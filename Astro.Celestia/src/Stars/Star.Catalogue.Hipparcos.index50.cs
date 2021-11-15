using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_50() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65562"},
        {"Hipparcos Number", "HIP 38998"},
        {"Geneva Identification System", "GEN# +1.00065562"},
        {"Smithsonian Astrophysical Observation", "SAO 153658"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.71788836),
        dec: Angle.Degrees(-13.31490016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18427"},
        {"Hipparcos Number", "HIP 13781"},
        {"Smithsonian Astrophysical Observation", "SAO 148683"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.34053047),
        dec: Angle.Degrees(-13.31423449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112790",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 58"},
        {"Henry Draper", "HD 216135"},
        {"Hipparcos Number", "HIP 112790"},
        {"Geneva Identification System", "GEN# +1.00216135"},
    },
    visualMagnitude: 10.11,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.61766725),
        dec: Angle.Degrees(-13.31228244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123984"},
        {"Hipparcos Number", "HIP 69306"},
        {"Geneva Identification System", "GEN# +1.00123984"},
        {"Smithsonian Astrophysical Observation", "SAO 158406"},
        {"Wilson Evans Batten Catalogue", "WEB 12088"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.78770371),
        dec: Angle.Degrees(-13.31067736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116961"},
        {"Hipparcos Number", "HIP 65623"},
        {"Geneva Identification System", "GEN# +1.00116961"},
        {"Smithsonian Astrophysical Observation", "SAO 157944"},
        {"Wilson Evans Batten Catalogue", "WEB 11610"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.81603218),
        dec: Angle.Degrees(-13.31053179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218732"},
        {"Hipparcos Number", "HIP 114426"},
        {"Geneva Identification System", "GEN# +1.00218732"},
        {"Smithsonian Astrophysical Observation", "SAO 165532"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.60580162),
        dec: Angle.Degrees(-13.30978894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2869"},
        {"Hipparcos Number", "HIP 2523"},
        {"Smithsonian Astrophysical Observation", "SAO 147324"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.99433200),
        dec: Angle.Degrees(-13.30942452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118797"},
        {"Hipparcos Number", "HIP 66616"},
        {"Geneva Identification System", "GEN# +1.00118797"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.81843053),
        dec: Angle.Degrees(-13.30921188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111945"},
        {"Hipparcos Number", "HIP 62868"},
        {"Smithsonian Astrophysical Observation", "SAO 157567"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.28017334),
        dec: Angle.Degrees(-13.30737511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78318"},
        {"Hipparcos Number", "HIP 44754"},
        {"Geneva Identification System", "GEN# +1.00078318"},
        {"Smithsonian Astrophysical Observation", "SAO 154920"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.81139921),
        dec: Angle.Degrees(-13.30725892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23917"},
        {"Hipparcos Number", "HIP 17787"},
        {"Smithsonian Astrophysical Observation", "SAO 149178"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.10776551),
        dec: Angle.Degrees(-13.30666227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80521"},
        {"Hipparcos Number", "HIP 45763"},
        {"Smithsonian Astrophysical Observation", "SAO 155098"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.97972137),
        dec: Angle.Degrees(-13.30583501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211676"},
        {"Hipparcos Number", "HIP 110179"},
        {"Geneva Identification System", "GEN# +1.00211676"},
        {"Smithsonian Astrophysical Observation", "SAO 164996"},
        {"Wilson Evans Batten Catalogue", "WEB 19774"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.75290198),
        dec: Angle.Degrees(-13.30497087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89351"},
        {"Hipparcos Number", "HIP 50476"},
        {"Geneva Identification System", "GEN# +1.00089351"},
        {"Smithsonian Astrophysical Observation", "SAO 155882"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.59891457),
        dec: Angle.Degrees(-13.30466640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223405"},
        {"Hipparcos Number", "HIP 117476"},
        {"Geneva Identification System", "GEN# +1.00223405"},
        {"Smithsonian Astrophysical Observation", "SAO 165903"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.31565686),
        dec: Angle.Degrees(-13.30419000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221265"},
        {"Hipparcos Number", "HIP 116041"},
        {"Smithsonian Astrophysical Observation", "SAO 165728"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.68988539),
        dec: Angle.Degrees(-13.30394151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108664"},
        {"Hipparcos Number", "HIP 60917"},
        {"Smithsonian Astrophysical Observation", "SAO 157319"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.27164855),
        dec: Angle.Degrees(-13.30076039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210172"},
        {"Hipparcos Number", "HIP 109316"},
        {"Geneva Identification System", "GEN# +1.00210172"},
        {"Smithsonian Astrophysical Observation", "SAO 164885"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.19738566),
        dec: Angle.Degrees(-13.30043723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98352"},
        {"Smithsonian Astrophysical Observation", "SAO 163154"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.73588896),
        dec: Angle.Degrees(-13.29917116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58076"},
        {"Hipparcos Number", "HIP 35849"},
        {"Smithsonian Astrophysical Observation", "SAO 152806"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.87190027),
        dec: Angle.Degrees(-13.29878675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104432"},
        {"Cincinnati Publication", "Ci 20 1261"},
        {"Geneva Identification System", "GEN# +6.10140918"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.32082857),
        dec: Angle.Degrees(-13.29765532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 710.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1995.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83374"},
        {"Hipparcos Number", "HIP 47235"},
        {"Geneva Identification System", "GEN# +1.00083374"},
        {"Smithsonian Astrophysical Observation", "SAO 155349"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.41490478),
        dec: Angle.Degrees(-13.29727431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87096"},
        {"Hipparcos Number", "HIP 49202"},
        {"Geneva Identification System", "GEN# +1.00087096"},
        {"Smithsonian Astrophysical Observation", "SAO 155680"},
        {"Wilson Evans Batten Catalogue", "WEB 9112"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.63860316),
        dec: Angle.Degrees(-13.29655814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46907"},
        {"Hipparcos Number", "HIP 31460"},
        {"Smithsonian Astrophysical Observation", "SAO 151671"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.85422111),
        dec: Angle.Degrees(-13.29563735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221450"},
        {"Hipparcos Number", "HIP 116178"},
        {"Smithsonian Astrophysical Observation", "SAO 165753"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.09546968),
        dec: Angle.Degrees(-13.29467961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15608"},
        {"Hipparcos Number", "HIP 11654"},
        {"Smithsonian Astrophysical Observation", "SAO 148428"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.57643068),
        dec: Angle.Degrees(-13.29458414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157585"},
        {"Hipparcos Number", "HIP 85208"},
        {"Geneva Identification System", "GEN# +1.00157585"},
        {"Smithsonian Astrophysical Observation", "SAO 160527"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17684871),
        dec: Angle.Degrees(-13.29433813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74218"},
        {"Hipparcos Number", "HIP 42718"},
        {"Smithsonian Astrophysical Observation", "SAO 154561"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.58824175),
        dec: Angle.Degrees(-13.29361265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14971"},
        {"Hipparcos Number", "HIP 11225"},
        {"Geneva Identification System", "GEN# +1.00014971"},
        {"Smithsonian Astrophysical Observation", "SAO 148375"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.11805109),
        dec: Angle.Degrees(-13.29310828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122701"},
        {"Hipparcos Number", "HIP 68696"},
        {"Smithsonian Astrophysical Observation", "SAO 158315"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.92764993),
        dec: Angle.Degrees(-13.28868031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26296"},
        {"Hipparcos Number", "HIP 19381"},
        {"Smithsonian Astrophysical Observation", "SAO 149408"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.27896584),
        dec: Angle.Degrees(-13.28791875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92469"},
        {"Hipparcos Number", "HIP 52244"},
        {"Smithsonian Astrophysical Observation", "SAO 156146"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.11050609),
        dec: Angle.Degrees(-13.28102097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28160"},
        {"Hipparcos Number", "HIP 20697"},
        {"Geneva Identification System", "GEN# +1.00028160"},
        {"Smithsonian Astrophysical Observation", "SAO 149627"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.50447813),
        dec: Angle.Degrees(-13.28034338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202606"},
        {"Hipparcos Number", "HIP 105079"},
        {"Geneva Identification System", "GEN# +1.00202606"},
        {"Renson", "Renson 56436"},
        {"Smithsonian Astrophysical Observation", "SAO 164279"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.30642811),
        dec: Angle.Degrees(-13.27897414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15689"},
    },
    visualMagnitude: 12.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.52321876),
        dec: Angle.Degrees(-13.27811998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -299.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20936"},
        {"Hipparcos Number", "HIP 15690"},
        {"Smithsonian Astrophysical Observation", "SAO 148922"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.52633508),
        dec: Angle.Degrees(-13.27308849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31091"},
        {"Hipparcos Number", "HIP 22657"},
        {"Smithsonian Astrophysical Observation", "SAO 149951"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.10220203),
        dec: Angle.Degrees(-13.27057046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220123"},
        {"Hipparcos Number", "HIP 115310"},
        {"Geneva Identification System", "GEN# +1.00220123"},
        {"Smithsonian Astrophysical Observation", "SAO 165643"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.31313883),
        dec: Angle.Degrees(-13.26937150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19850"},
        {"Hipparcos Number", "HIP 14797"},
        {"Geneva Identification System", "GEN# +1.00019850"},
        {"Smithsonian Astrophysical Observation", "SAO 148816"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.77194948),
        dec: Angle.Degrees(-13.26430421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6008"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.31461024),
        dec: Angle.Degrees(-13.26331464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 366.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8762 AB"},
        {"Hipparcos Number", "HIP 63789"},
        {"Geneva Identification System", "GEN# -0.01203747J"},
        {"Smithsonian Astrophysical Observation", "SAO 157698"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.11240569),
        dec: Angle.Degrees(-13.26271314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186522"},
        {"Hipparcos Number", "HIP 97217"},
        {"Smithsonian Astrophysical Observation", "SAO 162954"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.37109220),
        dec: Angle.Degrees(-13.26230103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182089"},
        {"Hipparcos Number", "HIP 95317"},
        {"Geneva Identification System", "GEN# +1.00182089"},
        {"Smithsonian Astrophysical Observation", "SAO 162559"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.88533191),
        dec: Angle.Degrees(-13.26136766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22856"},
        {"Hipparcos Number", "HIP 17100"},
        {"Smithsonian Astrophysical Observation", "SAO 149086"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.94531086),
        dec: Angle.Degrees(-13.25897066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29502"},
        {"Hipparcos Number", "HIP 21595"},
        {"Geneva Identification System", "GEN# +1.00029502"},
        {"Smithsonian Astrophysical Observation", "SAO 149780"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54812763),
        dec: Angle.Degrees(-13.25827382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19334"},
        {"Hipparcos Number", "HIP 14429"},
        {"Smithsonian Astrophysical Observation", "SAO 148768"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.56454956),
        dec: Angle.Degrees(-13.25765913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2966"},
        {"Hipparcos Number", "HIP 2586"},
        {"Geneva Identification System", "GEN# +1.00002966"},
        {"Smithsonian Astrophysical Observation", "SAO 147331"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.20832918),
        dec: Angle.Degrees(-13.25755041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73583"},
        {"Hipparcos Number", "HIP 42401"},
        {"Geneva Identification System", "GEN# +1.00073583"},
        {"Smithsonian Astrophysical Observation", "SAO 154490"},
        {"Wilson Evans Batten Catalogue", "WEB 8152"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.68874380),
        dec: Angle.Degrees(-13.25678613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77859"},
        {"Hipparcos Number", "HIP 44554"},
        {"Renson", "Renson 22045"},
        {"Smithsonian Astrophysical Observation", "SAO 154883"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.16724877),
        dec: Angle.Degrees(-13.25559861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2213"},
        {"Hipparcos Number", "HIP 2043"},
        {"Smithsonian Astrophysical Observation", "SAO 147269"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.48097222),
        dec: Angle.Degrees(-13.25522026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6764"},
        {"Hipparcos Number", "HIP 5331"},
        {"Smithsonian Astrophysical Observation", "SAO 147628"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04633102),
        dec: Angle.Degrees(-13.25494505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176745"},
        {"Hipparcos Number", "HIP 93478"},
        {"Smithsonian Astrophysical Observation", "SAO 162112"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.55591868),
        dec: Angle.Degrees(-13.25374718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208722"},
        {"Hipparcos Number", "HIP 108477"},
        {"Geneva Identification System", "GEN# +1.00208722"},
        {"Smithsonian Astrophysical Observation", "SAO 164780"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.62399888),
        dec: Angle.Degrees(-13.25215606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181314"},
        {"Hipparcos Number", "HIP 95061"},
        {"Smithsonian Astrophysical Observation", "SAO 162490"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.12556457),
        dec: Angle.Degrees(-13.25155177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8841"},
        {"Smithsonian Astrophysical Observation", "SAO 148087"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.41976021),
        dec: Angle.Degrees(-13.24965345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15554"},
        {"Hipparcos Number", "HIP 11614"},
        {"Smithsonian Astrophysical Observation", "SAO 148422"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.44889229),
        dec: Angle.Degrees(-13.24800338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4685 A"},
        {"Henry Draper", "HD 41666"},
        {"Hipparcos Number", "HIP 28886"},
        {"Geneva Identification System", "GEN# +1.00041666"},
        {"Renson", "Renson 11116"},
        {"Smithsonian Astrophysical Observation", "SAO 151106"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.48199888),
        dec: Angle.Degrees(-13.24779325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37152"},
        {"Hipparcos Number", "HIP 26288"},
        {"Smithsonian Astrophysical Observation", "SAO 150594"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.97312169),
        dec: Angle.Degrees(-13.24511380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56489"},
        {"Geneva Identification System", "GEN# -0.01203458"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.71080345),
        dec: Angle.Degrees(-13.24185412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -283.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18371"},
        {"Hipparcos Number", "HIP 13724"},
        {"Smithsonian Astrophysical Observation", "SAO 148678"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.19476437),
        dec: Angle.Degrees(-13.23874824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21906"},
        {"Geneva Identification System", "GEN# -0.01300959A"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.65653638),
        dec: Angle.Degrees(-13.23839490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165546"},
        {"Hipparcos Number", "HIP 88748"},
        {"Smithsonian Astrophysical Observation", "SAO 161085"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.75960163),
        dec: Angle.Degrees(-13.23587207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11389"},
        {"Hipparcos Number", "HIP 8672"},
        {"Smithsonian Astrophysical Observation", "SAO 148066"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91701501),
        dec: Angle.Degrees(-13.23381942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22050"},
        {"Hipparcos Number", "HIP 16535"},
        {"Geneva Identification System", "GEN# +1.00022050"},
        {"Smithsonian Astrophysical Observation", "SAO 149026"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.23262187),
        dec: Angle.Degrees(-13.23365573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43580",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7062 A"},
        {"Henry Draper", "HD 75916"},
        {"Hipparcos Number", "HIP 43580"},
        {"Geneva Identification System", "GEN# +1.00075916"},
        {"Smithsonian Astrophysical Observation", "SAO 154704"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.12810256),
        dec: Angle.Degrees(-13.23294424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50091"},
        {"Hipparcos Number", "HIP 32876"},
        {"Geneva Identification System", "GEN# +1.00050091"},
        {"Smithsonian Astrophysical Observation", "SAO 152006"},
        {"Wilson Evans Batten Catalogue", "WEB 6616"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.75982629),
        dec: Angle.Degrees(-13.23176997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 713 AB"},
        {"Henry Draper", "HD 5041"},
        {"Hipparcos Number", "HIP 4066"},
        {"Geneva Identification System", "GEN# +1.00005041"},
        {"Smithsonian Astrophysical Observation", "SAO 147487"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.03228479),
        dec: Angle.Degrees(-13.23029503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45095"},
        {"Hipparcos Number", "HIP 30521"},
        {"Geneva Identification System", "GEN# +1.00045095"},
        {"Smithsonian Astrophysical Observation", "SAO 151471"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.22480792),
        dec: Angle.Degrees(-13.23028053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 287"},
        {"Smithsonian Astrophysical Observation", "SAO 147056"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.88580553),
        dec: Angle.Degrees(-13.22726530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9118"},
        {"Hipparcos Number", "HIP 6965"},
        {"Geneva Identification System", "GEN# +1.00009118"},
        {"Smithsonian Astrophysical Observation", "SAO 147841"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42102571),
        dec: Angle.Degrees(-13.22364932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26624"},
        {"Hipparcos Number", "HIP 19608"},
        {"Geneva Identification System", "GEN# +1.00026624"},
        {"Renson", "Renson 6803"},
        {"Smithsonian Astrophysical Observation", "SAO 149448"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.02245069),
        dec: Angle.Degrees(-13.22309539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42725"},
        {"Hipparcos Number", "HIP 29409"},
        {"Smithsonian Astrophysical Observation", "SAO 151207"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.95332760),
        dec: Angle.Degrees(-13.22195989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101731"},
        {"Hipparcos Number", "HIP 57102"},
        {"Geneva Identification System", "GEN# +1.00101731"},
        {"Smithsonian Astrophysical Observation", "SAO 156841"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.58150766),
        dec: Angle.Degrees(-13.22117272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42282"},
        {"Hipparcos Number", "HIP 29174"},
        {"Fundamental Katalog 5th Edition", "FK5 4562"},
        {"Geneva Identification System", "GEN# +1.00042282"},
        {"Smithsonian Astrophysical Observation", "SAO 151168"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.31331659),
        dec: Angle.Degrees(-13.22078746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53012"},
        {"Hipparcos Number", "HIP 33973"},
        {"Geneva Identification System", "GEN# +1.00053012"},
        {"Smithsonian Astrophysical Observation", "SAO 152286"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.72951984),
        dec: Angle.Degrees(-13.21789457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135637"},
        {"Hipparcos Number", "HIP 74743"},
        {"Geneva Identification System", "GEN# +1.00135637"},
        {"Smithsonian Astrophysical Observation", "SAO 159140"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.13077241),
        dec: Angle.Degrees(-13.21730540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56925"},
        {"Hipparcos Number", "HIP 35378"},
        {"Geneva Identification System", "GEN# +1.00056925"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.62138909),
        dec: Angle.Degrees(-13.21709370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14492 AB"},
        {"Henry Draper", "HD 199668"},
        {"Hipparcos Number", "HIP 103574"},
        {"Geneva Identification System", "GEN# +1.00199668J"},
        {"Smithsonian Astrophysical Observation", "SAO 164036"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77240693),
        dec: Angle.Degrees(-13.21571575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8954 AB"},
        {"Henry Draper", "HD 118054"},
        {"Hipparcos Number", "HIP 66247"},
        {"Geneva Identification System", "GEN# +1.00118054"},
        {"Renson", "Renson 34040"},
        {"Smithsonian Astrophysical Observation", "SAO 158021"},
        {"Wilson Evans Batten Catalogue", "WEB 11706"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.66866043),
        dec: Angle.Degrees(-13.21430591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173138"},
        {"Hipparcos Number", "HIP 91929"},
        {"Wilson Evans Batten Catalogue", "WEB 15829"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.10487948),
        dec: Angle.Degrees(-13.21323208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10509"},
        {"Hipparcos Number", "HIP 7962"},
        {"Geneva Identification System", "GEN# +1.00010509"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.56196808),
        dec: Angle.Degrees(-13.21227603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26003"},
        {"Hipparcos Number", "HIP 19162"},
        {"Smithsonian Astrophysical Observation", "SAO 149374"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.63578748),
        dec: Angle.Degrees(-13.21088968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98786"},
        {"Hipparcos Number", "HIP 55500"},
        {"Smithsonian Astrophysical Observation", "SAO 156629"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.49385109),
        dec: Angle.Degrees(-13.21077540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21571"},
        {"Hipparcos Number", "HIP 16182"},
        {"Smithsonian Astrophysical Observation", "SAO 148974"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.11447679),
        dec: Angle.Degrees(-13.20920591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48889"},
        {"Hipparcos Number", "HIP 32347"},
        {"Smithsonian Astrophysical Observation", "SAO 151878"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.27999554),
        dec: Angle.Degrees(-13.20779533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9438 AB"},
        {"Henry Draper", "HD 131771"},
        {"Hipparcos Number", "HIP 73055"},
        {"Smithsonian Astrophysical Observation", "SAO 158900"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.94695158),
        dec: Angle.Degrees(-13.20600975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92022"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.35223357),
        dec: Angle.Degrees(-13.20522558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38533"},
        {"Hipparcos Number", "HIP 27202"},
        {"Smithsonian Astrophysical Observation", "SAO 150782"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.48891932),
        dec: Angle.Degrees(-13.20387062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66491"},
        {"Hipparcos Number", "HIP 39409"},
        {"Smithsonian Astrophysical Observation", "SAO 153761"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.84956986),
        dec: Angle.Degrees(-13.20366013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198694"},
        {"Hipparcos Number", "HIP 103037"},
        {"Smithsonian Astrophysical Observation", "SAO 163946"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.12931682),
        dec: Angle.Degrees(-13.20295230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202407"},
        {"Hipparcos Number", "HIP 105002"},
        {"Smithsonian Astrophysical Observation", "SAO 164265"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.99836668),
        dec: Angle.Degrees(-13.20253228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101198"},
        {"Hipparcos Number", "HIP 56802"},
        {"Geneva Identification System", "GEN# +1.00101198"},
        {"Smithsonian Astrophysical Observation", "SAO 156802"},
        {"Wilson Evans Batten Catalogue", "WEB 10226"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.66648767),
        dec: Angle.Degrees(-13.20224958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191902"},
        {"Hipparcos Number", "HIP 99593"},
        {"Geneva Identification System", "GEN# +1.00191902"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.17350370),
        dec: Angle.Degrees(-13.20112361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55066"},
        {"Hipparcos Number", "HIP 34682"},
        {"Geneva Identification System", "GEN# +1.00055066"},
        {"Smithsonian Astrophysical Observation", "SAO 152517"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.73792847),
        dec: Angle.Degrees(-13.20079875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83126",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10286 AB"},
        {"Henry Draper", "HD 153315"},
        {"Hipparcos Number", "HIP 83126"},
    },
    visualMagnitude: 8.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.82021652),
        dec: Angle.Degrees(-13.19867190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10985"},
        {"Hipparcos Number", "HIP 8360"},
        {"Smithsonian Astrophysical Observation", "SAO 148013"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.92952623),
        dec: Angle.Degrees(-13.19774974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82942"},
        {"Smithsonian Astrophysical Observation", "SAO 160181"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.24023336),
        dec: Angle.Degrees(-13.19708000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48573"},
        {"Hipparcos Number", "HIP 32216"},
        {"Smithsonian Astrophysical Observation", "SAO 151846"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.88694179),
        dec: Angle.Degrees(-13.19600194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88076"},
        {"Hipparcos Number", "HIP 49717"},
        {"Smithsonian Astrophysical Observation", "SAO 155768"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.26075901),
        dec: Angle.Degrees(-13.19575495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115680"},
        {"Hipparcos Number", "HIP 64952"},
        {"Smithsonian Astrophysical Observation", "SAO 157847"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.70689682),
        dec: Angle.Degrees(-13.19567525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127435"},
        {"Hipparcos Number", "HIP 71044"},
        {"Fundamental Katalog 5th Edition", "FK5 5283"},
        {"Geneva Identification System", "GEN# +1.00127435"},
        {"Smithsonian Astrophysical Observation", "SAO 158620"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.94566967),
        dec: Angle.Degrees(-13.19178815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136276"},
        {"Hipparcos Number", "HIP 75050"},
        {"Geneva Identification System", "GEN# +1.00136276"},
        {"Smithsonian Astrophysical Observation", "SAO 159180"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.03912514),
        dec: Angle.Degrees(-13.19163383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50705"},
        {"Hipparcos Number", "HIP 33113"},
        {"Smithsonian Astrophysical Observation", "SAO 152066"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.45200721),
        dec: Angle.Degrees(-13.19137773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222846"},
        {"Hipparcos Number", "HIP 117085"},
        {"Smithsonian Astrophysical Observation", "SAO 165853"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.04518689),
        dec: Angle.Degrees(-13.19025781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52968"},
        {"Hipparcos Number", "HIP 33948"},
        {"Celescope Catalog", "CEL 1524"},
        {"Geneva Identification System", "GEN# +1.00052968"},
        {"Smithsonian Astrophysical Observation", "SAO 152276"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.66844375),
        dec: Angle.Degrees(-13.18975374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58791"},
        {"Hipparcos Number", "HIP 36134"},
        {"Celescope Catalog", "CEL 1852"},
        {"Geneva Identification System", "GEN# +1.00058791"},
        {"Renson", "Renson 16052"},
        {"Smithsonian Astrophysical Observation", "SAO 152878"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.64928274),
        dec: Angle.Degrees(-13.18897894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8878 A"},
        {"Henry Draper", "HD 116275"},
        {"Hipparcos Number", "HIP 65283"},
        {"Geneva Identification System", "GEN# +1.00116275A"},
        {"Renson", "Renson 33553"},
        {"Smithsonian Astrophysical Observation", "SAO 157895"},
        {"Wilson Evans Batten Catalogue", "WEB 11521"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.69025766),
        dec: Angle.Degrees(-13.18650585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50737"},
        {"Hipparcos Number", "HIP 33119"},
        {"Smithsonian Astrophysical Observation", "SAO 152068"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.46736676),
        dec: Angle.Degrees(-13.18586415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212447"},
        {"Hipparcos Number", "HIP 110611"},
        {"Smithsonian Astrophysical Observation", "SAO 165049"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.13769360),
        dec: Angle.Degrees(-13.18483887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27113"},
        {"Hipparcos Number", "HIP 19922"},
        {"Smithsonian Astrophysical Observation", "SAO 149501"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.12129283),
        dec: Angle.Degrees(-13.18427826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196347"},
        {"Hipparcos Number", "HIP 101734"},
        {"Geneva Identification System", "GEN# +1.00196347"},
        {"Smithsonian Astrophysical Observation", "SAO 163736"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.31073342),
        dec: Angle.Degrees(-13.18422926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101321"},
        {"Hipparcos Number", "HIP 56864"},
        {"Smithsonian Astrophysical Observation", "SAO 156815"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.87547337),
        dec: Angle.Degrees(-13.18402025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219452"},
        {"Hipparcos Number", "HIP 114854"},
        {"Geneva Identification System", "GEN# +1.00219452"},
        {"Smithsonian Astrophysical Observation", "SAO 165595"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.96903539),
        dec: Angle.Degrees(-13.18389295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125756"},
        {"Hipparcos Number", "HIP 70208"},
        {"Smithsonian Astrophysical Observation", "SAO 158516"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.46424085),
        dec: Angle.Degrees(-13.18231797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80449",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10047 AB"},
        {"Henry Draper", "HD 147954"},
        {"Hipparcos Number", "HIP 80449"},
        {"Smithsonian Astrophysical Observation", "SAO 159907"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.32921891),
        dec: Angle.Degrees(-13.17938982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75116"},
        {"Cincinnati Publication", "Ci 20 927"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.24757684),
        dec: Angle.Degrees(-13.17836115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -595.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34816"},
        {"Hipparcos Number", "HIP 24845"},
        {"Fundamental Katalog 5th Edition", "FK5 1146"},
        {"Geneva Identification System", "GEN# +1.00034816"},
        {"Smithsonian Astrophysical Observation", "SAO 150340"},
        {"Wilson Evans Batten Catalogue", "WEB 4815"},
    },
    visualMagnitude: 4.29,
    bvColour: -0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.89385817),
        dec: Angle.Degrees(-13.17677698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 358328"},
        {"Hipparcos Number", "HIP 104493"},
        {"Geneva Identification System", "GEN# -0.01305865"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50925816),
        dec: Angle.Degrees(-13.17663262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184890"},
        {"Hipparcos Number", "HIP 96495"},
        {"Smithsonian Astrophysical Observation", "SAO 162820"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.25927604),
        dec: Angle.Degrees(-13.17295880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3249"},
        {"Wilson Evans Batten Catalogue", "WEB 582"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.35092555),
        dec: Angle.Degrees(-13.17231358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22134"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.44831751),
        dec: Angle.Degrees(-13.17060387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143111"},
        {"Hipparcos Number", "HIP 78271"},
        {"Smithsonian Astrophysical Observation", "SAO 159616"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.73717622),
        dec: Angle.Degrees(-13.16968734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1898"},
        {"Hipparcos Number", "HIP 1831"},
        {"Geneva Identification System", "GEN# +1.00001898"},
        {"Smithsonian Astrophysical Observation", "SAO 147243"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.80281494),
        dec: Angle.Degrees(-13.16813155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77199"},
        {"Hipparcos Number", "HIP 44249"},
        {"Smithsonian Astrophysical Observation", "SAO 154831"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.16691156),
        dec: Angle.Degrees(-13.16731602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45629"},
        {"Hipparcos Number", "HIP 30776"},
        {"Geneva Identification System", "GEN# +1.00045629"},
        {"Smithsonian Astrophysical Observation", "SAO 151530"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.99596340),
        dec: Angle.Degrees(-13.16058121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115368"},
        {"Hipparcos Number", "HIP 64808"},
        {"Fundamental Katalog 5th Edition", "FK5 5171"},
        {"Smithsonian Astrophysical Observation", "SAO 157831"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.24363302),
        dec: Angle.Degrees(-13.15881054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40192"},
        {"Hipparcos Number", "HIP 28128"},
        {"Geneva Identification System", "GEN# +1.00040192"},
        {"Smithsonian Astrophysical Observation", "SAO 150962"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.18395193),
        dec: Angle.Degrees(-13.15849552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118331"},
        {"Hipparcos Number", "HIP 66377"},
        {"Smithsonian Astrophysical Observation", "SAO 158038"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.11839799),
        dec: Angle.Degrees(-13.15673633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85354"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.62530175),
        dec: Angle.Degrees(-13.15632161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6956"},
        {"Smithsonian Astrophysical Observation", "SAO 147840"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.38420319),
        dec: Angle.Degrees(-13.15546378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19075"},
        {"Hipparcos Number", "HIP 14252"},
        {"Smithsonian Astrophysical Observation", "SAO 148741"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.95023296),
        dec: Angle.Degrees(-13.15252164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224172"},
        {"Hipparcos Number", "HIP 117978"},
        {"Geneva Identification System", "GEN# +1.00224172"},
        {"Smithsonian Astrophysical Observation", "SAO 165956"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.94046344),
        dec: Angle.Degrees(-13.15240762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73145"},
        {"Hipparcos Number", "HIP 42213"},
        {"Geneva Identification System", "GEN# +1.00073145"},
        {"Smithsonian Astrophysical Observation", "SAO 154443"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09559162),
        dec: Angle.Degrees(-13.15137262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10669"},
        {"Hipparcos Number", "HIP 8095"},
        {"Smithsonian Astrophysical Observation", "SAO 147984"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.98020898),
        dec: Angle.Degrees(-13.15010690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15971"},
        {"Hipparcos Number", "HIP 11910"},
        {"Geneva Identification System", "GEN# +1.00015971"},
        {"Smithsonian Astrophysical Observation", "SAO 148467"},
        {"Wilson Evans Batten Catalogue", "WEB 2465"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.43192664),
        dec: Angle.Degrees(-13.14841756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31024",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5148 A"},
        {"Henry Draper", "HD 46064"},
        {"Hipparcos Number", "HIP 31024"},
        {"Geneva Identification System", "GEN# +1.00046064A"},
        {"Smithsonian Astrophysical Observation", "SAO 151585"},
        {"Wilson Evans Batten Catalogue", "WEB 6176"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.64536676),
        dec: Angle.Degrees(-13.14817605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53544"},
        {"Hipparcos Number", "HIP 34149"},
        {"Smithsonian Astrophysical Observation", "SAO 152335"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.21813120),
        dec: Angle.Degrees(-13.14736680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164485"},
        {"Hipparcos Number", "HIP 88301"},
        {"Renson", "Renson 46490"},
        {"Smithsonian Astrophysical Observation", "SAO 161010"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.48586341),
        dec: Angle.Degrees(-13.14731872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156804"},
        {"Hipparcos Number", "HIP 84823"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.04829147),
        dec: Angle.Degrees(-13.14469026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197366"},
        {"Hipparcos Number", "HIP 102288"},
        {"Smithsonian Astrophysical Observation", "SAO 163829"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.89111098),
        dec: Angle.Degrees(-13.14189544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110682"},
        {"Hipparcos Number", "HIP 62125"},
        {"Geneva Identification System", "GEN# +1.00110682"},
        {"Smithsonian Astrophysical Observation", "SAO 157476"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.98298747),
        dec: Angle.Degrees(-13.14189403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12521"},
        {"Hipparcos Number", "HIP 9531"},
        {"Smithsonian Astrophysical Observation", "SAO 148165"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.64148963),
        dec: Angle.Degrees(-13.14154998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59404"},
        {"Hipparcos Number", "HIP 36390"},
        {"Smithsonian Astrophysical Observation", "SAO 152942"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.33104462),
        dec: Angle.Degrees(-13.13916138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50073"},
        {"Geneva Identification System", "GEN# -0.01203114"},
        {"Wilson Evans Batten Catalogue", "WEB 9206"},
    },
    visualMagnitude: 10.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.35054689),
        dec: Angle.Degrees(-13.13811898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181534"},
        {"Hipparcos Number", "HIP 95136"},
        {"Smithsonian Astrophysical Observation", "SAO 162506"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.33019866),
        dec: Angle.Degrees(-13.13629536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66738"},
        {"Hipparcos Number", "HIP 39504"},
        {"Geneva Identification System", "GEN# +1.00066738"},
        {"Smithsonian Astrophysical Observation", "SAO 153785"},
        {"Wilson Evans Batten Catalogue", "WEB 7723"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.11843289),
        dec: Angle.Degrees(-13.13593526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40071"},
        {"Hipparcos Number", "HIP 28073"},
        {"Geneva Identification System", "GEN# +1.00040071"},
        {"Renson", "Renson 10680"},
        {"Smithsonian Astrophysical Observation", "SAO 150950"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.02551350),
        dec: Angle.Degrees(-13.13533531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144840"},
        {"Hipparcos Number", "HIP 79066"},
        {"Geneva Identification System", "GEN# +1.00144840A"},
        {"Smithsonian Astrophysical Observation", "SAO 159729"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.10218467),
        dec: Angle.Degrees(-13.13480867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144639"},
        {"Hipparcos Number", "HIP 78981"},
        {"Geneva Identification System", "GEN# +1.00144639"},
        {"Smithsonian Astrophysical Observation", "SAO 159711"},
        {"Wilson Evans Batten Catalogue", "WEB 13348"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.83438631),
        dec: Angle.Degrees(-13.13461163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63263",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8717 AB"},
        {"Henry Draper", "HD 112574"},
        {"Hipparcos Number", "HIP 63263"},
        {"Wilson Evans Batten Catalogue", "WEB 11212"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.45595116),
        dec: Angle.Degrees(-13.13439886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90387"},
        {"Hipparcos Number", "HIP 51054"},
        {"Geneva Identification System", "GEN# +1.00090387"},
        {"Smithsonian Astrophysical Observation", "SAO 155977"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.46618313),
        dec: Angle.Degrees(-13.13277555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35643"},
        {"Hipparcos Number", "HIP 25371"},
        {"Geneva Identification System", "GEN# +1.00035643"},
        {"Smithsonian Astrophysical Observation", "SAO 150432"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.41279244),
        dec: Angle.Degrees(-13.13213847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182703"},
        {"Hipparcos Number", "HIP 95579"},
        {"Smithsonian Astrophysical Observation", "SAO 162617"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61379246),
        dec: Angle.Degrees(-13.13191520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79804"},
        {"Hipparcos Number", "HIP 45445"},
        {"Fundamental Katalog 5th Edition", "FK5 4823"},
        {"Smithsonian Astrophysical Observation", "SAO 155039"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.92092249),
        dec: Angle.Degrees(-13.13126481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152557"},
        {"Hipparcos Number", "HIP 82728"},
        {"Smithsonian Astrophysical Observation", "SAO 160158"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.63992385),
        dec: Angle.Degrees(-13.13032549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92547"},
        {"Hipparcos Number", "HIP 52276"},
        {"Geneva Identification System", "GEN# +1.00092547"},
        {"Smithsonian Astrophysical Observation", "SAO 156157"},
        {"Wilson Evans Batten Catalogue", "WEB 9519"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.23354672),
        dec: Angle.Degrees(-13.12957147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16434"},
        {"Hipparcos Number", "HIP 12260"},
        {"Geneva Identification System", "GEN# +1.00016434"},
        {"Smithsonian Astrophysical Observation", "SAO 148511"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.46145764),
        dec: Angle.Degrees(-13.12945162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86421"},
        {"Hipparcos Number", "HIP 48877"},
        {"Smithsonian Astrophysical Observation", "SAO 155628"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.53355818),
        dec: Angle.Degrees(-13.12911005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154896"},
        {"Hipparcos Number", "HIP 83898"},
        {"Smithsonian Astrophysical Observation", "SAO 160312"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.20131311),
        dec: Angle.Degrees(-13.12697829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55611"},
        {"Hipparcos Number", "HIP 34884"},
        {"Smithsonian Astrophysical Observation", "SAO 152571"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.27461655),
        dec: Angle.Degrees(-13.12613907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43708"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)54, 05.3300),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)07, 25.100)
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
    primaryId: "HIP 23777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32996"},
        {"Hipparcos Number", "HIP 23777"},
        {"Geneva Identification System", "GEN# +1.00032996"},
        {"Renson", "Renson 8442"},
        {"Smithsonian Astrophysical Observation", "SAO 150149"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.65304818),
        dec: Angle.Degrees(-13.12265846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15322 ABC"},
        {"Henry Draper", "HD 207171"},
        {"Hipparcos Number", "HIP 107588"},
        {"Smithsonian Astrophysical Observation", "SAO 164652"},
    },
    visualMagnitude: 8.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.86171797),
        dec: Angle.Degrees(-13.12164848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130463"},
        {"Hipparcos Number", "HIP 72442"},
        {"Smithsonian Astrophysical Observation", "SAO 158815"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.20395286),
        dec: Angle.Degrees(-13.11942559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114062"},
        {"Hipparcos Number", "HIP 64093"},
        {"Renson", "Renson 33024"},
        {"Smithsonian Astrophysical Observation", "SAO 157742"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.02598871),
        dec: Angle.Degrees(-13.11809228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148744"},
        {"Hipparcos Number", "HIP 80857"},
        {"Smithsonian Astrophysical Observation", "SAO 159958"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67255502),
        dec: Angle.Degrees(-13.11615619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107730"},
        {"Hipparcos Number", "HIP 60372"},
        {"Smithsonian Astrophysical Observation", "SAO 157247"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.69117441),
        dec: Angle.Degrees(-13.11553343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4940"},
        {"Hipparcos Number", "HIP 3990"},
        {"Smithsonian Astrophysical Observation", "SAO 147479"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.82127934),
        dec: Angle.Degrees(-13.11461946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97144"},
        {"Hipparcos Number", "HIP 54623"},
        {"Smithsonian Astrophysical Observation", "SAO 156513"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.70675355),
        dec: Angle.Degrees(-13.11434892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120011"},
        {"Hipparcos Number", "HIP 67254"},
        {"Smithsonian Astrophysical Observation", "SAO 158160"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.76900317),
        dec: Angle.Degrees(-13.11223676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223541"},
        {"Hipparcos Number", "HIP 117563"},
        {"Smithsonian Astrophysical Observation", "SAO 165914"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.62807127),
        dec: Angle.Degrees(-13.11059730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120543"},
        {"Hipparcos Number", "HIP 67541"},
        {"Smithsonian Astrophysical Observation", "SAO 158190"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.58701775),
        dec: Angle.Degrees(-13.11023721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90791"},
        {"Wilson Evans Batten Catalogue", "WEB 15558"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.83228214),
        dec: Angle.Degrees(-13.10817004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147268"},
        {"Hipparcos Number", "HIP 80129"},
        {"Geneva Identification System", "GEN# +1.00147268"},
        {"Smithsonian Astrophysical Observation", "SAO 159873"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.33689750),
        dec: Angle.Degrees(-13.10589677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99623"},
        {"Hipparcos Number", "HIP 55910"},
        {"Smithsonian Astrophysical Observation", "SAO 156691"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.90092821),
        dec: Angle.Degrees(-13.10572607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148376"},
        {"Hipparcos Number", "HIP 80658"},
        {"Smithsonian Astrophysical Observation", "SAO 159928"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.01075672),
        dec: Angle.Degrees(-13.10292663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175773"},
        {"Hipparcos Number", "HIP 93065"},
        {"Smithsonian Astrophysical Observation", "SAO 162019"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.35667285),
        dec: Angle.Degrees(-13.10133496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156228"},
        {"Hipparcos Number", "HIP 84544"},
        {"Geneva Identification System", "GEN# +1.00156228"},
        {"Smithsonian Astrophysical Observation", "SAO 160424"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.25092118),
        dec: Angle.Degrees(-13.10111643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216423"},
        {"Hipparcos Number", "HIP 112980"},
        {"Smithsonian Astrophysical Observation", "SAO 165354"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20506992),
        dec: Angle.Degrees(-13.09964589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89149"},
        {"Hipparcos Number", "HIP 50344"},
        {"Geneva Identification System", "GEN# +1.00089149"},
        {"Smithsonian Astrophysical Observation", "SAO 155866"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.19524586),
        dec: Angle.Degrees(-13.09948724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37779"},
    },
    visualMagnitude: 11.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19496398),
        dec: Angle.Degrees(-13.09897462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53267"},
        {"Hipparcos Number", "HIP 34058"},
        {"Geneva Identification System", "GEN# +1.00053267"},
        {"Smithsonian Astrophysical Observation", "SAO 152307"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.97283440),
        dec: Angle.Degrees(-13.09696095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52984"},
        {"Hipparcos Number", "HIP 33960"},
        {"Celescope Catalog", "CEL 1527"},
        {"Geneva Identification System", "GEN# +1.00052984"},
        {"Smithsonian Astrophysical Observation", "SAO 152282"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.70112925),
        dec: Angle.Degrees(-13.09584877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88010",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10938 AB"},
        {"Henry Draper", "HD 163810"},
        {"Hipparcos Number", "HIP 88010"},
        {"Cincinnati Publication", "Ci 20 1070"},
        {"Geneva Identification System", "GEN# +1.00163810J"},
        {"Smithsonian Astrophysical Observation", "SAO 160955"},
        {"Wilson Evans Batten Catalogue", "WEB 14865"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66135928),
        dec: Angle.Degrees(-13.09534036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -456.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -734.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197197"},
        {"Hipparcos Number", "HIP 102211"},
        {"Geneva Identification System", "GEN# +1.00197197"},
        {"Smithsonian Astrophysical Observation", "SAO 163813"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.65529273),
        dec: Angle.Degrees(-13.09443155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84284"},
        {"Hipparcos Number", "HIP 47738"},
        {"Smithsonian Astrophysical Observation", "SAO 155436"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.97511883),
        dec: Angle.Degrees(-13.09110597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32266"},
        {"Hipparcos Number", "HIP 23352"},
        {"Smithsonian Astrophysical Observation", "SAO 150080"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.33324172),
        dec: Angle.Degrees(-13.08938876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156954"},
        {"Hipparcos Number", "HIP 84895"},
        {"Geneva Identification System", "GEN# +1.00156954"},
        {"Smithsonian Astrophysical Observation", "SAO 160483"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.25147087),
        dec: Angle.Degrees(-13.08534120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17908"},
        {"Hipparcos Number", "HIP 13383"},
        {"Smithsonian Astrophysical Observation", "SAO 148644"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.05480665),
        dec: Angle.Degrees(-13.08469831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151785"},
        {"Hipparcos Number", "HIP 82374"},
        {"Smithsonian Astrophysical Observation", "SAO 160119"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.49381112),
        dec: Angle.Degrees(-13.07958918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2238"},
        {"Hipparcos Number", "HIP 2062"},
        {"Smithsonian Astrophysical Observation", "SAO 147271"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.52561579),
        dec: Angle.Degrees(-13.07783308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104639"},
        {"Hipparcos Number", "HIP 58749"},
        {"Smithsonian Astrophysical Observation", "SAO 157060"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.74202414),
        dec: Angle.Degrees(-13.07490843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8293"},
        {"Hipparcos Number", "HIP 6391"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53253664),
        dec: Angle.Degrees(-13.07428421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68855",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9104 A"},
        {"Henry Draper", "HD 123103"},
        {"Hipparcos Number", "HIP 68855"},
        {"Geneva Identification System", "GEN# +1.00123103"},
        {"Smithsonian Astrophysical Observation", "SAO 158344"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48910268),
        dec: Angle.Degrees(-13.07364729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128597"},
        {"Hipparcos Number", "HIP 71566"},
        {"Geneva Identification System", "GEN# +1.00128597"},
        {"Smithsonian Astrophysical Observation", "SAO 158688"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.54797039),
        dec: Angle.Degrees(-13.07306379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -290.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217251"},
        {"Hipparcos Number", "HIP 113531"},
        {"Geneva Identification System", "GEN# +1.00217251"},
        {"Smithsonian Astrophysical Observation", "SAO 165425"},
        {"Wilson Evans Batten Catalogue", "WEB 20184"},
    },
    visualMagnitude: 6.12,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.89865503),
        dec: Angle.Degrees(-13.07089129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55211"},
        {"Hipparcos Number", "HIP 34731"},
        {"Celescope Catalog", "CEL 1652"},
        {"Geneva Identification System", "GEN# +1.00055211"},
        {"Smithsonian Astrophysical Observation", "SAO 152531"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.86688371),
        dec: Angle.Degrees(-13.07060462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9104 B"},
        {"Henry Draper", "HD 123102"},
        {"Hipparcos Number", "HIP 68856"},
        {"Smithsonian Astrophysical Observation", "SAO 158345"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48958729),
        dec: Angle.Degrees(-13.06990170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18720"},
        {"Hipparcos Number", "HIP 13995"},
        {"Geneva Identification System", "GEN# +1.00018720"},
        {"Smithsonian Astrophysical Observation", "SAO 148710"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.04707106),
        dec: Angle.Degrees(-13.06561024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171249"},
        {"Hipparcos Number", "HIP 91037"},
        {"Smithsonian Astrophysical Observation", "SAO 161618"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.56568016),
        dec: Angle.Degrees(-13.06482046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87504"},
        {"Hipparcos Number", "HIP 49402"},
        {"Fundamental Katalog 5th Edition", "FK5 1261"},
        {"Geneva Identification System", "GEN# +1.00087504"},
        {"Smithsonian Astrophysical Observation", "SAO 155713"},
        {"Wilson Evans Batten Catalogue", "WEB 9127"},
    },
    visualMagnitude: 4.60,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.28121856),
        dec: Angle.Degrees(-13.06467435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60993"},
        {"Hipparcos Number", "HIP 37040"},
        {"Geneva Identification System", "GEN# +1.00060993"},
        {"Smithsonian Astrophysical Observation", "SAO 153144"},
        {"Wilson Evans Batten Catalogue", "WEB 7348"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.17623734),
        dec: Angle.Degrees(-13.06386742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96330"},
        {"Hipparcos Number", "HIP 54278"},
        {"Smithsonian Astrophysical Observation", "SAO 156457"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.55263892),
        dec: Angle.Degrees(-13.06374967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1594"},
        {"Hipparcos Number", "HIP 1611"},
        {"Geneva Identification System", "GEN# +1.00001594"},
        {"Smithsonian Astrophysical Observation", "SAO 147223"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.04383611),
        dec: Angle.Degrees(-13.06149298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1295"},
        {"Hipparcos Number", "HIP 1362"},
        {"Smithsonian Astrophysical Observation", "SAO 147200"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.26389977),
        dec: Angle.Degrees(-13.06108677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16878 A"},
        {"Henry Draper", "HD 222093"},
        {"Hipparcos Number", "HIP 116591"},
        {"Geneva Identification System", "GEN# +1.00222093A"},
        {"Smithsonian Astrophysical Observation", "SAO 165804"},
        {"Wilson Evans Batten Catalogue", "WEB 20583"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.41474582),
        dec: Angle.Degrees(-13.06030596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51361"},
        {"Hipparcos Number", "HIP 33376"},
        {"Geneva Identification System", "GEN# +1.00051361"},
    },
    visualMagnitude: 10.23,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.12622481),
        dec: Angle.Degrees(-13.05937400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116832"},
        {"Hipparcos Number", "HIP 65553"},
        {"Smithsonian Astrophysical Observation", "SAO 157935"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.59241691),
        dec: Angle.Degrees(-13.05660074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8829"},
        {"Hipparcos Number", "HIP 6748"},
        {"Fundamental Katalog 5th Edition", "FK5 1041"},
        {"Geneva Identification System", "GEN# +1.00008829"},
        {"Renson", "Renson 2130"},
        {"Smithsonian Astrophysical Observation", "SAO 147812"},
        {"Wilson Evans Batten Catalogue", "WEB 1473"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.71481835),
        dec: Angle.Degrees(-13.05653391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140269"},
        {"Hipparcos Number", "HIP 76982"},
        {"Geneva Identification System", "GEN# +1.00140269"},
        {"Smithsonian Astrophysical Observation", "SAO 159458"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.78621868),
        dec: Angle.Degrees(-13.05608549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70673"},
        {"Hipparcos Number", "HIP 41067"},
        {"Geneva Identification System", "GEN# +1.00070673"},
        {"Smithsonian Astrophysical Observation", "SAO 154177"},
        {"Wilson Evans Batten Catalogue", "WEB 7957"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.69529395),
        dec: Angle.Degrees(-13.05467864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1114"},
        {"Hipparcos Number", "HIP 1237"},
        {"Geneva Identification System", "GEN# +1.00001114"},
        {"Renson", "Renson 220"},
        {"Smithsonian Astrophysical Observation", "SAO 147181"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.85228554),
        dec: Angle.Degrees(-13.05439848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134630"},
        {"Hipparcos Number", "HIP 74301"},
        {"Fundamental Katalog 5th Edition", "FK5 5348"},
        {"Smithsonian Astrophysical Observation", "SAO 159075"},
        {"Wilson Evans Batten Catalogue", "WEB 12684"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.80634954),
        dec: Angle.Degrees(-13.05430971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45677"},
        {"Hipparcos Number", "HIP 30800"},
        {"Geneva Identification System", "GEN# +1.00045677"},
        {"Renson", "Renson 12140"},
        {"Smithsonian Astrophysical Observation", "SAO 151534"},
        {"Wilson Evans Batten Catalogue", "WEB 6142"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.07258635),
        dec: Angle.Degrees(-13.05309360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199828"},
        {"Hipparcos Number", "HIP 103640"},
        {"Smithsonian Astrophysical Observation", "SAO 164046"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.97851397),
        dec: Angle.Degrees(-13.05163503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80344"},
        {"Smithsonian Astrophysical Observation", "SAO 159895"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.02619062),
        dec: Angle.Degrees(-13.05130347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100043"},
        {"Hipparcos Number", "HIP 56154"},
        {"Geneva Identification System", "GEN# +1.00100043"},
        {"Smithsonian Astrophysical Observation", "SAO 156722"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.66146251),
        dec: Angle.Degrees(-13.05013821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56274"},
        {"Hipparcos Number", "HIP 35139"},
        {"Cincinnati Publication", "Ci 20 417"},
        {"Geneva Identification System", "GEN# +1.00056274"},
        {"Smithsonian Astrophysical Observation", "SAO 152626"},
        {"Wilson Evans Batten Catalogue", "WEB 7023"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96292197),
        dec: Angle.Degrees(-13.04991169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -510.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45733"},
        {"Hipparcos Number", "HIP 30828"},
        {"Geneva Identification System", "GEN# +1.00045733"},
        {"Renson", "Renson 12180"},
        {"Smithsonian Astrophysical Observation", "SAO 151542"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14398377),
        dec: Angle.Degrees(-13.04924941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28497"},
        {"Hipparcos Number", "HIP 20922"},
        {"Fundamental Katalog 5th Edition", "FK5 2332"},
        {"Geneva Identification System", "GEN# +1.00028497"},
        {"Smithsonian Astrophysical Observation", "SAO 149674"},
        {"Wilson Evans Batten Catalogue", "WEB 4020"},
    },
    visualMagnitude: 5.61,
    bvColour: -0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.27885535),
        dec: Angle.Degrees(-13.04836725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202929"},
        {"Hipparcos Number", "HIP 105267"},
        {"Smithsonian Astrophysical Observation", "SAO 164303"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.83535367),
        dec: Angle.Degrees(-13.04794357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191365"},
        {"Hipparcos Number", "HIP 99357"},
        {"Geneva Identification System", "GEN# +1.00191365"},
        {"Smithsonian Astrophysical Observation", "SAO 163305"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.50392351),
        dec: Angle.Degrees(-13.04635334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135681"},
        {"Hipparcos Number", "HIP 74765"},
        {"Geneva Identification System", "GEN# +1.00135681"},
        {"Smithsonian Astrophysical Observation", "SAO 159146"},
        {"Wilson Evans Batten Catalogue", "WEB 12755"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.20247278),
        dec: Angle.Degrees(-13.03919602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6503"},
        {"Hipparcos Number", "HIP 5149"},
        {"Smithsonian Astrophysical Observation", "SAO 147605"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.47841903),
        dec: Angle.Degrees(-13.03866947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178069"},
        {"Hipparcos Number", "HIP 93947"},
        {"Smithsonian Astrophysical Observation", "SAO 162216"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.93259555),
        dec: Angle.Degrees(-13.03742136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145854"},
        {"Hipparcos Number", "HIP 79519"},
        {"Smithsonian Astrophysical Observation", "SAO 159789"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.40736078),
        dec: Angle.Degrees(-13.03503618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111581"},
        {"Hipparcos Number", "HIP 62668"},
        {"Smithsonian Astrophysical Observation", "SAO 157540"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.61917448),
        dec: Angle.Degrees(-13.03466438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187697"},
        {"Hipparcos Number", "HIP 97739"},
        {"Smithsonian Astrophysical Observation", "SAO 163055"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.93781146),
        dec: Angle.Degrees(-13.03260944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21578",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3355 B"},
        {"Hipparcos Number", "HIP 21578"},
        {"Smithsonian Astrophysical Observation", "SAO 149777"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.49945532),
        dec: Angle.Degrees(-13.03229230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163977"},
        {"Hipparcos Number", "HIP 88090"},
        {"Geneva Identification System", "GEN# +1.00163977"},
        {"Smithsonian Astrophysical Observation", "SAO 160966"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.86834183),
        dec: Angle.Degrees(-13.03149544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21577",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3355 A"},
        {"Henry Draper", "HD 29482"},
        {"Hipparcos Number", "HIP 21577"},
        {"Geneva Identification System", "GEN# +1.00029482"},
        {"Smithsonian Astrophysical Observation", "SAO 149776"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.49897056),
        dec: Angle.Degrees(-13.02887708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195183"},
        {"Hipparcos Number", "HIP 101157"},
        {"Smithsonian Astrophysical Observation", "SAO 163633"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.56334634),
        dec: Angle.Degrees(-13.02846126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210776"},
        {"Hipparcos Number", "HIP 109672"},
        {"Smithsonian Astrophysical Observation", "SAO 164929"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.25231624),
        dec: Angle.Degrees(-13.02797524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119185"},
        {"Hipparcos Number", "HIP 66844"},
        {"Geneva Identification System", "GEN# +1.00119185"},
        {"Smithsonian Astrophysical Observation", "SAO 158098"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.48970381),
        dec: Angle.Degrees(-13.02777193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209080"},
        {"Hipparcos Number", "HIP 108692"},
        {"Geneva Identification System", "GEN# +1.00209080"},
        {"Smithsonian Astrophysical Observation", "SAO 164811"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.27113780),
        dec: Angle.Degrees(-13.02720352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40905"},
        {"Hipparcos Number", "HIP 28533"},
        {"Smithsonian Astrophysical Observation", "SAO 151027"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.33474379),
        dec: Angle.Degrees(-13.02664963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209490"},
        {"Hipparcos Number", "HIP 108931"},
        {"Fundamental Katalog 5th Edition", "FK5 5949"},
        {"Smithsonian Astrophysical Observation", "SAO 164840"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.02494556),
        dec: Angle.Degrees(-13.01960540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29709"},
        {"Hipparcos Number", "HIP 21752"},
        {"Geneva Identification System", "GEN# +1.00029709"},
        {"Smithsonian Astrophysical Observation", "SAO 149812"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.05696948),
        dec: Angle.Degrees(-13.01535347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120756"},
        {"Hipparcos Number", "HIP 67646"},
        {"Geneva Identification System", "GEN# +1.00120756"},
        {"Smithsonian Astrophysical Observation", "SAO 158203"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.89671878),
        dec: Angle.Degrees(-13.01510130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61910",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8627 AB"},
        {"Henry Draper", "HD 110317J"},
        {"Hipparcos Number", "HIP 61910"},
        {"Geneva Identification System", "GEN# +1.00110318J"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.31676407),
        dec: Angle.Degrees(-13.01392023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106403"},
        {"Hipparcos Number", "HIP 59688"},
        {"Smithsonian Astrophysical Observation", "SAO 157161"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.60865877),
        dec: Angle.Degrees(-13.01371844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138546"},
        {"Hipparcos Number", "HIP 76153"},
        {"Fundamental Katalog 5th Edition", "FK5 5375"},
        {"Smithsonian Astrophysical Observation", "SAO 159341"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.31339526),
        dec: Angle.Degrees(-13.01277487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139484"},
        {"Hipparcos Number", "HIP 76622"},
        {"Smithsonian Astrophysical Observation", "SAO 159412"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.71395836),
        dec: Angle.Degrees(-13.00777277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215464"},
        {"Hipparcos Number", "HIP 112352"},
        {"Smithsonian Astrophysical Observation", "SAO 165276"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.36286244),
        dec: Angle.Degrees(-13.00686969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175125"},
        {"Hipparcos Number", "HIP 92783"},
        {"Smithsonian Astrophysical Observation", "SAO 161958"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.60208644),
        dec: Angle.Degrees(-13.00583169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71113",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9297 AB"},
        {"Henry Draper", "HD 127580"},
        {"Hipparcos Number", "HIP 71113"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.13632000),
        dec: Angle.Degrees(-13.00383335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144784"},
        {"Hipparcos Number", "HIP 79041"},
        {"Geneva Identification System", "GEN# +1.00144784"},
        {"Smithsonian Astrophysical Observation", "SAO 159725"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.01554747),
        dec: Angle.Degrees(-13.00288080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96400"},
        {"Hipparcos Number", "HIP 54315"},
        {"Geneva Identification System", "GEN# +1.00096400"},
        {"Smithsonian Astrophysical Observation", "SAO 156466"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.67302401),
        dec: Angle.Degrees(-13.00265292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16561"},
        {"Hipparcos Number", "HIP 12341"},
        {"Smithsonian Astrophysical Observation", "SAO 148520"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.72850119),
        dec: Angle.Degrees(-13.00257487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52162"},
        {"Hipparcos Number", "HIP 33664"},
        {"Geneva Identification System", "GEN# +1.00052162"},
        {"Smithsonian Astrophysical Observation", "SAO 152211"},
        {"Wilson Evans Batten Catalogue", "WEB 6764"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.90042216),
        dec: Angle.Degrees(-13.00216115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91773"},
        {"Hipparcos Number", "HIP 51853"},
        {"Geneva Identification System", "GEN# +1.00091773"},
        {"Smithsonian Astrophysical Observation", "SAO 156086"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.91192304),
        dec: Angle.Degrees(-13.00025673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114558"},
        {"Hipparcos Number", "HIP 64356"},
        {"Smithsonian Astrophysical Observation", "SAO 157781"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87034072),
        dec: Angle.Degrees(-12.99998264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170159"},
        {"Hipparcos Number", "HIP 90552"},
        {"Geneva Identification System", "GEN# +1.00170159"},
        {"Smithsonian Astrophysical Observation", "SAO 161508"},
        {"Wilson Evans Batten Catalogue", "WEB 15507"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.15282478),
        dec: Angle.Degrees(-12.99743945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83712"},
        {"Hipparcos Number", "HIP 47440"},
        {"Geneva Identification System", "GEN# +1.00083712"},
        {"Smithsonian Astrophysical Observation", "SAO 155382"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.01190042),
        dec: Angle.Degrees(-12.99729557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189397"},
        {"Hipparcos Number", "HIP 98463"},
        {"Geneva Identification System", "GEN# +1.00189397"},
        {"Smithsonian Astrophysical Observation", "SAO 163170"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06930572),
        dec: Angle.Degrees(-12.99470387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92357"},
        {"Hipparcos Number", "HIP 52183"},
        {"Smithsonian Astrophysical Observation", "SAO 156137"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.90519135),
        dec: Angle.Degrees(-12.99424911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209603"},
        {"Hipparcos Number", "HIP 109001"},
        {"Smithsonian Astrophysical Observation", "SAO 164848"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.23462677),
        dec: Angle.Degrees(-12.99424642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51849"},
        {"Hipparcos Number", "HIP 33560"},
        {"Geneva Identification System", "GEN# +1.00051849"},
        {"Smithsonian Astrophysical Observation", "SAO 152180"},
        {"Wilson Evans Batten Catalogue", "WEB 6747"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.60840608),
        dec: Angle.Degrees(-12.99146886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166336"},
        {"Hipparcos Number", "HIP 89079"},
        {"Smithsonian Astrophysical Observation", "SAO 161148"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.69833721),
        dec: Angle.Degrees(-12.99125445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38025"},
        {"Hipparcos Number", "HIP 26858"},
        {"Geneva Identification System", "GEN# +1.00038025"},
        {"Smithsonian Astrophysical Observation", "SAO 150713"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.53662364),
        dec: Angle.Degrees(-12.99023782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143190"},
        {"Hipparcos Number", "HIP 78315"},
        {"Geneva Identification System", "GEN# +1.00143190"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.86382951),
        dec: Angle.Degrees(-12.98907270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164165"},
        {"Hipparcos Number", "HIP 88171"},
        {"Geneva Identification System", "GEN# +1.00164165"},
        {"Smithsonian Astrophysical Observation", "SAO 160984"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.11183748),
        dec: Angle.Degrees(-12.98809347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117410"},
        {"Geneva Identification System", "GEN# -0.01306464J"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.10647209),
        dec: Angle.Degrees(-12.98751169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20279"},
        {"Hipparcos Number", "HIP 15148"},
        {"Smithsonian Astrophysical Observation", "SAO 148859"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.81499960),
        dec: Angle.Degrees(-12.98733756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203035"},
        {"Hipparcos Number", "HIP 105325"},
        {"Smithsonian Astrophysical Observation", "SAO 164311"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.00822188),
        dec: Angle.Degrees(-12.98639835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55233"},
    },
    visualMagnitude: 10.96,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.66059684),
        dec: Angle.Degrees(-12.98557255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -307.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9680 AB"},
        {"Henry Draper", "HD 138253"},
        {"Hipparcos Number", "HIP 76003"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.83126099),
        dec: Angle.Degrees(-12.98542880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47366"},
        {"Hipparcos Number", "HIP 31674"},
        {"Geneva Identification System", "GEN# +1.00047366"},
        {"Smithsonian Astrophysical Observation", "SAO 151725"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41994734),
        dec: Angle.Degrees(-12.98481239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10340"},
        {"Hipparcos Number", "HIP 7836"},
        {"Smithsonian Astrophysical Observation", "SAO 147955"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.20489724),
        dec: Angle.Degrees(-12.98379726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113384"},
        {"Hipparcos Number", "HIP 63709"},
        {"Smithsonian Astrophysical Observation", "SAO 157683"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.84367227),
        dec: Angle.Degrees(-12.98112668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126083"},
        {"Hipparcos Number", "HIP 70357"},
        {"Smithsonian Astrophysical Observation", "SAO 158532"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.92771516),
        dec: Angle.Degrees(-12.98037097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207921"},
        {"Hipparcos Number", "HIP 108005"},
        {"Geneva Identification System", "GEN# +1.00207921"},
        {"Smithsonian Astrophysical Observation", "SAO 164708"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.22803627),
        dec: Angle.Degrees(-12.97803351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134371"},
        {"Hipparcos Number", "HIP 74210"},
        {"Smithsonian Astrophysical Observation", "SAO 159060"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.47280269),
        dec: Angle.Degrees(-12.97618834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9214"},
        {"Hipparcos Number", "HIP 7032"},
        {"Smithsonian Astrophysical Observation", "SAO 147849"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.64908180),
        dec: Angle.Degrees(-12.97589719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22163"},
        {"Smithsonian Astrophysical Observation", "SAO 149869"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.52756383),
        dec: Angle.Degrees(-12.97523193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142801"},
        {"Hipparcos Number", "HIP 78107"},
        {"Smithsonian Astrophysical Observation", "SAO 159596"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.23101345),
        dec: Angle.Degrees(-12.96938290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8389"},
        {"Henry Draper 2", "HD 8389A"},
        {"Hipparcos Number", "HIP 6456"},
        {"Geneva Identification System", "GEN# +1.10008389"},
        {"Geneva Identification System 2", "GEN# +1.00008389A"},
        {"Smithsonian Astrophysical Observation", "SAO 147768"},
        {"Wilson Evans Batten Catalogue", "WEB 1428"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.75984242),
        dec: Angle.Degrees(-12.96600556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 463.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81408"},
        {"Hipparcos Number", "HIP 46191"},
        {"Cincinnati Publication", "Ci 20 524"},
        {"Geneva Identification System", "GEN# +1.00081408"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.27108754),
        dec: Angle.Degrees(-12.96544548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 555.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -569.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119845"},
        {"Hipparcos Number", "HIP 67163"},
        {"Smithsonian Astrophysical Observation", "SAO 158150"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46001144),
        dec: Angle.Degrees(-12.96462542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113250"},
    },
    visualMagnitude: 11.54,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.99346162),
        dec: Angle.Degrees(-12.96285092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5030 A"},
        {"Henry Draper", "HD 44996"},
        {"Hipparcos Number", "HIP 30468"},
        {"Geneva Identification System", "GEN# +1.00044996A"},
        {"Smithsonian Astrophysical Observation", "SAO 151461"},
    },
    visualMagnitude: 6.12,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.08575250),
        dec: Angle.Degrees(-12.96194840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196099"},
        {"Hipparcos Number", "HIP 101606"},
        {"Smithsonian Astrophysical Observation", "SAO 163713"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.87321601),
        dec: Angle.Degrees(-12.96106153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170234"},
        {"Hipparcos Number", "HIP 90572"},
        {"Smithsonian Astrophysical Observation", "SAO 161516"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.22297745),
        dec: Angle.Degrees(-12.96015823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212477"},
        {"Hipparcos Number", "HIP 110637"},
        {"Smithsonian Astrophysical Observation", "SAO 165053"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.18389606),
        dec: Angle.Degrees(-12.95771194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59212"},
        {"Hipparcos Number", "HIP 36311"},
        {"Celescope Catalog", "CEL 1870"},
        {"Geneva Identification System", "GEN# +1.00059212J"},
        {"Smithsonian Astrophysical Observation", "SAO 152924"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.11003484),
        dec: Angle.Degrees(-12.95607849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178268"},
        {"Hipparcos Number", "HIP 94014"},
        {"Smithsonian Astrophysical Observation", "SAO 162232"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.10925477),
        dec: Angle.Degrees(-12.95606485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67491"},
        {"Hipparcos Number", "HIP 39779"},
        {"Smithsonian Astrophysical Observation", "SAO 153867"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.94062458),
        dec: Angle.Degrees(-12.95258849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53857"},
        {"Hipparcos Number", "HIP 34262"},
        {"Celescope Catalog", "CEL 1580"},
        {"Geneva Identification System", "GEN# +1.00053857J"},
        {"Wilson Evans Batten Catalogue", "WEB 6863"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.53088102),
        dec: Angle.Degrees(-12.95220123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16006"},
        {"Hipparcos Number", "HIP 11931"},
        {"Smithsonian Astrophysical Observation", "SAO 148470"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.49352122),
        dec: Angle.Degrees(-12.95111189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7571 C"},
        {"Henry Draper", "HD 85883"},
        {"Hipparcos Number", "HIP 48592"},
        {"Geneva Identification System", "GEN# +1.00085883"},
        {"Smithsonian Astrophysical Observation", "SAO 155582"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64417674),
        dec: Angle.Degrees(-12.95094587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95134"},
        {"Hipparcos Number", "HIP 53674"},
        {"Smithsonian Astrophysical Observation", "SAO 156363"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.73448720),
        dec: Angle.Degrees(-12.95064836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220739"},
        {"Hipparcos Number", "HIP 115685"},
        {"Smithsonian Astrophysical Observation", "SAO 165692"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58272637),
        dec: Angle.Degrees(-12.95044175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116812"},
        {"Smithsonian Astrophysical Observation", "SAO 165824"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.12299585),
        dec: Angle.Degrees(-12.94923880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92115"},
        {"Hipparcos Number", "HIP 52036"},
        {"Smithsonian Astrophysical Observation", "SAO 156115"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.48149439),
        dec: Angle.Degrees(-12.94431629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37528"},
        {"Hipparcos Number", "HIP 26543"},
        {"Smithsonian Astrophysical Observation", "SAO 150641"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.66916297),
        dec: Angle.Degrees(-12.94259600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126101"},
        {"Hipparcos Number", "HIP 70365"},
        {"Geneva Identification System", "GEN# +1.00126101"},
        {"Smithsonian Astrophysical Observation", "SAO 158534"},
        {"Wilson Evans Batten Catalogue", "WEB 12213"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95416924),
        dec: Angle.Degrees(-12.94246163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124374"},
        {"Hipparcos Number", "HIP 69486"},
        {"Geneva Identification System", "GEN# +1.00124374"},
        {"Smithsonian Astrophysical Observation", "SAO 158438"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.38875777),
        dec: Angle.Degrees(-12.94232780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85365"},
        {"Hipparcos Number", "HIP 48321"},
        {"Geneva Identification System", "GEN# +1.00085365"},
        {"Smithsonian Astrophysical Observation", "SAO 155528"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.75400138),
        dec: Angle.Degrees(-12.94184180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3800 AB"},
        {"Henry Draper", "HD 33949"},
        {"Hipparcos Number", "HIP 24327"},
        {"Geneva Identification System", "GEN# +1.00033949"},
        {"Smithsonian Astrophysical Observation", "SAO 150239"},
        {"Wilson Evans Batten Catalogue", "WEB 4720"},
    },
    visualMagnitude: 4.36,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.30785422),
        dec: Angle.Degrees(-12.94128833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48399"},
        {"Hipparcos Number", "HIP 32134"},
        {"Smithsonian Astrophysical Observation", "SAO 151821"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.66543364),
        dec: Angle.Degrees(-12.94082272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105571"},
        {"Hipparcos Number", "HIP 59264"},
        {"Smithsonian Astrophysical Observation", "SAO 157109"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.34233866),
        dec: Angle.Degrees(-12.94003097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39899"},
        {"Hipparcos Number", "HIP 27970"},
        {"Geneva Identification System", "GEN# +1.00039899"},
        {"Smithsonian Astrophysical Observation", "SAO 150935"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.73949792),
        dec: Angle.Degrees(-12.93866175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112143"},
        {"Hipparcos Number", "HIP 62990"},
        {"Smithsonian Astrophysical Observation", "SAO 157585"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.60725325),
        dec: Angle.Degrees(-12.93734438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5096"},
        {"Hipparcos Number", "HIP 4101"},
        {"Geneva Identification System", "GEN# +1.00005096"},
        {"Smithsonian Astrophysical Observation", "SAO 147492"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.16246333),
        dec: Angle.Degrees(-12.93682670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65125"},
        {"Hipparcos Number", "HIP 38826"},
        {"Smithsonian Astrophysical Observation", "SAO 153618"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.18816208),
        dec: Angle.Degrees(-12.93532673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130294"},
        {"Hipparcos Number", "HIP 72347"},
        {"Smithsonian Astrophysical Observation", "SAO 158804"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.91204393),
        dec: Angle.Degrees(-12.93468722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81302"},
        {"Smithsonian Astrophysical Observation", "SAO 159996"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09038975),
        dec: Angle.Degrees(-12.93437387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57543"},
        {"Hipparcos Number", "HIP 35635"},
        {"Smithsonian Astrophysical Observation", "SAO 152753"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.30874121),
        dec: Angle.Degrees(-12.93302057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48162"},
        {"Hipparcos Number", "HIP 32036"},
        {"Smithsonian Astrophysical Observation", "SAO 151795"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.37629307),
        dec: Angle.Degrees(-12.93033110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220876"},
        {"Hipparcos Number", "HIP 115789"},
        {"Smithsonian Astrophysical Observation", "SAO 165705"},
        {"Wilson Evans Batten Catalogue", "WEB 20489"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.85879285),
        dec: Angle.Degrees(-12.93008458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21270"},
        {"Smithsonian Astrophysical Observation", "SAO 149730"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.45114657),
        dec: Angle.Degrees(-12.92881078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32706"},
        {"Hipparcos Number", "HIP 23615"},
        {"Smithsonian Astrophysical Observation", "SAO 150120"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15807368),
        dec: Angle.Degrees(-12.92819665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69054",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9115"},
        {"Henry Draper", "HD 123453"},
        {"Hipparcos Number", "HIP 69054"},
        {"Geneva Identification System", "GEN# +1.00123453J"},
        {"Smithsonian Astrophysical Observation", "SAO 158372"},
        {"Wilson Evans Batten Catalogue", "WEB 12059"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.01678892),
        dec: Angle.Degrees(-12.92810228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19624"},
        {"Smithsonian Astrophysical Observation", "SAO 149453"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.07255300),
        dec: Angle.Degrees(-12.92808586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4917"},
        {"Hipparcos Number", "HIP 3975"},
        {"Smithsonian Astrophysical Observation", "SAO 147478"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.77609414),
        dec: Angle.Degrees(-12.92756757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40084",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6647 AB"},
        {"Henry Draper", "HD 68290"},
        {"Hipparcos Number", "HIP 40084"},
        {"Geneva Identification System", "GEN# +1.00068290J"},
        {"Smithsonian Astrophysical Observation", "SAO 153942"},
        {"Wilson Evans Batten Catalogue", "WEB 7822"},
    },
    visualMagnitude: 4.72,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.81800545),
        dec: Angle.Degrees(-12.92701835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13370 A"},
        {"Henry Draper", "HD 190723"},
        {"Hipparcos Number", "HIP 99066"},
        {"Smithsonian Astrophysical Observation", "SAO 163267"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.69076976),
        dec: Angle.Degrees(-12.92699254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13406"},
        {"Hipparcos Number", "HIP 10167"},
        {"Fundamental Katalog 5th Edition", "FK5 4202"},
        {"Geneva Identification System", "GEN# +1.00013406"},
        {"Renson", "Renson 3480"},
        {"Smithsonian Astrophysical Observation", "SAO 148253"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.68990414),
        dec: Angle.Degrees(-12.92662738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184317"},
        {"Hipparcos Number", "HIP 96265"},
        {"Geneva Identification System", "GEN# +1.00184317"},
        {"Smithsonian Astrophysical Observation", "SAO 162781"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.60885874),
        dec: Angle.Degrees(-12.92644835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135966"},
        {"Hipparcos Number", "HIP 74897"},
        {"Smithsonian Astrophysical Observation", "SAO 159162"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.60303196),
        dec: Angle.Degrees(-12.92480305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142746"},
        {"Hipparcos Number", "HIP 78084"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.16206453),
        dec: Angle.Degrees(-12.92305679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85858"},
        {"Hipparcos Number", "HIP 48574"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.61405208),
        dec: Angle.Degrees(-12.92231149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21361"},
        {"Smithsonian Astrophysical Observation", "SAO 149744"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.74820629),
        dec: Angle.Degrees(-12.92180612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78030"},
        {"Hipparcos Number", "HIP 44633"},
        {"Smithsonian Astrophysical Observation", "SAO 154898"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.42171418),
        dec: Angle.Degrees(-12.91812259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10394"},
        {"Hipparcos Number", "HIP 7870"},
        {"Smithsonian Astrophysical Observation", "SAO 147959"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.31312797),
        dec: Angle.Degrees(-12.91768022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84052"},
        {"Hipparcos Number", "HIP 47586"},
        {"Geneva Identification System", "GEN# +1.00084052"},
        {"Smithsonian Astrophysical Observation", "SAO 155414"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.53975583),
        dec: Angle.Degrees(-12.91732434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33318"},
        {"Hipparcos Number", "HIP 23951"},
        {"Smithsonian Astrophysical Observation", "SAO 150176"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.21532880),
        dec: Angle.Degrees(-12.91622931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160512"},
        {"Hipparcos Number", "HIP 86523"},
        {"Smithsonian Astrophysical Observation", "SAO 160741"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.22251537),
        dec: Angle.Degrees(-12.91579585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213198"},
        {"Hipparcos Number", "HIP 111066"},
        {"Geneva Identification System", "GEN# +1.00213198"},
        {"Smithsonian Astrophysical Observation", "SAO 165123"},
        {"Wilson Evans Batten Catalogue", "WEB 19882"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.50577970),
        dec: Angle.Degrees(-12.91511781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10444"},
        {"Smithsonian Astrophysical Observation", "SAO 148287"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.64778300),
        dec: Angle.Degrees(-12.91283023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147135"},
        {"Hipparcos Number", "HIP 80060"},
        {"Geneva Identification System", "GEN# +1.00147135"},
        {"Smithsonian Astrophysical Observation", "SAO 159867"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.11766582),
        dec: Angle.Degrees(-12.91111502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15505"},
        {"Hipparcos Number", "HIP 11592"},
        {"Geneva Identification System", "GEN# +1.00015505"},
        {"Smithsonian Astrophysical Observation", "SAO 148418"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.34829895),
        dec: Angle.Degrees(-12.91080154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128596"},
        {"Hipparcos Number", "HIP 71559"},
        {"Geneva Identification System", "GEN# +1.00128596"},
        {"Smithsonian Astrophysical Observation", "SAO 158686"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.52972031),
        dec: Angle.Degrees(-12.91055855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81729"},
        {"Hipparcos Number", "HIP 46353"},
        {"Renson", "Renson 23195"},
        {"Smithsonian Astrophysical Observation", "SAO 155197"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.76608858),
        dec: Angle.Degrees(-12.90936192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133772"},
        {"Hipparcos Number", "HIP 73939"},
        {"Smithsonian Astrophysical Observation", "SAO 159027"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.64260450),
        dec: Angle.Degrees(-12.90700458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13532"},
        {"Hipparcos Number", "HIP 10249"},
        {"Smithsonian Astrophysical Observation", "SAO 148268"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.95453319),
        dec: Angle.Degrees(-12.90682568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35698"},
        {"Hipparcos Number", "HIP 25407"},
        {"Smithsonian Astrophysical Observation", "SAO 150440"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.51950197),
        dec: Angle.Degrees(-12.90479282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108074"},
        {"Smithsonian Astrophysical Observation", "SAO 164722"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.45454011),
        dec: Angle.Degrees(-12.90450958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36698"},
        {"Hipparcos Number", "HIP 26017"},
        {"Smithsonian Astrophysical Observation", "SAO 150551"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.27816533),
        dec: Angle.Degrees(-12.90361284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6461"},
        {"Hipparcos Number", "HIP 5104"},
        {"Geneva Identification System", "GEN# +1.00006461"},
        {"Smithsonian Astrophysical Observation", "SAO 147600"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.35586357),
        dec: Angle.Degrees(-12.90348019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171769"},
        {"Hipparcos Number", "HIP 91277"},
        {"Smithsonian Astrophysical Observation", "SAO 161669"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.27983904),
        dec: Angle.Degrees(-12.90274005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126615"},
        {"Hipparcos Number", "HIP 70634"},
        {"Smithsonian Astrophysical Observation", "SAO 158567"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.72517116),
        dec: Angle.Degrees(-12.90092693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40745"},
        {"Hipparcos Number", "HIP 28434"},
        {"Geneva Identification System", "GEN# +1.00040745"},
        {"Smithsonian Astrophysical Observation", "SAO 151011"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07359834),
        dec: Angle.Degrees(-12.89991193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86989"},
        {"Hipparcos Number", "HIP 49148"},
        {"Smithsonian Astrophysical Observation", "SAO 155668"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.46548752),
        dec: Angle.Degrees(-12.89878741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6097",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6097"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.56627324),
        dec: Angle.Degrees(-12.89818577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -679.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214249"},
        {"Hipparcos Number", "HIP 111651"},
        {"Smithsonian Astrophysical Observation", "SAO 165197"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.27249139),
        dec: Angle.Degrees(-12.89783871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16277"},
        {"Hipparcos Number", "HIP 12138"},
        {"Geneva Identification System", "GEN# +1.00016277"},
        {"Smithsonian Astrophysical Observation", "SAO 148496"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.08482338),
        dec: Angle.Degrees(-12.89687428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43252"},
        {"Hipparcos Number", "HIP 29634"},
        {"Smithsonian Astrophysical Observation", "SAO 151260"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.67448131),
        dec: Angle.Degrees(-12.88858367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11247"},
        {"Hipparcos Number", "HIP 8549"},
        {"Smithsonian Astrophysical Observation", "SAO 148049"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.56589910),
        dec: Angle.Degrees(-12.88689038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203162"},
        {"Hipparcos Number", "HIP 105385"},
        {"Smithsonian Astrophysical Observation", "SAO 164322"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.19525545),
        dec: Angle.Degrees(-12.88614093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54493"},
        {"Hipparcos Number", "HIP 34454"},
        {"Celescope Catalog", "CEL 1609"},
        {"Geneva Identification System", "GEN# +1.00054493"},
        {"Smithsonian Astrophysical Observation", "SAO 152446"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.13430838),
        dec: Angle.Degrees(-12.88593117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145153"},
        {"Hipparcos Number", "HIP 79200"},
        {"Geneva Identification System", "GEN# +1.00145153"},
        {"Smithsonian Astrophysical Observation", "SAO 159748"},
        {"Wilson Evans Batten Catalogue", "WEB 13393"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.47242374),
        dec: Angle.Degrees(-12.88570963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69588"},
        {"Hipparcos Number", "HIP 40584"},
        {"Smithsonian Astrophysical Observation", "SAO 154069"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.29821123),
        dec: Angle.Degrees(-12.88336710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110107"},
        {"Hipparcos Number", "HIP 61801"},
        {"Smithsonian Astrophysical Observation", "SAO 157428"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98742200),
        dec: Angle.Degrees(-12.88306984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214910"},
        {"Hipparcos Number", "HIP 112053"},
        {"Smithsonian Astrophysical Observation", "SAO 165235"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.44047287),
        dec: Angle.Degrees(-12.88192032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32442"},
        {"Geneva Identification System", "GEN# +6.10180579"},
        {"Wilson Evans Batten Catalogue", "WEB 6543"},
    },
    visualMagnitude: 10.13,
    bvColour: 3.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.56462645),
        dec: Angle.Degrees(-12.88126059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201181"},
        {"Hipparcos Number", "HIP 104343"},
        {"Smithsonian Astrophysical Observation", "SAO 164164"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.06441945),
        dec: Angle.Degrees(-12.88071469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4307"},
        {"Hipparcos Number", "HIP 3559"},
        {"Geneva Identification System", "GEN# +1.00004307"},
        {"Smithsonian Astrophysical Observation", "SAO 147432"},
        {"Wilson Evans Batten Catalogue", "WEB 630"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.36961318),
        dec: Angle.Degrees(-12.88030968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87767"},
        {"Hipparcos Number", "HIP 49542"},
        {"Smithsonian Astrophysical Observation", "SAO 155735"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.73376641),
        dec: Angle.Degrees(-12.88019543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203705"},
        {"Hipparcos Number", "HIP 105668"},
        {"Fundamental Katalog 5th Edition", "FK5 1562"},
        {"Geneva Identification System", "GEN# +1.00203705"},
        {"Smithsonian Astrophysical Observation", "SAO 164364"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.04766053),
        dec: Angle.Degrees(-12.87813020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87274"},
        {"Hipparcos Number", "HIP 49289"},
        {"Smithsonian Astrophysical Observation", "SAO 155695"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.91171320),
        dec: Angle.Degrees(-12.87717150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36662",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6164 A"},
        {"Henry Draper", "HD 60116"},
        {"Hipparcos Number", "HIP 36662"},
        {"Smithsonian Astrophysical Observation", "SAO 153032"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.13978102),
        dec: Angle.Degrees(-12.87685335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221180"},
        {"Hipparcos Number", "HIP 115987"},
        {"Geneva Identification System", "GEN# +1.00221180"},
        {"Renson", "Renson 60630"},
        {"Smithsonian Astrophysical Observation", "SAO 165723"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.49129885),
        dec: Angle.Degrees(-12.87666548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214045"},
        {"Hipparcos Number", "HIP 111534"},
        {"Smithsonian Astrophysical Observation", "SAO 165179"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94689132),
        dec: Angle.Degrees(-12.87555883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12345"},
        {"Hipparcos Number", "HIP 9404"},
        {"Geneva Identification System", "GEN# +1.00012345"},
        {"Smithsonian Astrophysical Observation", "SAO 148151"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.20258820),
        dec: Angle.Degrees(-12.87526774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160613"},
        {"Hipparcos Number", "HIP 86565"},
        {"Fundamental Katalog 5th Edition", "FK5 3405"},
        {"Geneva Identification System", "GEN# +1.00160613"},
        {"Smithsonian Astrophysical Observation", "SAO 160747"},
        {"Wilson Evans Batten Catalogue", "WEB 14598"},
    },
    visualMagnitude: 4.24,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.35381884),
        dec: Angle.Degrees(-12.87517268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35734"},
        {"Hipparcos Number", "HIP 25426"},
        {"Geneva Identification System", "GEN# +1.00035734"},
        {"Smithsonian Astrophysical Observation", "SAO 150445"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56672549),
        dec: Angle.Degrees(-12.87387085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143484"},
        {"Hipparcos Number", "HIP 78455"},
        {"Geneva Identification System", "GEN# +1.00143484"},
        {"Smithsonian Astrophysical Observation", "SAO 159635"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.25355200),
        dec: Angle.Degrees(-12.87356114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87229"},
        {"Hipparcos Number", "HIP 49267"},
        {"Smithsonian Astrophysical Observation", "SAO 155693"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.85109949),
        dec: Angle.Degrees(-12.87157230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137317"},
        {"Hipparcos Number", "HIP 75517"},
        {"Smithsonian Astrophysical Observation", "SAO 159252"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.41883371),
        dec: Angle.Degrees(-12.87066900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167926"},
        {"Hipparcos Number", "HIP 89672"},
        {"Smithsonian Astrophysical Observation", "SAO 161289"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.49276440),
        dec: Angle.Degrees(-12.87003142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19849"},
        {"Hipparcos Number", "HIP 14808"},
        {"Smithsonian Astrophysical Observation", "SAO 148817"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.80332276),
        dec: Angle.Degrees(-12.86915086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199161"},
        {"Hipparcos Number", "HIP 103300"},
        {"Geneva Identification System", "GEN# +1.00199161"},
        {"Smithsonian Astrophysical Observation", "SAO 163988"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.91504223),
        dec: Angle.Degrees(-12.86712582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65763"},
        {"Hipparcos Number", "HIP 39081"},
        {"Smithsonian Astrophysical Observation", "SAO 153682"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.93736132),
        dec: Angle.Degrees(-12.86712065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102885"},
        {"Hipparcos Number", "HIP 57753"},
        {"Geneva Identification System", "GEN# +1.00102885"},
        {"Smithsonian Astrophysical Observation", "SAO 156930"},
        {"Wilson Evans Batten Catalogue", "WEB 10365"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.66659913),
        dec: Angle.Degrees(-12.86711154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100551"},
        {"Hipparcos Number", "HIP 56436"},
        {"Geneva Identification System", "GEN# +1.00100551"},
        {"Smithsonian Astrophysical Observation", "SAO 156756"},
        {"Wilson Evans Batten Catalogue", "WEB 10142"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.55985792),
        dec: Angle.Degrees(-12.86371769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88317"},
        {"Hipparcos Number", "HIP 49853"},
        {"Geneva Identification System", "GEN# +1.00088317"},
        {"Smithsonian Astrophysical Observation", "SAO 155790"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.69669347),
        dec: Angle.Degrees(-12.86223870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109528"},
        {"Geneva Identification System", "GEN# -0.01306123"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.80068501),
        dec: Angle.Degrees(-12.86146512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190416"},
        {"Hipparcos Number", "HIP 98937"},
        {"Smithsonian Astrophysical Observation", "SAO 163250"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32803357),
        dec: Angle.Degrees(-12.86033159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25281"},
        {"Hipparcos Number", "HIP 18722"},
        {"Smithsonian Astrophysical Observation", "SAO 149312"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.16717665),
        dec: Angle.Degrees(-12.85950655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91728"},
        {"Hipparcos Number", "HIP 51832"},
        {"Geneva Identification System", "GEN# +1.00091728"},
        {"Smithsonian Astrophysical Observation", "SAO 156084"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.84273125),
        dec: Angle.Degrees(-12.85926902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30807"},
        {"Geneva Identification System", "GEN# -0.01201502"},
        {"Smithsonian Astrophysical Observation", "SAO 151536"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.08836826),
        dec: Angle.Degrees(-12.85918401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138969"},
        {"Hipparcos Number", "HIP 76363"},
        {"Smithsonian Astrophysical Observation", "SAO 159372"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.94758083),
        dec: Angle.Degrees(-12.85912602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133130"},
        {"Hipparcos Number", "HIP 73638"},
        {"Geneva Identification System", "GEN# +1.00133130"},
        {"Smithsonian Astrophysical Observation", "SAO 158994"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.78371201),
        dec: Angle.Degrees(-12.85761895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70136"},
        {"Hipparcos Number", "HIP 40822"},
        {"Smithsonian Astrophysical Observation", "SAO 154119"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.97469969),
        dec: Angle.Degrees(-12.85695625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107403"},
        {"Hipparcos Number", "HIP 60213"},
        {"Smithsonian Astrophysical Observation", "SAO 157224"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.21257376),
        dec: Angle.Degrees(-12.85339648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208990"},
        {"Hipparcos Number", "HIP 108628"},
        {"Smithsonian Astrophysical Observation", "SAO 164806"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.10264442),
        dec: Angle.Degrees(-12.85327904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61016"},
        {"Hipparcos Number", "HIP 37044"},
        {"Smithsonian Astrophysical Observation", "SAO 153146"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.18948487),
        dec: Angle.Degrees(-12.85279197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9433"},
        {"Hipparcos Number", "HIP 7186"},
        {"Smithsonian Astrophysical Observation", "SAO 147874"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.14330849),
        dec: Angle.Degrees(-12.85266650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137649"},
        {"Hipparcos Number", "HIP 75670"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.90077003),
        dec: Angle.Degrees(-12.85188736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47202"},
        {"Hipparcos Number", "HIP 31604"},
        {"Smithsonian Astrophysical Observation", "SAO 151704"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.21638823),
        dec: Angle.Degrees(-12.85136155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81269"},
        {"Hipparcos Number", "HIP 46117"},
        {"Smithsonian Astrophysical Observation", "SAO 155150"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.07002349),
        dec: Angle.Degrees(-12.84976126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200414"},
        {"Hipparcos Number", "HIP 103942"},
        {"Smithsonian Astrophysical Observation", "SAO 164103"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.90436389),
        dec: Angle.Degrees(-12.84975301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84880",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10481 A"},
        {"Henry Draper", "HD 156928"},
        {"Hipparcos Number", "HIP 84880"},
        {"Fundamental Katalog 5th Edition", "FK5 3376"},
        {"Geneva Identification System", "GEN# +1.00156928A"},
        {"Smithsonian Astrophysical Observation", "SAO 160479"},
        {"Wilson Evans Batten Catalogue", "WEB 14330"},
    },
    visualMagnitude: 4.32,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.20681480),
        dec: Angle.Degrees(-12.84688200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56594"},
        {"Hipparcos Number", "HIP 35260"},
        {"Smithsonian Astrophysical Observation", "SAO 152661"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.27837247),
        dec: Angle.Degrees(-12.84621648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7134"},
        {"Hipparcos Number", "HIP 5578"},
        {"Geneva Identification System", "GEN# +1.00007134"},
        {"Smithsonian Astrophysical Observation", "SAO 147658"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.88374424),
        dec: Angle.Degrees(-12.84291544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49573"},
        {"Hipparcos Number", "HIP 32637"},
        {"Fundamental Katalog 5th Edition", "FK5 4620"},
        {"Smithsonian Astrophysical Observation", "SAO 151949"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.11417350),
        dec: Angle.Degrees(-12.84061180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176162"},
        {"Hipparcos Number", "HIP 93225"},
        {"Geneva Identification System", "GEN# +1.00176162J"},
        {"Smithsonian Astrophysical Observation", "SAO 162052"},
        {"Wilson Evans Batten Catalogue", "WEB 16163"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.84917715),
        dec: Angle.Degrees(-12.84046242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130325"},
        {"Hipparcos Number", "HIP 72373"},
        {"Geneva Identification System", "GEN# +1.00130325"},
        {"Smithsonian Astrophysical Observation", "SAO 158808"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.97883950),
        dec: Angle.Degrees(-12.83978160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45495"},
        {"Hipparcos Number", "HIP 30715"},
        {"Smithsonian Astrophysical Observation", "SAO 151519"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.80410520),
        dec: Angle.Degrees(-12.83836444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40605"},
        {"Hipparcos Number", "HIP 28344"},
        {"Smithsonian Astrophysical Observation", "SAO 150994"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.84254563),
        dec: Angle.Degrees(-12.83527715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180296"},
        {"Hipparcos Number", "HIP 94731"},
        {"Smithsonian Astrophysical Observation", "SAO 162393"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.13798378),
        dec: Angle.Degrees(-12.83404610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211361"},
        {"Hipparcos Number", "HIP 110000"},
        {"Geneva Identification System", "GEN# +1.00211361"},
        {"Smithsonian Astrophysical Observation", "SAO 164974"},
        {"Wilson Evans Batten Catalogue", "WEB 19748"},
    },
    visualMagnitude: 5.34,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.20018136),
        dec: Angle.Degrees(-12.83144751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109272"},
        {"Hipparcos Number", "HIP 61296"},
        {"Fundamental Katalog 5th Edition", "FK5 1321"},
        {"Geneva Identification System", "GEN# +1.00109272"},
        {"Smithsonian Astrophysical Observation", "SAO 157361"},
        {"Wilson Evans Batten Catalogue", "WEB 10908"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39278750),
        dec: Angle.Degrees(-12.83032829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220122"},
        {"Hipparcos Number", "HIP 115308"},
        {"Smithsonian Astrophysical Observation", "SAO 165642"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.30721514),
        dec: Angle.Degrees(-12.82985725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224810"},
        {"Hipparcos Number", "HIP 72"},
        {"Cincinnati Publication", "Ci 18 3151"},
        {"Smithsonian Astrophysical Observation", "SAO 165996"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.21946989),
        dec: Angle.Degrees(-12.82867015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40935"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.30355246),
        dec: Angle.Degrees(-12.82678150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18085"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.98807587),
        dec: Angle.Degrees(-12.82624740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223604"},
        {"Hipparcos Number", "HIP 117595"},
        {"Geneva Identification System", "GEN# +1.00223604"},
        {"Smithsonian Astrophysical Observation", "SAO 165917"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.73026711),
        dec: Angle.Degrees(-12.82076175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94072"},
        {"Hipparcos Number", "HIP 53058"},
        {"Geneva Identification System", "GEN# +1.00094072"},
        {"Smithsonian Astrophysical Observation", "SAO 156275"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.83895381),
        dec: Angle.Degrees(-12.81998446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64077"},
        {"Hipparcos Number", "HIP 38372"},
        {"Geneva Identification System", "GEN# +1.00064077"},
        {"Smithsonian Astrophysical Observation", "SAO 153499"},
        {"Wilson Evans Batten Catalogue", "WEB 7546"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.92035359),
        dec: Angle.Degrees(-12.81939332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76621"},
        {"Hipparcos Number", "HIP 43939"},
        {"Smithsonian Astrophysical Observation", "SAO 154784"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.24879867),
        dec: Angle.Degrees(-12.81873964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34241"},
        {"Hipparcos Number", "HIP 24499"},
        {"Geneva Identification System", "GEN# +1.00034241"},
        {"Smithsonian Astrophysical Observation", "SAO 150275"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.84144808),
        dec: Angle.Degrees(-12.81826274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88215"},
        {"Hipparcos Number", "HIP 49809"},
        {"Geneva Identification System", "GEN# +1.00088215"},
        {"Smithsonian Astrophysical Observation", "SAO 155780"},
        {"Wilson Evans Batten Catalogue", "WEB 9178"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.52483143),
        dec: Angle.Degrees(-12.81565791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112546"},
        {"Hipparcos Number", "HIP 63249"},
        {"Geneva Identification System", "GEN# +1.00112546"},
        {"Smithsonian Astrophysical Observation", "SAO 157621"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.39817305),
        dec: Angle.Degrees(-12.81251777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53756"},
        {"Hipparcos Number", "HIP 34221"},
        {"Celescope Catalog", "CEL 1569"},
        {"Geneva Identification System", "GEN# +1.00053756"},
        {"Smithsonian Astrophysical Observation", "SAO 152360"},
        {"Wilson Evans Batten Catalogue", "WEB 6852"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.42538773),
        dec: Angle.Degrees(-12.81184455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102697"},
        {"Hipparcos Number", "HIP 57654"},
        {"Geneva Identification System", "GEN# +1.00102697"},
        {"Smithsonian Astrophysical Observation", "SAO 156912"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.35832882),
        dec: Angle.Degrees(-12.81036167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55854"},
        {"Hipparcos Number", "HIP 34976"},
        {"Celescope Catalog", "CEL 1689"},
        {"Geneva Identification System", "GEN# +1.00055854"},
        {"Smithsonian Astrophysical Observation", "SAO 152591"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54797996),
        dec: Angle.Degrees(-12.80994071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197801"},
        {"Hipparcos Number", "HIP 102493"},
        {"Smithsonian Astrophysical Observation", "SAO 163864"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.56608413),
        dec: Angle.Degrees(-12.80979568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75881"},
        {"Hipparcos Number", "HIP 43565"},
        {"Fundamental Katalog 5th Edition", "FK5 2703"},
        {"Geneva Identification System", "GEN# +1.00075881"},
        {"Smithsonian Astrophysical Observation", "SAO 154701"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.08511487),
        dec: Angle.Degrees(-12.80844106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38712"},
        {"Hipparcos Number", "HIP 27318"},
        {"Smithsonian Astrophysical Observation", "SAO 150808"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.80832449),
        dec: Angle.Degrees(-12.80469893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66221"},
        {"Hipparcos Number", "HIP 39298"},
        {"Geneva Identification System", "GEN# +1.00066221"},
        {"Smithsonian Astrophysical Observation", "SAO 153736"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.52266402),
        dec: Angle.Degrees(-12.80408027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193209"},
        {"Hipparcos Number", "HIP 100202"},
        {"Geneva Identification System", "GEN# +1.00193209"},
        {"Smithsonian Astrophysical Observation", "SAO 163447"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.85901317),
        dec: Angle.Degrees(-12.80379241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18532"},
        {"Hipparcos Number", "HIP 13857"},
        {"Geneva Identification System", "GEN# +1.00018532"},
        {"Smithsonian Astrophysical Observation", "SAO 148692"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.60297027),
        dec: Angle.Degrees(-12.80210565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212654"},
        {"Hipparcos Number", "HIP 110741"},
        {"Smithsonian Astrophysical Observation", "SAO 165069"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.53547405),
        dec: Angle.Degrees(-12.80046669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179849"},
        {"Hipparcos Number", "HIP 94559"},
        {"Smithsonian Astrophysical Observation", "SAO 162358"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66641255),
        dec: Angle.Degrees(-12.80032571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9878"},
        {"Smithsonian Astrophysical Observation", "SAO 148212"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.78472998),
        dec: Angle.Degrees(-12.79999709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149123"},
        {"Hipparcos Number", "HIP 81047"},
        {"Geneva Identification System", "GEN# +1.00149123"},
        {"Smithsonian Astrophysical Observation", "SAO 159973"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.30093680),
        dec: Angle.Degrees(-12.79883112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85182"},
        {"Hipparcos Number", "HIP 48225"},
        {"Geneva Identification System", "GEN# +1.00085182"},
        {"Smithsonian Astrophysical Observation", "SAO 155519"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.48971035),
        dec: Angle.Degrees(-12.79880450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175831"},
        {"Hipparcos Number", "HIP 93088"},
        {"Geneva Identification System", "GEN# +1.00175831"},
        {"Smithsonian Astrophysical Observation", "SAO 162026"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.44462891),
        dec: Angle.Degrees(-12.79873825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219679"},
        {"Hipparcos Number", "HIP 115021"},
        {"Smithsonian Astrophysical Observation", "SAO 165611"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.43532439),
        dec: Angle.Degrees(-12.79478669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66051"},
        {"Hipparcos Number", "HIP 39229"},
        {"Fundamental Katalog 5th Edition", "FK5 4720"},
        {"Geneva Identification System", "GEN# +1.00066051"},
        {"Renson", "Renson 18190"},
        {"Smithsonian Astrophysical Observation", "SAO 153725"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.35267463),
        dec: Angle.Degrees(-12.79325878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25723"},
        {"Hipparcos Number", "HIP 19011"},
        {"Geneva Identification System", "GEN# +1.00025723"},
        {"Smithsonian Astrophysical Observation", "SAO 149351"},
        {"Wilson Evans Batten Catalogue", "WEB 3656"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.09461008),
        dec: Angle.Degrees(-12.79233884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217931"},
        {"Hipparcos Number", "HIP 113925"},
        {"Geneva Identification System", "GEN# +1.00217931"},
        {"Smithsonian Astrophysical Observation", "SAO 165472"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.05559806),
        dec: Angle.Degrees(-12.79075387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106158"},
        {"Hipparcos Number", "HIP 59569"},
        {"Geneva Identification System", "GEN# +1.00106158"},
        {"Smithsonian Astrophysical Observation", "SAO 157151"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23666604),
        dec: Angle.Degrees(-12.79050258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92996"},
        {"Hipparcos Number", "HIP 52509"},
        {"Smithsonian Astrophysical Observation", "SAO 156189"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.05001562),
        dec: Angle.Degrees(-12.79042989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97494"},
        {"Hipparcos Number", "HIP 54782"},
        {"Geneva Identification System", "GEN# +1.00097494"},
        {"Smithsonian Astrophysical Observation", "SAO 156537"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.23592867),
        dec: Angle.Degrees(-12.78514370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206893"},
        {"Hipparcos Number", "HIP 107412"},
        {"Geneva Identification System", "GEN# +1.00206893"},
        {"Smithsonian Astrophysical Observation", "SAO 164627"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.34103647),
        dec: Angle.Degrees(-12.78335331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119009"},
        {"Hipparcos Number", "HIP 66758"},
        {"Smithsonian Astrophysical Observation", "SAO 158085"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.24874931),
        dec: Angle.Degrees(-12.78290848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38368"},
        {"Hipparcos Number", "HIP 27089"},
        {"Smithsonian Astrophysical Observation", "SAO 150756"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.16347872),
        dec: Angle.Degrees(-12.77669066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138061"},
        {"Hipparcos Number", "HIP 75885"},
        {"Geneva Identification System", "GEN# +1.00138061"},
        {"Smithsonian Astrophysical Observation", "SAO 159298"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.49977696),
        dec: Angle.Degrees(-12.77655533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37567"},
        {"Hipparcos Number", "HIP 26565"},
        {"Smithsonian Astrophysical Observation", "SAO 150648"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.72446894),
        dec: Angle.Degrees(-12.77602976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155566"},
        {"Hipparcos Number", "HIP 84220"},
        {"Smithsonian Astrophysical Observation", "SAO 160370"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.22997327),
        dec: Angle.Degrees(-12.77391016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204515"},
        {"Hipparcos Number", "HIP 106089"},
        {"Fundamental Katalog 5th Edition", "FK5 5893"},
        {"Geneva Identification System", "GEN# +1.00204515"},
        {"Smithsonian Astrophysical Observation", "SAO 164426"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.34640736),
        dec: Angle.Degrees(-12.77165626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8361"},
        {"Geneva Identification System", "GEN# -0.01300321"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.93002703),
        dec: Angle.Degrees(-12.77105908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 252.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 164.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164856"},
        {"Hipparcos Number", "HIP 88462"},
        {"Smithsonian Astrophysical Observation", "SAO 161032"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.92784690),
        dec: Angle.Degrees(-12.76941970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17925"},
        {"Hipparcos Number", "HIP 13402"},
        {"Cincinnati Publication", "Ci 20 190"},
        {"Cincinnati Publication 2", "Ci 18 373"},
        {"Geneva Identification System", "GEN# +1.00017925"},
        {"Smithsonian Astrophysical Observation", "SAO 148647"},
        {"Wilson Evans Batten Catalogue", "WEB 2683"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.13287752),
        dec: Angle.Degrees(-12.76925369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 398.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132309"},
        {"Hipparcos Number", "HIP 73291"},
        {"Smithsonian Astrophysical Observation", "SAO 158942"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.67779504),
        dec: Angle.Degrees(-12.76837344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39513"},
        {"Hipparcos Number", "HIP 27774"},
        {"Geneva Identification System", "GEN# +1.00039513"},
        {"Smithsonian Astrophysical Observation", "SAO 150897"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.15859006),
        dec: Angle.Degrees(-12.76780499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31923"},
        {"Hipparcos Number", "HIP 23172"},
        {"Smithsonian Astrophysical Observation", "SAO 150051"},
        {"Wilson Evans Batten Catalogue", "WEB 4496"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.77408649),
        dec: Angle.Degrees(-12.76692303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71072"},
        {"Hipparcos Number", "HIP 41255"},
        {"Smithsonian Astrophysical Observation", "SAO 154230"},
        {"Wilson Evans Batten Catalogue", "WEB 7981"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.25167372),
        dec: Angle.Degrees(-12.76478989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58191"},
        {"Hipparcos Number", "HIP 35899"},
        {"Geneva Identification System", "GEN# +1.00058191"},
        {"Smithsonian Astrophysical Observation", "SAO 152820"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.00889642),
        dec: Angle.Degrees(-12.76336616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90320"},
        {"Hipparcos Number", "HIP 51026"},
        {"Geneva Identification System", "GEN# +1.00090320"},
        {"Smithsonian Astrophysical Observation", "SAO 155970"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.36675691),
        dec: Angle.Degrees(-12.76268789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25774"},
        {"Smithsonian Astrophysical Observation", "SAO 150502"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.55522235),
        dec: Angle.Degrees(-12.76254736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41419"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.72257960),
        dec: Angle.Degrees(-12.76179670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 273.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14448"},
        {"Hipparcos Number", "HIP 10850"},
        {"Geneva Identification System", "GEN# +1.00014448"},
        {"Smithsonian Astrophysical Observation", "SAO 148332"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.91468788),
        dec: Angle.Degrees(-12.76144446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217250"},
        {"Hipparcos Number", "HIP 113529"},
        {"Smithsonian Astrophysical Observation", "SAO 165423"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.89166292),
        dec: Angle.Degrees(-12.76044895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140031"},
        {"Hipparcos Number", "HIP 76876"},
        {"Smithsonian Astrophysical Observation", "SAO 159443"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.47322897),
        dec: Angle.Degrees(-12.75992828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100310",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alshat"},
        {"Aitken", "ADS 13714 A"},
        {"Henry Draper", "HD 193432"},
        {"Hipparcos Number", "HIP 100310"},
        {"Geneva Identification System", "GEN# +1.00193432"},
        {"Smithsonian Astrophysical Observation", "SAO 163468"},
        {"Wilson Evans Batten Catalogue", "WEB 18091"},
    },
    visualMagnitude: 4.77,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.16586145),
        dec: Angle.Degrees(-12.75904403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185160"},
        {"Hipparcos Number", "HIP 96587"},
        {"Geneva Identification System", "GEN# +1.00185160"},
        {"Smithsonian Astrophysical Observation", "SAO 162839"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.53701816),
        dec: Angle.Degrees(-12.75802047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117262",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16989 AB"},
        {"Henry Draper", "HD 223085"},
        {"Hipparcos Number", "HIP 117262"},
        {"Smithsonian Astrophysical Observation", "SAO 165873"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.64515982),
        dec: Angle.Degrees(-12.75769764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21545"},
        {"Hipparcos Number", "HIP 16153"},
        {"Smithsonian Astrophysical Observation", "SAO 148973"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.03963628),
        dec: Angle.Degrees(-12.75402662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86592"},
        {"Hipparcos Number", "HIP 48958"},
        {"Renson", "Renson 24760"},
        {"Smithsonian Astrophysical Observation", "SAO 155635"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.80954282),
        dec: Angle.Degrees(-12.75387229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122749"},
        {"Hipparcos Number", "HIP 68713"},
        {"Smithsonian Astrophysical Observation", "SAO 158320"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00321334),
        dec: Angle.Degrees(-12.75260737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39984",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39984"},
        {"Geneva Identification System", "GEN# +2.25390021"},
        {"New General Catalogue", "NGC 2539 21"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.48886575),
        dec: Angle.Degrees(-12.74958467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146139"},
        {"Hipparcos Number", "HIP 79648"},
        {"Smithsonian Astrophysical Observation", "SAO 159813"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.80200750),
        dec: Angle.Degrees(-12.74942397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1036"},
        {"Hipparcos Number", "HIP 1177"},
        {"Smithsonian Astrophysical Observation", "SAO 147171"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.67063744),
        dec: Angle.Degrees(-12.74819936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103460"},
        {"Hipparcos Number", "HIP 58091"},
        {"Smithsonian Astrophysical Observation", "SAO 156978"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.70684192),
        dec: Angle.Degrees(-12.74761773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95519"},
        {"Hipparcos Number", "HIP 53883"},
        {"Smithsonian Astrophysical Observation", "SAO 156403"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.36272376),
        dec: Angle.Degrees(-12.74704342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31004"},
        {"Hipparcos Number", "HIP 22605"},
        {"Smithsonian Astrophysical Observation", "SAO 149944"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.95024235),
        dec: Angle.Degrees(-12.74597902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79005",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9924 A"},
        {"Henry Draper", "HD 144708"},
        {"Hipparcos Number", "HIP 79005"},
        {"Geneva Identification System", "GEN# +1.00144708"},
        {"Smithsonian Astrophysical Observation", "SAO 159715"},
        {"Wilson Evans Batten Catalogue", "WEB 13354"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90183590),
        dec: Angle.Degrees(-12.74534315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8173"},
        {"Hipparcos Number", "HIP 6305"},
        {"Smithsonian Astrophysical Observation", "SAO 147753"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.25208908),
        dec: Angle.Degrees(-12.74293775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154698"},
        {"Hipparcos Number", "HIP 83795"},
        {"Smithsonian Astrophysical Observation", "SAO 160293"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.87724404),
        dec: Angle.Degrees(-12.74262915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157262"},
        {"Hipparcos Number", "HIP 85029"},
        {"Smithsonian Astrophysical Observation", "SAO 160507"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.68608292),
        dec: Angle.Degrees(-12.74102494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138147"},
        {"Hipparcos Number", "HIP 75935"},
        {"Smithsonian Astrophysical Observation", "SAO 159306"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.64643358),
        dec: Angle.Degrees(-12.74049702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9987"},
        {"Hipparcos Number", "HIP 7555"},
        {"Smithsonian Astrophysical Observation", "SAO 147913"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.33693511),
        dec: Angle.Degrees(-12.73844504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73687"},
        {"Hipparcos Number", "HIP 42444"},
        {"Smithsonian Astrophysical Observation", "SAO 154504"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81217033),
        dec: Angle.Degrees(-12.73745694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72589"},
        {"Hipparcos Number", "HIP 41973"},
        {"Smithsonian Astrophysical Observation", "SAO 154388"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.33562475),
        dec: Angle.Degrees(-12.73714292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101706",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14054 AB"},
        {"Henry Draper", "HD 196310"},
        {"Hipparcos Number", "HIP 101706"},
        {"Smithsonian Astrophysical Observation", "SAO 163730"},
        {"Wilson Evans Batten Catalogue", "WEB 18370"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.22940795),
        dec: Angle.Degrees(-12.73705855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21918"},
        {"Hipparcos Number", "HIP 16435"},
        {"Renson", "Renson 5514"},
        {"Smithsonian Astrophysical Observation", "SAO 149015"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.90300431),
        dec: Angle.Degrees(-12.73476572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82129"},
        {"Hipparcos Number", "HIP 46567"},
        {"Smithsonian Astrophysical Observation", "SAO 155238"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.45373207),
        dec: Angle.Degrees(-12.73400382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24539"},
        {"Hipparcos Number", "HIP 18223"},
        {"Smithsonian Astrophysical Observation", "SAO 149234"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.44422140),
        dec: Angle.Degrees(-12.73333987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9890"},
        {"Hipparcos Number", "HIP 7485"},
        {"Smithsonian Astrophysical Observation", "SAO 147905"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.09710438),
        dec: Angle.Degrees(-12.73288172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218304"},
        {"Hipparcos Number", "HIP 114143"},
        {"Smithsonian Astrophysical Observation", "SAO 165502"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.74661834),
        dec: Angle.Degrees(-12.73017232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155612"},
        {"Hipparcos Number", "HIP 84243"},
        {"Geneva Identification System", "GEN# +1.00155612"},
        {"Smithsonian Astrophysical Observation", "SAO 160372"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.30839490),
        dec: Angle.Degrees(-12.73000329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38609"},
        {"Hipparcos Number", "HIP 27250"},
        {"Smithsonian Astrophysical Observation", "SAO 150794"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.62870993),
        dec: Angle.Degrees(-12.72880108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11489"},
        {"Hipparcos Number", "HIP 8759"},
        {"Smithsonian Astrophysical Observation", "SAO 148077"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.17618084),
        dec: Angle.Degrees(-12.72795071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34227"},
        {"Hipparcos Number", "HIP 24492"},
        {"Smithsonian Astrophysical Observation", "SAO 150273"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.82589768),
        dec: Angle.Degrees(-12.72763908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186498"},
        {"Hipparcos Number", "HIP 97182"},
        {"Smithsonian Astrophysical Observation", "SAO 162948"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.29011342),
        dec: Angle.Degrees(-12.72626111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207503"},
        {"Hipparcos Number", "HIP 107750"},
        {"Geneva Identification System", "GEN# +1.00207503"},
        {"Renson", "Renson 57730"},
        {"Smithsonian Astrophysical Observation", "SAO 164679"},
        {"Wilson Evans Batten Catalogue", "WEB 19431"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.42093121),
        dec: Angle.Degrees(-12.72291549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2860 AB"},
        {"Henry Draper", "HD 24624"},
        {"Hipparcos Number", "HIP 18272"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.63260519),
        dec: Angle.Degrees(-12.72188647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129193"},
        {"Hipparcos Number", "HIP 71823"},
        {"Smithsonian Astrophysical Observation", "SAO 158734"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.38443947),
        dec: Angle.Degrees(-12.72022117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68687"},
        {"Hipparcos Number", "HIP 40237"},
        {"Smithsonian Astrophysical Observation", "SAO 153987"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.27937864),
        dec: Angle.Degrees(-12.71936144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195795"},
        {"Hipparcos Number", "HIP 101468"},
        {"Smithsonian Astrophysical Observation", "SAO 163680"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.45348482),
        dec: Angle.Degrees(-12.71820649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50190"},
        {"Hipparcos Number", "HIP 32932"},
        {"Smithsonian Astrophysical Observation", "SAO 152019"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.91460100),
        dec: Angle.Degrees(-12.71340042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144310"},
        {"Hipparcos Number", "HIP 78838"},
        {"Geneva Identification System", "GEN# +1.00144310"},
        {"Smithsonian Astrophysical Observation", "SAO 159685"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.40775860),
        dec: Angle.Degrees(-12.71217958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177012"},
        {"Hipparcos Number", "HIP 93560"},
        {"Smithsonian Astrophysical Observation", "SAO 162143"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.84222622),
        dec: Angle.Degrees(-12.70952479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9512"},
        {"Hipparcos Number", "HIP 7233"},
        {"Cincinnati Publication", "Ci 18 207"},
        {"Geneva Identification System", "GEN# +1.00009512"},
        {"Smithsonian Astrophysical Observation", "SAO 147881"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.31369092),
        dec: Angle.Degrees(-12.70834872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 154.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20248"},
        {"Hipparcos Number", "HIP 15121"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.74158936),
        dec: Angle.Degrees(-12.70785086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116870"},
        {"Hipparcos Number", "HIP 65581"},
        {"Fundamental Katalog 5th Edition", "FK5 1348"},
        {"Geneva Identification System", "GEN# +1.00116870"},
        {"Smithsonian Astrophysical Observation", "SAO 157938"},
        {"Wilson Evans Batten Catalogue", "WEB 11590"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.68018558),
        dec: Angle.Degrees(-12.70761258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189853"},
        {"Hipparcos Number", "HIP 98680"},
        {"Smithsonian Astrophysical Observation", "SAO 163202"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.64545402),
        dec: Angle.Degrees(-12.70757554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122124"},
        {"Hipparcos Number", "HIP 68396"},
        {"Smithsonian Astrophysical Observation", "SAO 158283"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01790712),
        dec: Angle.Degrees(-12.70643754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73414"},
        {"Hipparcos Number", "HIP 42336"},
        {"Smithsonian Astrophysical Observation", "SAO 154470"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.47114308),
        dec: Angle.Degrees(-12.70591725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123087"},
        {"Hipparcos Number", "HIP 68847"},
        {"Geneva Identification System", "GEN# +1.00123087"},
        {"Smithsonian Astrophysical Observation", "SAO 158343"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.46687261),
        dec: Angle.Degrees(-12.70313756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218854"},
        {"Hipparcos Number", "HIP 114499"},
        {"Smithsonian Astrophysical Observation", "SAO 165542"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.84520584),
        dec: Angle.Degrees(-12.70177223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155213"},
        {"Hipparcos Number", "HIP 84034"},
        {"Smithsonian Astrophysical Observation", "SAO 160337"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.68099690),
        dec: Angle.Degrees(-12.70108755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40604"},
        {"Hipparcos Number", "HIP 28350"},
        {"Geneva Identification System", "GEN# +1.00040604"},
        {"Smithsonian Astrophysical Observation", "SAO 150996"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.85737981),
        dec: Angle.Degrees(-12.70105682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152016"},
        {"Hipparcos Number", "HIP 82481"},
        {"Smithsonian Astrophysical Observation", "SAO 160131"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.85488401),
        dec: Angle.Degrees(-12.69959281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37374"},
        {"Hipparcos Number", "HIP 26440"},
        {"Smithsonian Astrophysical Observation", "SAO 150628"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.39510137),
        dec: Angle.Degrees(-12.69925652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98727"},
        {"Hipparcos Number", "HIP 55464"},
        {"Geneva Identification System", "GEN# +1.00098727"},
        {"Smithsonian Astrophysical Observation", "SAO 156625"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.37941166),
        dec: Angle.Degrees(-12.69870623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147179"},
        {"Hipparcos Number", "HIP 80087"},
        {"Smithsonian Astrophysical Observation", "SAO 159869"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.19309353),
        dec: Angle.Degrees(-12.69791901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141145"},
        {"Hipparcos Number", "HIP 77392"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.97972017),
        dec: Angle.Degrees(-12.69613255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216144"},
        {"Hipparcos Number", "HIP 112799"},
        {"Smithsonian Astrophysical Observation", "SAO 165330"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.64207942),
        dec: Angle.Degrees(-12.69142354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3908"},
        {"Hipparcos Number", "HIP 3255"},
        {"Geneva Identification System", "GEN# +1.00003908"},
        {"Smithsonian Astrophysical Observation", "SAO 147402"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.36923007),
        dec: Angle.Degrees(-12.69042180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169515"},
        {"Hipparcos Number", "HIP 90303"},
        {"Geneva Identification System", "GEN# +1.00169515"},
        {"Smithsonian Astrophysical Observation", "SAO 161458"},
        {"Wilson Evans Batten Catalogue", "WEB 15453"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.38115576),
        dec: Angle.Degrees(-12.69004924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14205"},
        {"Hipparcos Number", "HIP 10686"},
        {"Smithsonian Astrophysical Observation", "SAO 148311"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.38719431),
        dec: Angle.Degrees(-12.68758079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215261"},
        {"Hipparcos Number", "HIP 112238"},
        {"Smithsonian Astrophysical Observation", "SAO 165257"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.01267281),
        dec: Angle.Degrees(-12.68612976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182343"},
        {"Hipparcos Number", "HIP 95424"},
        {"Smithsonian Astrophysical Observation", "SAO 162576"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17087802),
        dec: Angle.Degrees(-12.68276029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90115"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.84496560),
        dec: Angle.Degrees(-12.68104573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64691"},
        {"Hipparcos Number", "HIP 38633"},
        {"Smithsonian Astrophysical Observation", "SAO 153573"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.66526620),
        dec: Angle.Degrees(-12.68063695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146214"},
        {"Hipparcos Number", "HIP 79667"},
        {"Geneva Identification System", "GEN# +1.00146214"},
        {"Smithsonian Astrophysical Observation", "SAO 159816"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.88859685),
        dec: Angle.Degrees(-12.68003873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11227"},
        {"Hipparcos Number", "HIP 8542"},
        {"Smithsonian Astrophysical Observation", "SAO 148048"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.53231619),
        dec: Angle.Degrees(-12.67951761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109057"},
        {"Hipparcos Number", "HIP 61153"},
        {"Geneva Identification System", "GEN# +1.00109057"},
        {"Smithsonian Astrophysical Observation", "SAO 157343"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.97021614),
        dec: Angle.Degrees(-12.67946720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68407"},
        {"Hipparcos Number", "HIP 40129"},
        {"Geneva Identification System", "GEN# +2.25390030"},
        {"Smithsonian Astrophysical Observation", "SAO 153952"},
        {"New General Catalogue", "NGC 2539 30"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95072037),
        dec: Angle.Degrees(-12.67881093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118038"},
        {"Hipparcos Number", "HIP 66233"},
        {"Geneva Identification System", "GEN# +1.00118038"},
        {"Smithsonian Astrophysical Observation", "SAO 158013"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.61222211),
        dec: Angle.Degrees(-12.67706749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83545",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10324 AB"},
        {"Henry Draper", "HD 154202"},
        {"Hipparcos Number", "HIP 83545"},
        {"Smithsonian Astrophysical Observation", "SAO 160261"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12323755),
        dec: Angle.Degrees(-12.67600882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63112"},
        {"Hipparcos Number", "HIP 37951"},
        {"Geneva Identification System", "GEN# +1.00063112"},
        {"Smithsonian Astrophysical Observation", "SAO 153389"},
        {"Wilson Evans Batten Catalogue", "WEB 7491"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.68633286),
        dec: Angle.Degrees(-12.67531262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169313"},
        {"Hipparcos Number", "HIP 90234"},
        {"Geneva Identification System", "GEN# +1.00169313"},
        {"Smithsonian Astrophysical Observation", "SAO 161445"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.16665745),
        dec: Angle.Degrees(-12.67508827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21688"},
        {"Hipparcos Number", "HIP 16263"},
        {"Fundamental Katalog 5th Edition", "FK5 2246"},
        {"Geneva Identification System", "GEN# +1.00021688"},
        {"Smithsonian Astrophysical Observation", "SAO 148985"},
        {"Wilson Evans Batten Catalogue", "WEB 3099"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.40009401),
        dec: Angle.Degrees(-12.67474889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98606"},
        {"Hipparcos Number", "HIP 55392"},
        {"Smithsonian Astrophysical Observation", "SAO 156619"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.13526373),
        dec: Angle.Degrees(-12.67431942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132816"},
        {"Hipparcos Number", "HIP 73508"},
        {"Smithsonian Astrophysical Observation", "SAO 158975"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.36371958),
        dec: Angle.Degrees(-12.67295336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40038"},
        {"Geneva Identification System", "GEN# +2.25390026"},
        {"New General Catalogue", "NGC 2539 26"},
        {"New General Catalogue 2", "NGC 2539 463"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.67858026),
        dec: Angle.Degrees(-12.66989351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113970"},
        {"Hipparcos Number", "HIP 64032"},
        {"Smithsonian Astrophysical Observation", "SAO 157732"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.85081284),
        dec: Angle.Degrees(-12.66818664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62308"},
        {"Hipparcos Number", "HIP 37596"},
        {"Smithsonian Astrophysical Observation", "SAO 153292"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.71374813),
        dec: Angle.Degrees(-12.66808960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49699"},
        {"Hipparcos Number", "HIP 32696"},
        {"Geneva Identification System", "GEN# +1.00049699"},
        {"Smithsonian Astrophysical Observation", "SAO 151964"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31612619),
        dec: Angle.Degrees(-12.66792673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190454"},
        {"Hipparcos Number", "HIP 98953"},
        {"Geneva Identification System", "GEN# +1.00190454"},
        {"Smithsonian Astrophysical Observation", "SAO 163253"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.35971082),
        dec: Angle.Degrees(-12.66504590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208704"},
        {"Hipparcos Number", "HIP 108468"},
        {"Geneva Identification System", "GEN# +1.00208704"},
        {"Smithsonian Astrophysical Observation", "SAO 164779"},
        {"Wilson Evans Batten Catalogue", "WEB 19530"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.60127428),
        dec: Angle.Degrees(-12.66480802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221575"},
        {"Hipparcos Number", "HIP 116258"},
        {"Cincinnati Publication", "Ci 18 3084"},
        {"Smithsonian Astrophysical Observation", "SAO 165764"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.34881296),
        dec: Angle.Degrees(-12.66467637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187208"},
        {"Hipparcos Number", "HIP 97526"},
        {"Smithsonian Astrophysical Observation", "SAO 163017"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.32358454),
        dec: Angle.Degrees(-12.66387619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74798"},
        {"Hipparcos Number", "HIP 42992"},
        {"Smithsonian Astrophysical Observation", "SAO 154611"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.44351320),
        dec: Angle.Degrees(-12.66372531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117733"},
        {"Hipparcos Number", "HIP 66045"},
        {"Fundamental Katalog 5th Edition", "FK5 5194"},
        {"Geneva Identification System", "GEN# +1.00117733"},
        {"Smithsonian Astrophysical Observation", "SAO 157992"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.10311533),
        dec: Angle.Degrees(-12.66308354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13051"},
        {"Smithsonian Astrophysical Observation", "SAO 148609"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.92957772),
        dec: Angle.Degrees(-12.66092425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80824"},
        {"Cincinnati Publication", "Ci 20 995"},
        {"Geneva Identification System", "GEN# -0.01204523"},
        {"Wilson Evans Batten Catalogue", "WEB 13669"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.57547824),
        dec: Angle.Degrees(-12.65971367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1184.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11792"},
        {"Hipparcos Number", "HIP 8967"},
        {"Smithsonian Astrophysical Observation", "SAO 148108"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.87713735),
        dec: Angle.Degrees(-12.65831740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78996"},
        {"Hipparcos Number", "HIP 45078"},
        {"Geneva Identification System", "GEN# +1.00078996"},
        {"Smithsonian Astrophysical Observation", "SAO 154977"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.73792702),
        dec: Angle.Degrees(-12.65528596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115693"},
        {"Hipparcos Number", "HIP 64971"},
        {"Geneva Identification System", "GEN# +1.00115693"},
        {"Smithsonian Astrophysical Observation", "SAO 157849"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.74455723),
        dec: Angle.Degrees(-12.64808549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12505 AB"},
        {"Henry Draper", "HD 183347"},
        {"Hipparcos Number", "HIP 95847"},
        {"Smithsonian Astrophysical Observation", "SAO 162674"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.40750570),
        dec: Angle.Degrees(-12.64662257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131726"},
        {"Hipparcos Number", "HIP 73044"},
        {"Smithsonian Astrophysical Observation", "SAO 158897"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.92518153),
        dec: Angle.Degrees(-12.64454048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131253"},
        {"Hipparcos Number", "HIP 72811"},
        {"Geneva Identification System", "GEN# +1.00131253"},
        {"Smithsonian Astrophysical Observation", "SAO 158875"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22865374),
        dec: Angle.Degrees(-12.64399568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3783"},
        {"Smithsonian Astrophysical Observation", "SAO 147457"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.15363943),
        dec: Angle.Degrees(-12.63906469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57568"},
        {"Hipparcos Number", "HIP 35651"},
        {"Cincinnati Publication", "Ci 20 421"},
        {"Geneva Identification System", "GEN# +1.00057568"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34484760),
        dec: Angle.Degrees(-12.63835546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 460.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132072"},
        {"Hipparcos Number", "HIP 73200"},
        {"Smithsonian Astrophysical Observation", "SAO 158927"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.40280349),
        dec: Angle.Degrees(-12.63801934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95402"},
        {"Hipparcos Number", "HIP 53820"},
        {"Geneva Identification System", "GEN# +1.00095402"},
        {"Smithsonian Astrophysical Observation", "SAO 156391"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.17382081),
        dec: Angle.Degrees(-12.63791804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72059"},
        {"Hipparcos Number", "HIP 41722"},
        {"Smithsonian Astrophysical Observation", "SAO 154328"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.61861431),
        dec: Angle.Degrees(-12.63369058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42207"},
        {"Hipparcos Number", "HIP 29145"},
        {"Smithsonian Astrophysical Observation", "SAO 151158"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.23007997),
        dec: Angle.Degrees(-12.63326175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28807"},
        {"Hipparcos Number", "HIP 21143"},
        {"Geneva Identification System", "GEN# +1.00028807"},
        {"Smithsonian Astrophysical Observation", "SAO 149706"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.98717479),
        dec: Angle.Degrees(-12.63265030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52819"},
        {"Smithsonian Astrophysical Observation", "SAO 156240"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.98629070),
        dec: Angle.Degrees(-12.63253932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201418"},
        {"Hipparcos Number", "HIP 104465"},
        {"Smithsonian Astrophysical Observation", "SAO 164184"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.42472207),
        dec: Angle.Degrees(-12.63182881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14809"},
        {"Hipparcos Number", "HIP 11094"},
        {"Smithsonian Astrophysical Observation", "SAO 148363"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71712495),
        dec: Angle.Degrees(-12.63061932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69830"},
        {"Hipparcos Number", "HIP 40693"},
        {"Cincinnati Publication", "Ci 20 471"},
        {"Geneva Identification System", "GEN# +1.00069830"},
        {"Smithsonian Astrophysical Observation", "SAO 154093"},
        {"Wilson Evans Batten Catalogue", "WEB 7906"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59908460),
        dec: Angle.Degrees(-12.62976955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -989.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18920"},
        {"Hipparcos Number", "HIP 14136"},
        {"Smithsonian Astrophysical Observation", "SAO 148725"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.57053600),
        dec: Angle.Degrees(-12.62888348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117128"},
        {"Hipparcos Number", "HIP 65724"},
        {"Smithsonian Astrophysical Observation", "SAO 157956"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.10947160),
        dec: Angle.Degrees(-12.62874022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117483"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.33898656),
        dec: Angle.Degrees(-12.62655519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206032"},
        {"Hipparcos Number", "HIP 106951"},
        {"Smithsonian Astrophysical Observation", "SAO 164557"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.91327101),
        dec: Angle.Degrees(-12.62227870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141798"},
        {"Hipparcos Number", "HIP 77666"},
        {"Geneva Identification System", "GEN# +1.00141798"},
        {"Renson", "Renson 40253"},
        {"Smithsonian Astrophysical Observation", "SAO 159539"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.83480441),
        dec: Angle.Degrees(-12.62209915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115277"},
        {"Hipparcos Number", "HIP 64750"},
        {"Smithsonian Astrophysical Observation", "SAO 157826"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.05696398),
        dec: Angle.Degrees(-12.62117218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187663"},
        {"Hipparcos Number", "HIP 97726"},
        {"Smithsonian Astrophysical Observation", "SAO 163048"},
        {"Wilson Evans Batten Catalogue", "WEB 17191"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.89686921),
        dec: Angle.Degrees(-12.62111007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218614"},
        {"Hipparcos Number", "HIP 114340"},
        {"Smithsonian Astrophysical Observation", "SAO 165517"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.36147800),
        dec: Angle.Degrees(-12.61830514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113081"},
        {"Hipparcos Number", "HIP 63543"},
        {"Smithsonian Astrophysical Observation", "SAO 157654"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.31590730),
        dec: Angle.Degrees(-12.61787692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191862"},
        {"Hipparcos Number", "HIP 99572"},
        {"Geneva Identification System", "GEN# +1.00191862"},
        {"Smithsonian Astrophysical Observation", "SAO 163337"},
        {"Wilson Evans Batten Catalogue", "WEB 17816"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.10731366),
        dec: Angle.Degrees(-12.61702214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17191",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2690 A"},
        {"Henry Draper", "HD 22968"},
        {"Hipparcos Number", "HIP 17191"},
        {"Geneva Identification System", "GEN# +1.00022968"},
        {"Smithsonian Astrophysical Observation", "SAO 149104"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.21495881),
        dec: Angle.Degrees(-12.61588589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182342"},
        {"Hipparcos Number", "HIP 95426"},
        {"Geneva Identification System", "GEN# +1.00182342"},
        {"Smithsonian Astrophysical Observation", "SAO 162577"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17298846),
        dec: Angle.Degrees(-12.61556995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102652"},
        {"Hipparcos Number", "HIP 57634"},
        {"Smithsonian Astrophysical Observation", "SAO 156908"},
        {"Wilson Evans Batten Catalogue", "WEB 10350"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.26965477),
        dec: Angle.Degrees(-12.61503736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111870",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16145 AB"},
        {"Henry Draper", "HD 214615"},
        {"Hipparcos Number", "HIP 111870"},
        {"Geneva Identification System", "GEN# +1.00214615J"},
        {"Smithsonian Astrophysical Observation", "SAO 165218"},
        {"Wilson Evans Batten Catalogue", "WEB 19981"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.89370831),
        dec: Angle.Degrees(-12.61481412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83986"},
        {"Hipparcos Number", "HIP 47554"},
        {"Geneva Identification System", "GEN# +1.00083986"},
        {"Smithsonian Astrophysical Observation", "SAO 155404"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.43628338),
        dec: Angle.Degrees(-12.61406960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172089"},
        {"Hipparcos Number", "HIP 91428"},
        {"Smithsonian Astrophysical Observation", "SAO 161691"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.68011944),
        dec: Angle.Degrees(-12.61294477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124106"},
        {"Hipparcos Number", "HIP 69357"},
        {"Geneva Identification System", "GEN# +1.00124106"},
        {"Smithsonian Astrophysical Observation", "SAO 158416"},
        {"Wilson Evans Batten Catalogue", "WEB 12094"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.94302002),
        dec: Angle.Degrees(-12.61132994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -257.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198206"},
        {"Hipparcos Number", "HIP 102738"},
        {"Geneva Identification System", "GEN# +1.00198206"},
        {"Smithsonian Astrophysical Observation", "SAO 163905"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.26716600),
        dec: Angle.Degrees(-12.61058616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156540"},
        {"Hipparcos Number", "HIP 84674"},
        {"Smithsonian Astrophysical Observation", "SAO 160446"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.66167858),
        dec: Angle.Degrees(-12.60955679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162118"},
        {"Hipparcos Number", "HIP 87268"},
        {"Smithsonian Astrophysical Observation", "SAO 160845"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48129659),
        dec: Angle.Degrees(-12.60924043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221564"},
        {"Hipparcos Number", "HIP 116245"},
        {"Geneva Identification System", "GEN# +1.00221564"},
        {"Smithsonian Astrophysical Observation", "SAO 165761"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.30807757),
        dec: Angle.Degrees(-12.60909529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64967"},
        {"Hipparcos Number", "HIP 38748"},
        {"Smithsonian Astrophysical Observation", "SAO 153599"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.99422811),
        dec: Angle.Degrees(-12.60839602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46828"},
        {"Hipparcos Number", "HIP 31415"},
        {"Geneva Identification System", "GEN# +1.00046828"},
        {"Smithsonian Astrophysical Observation", "SAO 151665"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76235795),
        dec: Angle.Degrees(-12.60728529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55562"},
        {"Hipparcos Number", "HIP 34878"},
        {"Celescope Catalog", "CEL 1678"},
        {"Geneva Identification System", "GEN# +1.00055562"},
        {"Smithsonian Astrophysical Observation", "SAO 152563"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.24211706),
        dec: Angle.Degrees(-12.60582952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148151"},
        {"Hipparcos Number", "HIP 80537"},
        {"Geneva Identification System", "GEN# +1.00148151"},
        {"Smithsonian Astrophysical Observation", "SAO 159914"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.63188763),
        dec: Angle.Degrees(-12.60467371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25634"},
        {"Smithsonian Astrophysical Observation", "SAO 150485"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.13026310),
        dec: Angle.Degrees(-12.60104086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42711"},
        {"Hipparcos Number", "HIP 29394"},
        {"Geneva Identification System", "GEN# +1.00042711"},
        {"Smithsonian Astrophysical Observation", "SAO 151204"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92019302),
        dec: Angle.Degrees(-12.59873427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207006"},
        {"Hipparcos Number", "HIP 107491"},
        {"Geneva Identification System", "GEN# +1.00207006"},
        {"Smithsonian Astrophysical Observation", "SAO 164636"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.57507319),
        dec: Angle.Degrees(-12.59859419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202784"},
        {"Hipparcos Number", "HIP 105194"},
        {"Smithsonian Astrophysical Observation", "SAO 164293"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.63837160),
        dec: Angle.Degrees(-12.59586852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2367 A"},
        {"Henry Draper", "HD 19544"},
        {"Hipparcos Number", "HIP 14584"},
        {"Smithsonian Astrophysical Observation", "SAO 148788"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.06957003),
        dec: Angle.Degrees(-12.59317025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97918"},
        {"Hipparcos Number", "HIP 54999"},
        {"Geneva Identification System", "GEN# +1.00097918"},
        {"Smithsonian Astrophysical Observation", "SAO 156568"},
        {"Wilson Evans Batten Catalogue", "WEB 9924"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.91571154),
        dec: Angle.Degrees(-12.59254124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33162"},
        {"Hipparcos Number", "HIP 23874"},
        {"Smithsonian Astrophysical Observation", "SAO 150166"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.95758678),
        dec: Angle.Degrees(-12.59244155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195075"},
        {"Hipparcos Number", "HIP 101088"},
        {"Fundamental Katalog 5th Edition", "FK5 5807"},
        {"Smithsonian Astrophysical Observation", "SAO 163621"},
        {"Wilson Evans Batten Catalogue", "WEB 18257"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.37507384),
        dec: Angle.Degrees(-12.59136905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170516"},
        {"Hipparcos Number", "HIP 90701"},
        {"Smithsonian Astrophysical Observation", "SAO 161545"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.58042278),
        dec: Angle.Degrees(-12.59125154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81030"},
        {"Geneva Identification System", "GEN# -0.01204542"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.24195312),
        dec: Angle.Degrees(-12.59118068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -312.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69488"},
        {"Hipparcos Number", "HIP 40553"},
        {"Smithsonian Astrophysical Observation", "SAO 154060"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.21737419),
        dec: Angle.Degrees(-12.59076002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176078"},
        {"Hipparcos Number", "HIP 93200"},
        {"Geneva Identification System", "GEN# +1.00176078"},
        {"Smithsonian Astrophysical Observation", "SAO 162043"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.75544904),
        dec: Angle.Degrees(-12.58778585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82658"},
        {"Hipparcos Number", "HIP 46861"},
        {"Geneva Identification System", "GEN# +1.00082658"},
        {"Smithsonian Astrophysical Observation", "SAO 155283"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.23743427),
        dec: Angle.Degrees(-12.58764751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173388"},
        {"Hipparcos Number", "HIP 92034"},
        {"Geneva Identification System", "GEN# +1.00173388"},
        {"Smithsonian Astrophysical Observation", "SAO 161796"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.39135512),
        dec: Angle.Degrees(-12.58750098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73332"},
        {"Hipparcos Number", "HIP 42309"},
        {"Geneva Identification System", "GEN# +1.00073332"},
        {"Smithsonian Astrophysical Observation", "SAO 154464"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.39079226),
        dec: Angle.Degrees(-12.58576916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49888"},
        {"Hipparcos Number", "HIP 32786"},
        {"Geneva Identification System", "GEN# +1.00049888"},
        {"Smithsonian Astrophysical Observation", "SAO 151986"},
        {"Wilson Evans Batten Catalogue", "WEB 6602"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.53371347),
        dec: Angle.Degrees(-12.58476172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88788"},
        {"Hipparcos Number", "HIP 50157"},
        {"Geneva Identification System", "GEN# +1.00088788"},
        {"Smithsonian Astrophysical Observation", "SAO 155837"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.58165575),
        dec: Angle.Degrees(-12.58446475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179407"},
        {"Hipparcos Number", "HIP 94407"},
        {"Geneva Identification System", "GEN# +1.00179407"},
        {"Smithsonian Astrophysical Observation", "SAO 162319"},
        {"Wilson Evans Batten Catalogue", "WEB 16452"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.22084256),
        dec: Angle.Degrees(-12.58285090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84856"},
        {"Hipparcos Number", "HIP 48057"},
        {"Smithsonian Astrophysical Observation", "SAO 155482"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.94995388),
        dec: Angle.Degrees(-12.58038085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183426"},
        {"Hipparcos Number", "HIP 95883"},
        {"Smithsonian Astrophysical Observation", "SAO 162686"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.50849319),
        dec: Angle.Degrees(-12.58035736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111213"},
        {"Hipparcos Number", "HIP 62433"},
        {"Geneva Identification System", "GEN# +1.00111213"},
        {"Smithsonian Astrophysical Observation", "SAO 157511"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.92952532),
        dec: Angle.Degrees(-12.57986585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 645"},
        {"Hipparcos Number", "HIP 873"},
        {"Fundamental Katalog 5th Edition", "FK5 2008"},
        {"Geneva Identification System", "GEN# +1.00000645"},
        {"Smithsonian Astrophysical Observation", "SAO 147127"},
        {"Wilson Evans Batten Catalogue", "WEB 150"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.67810574),
        dec: Angle.Degrees(-12.57980381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116175"},
        {"Hipparcos Number", "HIP 65239"},
        {"Geneva Identification System", "GEN# +1.00116175"},
        {"Smithsonian Astrophysical Observation", "SAO 157886"},
        {"Wilson Evans Batten Catalogue", "WEB 11512"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.53436822),
        dec: Angle.Degrees(-12.57953334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44874"},
        {"Hipparcos Number", "HIP 30415"},
        {"Smithsonian Astrophysical Observation", "SAO 151445"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.93171133),
        dec: Angle.Degrees(-12.57866555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25165"},
        {"Hipparcos Number", "HIP 18647"},
        {"Geneva Identification System", "GEN# +1.00025165"},
        {"Smithsonian Astrophysical Observation", "SAO 149299"},
        {"Wilson Evans Batten Catalogue", "WEB 3591"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.87555244),
        dec: Angle.Degrees(-12.57433214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8562"},
        {"Hipparcos Number", "HIP 6576"},
        {"Smithsonian Astrophysical Observation", "SAO 147789"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.12601119),
        dec: Angle.Degrees(-12.56988881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2265 AB"},
        {"Henry Draper", "HD 18605"},
        {"Hipparcos Number", "HIP 13916"},
        {"Geneva Identification System", "GEN# +1.00018605"},
        {"Smithsonian Astrophysical Observation", "SAO 148698"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.81490379),
        dec: Angle.Degrees(-12.56867636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100364"},
        {"Hipparcos Number", "HIP 56320"},
        {"Geneva Identification System", "GEN# +1.00100364"},
        {"Smithsonian Astrophysical Observation", "SAO 156746"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.20226737),
        dec: Angle.Degrees(-12.56836831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188807"},
        {"Hipparcos Number", "HIP 98204"},
        {"Cincinnati Publication", "Ci 18 2599"},
        {"Cincinnati Publication 2", "Ci 20 1174"},
        {"Geneva Identification System", "GEN# +1.00188807"},
        {"Smithsonian Astrophysical Observation", "SAO 163135"},
        {"Wilson Evans Batten Catalogue", "WEB 17318"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.33207734),
        dec: Angle.Degrees(-12.56673822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -512.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200003"},
        {"Hipparcos Number", "HIP 103719"},
        {"Smithsonian Astrophysical Observation", "SAO 164063"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.26234998),
        dec: Angle.Degrees(-12.56600788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123512"},
        {"Hipparcos Number", "HIP 69082"},
        {"Smithsonian Astrophysical Observation", "SAO 158378"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10367693),
        dec: Angle.Degrees(-12.56544469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114176"},
        {"Hipparcos Number", "HIP 64164"},
        {"Smithsonian Astrophysical Observation", "SAO 157750"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.25613486),
        dec: Angle.Degrees(-12.56533867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188735"},
        {"Hipparcos Number", "HIP 98176"},
        {"Smithsonian Astrophysical Observation", "SAO 163130"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.27682862),
        dec: Angle.Degrees(-12.56513635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27912"},
        {"Hipparcos Number", "HIP 20523"},
        {"Smithsonian Astrophysical Observation", "SAO 149607"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.97178293),
        dec: Angle.Degrees(-12.56368572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82842"},
        {"Smithsonian Astrophysical Observation", "SAO 160169"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.94353700),
        dec: Angle.Degrees(-12.56257524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26374"},
        {"Hipparcos Number", "HIP 19438"},
        {"Smithsonian Astrophysical Observation", "SAO 149419"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.43774873),
        dec: Angle.Degrees(-12.56080537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21518"},
        {"Smithsonian Astrophysical Observation", "SAO 149768"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.31390147),
        dec: Angle.Degrees(-12.56027830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149165"},
        {"Hipparcos Number", "HIP 81069"},
        {"Geneva Identification System", "GEN# +1.00149165"},
        {"Smithsonian Astrophysical Observation", "SAO 159975"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.38004280),
        dec: Angle.Degrees(-12.56024192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215047"},
        {"Hipparcos Number", "HIP 112111"},
        {"Smithsonian Astrophysical Observation", "SAO 165243"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.63439754),
        dec: Angle.Degrees(-12.55969134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46185"},
        {"Hipparcos Number", "HIP 31088"},
        {"Smithsonian Astrophysical Observation", "SAO 151604"},
        {"Wilson Evans Batten Catalogue", "WEB 6192"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.85099209),
        dec: Angle.Degrees(-12.55968565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39035"},
        {"Hipparcos Number", "HIP 27506"},
        {"Smithsonian Astrophysical Observation", "SAO 150842"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.36462558),
        dec: Angle.Degrees(-12.55908489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95423"},
        {"Hipparcos Number", "HIP 53841"},
        {"Smithsonian Astrophysical Observation", "SAO 156394"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.21496285),
        dec: Angle.Degrees(-12.55871508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19948"},
        {"Geneva Identification System", "GEN# +9.80160061"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.17383394),
        dec: Angle.Degrees(-12.55691853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 211.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173991"},
        {"Hipparcos Number", "HIP 92309"},
        {"Smithsonian Astrophysical Observation", "SAO 161855"},
        {"Wilson Evans Batten Catalogue", "WEB 15931"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.21243086),
        dec: Angle.Degrees(-12.55628695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35591"},
        {"Hipparcos Number", "HIP 25353"},
        {"Geneva Identification System", "GEN# +1.00035591"},
        {"Smithsonian Astrophysical Observation", "SAO 150427"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.33394540),
        dec: Angle.Degrees(-12.55401195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5376"},
        {"Hipparcos Number", "HIP 4333"},
        {"Geneva Identification System", "GEN# +1.00005376"},
        {"Smithsonian Astrophysical Observation", "SAO 147512"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.87677404),
        dec: Angle.Degrees(-12.55239952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153852"},
        {"Hipparcos Number", "HIP 83400"},
        {"Smithsonian Astrophysical Observation", "SAO 160241"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.67960766),
        dec: Angle.Degrees(-12.55185770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120451"},
        {"Hipparcos Number", "HIP 67482"},
        {"Smithsonian Astrophysical Observation", "SAO 158184"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.43716752),
        dec: Angle.Degrees(-12.55145861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16804"},
        {"Hipparcos Number", "HIP 12539"},
        {"Smithsonian Astrophysical Observation", "SAO 148545"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.33948593),
        dec: Angle.Degrees(-12.55071283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109657"},
        {"Hipparcos Number", "HIP 61535"},
        {"Smithsonian Astrophysical Observation", "SAO 157393"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.10329828),
        dec: Angle.Degrees(-12.54774541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100064",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Algedi"},
        {"Common Name 2", "Giedi"},
        {"Aitken", "ADS 13645 A"},
        {"Henry Draper", "HD 192947"},
        {"Hipparcos Number", "HIP 100064"},
        {"Fundamental Katalog 5th Edition", "FK5 761"},
        {"Geneva Identification System", "GEN# +1.00192947"},
        {"Smithsonian Astrophysical Observation", "SAO 163427"},
        {"Wilson Evans Batten Catalogue", "WEB 18016"},
    },
    visualMagnitude: 3.58,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.51341030),
        dec: Angle.Degrees(-12.54485877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198431"},
        {"Hipparcos Number", "HIP 102891"},
        {"Fundamental Katalog 5th Edition", "FK5 3665"},
        {"Geneva Identification System", "GEN# +1.00198431"},
        {"Smithsonian Astrophysical Observation", "SAO 163924"},
        {"Wilson Evans Batten Catalogue", "WEB 18664"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.67375681),
        dec: Angle.Degrees(-12.54472977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146435"},
        {"Hipparcos Number", "HIP 79760"},
        {"Smithsonian Astrophysical Observation", "SAO 159828"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18879951),
        dec: Angle.Degrees(-12.54369844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28947"},
        {"Hipparcos Number", "HIP 21218"},
        {"Smithsonian Astrophysical Observation", "SAO 149722"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.27641241),
        dec: Angle.Degrees(-12.54330124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31634"},
        {"Hipparcos Number", "HIP 23006"},
        {"Smithsonian Astrophysical Observation", "SAO 150014"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.22557590),
        dec: Angle.Degrees(-12.54329335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56273"},
        {"Hipparcos Number", "HIP 35153"},
        {"Celescope Catalog", "CEL 1722"},
        {"Geneva Identification System", "GEN# +1.00056273"},
        {"Renson", "Renson 15300"},
        {"Smithsonian Astrophysical Observation", "SAO 152629"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.98881959),
        dec: Angle.Degrees(-12.54315304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124322"},
        {"Hipparcos Number", "HIP 69452"},
        {"Smithsonian Astrophysical Observation", "SAO 158433"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.29636647),
        dec: Angle.Degrees(-12.53888708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77708",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9812 AB"},
        {"Henry Draper", "HD 141898"},
        {"Hipparcos Number", "HIP 77708"},
        {"Smithsonian Astrophysical Observation", "SAO 159548"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.98743112),
        dec: Angle.Degrees(-12.53754436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81599"},
        {"Hipparcos Number", "HIP 46284"},
        {"Smithsonian Astrophysical Observation", "SAO 155184"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.57717755),
        dec: Angle.Degrees(-12.53747117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32045"},
        {"Hipparcos Number", "HIP 23231"},
        {"Geneva Identification System", "GEN# +1.00032045"},
        {"Smithsonian Astrophysical Observation", "SAO 150064"},
        {"Wilson Evans Batten Catalogue", "WEB 4514"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.98213784),
        dec: Angle.Degrees(-12.53720450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167330"},
        {"Hipparcos Number", "HIP 89441"},
        {"Geneva Identification System", "GEN# +1.00167330"},
        {"Smithsonian Astrophysical Observation", "SAO 161221"},
        {"Wilson Evans Batten Catalogue", "WEB 15218"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.80526064),
        dec: Angle.Degrees(-12.53674433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73378"},
        {"Hipparcos Number", "HIP 42328"},
        {"Geneva Identification System", "GEN# +1.00073378"},
        {"Smithsonian Astrophysical Observation", "SAO 154469"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.45037045),
        dec: Angle.Degrees(-12.53673802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71377"},
        {"Hipparcos Number", "HIP 41395"},
        {"Geneva Identification System", "GEN# +1.00071377"},
        {"Smithsonian Astrophysical Observation", "SAO 154257"},
        {"Wilson Evans Batten Catalogue", "WEB 8009"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.67502883),
        dec: Angle.Degrees(-12.53453988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44080"},
        {"Hipparcos Number", "HIP 30042"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.82647467),
        dec: Angle.Degrees(-12.53326208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111293"},
        {"Hipparcos Number", "HIP 62497"},
        {"Geneva Identification System", "GEN# +1.00111293"},
        {"Smithsonian Astrophysical Observation", "SAO 157518"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.10470591),
        dec: Angle.Degrees(-12.53155116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89455"},
        {"Hipparcos Number", "HIP 50536"},
        {"Geneva Identification System", "GEN# +1.00089455J"},
        {"Smithsonian Astrophysical Observation", "SAO 155894"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.82033171),
        dec: Angle.Degrees(-12.52810011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115427"},
        {"Hipparcos Number", "HIP 64819"},
        {"Geneva Identification System", "GEN# +1.00115427"},
        {"Smithsonian Astrophysical Observation", "SAO 157834"},
        {"Wilson Evans Batten Catalogue", "WEB 11457"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.30100857),
        dec: Angle.Degrees(-12.52580940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220628"},
        {"Hipparcos Number", "HIP 115629"},
        {"Geneva Identification System", "GEN# +1.00220628"},
        {"Smithsonian Astrophysical Observation", "SAO 165683"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.35586062),
        dec: Angle.Degrees(-12.52401566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158840"},
        {"Hipparcos Number", "HIP 85809"},
        {"Smithsonian Astrophysical Observation", "SAO 160616"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.00160088),
        dec: Angle.Degrees(-12.52357719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55121"},
        {"Hipparcos Number", "HIP 34692"},
        {"Celescope Catalog", "CEL 1646"},
        {"Geneva Identification System", "GEN# +1.00055121"},
        {"Smithsonian Astrophysical Observation", "SAO 152521"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.78337726),
        dec: Angle.Degrees(-12.52270119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71253"},
        {"Cincinnati Publication", "Ci 20 870"},
        {"Geneva Identification System", "GEN# -0.01103759"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.57093205),
        dec: Angle.Degrees(-12.52100145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -357.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 595.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112654"},
        {"Hipparcos Number", "HIP 63313"},
        {"Smithsonian Astrophysical Observation", "SAO 157634"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.62901146),
        dec: Angle.Degrees(-12.51332303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61632"},
        {"Hipparcos Number", "HIP 37327"},
        {"Geneva Identification System", "GEN# +1.00061632"},
        {"Smithsonian Astrophysical Observation", "SAO 153210"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.94057164),
        dec: Angle.Degrees(-12.51239596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157968"},
        {"Hipparcos Number", "HIP 85397"},
        {"Geneva Identification System", "GEN# +1.00157968"},
        {"Smithsonian Astrophysical Observation", "SAO 160553"},
        {"Wilson Evans Batten Catalogue", "WEB 14425"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.75884919),
        dec: Angle.Degrees(-12.51233441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209878"},
        {"Hipparcos Number", "HIP 109170"},
        {"Smithsonian Astrophysical Observation", "SAO 164864"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.70362237),
        dec: Angle.Degrees(-12.51214256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200230"},
        {"Hipparcos Number", "HIP 103846"},
        {"Smithsonian Astrophysical Observation", "SAO 164084"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.63833396),
        dec: Angle.Degrees(-12.51208872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106147",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 54"},
        {"Henry Draper", "HD 204587"},
        {"Hipparcos Number", "HIP 106147"},
        {"Cincinnati Publication", "Ci 20 1284"},
        {"Geneva Identification System", "GEN# +1.00204587"},
        {"Smithsonian Astrophysical Observation", "SAO 164435"},
        {"Wilson Evans Batten Catalogue", "WEB 19237"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.50894501),
        dec: Angle.Degrees(-12.50943675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1015.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100027",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Prima Giedi"},
        {"Aitken", "ADS 13632 A"},
        {"Henry Draper", "HD 192876"},
        {"Hipparcos Number", "HIP 100027"},
        {"Fundamental Katalog 5th Edition", "FK5 1527"},
        {"Geneva Identification System", "GEN# +1.00192876"},
        {"Smithsonian Astrophysical Observation", "SAO 163422"},
        {"Wilson Evans Batten Catalogue", "WEB 18009"},
    },
    visualMagnitude: 4.30,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.41190045),
        dec: Angle.Degrees(-12.50821403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143745"},
        {"Hipparcos Number", "HIP 78569"},
        {"Geneva Identification System", "GEN# +1.00143745"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.65350459),
        dec: Angle.Degrees(-12.50741422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138886"},
        {"Hipparcos Number", "HIP 76314"},
        {"Geneva Identification System", "GEN# +1.00138886"},
        {"Smithsonian Astrophysical Observation", "SAO 159363"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.82903557),
        dec: Angle.Degrees(-12.50729613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57116"},
        {"Hipparcos Number", "HIP 35478"},
        {"Smithsonian Astrophysical Observation", "SAO 152722"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84693030),
        dec: Angle.Degrees(-12.50655686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215779"},
        {"Hipparcos Number", "HIP 112551"},
        {"Geneva Identification System", "GEN# +1.00215779"},
        {"Smithsonian Astrophysical Observation", "SAO 165299"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.93638514),
        dec: Angle.Degrees(-12.50616427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52803"},
        {"Hipparcos Number", "HIP 33897"},
        {"Smithsonian Astrophysical Observation", "SAO 152266"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.53627143),
        dec: Angle.Degrees(-12.50461240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167311"},
        {"Hipparcos Number", "HIP 89436"},
        {"Geneva Identification System", "GEN# +1.00167311"},
        {"Smithsonian Astrophysical Observation", "SAO 161219"},
        {"Wilson Evans Batten Catalogue", "WEB 15216"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.79959097),
        dec: Angle.Degrees(-12.50112939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151009"},
        {"Hipparcos Number", "HIP 82010"},
        {"Smithsonian Astrophysical Observation", "SAO 160078"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.29627152),
        dec: Angle.Degrees(-12.49696250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128336"},
        {"Hipparcos Number", "HIP 71441"},
        {"Geneva Identification System", "GEN# +1.00128336"},
        {"Smithsonian Astrophysical Observation", "SAO 158670"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.15517248),
        dec: Angle.Degrees(-12.49365373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140268"},
        {"Hipparcos Number", "HIP 76979"},
        {"Smithsonian Astrophysical Observation", "SAO 159457"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.77054699),
        dec: Angle.Degrees(-12.49260318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17080"},
        {"Hipparcos Number", "HIP 12774"},
        {"Smithsonian Astrophysical Observation", "SAO 148576"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.04318811),
        dec: Angle.Degrees(-12.49206352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33093"},
        {"Hipparcos Number", "HIP 23831"},
        {"Geneva Identification System", "GEN# +1.00033093"},
        {"Smithsonian Astrophysical Observation", "SAO 150159"},
        {"Wilson Evans Batten Catalogue", "WEB 4649"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.85367500),
        dec: Angle.Degrees(-12.49100914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224208"},
        {"Hipparcos Number", "HIP 117994"},
        {"Geneva Identification System", "GEN# +1.00224208"},
        {"Smithsonian Astrophysical Observation", "SAO 165960"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.00593639),
        dec: Angle.Degrees(-12.48742818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90081"},
        {"Hipparcos Number", "HIP 50895"},
        {"Geneva Identification System", "GEN# +1.00090081"},
        {"Smithsonian Astrophysical Observation", "SAO 155950"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.89470787),
        dec: Angle.Degrees(-12.48674609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115799"},
        {"Hipparcos Number", "HIP 65014"},
        {"Smithsonian Astrophysical Observation", "SAO 157858"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.90488168),
        dec: Angle.Degrees(-12.48359996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34607"},
        {"Hipparcos Number", "HIP 24731"},
        {"Renson", "Renson 8830"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54931032),
        dec: Angle.Degrees(-12.48313184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108980"},
        {"Hipparcos Number", "HIP 61106"},
        {"Smithsonian Astrophysical Observation", "SAO 157336"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.84993635),
        dec: Angle.Degrees(-12.48170341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5460"},
        {"Smithsonian Astrophysical Observation", "SAO 147644"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.47073440),
        dec: Angle.Degrees(-12.47652191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162450"},
        {"Hipparcos Number", "HIP 87402"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.91965860),
        dec: Angle.Degrees(-12.47643278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29851"},
        {"Hipparcos Number", "HIP 21837"},
        {"Geneva Identification System", "GEN# +1.00029851"},
        {"Smithsonian Astrophysical Observation", "SAO 149831"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.42514639),
        dec: Angle.Degrees(-12.47582192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73840"},
        {"Hipparcos Number", "HIP 42509"},
        {"Fundamental Katalog 5th Edition", "FK5 325"},
        {"Geneva Identification System", "GEN# +1.00073840"},
        {"Smithsonian Astrophysical Observation", "SAO 154515"},
        {"Wilson Evans Batten Catalogue", "WEB 8186"},
    },
    visualMagnitude: 4.98,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.00633068),
        dec: Angle.Degrees(-12.47537441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85948"},
        {"Hipparcos Number", "HIP 48636"},
        {"Geneva Identification System", "GEN# +1.00085948"},
        {"Smithsonian Astrophysical Observation", "SAO 155591"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.75914722),
        dec: Angle.Degrees(-12.46754283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224511"},
        {"Hipparcos Number", "HIP 118203"},
        {"Geneva Identification System", "GEN# +1.00224511"},
        {"Smithsonian Astrophysical Observation", "SAO 165974"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.64091289),
        dec: Angle.Degrees(-12.46698995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36815"},
        {"Hipparcos Number", "HIP 26090"},
        {"Smithsonian Astrophysical Observation", "SAO 150563"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.46372413),
        dec: Angle.Degrees(-12.46680206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202111"},
        {"Hipparcos Number", "HIP 104817"},
        {"Smithsonian Astrophysical Observation", "SAO 164238"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.53067161),
        dec: Angle.Degrees(-12.46644771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13445"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.28736105),
        dec: Angle.Degrees(-12.46617270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31301"},
        {"Hipparcos Number", "HIP 22779"},
        {"Smithsonian Astrophysical Observation", "SAO 149968"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.50253992),
        dec: Angle.Degrees(-12.46268090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7131 AB"},
        {"Henry Draper", "HD 77126"},
        {"Hipparcos Number", "HIP 44190"},
        {"Geneva Identification System", "GEN# +1.00077126"},
        {"Smithsonian Astrophysical Observation", "SAO 154820"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.02141157),
        dec: Angle.Degrees(-12.46094019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17491"},
        {"Hipparcos Number", "HIP 13064"},
        {"Fundamental Katalog 5th Edition", "FK5 4255"},
        {"Geneva Identification System", "GEN# +1.00017491"},
        {"Smithsonian Astrophysical Observation", "SAO 148612"},
        {"Wilson Evans Batten Catalogue", "WEB 2637"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.98301513),
        dec: Angle.Degrees(-12.46053156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198075"},
        {"Hipparcos Number", "HIP 102664"},
        {"Geneva Identification System", "GEN# +1.00198075"},
        {"Smithsonian Astrophysical Observation", "SAO 163891"},
        {"Wilson Evans Batten Catalogue", "WEB 18610"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.06332409),
        dec: Angle.Degrees(-12.45438728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75435"},
        {"Hipparcos Number", "HIP 43333"},
        {"Smithsonian Astrophysical Observation", "SAO 154665"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.42237052),
        dec: Angle.Degrees(-12.45394943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24561"},
        {"Hipparcos Number", "HIP 18236"},
        {"Geneva Identification System", "GEN# +1.00024561"},
        {"Smithsonian Astrophysical Observation", "SAO 149236"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.49924861),
        dec: Angle.Degrees(-12.44928581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73444"},
        {"Geneva Identification System", "GEN# -0.01103853"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.12926101),
        dec: Angle.Degrees(-12.44897818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121348"},
        {"Hipparcos Number", "HIP 67972"},
        {"Smithsonian Astrophysical Observation", "SAO 158234"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.79701681),
        dec: Angle.Degrees(-12.44893938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220189"},
        {"Hipparcos Number", "HIP 115351"},
        {"Fundamental Katalog 5th Edition", "FK5 6064"},
        {"Smithsonian Astrophysical Observation", "SAO 165652"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46504751),
        dec: Angle.Degrees(-12.44889279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200212"},
        {"Hipparcos Number", "HIP 103834"},
        {"Smithsonian Astrophysical Observation", "SAO 164080"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60827316),
        dec: Angle.Degrees(-12.44701185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92245"},
        {"Hipparcos Number", "HIP 52113"},
        {"Geneva Identification System", "GEN# +1.00092245"},
        {"Smithsonian Astrophysical Observation", "SAO 156124"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.71016955),
        dec: Angle.Degrees(-12.44364242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14130"},
        {"Hipparcos Number", "HIP 10627"},
        {"Smithsonian Astrophysical Observation", "SAO 148306"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.20511194),
        dec: Angle.Degrees(-12.44212905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7567"},
        {"Smithsonian Astrophysical Observation", "SAO 147914"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.36197183),
        dec: Angle.Degrees(-12.44093344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190740"},
        {"Hipparcos Number", "HIP 99077"},
        {"Fundamental Katalog 5th Edition", "FK5 5772"},
        {"Smithsonian Astrophysical Observation", "SAO 163268"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.70956454),
        dec: Angle.Degrees(-12.43985178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3641 AB"},
        {"Henry Draper", "HD 32470"},
        {"Hipparcos Number", "HIP 23490"},
        {"Smithsonian Astrophysical Observation", "SAO 150099"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.74032046),
        dec: Angle.Degrees(-12.43857958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132112"},
        {"Hipparcos Number", "HIP 73213"},
        {"Geneva Identification System", "GEN# +1.00132112"},
        {"Smithsonian Astrophysical Observation", "SAO 158929"},
        {"Wilson Evans Batten Catalogue", "WEB 12549"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.44389681),
        dec: Angle.Degrees(-12.43755131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99610"},
        {"Hipparcos Number", "HIP 55900"},
        {"Geneva Identification System", "GEN# +1.00099610"},
        {"Smithsonian Astrophysical Observation", "SAO 156690"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.87613192),
        dec: Angle.Degrees(-12.43580206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210171"},
        {"Hipparcos Number", "HIP 109317"},
        {"Smithsonian Astrophysical Observation", "SAO 164886"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.20526869),
        dec: Angle.Degrees(-12.43551906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90844"},
        {"Hipparcos Number", "HIP 51335"},
        {"Smithsonian Astrophysical Observation", "SAO 156010"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.28200672),
        dec: Angle.Degrees(-12.43490270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94427"},
        {"Hipparcos Number", "HIP 53290"},
        {"Geneva Identification System", "GEN# +1.00094427"},
        {"Renson", "Renson 27250"},
        {"Smithsonian Astrophysical Observation", "SAO 156309"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.48641661),
        dec: Angle.Degrees(-12.43450917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38455"},
        {"Hipparcos Number", "HIP 27158"},
        {"Smithsonian Astrophysical Observation", "SAO 150771"},
        {"Wilson Evans Batten Catalogue", "WEB 5340"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.35670315),
        dec: Angle.Degrees(-12.43439149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148968"},
        {"Hipparcos Number", "HIP 80974"},
        {"Smithsonian Astrophysical Observation", "SAO 159966"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.03374023),
        dec: Angle.Degrees(-12.43162015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147452"},
        {"Hipparcos Number", "HIP 80217"},
        {"Geneva Identification System", "GEN# +1.00147452"},
        {"Smithsonian Astrophysical Observation", "SAO 159884"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.63299278),
        dec: Angle.Degrees(-12.42847142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148182"},
        {"Hipparcos Number", "HIP 80550"},
        {"Geneva Identification System", "GEN# +1.00148182"},
        {"Smithsonian Astrophysical Observation", "SAO 159916"},
        {"Wilson Evans Batten Catalogue", "WEB 13625"},
    },
    visualMagnitude: 8.61,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.68211413),
        dec: Angle.Degrees(-12.42663056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67172",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9018 AB"},
        {"Henry Draper", "HD 119853"},
        {"Hipparcos Number", "HIP 67172"},
        {"Geneva Identification System", "GEN# +1.00119853"},
        {"Smithsonian Astrophysical Observation", "SAO 158152"},
        {"Wilson Evans Batten Catalogue", "WEB 11824"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.48471128),
        dec: Angle.Degrees(-12.42654721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38532"},
        {"Hipparcos Number", "HIP 27208"},
        {"Smithsonian Astrophysical Observation", "SAO 150784"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.50670938),
        dec: Angle.Degrees(-12.42348854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25242"},
        {"Hipparcos Number", "HIP 18686"},
        {"Smithsonian Astrophysical Observation", "SAO 149306"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.03202351),
        dec: Angle.Degrees(-12.42285970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74333"},
        {"Hipparcos Number", "HIP 42790"},
        {"Smithsonian Astrophysical Observation", "SAO 154570"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.78196485),
        dec: Angle.Degrees(-12.42186792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33820"},
        {"Hipparcos Number", "HIP 24259"},
        {"Smithsonian Astrophysical Observation", "SAO 150226"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.11099309),
        dec: Angle.Degrees(-12.41994029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126212"},
        {"Hipparcos Number", "HIP 70432"},
        {"Smithsonian Astrophysical Observation", "SAO 158545"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.12357764),
        dec: Angle.Degrees(-12.41873367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6442"},
        {"Hipparcos Number", "HIP 5090"},
        {"Smithsonian Astrophysical Observation", "SAO 147599"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.29950754),
        dec: Angle.Degrees(-12.41857988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18941"},
        {"Hipparcos Number", "HIP 14155"},
        {"Smithsonian Astrophysical Observation", "SAO 148729"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.62428977),
        dec: Angle.Degrees(-12.41645823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73594"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.63900165),
        dec: Angle.Degrees(-12.41388051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154519"},
        {"Hipparcos Number", "HIP 83699"},
        {"Geneva Identification System", "GEN# +1.00154519"},
        {"Smithsonian Astrophysical Observation", "SAO 160279"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.59213593),
        dec: Angle.Degrees(-12.41113585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100742"},
        {"Hipparcos Number", "HIP 56536"},
        {"Geneva Identification System", "GEN# +1.00100742"},
        {"Smithsonian Astrophysical Observation", "SAO 156771"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.88710704),
        dec: Angle.Degrees(-12.41085613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4791"},
        {"Smithsonian Astrophysical Observation", "SAO 147570"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.38589879),
        dec: Angle.Degrees(-12.40623856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177816"},
        {"Hipparcos Number", "HIP 93849"},
        {"Smithsonian Astrophysical Observation", "SAO 162199"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.68447450),
        dec: Angle.Degrees(-12.40355244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114661"},
        {"Hipparcos Number", "HIP 64404"},
        {"Smithsonian Astrophysical Observation", "SAO 157789"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.00758226),
        dec: Angle.Degrees(-12.40264101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216808"},
        {"Hipparcos Number", "HIP 113264"},
        {"Smithsonian Astrophysical Observation", "SAO 165390"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.03972320),
        dec: Angle.Degrees(-12.40227048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27487"},
        {"Hipparcos Number", "HIP 20212"},
        {"Geneva Identification System", "GEN# +1.00027487"},
        {"Smithsonian Astrophysical Observation", "SAO 149543"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97340478),
        dec: Angle.Degrees(-12.39914021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100270"},
        {"Hipparcos Number", "HIP 56279"},
        {"Smithsonian Astrophysical Observation", "SAO 156739"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.06474958),
        dec: Angle.Degrees(-12.39659278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133464"},
        {"Hipparcos Number", "HIP 73794"},
        {"Smithsonian Astrophysical Observation", "SAO 159010"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23742915),
        dec: Angle.Degrees(-12.39550966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39733"},
        {"Hipparcos Number", "HIP 27875"},
        {"Smithsonian Astrophysical Observation", "SAO 150922"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.47745090),
        dec: Angle.Degrees(-12.39433812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92034"},
        {"Hipparcos Number", "HIP 52003"},
        {"Smithsonian Astrophysical Observation", "SAO 156109"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36270761),
        dec: Angle.Degrees(-12.39401959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53975"},
        {"Hipparcos Number", "HIP 34297"},
        {"Celescope Catalog", "CEL 1584"},
        {"Geneva Identification System", "GEN# +1.00053975"},
        {"Smithsonian Astrophysical Observation", "SAO 152393"},
        {"Wilson Evans Batten Catalogue", "WEB 6870"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.64986453),
        dec: Angle.Degrees(-12.39395311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191753"},
        {"Hipparcos Number", "HIP 99529"},
        {"Geneva Identification System", "GEN# +1.00191753"},
        {"Smithsonian Astrophysical Observation", "SAO 163328"},
        {"Wilson Evans Batten Catalogue", "WEB 17803"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.99126270),
        dec: Angle.Degrees(-12.39235779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113771",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113771"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.60251865),
        dec: Angle.Degrees(-12.39215676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 207.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46184"},
        {"Hipparcos Number", "HIP 31084"},
        {"Geneva Identification System", "GEN# +1.00046184"},
        {"Smithsonian Astrophysical Observation", "SAO 151602"},
        {"Wilson Evans Batten Catalogue", "WEB 6191"},
    },
    visualMagnitude: 5.16,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.84591544),
        dec: Angle.Degrees(-12.39190922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197928"},
        {"Hipparcos Number", "HIP 102569"},
        {"Geneva Identification System", "GEN# +1.00197928"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.78867367),
        dec: Angle.Degrees(-12.39061154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120746"},
        {"Hipparcos Number", "HIP 67644"},
        {"Smithsonian Astrophysical Observation", "SAO 158202"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.89231070),
        dec: Angle.Degrees(-12.38958986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170429"},
        {"Hipparcos Number", "HIP 90661"},
        {"Smithsonian Astrophysical Observation", "SAO 161535"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.48005118),
        dec: Angle.Degrees(-12.38943892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213735"},
        {"Hipparcos Number", "HIP 111376"},
        {"Smithsonian Astrophysical Observation", "SAO 165161"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.45236948),
        dec: Angle.Degrees(-12.38818812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151798"},
        {"Hipparcos Number", "HIP 82388"},
        {"Geneva Identification System", "GEN# +1.00151798"},
        {"Smithsonian Astrophysical Observation", "SAO 160122"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.52169648),
        dec: Angle.Degrees(-12.38720302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134906"},
        {"Hipparcos Number", "HIP 74430"},
        {"Smithsonian Astrophysical Observation", "SAO 159099"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.17014032),
        dec: Angle.Degrees(-12.38709359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109876"},
        {"Hipparcos Number", "HIP 61649"},
        {"Geneva Identification System", "GEN# +1.00109876"},
        {"Smithsonian Astrophysical Observation", "SAO 157408"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57180620),
        dec: Angle.Degrees(-12.38559376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119805"},
        {"Hipparcos Number", "HIP 67144"},
        {"Smithsonian Astrophysical Observation", "SAO 158148"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.40488053),
        dec: Angle.Degrees(-12.38418089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16031"},
        {"Hipparcos Number", "HIP 11952"},
        {"Cincinnati Publication", "Ci 18 333"},
        {"Geneva Identification System", "GEN# +1.00016031"},
        {"Smithsonian Astrophysical Observation", "SAO 148474"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.54588590),
        dec: Angle.Degrees(-12.38384249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131252"},
        {"Hipparcos Number", "HIP 72804"},
        {"Geneva Identification System", "GEN# +1.00131252"},
        {"Smithsonian Astrophysical Observation", "SAO 158874"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22075486),
        dec: Angle.Degrees(-12.38361432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193802"},
        {"Hipparcos Number", "HIP 100483"},
        {"Smithsonian Astrophysical Observation", "SAO 163506"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.64869655),
        dec: Angle.Degrees(-12.38190021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196222"},
        {"Hipparcos Number", "HIP 101647"},
        {"Smithsonian Astrophysical Observation", "SAO 163720"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.06843468),
        dec: Angle.Degrees(-12.38126833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135106"},
        {"Hipparcos Number", "HIP 74533"},
        {"Smithsonian Astrophysical Observation", "SAO 159112"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.44640307),
        dec: Angle.Degrees(-12.38027898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55561"},
        {"Hipparcos Number", "HIP 34872"},
        {"Celescope Catalog", "CEL 1676"},
        {"Geneva Identification System", "GEN# +1.00055561"},
        {"Smithsonian Astrophysical Observation", "SAO 152561"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.23296740),
        dec: Angle.Degrees(-12.37917808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58234"},
        {"Smithsonian Astrophysical Observation", "SAO 156999"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.16399185),
        dec: Angle.Degrees(-12.37746067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145056"},
        {"Hipparcos Number", "HIP 79160"},
        {"Geneva Identification System", "GEN# +1.00145056"},
        {"Smithsonian Astrophysical Observation", "SAO 159741"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.34467956),
        dec: Angle.Degrees(-12.37599071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113718"},
        {"Hipparcos Number", "HIP 63897"},
        {"Smithsonian Astrophysical Observation", "SAO 157712"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42774472),
        dec: Angle.Degrees(-12.36997788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136956"},
        {"Hipparcos Number", "HIP 75352"},
        {"Fundamental Katalog 5th Edition", "FK5 3214"},
        {"Geneva Identification System", "GEN# +1.00136956"},
        {"Smithsonian Astrophysical Observation", "SAO 159227"},
        {"Wilson Evans Batten Catalogue", "WEB 12853"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.96775654),
        dec: Angle.Degrees(-12.36941286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160083"},
        {"Hipparcos Number", "HIP 86338"},
        {"Smithsonian Astrophysical Observation", "SAO 160714"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.63616071),
        dec: Angle.Degrees(-12.36704980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54105"},
        {"Hipparcos Number", "HIP 34344"},
        {"Smithsonian Astrophysical Observation", "SAO 152408"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.79291117),
        dec: Angle.Degrees(-12.36247660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188196"},
        {"Hipparcos Number", "HIP 97955"},
        {"Geneva Identification System", "GEN# +1.00188196"},
        {"Smithsonian Astrophysical Observation", "SAO 163097"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.61489551),
        dec: Angle.Degrees(-12.36058368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60531"},
        {"Hipparcos Number", "HIP 36829"},
        {"Smithsonian Astrophysical Observation", "SAO 153082"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61135433),
        dec: Angle.Degrees(-12.35956928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174754"},
        {"Hipparcos Number", "HIP 92642"},
        {"Smithsonian Astrophysical Observation", "SAO 161925"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.15242753),
        dec: Angle.Degrees(-12.35887933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1556"},
        {"Hipparcos Number", "HIP 1581"},
        {"Smithsonian Astrophysical Observation", "SAO 147218"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.94855880),
        dec: Angle.Degrees(-12.35802013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78668"},
        {"Hipparcos Number", "HIP 44936"},
        {"Fundamental Katalog 5th Edition", "FK5 1240"},
        {"Geneva Identification System", "GEN# +1.00078668"},
        {"Smithsonian Astrophysical Observation", "SAO 154953"},
        {"Wilson Evans Batten Catalogue", "WEB 8583"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.29792608),
        dec: Angle.Degrees(-12.35770752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99564"},
        {"Hipparcos Number", "HIP 55874"},
        {"Fundamental Katalog 5th Edition", "FK5 2914"},
        {"Geneva Identification System", "GEN# +1.00099564"},
        {"Smithsonian Astrophysical Observation", "SAO 156685"},
        {"Wilson Evans Batten Catalogue", "WEB 10040"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.78989699),
        dec: Angle.Degrees(-12.35680710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21231"},
        {"Hipparcos Number", "HIP 15926"},
        {"Smithsonian Astrophysical Observation", "SAO 148953"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.28890205),
        dec: Angle.Degrees(-12.35517684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7671 A"},
        {"Henry Draper", "HD 88284"},
        {"Hipparcos Number", "HIP 49841"},
        {"Fundamental Katalog 5th Edition", "FK5 381"},
        {"Geneva Identification System", "GEN# +1.00088284"},
        {"Smithsonian Astrophysical Observation", "SAO 155785"},
        {"Wilson Evans Batten Catalogue", "WEB 9179"},
    },
    visualMagnitude: 3.61,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.64748785),
        dec: Angle.Degrees(-12.35383921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129940"},
        {"Hipparcos Number", "HIP 72174"},
        {"Geneva Identification System", "GEN# +1.00129940"},
        {"Smithsonian Astrophysical Observation", "SAO 158783"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43511601),
        dec: Angle.Degrees(-12.35361115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18263"},
        {"Hipparcos Number", "HIP 13636"},
        {"Smithsonian Astrophysical Observation", "SAO 148668"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.90288518),
        dec: Angle.Degrees(-12.35321515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145715"},
        {"Hipparcos Number", "HIP 79455"},
        {"Smithsonian Astrophysical Observation", "SAO 159780"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21744970),
        dec: Angle.Degrees(-12.35214347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59338"},
        {"Hipparcos Number", "HIP 36360"},
        {"Smithsonian Astrophysical Observation", "SAO 152931"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.26317763),
        dec: Angle.Degrees(-12.35209848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165361"},
        {"Hipparcos Number", "HIP 88668"},
        {"Smithsonian Astrophysical Observation", "SAO 161064"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.52796571),
        dec: Angle.Degrees(-12.35145525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8239 AB"},
        {"Henry Draper", "HD 100922"},
        {"Hipparcos Number", "HIP 56641"},
        {"Geneva Identification System", "GEN# +1.00100922J"},
        {"Smithsonian Astrophysical Observation", "SAO 156786"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.20767595),
        dec: Angle.Degrees(-12.35053224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115217"},
        {"Hipparcos Number", "HIP 64718"},
        {"Smithsonian Astrophysical Observation", "SAO 157822"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.97484020),
        dec: Angle.Degrees(-12.35009179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171854"},
        {"Hipparcos Number", "HIP 91314"},
        {"Geneva Identification System", "GEN# +1.00171854"},
        {"Smithsonian Astrophysical Observation", "SAO 161675"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.38694927),
        dec: Angle.Degrees(-12.34976054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159450"},
        {"Hipparcos Number", "HIP 86059"},
        {"Geneva Identification System", "GEN# +1.00159450"},
        {"Smithsonian Astrophysical Observation", "SAO 160664"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.81959061),
        dec: Angle.Degrees(-12.34777524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100998"},
        {"Hipparcos Number", "HIP 56683"},
        {"Smithsonian Astrophysical Observation", "SAO 156788"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.33369409),
        dec: Angle.Degrees(-12.34696475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2659"},
        {"Hipparcos Number", "HIP 2362"},
        {"Smithsonian Astrophysical Observation", "SAO 147310"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.54191405),
        dec: Angle.Degrees(-12.34688325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72762"},
        {"Hipparcos Number", "HIP 42050"},
        {"Geneva Identification System", "GEN# +1.00072762"},
        {"Smithsonian Astrophysical Observation", "SAO 154410"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.56279306),
        dec: Angle.Degrees(-12.34631055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83805"},
        {"Smithsonian Astrophysical Observation", "SAO 160298"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.90780701),
        dec: Angle.Degrees(-12.34606462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195827"},
        {"Hipparcos Number", "HIP 101492"},
        {"Smithsonian Astrophysical Observation", "SAO 163683"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.50755111),
        dec: Angle.Degrees(-12.34364129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43271"},
        {"Hipparcos Number", "HIP 29648"},
        {"Smithsonian Astrophysical Observation", "SAO 151263"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70695951),
        dec: Angle.Degrees(-12.34295652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11274"},
        {"Hipparcos Number", "HIP 8564"},
        {"Geneva Identification System", "GEN# +1.00011274"},
        {"Smithsonian Astrophysical Observation", "SAO 148052"},
        {"Wilson Evans Batten Catalogue", "WEB 1820"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62011024),
        dec: Angle.Degrees(-12.34254752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37161"},
        {"Hipparcos Number", "HIP 26301"},
        {"Smithsonian Astrophysical Observation", "SAO 150597"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.01440290),
        dec: Angle.Degrees(-12.33994260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197080"},
        {"Hipparcos Number", "HIP 102124"},
        {"Geneva Identification System", "GEN# +1.00197080"},
        {"Smithsonian Astrophysical Observation", "SAO 163802"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43032896),
        dec: Angle.Degrees(-12.33859905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170716"},
        {"Hipparcos Number", "HIP 90798"},
        {"Geneva Identification System", "GEN# +1.00170716"},
        {"Smithsonian Astrophysical Observation", "SAO 161565"},
        {"Wilson Evans Batten Catalogue", "WEB 15562"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.84605437),
        dec: Angle.Degrees(-12.33797164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99918",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13600 A"},
        {"Henry Draper", "HD 192666"},
        {"Hipparcos Number", "HIP 99918"},
        {"Geneva Identification System", "GEN# +1.00192666"},
        {"Renson", "Renson 53720"},
        {"Smithsonian Astrophysical Observation", "SAO 163402"},
        {"Wilson Evans Batten Catalogue", "WEB 17972"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.09500616),
        dec: Angle.Degrees(-12.33707716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15995"},
        {"Hipparcos Number", "HIP 11927"},
        {"Geneva Identification System", "GEN# +1.00015995"},
        {"Smithsonian Astrophysical Observation", "SAO 148469"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.48070674),
        dec: Angle.Degrees(-12.33704547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143483"},
        {"Hipparcos Number", "HIP 78453"},
        {"Smithsonian Astrophysical Observation", "SAO 159633"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.24388129),
        dec: Angle.Degrees(-12.33694883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150079"},
        {"Hipparcos Number", "HIP 81532"},
        {"Geneva Identification System", "GEN# +1.00150079"},
        {"Smithsonian Astrophysical Observation", "SAO 160026"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.79935202),
        dec: Angle.Degrees(-12.33582879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51626"},
        {"Hipparcos Number", "HIP 33489"},
        {"Smithsonian Astrophysical Observation", "SAO 152166"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.41423666),
        dec: Angle.Degrees(-12.33517489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9821"},
        {"Smithsonian Astrophysical Observation", "SAO 148202"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.59780701),
        dec: Angle.Degrees(-12.33237225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20909"},
        {"Hipparcos Number", "HIP 15676"},
        {"Geneva Identification System", "GEN# +1.00020909"},
        {"Smithsonian Astrophysical Observation", "SAO 148918"},
        {"Wilson Evans Batten Catalogue", "WEB 3005"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.49215269),
        dec: Angle.Degrees(-12.33148293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5049"},
        {"Smithsonian Astrophysical Observation", "SAO 147592"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16035785),
        dec: Angle.Degrees(-12.33140348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173803"},
        {"Hipparcos Number", "HIP 92227"},
        {"Smithsonian Astrophysical Observation", "SAO 161833"},
    },
    visualMagnitude: 7.50,
    bvColour: 2.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.93712820),
        dec: Angle.Degrees(-12.32971271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118480"},
        {"Hipparcos Number", "HIP 66453"},
        {"Smithsonian Astrophysical Observation", "SAO 158045"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.34447779),
        dec: Angle.Degrees(-12.32850737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48336"},
        {"Cincinnati Publication", "Ci 20 550"},
        {"Cincinnati Publication 2", "Ci 18 1167"},
        {"Geneva Identification System", "GEN# -0.01102741"},
        {"Smithsonian Astrophysical Observation", "SAO 155530"},
        {"Wilson Evans Batten Catalogue", "WEB 9015"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.78733655),
        dec: Angle.Degrees(-12.32631346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1137.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1457.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53623"},
        {"Hipparcos Number", "HIP 34178"},
        {"Celescope Catalog", "CEL 1560"},
        {"Geneva Identification System", "GEN# +1.00053623"},
        {"Smithsonian Astrophysical Observation", "SAO 152349"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.31979340),
        dec: Angle.Degrees(-12.32625090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221717"},
        {"Hipparcos Number", "HIP 116349"},
        {"Smithsonian Astrophysical Observation", "SAO 165776"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.64317795),
        dec: Angle.Degrees(-12.32621425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78453"},
        {"Hipparcos Number", "HIP 44807"},
        {"Smithsonian Astrophysical Observation", "SAO 154928"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.97290483),
        dec: Angle.Degrees(-12.32319290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7980",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1347 AB"},
        {"Henry Draper", "HD 10535"},
        {"Hipparcos Number", "HIP 7980"},
        {"Smithsonian Astrophysical Observation", "SAO 147970"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.62436377),
        dec: Angle.Degrees(-12.32053108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187150"},
        {"Hipparcos Number", "HIP 97484"},
        {"Smithsonian Astrophysical Observation", "SAO 163007"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.20905254),
        dec: Angle.Degrees(-12.31936853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54601"},
        {"Hipparcos Number", "HIP 34504"},
        {"Geneva Identification System", "GEN# +1.00054601"},
        {"Smithsonian Astrophysical Observation", "SAO 152461"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.23486400),
        dec: Angle.Degrees(-12.31924670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164579"},
        {"Hipparcos Number", "HIP 88326"},
        {"Geneva Identification System", "GEN# +1.00164579"},
        {"Smithsonian Astrophysical Observation", "SAO 161017"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.59265874),
        dec: Angle.Degrees(-12.31836845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34863"},
        {"Hipparcos Number", "HIP 24873"},
        {"Geneva Identification System", "GEN# +1.00034863"},
        {"Smithsonian Astrophysical Observation", "SAO 150345"},
        {"Wilson Evans Batten Catalogue", "WEB 4820"},
    },
    visualMagnitude: 5.29,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.99596151),
        dec: Angle.Degrees(-12.31560456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121112"},
        {"Hipparcos Number", "HIP 67839"},
        {"Smithsonian Astrophysical Observation", "SAO 158218"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.43617848),
        dec: Angle.Degrees(-12.31451333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6333 AB"},
        {"Henry Draper", "HD 62632"},
        {"Hipparcos Number", "HIP 37750"},
        {"Smithsonian Astrophysical Observation", "SAO 153331"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.14076609),
        dec: Angle.Degrees(-12.31375015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156392"},
        {"Hipparcos Number", "HIP 84618"},
        {"Geneva Identification System", "GEN# +1.00156392"},
        {"Smithsonian Astrophysical Observation", "SAO 160434"},
        {"Wilson Evans Batten Catalogue", "WEB 14288"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.46573995),
        dec: Angle.Degrees(-12.31313284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37970"},
        {"Hipparcos Number", "HIP 26831"},
        {"Smithsonian Astrophysical Observation", "SAO 150705"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.46025824),
        dec: Angle.Degrees(-12.31090148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83843"},
        {"Hipparcos Number", "HIP 47485"},
        {"Smithsonian Astrophysical Observation", "SAO 155394"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.20137943),
        dec: Angle.Degrees(-12.30958246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128429"},
        {"Hipparcos Number", "HIP 71469"},
        {"Cincinnati Publication", "Ci 20 873"},
        {"Fundamental Katalog 5th Edition", "FK5 1381"},
        {"Geneva Identification System", "GEN# +1.00128429"},
        {"Smithsonian Astrophysical Observation", "SAO 158677"},
        {"Wilson Evans Batten Catalogue", "WEB 12331"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.25123338),
        dec: Angle.Degrees(-12.30623565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -870.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 364.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12703"},
        {"Hipparcos Number", "HIP 9653"},
        {"Smithsonian Astrophysical Observation", "SAO 148179"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.02902439),
        dec: Angle.Degrees(-12.30592631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48289"},
        {"Smithsonian Astrophysical Observation", "SAO 155523"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.67629950),
        dec: Angle.Degrees(-12.30553168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144393"},
        {"Hipparcos Number", "HIP 78878"},
        {"Geneva Identification System", "GEN# +1.00144393"},
        {"Smithsonian Astrophysical Observation", "SAO 159690"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.52697462),
        dec: Angle.Degrees(-12.30417187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137648"},
        {"Hipparcos Number", "HIP 75669"},
        {"Geneva Identification System", "GEN# +1.00137648"},
        {"Smithsonian Astrophysical Observation", "SAO 159273"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.89955885),
        dec: Angle.Degrees(-12.30259616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49211"},
        {"Smithsonian Astrophysical Observation", "SAO 155682"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.66345992),
        dec: Angle.Degrees(-12.30177627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27985"},
        {"Hipparcos Number", "HIP 20589"},
        {"Smithsonian Astrophysical Observation", "SAO 149613"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.14826671),
        dec: Angle.Degrees(-12.29862784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22257"},
        {"Hipparcos Number", "HIP 16681"},
        {"Geneva Identification System", "GEN# +1.00022257"},
        {"Smithsonian Astrophysical Observation", "SAO 149049"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65879346),
        dec: Angle.Degrees(-12.29771598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197455"},
        {"Hipparcos Number", "HIP 102343"},
        {"Smithsonian Astrophysical Observation", "SAO 163838"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.04909950),
        dec: Angle.Degrees(-12.29693074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26751"},
        {"Hipparcos Number", "HIP 19711"},
        {"Smithsonian Astrophysical Observation", "SAO 149464"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.34620285),
        dec: Angle.Degrees(-12.29555908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136906"},
        {"Hipparcos Number", "HIP 75334"},
        {"Smithsonian Astrophysical Observation", "SAO 159221"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.89053769),
        dec: Angle.Degrees(-12.29530010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70975"},
        {"Cincinnati Publication", "Ci 20 865"},
        {"Geneva Identification System", "GEN# +6.00105734"},
    },
    visualMagnitude: 11.92,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75585171),
        dec: Angle.Degrees(-12.29512776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -405.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -400.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2893"},
        {"Hipparcos Number", "HIP 2532"},
        {"Geneva Identification System", "GEN# +1.00002893"},
        {"Smithsonian Astrophysical Observation", "SAO 147326"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.02934093),
        dec: Angle.Degrees(-12.29501561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30059"},
        {"Hipparcos Number", "HIP 22002"},
        {"Smithsonian Astrophysical Observation", "SAO 149848"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.94895917),
        dec: Angle.Degrees(-12.29444742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97817"},
        {"Hipparcos Number", "HIP 54943"},
        {"Smithsonian Astrophysical Observation", "SAO 156559"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76758930),
        dec: Angle.Degrees(-12.29383719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198923"},
        {"Hipparcos Number", "HIP 103151"},
        {"Smithsonian Astrophysical Observation", "SAO 163964"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.48946396),
        dec: Angle.Degrees(-12.29171608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15130"},
        {"Hipparcos Number", "HIP 11345"},
        {"Fundamental Katalog 5th Edition", "FK5 1066"},
        {"Geneva Identification System", "GEN# +1.00015130"},
        {"Smithsonian Astrophysical Observation", "SAO 148385"},
        {"Wilson Evans Batten Catalogue", "WEB 2367"},
    },
    visualMagnitude: 4.88,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.48755111),
        dec: Angle.Degrees(-12.29045200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53303"},
        {"Hipparcos Number", "HIP 34080"},
        {"Celescope Catalog", "CEL 1545"},
        {"Geneva Identification System", "GEN# +1.00053303"},
        {"Smithsonian Astrophysical Observation", "SAO 152311"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01093760),
        dec: Angle.Degrees(-12.28816691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82525"},
        {"Hipparcos Number", "HIP 46796"},
        {"Smithsonian Astrophysical Observation", "SAO 155266"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.04009793),
        dec: Angle.Degrees(-12.28721630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179497"},
        {"Hipparcos Number", "HIP 94437"},
        {"Fundamental Katalog 5th Edition", "FK5 3534"},
        {"Geneva Identification System", "GEN# +1.00179497"},
        {"Smithsonian Astrophysical Observation", "SAO 162326"},
        {"Wilson Evans Batten Catalogue", "WEB 16457"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31464939),
        dec: Angle.Degrees(-12.28250973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107993"},
        {"Hipparcos Number", "HIP 60532"},
        {"Smithsonian Astrophysical Observation", "SAO 157263"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.13258073),
        dec: Angle.Degrees(-12.28221642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111137"},
        {"Hipparcos Number", "HIP 62399"},
        {"Smithsonian Astrophysical Observation", "SAO 157508"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.82480334),
        dec: Angle.Degrees(-12.27892895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34553"},
        {"Hipparcos Number", "HIP 24698"},
        {"Smithsonian Astrophysical Observation", "SAO 150312"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.45827342),
        dec: Angle.Degrees(-12.27649203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97908"},
        {"Hipparcos Number", "HIP 54987"},
        {"Geneva Identification System", "GEN# +1.00097908"},
        {"Smithsonian Astrophysical Observation", "SAO 156567"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.89198797),
        dec: Angle.Degrees(-12.27624248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48762"},
        {"Geneva Identification System", "GEN# -0.01102763"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.19178097),
        dec: Angle.Degrees(-12.27026571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6404"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.56789872),
        dec: Angle.Degrees(-12.26920521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 246.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16700 AB"},
        {"Henry Draper", "HD 220188"},
        {"Hipparcos Number", "HIP 115346"},
        {"Geneva Identification System", "GEN# +1.00220188J"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46123408),
        dec: Angle.Degrees(-12.26796101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204971"},
        {"Hipparcos Number", "HIP 106351"},
        {"Geneva Identification System", "GEN# +1.00204971"},
        {"Smithsonian Astrophysical Observation", "SAO 164461"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.09204365),
        dec: Angle.Degrees(-12.26729153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181533"},
        {"Hipparcos Number", "HIP 95135"},
        {"Renson", "Renson 50274"},
        {"Smithsonian Astrophysical Observation", "SAO 162507"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.32994948),
        dec: Angle.Degrees(-12.26654858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28385"},
        {"Hipparcos Number", "HIP 20857"},
        {"Smithsonian Astrophysical Observation", "SAO 149662"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.04501657),
        dec: Angle.Degrees(-12.26523595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202783"},
        {"Hipparcos Number", "HIP 105189"},
        {"Geneva Identification System", "GEN# +1.00202783"},
        {"Smithsonian Astrophysical Observation", "SAO 164292"},
        {"Wilson Evans Batten Catalogue", "WEB 19101"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.62524317),
        dec: Angle.Degrees(-12.26520116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89653"},
        {"Geneva Identification System", "GEN# +2.66040007"},
        {"Smithsonian Astrophysical Observation", "SAO 161281"},
        {"New General Catalogue", "NGC 6604 7"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.44602251),
        dec: Angle.Degrees(-12.26370090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20153"},
        {"Hipparcos Number", "HIP 15050"},
        {"Smithsonian Astrophysical Observation", "SAO 148848"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.48894918),
        dec: Angle.Degrees(-12.26318435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171198"},
        {"Hipparcos Number", "HIP 91003"},
        {"Geneva Identification System", "GEN# +1.00171198"},
        {"Smithsonian Astrophysical Observation", "SAO 161609"},
        {"Wilson Evans Batten Catalogue", "WEB 15616"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.47128358),
        dec: Angle.Degrees(-12.26287009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11939"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.51285289),
        dec: Angle.Degrees(-12.25971743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9315"},
        {"Hipparcos Number", "HIP 7113"},
        {"Geneva Identification System", "GEN# +1.00009315"},
        {"Smithsonian Astrophysical Observation", "SAO 147860"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.90343466),
        dec: Angle.Degrees(-12.25818663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12139"},
        {"Smithsonian Astrophysical Observation", "SAO 148497"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.09775343),
        dec: Angle.Degrees(-12.25739327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10784"},
        {"Hipparcos Number", "HIP 8197"},
        {"Smithsonian Astrophysical Observation", "SAO 147998"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.34133157),
        dec: Angle.Degrees(-12.25659426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189558"},
        {"Hipparcos Number", "HIP 98532"},
        {"Cincinnati Publication", "Ci 20 1177"},
        {"Cincinnati Publication 2", "Ci 18 2607"},
        {"Geneva Identification System", "GEN# +1.00189558"},
        {"Smithsonian Astrophysical Observation", "SAO 163181"},
        {"Wilson Evans Batten Catalogue", "WEB 17402"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25179101),
        dec: Angle.Degrees(-12.25476253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -309.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -365.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211021"},
        {"Hipparcos Number", "HIP 109811"},
        {"Geneva Identification System", "GEN# +1.00211021"},
        {"Smithsonian Astrophysical Observation", "SAO 164945"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.62780928),
        dec: Angle.Degrees(-12.25381456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184574"},
        {"Hipparcos Number", "HIP 96365"},
        {"Geneva Identification System", "GEN# +1.00184574"},
        {"Smithsonian Astrophysical Observation", "SAO 162797"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88943308),
        dec: Angle.Degrees(-12.25306622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206377"},
        {"Hipparcos Number", "HIP 107127"},
        {"Smithsonian Astrophysical Observation", "SAO 164584"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.50188589),
        dec: Angle.Degrees(-12.24963587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172203"},
        {"Hipparcos Number", "HIP 91480"},
        {"Smithsonian Astrophysical Observation", "SAO 161698"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.86066784),
        dec: Angle.Degrees(-12.24776090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15586"},
        {"Hipparcos Number", "HIP 11634"},
        {"Smithsonian Astrophysical Observation", "SAO 148426"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.52891306),
        dec: Angle.Degrees(-12.24662393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8972"},
        {"Hipparcos Number", "HIP 6859"},
        {"Geneva Identification System", "GEN# +1.00008972"},
        {"Renson", "Renson 2170"},
        {"Smithsonian Astrophysical Observation", "SAO 147824"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.06699313),
        dec: Angle.Degrees(-12.24598966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5602"},
        {"Hipparcos Number", "HIP 4494"},
        {"Smithsonian Astrophysical Observation", "SAO 147536"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.39841938),
        dec: Angle.Degrees(-12.24562419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22642"},
        {"Hipparcos Number", "HIP 16956"},
        {"Smithsonian Astrophysical Observation", "SAO 149075"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.53299212),
        dec: Angle.Degrees(-12.24311974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43687"},
        {"Hipparcos Number", "HIP 29838"},
        {"Smithsonian Astrophysical Observation", "SAO 151310"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.24324459),
        dec: Angle.Degrees(-12.24269469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167971"},
        {"Hipparcos Number", "HIP 89681"},
        {"Geneva Identification System", "GEN# +2.66040001"},
        {"Smithsonian Astrophysical Observation", "SAO 161292"},
        {"Wilson Evans Batten Catalogue", "WEB 15281"},
        {"New General Catalogue", "NGC 6604 1"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.52456493),
        dec: Angle.Degrees(-12.24257847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124703"},
        {"Hipparcos Number", "HIP 69657"},
        {"Geneva Identification System", "GEN# +1.00124703"},
        {"Smithsonian Astrophysical Observation", "SAO 158449"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.84604209),
        dec: Angle.Degrees(-12.24250106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24192"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.90877144),
        dec: Angle.Degrees(-12.24187054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59832"},
        {"Hipparcos Number", "HIP 36579"},
        {"Smithsonian Astrophysical Observation", "SAO 153002"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.85566630),
        dec: Angle.Degrees(-12.24112909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105205"},
        {"Hipparcos Number", "HIP 59068"},
        {"Fundamental Katalog 5th Edition", "FK5 2968"},
        {"Geneva Identification System", "GEN# +1.00105205"},
        {"Smithsonian Astrophysical Observation", "SAO 157086"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.69744287),
        dec: Angle.Degrees(-12.24084421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77151"},
        {"Hipparcos Number", "HIP 44210"},
        {"Smithsonian Astrophysical Observation", "SAO 154823"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.08369176),
        dec: Angle.Degrees(-12.24075951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211492"},
        {"Hipparcos Number", "HIP 110065"},
        {"Smithsonian Astrophysical Observation", "SAO 164986"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.40992707),
        dec: Angle.Degrees(-12.23861543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129293"},
        {"Hipparcos Number", "HIP 71873"},
        {"Smithsonian Astrophysical Observation", "SAO 158742"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.50943823),
        dec: Angle.Degrees(-12.23490148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153022"},
        {"Hipparcos Number", "HIP 82981"},
        {"Geneva Identification System", "GEN# +1.00153022"},
        {"Smithsonian Astrophysical Observation", "SAO 160185"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.36322572),
        dec: Angle.Degrees(-12.23458175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66033"},
        {"Hipparcos Number", "HIP 39218"},
        {"Smithsonian Astrophysical Observation", "SAO 153722"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.32885877),
        dec: Angle.Degrees(-12.23073193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214873"},
        {"Hipparcos Number", "HIP 112021"},
        {"Smithsonian Astrophysical Observation", "SAO 165233"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35682542),
        dec: Angle.Degrees(-12.22990642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37809"},
        {"Hipparcos Number", "HIP 26724"},
        {"Geneva Identification System", "GEN# +1.00037809"},
        {"Smithsonian Astrophysical Observation", "SAO 150681"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.18497233),
        dec: Angle.Degrees(-12.22933547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91889"},
        {"Hipparcos Number", "HIP 51933"},
        {"Cincinnati Publication", "Ci 20 585"},
        {"Fundamental Katalog 5th Edition", "FK5 1274"},
        {"Geneva Identification System", "GEN# +1.00091889"},
        {"Smithsonian Astrophysical Observation", "SAO 156095"},
        {"Wilson Evans Batten Catalogue", "WEB 9478"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.13426115),
        dec: Angle.Degrees(-12.22848702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 268.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -672.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81953"},
        {"Smithsonian Astrophysical Observation", "SAO 160075"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.13254871),
        dec: Angle.Degrees(-12.22824413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55902"},
        {"Hipparcos Number", "HIP 34998"},
        {"Geneva Identification System", "GEN# +1.00055902"},
        {"Smithsonian Astrophysical Observation", "SAO 152600"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.61657684),
        dec: Angle.Degrees(-12.22698306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46183"},
        {"Hipparcos Number", "HIP 31087"},
        {"Fundamental Katalog 5th Edition", "FK5 4593"},
        {"Geneva Identification System", "GEN# +1.00046183"},
        {"Smithsonian Astrophysical Observation", "SAO 151603"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.85013045),
        dec: Angle.Degrees(-12.22671567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39054"},
        {"Hipparcos Number", "HIP 27509"},
        {"Smithsonian Astrophysical Observation", "SAO 150844"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.38366354),
        dec: Angle.Degrees(-12.22494693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64526"},
        {"Smithsonian Astrophysical Observation", "SAO 157800"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.37069827),
        dec: Angle.Degrees(-12.22469068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208965"},
        {"Hipparcos Number", "HIP 108619"},
        {"Smithsonian Astrophysical Observation", "SAO 164802"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.05375042),
        dec: Angle.Degrees(-12.22467703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58882"},
        {"Hipparcos Number", "HIP 36179"},
        {"Geneva Identification System", "GEN# +1.00058882"},
        {"Smithsonian Astrophysical Observation", "SAO 152892"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.76573051),
        dec: Angle.Degrees(-12.22393007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15658"},
        {"Hipparcos Number", "HIP 11694"},
        {"Smithsonian Astrophysical Observation", "SAO 148432"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.70600887),
        dec: Angle.Degrees(-12.22342358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121422"},
        {"Hipparcos Number", "HIP 67999"},
        {"Smithsonian Astrophysical Observation", "SAO 158236"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.88135103),
        dec: Angle.Degrees(-12.22304874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9082"},
        {"Smithsonian Astrophysical Observation", "SAO 148121"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.23810318),
        dec: Angle.Degrees(-12.22165569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211841"},
        {"Hipparcos Number", "HIP 110278"},
        {"Smithsonian Astrophysical Observation", "SAO 165007"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.06782140),
        dec: Angle.Degrees(-12.22153676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20529"},
        {"Hipparcos Number", "HIP 15335"},
        {"Smithsonian Astrophysical Observation", "SAO 148886"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.44063707),
        dec: Angle.Degrees(-12.22152657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141044"},
        {"Hipparcos Number", "HIP 77337"},
        {"Geneva Identification System", "GEN# +1.00141044"},
        {"Smithsonian Astrophysical Observation", "SAO 159495"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.83377360),
        dec: Angle.Degrees(-12.22128678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6606 AB"},
        {"Aitken 2", "ADS 6606"},
        {"Henry Draper", "HD 67430"},
        {"Hipparcos Number", "HIP 39753"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)07, 30.8000),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)13, 14.900)
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
    primaryId: "HIP 62279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110937"},
        {"Hipparcos Number", "HIP 62279"},
        {"Smithsonian Astrophysical Observation", "SAO 157493"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.44647224),
        dec: Angle.Degrees(-12.22077399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63439"},
        {"Hipparcos Number", "HIP 38103"},
        {"Fundamental Katalog 5th Edition", "FK5 4704"},
        {"Smithsonian Astrophysical Observation", "SAO 153427"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.12734636),
        dec: Angle.Degrees(-12.21856607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222721"},
        {"Hipparcos Number", "HIP 117002"},
        {"Cincinnati Publication", "Ci 18 3113"},
        {"Smithsonian Astrophysical Observation", "SAO 165845"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.79169900),
        dec: Angle.Degrees(-12.21853480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10305 AB"},
        {"Hipparcos Number", "HIP 83283"},
        {"Smithsonian Astrophysical Observation", "SAO 160228"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.30646789),
        dec: Angle.Degrees(-12.21715548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108821",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108821"},
        {"Smithsonian Astrophysical Observation", "SAO 164832"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.69196666),
        dec: Angle.Degrees(-12.21688064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7274",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1223 AB"},
        {"Henry Draper", "HD 9575"},
        {"Hipparcos Number", "HIP 7274"},
        {"Geneva Identification System", "GEN# +1.00009575J"},
        {"Smithsonian Astrophysical Observation", "SAO 147882"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.42670141),
        dec: Angle.Degrees(-12.21287570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220958"},
        {"Hipparcos Number", "HIP 115844"},
        {"Smithsonian Astrophysical Observation", "SAO 165710"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.03026654),
        dec: Angle.Degrees(-12.21229504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1835"},
        {"Hipparcos Number", "HIP 1803"},
        {"Cincinnati Publication", "Ci 20 26"},
        {"Geneva Identification System", "GEN# +1.00001835"},
        {"Smithsonian Astrophysical Observation", "SAO 147237"},
        {"Wilson Evans Batten Catalogue", "WEB 320"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.71480399),
        dec: Angle.Degrees(-12.20958506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 394.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89605"},
        {"Hipparcos Number", "HIP 50600"},
        {"Smithsonian Astrophysical Observation", "SAO 155904"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.05235057),
        dec: Angle.Degrees(-12.20894920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34196"},
        {"Hipparcos Number", "HIP 24465"},
        {"Smithsonian Astrophysical Observation", "SAO 150269"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.76328166),
        dec: Angle.Degrees(-12.20476209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14598"},
        {"Hipparcos Number", "HIP 10970"},
        {"Geneva Identification System", "GEN# +1.00014598"},
        {"Smithsonian Astrophysical Observation", "SAO 148343"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31671715),
        dec: Angle.Degrees(-12.20374748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8590"},
        {"Cincinnati Publication", "Ci 20 129"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.71764478),
        dec: Angle.Degrees(-12.20368514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 434.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101535"},
        {"Hipparcos Number", "HIP 56987"},
        {"Smithsonian Astrophysical Observation", "SAO 156831"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.22816763),
        dec: Angle.Degrees(-12.20283663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -326.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222092"},
        {"Hipparcos Number", "HIP 116593"},
        {"Smithsonian Astrophysical Observation", "SAO 165805"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.42147575),
        dec: Angle.Degrees(-12.20182981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58277"},
        {"Hipparcos Number", "HIP 35936"},
        {"Smithsonian Astrophysical Observation", "SAO 152830"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.12041238),
        dec: Angle.Degrees(-12.20145347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83582"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.23744680),
        dec: Angle.Degrees(-12.20143235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91259"},
        {"Hipparcos Number", "HIP 51572"},
        {"Smithsonian Astrophysical Observation", "SAO 156041"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.00521545),
        dec: Angle.Degrees(-12.19941074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49274"},
        {"Hipparcos Number", "HIP 32513"},
        {"Smithsonian Astrophysical Observation", "SAO 151924"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.77932016),
        dec: Angle.Degrees(-12.19911128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139695"},
        {"Hipparcos Number", "HIP 76717"},
        {"Geneva Identification System", "GEN# +1.00139695"},
        {"Smithsonian Astrophysical Observation", "SAO 159424"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.98996954),
        dec: Angle.Degrees(-12.19885468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92545"},
        {"Hipparcos Number", "HIP 52279"},
        {"Renson", "Renson 26700"},
        {"Smithsonian Astrophysical Observation", "SAO 156159"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.24053066),
        dec: Angle.Degrees(-12.19579171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5920"},
        {"Hipparcos Number", "HIP 4707"},
        {"Smithsonian Astrophysical Observation", "SAO 147564"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.12663835),
        dec: Angle.Degrees(-12.19560626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221328"},
        {"Hipparcos Number", "HIP 116078"},
        {"Geneva Identification System", "GEN# +1.00221328"},
        {"Smithsonian Astrophysical Observation", "SAO 165736"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.82197475),
        dec: Angle.Degrees(-12.19472431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63336"},
        {"Hipparcos Number", "HIP 38048"},
        {"Geneva Identification System", "GEN# +1.00063336"},
        {"Smithsonian Astrophysical Observation", "SAO 153414"},
        {"Wilson Evans Batten Catalogue", "WEB 7502"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98659214),
        dec: Angle.Degrees(-12.19289276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216567"},
        {"Hipparcos Number", "HIP 113085"},
        {"Fundamental Katalog 5th Edition", "FK5 6023"},
        {"Smithsonian Astrophysical Observation", "SAO 165366"},
        {"Wilson Evans Batten Catalogue", "WEB 20129"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52955349),
        dec: Angle.Degrees(-12.19030907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136310"},
        {"Hipparcos Number", "HIP 75064"},
        {"Smithsonian Astrophysical Observation", "SAO 159183"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.09184252),
        dec: Angle.Degrees(-12.19013835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102990"},
        {"Hipparcos Number", "HIP 57819"},
        {"Fundamental Katalog 5th Edition", "FK5 2947"},
        {"Geneva Identification System", "GEN# +1.00102990"},
        {"Smithsonian Astrophysical Observation", "SAO 156940"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.84183475),
        dec: Angle.Degrees(-12.18792174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85455",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10559 AB"},
        {"Henry Draper", "HD 158101"},
        {"Hipparcos Number", "HIP 85455"},
        {"Smithsonian Astrophysical Observation", "SAO 160561"},
    },
    visualMagnitude: 8.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.94984299),
        dec: Angle.Degrees(-12.18670807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211990"},
        {"Hipparcos Number", "HIP 110375"},
        {"Smithsonian Astrophysical Observation", "SAO 165018"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.34436244),
        dec: Angle.Degrees(-12.18580969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104311",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14657 AB"},
        {"Henry Draper", "HD 201103"},
        {"Hipparcos Number", "HIP 104311"},
        {"Smithsonian Astrophysical Observation", "SAO 164157"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.96967858),
        dec: Angle.Degrees(-12.18527364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48038"},
        {"Hipparcos Number", "HIP 31976"},
        {"Geneva Identification System", "GEN# +1.00048038"},
        {"Smithsonian Astrophysical Observation", "SAO 151785"},
        {"Wilson Evans Batten Catalogue", "WEB 6441"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23878317),
        dec: Angle.Degrees(-12.18225682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217971"},
        {"Hipparcos Number", "HIP 113945"},
        {"Smithsonian Astrophysical Observation", "SAO 165477"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.12585986),
        dec: Angle.Degrees(-12.17920979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84487"},
        {"Wilson Evans Batten Catalogue", "WEB 14263"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.08395542),
        dec: Angle.Degrees(-12.17809864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36996"},
        {"Smithsonian Astrophysical Observation", "SAO 153126"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.06269963),
        dec: Angle.Degrees(-12.17528560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40432"},
        {"Hipparcos Number", "HIP 28256"},
        {"Geneva Identification System", "GEN# +1.00040432"},
        {"Smithsonian Astrophysical Observation", "SAO 150981"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.55819112),
        dec: Angle.Degrees(-12.17328253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3569"},
        {"Hipparcos Number", "HIP 3028"},
        {"Smithsonian Astrophysical Observation", "SAO 147376"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.63821988),
        dec: Angle.Degrees(-12.17262517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19178"},
        {"Hipparcos Number", "HIP 14330"},
        {"Geneva Identification System", "GEN# +1.00019178"},
        {"Smithsonian Astrophysical Observation", "SAO 148750"},
        {"Wilson Evans Batten Catalogue", "WEB 2802"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.20700231),
        dec: Angle.Degrees(-12.17141166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219833"},
        {"Hipparcos Number", "HIP 115119"},
        {"Geneva Identification System", "GEN# +1.00219833"},
        {"Smithsonian Astrophysical Observation", "SAO 165622"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.75892570),
        dec: Angle.Degrees(-12.17042573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6929 AB"},
        {"Henry Draper", "HD 73941"},
        {"Hipparcos Number", "HIP 42574"},
        {"Smithsonian Astrophysical Observation", "SAO 154531"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.17256862),
        dec: Angle.Degrees(-12.16908925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 358025"},
        {"Hipparcos Number", "HIP 103349"},
        {"Cincinnati Publication", "Ci 20 1239"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.07879536),
        dec: Angle.Degrees(-12.16878685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -465.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6748"},
        {"Hipparcos Number", "HIP 5328"},
        {"Geneva Identification System", "GEN# +1.00006748"},
        {"Smithsonian Astrophysical Observation", "SAO 147627"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.04425060),
        dec: Angle.Degrees(-12.16808167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99290"},
        {"Hipparcos Number", "HIP 55752"},
        {"Smithsonian Astrophysical Observation", "SAO 156666"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.35871625),
        dec: Angle.Degrees(-12.16716355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16697"},
        {"Hipparcos Number", "HIP 12449"},
        {"Smithsonian Astrophysical Observation", "SAO 148536"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.07211946),
        dec: Angle.Degrees(-12.16520299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96298"},
        {"Hipparcos Number", "HIP 54258"},
        {"Smithsonian Astrophysical Observation", "SAO 156450"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.49525391),
        dec: Angle.Degrees(-12.16496109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67166"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.46272595),
        dec: Angle.Degrees(-12.16408552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17193"},
        {"Hipparcos Number", "HIP 12849"},
        {"Geneva Identification System", "GEN# +1.00017193"},
        {"Smithsonian Astrophysical Observation", "SAO 148585"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.29845350),
        dec: Angle.Degrees(-12.16056931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10571"},
        {"Hipparcos Number", "HIP 8007"},
        {"Smithsonian Astrophysical Observation", "SAO 147973"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.70371269),
        dec: Angle.Degrees(-12.16028541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19278"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.97151585),
        dec: Angle.Degrees(-12.16016906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29902"},
        {"Hipparcos Number", "HIP 21883"},
        {"Smithsonian Astrophysical Observation", "SAO 149835"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.56506145),
        dec: Angle.Degrees(-12.16001253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215555"},
        {"Hipparcos Number", "HIP 112415"},
        {"Smithsonian Astrophysical Observation", "SAO 165283"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.53644067),
        dec: Angle.Degrees(-12.15884732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213781"},
        {"Hipparcos Number", "HIP 111396"},
        {"Geneva Identification System", "GEN# +1.00213781"},
        {"Renson", "Renson 59300"},
        {"Smithsonian Astrophysical Observation", "SAO 165163"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.51910225),
        dec: Angle.Degrees(-12.15823192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58579",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8391 AB"},
        {"Henry Draper", "HD 104324"},
        {"Hipparcos Number", "HIP 58579"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.19812406),
        dec: Angle.Degrees(-12.15747773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124358"},
        {"Hipparcos Number", "HIP 69470"},
        {"Geneva Identification System", "GEN# +1.00124358"},
        {"Smithsonian Astrophysical Observation", "SAO 158436"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.33906649),
        dec: Angle.Degrees(-12.15664837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50462"},
        {"Hipparcos Number", "HIP 33029"},
        {"Geneva Identification System", "GEN# +1.00050462"},
        {"Renson", "Renson 13820"},
        {"Smithsonian Astrophysical Observation", "SAO 152042"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.22787508),
        dec: Angle.Degrees(-12.15453303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89634"},
        {"Hipparcos Number", "HIP 50617"},
        {"Smithsonian Astrophysical Observation", "SAO 155907"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.09181719),
        dec: Angle.Degrees(-12.15268787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -318.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19290"},
    },
    visualMagnitude: 10.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.02577143),
        dec: Angle.Degrees(-12.15176501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164047"},
        {"Hipparcos Number", "HIP 88117"},
        {"Geneva Identification System", "GEN# +1.00164047"},
        {"Smithsonian Astrophysical Observation", "SAO 160973"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.95094683),
        dec: Angle.Degrees(-12.15080829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10411"},
        {"Hipparcos Number", "HIP 7877"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.33038801),
        dec: Angle.Degrees(-12.14719354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78484"},
        {"Smithsonian Astrophysical Observation", "SAO 159637"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.32825632),
        dec: Angle.Degrees(-12.14502483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8675"},
        {"Hipparcos Number", "HIP 6656"},
        {"Smithsonian Astrophysical Observation", "SAO 147799"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33891062),
        dec: Angle.Degrees(-12.14495359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95722",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12469 AB"},
        {"Henry Draper", "HD 183063"},
        {"Hipparcos Number", "HIP 95722"},
        {"Geneva Identification System", "GEN# +1.00183063"},
        {"Wilson Evans Batten Catalogue", "WEB 16749"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05108595),
        dec: Angle.Degrees(-12.14461006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207272"},
        {"Hipparcos Number", "HIP 107632"},
        {"Smithsonian Astrophysical Observation", "SAO 164662"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.01733013),
        dec: Angle.Degrees(-12.14445002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4272"},
        {"Hipparcos Number", "HIP 3526"},
        {"Geneva Identification System", "GEN# +1.00004272"},
        {"Smithsonian Astrophysical Observation", "SAO 147430"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.24814887),
        dec: Angle.Degrees(-12.14430859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178881"},
        {"Hipparcos Number", "HIP 94222"},
        {"Smithsonian Astrophysical Observation", "SAO 162279"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.71157023),
        dec: Angle.Degrees(-12.14315226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77177"},
        {"Hipparcos Number", "HIP 44237"},
        {"Geneva Identification System", "GEN# +1.00077177"},
        {"Renson", "Renson 21793"},
        {"Smithsonian Astrophysical Observation", "SAO 154826"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.13725082),
        dec: Angle.Degrees(-12.14062842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144449"},
        {"Hipparcos Number", "HIP 78899"},
        {"Geneva Identification System", "GEN# +1.00144449"},
        {"Smithsonian Astrophysical Observation", "SAO 159695"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.59467846),
        dec: Angle.Degrees(-12.13969465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101244"},
        {"Hipparcos Number", "HIP 56824"},
        {"Smithsonian Astrophysical Observation", "SAO 156806"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.73034159),
        dec: Angle.Degrees(-12.13838889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205180"},
        {"Hipparcos Number", "HIP 106475"},
        {"Smithsonian Astrophysical Observation", "SAO 164481"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.47797758),
        dec: Angle.Degrees(-12.13774164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146996"},
        {"Hipparcos Number", "HIP 79988"},
        {"Geneva Identification System", "GEN# +1.00146996"},
        {"Smithsonian Astrophysical Observation", "SAO 159853"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.91117130),
        dec: Angle.Degrees(-12.13125287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122800"},
        {"Hipparcos Number", "HIP 68735"},
        {"Geneva Identification System", "GEN# +1.00122800"},
        {"Smithsonian Astrophysical Observation", "SAO 158322"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.05046096),
        dec: Angle.Degrees(-12.12976290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82943"},
        {"Hipparcos Number", "HIP 47007"},
        {"Geneva Identification System", "GEN# +1.00082943"},
        {"Smithsonian Astrophysical Observation", "SAO 155312"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.71139454),
        dec: Angle.Degrees(-12.12912278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35136"},
        {"Hipparcos Number", "HIP 25074"},
        {"Smithsonian Astrophysical Observation", "SAO 150381"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.52535602),
        dec: Angle.Degrees(-12.12707399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29573"},
        {"Hipparcos Number", "HIP 21644"},
        {"Geneva Identification System", "GEN# +1.00029573"},
        {"Renson", "Renson 7570"},
        {"Smithsonian Astrophysical Observation", "SAO 149789"},
        {"Wilson Evans Batten Catalogue", "WEB 4160"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72330721),
        dec: Angle.Degrees(-12.12307828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187111"},
        {"Hipparcos Number", "HIP 97468"},
        {"Geneva Identification System", "GEN# +1.00187111"},
        {"Smithsonian Astrophysical Observation", "SAO 163006"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.16480187),
        dec: Angle.Degrees(-12.12200918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94604"},
        {"Hipparcos Number", "HIP 53392"},
        {"Smithsonian Astrophysical Observation", "SAO 156325"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.81032947),
        dec: Angle.Degrees(-12.12176335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73622"},
        {"Hipparcos Number", "HIP 42421"},
        {"Smithsonian Astrophysical Observation", "SAO 154497"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75526995),
        dec: Angle.Degrees(-12.12028867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45419"},
        {"Hipparcos Number", "HIP 30674"},
        {"Renson", "Renson 12020"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.68527098),
        dec: Angle.Degrees(-12.11243455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142272"},
        {"Hipparcos Number", "HIP 77863"},
        {"Smithsonian Astrophysical Observation", "SAO 159566"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.48872207),
        dec: Angle.Degrees(-12.11017932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113216"},
        {"Hipparcos Number", "HIP 63610"},
        {"Smithsonian Astrophysical Observation", "SAO 157668"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.55375089),
        dec: Angle.Degrees(-12.10899745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103774"},
        {"Hipparcos Number", "HIP 58263"},
        {"Geneva Identification System", "GEN# +1.00103774"},
        {"Smithsonian Astrophysical Observation", "SAO 157002"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.23193399),
        dec: Angle.Degrees(-12.10786086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168112"},
        {"Hipparcos Number", "HIP 89729"},
        {"Geneva Identification System", "GEN# +1.00168112"},
        {"Smithsonian Astrophysical Observation", "SAO 161311"},
        {"Wilson Evans Batten Catalogue", "WEB 15296"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.67027967),
        dec: Angle.Degrees(-12.10648464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33762"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.18324128),
        dec: Angle.Degrees(-12.10592968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115573"},
        {"Hipparcos Number", "HIP 64900"},
        {"Smithsonian Astrophysical Observation", "SAO 157842"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.53539363),
        dec: Angle.Degrees(-12.10441145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208691"},
        {"Hipparcos Number", "HIP 108458"},
        {"Smithsonian Astrophysical Observation", "SAO 164775"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.57361047),
        dec: Angle.Degrees(-12.10216422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23614"},
        {"Hipparcos Number", "HIP 17593"},
        {"Geneva Identification System", "GEN# +1.00023614"},
        {"Smithsonian Astrophysical Observation", "SAO 149158"},
        {"Wilson Evans Batten Catalogue", "WEB 3348"},
    },
    visualMagnitude: 4.43,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.53542672),
        dec: Angle.Degrees(-12.10173530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98990"},
        {"Hipparcos Number", "HIP 55600"},
        {"Smithsonian Astrophysical Observation", "SAO 156645"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.84632122),
        dec: Angle.Degrees(-12.09944063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24712"},
        {"Hipparcos Number", "HIP 18339"},
        {"Geneva Identification System", "GEN# +1.00024712"},
        {"Renson", "Renson 6320"},
        {"Smithsonian Astrophysical Observation", "SAO 149251"},
        {"Wilson Evans Batten Catalogue", "WEB 3542"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.81739077),
        dec: Angle.Degrees(-12.09905104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105885"},
        {"Hipparcos Number", "HIP 59410"},
        {"Geneva Identification System", "GEN# +1.00105885"},
        {"Smithsonian Astrophysical Observation", "SAO 157132"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.80988812),
        dec: Angle.Degrees(-12.09713882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7661"},
        {"Hipparcos Number", "HIP 5938"},
        {"Geneva Identification System", "GEN# +1.00007661"},
        {"Smithsonian Astrophysical Observation", "SAO 147702"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.10048066),
        dec: Angle.Degrees(-12.09698844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88182"},
        {"Hipparcos Number", "HIP 49802"},
        {"Geneva Identification System", "GEN# +1.00088182"},
        {"Renson", "Renson 25250"},
        {"Smithsonian Astrophysical Observation", "SAO 155777"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.48536641),
        dec: Angle.Degrees(-12.09526147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204073"},
        {"Hipparcos Number", "HIP 105856"},
        {"Smithsonian Astrophysical Observation", "SAO 164388"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.60444603),
        dec: Angle.Degrees(-12.09499954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81305"},
        {"Hipparcos Number", "HIP 46136"},
        {"Smithsonian Astrophysical Observation", "SAO 155155"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.12830513),
        dec: Angle.Degrees(-12.09451200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6852"},
        {"Hipparcos Number", "HIP 5393"},
        {"Geneva Identification System", "GEN# +1.00006852"},
        {"Smithsonian Astrophysical Observation", "SAO 147634"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.25470216),
        dec: Angle.Degrees(-12.09294872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118796"},
        {"Hipparcos Number", "HIP 66617"},
        {"Geneva Identification System", "GEN# +1.00118796"},
        {"Smithsonian Astrophysical Observation", "SAO 158069"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.82426600),
        dec: Angle.Degrees(-12.09199028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202130"},
        {"Hipparcos Number", "HIP 104826"},
        {"Smithsonian Astrophysical Observation", "SAO 164239"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.55003255),
        dec: Angle.Degrees(-12.09139870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136530"},
        {"Hipparcos Number", "HIP 75154"},
        {"Smithsonian Astrophysical Observation", "SAO 159195"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.38216847),
        dec: Angle.Degrees(-12.09118414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10064 AB"},
        {"Henry Draper", "HD 148246"},
        {"Hipparcos Number", "HIP 80576"},
        {"Smithsonian Astrophysical Observation", "SAO 159921"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.77689999),
        dec: Angle.Degrees(-12.09110428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100660"},
        {"Hipparcos Number", "HIP 56494"},
        {"Smithsonian Astrophysical Observation", "SAO 156765"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.72881054),
        dec: Angle.Degrees(-12.08749854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119292"},
        {"Hipparcos Number", "HIP 66901"},
        {"Geneva Identification System", "GEN# +1.00119292"},
        {"Smithsonian Astrophysical Observation", "SAO 158105"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.64887635),
        dec: Angle.Degrees(-12.08689594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21634"},
        {"Hipparcos Number", "HIP 16234"},
        {"Geneva Identification System", "GEN# +1.00021634"},
        {"Smithsonian Astrophysical Observation", "SAO 148982"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.30028475),
        dec: Angle.Degrees(-12.08616269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9729"},
        {"Hipparcos Number", "HIP 7373"},
        {"Smithsonian Astrophysical Observation", "SAO 147888"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.75588996),
        dec: Angle.Degrees(-12.08513487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153134"},
        {"Hipparcos Number", "HIP 83032"},
        {"Geneva Identification System", "GEN# +1.00153134"},
        {"Smithsonian Astrophysical Observation", "SAO 160193"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.50969806),
        dec: Angle.Degrees(-12.08417918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95422"},
        {"Hipparcos Number", "HIP 53839"},
        {"Geneva Identification System", "GEN# +1.00095422"},
        {"Smithsonian Astrophysical Observation", "SAO 156393"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.21149540),
        dec: Angle.Degrees(-12.08148709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46034"},
        {"Hipparcos Number", "HIP 31020"},
        {"Smithsonian Astrophysical Observation", "SAO 151582"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.63834775),
        dec: Angle.Degrees(-12.08105558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61699"},
        {"Hipparcos Number", "HIP 37366"},
        {"Geneva Identification System", "GEN# +1.00061699"},
        {"Smithsonian Astrophysical Observation", "SAO 153220"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.05740684),
        dec: Angle.Degrees(-12.08036283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81392"},
        {"Hipparcos Number", "HIP 46184"},
        {"Renson", "Renson 23130"},
        {"Smithsonian Astrophysical Observation", "SAO 155162"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25326078),
        dec: Angle.Degrees(-12.07977430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89270"},
        {"Hipparcos Number", "HIP 50422"},
        {"Smithsonian Astrophysical Observation", "SAO 155877"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.43249687),
        dec: Angle.Degrees(-12.07876025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55517"},
        {"Hipparcos Number", "HIP 34854"},
        {"Celescope Catalog", "CEL 1673"},
        {"Geneva Identification System", "GEN# +1.00055517"},
        {"Smithsonian Astrophysical Observation", "SAO 152557"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.19182135),
        dec: Angle.Degrees(-12.07775739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90447"},
        {"Hipparcos Number", "HIP 51098"},
        {"Smithsonian Astrophysical Observation", "SAO 155983"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.59763610),
        dec: Angle.Degrees(-12.07698375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191726"},
        {"Hipparcos Number", "HIP 99514"},
        {"Geneva Identification System", "GEN# +1.00191726"},
        {"Smithsonian Astrophysical Observation", "SAO 163327"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94565728),
        dec: Angle.Degrees(-12.07628543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106347",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106347"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.07743640),
        dec: Angle.Degrees(-12.07153202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109584"},
        {"Hipparcos Number", "HIP 61486"},
        {"Geneva Identification System", "GEN# +1.00109584"},
        {"Smithsonian Astrophysical Observation", "SAO 157385"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96986169),
        dec: Angle.Degrees(-12.06919053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163155"},
        {"Hipparcos Number", "HIP 87729"},
        {"Smithsonian Astrophysical Observation", "SAO 160904"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.79739455),
        dec: Angle.Degrees(-12.06871771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112495"},
        {"Hipparcos Number", "HIP 63220"},
        {"Smithsonian Astrophysical Observation", "SAO 157618"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.30284771),
        dec: Angle.Degrees(-12.06692425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79287",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9945 AB"},
        {"Henry Draper", "HD 145349"},
        {"Hipparcos Number", "HIP 79287"},
        {"Smithsonian Astrophysical Observation", "SAO 159754"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.72806628),
        dec: Angle.Degrees(-12.06547316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108777"},
        {"Hipparcos Number", "HIP 60981"},
        {"Geneva Identification System", "GEN# +1.00108777"},
        {"Smithsonian Astrophysical Observation", "SAO 157324"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.49356820),
        dec: Angle.Degrees(-12.06542362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125294"},
        {"Hipparcos Number", "HIP 69945"},
        {"Smithsonian Astrophysical Observation", "SAO 158485"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.70491157),
        dec: Angle.Degrees(-12.06320573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82412"},
        {"Hipparcos Number", "HIP 46725"},
        {"Smithsonian Astrophysical Observation", "SAO 155253"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.86891627),
        dec: Angle.Degrees(-12.06227094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203617"},
        {"Hipparcos Number", "HIP 105633"},
        {"Smithsonian Astrophysical Observation", "SAO 164359"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.92441507),
        dec: Angle.Degrees(-12.06014997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
