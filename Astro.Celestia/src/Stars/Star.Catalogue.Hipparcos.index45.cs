using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_45() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24932"},
        {"Smithsonian Astrophysical Observation", "SAO 150359"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.12570491),
        dec: Angle.Degrees(-19.40404574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63395"},
        {"Hipparcos Number", "HIP 38056"},
        {"Smithsonian Astrophysical Observation", "SAO 153416"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.99537425),
        dec: Angle.Degrees(-19.40358145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138426"},
        {"Hipparcos Number", "HIP 76103"},
        {"Renson", "Renson 39420"},
        {"Smithsonian Astrophysical Observation", "SAO 159329"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.14214242),
        dec: Angle.Degrees(-19.40272599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102498"},
        {"Hipparcos Number", "HIP 57550"},
        {"Smithsonian Astrophysical Observation", "SAO 156891"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.93940544),
        dec: Angle.Degrees(-19.40107162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82573"},
        {"Hipparcos Number", "HIP 46813"},
        {"Fundamental Katalog 5th Edition", "FK5 2757"},
        {"Geneva Identification System", "GEN# +1.00082573"},
        {"Renson", "Renson 23500"},
        {"Smithsonian Astrophysical Observation", "SAO 155273"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.08512296),
        dec: Angle.Degrees(-19.40032613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39055"},
        {"Hipparcos Number", "HIP 27485"},
        {"Smithsonian Astrophysical Observation", "SAO 150841"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.30212530),
        dec: Angle.Degrees(-19.39990237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1204"},
        {"Hipparcos Number", "HIP 1304"},
        {"Geneva Identification System", "GEN# +1.00001204"},
        {"Smithsonian Astrophysical Observation", "SAO 147192"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.09273140),
        dec: Angle.Degrees(-19.39924084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165688"},
        {"Hipparcos Number", "HIP 88828"},
        {"Geneva Identification System", "GEN# +1.00165688"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.98733473),
        dec: Angle.Degrees(-19.39912375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66991"},
        {"Hipparcos Number", "HIP 39575"},
        {"Renson", "Renson 18490"},
        {"Smithsonian Astrophysical Observation", "SAO 153807"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.30404734),
        dec: Angle.Degrees(-19.39850168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142113"},
        {"Hipparcos Number", "HIP 77813"},
        {"Smithsonian Astrophysical Observation", "SAO 159556"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.33706980),
        dec: Angle.Degrees(-19.39817873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195859"},
        {"Hipparcos Number", "HIP 101525"},
        {"Smithsonian Astrophysical Observation", "SAO 163693"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.61491290),
        dec: Angle.Degrees(-19.39795358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22631"},
        {"Smithsonian Astrophysical Observation", "SAO 149950"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.03898428),
        dec: Angle.Degrees(-19.39651006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33095"},
        {"Hipparcos Number", "HIP 23818"},
        {"Fundamental Katalog 5th Edition", "FK5 2385"},
        {"Geneva Identification System", "GEN# +1.00033095"},
        {"Smithsonian Astrophysical Observation", "SAO 150156"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.79074687),
        dec: Angle.Degrees(-19.39252388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 269.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6928"},
        {"Hipparcos Number", "HIP 5435"},
        {"Smithsonian Astrophysical Observation", "SAO 147640"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.38381620),
        dec: Angle.Degrees(-19.39169586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23033"},
        {"Hipparcos Number", "HIP 17212"},
        {"Smithsonian Astrophysical Observation", "SAO 149111"},
        {"Wilson Evans Batten Catalogue", "WEB 3260"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.30302910),
        dec: Angle.Degrees(-19.39142016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213623"},
        {"Hipparcos Number", "HIP 111321"},
        {"Smithsonian Astrophysical Observation", "SAO 165157"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.28244037),
        dec: Angle.Degrees(-19.39104626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53354"},
        {"Geneva Identification System", "GEN# -0.01803055"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.67452437),
        dec: Angle.Degrees(-19.38935007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5911"},
        {"Hipparcos Number", "HIP 4702"},
        {"Geneva Identification System", "GEN# +1.00005911"},
        {"Smithsonian Astrophysical Observation", "SAO 147563"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.11638594),
        dec: Angle.Degrees(-19.38925862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40418"},
        {"Hipparcos Number", "HIP 28218"},
        {"Smithsonian Astrophysical Observation", "SAO 150977"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.43405380),
        dec: Angle.Degrees(-19.38711881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39442"},
        {"Hipparcos Number", "HIP 27694"},
        {"Smithsonian Astrophysical Observation", "SAO 150882"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.95104066),
        dec: Angle.Degrees(-19.38697449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183741"},
        {"Hipparcos Number", "HIP 96044"},
        {"Smithsonian Astrophysical Observation", "SAO 162723"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92740724),
        dec: Angle.Degrees(-19.38645017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50678"},
        {"Hipparcos Number", "HIP 33083"},
        {"Smithsonian Astrophysical Observation", "SAO 152058"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.34640391),
        dec: Angle.Degrees(-19.38399208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49866"},
        {"Hipparcos Number", "HIP 32742"},
        {"Geneva Identification System", "GEN# +1.00049866"},
        {"Smithsonian Astrophysical Observation", "SAO 151978"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42948153),
        dec: Angle.Degrees(-19.38392537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191434"},
        {"Hipparcos Number", "HIP 99391"},
        {"Geneva Identification System", "GEN# +1.00191434"},
        {"Smithsonian Astrophysical Observation", "SAO 163313"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.60608664),
        dec: Angle.Degrees(-19.38315286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77939",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9834 AB"},
        {"Henry Draper", "HD 142378"},
        {"Hipparcos Number", "HIP 77939"},
        {"Geneva Identification System", "GEN# +1.00142378J"},
        {"Smithsonian Astrophysical Observation", "SAO 159572"},
        {"Wilson Evans Batten Catalogue", "WEB 13179"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.75154369),
        dec: Angle.Degrees(-19.38288098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144365"},
        {"Hipparcos Number", "HIP 78885"},
        {"Smithsonian Astrophysical Observation", "SAO 159688"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.55619005),
        dec: Angle.Degrees(-19.38173342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210832"},
        {"Hipparcos Number", "HIP 109721"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.36576101),
        dec: Angle.Degrees(-19.38065690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133649"},
        {"Hipparcos Number", "HIP 73904"},
        {"Smithsonian Astrophysical Observation", "SAO 159021"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.56163432),
        dec: Angle.Degrees(-19.37744293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22494"},
        {"Hipparcos Number", "HIP 16816"},
        {"Smithsonian Astrophysical Observation", "SAO 149064"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.10418486),
        dec: Angle.Degrees(-19.37671629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35593"},
        {"Hipparcos Number", "HIP 25324"},
        {"Smithsonian Astrophysical Observation", "SAO 150422"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.25009655),
        dec: Angle.Degrees(-19.37387974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6867"},
        {"Hipparcos Number", "HIP 5390"},
        {"Smithsonian Astrophysical Observation", "SAO 147636"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.24789697),
        dec: Angle.Degrees(-19.37350567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220715"},
        {"Hipparcos Number", "HIP 115675"},
        {"Smithsonian Astrophysical Observation", "SAO 165689"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.53585867),
        dec: Angle.Degrees(-19.37324359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10000"},
        {"Hipparcos Number", "HIP 7547"},
        {"Smithsonian Astrophysical Observation", "SAO 147912"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.30740160),
        dec: Angle.Degrees(-19.37170973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33887"},
        {"Hipparcos Number", "HIP 24278"},
        {"Smithsonian Astrophysical Observation", "SAO 150231"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.15397989),
        dec: Angle.Degrees(-19.36987132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12731"},
        {"Hipparcos Number", "HIP 9664"},
        {"Geneva Identification System", "GEN# +1.00012731"},
        {"Smithsonian Astrophysical Observation", "SAO 148181"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.07722040),
        dec: Angle.Degrees(-19.36779610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66691"},
        {"Hipparcos Number", "HIP 39472"},
        {"Smithsonian Astrophysical Observation", "SAO 153778"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.01842181),
        dec: Angle.Degrees(-19.36728691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152470"},
        {"Hipparcos Number", "HIP 82704"},
        {"Smithsonian Astrophysical Observation", "SAO 160155"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57916465),
        dec: Angle.Degrees(-19.36640043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181131"},
        {"Hipparcos Number", "HIP 95014"},
        {"Geneva Identification System", "GEN# +1.00181131"},
        {"Smithsonian Astrophysical Observation", "SAO 162478"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.99697108),
        dec: Angle.Degrees(-19.36627985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140781"},
        {"Hipparcos Number", "HIP 77231"},
        {"Smithsonian Astrophysical Observation", "SAO 159485"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.54210630),
        dec: Angle.Degrees(-19.36625591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7921"},
        {"Hipparcos Number", "HIP 6121"},
        {"Geneva Identification System", "GEN# +1.00007921"},
        {"Smithsonian Astrophysical Observation", "SAO 147729"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.64326576),
        dec: Angle.Degrees(-19.36521735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213767"},
        {"Hipparcos Number", "HIP 111401"},
        {"Smithsonian Astrophysical Observation", "SAO 165164"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.53299882),
        dec: Angle.Degrees(-19.36209313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126173"},
        {"Hipparcos Number", "HIP 70415"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.08804416),
        dec: Angle.Degrees(-19.36113749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1473"},
        {"Hipparcos Number", "HIP 1506"},
        {"Geneva Identification System", "GEN# +1.00001473"},
        {"Smithsonian Astrophysical Observation", "SAO 147211"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.68833067),
        dec: Angle.Degrees(-19.35998169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108141"},
        {"Hipparcos Number", "HIP 60623"},
        {"Geneva Identification System", "GEN# +1.00108141"},
        {"Smithsonian Astrophysical Observation", "SAO 157275"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.37082571),
        dec: Angle.Degrees(-19.35863424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28981"},
        {"Hipparcos Number", "HIP 21220"},
        {"Geneva Identification System", "GEN# +1.00028981"},
        {"Smithsonian Astrophysical Observation", "SAO 149723"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.28344328),
        dec: Angle.Degrees(-19.35849448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65809"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.34024236),
        dec: Angle.Degrees(-19.35820217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152146"},
        {"Hipparcos Number", "HIP 82547"},
        {"Geneva Identification System", "GEN# +1.00152146"},
        {"Smithsonian Astrophysical Observation", "SAO 160136"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.08608255),
        dec: Angle.Degrees(-19.35690772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28367"},
        {"Hipparcos Number", "HIP 20820"},
        {"Geneva Identification System", "GEN# +1.00028367"},
        {"Smithsonian Astrophysical Observation", "SAO 149651"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.92427385),
        dec: Angle.Degrees(-19.35682397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52010",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7856 A"},
        {"Henry Draper", "HD 92070"},
        {"Henry Draper 2", "HD 92070A"},
        {"Hipparcos Number", "HIP 52010"},
        {"Smithsonian Astrophysical Observation", "SAO 156112"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.39055552),
        dec: Angle.Degrees(-19.35624096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20375"},
        {"Hipparcos Number", "HIP 15210"},
        {"Smithsonian Astrophysical Observation", "SAO 148870"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.01885783),
        dec: Angle.Degrees(-19.35467978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48482"},
        {"Hipparcos Number", "HIP 32147"},
        {"Smithsonian Astrophysical Observation", "SAO 151826"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.70061505),
        dec: Angle.Degrees(-19.35455016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10558"},
        {"Hipparcos Number", "HIP 7982"},
        {"Geneva Identification System", "GEN# +1.00010558"},
        {"Smithsonian Astrophysical Observation", "SAO 147971"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.62898980),
        dec: Angle.Degrees(-19.35280626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17003"},
        {"Hipparcos Number", "HIP 12698"},
        {"Smithsonian Astrophysical Observation", "SAO 148567"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.77775238),
        dec: Angle.Degrees(-19.35186380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212175"},
        {"Hipparcos Number", "HIP 110475"},
        {"Smithsonian Astrophysical Observation", "SAO 165029"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.66283784),
        dec: Angle.Degrees(-19.34979466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215154"},
        {"Hipparcos Number", "HIP 112210"},
        {"Smithsonian Astrophysical Observation", "SAO 165251"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.88803170),
        dec: Angle.Degrees(-19.34911545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217447"},
        {"Hipparcos Number", "HIP 113641"},
        {"Geneva Identification System", "GEN# +1.00217447"},
        {"Smithsonian Astrophysical Observation", "SAO 165435"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.23093068),
        dec: Angle.Degrees(-19.34691515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16837"},
        {"Hipparcos Number", "HIP 12549"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.36351806),
        dec: Angle.Degrees(-19.34496659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197382"},
        {"Hipparcos Number", "HIP 102325"},
        {"Smithsonian Astrophysical Observation", "SAO 163833"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.97933653),
        dec: Angle.Degrees(-19.34414376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95403"},
        {"Hipparcos Number", "HIP 53816"},
        {"Geneva Identification System", "GEN# +1.00095403"},
        {"Smithsonian Astrophysical Observation", "SAO 156390"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15832110),
        dec: Angle.Degrees(-19.34310471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182978"},
        {"Hipparcos Number", "HIP 95711"},
        {"Geneva Identification System", "GEN# +1.00182978"},
        {"Smithsonian Astrophysical Observation", "SAO 162642"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.01372188),
        dec: Angle.Degrees(-19.34280600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77283"},
        {"Hipparcos Number", "HIP 44286"},
        {"Smithsonian Astrophysical Observation", "SAO 154840"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.28995111),
        dec: Angle.Degrees(-19.34216912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104457"},
        {"Hipparcos Number", "HIP 58653"},
        {"Smithsonian Astrophysical Observation", "SAO 157047"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.41358450),
        dec: Angle.Degrees(-19.33891630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3145 A"},
        {"Henry Draper", "HD 27629"},
        {"Hipparcos Number", "HIP 20283"},
        {"Geneva Identification System", "GEN# +1.00027629"},
        {"Smithsonian Astrophysical Observation", "SAO 149563"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.21066386),
        dec: Angle.Degrees(-19.33564106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65648"},
        {"Hipparcos Number", "HIP 39024"},
        {"Smithsonian Astrophysical Observation", "SAO 153670"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77453647),
        dec: Angle.Degrees(-19.33466201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10476 A"},
        {"Henry Draper", "HD 156846"},
        {"Hipparcos Number", "HIP 84856"},
        {"Geneva Identification System", "GEN# +1.00156846J"},
        {"Smithsonian Astrophysical Observation", "SAO 160474"},
        {"Wilson Evans Batten Catalogue", "WEB 14325"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.14331552),
        dec: Angle.Degrees(-19.33339899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125592"},
        {"Hipparcos Number", "HIP 70118"},
        {"Geneva Identification System", "GEN# +1.00125592"},
        {"Smithsonian Astrophysical Observation", "SAO 158499"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.20988398),
        dec: Angle.Degrees(-19.33239780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3132"},
        {"Hipparcos Number", "HIP 2709"},
        {"Geneva Identification System", "GEN# +1.00003132"},
        {"Smithsonian Astrophysical Observation", "SAO 147344"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.61083077),
        dec: Angle.Degrees(-19.33221170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119738"},
        {"Hipparcos Number", "HIP 67122"},
        {"Smithsonian Astrophysical Observation", "SAO 158143"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.34734080),
        dec: Angle.Degrees(-19.33219811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104777"},
        {"Cincinnati Publication", "Ci 20 1269"},
        {"Geneva Identification System", "GEN# +6.10220770"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.39265296),
        dec: Angle.Degrees(-19.32689199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -246.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1092.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5761"},
        {"Hipparcos Number", "HIP 4606"},
        {"Geneva Identification System", "GEN# +1.00005761"},
        {"Smithsonian Astrophysical Observation", "SAO 147556"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.76076009),
        dec: Angle.Degrees(-19.32623061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45437"},
        {"Hipparcos Number", "HIP 30655"},
        {"Smithsonian Astrophysical Observation", "SAO 151509"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.61574251),
        dec: Angle.Degrees(-19.32496246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77954"},
        {"Hipparcos Number", "HIP 44582"},
        {"Smithsonian Astrophysical Observation", "SAO 154888"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.24232738),
        dec: Angle.Degrees(-19.32161456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200297"},
        {"Hipparcos Number", "HIP 103896"},
        {"Geneva Identification System", "GEN# +1.00200297"},
        {"Smithsonian Astrophysical Observation", "SAO 164095"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.77312910),
        dec: Angle.Degrees(-19.32058937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173059"},
        {"Hipparcos Number", "HIP 91903"},
        {"Geneva Identification System", "GEN# +1.00173059"},
        {"Smithsonian Astrophysical Observation", "SAO 161777"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.03655816),
        dec: Angle.Degrees(-19.31788263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108276"},
        {"Hipparcos Number", "HIP 60708"},
        {"Geneva Identification System", "GEN# +1.00108276"},
        {"Smithsonian Astrophysical Observation", "SAO 157286"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63040312),
        dec: Angle.Degrees(-19.31614406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21966"},
        {"Hipparcos Number", "HIP 16446"},
        {"Smithsonian Astrophysical Observation", "SAO 149019"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.95376029),
        dec: Angle.Degrees(-19.31605676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85035"},
        {"Hipparcos Number", "HIP 48135"},
        {"Smithsonian Astrophysical Observation", "SAO 155505"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.19595610),
        dec: Angle.Degrees(-19.31349640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217802"},
        {"Hipparcos Number", "HIP 113855"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.85568063),
        dec: Angle.Degrees(-19.31317522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209096"},
        {"Hipparcos Number", "HIP 108708"},
        {"Smithsonian Astrophysical Observation", "SAO 164814"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.31104837),
        dec: Angle.Degrees(-19.31269005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6720"},
        {"Hipparcos Number", "HIP 5291"},
        {"Geneva Identification System", "GEN# +1.00006720"},
        {"Smithsonian Astrophysical Observation", "SAO 147623"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.92910095),
        dec: Angle.Degrees(-19.31203777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216663"},
        {"Hipparcos Number", "HIP 113163"},
        {"Geneva Identification System", "GEN# +1.00216663"},
        {"Smithsonian Astrophysical Observation", "SAO 165377"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.73711890),
        dec: Angle.Degrees(-19.31186484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204160"},
        {"Hipparcos Number", "HIP 105924"},
        {"Smithsonian Astrophysical Observation", "SAO 164398"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.80545778),
        dec: Angle.Degrees(-19.31180698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129379"},
        {"Hipparcos Number", "HIP 71934"},
        {"Fundamental Katalog 5th Edition", "FK5 3165"},
        {"Smithsonian Astrophysical Observation", "SAO 158752"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.68793274),
        dec: Angle.Degrees(-19.31174276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7641 A"},
        {"Henry Draper", "HD 87743"},
        {"Henry Draper 2", "HD 87743A"},
        {"Hipparcos Number", "HIP 49520"},
        {"Geneva Identification System", "GEN# +1.00087743"},
        {"Smithsonian Astrophysical Observation", "SAO 155731"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.66220578),
        dec: Angle.Degrees(-19.31066357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31682"},
        {"Smithsonian Astrophysical Observation", "SAO 151727"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42815662),
        dec: Angle.Degrees(-19.30943034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155803"},
        {"Hipparcos Number", "HIP 84344"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.66346459),
        dec: Angle.Degrees(-19.30918427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18478"},
        {"Hipparcos Number", "HIP 13793"},
        {"Smithsonian Astrophysical Observation", "SAO 148686"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.40177848),
        dec: Angle.Degrees(-19.30839297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89132"},
        {"Hipparcos Number", "HIP 50320"},
        {"Fundamental Katalog 5th Edition", "FK5 2825"},
        {"Smithsonian Astrophysical Observation", "SAO 155862"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.13676160),
        dec: Angle.Degrees(-19.30816453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180275"},
        {"Hipparcos Number", "HIP 94738"},
        {"Geneva Identification System", "GEN# +1.00180275"},
        {"Smithsonian Astrophysical Observation", "SAO 162394"},
        {"Wilson Evans Batten Catalogue", "WEB 16529"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.17412498),
        dec: Angle.Degrees(-19.30765418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13459"},
        {"Hipparcos Number", "HIP 10198"},
        {"Smithsonian Astrophysical Observation", "SAO 148259"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.78523903),
        dec: Angle.Degrees(-19.30738486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195623"},
        {"Hipparcos Number", "HIP 101405"},
        {"Smithsonian Astrophysical Observation", "SAO 163669"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.26257355),
        dec: Angle.Degrees(-19.30523598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176223"},
        {"Hipparcos Number", "HIP 93282"},
        {"Smithsonian Astrophysical Observation", "SAO 162065"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00437280),
        dec: Angle.Degrees(-19.30340797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19554"},
        {"Hipparcos Number", "HIP 14575"},
        {"Smithsonian Astrophysical Observation", "SAO 148787"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.03884986),
        dec: Angle.Degrees(-19.30291863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139446"},
        {"Hipparcos Number", "HIP 76628"},
        {"Geneva Identification System", "GEN# +1.00139446"},
        {"Smithsonian Astrophysical Observation", "SAO 159411"},
        {"Wilson Evans Batten Catalogue", "WEB 13008"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.72711374),
        dec: Angle.Degrees(-19.30170914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4274"},
        {"Hipparcos Number", "HIP 3525"},
        {"Geneva Identification System", "GEN# +1.00004274"},
        {"Smithsonian Astrophysical Observation", "SAO 147431"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.24793657),
        dec: Angle.Degrees(-19.29783711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16331"},
        {"Hipparcos Number", "HIP 12162"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.18369623),
        dec: Angle.Degrees(-19.29448455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143460"},
        {"Hipparcos Number", "HIP 78462"},
        {"Smithsonian Astrophysical Observation", "SAO 159632"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26467525),
        dec: Angle.Degrees(-19.29437206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188352"},
        {"Hipparcos Number", "HIP 98045"},
        {"Geneva Identification System", "GEN# +1.00188352"},
        {"Smithsonian Astrophysical Observation", "SAO 163107"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.84997231),
        dec: Angle.Degrees(-19.29284198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134887"},
        {"Hipparcos Number", "HIP 74455"},
        {"Smithsonian Astrophysical Observation", "SAO 159102"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.23235802),
        dec: Angle.Degrees(-19.29269193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54373"},
    },
    visualMagnitude: 10.38,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.86603065),
        dec: Angle.Degrees(-19.29137696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192974"},
        {"Hipparcos Number", "HIP 100107"},
        {"Geneva Identification System", "GEN# +1.00192974"},
        {"Smithsonian Astrophysical Observation", "SAO 163432"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61899969),
        dec: Angle.Degrees(-19.29129908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178175"},
        {"Hipparcos Number", "HIP 93996"},
        {"Geneva Identification System", "GEN# +1.00178175"},
        {"Smithsonian Astrophysical Observation", "SAO 162229"},
        {"Wilson Evans Batten Catalogue", "WEB 16361"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.06958032),
        dec: Angle.Degrees(-19.29028615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9641"},
        {"Hipparcos Number", "HIP 7316"},
        {"Smithsonian Astrophysical Observation", "SAO 147885"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.54976047),
        dec: Angle.Degrees(-19.29014194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18178"},
        {"Smithsonian Astrophysical Observation", "SAO 149231"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.31774943),
        dec: Angle.Degrees(-19.28882523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76336"},
        {"Hipparcos Number", "HIP 43769"},
        {"Smithsonian Astrophysical Observation", "SAO 154738"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.73927096),
        dec: Angle.Degrees(-19.28853493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15494"},
        {"Hipparcos Number", "HIP 11570"},
        {"Geneva Identification System", "GEN# +1.00015494"},
        {"Smithsonian Astrophysical Observation", "SAO 148413"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.27957048),
        dec: Angle.Degrees(-19.28844259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44224"},
        {"Smithsonian Astrophysical Observation", "SAO 154827"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.11635485),
        dec: Angle.Degrees(-19.28801132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195811"},
        {"Hipparcos Number", "HIP 101506"},
        {"Renson", "Renson 54577"},
        {"Smithsonian Astrophysical Observation", "SAO 163684"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.54265510),
        dec: Angle.Degrees(-19.28792292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154624"},
        {"Hipparcos Number", "HIP 83788"},
        {"Smithsonian Astrophysical Observation", "SAO 160289"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.86251776),
        dec: Angle.Degrees(-19.28710389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26412"},
        {"Hipparcos Number", "HIP 19446"},
        {"Smithsonian Astrophysical Observation", "SAO 149421"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.46871024),
        dec: Angle.Degrees(-19.28698797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151504"},
        {"Hipparcos Number", "HIP 82265"},
        {"Geneva Identification System", "GEN# +1.00151504"},
        {"Smithsonian Astrophysical Observation", "SAO 160106"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.13458893),
        dec: Angle.Degrees(-19.28692612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -347.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123308"},
        {"Hipparcos Number", "HIP 68968"},
        {"Geneva Identification System", "GEN# +1.00123308"},
        {"Smithsonian Astrophysical Observation", "SAO 158362"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.79016809),
        dec: Angle.Degrees(-19.28428081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172816"},
        {"Hipparcos Number", "HIP 91781"},
        {"Geneva Identification System", "GEN# +1.00172816"},
        {"Smithsonian Astrophysical Observation", "SAO 161754"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.72961269),
        dec: Angle.Degrees(-19.28412831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78217"},
        {"Hipparcos Number", "HIP 44694"},
        {"Smithsonian Astrophysical Observation", "SAO 154914"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.61681564),
        dec: Angle.Degrees(-19.28304631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57118"},
        {"Hipparcos Number", "HIP 35442"},
        {"Geneva Identification System", "GEN# +1.00057118"},
        {"Smithsonian Astrophysical Observation", "SAO 152710"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.75800519),
        dec: Angle.Degrees(-19.28031128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176124"},
        {"Hipparcos Number", "HIP 93224"},
        {"Geneva Identification System", "GEN# +1.00176124"},
        {"Smithsonian Astrophysical Observation", "SAO 162049"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.84925051),
        dec: Angle.Degrees(-19.27928904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196636"},
        {"Hipparcos Number", "HIP 101922"},
        {"Smithsonian Astrophysical Observation", "SAO 163770"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.81519918),
        dec: Angle.Degrees(-19.27846498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149595"},
        {"Hipparcos Number", "HIP 81321"},
        {"Smithsonian Astrophysical Observation", "SAO 159998"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.13509925),
        dec: Angle.Degrees(-19.27533880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8956"},
        {"Smithsonian Astrophysical Observation", "SAO 148107"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.83202844),
        dec: Angle.Degrees(-19.27528729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107241"},
        {"Hipparcos Number", "HIP 60135"},
        {"Smithsonian Astrophysical Observation", "SAO 157214"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.98224126),
        dec: Angle.Degrees(-19.27475720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11378"},
        {"Hipparcos Number", "HIP 8649"},
        {"Geneva Identification System", "GEN# +1.00011378"},
        {"Renson", "Renson 2840"},
        {"Smithsonian Astrophysical Observation", "SAO 148063"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.87010326),
        dec: Angle.Degrees(-19.27385988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55444"},
        {"Hipparcos Number", "HIP 34797"},
        {"Celescope Catalog", "CEL 1663"},
        {"Geneva Identification System", "GEN# +1.00055444"},
        {"Smithsonian Astrophysical Observation", "SAO 152551"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.05005697),
        dec: Angle.Degrees(-19.26969452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171394"},
        {"Hipparcos Number", "HIP 91135"},
        {"Geneva Identification System", "GEN# +1.00171394"},
        {"Smithsonian Astrophysical Observation", "SAO 161635"},
        {"Wilson Evans Batten Catalogue", "WEB 15647"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.84869803),
        dec: Angle.Degrees(-19.26850624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187907"},
        {"Hipparcos Number", "HIP 97858"},
        {"Smithsonian Astrophysical Observation", "SAO 163079"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29547430),
        dec: Angle.Degrees(-19.26495583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14325"},
        {"Hipparcos Number", "HIP 10760"},
        {"Smithsonian Astrophysical Observation", "SAO 148323"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.61259555),
        dec: Angle.Degrees(-19.26116701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198031"},
        {"Hipparcos Number", "HIP 102660"},
        {"Geneva Identification System", "GEN# +1.00198031"},
        {"Smithsonian Astrophysical Observation", "SAO 163887"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.05691566),
        dec: Angle.Degrees(-19.26023643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86593"},
        {"Smithsonian Astrophysical Observation", "SAO 160752"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44718369),
        dec: Angle.Degrees(-19.25906134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107199"},
        {"Hipparcos Number", "HIP 60106"},
        {"Geneva Identification System", "GEN# +1.00107199"},
        {"Smithsonian Astrophysical Observation", "SAO 157211"},
        {"Wilson Evans Batten Catalogue", "WEB 10686"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.90780560),
        dec: Angle.Degrees(-19.25605244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120025"},
        {"Hipparcos Number", "HIP 67270"},
        {"Fundamental Katalog 5th Edition", "FK5 3093"},
        {"Geneva Identification System", "GEN# +1.00120025"},
        {"Renson", "Renson 34600"},
        {"Smithsonian Astrophysical Observation", "SAO 158161"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80511081),
        dec: Angle.Degrees(-19.25575373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47205"},
        {"Hipparcos Number", "HIP 31592"},
        {"Fundamental Katalog 5th Edition", "FK5 2510"},
        {"Geneva Identification System", "GEN# +1.00047205"},
        {"Smithsonian Astrophysical Observation", "SAO 151702"},
        {"Wilson Evans Batten Catalogue", "WEB 6324"},
    },
    visualMagnitude: 3.95,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.17082883),
        dec: Angle.Degrees(-19.25570928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117801"},
        {"Hipparcos Number", "HIP 66103"},
        {"Smithsonian Astrophysical Observation", "SAO 157999"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.25995265),
        dec: Angle.Degrees(-19.25343057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30196"},
        {"Geneva Identification System", "GEN# -0.01901422"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.29423157),
        dec: Angle.Degrees(-19.25248310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99671"},
        {"Hipparcos Number", "HIP 55951"},
        {"Smithsonian Astrophysical Observation", "SAO 156696"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.99074897),
        dec: Angle.Degrees(-19.24941379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210972"},
        {"Hipparcos Number", "HIP 109794"},
        {"Geneva Identification System", "GEN# +1.00210972"},
        {"Smithsonian Astrophysical Observation", "SAO 164942"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58532116),
        dec: Angle.Degrees(-19.24881997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200233"},
        {"Hipparcos Number", "HIP 103865"},
        {"Smithsonian Astrophysical Observation", "SAO 164087"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.68817332),
        dec: Angle.Degrees(-19.24875816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25250"},
        {"Hipparcos Number", "HIP 18678"},
        {"Geneva Identification System", "GEN# +1.00025250"},
        {"Smithsonian Astrophysical Observation", "SAO 149305"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.00104388),
        dec: Angle.Degrees(-19.24669718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89278"},
    },
    visualMagnitude: 11.65,
    bvColour: 2.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.26834906),
        dec: Angle.Degrees(-19.24609734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11972 A"},
        {"Henry Draper", "HD 176884"},
        {"Hipparcos Number", "HIP 93537"},
        {"Geneva Identification System", "GEN# +1.00176884A"},
        {"Smithsonian Astrophysical Observation", "SAO 162130"},
        {"Wilson Evans Batten Catalogue", "WEB 16244"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.76584773),
        dec: Angle.Degrees(-19.24565829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123598"},
        {"Hipparcos Number", "HIP 69126"},
        {"Geneva Identification System", "GEN# +1.00123598"},
        {"Smithsonian Astrophysical Observation", "SAO 158383"},
        {"Wilson Evans Batten Catalogue", "WEB 12069"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.25137702),
        dec: Angle.Degrees(-19.24545660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67797"},
        {"Hipparcos Number", "HIP 39906"},
        {"Fundamental Katalog 5th Edition", "FK5 2632"},
        {"Geneva Identification System", "GEN# +1.00067797"},
        {"Smithsonian Astrophysical Observation", "SAO 153890"},
        {"Wilson Evans Batten Catalogue", "WEB 7777"},
    },
    visualMagnitude: 4.40,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.25684770),
        dec: Angle.Degrees(-19.24500094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205378"},
        {"Hipparcos Number", "HIP 106594"},
        {"Geneva Identification System", "GEN# +1.00205378"},
        {"Smithsonian Astrophysical Observation", "SAO 164498"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.82911129),
        dec: Angle.Degrees(-19.24469329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75314"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.80675573),
        dec: Angle.Degrees(-19.24346038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154623"},
        {"Hipparcos Number", "HIP 83782"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.84875868),
        dec: Angle.Degrees(-19.24002088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110031"},
        {"Hipparcos Number", "HIP 61761"},
        {"Smithsonian Astrophysical Observation", "SAO 157422"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.86909761),
        dec: Angle.Degrees(-19.23901650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106264",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15046 AB"},
        {"Henry Draper", "HD 204779"},
        {"Hipparcos Number", "HIP 106264"},
        {"Smithsonian Astrophysical Observation", "SAO 164449"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.85609407),
        dec: Angle.Degrees(-19.23750662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89272"},
        {"Smithsonian Astrophysical Observation", "SAO 161192"},
    },
    visualMagnitude: 9.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.25778372),
        dec: Angle.Degrees(-19.23719297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179266"},
        {"Hipparcos Number", "HIP 94394"},
        {"Smithsonian Astrophysical Observation", "SAO 162311"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18401956),
        dec: Angle.Degrees(-19.23524595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181558"},
        {"Hipparcos Number", "HIP 95159"},
        {"Geneva Identification System", "GEN# +1.00181558A"},
        {"Smithsonian Astrophysical Observation", "SAO 162511"},
        {"Wilson Evans Batten Catalogue", "WEB 16620"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.40463261),
        dec: Angle.Degrees(-19.23441785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47619"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.64986317),
        dec: Angle.Degrees(-19.23423153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -471.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27352"},
        {"Hipparcos Number", "HIP 20081"},
        {"Smithsonian Astrophysical Observation", "SAO 149525"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.57992081),
        dec: Angle.Degrees(-19.23371509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121551"},
        {"Hipparcos Number", "HIP 68095"},
        {"Smithsonian Astrophysical Observation", "SAO 158244"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11836034),
        dec: Angle.Degrees(-19.23258723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205705"},
        {"Hipparcos Number", "HIP 106768"},
        {"Geneva Identification System", "GEN# +1.00205705"},
        {"Smithsonian Astrophysical Observation", "SAO 164528"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.40694244),
        dec: Angle.Degrees(-19.23101624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164124"},
        {"Hipparcos Number", "HIP 88167"},
        {"Smithsonian Astrophysical Observation", "SAO 160980"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.10306013),
        dec: Angle.Degrees(-19.23100050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185426"},
        {"Hipparcos Number", "HIP 96726"},
        {"Geneva Identification System", "GEN# +1.00185426"},
        {"Smithsonian Astrophysical Observation", "SAO 162859"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.94584249),
        dec: Angle.Degrees(-19.23062294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57479"},
        {"Hipparcos Number", "HIP 35593"},
        {"Smithsonian Astrophysical Observation", "SAO 152747"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.17897941),
        dec: Angle.Degrees(-19.22795406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37792"},
        {"Hipparcos Number", "HIP 26688"},
        {"Geneva Identification System", "GEN# +1.00037792"},
        {"Smithsonian Astrophysical Observation", "SAO 150673"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07296536),
        dec: Angle.Degrees(-19.22668007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107879"},
        {"Hipparcos Number", "HIP 60474"},
        {"Smithsonian Astrophysical Observation", "SAO 157260"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.96968348),
        dec: Angle.Degrees(-19.22559544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 380"},
        {"Hipparcos Number", "HIP 678"},
        {"Smithsonian Astrophysical Observation", "SAO 147102"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.09641108),
        dec: Angle.Degrees(-19.22409603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29262"},
        {"Hipparcos Number", "HIP 21409"},
        {"Smithsonian Astrophysical Observation", "SAO 149752"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.93118159),
        dec: Angle.Degrees(-19.22344290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158040"},
        {"Hipparcos Number", "HIP 85446"},
        {"Smithsonian Astrophysical Observation", "SAO 160559"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.92760517),
        dec: Angle.Degrees(-19.22339400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40303"},
        {"Hipparcos Number", "HIP 28163"},
        {"Smithsonian Astrophysical Observation", "SAO 150968"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.27007506),
        dec: Angle.Degrees(-19.21960427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121303"},
        {"Hipparcos Number", "HIP 67958"},
        {"Geneva Identification System", "GEN# +1.00121303"},
        {"Smithsonian Astrophysical Observation", "SAO 158229"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.75725086),
        dec: Angle.Degrees(-19.21725234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75511"},
        {"Hipparcos Number", "HIP 43356"},
        {"Smithsonian Astrophysical Observation", "SAO 154670"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.47377105),
        dec: Angle.Degrees(-19.21568588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46037"},
        {"Hipparcos Number", "HIP 30988"},
        {"Smithsonian Astrophysical Observation", "SAO 151577"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.54922429),
        dec: Angle.Degrees(-19.21483605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187604"},
        {"Hipparcos Number", "HIP 97727"},
        {"Smithsonian Astrophysical Observation", "SAO 163046"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.89933932),
        dec: Angle.Degrees(-19.21121600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11497 A"},
        {"Henry Draper", "HD 171736"},
        {"Hipparcos Number", "HIP 91276"},
        {"Smithsonian Astrophysical Observation", "SAO 161665"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.27967145),
        dec: Angle.Degrees(-19.20938174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77084"},
        {"Hipparcos Number", "HIP 44162"},
        {"Geneva Identification System", "GEN# +1.00077084"},
        {"Smithsonian Astrophysical Observation", "SAO 154815"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.91641417),
        dec: Angle.Degrees(-19.20779957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192269"},
        {"Hipparcos Number", "HIP 99782"},
        {"Smithsonian Astrophysical Observation", "SAO 163373"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.67830854),
        dec: Angle.Degrees(-19.20713609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103086"},
        {"Hipparcos Number", "HIP 57875"},
        {"Geneva Identification System", "GEN# +1.00103086"},
        {"Smithsonian Astrophysical Observation", "SAO 156948"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.05098844),
        dec: Angle.Degrees(-19.20619164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218412"},
        {"Hipparcos Number", "HIP 114229"},
        {"Smithsonian Astrophysical Observation", "SAO 165505"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.01168393),
        dec: Angle.Degrees(-19.20559106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115106"},
        {"Hipparcos Number", "HIP 64656"},
        {"Smithsonian Astrophysical Observation", "SAO 157817"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.80579417),
        dec: Angle.Degrees(-19.20475327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91379"},
        {"Hipparcos Number", "HIP 51620"},
        {"Smithsonian Astrophysical Observation", "SAO 156049"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.18487874),
        dec: Angle.Degrees(-19.20158368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99534"},
        {"Hipparcos Number", "HIP 55867"},
        {"Smithsonian Astrophysical Observation", "SAO 156684"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.75989924),
        dec: Angle.Degrees(-19.20048741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52696"},
        {"Hipparcos Number", "HIP 33838"},
        {"Geneva Identification System", "GEN# +1.00052696"},
        {"Renson", "Renson 14460"},
        {"Smithsonian Astrophysical Observation", "SAO 152250"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.37206767),
        dec: Angle.Degrees(-19.20034933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107218"},
        {"Hipparcos Number", "HIP 60117"},
        {"Smithsonian Astrophysical Observation", "SAO 157212"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.92754938),
        dec: Angle.Degrees(-19.19892767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173854"},
        {"Hipparcos Number", "HIP 92266"},
        {"Geneva Identification System", "GEN# +1.00173854"},
        {"Smithsonian Astrophysical Observation", "SAO 161842"},
        {"Wilson Evans Batten Catalogue", "WEB 15918"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.05582225),
        dec: Angle.Degrees(-19.19888926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54959"},
        {"Hipparcos Number", "HIP 34621"},
        {"Geneva Identification System", "GEN# +1.00054959"},
        {"Smithsonian Astrophysical Observation", "SAO 152500"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.55168491),
        dec: Angle.Degrees(-19.19847009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111903",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16155 A"},
        {"Henry Draper", "HD 214657"},
        {"Hipparcos Number", "HIP 111903"},
        {"Smithsonian Astrophysical Observation", "SAO 165223"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.01121827),
        dec: Angle.Degrees(-19.19784555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102448"},
        {"Hipparcos Number", "HIP 57528"},
        {"Geneva Identification System", "GEN# +1.00102448"},
        {"Smithsonian Astrophysical Observation", "SAO 156890"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.86271421),
        dec: Angle.Degrees(-19.19609103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2670"},
        {"Hipparcos Number", "HIP 2368"},
        {"Geneva Identification System", "GEN# +1.00002670"},
        {"Smithsonian Astrophysical Observation", "SAO 147311"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.55436244),
        dec: Angle.Degrees(-19.19375934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10510"},
        {"Hipparcos Number", "HIP 7937"},
        {"Geneva Identification System", "GEN# +1.00010510"},
        {"Smithsonian Astrophysical Observation", "SAO 147966"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.50851484),
        dec: Angle.Degrees(-19.19244230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208507"},
        {"Hipparcos Number", "HIP 108352"},
        {"Fundamental Katalog 5th Edition", "FK5 5938"},
        {"Geneva Identification System", "GEN# +1.00208507"},
        {"Smithsonian Astrophysical Observation", "SAO 164759"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.26878333),
        dec: Angle.Degrees(-19.18990720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179024"},
        {"Hipparcos Number", "HIP 94309"},
        {"Smithsonian Astrophysical Observation", "SAO 162295"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.93896402),
        dec: Angle.Degrees(-19.18933069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118583"},
        {"Hipparcos Number", "HIP 66525"},
        {"Fundamental Katalog 5th Edition", "FK5 5204"},
        {"Renson", "Renson 34265"},
        {"Smithsonian Astrophysical Observation", "SAO 158055"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.54010387),
        dec: Angle.Degrees(-19.18871436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43861"},
        {"Hipparcos Number", "HIP 29900"},
        {"Geneva Identification System", "GEN# +1.00043861"},
        {"Smithsonian Astrophysical Observation", "SAO 151323"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.43429638),
        dec: Angle.Degrees(-19.18870791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212658"},
        {"Hipparcos Number", "HIP 110750"},
        {"Geneva Identification System", "GEN# +1.00212658"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.55576323),
        dec: Angle.Degrees(-19.18836610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63271"},
        {"Smithsonian Astrophysical Observation", "SAO 157624"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.48054121),
        dec: Angle.Degrees(-19.18818332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151925"},
        {"Hipparcos Number", "HIP 82465"},
        {"Smithsonian Astrophysical Observation", "SAO 160128"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.79274228),
        dec: Angle.Degrees(-19.18666577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19510"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.69498771),
        dec: Angle.Degrees(-19.18442129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4072"},
        {"Hipparcos Number", "HIP 3387"},
        {"Geneva Identification System", "GEN# +1.00004072"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.76208244),
        dec: Angle.Degrees(-19.18146936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29074"},
        {"Hipparcos Number", "HIP 21277"},
        {"Smithsonian Astrophysical Observation", "SAO 149733"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.47763978),
        dec: Angle.Degrees(-19.17807101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127074"},
        {"Hipparcos Number", "HIP 70889"},
        {"Smithsonian Astrophysical Observation", "SAO 158600"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.44665641),
        dec: Angle.Degrees(-19.17764000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68303"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.72756255),
        dec: Angle.Degrees(-19.17701349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216553"},
        {"Hipparcos Number", "HIP 113080"},
        {"Smithsonian Astrophysical Observation", "SAO 165365"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.52332689),
        dec: Angle.Degrees(-19.17513859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159190"},
        {"Hipparcos Number", "HIP 85965"},
        {"Smithsonian Astrophysical Observation", "SAO 160645"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.53819611),
        dec: Angle.Degrees(-19.17488688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63541"},
        {"Hipparcos Number", "HIP 38121"},
        {"Smithsonian Astrophysical Observation", "SAO 153434"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.18299107),
        dec: Angle.Degrees(-19.17485879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74096"},
        {"Hipparcos Number", "HIP 42638"},
        {"Smithsonian Astrophysical Observation", "SAO 154546"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.33306328),
        dec: Angle.Degrees(-19.17484893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 312502"},
        {"Hipparcos Number", "HIP 88341"},
        {"Wilson Evans Batten Catalogue", "WEB 14935"},
    },
    visualMagnitude: 11.11,
    bvColour: 3.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.61786085),
        dec: Angle.Degrees(-19.17360023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136102"},
        {"Hipparcos Number", "HIP 74992"},
        {"Smithsonian Astrophysical Observation", "SAO 159169"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.86146717),
        dec: Angle.Degrees(-19.16916593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153419"},
        {"Hipparcos Number", "HIP 83209"},
        {"Smithsonian Astrophysical Observation", "SAO 160222"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.07853110),
        dec: Angle.Degrees(-19.16842568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9043 AB"},
        {"Henry Draper", "HD 121137"},
        {"Hipparcos Number", "HIP 67859"},
        {"Smithsonian Astrophysical Observation", "SAO 158221"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48517097),
        dec: Angle.Degrees(-19.16809536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6796"},
        {"Hipparcos Number", "HIP 5354"},
        {"Smithsonian Astrophysical Observation", "SAO 147631"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.10695428),
        dec: Angle.Degrees(-19.16696170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166291"},
        {"Hipparcos Number", "HIP 89061"},
        {"Geneva Identification System", "GEN# +1.00166291"},
        {"Smithsonian Astrophysical Observation", "SAO 161140"},
        {"Wilson Evans Batten Catalogue", "WEB 15119"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65937345),
        dec: Angle.Degrees(-19.16689243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69561"},
        {"Hipparcos Number", "HIP 40551"},
        {"Smithsonian Astrophysical Observation", "SAO 154066"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.21550617),
        dec: Angle.Degrees(-19.16636759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7357"},
        {"Hipparcos Number", "HIP 5713"},
        {"Geneva Identification System", "GEN# +1.00007357"},
        {"Smithsonian Astrophysical Observation", "SAO 147676"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.37230041),
        dec: Angle.Degrees(-19.16627103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42042"},
        {"Hipparcos Number", "HIP 29048"},
        {"Geneva Identification System", "GEN# +1.00042042"},
        {"Smithsonian Astrophysical Observation", "SAO 151142"},
        {"Wilson Evans Batten Catalogue", "WEB 5688"},
    },
    visualMagnitude: 5.28,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.92345906),
        dec: Angle.Degrees(-19.16600403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215720"},
        {"Hipparcos Number", "HIP 112530"},
        {"Geneva Identification System", "GEN# +1.00215720"},
        {"Smithsonian Astrophysical Observation", "SAO 165292"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88877018),
        dec: Angle.Degrees(-19.16283618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67522"},
        {"Hipparcos Number", "HIP 39782"},
        {"Smithsonian Astrophysical Observation", "SAO 153868"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.94702217),
        dec: Angle.Degrees(-19.16221103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40090"},
        {"Hipparcos Number", "HIP 28050"},
        {"Smithsonian Astrophysical Observation", "SAO 150948"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.97697416),
        dec: Angle.Degrees(-19.16031853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90801",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11433 G"},
        {"Henry Draper", "HD 170682"},
        {"Hipparcos Number", "HIP 90801"},
        {"Geneva Identification System", "GEN# +3.47250050"},
        {"Smithsonian Astrophysical Observation", "SAO 161562"},
        {"Wilson Evans Batten Catalogue", "WEB 15561"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85088311),
        dec: Angle.Degrees(-19.15860340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74894"},
        {"Hipparcos Number", "HIP 43049"},
        {"Geneva Identification System", "GEN# +1.00074894"},
        {"Smithsonian Astrophysical Observation", "SAO 154621"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.56282227),
        dec: Angle.Degrees(-19.15603285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81712"},
        {"Hipparcos Number", "HIP 46336"},
        {"Geneva Identification System", "GEN# +1.00081712"},
        {"Smithsonian Astrophysical Observation", "SAO 155193"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.70382552),
        dec: Angle.Degrees(-19.15513426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14462"},
        {"Hipparcos Number", "HIP 10853"},
        {"Smithsonian Astrophysical Observation", "SAO 148333"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.91867419),
        dec: Angle.Degrees(-19.15437593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106370"},
        {"Hipparcos Number", "HIP 59677"},
        {"Smithsonian Astrophysical Observation", "SAO 157160"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.56924268),
        dec: Angle.Degrees(-19.15430424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175754"},
        {"Hipparcos Number", "HIP 93077"},
        {"Geneva Identification System", "GEN# +1.00175754"},
        {"Smithsonian Astrophysical Observation", "SAO 162021"},
        {"Wilson Evans Batten Catalogue", "WEB 16122"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.39878248),
        dec: Angle.Degrees(-19.15313250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88595"},
        {"Hipparcos Number", "HIP 50013"},
        {"Geneva Identification System", "GEN# +9.00050001"},
        {"Smithsonian Astrophysical Observation", "SAO 155820"},
        {"Wilson Evans Batten Catalogue", "WEB 9194"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.15873787),
        dec: Angle.Degrees(-19.15280764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194473"},
        {"Hipparcos Number", "HIP 100805"},
        {"Geneva Identification System", "GEN# +1.00194473"},
        {"Smithsonian Astrophysical Observation", "SAO 163568"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.59146139),
        dec: Angle.Degrees(-19.15209821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82144"},
        {"Hipparcos Number", "HIP 46559"},
        {"Smithsonian Astrophysical Observation", "SAO 155236"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.42264143),
        dec: Angle.Degrees(-19.15043893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204577"},
        {"Hipparcos Number", "HIP 106143"},
        {"Fundamental Katalog 5th Edition", "FK5 5896"},
        {"Geneva Identification System", "GEN# +1.00204577"},
        {"Smithsonian Astrophysical Observation", "SAO 164433"},
        {"Wilson Evans Batten Catalogue", "WEB 19236"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.49814503),
        dec: Angle.Degrees(-19.14772017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131336"},
        {"Hipparcos Number", "HIP 72865"},
        {"Geneva Identification System", "GEN# +1.00131336"},
        {"Smithsonian Astrophysical Observation", "SAO 158879"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.40195714),
        dec: Angle.Degrees(-19.14738821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221601"},
        {"Hipparcos Number", "HIP 116271"},
        {"Smithsonian Astrophysical Observation", "SAO 165765"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.37857561),
        dec: Angle.Degrees(-19.14545804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123949"},
        {"Hipparcos Number", "HIP 69290"},
        {"Geneva Identification System", "GEN# +1.00123949"},
        {"Smithsonian Astrophysical Observation", "SAO 158404"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.74713395),
        dec: Angle.Degrees(-19.14398051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36169"},
        {"Hipparcos Number", "HIP 25679"},
        {"Smithsonian Astrophysical Observation", "SAO 150492"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.26363575),
        dec: Angle.Degrees(-19.14276456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174115"},
        {"Hipparcos Number", "HIP 92384"},
        {"Geneva Identification System", "GEN# +1.00174115"},
        {"Renson", "Renson 48770"},
        {"Smithsonian Astrophysical Observation", "SAO 161871"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.39732814),
        dec: Angle.Degrees(-19.14233741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93036"},
        {"Hipparcos Number", "HIP 52524"},
        {"Smithsonian Astrophysical Observation", "SAO 156191"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.08844752),
        dec: Angle.Degrees(-19.14189049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65351"},
        {"Hipparcos Number", "HIP 38897"},
        {"Smithsonian Astrophysical Observation", "SAO 153636"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.40979964),
        dec: Angle.Degrees(-19.14111776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171690"},
        {"Hipparcos Number", "HIP 91267"},
        {"Smithsonian Astrophysical Observation", "SAO 161662"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.24324069),
        dec: Angle.Degrees(-19.13984052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13004"},
        {"Hipparcos Number", "HIP 9862"},
        {"Smithsonian Astrophysical Observation", "SAO 148210"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.71650468),
        dec: Angle.Degrees(-19.13878097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18288"},
        {"Hipparcos Number", "HIP 13639"},
        {"Geneva Identification System", "GEN# +1.00018288"},
        {"Smithsonian Astrophysical Observation", "SAO 148670"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.90799876),
        dec: Angle.Degrees(-19.13819306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14034"},
        {"Hipparcos Number", "HIP 10555"},
        {"Smithsonian Astrophysical Observation", "SAO 148300"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.97798471),
        dec: Angle.Degrees(-19.13727730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151011"},
        {"Hipparcos Number", "HIP 82038"},
        {"Smithsonian Astrophysical Observation", "SAO 160080"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.37573793),
        dec: Angle.Degrees(-19.13692789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70942"},
        {"Hipparcos Number", "HIP 41174"},
        {"Smithsonian Astrophysical Observation", "SAO 154213"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.03517064),
        dec: Angle.Degrees(-19.13568331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23492"},
        {"Hipparcos Number", "HIP 17517"},
        {"Smithsonian Astrophysical Observation", "SAO 149145"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.25812697),
        dec: Angle.Degrees(-19.13481704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66034"},
        {"Hipparcos Number", "HIP 39199"},
        {"Smithsonian Astrophysical Observation", "SAO 153720"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.27526964),
        dec: Angle.Degrees(-19.13364591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148116"},
        {"Hipparcos Number", "HIP 80544"},
        {"Smithsonian Astrophysical Observation", "SAO 159915"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.66908939),
        dec: Angle.Degrees(-19.13217587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19368"},
        {"Smithsonian Astrophysical Observation", "SAO 149405"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.23098201),
        dec: Angle.Degrees(-19.13192067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224065"},
        {"Hipparcos Number", "HIP 117905"},
        {"Geneva Identification System", "GEN# +1.00224065"},
        {"Smithsonian Astrophysical Observation", "SAO 165950"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.72690825),
        dec: Angle.Degrees(-19.13051931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20006"},
        {"Smithsonian Astrophysical Observation", "SAO 149515"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.34072122),
        dec: Angle.Degrees(-19.12828577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90836",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11433 A"},
        {"Henry Draper", "HD 170764"},
        {"Hipparcos Number", "HIP 90836"},
        {"Geneva Identification System", "GEN# +3.47250103"},
        {"Smithsonian Astrophysical Observation", "SAO 161571"},
        {"Wilson Evans Batten Catalogue", "WEB 15572"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.97222239),
        dec: Angle.Degrees(-19.12505743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170820"},
        {"Hipparcos Number", "HIP 90870"},
        {"Geneva Identification System", "GEN# +3.47250150"},
        {"Smithsonian Astrophysical Observation", "SAO 161576"},
        {"Wilson Evans Batten Catalogue", "WEB 15580"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.05462769),
        dec: Angle.Degrees(-19.12395849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140780"},
        {"Hipparcos Number", "HIP 77232"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.54522299),
        dec: Angle.Degrees(-19.11954386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174755"},
        {"Hipparcos Number", "HIP 92663"},
        {"Smithsonian Astrophysical Observation", "SAO 161930"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.23827228),
        dec: Angle.Degrees(-19.11922103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13675 A"},
        {"Henry Draper", "HD 193150"},
        {"Hipparcos Number", "HIP 100195"},
        {"Fundamental Katalog 5th Edition", "FK5 3625"},
        {"Geneva Identification System", "GEN# +1.00193150A"},
        {"Smithsonian Astrophysical Observation", "SAO 163445"},
        {"Wilson Evans Batten Catalogue", "WEB 18050"},
    },
    visualMagnitude: 5.28,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.84833016),
        dec: Angle.Degrees(-19.11850680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59189"},
        {"Hipparcos Number", "HIP 36275"},
        {"Smithsonian Astrophysical Observation", "SAO 152918"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.02210750),
        dec: Angle.Degrees(-19.11816192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54814"},
        {"Hipparcos Number", "HIP 34566"},
        {"Celescope Catalog", "CEL 1625"},
        {"Geneva Identification System", "GEN# +1.00054814"},
        {"Smithsonian Astrophysical Observation", "SAO 152480"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.39640338),
        dec: Angle.Degrees(-19.11554040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158526"},
        {"Hipparcos Number", "HIP 85690"},
        {"Smithsonian Astrophysical Observation", "SAO 160597"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.66998947),
        dec: Angle.Degrees(-19.11500839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198824"},
        {"Hipparcos Number", "HIP 103114"},
        {"Smithsonian Astrophysical Observation", "SAO 163954"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.38405503),
        dec: Angle.Degrees(-19.11373188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52621"},
        {"Geneva Identification System", "GEN# -0.01803019"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.41769813),
        dec: Angle.Degrees(-19.11290026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1804.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -594.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186109"},
        {"Hipparcos Number", "HIP 97031"},
        {"Smithsonian Astrophysical Observation", "SAO 162925"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.80108669),
        dec: Angle.Degrees(-19.11210311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23356"},
        {"Hipparcos Number", "HIP 17420"},
        {"Smithsonian Astrophysical Observation", "SAO 149134"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.97979823),
        dec: Angle.Degrees(-19.11127994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 309.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220424"},
        {"Hipparcos Number", "HIP 115494"},
        {"Smithsonian Astrophysical Observation", "SAO 165668"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.93561136),
        dec: Angle.Degrees(-19.10960444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140652"},
        {"Hipparcos Number", "HIP 77165"},
        {"Smithsonian Astrophysical Observation", "SAO 159480"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.34936147),
        dec: Angle.Degrees(-19.10722708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62241"},
        {"Hipparcos Number", "HIP 37546"},
        {"Geneva Identification System", "GEN# +1.00062241"},
        {"Smithsonian Astrophysical Observation", "SAO 153280"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.58699084),
        dec: Angle.Degrees(-19.10642868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134758"},
        {"Hipparcos Number", "HIP 74391"},
        {"Smithsonian Astrophysical Observation", "SAO 159089"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.05015284),
        dec: Angle.Degrees(-19.10642417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164438"},
        {"Hipparcos Number", "HIP 88297"},
        {"Geneva Identification System", "GEN# +1.00164438"},
        {"Smithsonian Astrophysical Observation", "SAO 161004"},
        {"Wilson Evans Batten Catalogue", "WEB 14925"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.46783583),
        dec: Angle.Degrees(-19.10613785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172595"},
        {"Hipparcos Number", "HIP 91698"},
        {"Smithsonian Astrophysical Observation", "SAO 161735"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.49095310),
        dec: Angle.Degrees(-19.10506664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143955"},
        {"Hipparcos Number", "HIP 78704"},
        {"Smithsonian Astrophysical Observation", "SAO 159663"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.00310504),
        dec: Angle.Degrees(-19.10423683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176903"},
        {"Hipparcos Number", "HIP 93543"},
        {"Geneva Identification System", "GEN# +1.00176903"},
        {"Smithsonian Astrophysical Observation", "SAO 162133"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.77912298),
        dec: Angle.Degrees(-19.10301593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189698"},
        {"Hipparcos Number", "HIP 98634"},
        {"Geneva Identification System", "GEN# +1.00189698"},
        {"Smithsonian Astrophysical Observation", "SAO 163193"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.50495195),
        dec: Angle.Degrees(-19.09914847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44704"},
        {"Hipparcos Number", "HIP 30295"},
        {"Smithsonian Astrophysical Observation", "SAO 151424"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.58543109),
        dec: Angle.Degrees(-19.09756041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47942"},
        {"Hipparcos Number", "HIP 31919"},
        {"Smithsonian Astrophysical Observation", "SAO 151775"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.06316803),
        dec: Angle.Degrees(-19.09646541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35915"},
        {"Hipparcos Number", "HIP 25501"},
        {"Geneva Identification System", "GEN# +1.00035915"},
        {"Smithsonian Astrophysical Observation", "SAO 150466"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.79856255),
        dec: Angle.Degrees(-19.09571619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90242"},
        {"Hipparcos Number", "HIP 50966"},
        {"Geneva Identification System", "GEN# +1.00090242"},
        {"Smithsonian Astrophysical Observation", "SAO 155964"},
        {"Wilson Evans Batten Catalogue", "WEB 9324"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.15323644),
        dec: Angle.Degrees(-19.09246222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15203"},
        {"Hipparcos Number", "HIP 11378"},
        {"Smithsonian Astrophysical Observation", "SAO 148391"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62839600),
        dec: Angle.Degrees(-19.09106563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195076"},
        {"Hipparcos Number", "HIP 101111"},
        {"Geneva Identification System", "GEN# +1.00195076"},
        {"Smithsonian Astrophysical Observation", "SAO 163623"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.43285708),
        dec: Angle.Degrees(-19.09077532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201013"},
        {"Hipparcos Number", "HIP 104276"},
        {"Geneva Identification System", "GEN# +1.00201013"},
        {"Smithsonian Astrophysical Observation", "SAO 164152"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.87450641),
        dec: Angle.Degrees(-19.08810347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196101"},
        {"Hipparcos Number", "HIP 101621"},
        {"Smithsonian Astrophysical Observation", "SAO 163715"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.92926607),
        dec: Angle.Degrees(-19.08580653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173407"},
        {"Hipparcos Number", "HIP 92071"},
        {"Smithsonian Astrophysical Observation", "SAO 161802"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.48347553),
        dec: Angle.Degrees(-19.08222147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8350"},
        {"Hipparcos Number", "HIP 6427"},
        {"Geneva Identification System", "GEN# +1.00008350J"},
        {"Smithsonian Astrophysical Observation", "SAO 147767"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.62715374),
        dec: Angle.Degrees(-19.08104977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19251"},
        {"Hipparcos Number", "HIP 14357"},
        {"Smithsonian Astrophysical Observation", "SAO 148756"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.30361308),
        dec: Angle.Degrees(-19.08088429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2346"},
        {"Hipparcos Number", "HIP 2158"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.81122765),
        dec: Angle.Degrees(-19.07826250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113330"},
        {"Hipparcos Number", "HIP 63683"},
        {"Fundamental Katalog 5th Edition", "FK5 5153"},
        {"Geneva Identification System", "GEN# +1.00113330"},
        {"Smithsonian Astrophysical Observation", "SAO 157680"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.76070760),
        dec: Angle.Degrees(-19.07748205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167660"},
        {"Hipparcos Number", "HIP 89596"},
        {"Geneva Identification System", "GEN# +1.00167660"},
        {"Smithsonian Astrophysical Observation", "SAO 161257"},
        {"Wilson Evans Batten Catalogue", "WEB 15258"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.24881465),
        dec: Angle.Degrees(-19.07582959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209585"},
        {"Hipparcos Number", "HIP 108999"},
        {"Geneva Identification System", "GEN# +1.00209585"},
        {"Smithsonian Astrophysical Observation", "SAO 164847"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.21794917),
        dec: Angle.Degrees(-19.07555254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193585"},
        {"Hipparcos Number", "HIP 100393"},
        {"Smithsonian Astrophysical Observation", "SAO 163493"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38615938),
        dec: Angle.Degrees(-19.07536471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222295"},
        {"Hipparcos Number", "HIP 116739"},
        {"Smithsonian Astrophysical Observation", "SAO 165815"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.87381405),
        dec: Angle.Degrees(-19.07522250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223272"},
        {"Hipparcos Number", "HIP 117399"},
        {"Smithsonian Astrophysical Observation", "SAO 165891"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.06276028),
        dec: Angle.Degrees(-19.07137547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4035"},
        {"Hipparcos Number", "HIP 3358"},
        {"Geneva Identification System", "GEN# +1.00004035"},
        {"Smithsonian Astrophysical Observation", "SAO 147413"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.68487240),
        dec: Angle.Degrees(-19.06983187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165405"},
        {"Hipparcos Number", "HIP 88704"},
        {"Smithsonian Astrophysical Observation", "SAO 161071"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.62963143),
        dec: Angle.Degrees(-19.06759064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22163"},
        {"Hipparcos Number", "HIP 16590"},
        {"Smithsonian Astrophysical Observation", "SAO 149039"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.39568947),
        dec: Angle.Degrees(-19.06649071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16594"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.40658726),
        dec: Angle.Degrees(-19.06609540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34274"},
        {"Hipparcos Number", "HIP 24506"},
        {"Geneva Identification System", "GEN# +1.00034274"},
        {"Smithsonian Astrophysical Observation", "SAO 150277"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.85158524),
        dec: Angle.Degrees(-19.06042191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204125"},
        {"Hipparcos Number", "HIP 105914"},
        {"Smithsonian Astrophysical Observation", "SAO 164395"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.76300372),
        dec: Angle.Degrees(-19.05808495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138738"},
        {"Hipparcos Number", "HIP 76247"},
        {"Smithsonian Astrophysical Observation", "SAO 159356"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.62605036),
        dec: Angle.Degrees(-19.05419022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39500"},
        {"Hipparcos Number", "HIP 27721"},
        {"Smithsonian Astrophysical Observation", "SAO 150890"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.05287448),
        dec: Angle.Degrees(-19.05383093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48872"},
        {"Hipparcos Number", "HIP 32310"},
        {"Celescope Catalog", "CEL 1366"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.18478068),
        dec: Angle.Degrees(-19.05298112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213791"},
        {"Hipparcos Number", "HIP 111420"},
        {"Geneva Identification System", "GEN# +1.00213791"},
        {"Smithsonian Astrophysical Observation", "SAO 165165"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.60273824),
        dec: Angle.Degrees(-19.05277617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82433"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.70145617),
        dec: Angle.Degrees(-19.05141393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1343"},
        {"Hipparcos Number", "HIP 1402"},
        {"Geneva Identification System", "GEN# +1.00001343"},
        {"Smithsonian Astrophysical Observation", "SAO 147205"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.38621007),
        dec: Angle.Degrees(-19.05108585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89708"},
        {"Hipparcos Number", "HIP 50661"},
        {"Geneva Identification System", "GEN# +1.00089708"},
        {"Smithsonian Astrophysical Observation", "SAO 155918"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.19247290),
        dec: Angle.Degrees(-19.05047383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117611",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17044 A"},
        {"Henry Draper", "HD 223621"},
        {"Hipparcos Number", "HIP 117611"},
        {"Geneva Identification System", "GEN# +1.00223621"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.78888702),
        dec: Angle.Degrees(-19.04951676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108539"},
        {"Hipparcos Number", "HIP 60844"},
        {"Smithsonian Astrophysical Observation", "SAO 157308"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.06822010),
        dec: Angle.Degrees(-19.04763679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64894"},
        {"Hipparcos Number", "HIP 38707"},
        {"Smithsonian Astrophysical Observation", "SAO 153591"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.87161042),
        dec: Angle.Degrees(-19.04739028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117610",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17044 B"},
        {"Hipparcos Number", "HIP 117610"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.78802833),
        dec: Angle.Degrees(-19.04673096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93072"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.38579150),
        dec: Angle.Degrees(-19.04663555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18866"},
        {"Smithsonian Astrophysical Observation", "SAO 149332"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.67220885),
        dec: Angle.Degrees(-19.04606817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187739"},
        {"Hipparcos Number", "HIP 97783"},
        {"Geneva Identification System", "GEN# +1.00187739"},
        {"Smithsonian Astrophysical Observation", "SAO 163060"},
        {"Wilson Evans Batten Catalogue", "WEB 17200"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.05002110),
        dec: Angle.Degrees(-19.04486185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17002"},
        {"Hipparcos Number", "HIP 12700"},
        {"Smithsonian Astrophysical Observation", "SAO 148568"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.78825306),
        dec: Angle.Degrees(-19.04370762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2640"},
        {"Hipparcos Number", "HIP 2344"},
        {"Geneva Identification System", "GEN# +1.00002640"},
        {"Smithsonian Astrophysical Observation", "SAO 147308"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.48254818),
        dec: Angle.Degrees(-19.04251364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73007"},
        {"Hipparcos Number", "HIP 42132"},
        {"Smithsonian Astrophysical Observation", "SAO 154429"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.82973506),
        dec: Angle.Degrees(-19.04113763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216357"},
        {"Hipparcos Number", "HIP 112958"},
        {"Fundamental Katalog 5th Edition", "FK5 6020"},
        {"Geneva Identification System", "GEN# +1.00216357"},
        {"Smithsonian Astrophysical Observation", "SAO 165351"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14878346),
        dec: Angle.Degrees(-19.03788497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114020"},
        {"Hipparcos Number", "HIP 64071"},
        {"Smithsonian Astrophysical Observation", "SAO 157737"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.96656197),
        dec: Angle.Degrees(-19.03568748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199728"},
        {"Hipparcos Number", "HIP 103616"},
        {"Geneva Identification System", "GEN# +1.00199728"},
        {"Renson", "Renson 55630"},
        {"Smithsonian Astrophysical Observation", "SAO 164043"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.90055233),
        dec: Angle.Degrees(-19.03523289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33178"},
        {"Hipparcos Number", "HIP 23848"},
        {"Smithsonian Astrophysical Observation", "SAO 150163"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90331854),
        dec: Angle.Degrees(-19.03498918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115063"},
        {"Hipparcos Number", "HIP 64642"},
        {"Smithsonian Astrophysical Observation", "SAO 157814"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.74043590),
        dec: Angle.Degrees(-19.03475857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199184"},
        {"Hipparcos Number", "HIP 103332"},
        {"Smithsonian Astrophysical Observation", "SAO 163994"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.02111715),
        dec: Angle.Degrees(-19.03300315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50644"},
        {"Hipparcos Number", "HIP 33077"},
        {"Geneva Identification System", "GEN# +1.00050644"},
        {"Smithsonian Astrophysical Observation", "SAO 152055"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.32851233),
        dec: Angle.Degrees(-19.03277877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9337"},
        {"Hipparcos Number", "HIP 7116"},
        {"Geneva Identification System", "GEN# +1.00009337"},
        {"Smithsonian Astrophysical Observation", "SAO 147862"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.91302906),
        dec: Angle.Degrees(-19.03214210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209169"},
        {"Hipparcos Number", "HIP 108739"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.41377318),
        dec: Angle.Degrees(-19.02775728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7793"},
        {"Hipparcos Number", "HIP 6019"},
        {"Smithsonian Astrophysical Observation", "SAO 147718"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33465592),
        dec: Angle.Degrees(-19.02738338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17597"},
        {"Hipparcos Number", "HIP 13130"},
        {"Geneva Identification System", "GEN# +1.00017597J"},
        {"Smithsonian Astrophysical Observation", "SAO 148620"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.22396395),
        dec: Angle.Degrees(-19.02736770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30731"},
        {"Smithsonian Astrophysical Observation", "SAO 151524"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.84414009),
        dec: Angle.Degrees(-19.02705005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9336"},
        {"Hipparcos Number", "HIP 7108"},
        {"Geneva Identification System", "GEN# +1.00009336"},
        {"Renson", "Renson 2255"},
        {"Smithsonian Astrophysical Observation", "SAO 147861"},
        {"Wilson Evans Batten Catalogue", "WEB 1536"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.89154036),
        dec: Angle.Degrees(-19.02289579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19168"},
        {"Smithsonian Astrophysical Observation", "SAO 149376"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64649445),
        dec: Angle.Degrees(-19.02096282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198140"},
        {"Hipparcos Number", "HIP 102726"},
        {"Wilson Evans Batten Catalogue", "WEB 18623"},
    },
    visualMagnitude: 10.64,
    bvColour: 3.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.23682595),
        dec: Angle.Degrees(-19.01916525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163351"},
        {"Hipparcos Number", "HIP 87832"},
        {"Geneva Identification System", "GEN# +2.64940008"},
        {"New General Catalogue", "NGC 6494 8"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.14550639),
        dec: Angle.Degrees(-19.01827366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87881"},
        {"Geneva Identification System", "GEN# +2.64940012"},
        {"New General Catalogue", "NGC 6494 12"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.28129998),
        dec: Angle.Degrees(-19.01774695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124087"},
        {"Hipparcos Number", "HIP 69356"},
        {"Smithsonian Astrophysical Observation", "SAO 158414"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.94106204),
        dec: Angle.Degrees(-19.01756264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57821"},
        {"Hipparcos Number", "HIP 35727"},
        {"Celescope Catalog", "CEL 1805"},
        {"Fundamental Katalog 5th Edition", "FK5 2570"},
        {"Geneva Identification System", "GEN# +1.00057821"},
        {"Smithsonian Astrophysical Observation", "SAO 152776"},
        {"Wilson Evans Batten Catalogue", "WEB 7119"},
    },
    visualMagnitude: 4.94,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.55637515),
        dec: Angle.Degrees(-19.01658444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50153"},
        {"Hipparcos Number", "HIP 32886"},
        {"Smithsonian Astrophysical Observation", "SAO 152014"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.78450358),
        dec: Angle.Degrees(-19.01355546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11172"},
        {"Hipparcos Number", "HIP 8493"},
        {"Smithsonian Astrophysical Observation", "SAO 148035"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.37241558),
        dec: Angle.Degrees(-19.01340255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58439"},
        {"Hipparcos Number", "HIP 35975"},
        {"Geneva Identification System", "GEN# +1.00058439J"},
        {"Smithsonian Astrophysical Observation", "SAO 152837"},
        {"Wilson Evans Batten Catalogue", "WEB 7162"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.21201745),
        dec: Angle.Degrees(-19.01228875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156718"},
        {"Hipparcos Number", "HIP 84808"},
        {"Smithsonian Astrophysical Observation", "SAO 160465"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00401321),
        dec: Angle.Degrees(-19.01037191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10708"},
        {"Hipparcos Number", "HIP 8114"},
        {"Smithsonian Astrophysical Observation", "SAO 147987"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.06867949),
        dec: Angle.Degrees(-19.00928395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48615",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Felis"},
        {"Henry Draper", "HD 85951"},
        {"Hipparcos Number", "HIP 48615"},
        {"Fundamental Katalog 5th Edition", "FK5 373"},
        {"Geneva Identification System", "GEN# +1.00085951"},
        {"Smithsonian Astrophysical Observation", "SAO 155588"},
        {"Wilson Evans Batten Catalogue", "WEB 9050"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.71765461),
        dec: Angle.Degrees(-19.00926985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83439"},
        {"Hipparcos Number", "HIP 47265"},
        {"Smithsonian Astrophysical Observation", "SAO 155354"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.50171965),
        dec: Angle.Degrees(-19.00918320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102333"},
        {"Hipparcos Number", "HIP 57452"},
        {"Renson", "Renson 29500"},
        {"Smithsonian Astrophysical Observation", "SAO 156879"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.66287905),
        dec: Angle.Degrees(-19.00704887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63733"},
        {"Hipparcos Number", "HIP 38217"},
        {"Geneva Identification System", "GEN# +1.00063733"},
        {"Smithsonian Astrophysical Observation", "SAO 153459"},
        {"Wilson Evans Batten Catalogue", "WEB 7531"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.44061769),
        dec: Angle.Degrees(-19.00688209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111156"},
        {"Hipparcos Number", "HIP 62408"},
        {"Geneva Identification System", "GEN# +1.00111156"},
        {"Smithsonian Astrophysical Observation", "SAO 157509"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.83771602),
        dec: Angle.Degrees(-19.00442963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41436"},
        {"Hipparcos Number", "HIP 28760"},
        {"Smithsonian Astrophysical Observation", "SAO 151079"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08736347),
        dec: Angle.Degrees(-19.00328168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26411"},
        {"Hipparcos Number", "HIP 19452"},
        {"Smithsonian Astrophysical Observation", "SAO 149422"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.49494791),
        dec: Angle.Degrees(-19.00280186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109694"},
        {"Hipparcos Number", "HIP 61551"},
        {"Smithsonian Astrophysical Observation", "SAO 157396"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.18205144),
        dec: Angle.Degrees(-19.00230888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4496",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 799"},
        {"Henry Draper", "HD 5617"},
        {"Hipparcos Number", "HIP 4496"},
        {"Geneva Identification System", "GEN# +1.00005617J"},
        {"Smithsonian Astrophysical Observation", "SAO 147537"},
        {"Wilson Evans Batten Catalogue", "WEB 813"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.40729852),
        dec: Angle.Degrees(-18.99863300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44893"},
        {"Hipparcos Number", "HIP 30397"},
        {"Smithsonian Astrophysical Observation", "SAO 151443"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.87742523),
        dec: Angle.Degrees(-18.99862618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22837"},
        {"Hipparcos Number", "HIP 17071"},
        {"Geneva Identification System", "GEN# +1.00022837"},
        {"Smithsonian Astrophysical Observation", "SAO 149084"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.87800449),
        dec: Angle.Degrees(-18.99836895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42387"},
        {"Hipparcos Number", "HIP 29203"},
        {"Smithsonian Astrophysical Observation", "SAO 151180"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39218016),
        dec: Angle.Degrees(-18.99796019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198902"},
        {"Hipparcos Number", "HIP 103166"},
        {"Geneva Identification System", "GEN# +1.00198902"},
        {"Smithsonian Astrophysical Observation", "SAO 163965"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.52387267),
        dec: Angle.Degrees(-18.99675194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144925"},
        {"Hipparcos Number", "HIP 79124"},
        {"Geneva Identification System", "GEN# +1.00144925"},
        {"Smithsonian Astrophysical Observation", "SAO 159731"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.26085523),
        dec: Angle.Degrees(-18.99550900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125624"},
        {"Hipparcos Number", "HIP 70134"},
        {"Smithsonian Astrophysical Observation", "SAO 158504"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.26726727),
        dec: Angle.Degrees(-18.99219018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159743"},
        {"Hipparcos Number", "HIP 86208"},
        {"Geneva Identification System", "GEN# +1.00159743"},
        {"Smithsonian Astrophysical Observation", "SAO 160691"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.25704710),
        dec: Angle.Degrees(-18.99192292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87388"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.86438551),
        dec: Angle.Degrees(-18.99145225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -292.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222422"},
        {"Hipparcos Number", "HIP 116819"},
        {"Cincinnati Publication", "Ci 18 3104"},
        {"Geneva Identification System", "GEN# +1.00222422"},
        {"Smithsonian Astrophysical Observation", "SAO 165825"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.15694122),
        dec: Angle.Degrees(-18.98879303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220066"},
        {"Hipparcos Number", "HIP 115286"},
        {"Geneva Identification System", "GEN# +1.00220066"},
        {"Smithsonian Astrophysical Observation", "SAO 165639"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.23644512),
        dec: Angle.Degrees(-18.98858923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16660"},
        {"Hipparcos Number", "HIP 12402"},
        {"Smithsonian Astrophysical Observation", "SAO 148531"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.91906978),
        dec: Angle.Degrees(-18.98753501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29594"},
        {"Hipparcos Number", "HIP 21641"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72223295),
        dec: Angle.Degrees(-18.98672477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53785"},
        {"Smithsonian Astrophysical Observation", "SAO 156385"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.06857224),
        dec: Angle.Degrees(-18.98634216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180414"},
        {"Hipparcos Number", "HIP 94783"},
        {"Smithsonian Astrophysical Observation", "SAO 162405"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.29107596),
        dec: Angle.Degrees(-18.98603358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119152"},
        {"Hipparcos Number", "HIP 66837"},
        {"Geneva Identification System", "GEN# +1.00119152"},
        {"Smithsonian Astrophysical Observation", "SAO 158096"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.47005087),
        dec: Angle.Degrees(-18.98482257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165421"},
        {"Hipparcos Number", "HIP 88718"},
        {"Fundamental Katalog 5th Edition", "FK5 5596"},
        {"Smithsonian Astrophysical Observation", "SAO 161077"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.67825479),
        dec: Angle.Degrees(-18.98410712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55904"},
        {"Hipparcos Number", "HIP 34973"},
        {"Geneva Identification System", "GEN# +1.00055904"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54257180),
        dec: Angle.Degrees(-18.98387261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66784"},
        {"Hipparcos Number", "HIP 39511"},
        {"Smithsonian Astrophysical Observation", "SAO 153791"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.13087127),
        dec: Angle.Degrees(-18.98369897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26846"},
        {"Smithsonian Astrophysical Observation", "SAO 150712"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.50227400),
        dec: Angle.Degrees(-18.98312525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83482"},
        {"Hipparcos Number", "HIP 47294"},
        {"Renson", "Renson 23804"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.57172580),
        dec: Angle.Degrees(-18.98265237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103907"},
        {"Hipparcos Number", "HIP 58343"},
        {"Smithsonian Astrophysical Observation", "SAO 157015"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.46974511),
        dec: Angle.Degrees(-18.98205055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129958"},
        {"Hipparcos Number", "HIP 72202"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51335518),
        dec: Angle.Degrees(-18.97924815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113668"},
        {"Hipparcos Number", "HIP 63879"},
        {"Geneva Identification System", "GEN# +1.00113668"},
        {"Smithsonian Astrophysical Observation", "SAO 157706"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36958896),
        dec: Angle.Degrees(-18.97920595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99091"},
        {"Hipparcos Number", "HIP 55655"},
        {"Smithsonian Astrophysical Observation", "SAO 156654"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.04116718),
        dec: Angle.Degrees(-18.97822199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13523"},
        {"Hipparcos Number", "HIP 10232"},
        {"Geneva Identification System", "GEN# +1.00013523"},
        {"Smithsonian Astrophysical Observation", "SAO 148265"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.88466322),
        dec: Angle.Degrees(-18.97671679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9463"},
        {"Hipparcos Number", "HIP 7188"},
        {"Smithsonian Astrophysical Observation", "SAO 147875"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.15111174),
        dec: Angle.Degrees(-18.97668657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68292"},
        {"Hipparcos Number", "HIP 40066"},
        {"Geneva Identification System", "GEN# +1.00068292"},
        {"Renson", "Renson 18860"},
        {"Smithsonian Astrophysical Observation", "SAO 153936"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.76402071),
        dec: Angle.Degrees(-18.97407724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217056"},
        {"Hipparcos Number", "HIP 113406"},
        {"Smithsonian Astrophysical Observation", "SAO 165407"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.51345607),
        dec: Angle.Degrees(-18.97286173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170886"},
        {"Hipparcos Number", "HIP 90900"},
        {"Geneva Identification System", "GEN# +3.47250251"},
        {"Smithsonian Astrophysical Observation", "SAO 161582"},
        {"Wilson Evans Batten Catalogue", "WEB 15587"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.12153690),
        dec: Angle.Degrees(-18.97263963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100906"},
        {"Hipparcos Number", "HIP 56635"},
        {"Geneva Identification System", "GEN# +1.00100906"},
        {"Smithsonian Astrophysical Observation", "SAO 156785"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.17675174),
        dec: Angle.Degrees(-18.96962759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19622"},
        {"Hipparcos Number", "HIP 14627"},
        {"Smithsonian Astrophysical Observation", "SAO 148791"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.22573876),
        dec: Angle.Degrees(-18.96924010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143437"},
        {"Hipparcos Number", "HIP 78454"},
        {"Smithsonian Astrophysical Observation", "SAO 159631"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.24657872),
        dec: Angle.Degrees(-18.96339482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89671"},
        {"Hipparcos Number", "HIP 50629"},
        {"Geneva Identification System", "GEN# +1.00089671"},
        {"Smithsonian Astrophysical Observation", "SAO 155912"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12058763),
        dec: Angle.Degrees(-18.96193222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40046"},
        {"Hipparcos Number", "HIP 28018"},
        {"Smithsonian Astrophysical Observation", "SAO 150940"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.89656618),
        dec: Angle.Degrees(-18.96028675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88419"},
        {"Hipparcos Number", "HIP 49902"},
        {"Smithsonian Astrophysical Observation", "SAO 155800"},
        {"Wilson Evans Batten Catalogue", "WEB 9186"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.82940580),
        dec: Angle.Degrees(-18.95696167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69724"},
        {"Hipparcos Number", "HIP 40623"},
        {"Smithsonian Astrophysical Observation", "SAO 154078"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.39556801),
        dec: Angle.Degrees(-18.95618463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180540"},
        {"Hipparcos Number", "HIP 94820"},
        {"Fundamental Katalog 5th Edition", "FK5 722"},
        {"Geneva Identification System", "GEN# +1.00180540"},
        {"Smithsonian Astrophysical Observation", "SAO 162413"},
        {"Wilson Evans Batten Catalogue", "WEB 16547"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.40868994),
        dec: Angle.Degrees(-18.95288215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178291"},
        {"Hipparcos Number", "HIP 94040"},
        {"Smithsonian Astrophysical Observation", "SAO 162234"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.18419092),
        dec: Angle.Degrees(-18.95279119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203797"},
        {"Hipparcos Number", "HIP 105735"},
        {"Geneva Identification System", "GEN# +1.00203797"},
        {"Smithsonian Astrophysical Observation", "SAO 164373"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.23679087),
        dec: Angle.Degrees(-18.95214480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142215"},
        {"Hipparcos Number", "HIP 77861"},
        {"Smithsonian Astrophysical Observation", "SAO 159564"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.48439239),
        dec: Angle.Degrees(-18.95090823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70792"},
        {"Hipparcos Number", "HIP 41109"},
        {"Smithsonian Astrophysical Observation", "SAO 154189"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.82618146),
        dec: Angle.Degrees(-18.94998147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113800"},
        {"Hipparcos Number", "HIP 63959"},
        {"Geneva Identification System", "GEN# +1.00113800"},
        {"Smithsonian Astrophysical Observation", "SAO 157722"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.60917416),
        dec: Angle.Degrees(-18.94948094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163450"},
        {"Hipparcos Number", "HIP 87873"},
        {"Geneva Identification System", "GEN# +2.64940009"},
        {"New General Catalogue", "NGC 6494 9"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.25604501),
        dec: Angle.Degrees(-18.94945633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7816"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.14207083),
        dec: Angle.Degrees(-18.94761970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3493"},
        {"Geneva Identification System", "GEN# -0.01900111B"},
        {"Geneva Identification System 2", "GEN# -0.01900111A"},
        {"Wilson Evans Batten Catalogue", "WEB 618"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.15409524),
        dec: Angle.Degrees(-18.94716716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 270.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 183.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80617"},
        {"Hipparcos Number", "HIP 45798"},
        {"Smithsonian Astrophysical Observation", "SAO 155102"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.07236561),
        dec: Angle.Degrees(-18.94659100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80829"},
        {"Hipparcos Number", "HIP 45898"},
        {"Smithsonian Astrophysical Observation", "SAO 155122"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.36503511),
        dec: Angle.Degrees(-18.94454200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217640"},
        {"Hipparcos Number", "HIP 113762"},
        {"Renson", "Renson 60025"},
        {"Smithsonian Astrophysical Observation", "SAO 165452"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.57539928),
        dec: Angle.Degrees(-18.94434112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111798"},
        {"Hipparcos Number", "HIP 62780"},
        {"Smithsonian Astrophysical Observation", "SAO 157556"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.97668778),
        dec: Angle.Degrees(-18.94392810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54146"},
        {"Hipparcos Number", "HIP 34332"},
        {"Smithsonian Astrophysical Observation", "SAO 152406"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.75072361),
        dec: Angle.Degrees(-18.94338696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130622"},
        {"Hipparcos Number", "HIP 72525"},
        {"Smithsonian Astrophysical Observation", "SAO 158824"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.42333213),
        dec: Angle.Degrees(-18.94210157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196187"},
        {"Hipparcos Number", "HIP 101651"},
        {"Geneva Identification System", "GEN# +1.00196187"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.08487435),
        dec: Angle.Degrees(-18.94092957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141812"},
        {"Hipparcos Number", "HIP 77688"},
        {"Smithsonian Astrophysical Observation", "SAO 159540"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.90868378),
        dec: Angle.Degrees(-18.93936510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150469"},
        {"Hipparcos Number", "HIP 81758"},
        {"Geneva Identification System", "GEN# +1.00150469"},
        {"Smithsonian Astrophysical Observation", "SAO 160054"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.49011751),
        dec: Angle.Degrees(-18.93777419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90985"},
        {"Hipparcos Number", "HIP 51400"},
        {"Smithsonian Astrophysical Observation", "SAO 156018"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.47480535),
        dec: Angle.Degrees(-18.93678609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11195"},
        {"Hipparcos Number", "HIP 8507"},
        {"Smithsonian Astrophysical Observation", "SAO 148041"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.42875198),
        dec: Angle.Degrees(-18.93609776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88991"},
        {"Hipparcos Number", "HIP 50246"},
        {"Geneva Identification System", "GEN# +1.00088991"},
        {"Smithsonian Astrophysical Observation", "SAO 155851"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.89090664),
        dec: Angle.Degrees(-18.93454214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50643"},
        {"Hipparcos Number", "HIP 33079"},
        {"Geneva Identification System", "GEN# +1.00050643"},
        {"Renson", "Renson 13920"},
        {"Smithsonian Astrophysical Observation", "SAO 152056"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.34102903),
        dec: Angle.Degrees(-18.93292926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1038"},
        {"Hipparcos Number", "HIP 1170"},
        {"Geneva Identification System", "GEN# +1.00001038"},
        {"Smithsonian Astrophysical Observation", "SAO 147169"},
        {"Wilson Evans Batten Catalogue", "WEB 208"},
    },
    visualMagnitude: 4.44,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66013628),
        dec: Angle.Degrees(-18.93268628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161681"},
        {"Hipparcos Number", "HIP 87096"},
        {"Smithsonian Astrophysical Observation", "SAO 160823"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93587708),
        dec: Angle.Degrees(-18.93064223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59813"},
        {"Hipparcos Number", "HIP 36540"},
        {"Geneva Identification System", "GEN# +1.00059813"},
        {"Smithsonian Astrophysical Observation", "SAO 152991"},
        {"Wilson Evans Batten Catalogue", "WEB 7269"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.74516355),
        dec: Angle.Degrees(-18.93001009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131811"},
        {"Hipparcos Number", "HIP 73096"},
        {"Geneva Identification System", "GEN# +1.00131811"},
        {"Smithsonian Astrophysical Observation", "SAO 158906"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.08071578),
        dec: Angle.Degrees(-18.92820800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182250"},
        {"Hipparcos Number", "HIP 95407"},
        {"Geneva Identification System", "GEN# +1.00182250"},
        {"Smithsonian Astrophysical Observation", "SAO 162571"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.12307277),
        dec: Angle.Degrees(-18.92800428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101155"},
        {"Hipparcos Number", "HIP 56764"},
        {"Smithsonian Astrophysical Observation", "SAO 156797"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.56581998),
        dec: Angle.Degrees(-18.92622050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155094"},
        {"Hipparcos Number", "HIP 84005"},
        {"Geneva Identification System", "GEN# +1.00155094"},
        {"Smithsonian Astrophysical Observation", "SAO 160328"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.57901798),
        dec: Angle.Degrees(-18.92615400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58152"},
        {"Hipparcos Number", "HIP 35858"},
        {"Smithsonian Astrophysical Observation", "SAO 152812"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.89306319),
        dec: Angle.Degrees(-18.92567596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8837 AB"},
        {"Henry Draper", "HD 115105"},
        {"Hipparcos Number", "HIP 64660"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.80987978),
        dec: Angle.Degrees(-18.91989170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130875"},
        {"Hipparcos Number", "HIP 72645"},
        {"Geneva Identification System", "GEN# +1.00130875"},
        {"Smithsonian Astrophysical Observation", "SAO 158843"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.79251863),
        dec: Angle.Degrees(-18.91877447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98577"},
        {"Hipparcos Number", "HIP 55381"},
        {"Geneva Identification System", "GEN# +1.00098577"},
        {"Smithsonian Astrophysical Observation", "SAO 156617"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.10729417),
        dec: Angle.Degrees(-18.91864618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200035"},
        {"Hipparcos Number", "HIP 103751"},
        {"Geneva Identification System", "GEN# +1.00200035"},
        {"Smithsonian Astrophysical Observation", "SAO 164065"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.36012951),
        dec: Angle.Degrees(-18.91745723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102235"},
        {"Cincinnati Publication", "Ci 20 1223"},
        {"Wilson Evans Batten Catalogue", "WEB 18499"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.73658394),
        dec: Angle.Degrees(-18.91626852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 605.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -858.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199636"},
        {"Hipparcos Number", "HIP 103566"},
        {"Geneva Identification System", "GEN# +1.00199636"},
        {"Smithsonian Astrophysical Observation", "SAO 164032"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.75987866),
        dec: Angle.Degrees(-18.91602162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13117"},
        {"Hipparcos Number", "HIP 9942"},
        {"Geneva Identification System", "GEN# +1.00013117"},
        {"Smithsonian Astrophysical Observation", "SAO 148227"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.99565000),
        dec: Angle.Degrees(-18.91297549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2817 A"},
        {"Henry Draper", "HD 24280"},
        {"Hipparcos Number", "HIP 18029"},
        {"Smithsonian Astrophysical Observation", "SAO 149211"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.80036758),
        dec: Angle.Degrees(-18.91060699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4505"},
        {"Hipparcos Number", "HIP 3671"},
        {"Smithsonian Astrophysical Observation", "SAO 147447"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.74343667),
        dec: Angle.Degrees(-18.91051376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18031",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2817 BC"},
        {"Hipparcos Number", "HIP 18031"},
    },
    visualMagnitude: 8.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.80386950),
        dec: Angle.Degrees(-18.90952463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223640"},
        {"Hipparcos Number", "HIP 117629"},
        {"Celescope Catalog", "CEL 5694"},
        {"Geneva Identification System", "GEN# +1.00223640"},
        {"Renson", "Renson 61290"},
        {"Smithsonian Astrophysical Observation", "SAO 165918"},
        {"Wilson Evans Batten Catalogue", "WEB 20705"},
    },
    visualMagnitude: 5.17,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.83884091),
        dec: Angle.Degrees(-18.90915459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88759",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)07, 11.8200),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)54, 32.800)
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
    primaryId: "HIP 90790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170657"},
        {"Hipparcos Number", "HIP 90790"},
        {"Geneva Identification System", "GEN# +3.47250026"},
        {"Smithsonian Astrophysical Observation", "SAO 161557"},
        {"Wilson Evans Batten Catalogue", "WEB 15556"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.82935904),
        dec: Angle.Degrees(-18.90833868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11066 BC"},
        {"Henry Draper", "HD 165528"},
        {"Henry Draper 2", "HD 312644"},
        {"Hipparcos Number", "HIP 88762"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.80396084),
        dec: Angle.Degrees(-18.90526923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62981"},
        {"Hipparcos Number", "HIP 37892"},
        {"Smithsonian Astrophysical Observation", "SAO 153374"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.48835159),
        dec: Angle.Degrees(-18.90452480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184644"},
        {"Hipparcos Number", "HIP 96422"},
        {"Smithsonian Astrophysical Observation", "SAO 162806"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.05079913),
        dec: Angle.Degrees(-18.90362288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65142"},
        {"Hipparcos Number", "HIP 38818"},
        {"Renson", "Renson 17860"},
        {"Smithsonian Astrophysical Observation", "SAO 153619"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.17180415),
        dec: Angle.Degrees(-18.90126807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30902"},
        {"Hipparcos Number", "HIP 22519"},
        {"Smithsonian Astrophysical Observation", "SAO 149930"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.68488169),
        dec: Angle.Degrees(-18.89998189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12507"},
        {"Hipparcos Number", "HIP 9506"},
        {"Smithsonian Astrophysical Observation", "SAO 148164"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.57737314),
        dec: Angle.Degrees(-18.89820118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30181"},
        {"Hipparcos Number", "HIP 22047"},
        {"Geneva Identification System", "GEN# +1.00030181"},
        {"Smithsonian Astrophysical Observation", "SAO 149860"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.13464823),
        dec: Angle.Degrees(-18.89639437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87176",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10805 AB"},
        {"Hipparcos Number", "HIP 87176"},
        {"Smithsonian Astrophysical Observation", "SAO 160831"},
    },
    visualMagnitude: 10.13,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.16096094),
        dec: Angle.Degrees(-18.89619748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206146"},
        {"Hipparcos Number", "HIP 107032"},
        {"Smithsonian Astrophysical Observation", "SAO 164567"},
        {"Wilson Evans Batten Catalogue", "WEB 19336"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.14487874),
        dec: Angle.Degrees(-18.89563431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17349"},
        {"Hipparcos Number", "HIP 12944"},
        {"Geneva Identification System", "GEN# +1.00017349"},
        {"Smithsonian Astrophysical Observation", "SAO 148593"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.61911078),
        dec: Angle.Degrees(-18.89546341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1921"},
        {"Hipparcos Number", "HIP 1854"},
        {"Geneva Identification System", "GEN# +1.00001921"},
        {"Smithsonian Astrophysical Observation", "SAO 147245"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.85414897),
        dec: Angle.Degrees(-18.89154631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94238"},
        {"Hipparcos Number", "HIP 53147"},
        {"Smithsonian Astrophysical Observation", "SAO 156286"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.09383439),
        dec: Angle.Degrees(-18.89091832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21370"},
        {"Hipparcos Number", "HIP 16018"},
        {"Smithsonian Astrophysical Observation", "SAO 148957"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.56317582),
        dec: Angle.Degrees(-18.88991970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7112 AB"},
        {"Henry Draper", "HD 76784"},
        {"Hipparcos Number", "HIP 44017"},
        {"Smithsonian Astrophysical Observation", "SAO 154794"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.46318021),
        dec: Angle.Degrees(-18.88897711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29593"},
        {"Hipparcos Number", "HIP 21646"},
        {"Smithsonian Astrophysical Observation", "SAO 149792"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.72749047),
        dec: Angle.Degrees(-18.88723623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214191"},
        {"Hipparcos Number", "HIP 111640"},
        {"Smithsonian Astrophysical Observation", "SAO 165193"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.23902926),
        dec: Angle.Degrees(-18.88699637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153727"},
        {"Hipparcos Number", "HIP 83331"},
        {"Geneva Identification System", "GEN# +1.00153727"},
        {"Smithsonian Astrophysical Observation", "SAO 160231"},
        {"Wilson Evans Batten Catalogue", "WEB 14086"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46363788),
        dec: Angle.Degrees(-18.88549646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87331"},
        {"Hipparcos Number", "HIP 49310"},
        {"Smithsonian Astrophysical Observation", "SAO 155697"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.98189269),
        dec: Angle.Degrees(-18.88464044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223302"},
        {"Hipparcos Number", "HIP 117414"},
        {"Smithsonian Astrophysical Observation", "SAO 165893"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.12760159),
        dec: Angle.Degrees(-18.88462167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152603"},
        {"Hipparcos Number", "HIP 82787"},
        {"Geneva Identification System", "GEN# +1.00152603"},
        {"Smithsonian Astrophysical Observation", "SAO 160160"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.77658664),
        dec: Angle.Degrees(-18.88411313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19639"},
        {"Hipparcos Number", "HIP 14635"},
        {"Smithsonian Astrophysical Observation", "SAO 148792"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.27936426),
        dec: Angle.Degrees(-18.87971763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219242"},
        {"Hipparcos Number", "HIP 114735"},
        {"Smithsonian Astrophysical Observation", "SAO 165576"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.63077189),
        dec: Angle.Degrees(-18.87641464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162741"},
        {"Hipparcos Number", "HIP 87568"},
        {"Smithsonian Astrophysical Observation", "SAO 160887"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.34126726),
        dec: Angle.Degrees(-18.87598663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59408"},
        {"Hipparcos Number", "HIP 36364"},
        {"Smithsonian Astrophysical Observation", "SAO 152936"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.27411339),
        dec: Angle.Degrees(-18.87521956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79431",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sharjah"},
        {"Hipparcos Number", "HIP 79431"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.17399821),
        dec: Angle.Degrees(-18.87499082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188449"},
        {"Hipparcos Number", "HIP 98078"},
        {"Geneva Identification System", "GEN# +1.00188449"},
        {"Smithsonian Astrophysical Observation", "SAO 163112"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98659844),
        dec: Angle.Degrees(-18.87494517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105065"},
        {"Hipparcos Number", "HIP 59000"},
        {"Geneva Identification System", "GEN# +1.00105065"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.46112175),
        dec: Angle.Degrees(-18.87447681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93365"},
        {"Hipparcos Number", "HIP 52704"},
        {"Smithsonian Astrophysical Observation", "SAO 156216"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.63647412),
        dec: Angle.Degrees(-18.87392086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219578"},
        {"Hipparcos Number", "HIP 114951"},
        {"Smithsonian Astrophysical Observation", "SAO 165602"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.24415369),
        dec: Angle.Degrees(-18.87317472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100347"},
        {"Hipparcos Number", "HIP 56310"},
        {"Smithsonian Astrophysical Observation", "SAO 156743"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.16387853),
        dec: Angle.Degrees(-18.87093422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110617"},
        {"Hipparcos Number", "HIP 62089"},
        {"Smithsonian Astrophysical Observation", "SAO 157469"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88202203),
        dec: Angle.Degrees(-18.86971581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20423"},
        {"Smithsonian Astrophysical Observation", "SAO 149590"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.62189739),
        dec: Angle.Degrees(-18.86872113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3621"},
        {"Hipparcos Number", "HIP 3060"},
        {"Geneva Identification System", "GEN# +1.00003621"},
        {"Smithsonian Astrophysical Observation", "SAO 147381"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.70959102),
        dec: Angle.Degrees(-18.86802671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206453"},
        {"Hipparcos Number", "HIP 107188"},
        {"Geneva Identification System", "GEN# +1.00206453"},
        {"Smithsonian Astrophysical Observation", "SAO 164593"},
        {"Wilson Evans Batten Catalogue", "WEB 19360"},
    },
    visualMagnitude: 4.72,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66423845),
        dec: Angle.Degrees(-18.86630105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4418"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.15319545),
        dec: Angle.Degrees(-18.86485874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92919"},
        {"Hipparcos Number", "HIP 52463"},
        {"Geneva Identification System", "GEN# +1.00092919"},
        {"Smithsonian Astrophysical Observation", "SAO 156181"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.87103381),
        dec: Angle.Degrees(-18.86422639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88216"},
        {"Hipparcos Number", "HIP 49805"},
        {"Smithsonian Astrophysical Observation", "SAO 155779"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.49328394),
        dec: Angle.Degrees(-18.86403956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180699"},
        {"Hipparcos Number", "HIP 94859"},
        {"Smithsonian Astrophysical Observation", "SAO 162432"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.54559291),
        dec: Angle.Degrees(-18.86376811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179604"},
        {"Hipparcos Number", "HIP 94489"},
        {"Smithsonian Astrophysical Observation", "SAO 162339"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.47750419),
        dec: Angle.Degrees(-18.86165674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168608"},
        {"Hipparcos Number", "HIP 89968"},
        {"Geneva Identification System", "GEN# +1.00168608"},
        {"Smithsonian Astrophysical Observation", "SAO 161376"},
        {"Wilson Evans Batten Catalogue", "WEB 15367"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.34578527),
        dec: Angle.Degrees(-18.85998365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157587"},
        {"Hipparcos Number", "HIP 85224"},
        {"Geneva Identification System", "GEN# +1.00157587"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.21767578),
        dec: Angle.Degrees(-18.85914321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96873"},
        {"Hipparcos Number", "HIP 54511"},
        {"Smithsonian Astrophysical Observation", "SAO 156496"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.29343557),
        dec: Angle.Degrees(-18.85585039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184705"},
        {"Hipparcos Number", "HIP 96440"},
        {"Geneva Identification System", "GEN# +1.00184705"},
        {"Smithsonian Astrophysical Observation", "SAO 162809"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.10859040),
        dec: Angle.Degrees(-18.85289016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22608"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.95973640),
        dec: Angle.Degrees(-18.85118298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60875"},
        {"Hipparcos Number", "HIP 36966"},
        {"Geneva Identification System", "GEN# +1.00060875"},
        {"Smithsonian Astrophysical Observation", "SAO 153117"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98734744),
        dec: Angle.Degrees(-18.84641604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100847",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13853 AB"},
        {"Henry Draper", "HD 194549"},
        {"Hipparcos Number", "HIP 100847"},
        {"Smithsonian Astrophysical Observation", "SAO 163578"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.70620790),
        dec: Angle.Degrees(-18.84641208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136778"},
        {"Hipparcos Number", "HIP 75291"},
        {"Smithsonian Astrophysical Observation", "SAO 159211"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.74969999),
        dec: Angle.Degrees(-18.84466560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166052"},
        {"Hipparcos Number", "HIP 88982"},
        {"Geneva Identification System", "GEN# +1.00166052"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.43518053),
        dec: Angle.Degrees(-18.84437708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20728"},
        {"Hipparcos Number", "HIP 15504"},
        {"Geneva Identification System", "GEN# +1.00020728"},
        {"Smithsonian Astrophysical Observation", "SAO 148904"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.94373267),
        dec: Angle.Degrees(-18.84428415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219758"},
        {"Hipparcos Number", "HIP 115078"},
        {"Smithsonian Astrophysical Observation", "SAO 165617"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.62351551),
        dec: Angle.Degrees(-18.84159409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6000"},
        {"Hipparcos Number", "HIP 4756"},
        {"Smithsonian Astrophysical Observation", "SAO 147568"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.27882634),
        dec: Angle.Degrees(-18.83980686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25057"},
        {"Smithsonian Astrophysical Observation", "SAO 150380"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.47851159),
        dec: Angle.Degrees(-18.83904354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6547"},
        {"Hipparcos Number", "HIP 5174"},
        {"Geneva Identification System", "GEN# +1.00006547"},
        {"Smithsonian Astrophysical Observation", "SAO 147609"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.54467569),
        dec: Angle.Degrees(-18.83860273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71417"},
        {"Hipparcos Number", "HIP 41399"},
        {"Smithsonian Astrophysical Observation", "SAO 154262"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.68291848),
        dec: Angle.Degrees(-18.83675503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138188"},
        {"Hipparcos Number", "HIP 75985"},
        {"Smithsonian Astrophysical Observation", "SAO 159309"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.76235056),
        dec: Angle.Degrees(-18.83650813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145917"},
        {"Hipparcos Number", "HIP 79580"},
        {"Smithsonian Astrophysical Observation", "SAO 159797"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.55529274),
        dec: Angle.Degrees(-18.83649999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215167"},
        {"Hipparcos Number", "HIP 112211"},
        {"Geneva Identification System", "GEN# +1.00215167"},
        {"Smithsonian Astrophysical Observation", "SAO 165252"},
        {"Wilson Evans Batten Catalogue", "WEB 20025"},
    },
    visualMagnitude: 4.68,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.89688564),
        dec: Angle.Degrees(-18.83030716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89483"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.91261085),
        dec: Angle.Degrees(-18.82937703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37528"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.53795047),
        dec: Angle.Degrees(-18.82905934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 276.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146952"},
        {"Hipparcos Number", "HIP 79984"},
        {"Smithsonian Astrophysical Observation", "SAO 159849"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.89637363),
        dec: Angle.Degrees(-18.82803324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8824 AB"},
        {"Hipparcos Number", "HIP 64520"},
        {"Geneva Identification System", "GEN# +1.00114846"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.36186926),
        dec: Angle.Degrees(-18.82638090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113720"},
        {"Hipparcos Number", "HIP 63905"},
        {"Geneva Identification System", "GEN# +1.00113720"},
        {"Smithsonian Astrophysical Observation", "SAO 157714"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44284552),
        dec: Angle.Degrees(-18.82582508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149934"},
        {"Hipparcos Number", "HIP 81486"},
        {"Smithsonian Astrophysical Observation", "SAO 160018"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.64479268),
        dec: Angle.Degrees(-18.82566791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207189"},
        {"Hipparcos Number", "HIP 107603"},
        {"Smithsonian Astrophysical Observation", "SAO 164655"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92094753),
        dec: Angle.Degrees(-18.82496513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22710"},
        {"Smithsonian Astrophysical Observation", "SAO 149963"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.25316306),
        dec: Angle.Degrees(-18.82445234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156779"},
        {"Hipparcos Number", "HIP 84829"},
        {"Geneva Identification System", "GEN# +1.00156779"},
        {"Smithsonian Astrophysical Observation", "SAO 160469"},
        {"Wilson Evans Batten Catalogue", "WEB 14321"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.06559021),
        dec: Angle.Degrees(-18.82357566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127561"},
        {"Hipparcos Number", "HIP 71114"},
        {"Smithsonian Astrophysical Observation", "SAO 158629"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.13564141),
        dec: Angle.Degrees(-18.82266834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225"},
        {"Hipparcos Number", "HIP 580"},
        {"Geneva Identification System", "GEN# +1.00000225"},
        {"Smithsonian Astrophysical Observation", "SAO 147088"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.76070652),
        dec: Angle.Degrees(-18.82075644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126535"},
        {"Hipparcos Number", "HIP 70608"},
        {"Smithsonian Astrophysical Observation", "SAO 158565"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.64507558),
        dec: Angle.Degrees(-18.82005961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215367"},
        {"Hipparcos Number", "HIP 112307"},
        {"Smithsonian Astrophysical Observation", "SAO 165264"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.22204316),
        dec: Angle.Degrees(-18.81817548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76354"},
        {"Hipparcos Number", "HIP 43777"},
        {"Geneva Identification System", "GEN# +1.00076354"},
        {"Smithsonian Astrophysical Observation", "SAO 154740"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74559211),
        dec: Angle.Degrees(-18.81222252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46790"},
        {"Hipparcos Number", "HIP 31355"},
        {"Smithsonian Astrophysical Observation", "SAO 151655"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.62953284),
        dec: Angle.Degrees(-18.81215815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36923"},
        {"Hipparcos Number", "HIP 26122"},
        {"Smithsonian Astrophysical Observation", "SAO 150578"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.56590977),
        dec: Angle.Degrees(-18.81199893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197803"},
        {"Hipparcos Number", "HIP 102509"},
        {"Smithsonian Astrophysical Observation", "SAO 163866"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.61644767),
        dec: Angle.Degrees(-18.80874351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8349"},
        {"Hipparcos Number", "HIP 6425"},
        {"Smithsonian Astrophysical Observation", "SAO 147766"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.61535286),
        dec: Angle.Degrees(-18.80705893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7093"},
        {"Hipparcos Number", "HIP 5539"},
        {"Smithsonian Astrophysical Observation", "SAO 147654"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.75694356),
        dec: Angle.Degrees(-18.80488171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190979"},
        {"Hipparcos Number", "HIP 99193"},
        {"Smithsonian Astrophysical Observation", "SAO 163285"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.05415903),
        dec: Angle.Degrees(-18.80382675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132778"},
        {"Hipparcos Number", "HIP 73514"},
        {"Smithsonian Astrophysical Observation", "SAO 158974"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.37899696),
        dec: Angle.Degrees(-18.80325153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163245"},
        {"Hipparcos Number", "HIP 87782"},
        {"Fundamental Katalog 5th Edition", "FK5 3423"},
        {"Geneva Identification System", "GEN# +2.64940001"},
        {"Smithsonian Astrophysical Observation", "SAO 160909"},
        {"Wilson Evans Batten Catalogue", "WEB 14814"},
        {"New General Catalogue", "NGC 6494 1"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.97900684),
        dec: Angle.Degrees(-18.80210517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10187"},
        {"Hipparcos Number", "HIP 7712"},
        {"Smithsonian Astrophysical Observation", "SAO 147933"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.81954200),
        dec: Angle.Degrees(-18.80055492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110139"},
        {"Hipparcos Number", "HIP 61825"},
        {"Smithsonian Astrophysical Observation", "SAO 157434"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.06258264),
        dec: Angle.Degrees(-18.80024469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36902"},
        {"Geneva Identification System", "GEN# -0.01801920"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.80810736),
        dec: Angle.Degrees(-18.79921736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97781"},
        {"Hipparcos Number", "HIP 54933"},
        {"Geneva Identification System", "GEN# +1.00097781"},
        {"Smithsonian Astrophysical Observation", "SAO 156558"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.73640765),
        dec: Angle.Degrees(-18.79861886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89659",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11232 A"},
        {"Henry Draper", "HD 167863"},
        {"Hipparcos Number", "HIP 89659"},
        {"Geneva Identification System", "GEN# +1.00167863"},
        {"Smithsonian Astrophysical Observation", "SAO 161278"},
        {"Wilson Evans Batten Catalogue", "WEB 15272"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46305484),
        dec: Angle.Degrees(-18.79849827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129049"},
        {"Hipparcos Number", "HIP 71776"},
        {"Smithsonian Astrophysical Observation", "SAO 158726"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.23980071),
        dec: Angle.Degrees(-18.79813735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72265"},
        {"Hipparcos Number", "HIP 41794"},
        {"Smithsonian Astrophysical Observation", "SAO 154353"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.82083195),
        dec: Angle.Degrees(-18.79696351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56747"},
        {"Hipparcos Number", "HIP 35303"},
        {"Geneva Identification System", "GEN# +1.00056747"},
        {"Smithsonian Astrophysical Observation", "SAO 152672"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.38729091),
        dec: Angle.Degrees(-18.79459798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49298"},
        {"Hipparcos Number", "HIP 32498"},
        {"Smithsonian Astrophysical Observation", "SAO 151922"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.73087495),
        dec: Angle.Degrees(-18.79458995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199014"},
        {"Hipparcos Number", "HIP 103224"},
        {"Geneva Identification System", "GEN# +1.00199014"},
        {"Smithsonian Astrophysical Observation", "SAO 163973"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.69540469),
        dec: Angle.Degrees(-18.79282912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103024"},
        {"Hipparcos Number", "HIP 57834"},
        {"Smithsonian Astrophysical Observation", "SAO 156942"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.90321043),
        dec: Angle.Degrees(-18.79200267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196892"},
        {"Hipparcos Number", "HIP 102046"},
        {"Cincinnati Publication", "Ci 20 1220"},
        {"Geneva Identification System", "GEN# +1.00196892"},
        {"Smithsonian Astrophysical Observation", "SAO 163787"},
        {"Wilson Evans Batten Catalogue", "WEB 18451"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20563594),
        dec: Angle.Degrees(-18.79153331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -428.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92460"},
        {"Hipparcos Number", "HIP 52227"},
        {"Smithsonian Astrophysical Observation", "SAO 156144"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05940865),
        dec: Angle.Degrees(-18.78947867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 358564"},
        {"Hipparcos Number", "HIP 103138"},
        {"Geneva Identification System", "GEN# -0.01905953"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.45595476),
        dec: Angle.Degrees(-18.78909774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12005"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.68313181),
        dec: Angle.Degrees(-18.78893894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151194"},
        {"Hipparcos Number", "HIP 82128"},
        {"Geneva Identification System", "GEN# +1.00151194"},
        {"Smithsonian Astrophysical Observation", "SAO 160090"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.66534247),
        dec: Angle.Degrees(-18.78887459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105988"},
        {"Hipparcos Number", "HIP 59467"},
        {"Smithsonian Astrophysical Observation", "SAO 157138"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.96305611),
        dec: Angle.Degrees(-18.78824759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89509"},
        {"Hipparcos Number", "HIP 50540"},
        {"Smithsonian Astrophysical Observation", "SAO 155899"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.85061192),
        dec: Angle.Degrees(-18.78479591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222871"},
        {"Hipparcos Number", "HIP 117118"},
        {"Smithsonian Astrophysical Observation", "SAO 165859"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.14469822),
        dec: Angle.Degrees(-18.78452346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184794"},
        {"Hipparcos Number", "HIP 96475"},
        {"Geneva Identification System", "GEN# +1.00184794"},
        {"Renson", "Renson 50966"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.20490312),
        dec: Angle.Degrees(-18.78443569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98991"},
        {"Hipparcos Number", "HIP 55598"},
        {"Geneva Identification System", "GEN# +1.00098991"},
        {"Smithsonian Astrophysical Observation", "SAO 156646"},
        {"Wilson Evans Batten Catalogue", "WEB 9993"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.84196837),
        dec: Angle.Degrees(-18.77990277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -305.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196414"},
        {"Hipparcos Number", "HIP 101797"},
        {"Renson", "Renson 54736"},
        {"Smithsonian Astrophysical Observation", "SAO 163745"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45232022),
        dec: Angle.Degrees(-18.77606413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190331"},
        {"Hipparcos Number", "HIP 98901"},
        {"Geneva Identification System", "GEN# +1.00190331"},
        {"Smithsonian Astrophysical Observation", "SAO 163240"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.25877042),
        dec: Angle.Degrees(-18.77126732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123355"},
        {"Hipparcos Number", "HIP 68989"},
        {"Smithsonian Astrophysical Observation", "SAO 158364"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.86286517),
        dec: Angle.Degrees(-18.77095993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188275"},
        {"Hipparcos Number", "HIP 98005"},
        {"Smithsonian Astrophysical Observation", "SAO 163102"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.75317734),
        dec: Angle.Degrees(-18.76759859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5422"},
        {"Hipparcos Number", "HIP 4362"},
        {"Smithsonian Astrophysical Observation", "SAO 147518"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.97206643),
        dec: Angle.Degrees(-18.76393794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74991"},
        {"Hipparcos Number", "HIP 43108"},
        {"Smithsonian Astrophysical Observation", "SAO 154628"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.68976416),
        dec: Angle.Degrees(-18.75781885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71945"},
        {"Hipparcos Number", "HIP 41647"},
        {"Geneva Identification System", "GEN# +1.00071945"},
        {"Smithsonian Astrophysical Observation", "SAO 154313"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.38170320),
        dec: Angle.Degrees(-18.75753417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43116"},
        {"Hipparcos Number", "HIP 29567"},
        {"Fundamental Katalog 5th Edition", "FK5 4567"},
        {"Smithsonian Astrophysical Observation", "SAO 151248"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.43607389),
        dec: Angle.Degrees(-18.75743440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147534"},
        {"Hipparcos Number", "HIP 80269"},
        {"Smithsonian Astrophysical Observation", "SAO 159889"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78302323),
        dec: Angle.Degrees(-18.75666416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21169"},
        {"Smithsonian Astrophysical Observation", "SAO 149714"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.07487483),
        dec: Angle.Degrees(-18.75517285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63137"},
        {"Smithsonian Astrophysical Observation", "SAO 157607"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.05410893),
        dec: Angle.Degrees(-18.75354595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82891"},
        {"Hipparcos Number", "HIP 46972"},
        {"Smithsonian Astrophysical Observation", "SAO 155307"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.60284105),
        dec: Angle.Degrees(-18.75231185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218504"},
        {"Hipparcos Number", "HIP 114276"},
        {"Geneva Identification System", "GEN# +1.00218504"},
        {"Smithsonian Astrophysical Observation", "SAO 165511"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.17901270),
        dec: Angle.Degrees(-18.75185533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140560"},
        {"Hipparcos Number", "HIP 77124"},
        {"Smithsonian Astrophysical Observation", "SAO 159477"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.22191035),
        dec: Angle.Degrees(-18.75086756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186803"},
        {"Hipparcos Number", "HIP 97358"},
        {"Geneva Identification System", "GEN# +1.00186803"},
        {"Smithsonian Astrophysical Observation", "SAO 162982"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.82559835),
        dec: Angle.Degrees(-18.74638679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7826"},
        {"Hipparcos Number", "HIP 6052"},
        {"Geneva Identification System", "GEN# +1.00007826"},
        {"Smithsonian Astrophysical Observation", "SAO 147725"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.42844919),
        dec: Angle.Degrees(-18.74619636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24157"},
        {"Hipparcos Number", "HIP 17946"},
        {"Smithsonian Astrophysical Observation", "SAO 149199"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.55797210),
        dec: Angle.Degrees(-18.74599408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109131"},
        {"Hipparcos Number", "HIP 61207"},
        {"Smithsonian Astrophysical Observation", "SAO 157348"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.13314140),
        dec: Angle.Degrees(-18.74563484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205624"},
        {"Hipparcos Number", "HIP 106715"},
        {"Smithsonian Astrophysical Observation", "SAO 164516"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.24392330),
        dec: Angle.Degrees(-18.74367345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152427"},
        {"Hipparcos Number", "HIP 82674"},
        {"Smithsonian Astrophysical Observation", "SAO 160152"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.50425384),
        dec: Angle.Degrees(-18.74335616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155598"},
        {"Hipparcos Number", "HIP 84256"},
        {"Smithsonian Astrophysical Observation", "SAO 160373"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.34919764),
        dec: Angle.Degrees(-18.74236252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116114"},
        {"Hipparcos Number", "HIP 65203"},
        {"Geneva Identification System", "GEN# +1.00116114"},
        {"Renson", "Renson 33530"},
        {"Smithsonian Astrophysical Observation", "SAO 157882"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.44307056),
        dec: Angle.Degrees(-18.74208767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107068"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.27029876),
        dec: Angle.Degrees(-18.73957344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216167"},
        {"Hipparcos Number", "HIP 112827"},
        {"Smithsonian Astrophysical Observation", "SAO 165333"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.73396036),
        dec: Angle.Degrees(-18.73847335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177863"},
        {"Hipparcos Number", "HIP 93887"},
        {"Geneva Identification System", "GEN# +1.00177863"},
        {"Smithsonian Astrophysical Observation", "SAO 162204"},
        {"Wilson Evans Batten Catalogue", "WEB 16333"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78469618),
        dec: Angle.Degrees(-18.73812780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203270"},
        {"Hipparcos Number", "HIP 105465"},
        {"Geneva Identification System", "GEN# +1.00203270"},
        {"Smithsonian Astrophysical Observation", "SAO 164335"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.43395751),
        dec: Angle.Degrees(-18.73538391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34895"},
        {"Wilson Evans Batten Catalogue", "WEB 6976"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.29864925),
        dec: Angle.Degrees(-18.73075599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117246"},
        {"Hipparcos Number", "HIP 65813"},
        {"Geneva Identification System", "GEN# +1.00117246"},
        {"Smithsonian Astrophysical Observation", "SAO 157962"},
        {"Wilson Evans Batten Catalogue", "WEB 11647"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.37162157),
        dec: Angle.Degrees(-18.72905861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117661"},
        {"Hipparcos Number", "HIP 66015"},
        {"Fundamental Katalog 5th Edition", "FK5 3078"},
        {"Geneva Identification System", "GEN# +1.00117661"},
        {"Renson", "Renson 33930"},
        {"Smithsonian Astrophysical Observation", "SAO 157987"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.01194311),
        dec: Angle.Degrees(-18.72883645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170433"},
        {"Hipparcos Number", "HIP 90687"},
        {"Geneva Identification System", "GEN# +1.00170433"},
        {"Smithsonian Astrophysical Observation", "SAO 161540"},
        {"Wilson Evans Batten Catalogue", "WEB 15535"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.54934640),
        dec: Angle.Degrees(-18.72857432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201261"},
        {"Hipparcos Number", "HIP 104387"},
        {"Smithsonian Astrophysical Observation", "SAO 164170"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.20792916),
        dec: Angle.Degrees(-18.72713506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177989"},
        {"Hipparcos Number", "HIP 93934"},
        {"Geneva Identification System", "GEN# +1.00177989"},
        {"Wilson Evans Batten Catalogue", "WEB 16347"},
    },
    visualMagnitude: 9.34,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.90732046),
        dec: Angle.Degrees(-18.72626346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29289"},
        {"Hipparcos Number", "HIP 21430"},
        {"Smithsonian Astrophysical Observation", "SAO 149754"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.01572580),
        dec: Angle.Degrees(-18.72604379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55414"},
        {"Smithsonian Astrophysical Observation", "SAO 156623"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.23052315),
        dec: Angle.Degrees(-18.72512796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144252"},
        {"Hipparcos Number", "HIP 78836"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.40122149),
        dec: Angle.Degrees(-18.72446116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9658 AB"},
        {"Henry Draper", "HD 137832"},
        {"Hipparcos Number", "HIP 75768"},
        {"Smithsonian Astrophysical Observation", "SAO 159286"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.17988914),
        dec: Angle.Degrees(-18.72330767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213031"},
        {"Hipparcos Number", "HIP 110961"},
        {"Smithsonian Astrophysical Observation", "SAO 165104"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20831207),
        dec: Angle.Degrees(-18.72250102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56727"},
        {"Hipparcos Number", "HIP 35290"},
        {"Celescope Catalog", "CEL 1743"},
        {"Wilson Evans Batten Catalogue", "WEB 7044"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36214100),
        dec: Angle.Degrees(-18.72049109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35592"},
        {"Hipparcos Number", "HIP 25333"},
        {"Smithsonian Astrophysical Observation", "SAO 150425"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.27653039),
        dec: Angle.Degrees(-18.72023877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88318"},
        {"Hipparcos Number", "HIP 49852"},
        {"Geneva Identification System", "GEN# +9.00050003"},
        {"Smithsonian Astrophysical Observation", "SAO 155789"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.68093896),
        dec: Angle.Degrees(-18.71785931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16491"},
        {"Hipparcos Number", "HIP 12284"},
        {"Smithsonian Astrophysical Observation", "SAO 148516"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.56304781),
        dec: Angle.Degrees(-18.71682291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125248"},
        {"Hipparcos Number", "HIP 69929"},
        {"Fundamental Katalog 5th Edition", "FK5 1369"},
        {"Geneva Identification System", "GEN# +1.00125248"},
        {"Renson", "Renson 35760"},
        {"Smithsonian Astrophysical Observation", "SAO 158481"},
        {"Wilson Evans Batten Catalogue", "WEB 12162"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.65956766),
        dec: Angle.Degrees(-18.71588164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89073"},
        {"Hipparcos Number", "HIP 50290"},
        {"Smithsonian Astrophysical Observation", "SAO 155856"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03241045),
        dec: Angle.Degrees(-18.71489953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23207"},
        {"Hipparcos Number", "HIP 17345"},
        {"Geneva Identification System", "GEN# +1.00023207"},
        {"Renson", "Renson 5900"},
        {"Smithsonian Astrophysical Observation", "SAO 149128"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.68571110),
        dec: Angle.Degrees(-18.71364478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26504"},
        {"Smithsonian Astrophysical Observation", "SAO 150639"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55143780),
        dec: Angle.Degrees(-18.71339282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26417"},
        {"Hipparcos Number", "HIP 19457"},
        {"Geneva Identification System", "GEN# +1.00026417"},
        {"Smithsonian Astrophysical Observation", "SAO 149424"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.50601469),
        dec: Angle.Degrees(-18.71110645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75142"},
        {"Hipparcos Number", "HIP 43166"},
        {"Fundamental Katalog 5th Edition", "FK5 4789"},
        {"Smithsonian Astrophysical Observation", "SAO 154640"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.89282776),
        dec: Angle.Degrees(-18.71046408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175453"},
        {"Hipparcos Number", "HIP 92950"},
        {"Geneva Identification System", "GEN# +1.00175453"},
        {"Smithsonian Astrophysical Observation", "SAO 162001"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.05991817),
        dec: Angle.Degrees(-18.70941364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120901"},
        {"Henry Draper 2", "HD 120902"},
        {"Hipparcos Number", "HIP 67744"},
        {"Geneva Identification System", "GEN# +1.00120901"},
        {"Smithsonian Astrophysical Observation", "SAO 158210"},
        {"Wilson Evans Batten Catalogue", "WEB 11911"},
        {"Wilson Evans Batten Catalogue 2", "WEB 11912"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.16182680),
        dec: Angle.Degrees(-18.70902706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177291"},
        {"Hipparcos Number", "HIP 93696"},
        {"Geneva Identification System", "GEN# +1.00177291"},
        {"Smithsonian Astrophysical Observation", "SAO 162161"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.19971378),
        dec: Angle.Degrees(-18.70755473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 718"},
        {"Hipparcos Number", "HIP 922"},
        {"Geneva Identification System", "GEN# +1.00000718"},
        {"Smithsonian Astrophysical Observation", "SAO 147135"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.87203127),
        dec: Angle.Degrees(-18.70689324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20128"},
        {"Hipparcos Number", "HIP 15025"},
        {"Smithsonian Astrophysical Observation", "SAO 148846"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.40835564),
        dec: Angle.Degrees(-18.70558463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190540"},
        {"Hipparcos Number", "HIP 99011"},
        {"Geneva Identification System", "GEN# +1.00190540"},
        {"Smithsonian Astrophysical Observation", "SAO 163260"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.51112866),
        dec: Angle.Degrees(-18.70437640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141325"},
        {"Hipparcos Number", "HIP 77473"},
        {"Geneva Identification System", "GEN# +1.00141325"},
        {"Smithsonian Astrophysical Observation", "SAO 159512"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.27569526),
        dec: Angle.Degrees(-18.70406140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18347"},
        {"Hipparcos Number", "HIP 13698"},
        {"Smithsonian Astrophysical Observation", "SAO 148676"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.09964902),
        dec: Angle.Degrees(-18.70354671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4411 AB"},
        {"Aitken 2", "ADS 4411"},
        {"Henry Draper", "HD 38932"},
        {"Hipparcos Number", "HIP 27424"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.10606205),
        dec: Angle.Degrees(-18.70352122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200951"},
        {"Hipparcos Number", "HIP 104230"},
        {"Geneva Identification System", "GEN# +1.00200951"},
        {"Smithsonian Astrophysical Observation", "SAO 164144"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.77734611),
        dec: Angle.Degrees(-18.70151407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207521"},
        {"Hipparcos Number", "HIP 107771"},
        {"Smithsonian Astrophysical Observation", "SAO 164682"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.49684233),
        dec: Angle.Degrees(-18.70136275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84578"},
        {"Hipparcos Number", "HIP 47905"},
        {"Geneva Identification System", "GEN# +1.00084578"},
        {"Smithsonian Astrophysical Observation", "SAO 155463"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.44879481),
        dec: Angle.Degrees(-18.70000031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221255"},
        {"Hipparcos Number", "HIP 116028"},
        {"Smithsonian Astrophysical Observation", "SAO 165727"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.65699893),
        dec: Angle.Degrees(-18.69882282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127010"},
        {"Hipparcos Number", "HIP 70864"},
        {"Smithsonian Astrophysical Observation", "SAO 158595"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.37551307),
        dec: Angle.Degrees(-18.69812869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68657"},
        {"Smithsonian Astrophysical Observation", "SAO 158309"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.80693565),
        dec: Angle.Degrees(-18.69695651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180768"},
        {"Hipparcos Number", "HIP 94879"},
        {"Geneva Identification System", "GEN# +1.00180768"},
        {"Smithsonian Astrophysical Observation", "SAO 162442"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.62436734),
        dec: Angle.Degrees(-18.69683457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139751"},
        {"Hipparcos Number", "HIP 76768"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.11847533),
        dec: Angle.Degrees(-18.69578251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2268"},
        {"Hipparcos Number", "HIP 2086"},
        {"Geneva Identification System", "GEN# +1.00002268"},
        {"Smithsonian Astrophysical Observation", "SAO 147275"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.59057887),
        dec: Angle.Degrees(-18.69360316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205871"},
        {"Hipparcos Number", "HIP 106868"},
        {"Smithsonian Astrophysical Observation", "SAO 164543"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.66971114),
        dec: Angle.Degrees(-18.69143256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147102"},
        {"Hipparcos Number", "HIP 80061"},
        {"Smithsonian Astrophysical Observation", "SAO 159866"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.12253463),
        dec: Angle.Degrees(-18.69030397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220465"},
        {"Hipparcos Number", "HIP 115528"},
        {"Geneva Identification System", "GEN# +1.00220465"},
        {"Smithsonian Astrophysical Observation", "SAO 165672"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.03232585),
        dec: Angle.Degrees(-18.68812455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202701"},
        {"Hipparcos Number", "HIP 105165"},
        {"Smithsonian Astrophysical Observation", "SAO 164288"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54738943),
        dec: Angle.Degrees(-18.68766639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16056 AB"},
        {"Henry Draper", "HD 213766"},
        {"Hipparcos Number", "HIP 111406"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.54364001),
        dec: Angle.Degrees(-18.68664329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54958"},
        {"Hipparcos Number", "HIP 34617"},
        {"Geneva Identification System", "GEN# +1.00054958J"},
        {"Smithsonian Astrophysical Observation", "SAO 152497"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53898709),
        dec: Angle.Degrees(-18.68559657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337"},
        {"Hipparcos Number", "HIP 646"},
        {"Smithsonian Astrophysical Observation", "SAO 147098"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.99726573),
        dec: Angle.Degrees(-18.68470818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41503"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.97162941),
        dec: Angle.Degrees(-18.68420457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178341"},
        {"Hipparcos Number", "HIP 94062"},
        {"Geneva Identification System", "GEN# +1.00178341"},
        {"Smithsonian Astrophysical Observation", "SAO 162239"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.23782717),
        dec: Angle.Degrees(-18.68268135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17533"},
        {"Hipparcos Number", "HIP 13087"},
        {"Smithsonian Astrophysical Observation", "SAO 148616"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.05982871),
        dec: Angle.Degrees(-18.68261550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3870"},
        {"Geneva Identification System", "GEN# -0.01900129"},
        {"Smithsonian Astrophysical Observation", "SAO 147468"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.42242062),
        dec: Angle.Degrees(-18.68197027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73266"},
        {"Hipparcos Number", "HIP 42255"},
        {"Geneva Identification System", "GEN# +1.00073266"},
        {"Smithsonian Astrophysical Observation", "SAO 154459"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.24022048),
        dec: Angle.Degrees(-18.68103528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148577"},
        {"Hipparcos Number", "HIP 80784"},
        {"Geneva Identification System", "GEN# +1.00148577"},
        {"Smithsonian Astrophysical Observation", "SAO 159946"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.42998113),
        dec: Angle.Degrees(-18.68020835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61554"},
        {"Hipparcos Number", "HIP 37261"},
        {"Celescope Catalog", "CEL 1961"},
        {"Geneva Identification System", "GEN# +1.00061554"},
        {"Smithsonian Astrophysical Observation", "SAO 153195"},
        {"Wilson Evans Batten Catalogue", "WEB 7378"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.77960698),
        dec: Angle.Degrees(-18.67840404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117218",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16979 AB"},
        {"Henry Draper", "HD 223024"},
        {"Hipparcos Number", "HIP 117218"},
        {"Geneva Identification System", "GEN# +1.00223024J"},
        {"Wilson Evans Batten Catalogue", "WEB 20652"},
    },
    visualMagnitude: 5.28,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50350924),
        dec: Angle.Degrees(-18.67836913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36845"},
        {"Hipparcos Number", "HIP 26078"},
        {"Geneva Identification System", "GEN# +1.00036845"},
        {"Smithsonian Astrophysical Observation", "SAO 150562"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.43168562),
        dec: Angle.Degrees(-18.67820494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45339",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7256 AB"},
        {"Henry Draper", "HD 79568"},
        {"Hipparcos Number", "HIP 45339"},
        {"Fundamental Katalog 5th Edition", "FK5 4822"},
        {"Smithsonian Astrophysical Observation", "SAO 155022"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59271732),
        dec: Angle.Degrees(-18.67515322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172177"},
        {"Hipparcos Number", "HIP 91486"},
        {"Smithsonian Astrophysical Observation", "SAO 161696"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.87156535),
        dec: Angle.Degrees(-18.67246983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149435"},
        {"Hipparcos Number", "HIP 81237"},
        {"Fundamental Katalog 5th Edition", "FK5 5466"},
        {"Geneva Identification System", "GEN# +1.00149435"},
        {"Smithsonian Astrophysical Observation", "SAO 159990"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.87386581),
        dec: Angle.Degrees(-18.67240212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90619"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.36413083),
        dec: Angle.Degrees(-18.67152958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129213"},
        {"Hipparcos Number", "HIP 71850"},
        {"Geneva Identification System", "GEN# +1.00129213"},
        {"Smithsonian Astrophysical Observation", "SAO 158738"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.45245000),
        dec: Angle.Degrees(-18.67067471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94821"},
        {"Hipparcos Number", "HIP 53497"},
        {"Smithsonian Astrophysical Observation", "SAO 156342"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.15741631),
        dec: Angle.Degrees(-18.66953647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209717"},
        {"Hipparcos Number", "HIP 109077"},
        {"Geneva Identification System", "GEN# +1.00209717"},
        {"Smithsonian Astrophysical Observation", "SAO 164854"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.45058547),
        dec: Angle.Degrees(-18.66823507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84467"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.03137764),
        dec: Angle.Degrees(-18.66789962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204365"},
        {"Hipparcos Number", "HIP 106027"},
        {"Smithsonian Astrophysical Observation", "SAO 164417"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.12942044),
        dec: Angle.Degrees(-18.66687959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30127"},
        {"Hipparcos Number", "HIP 22028"},
        {"Fundamental Katalog 5th Edition", "FK5 2352"},
        {"Geneva Identification System", "GEN# +1.00030127"},
        {"Smithsonian Astrophysical Observation", "SAO 149856"},
        {"Wilson Evans Batten Catalogue", "WEB 4231"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.03312400),
        dec: Angle.Degrees(-18.66654311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86684"},
        {"Hipparcos Number", "HIP 48994"},
        {"Smithsonian Astrophysical Observation", "SAO 155644"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.93425590),
        dec: Angle.Degrees(-18.66485525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158336"},
        {"Hipparcos Number", "HIP 85591"},
        {"Renson", "Renson 44560"},
        {"Smithsonian Astrophysical Observation", "SAO 160576"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36127751),
        dec: Angle.Degrees(-18.66421472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65564"},
        {"Hipparcos Number", "HIP 38982"},
        {"Smithsonian Astrophysical Observation", "SAO 153654"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.65866345),
        dec: Angle.Degrees(-18.66396919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4659"},
        {"Hipparcos Number", "HIP 3773"},
        {"Smithsonian Astrophysical Observation", "SAO 147455"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.12318298),
        dec: Angle.Degrees(-18.66336118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33594"},
        {"Hipparcos Number", "HIP 24092"},
        {"Smithsonian Astrophysical Observation", "SAO 150198"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.63733044),
        dec: Angle.Degrees(-18.66246611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11196 A"},
        {"Henry Draper", "HD 167356"},
        {"Hipparcos Number", "HIP 89470"},
        {"Geneva Identification System", "GEN# +1.00167356J"},
        {"Renson", "Renson 47035"},
        {"Smithsonian Astrophysical Observation", "SAO 161227"},
        {"Wilson Evans Batten Catalogue", "WEB 15225"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.87818188),
        dec: Angle.Degrees(-18.66157177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34564"},
        {"Hipparcos Number", "HIP 24675"},
        {"Geneva Identification System", "GEN# +1.00034564"},
        {"Smithsonian Astrophysical Observation", "SAO 150309"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.40692849),
        dec: Angle.Degrees(-18.66150505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31560",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5253 B"},
        {"Henry Draper", "HD 47138B"},
        {"Hipparcos Number", "HIP 31560"},
        {"Geneva Identification System", "GEN# +1.00047138B"},
        {"Smithsonian Astrophysical Observation", "SAO 151693"},
        {"Wilson Evans Batten Catalogue", "WEB 6317"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.09016886),
        dec: Angle.Degrees(-18.66045776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31564",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5253 A"},
        {"Henry Draper", "HD 47138"},
        {"Hipparcos Number", "HIP 31564"},
        {"Geneva Identification System", "GEN# +1.00047138A"},
        {"Smithsonian Astrophysical Observation", "SAO 151694"},
        {"Wilson Evans Batten Catalogue", "WEB 6316"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.09524032),
        dec: Angle.Degrees(-18.65994454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85402"},
        {"Hipparcos Number", "HIP 48334"},
        {"Geneva Identification System", "GEN# +1.00085402"},
        {"Smithsonian Astrophysical Observation", "SAO 155533"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.78354168),
        dec: Angle.Degrees(-18.65880087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86873",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10751 A"},
        {"Henry Draper", "HD 161208"},
        {"Hipparcos Number", "HIP 86873"},
        {"Geneva Identification System", "GEN# +1.00161208"},
        {"Smithsonian Astrophysical Observation", "SAO 160795"},
        {"Wilson Evans Batten Catalogue", "WEB 14653"},
    },
    visualMagnitude: 8.49,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.23531588),
        dec: Angle.Degrees(-18.65730699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32061"},
        {"Hipparcos Number", "HIP 23215"},
        {"Smithsonian Astrophysical Observation", "SAO 150063"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.93893467),
        dec: Angle.Degrees(-18.65648762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28264"},
        {"Hipparcos Number", "HIP 20761"},
        {"Geneva Identification System", "GEN# +1.00028264"},
        {"Smithsonian Astrophysical Observation", "SAO 149639"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.72150679),
        dec: Angle.Degrees(-18.65618823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183797"},
        {"Hipparcos Number", "HIP 96064"},
        {"Smithsonian Astrophysical Observation", "SAO 162727"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.98618662),
        dec: Angle.Degrees(-18.65590677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69754"},
        {"Hipparcos Number", "HIP 40643"},
        {"Smithsonian Astrophysical Observation", "SAO 154082"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.45605232),
        dec: Angle.Degrees(-18.64783384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218809"},
        {"Hipparcos Number", "HIP 114478"},
        {"Smithsonian Astrophysical Observation", "SAO 165537"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.76234667),
        dec: Angle.Degrees(-18.64738711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19661"},
        {"Smithsonian Astrophysical Observation", "SAO 149458"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.19079224),
        dec: Angle.Degrees(-18.64657635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13166"},
        {"Hipparcos Number", "HIP 9969"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.09128403),
        dec: Angle.Degrees(-18.64058388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27040"},
        {"Hipparcos Number", "HIP 19879"},
        {"Smithsonian Astrophysical Observation", "SAO 149494"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.94526697),
        dec: Angle.Degrees(-18.64048136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92682",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11776 A"},
        {"Henry Draper", "HD 174802"},
        {"Hipparcos Number", "HIP 92682"},
        {"Smithsonian Astrophysical Observation", "SAO 161935"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.27719596),
        dec: Angle.Degrees(-18.63677726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53156",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7960 AB"},
        {"Henry Draper", "HD 94254"},
        {"Hipparcos Number", "HIP 53156"},
        {"Smithsonian Astrophysical Observation", "SAO 156288"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.13312111),
        dec: Angle.Degrees(-18.63677214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173940"},
        {"Hipparcos Number", "HIP 92307"},
        {"Smithsonian Astrophysical Observation", "SAO 161850"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.20376384),
        dec: Angle.Degrees(-18.63216768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135547"},
        {"Hipparcos Number", "HIP 74728"},
        {"Smithsonian Astrophysical Observation", "SAO 159139"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.08219235),
        dec: Angle.Degrees(-18.62903167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206679"},
        {"Hipparcos Number", "HIP 107312"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.03770186),
        dec: Angle.Degrees(-18.62849462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132571"},
        {"Hipparcos Number", "HIP 73433"},
        {"Fundamental Katalog 5th Edition", "FK5 5334"},
        {"Smithsonian Astrophysical Observation", "SAO 158962"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09512170),
        dec: Angle.Degrees(-18.62726733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218593"},
        {"Hipparcos Number", "HIP 114338"},
        {"Smithsonian Astrophysical Observation", "SAO 165516"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.35484265),
        dec: Angle.Degrees(-18.62714223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133499"},
        {"Hipparcos Number", "HIP 73827"},
        {"Smithsonian Astrophysical Observation", "SAO 159013"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33245927),
        dec: Angle.Degrees(-18.62597292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74926"},
        {"Geneva Identification System", "GEN# -0.01804031"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.66362760),
        dec: Angle.Degrees(-18.62572405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 447.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -354.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121957"},
        {"Hipparcos Number", "HIP 68314"},
        {"Fundamental Katalog 5th Edition", "FK5 5237"},
        {"Smithsonian Astrophysical Observation", "SAO 158275"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.76519938),
        dec: Angle.Degrees(-18.62293423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207760"},
        {"Hipparcos Number", "HIP 107901"},
        {"Geneva Identification System", "GEN# +1.00207760"},
        {"Smithsonian Astrophysical Observation", "SAO 164697"},
        {"Wilson Evans Batten Catalogue", "WEB 19455"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.92358006),
        dec: Angle.Degrees(-18.62275248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12655"},
        {"Hipparcos Number", "HIP 9620"},
        {"Geneva Identification System", "GEN# +1.00012655"},
        {"Smithsonian Astrophysical Observation", "SAO 148176"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.90911883),
        dec: Angle.Degrees(-18.62206463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197930"},
        {"Hipparcos Number", "HIP 102587"},
        {"Geneva Identification System", "GEN# +1.00197930"},
        {"Smithsonian Astrophysical Observation", "SAO 163877"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.84549161),
        dec: Angle.Degrees(-18.62113492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2719"},
        {"Hipparcos Number", "HIP 2403"},
        {"Geneva Identification System", "GEN# +1.00002719A"},
        {"Smithsonian Astrophysical Observation", "SAO 147315"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.65848170),
        dec: Angle.Degrees(-18.62093632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80889"},
        {"Geneva Identification System", "GEN# -0.01804289"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.76319249),
        dec: Angle.Degrees(-18.62038231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57611"},
        {"Hipparcos Number", "HIP 35644"},
        {"Smithsonian Astrophysical Observation", "SAO 152757"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.33061705),
        dec: Angle.Degrees(-18.61977909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15456"},
        {"Hipparcos Number", "HIP 11553"},
        {"Geneva Identification System", "GEN# +1.00015456"},
        {"Smithsonian Astrophysical Observation", "SAO 148410"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.21527128),
        dec: Angle.Degrees(-18.61906920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69615"},
        {"Smithsonian Astrophysical Observation", "SAO 158447"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.72813191),
        dec: Angle.Degrees(-18.61898803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52246"},
        {"Smithsonian Astrophysical Observation", "SAO 156149"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.13101044),
        dec: Angle.Degrees(-18.61822100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11863"},
        {"Hipparcos Number", "HIP 9025"},
        {"Fundamental Katalog 5th Edition", "FK5 4174"},
        {"Smithsonian Astrophysical Observation", "SAO 148117"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.06108599),
        dec: Angle.Degrees(-18.61751702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89529"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02810742),
        dec: Angle.Degrees(-18.61744143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182318"},
        {"Hipparcos Number", "HIP 95440"},
        {"Smithsonian Astrophysical Observation", "SAO 162578"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.21048834),
        dec: Angle.Degrees(-18.61679161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75918"},
        {"Hipparcos Number", "HIP 43558"},
        {"Geneva Identification System", "GEN# +1.00075918"},
        {"Smithsonian Astrophysical Observation", "SAO 154702"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.06817431),
        dec: Angle.Degrees(-18.61593313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55494"},
        {"Hipparcos Number", "HIP 34820"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.11041987),
        dec: Angle.Degrees(-18.61500206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34618"},
        {"Hipparcos Number", "HIP 24707"},
        {"Smithsonian Astrophysical Observation", "SAO 150316"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.50347734),
        dec: Angle.Degrees(-18.61254953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79750"},
        {"Smithsonian Astrophysical Observation", "SAO 159825"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.16044556),
        dec: Angle.Degrees(-18.61250110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108490"},
        {"Hipparcos Number", "HIP 60818"},
        {"Smithsonian Astrophysical Observation", "SAO 157302"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.98703685),
        dec: Angle.Degrees(-18.60975429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99256"},
        {"Hipparcos Number", "HIP 55740"},
        {"Geneva Identification System", "GEN# +1.00099256"},
        {"Smithsonian Astrophysical Observation", "SAO 156664"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.31306115),
        dec: Angle.Degrees(-18.60709147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140143"},
        {"Hipparcos Number", "HIP 76937"},
        {"Fundamental Katalog 5th Edition", "FK5 5392"},
        {"Smithsonian Astrophysical Observation", "SAO 159452"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.65873157),
        dec: Angle.Degrees(-18.60706502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43717"},
        {"Hipparcos Number", "HIP 29829"},
        {"Geneva Identification System", "GEN# +1.00043717"},
        {"Smithsonian Astrophysical Observation", "SAO 151311"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22051100),
        dec: Angle.Degrees(-18.60677408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88300"},
        {"Hipparcos Number", "HIP 49839"},
        {"Geneva Identification System", "GEN# +9.00050007"},
        {"Smithsonian Astrophysical Observation", "SAO 155786"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.64357091),
        dec: Angle.Degrees(-18.60328238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54547"},
        {"Hipparcos Number", "HIP 34448"},
        {"Smithsonian Astrophysical Observation", "SAO 152448"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.11532335),
        dec: Angle.Degrees(-18.60308934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81693"},
        {"Hipparcos Number", "HIP 46326"},
        {"Smithsonian Astrophysical Observation", "SAO 155192"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.68024626),
        dec: Angle.Degrees(-18.60307793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16788"},
        {"Hipparcos Number", "HIP 12514"},
        {"Smithsonian Astrophysical Observation", "SAO 148542"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.26483285),
        dec: Angle.Degrees(-18.60223405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173928"},
        {"Hipparcos Number", "HIP 92301"},
        {"Smithsonian Astrophysical Observation", "SAO 161848"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.18921391),
        dec: Angle.Degrees(-18.60115618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 731"},
        {"Hipparcos Number", "HIP 932"},
        {"Geneva Identification System", "GEN# +1.00000731"},
        {"Smithsonian Astrophysical Observation", "SAO 147136"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.89707760),
        dec: Angle.Degrees(-18.60067836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146312"},
        {"Hipparcos Number", "HIP 79732"},
        {"Smithsonian Astrophysical Observation", "SAO 159823"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.08503600),
        dec: Angle.Degrees(-18.59862340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216457"},
        {"Hipparcos Number", "HIP 113021"},
        {"Geneva Identification System", "GEN# +1.00216457"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.32098151),
        dec: Angle.Degrees(-18.59192546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224064"},
        {"Hipparcos Number", "HIP 117891"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.70234757),
        dec: Angle.Degrees(-18.59168605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133412"},
        {"Hipparcos Number", "HIP 73787"},
        {"Geneva Identification System", "GEN# +1.00133412"},
        {"Smithsonian Astrophysical Observation", "SAO 159009"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.22527408),
        dec: Angle.Degrees(-18.59061013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156734"},
        {"Hipparcos Number", "HIP 84813"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.01187203),
        dec: Angle.Degrees(-18.58782210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203929"},
        {"Hipparcos Number", "HIP 105808"},
        {"Smithsonian Astrophysical Observation", "SAO 164380"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.42911636),
        dec: Angle.Degrees(-18.58728889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137612"},
        {"Hipparcos Number", "HIP 75664"},
        {"Smithsonian Astrophysical Observation", "SAO 159269"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.88768436),
        dec: Angle.Degrees(-18.58716008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13902 B"},
        {"Henry Draper", "HD 195093"},
        {"Hipparcos Number", "HIP 101120"},
        {"Geneva Identification System", "GEN# +1.00195093"},
        {"Smithsonian Astrophysical Observation", "SAO 163625"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.46907440),
        dec: Angle.Degrees(-18.58616340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124990"},
        {"Hipparcos Number", "HIP 69792"},
        {"Geneva Identification System", "GEN# +1.00124990"},
        {"Smithsonian Astrophysical Observation", "SAO 158462"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26580256),
        dec: Angle.Degrees(-18.58568095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101123",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13902 A"},
        {"Henry Draper", "HD 195094"},
        {"Hipparcos Number", "HIP 101123"},
        {"Smithsonian Astrophysical Observation", "SAO 163626"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.47454931),
        dec: Angle.Degrees(-18.58298474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8436 AB"},
        {"Henry Draper", "HD 105428"},
        {"Hipparcos Number", "HIP 59195"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.08857556),
        dec: Angle.Degrees(-18.58152041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164123"},
        {"Hipparcos Number", "HIP 88174"},
        {"Smithsonian Astrophysical Observation", "SAO 160982"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.12004998),
        dec: Angle.Degrees(-18.57891503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205003"},
        {"Hipparcos Number", "HIP 106382"},
        {"Smithsonian Astrophysical Observation", "SAO 164467"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.20376977),
        dec: Angle.Degrees(-18.57875952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5106"},
        {"Hipparcos Number", "HIP 4117"},
        {"Geneva Identification System", "GEN# +1.00005106"},
        {"Smithsonian Astrophysical Observation", "SAO 147494"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.19088897),
        dec: Angle.Degrees(-18.57668558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90110"},
        {"Wilson Evans Batten Catalogue", "WEB 15407"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82978975),
        dec: Angle.Degrees(-18.57477348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 672"},
        {"Hipparcos Number", "HIP 893"},
        {"Smithsonian Astrophysical Observation", "SAO 147130"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.74149810),
        dec: Angle.Degrees(-18.57284278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120121"},
        {"Hipparcos Number", "HIP 67320"},
        {"Smithsonian Astrophysical Observation", "SAO 158171"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98199996),
        dec: Angle.Degrees(-18.57271490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17206"},
        {"Hipparcos Number", "HIP 12843"},
        {"Geneva Identification System", "GEN# +1.00017206"},
        {"Smithsonian Astrophysical Observation", "SAO 148584"},
        {"Wilson Evans Batten Catalogue", "WEB 2610"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.27492276),
        dec: Angle.Degrees(-18.57265077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 330.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16846 AB"},
        {"Henry Draper", "HD 221790"},
        {"Hipparcos Number", "HIP 116397"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.79847666),
        dec: Angle.Degrees(-18.57178426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48890"},
        {"Hipparcos Number", "HIP 32319"},
        {"Renson", "Renson 13086"},
        {"Smithsonian Astrophysical Observation", "SAO 151873"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.21224121),
        dec: Angle.Degrees(-18.57044570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14430"},
        {"Hipparcos Number", "HIP 10831"},
        {"Smithsonian Astrophysical Observation", "SAO 148331"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.85330321),
        dec: Angle.Degrees(-18.57023769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22899"},
        {"Smithsonian Astrophysical Observation", "SAO 149995"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.88269099),
        dec: Angle.Degrees(-18.57007089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91790"},
        {"Hipparcos Number", "HIP 51852"},
        {"Geneva Identification System", "GEN# +1.00091790"},
        {"Smithsonian Astrophysical Observation", "SAO 156087"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.91191934),
        dec: Angle.Degrees(-18.56900618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205056"},
        {"Hipparcos Number", "HIP 106415"},
        {"Smithsonian Astrophysical Observation", "SAO 164472"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.30356039),
        dec: Angle.Degrees(-18.56775545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80165"},
        {"Smithsonian Astrophysical Observation", "SAO 159878"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.46812942),
        dec: Angle.Degrees(-18.56775040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41146"},
        {"Hipparcos Number", "HIP 28615"},
        {"Geneva Identification System", "GEN# +1.00041146"},
        {"Smithsonian Astrophysical Observation", "SAO 151048"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.59745664),
        dec: Angle.Degrees(-18.56754869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176123"},
        {"Hipparcos Number", "HIP 93234"},
        {"Geneva Identification System", "GEN# +1.00176123"},
        {"Smithsonian Astrophysical Observation", "SAO 162050"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.86158095),
        dec: Angle.Degrees(-18.56638766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9421"},
        {"Hipparcos Number", "HIP 7158"},
        {"Smithsonian Astrophysical Observation", "SAO 147869"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.06752454),
        dec: Angle.Degrees(-18.56603662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6322"},
        {"Hipparcos Number", "HIP 4995"},
        {"Geneva Identification System", "GEN# +1.00006322"},
        {"Renson", "Renson 1620"},
        {"Smithsonian Astrophysical Observation", "SAO 147589"},
        {"Wilson Evans Batten Catalogue", "WEB 1009"},
    },
    visualMagnitude: 9.24,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.00646333),
        dec: Angle.Degrees(-18.56542830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10675"},
        {"Hipparcos Number", "HIP 8088"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.96472031),
        dec: Angle.Degrees(-18.56538486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50801"},
        {"Hipparcos Number", "HIP 33138"},
        {"Celescope Catalog", "CEL 1423"},
        {"Geneva Identification System", "GEN# +1.00050801"},
        {"Smithsonian Astrophysical Observation", "SAO 152069"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.50814979),
        dec: Angle.Degrees(-18.56506994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3232"},
        {"Hipparcos Number", "HIP 2771"},
        {"Smithsonian Astrophysical Observation", "SAO 147349"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.83099834),
        dec: Angle.Degrees(-18.56414084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212674"},
        {"Hipparcos Number", "HIP 110755"},
        {"Geneva Identification System", "GEN# +1.00212674"},
        {"Smithsonian Astrophysical Observation", "SAO 165072"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.57310867),
        dec: Angle.Degrees(-18.56336206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182390"},
        {"Hipparcos Number", "HIP 95458"},
        {"Geneva Identification System", "GEN# +1.00182390"},
        {"Smithsonian Astrophysical Observation", "SAO 162588"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.27966956),
        dec: Angle.Degrees(-18.56279992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101958"},
        {"Hipparcos Number", "HIP 57215"},
        {"Smithsonian Astrophysical Observation", "SAO 156858"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.98079946),
        dec: Angle.Degrees(-18.56265020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223785"},
        {"Hipparcos Number", "HIP 117734"},
        {"Celescope Catalog", "CEL 5699"},
        {"Geneva Identification System", "GEN# +1.00223785"},
        {"Smithsonian Astrophysical Observation", "SAO 165934"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.16610437),
        dec: Angle.Degrees(-18.56186826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214911"},
        {"Hipparcos Number", "HIP 112062"},
        {"Smithsonian Astrophysical Observation", "SAO 165236"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.46296321),
        dec: Angle.Degrees(-18.56163581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26029"},
        {"Smithsonian Astrophysical Observation", "SAO 150556"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.30659212),
        dec: Angle.Degrees(-18.56146075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2465"},
        {"Henry Draper", "HD 20631"},
        {"Hipparcos Number", "HIP 15411"},
        {"Geneva Identification System", "GEN# +1.00020631J"},
        {"Smithsonian Astrophysical Observation", "SAO 148897"},
        {"Wilson Evans Batten Catalogue", "WEB 2966"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.67113524),
        dec: Angle.Degrees(-18.55964006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33995"},
        {"Hipparcos Number", "HIP 24339"},
        {"Geneva Identification System", "GEN# +1.00033995"},
        {"Smithsonian Astrophysical Observation", "SAO 150250"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.35524985),
        dec: Angle.Degrees(-18.55850736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154700"},
        {"Hipparcos Number", "HIP 83813"},
        {"Smithsonian Astrophysical Observation", "SAO 160297"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.93507379),
        dec: Angle.Degrees(-18.55846827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38206"},
        {"Hipparcos Number", "HIP 26966"},
        {"Geneva Identification System", "GEN# +1.00038206"},
        {"Smithsonian Astrophysical Observation", "SAO 150739"},
        {"Wilson Evans Batten Catalogue", "WEB 5316"},
    },
    visualMagnitude: 5.73,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.84024542),
        dec: Angle.Degrees(-18.55744324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24926"},
        {"Hipparcos Number", "HIP 18483"},
        {"Smithsonian Astrophysical Observation", "SAO 149275"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.25981429),
        dec: Angle.Degrees(-18.55388342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119132"},
        {"Hipparcos Number", "HIP 66819"},
        {"Smithsonian Astrophysical Observation", "SAO 158093"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.43314819),
        dec: Angle.Degrees(-18.55304165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165782"},
        {"Hipparcos Number", "HIP 88855"},
        {"Geneva Identification System", "GEN# +1.00165782"},
        {"Wilson Evans Batten Catalogue", "WEB 15063"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.11046572),
        dec: Angle.Degrees(-18.55220344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171432"},
        {"Hipparcos Number", "HIP 91143"},
        {"Geneva Identification System", "GEN# +1.00171432"},
        {"Wilson Evans Batten Catalogue", "WEB 15651"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.90315233),
        dec: Angle.Degrees(-18.55062106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22471"},
        {"Hipparcos Number", "HIP 16799"},
        {"Geneva Identification System", "GEN# +1.00022471"},
        {"Smithsonian Astrophysical Observation", "SAO 149062"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.05395840),
        dec: Angle.Degrees(-18.55007100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189893"},
        {"Hipparcos Number", "HIP 98707"},
        {"Geneva Identification System", "GEN# +1.00189893"},
        {"Smithsonian Astrophysical Observation", "SAO 163208"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.72861822),
        dec: Angle.Degrees(-18.54611021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77785"},
        {"Hipparcos Number", "HIP 44506"},
        {"Smithsonian Astrophysical Observation", "SAO 154874"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.00983738),
        dec: Angle.Degrees(-18.54449450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16688 AB"},
        {"Henry Draper", "HD 220065"},
        {"Hipparcos Number", "HIP 115284"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.23323502),
        dec: Angle.Degrees(-18.54339933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90577"},
    },
    visualMagnitude: 11.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.24091095),
        dec: Angle.Degrees(-18.54189148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16465 AB"},
        {"Henry Draper", "HD 217684"},
        {"Hipparcos Number", "HIP 113792"},
        {"Smithsonian Astrophysical Observation", "SAO 165456"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.65739239),
        dec: Angle.Degrees(-18.54168724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150803"},
        {"Hipparcos Number", "HIP 81931"},
        {"Smithsonian Astrophysical Observation", "SAO 160069"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.01997066),
        dec: Angle.Degrees(-18.54120305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86929"},
        {"Hipparcos Number", "HIP 49120"},
        {"Smithsonian Astrophysical Observation", "SAO 155665"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.38161492),
        dec: Angle.Degrees(-18.53954212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224594"},
        {"Hipparcos Number", "HIP 118258"},
        {"Smithsonian Astrophysical Observation", "SAO 165982"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.79609127),
        dec: Angle.Degrees(-18.53950042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144134"},
        {"Hipparcos Number", "HIP 78785"},
        {"Geneva Identification System", "GEN# +1.00144134"},
        {"Smithsonian Astrophysical Observation", "SAO 159677"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.26221871),
        dec: Angle.Degrees(-18.53940123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106597"},
        {"Hipparcos Number", "HIP 59795"},
        {"Geneva Identification System", "GEN# +1.00106597"},
        {"Smithsonian Astrophysical Observation", "SAO 157174"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.92182019),
        dec: Angle.Degrees(-18.53911324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80569"},
        {"Hipparcos Number", "HIP 45781"},
        {"Smithsonian Astrophysical Observation", "SAO 155100"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.01990194),
        dec: Angle.Degrees(-18.53891907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169335"},
        {"Hipparcos Number", "HIP 90257"},
        {"Geneva Identification System", "GEN# +1.00169335"},
        {"Smithsonian Astrophysical Observation", "SAO 161449"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.24947894),
        dec: Angle.Degrees(-18.53867137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155629"},
        {"Hipparcos Number", "HIP 84270"},
        {"Smithsonian Astrophysical Observation", "SAO 160378"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.40522255),
        dec: Angle.Degrees(-18.53637152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145997"},
        {"Hipparcos Number", "HIP 79605"},
        {"Geneva Identification System", "GEN# +1.00145997"},
        {"Smithsonian Astrophysical Observation", "SAO 159807"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.66375587),
        dec: Angle.Degrees(-18.53534300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164843"},
        {"Hipparcos Number", "HIP 88477"},
        {"Smithsonian Astrophysical Observation", "SAO 161034"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.98395121),
        dec: Angle.Degrees(-18.53452002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175384"},
        {"Hipparcos Number", "HIP 92912"},
        {"Geneva Identification System", "GEN# +1.00175384"},
        {"Smithsonian Astrophysical Observation", "SAO 161991"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.95784904),
        dec: Angle.Degrees(-18.53351091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110126"},
        {"Hipparcos Number", "HIP 61814"},
        {"Geneva Identification System", "GEN# +1.00110126"},
        {"Smithsonian Astrophysical Observation", "SAO 157430"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.02517878),
        dec: Angle.Degrees(-18.53284219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15477"},
        {"Hipparcos Number", "HIP 11571"},
        {"Smithsonian Astrophysical Observation", "SAO 148412"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.27990964),
        dec: Angle.Degrees(-18.53282460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 775 AB"},
        {"Henry Draper", "HD 5414"},
        {"Hipparcos Number", "HIP 4354"},
        {"Smithsonian Astrophysical Observation", "SAO 147516"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.95431636),
        dec: Angle.Degrees(-18.53191408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150018"},
        {"Hipparcos Number", "HIP 81514"},
        {"Geneva Identification System", "GEN# +1.00150018"},
        {"Renson", "Renson 42436"},
        {"Smithsonian Astrophysical Observation", "SAO 160024"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.75461048),
        dec: Angle.Degrees(-18.52444029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69998",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9218 AB"},
        {"Henry Draper", "HD 125379"},
        {"Hipparcos Number", "HIP 69998"},
        {"Renson", "Renson 35820"},
        {"Smithsonian Astrophysical Observation", "SAO 158495"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.85762004),
        dec: Angle.Degrees(-18.52359782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200481"},
        {"Hipparcos Number", "HIP 103997"},
        {"Geneva Identification System", "GEN# +1.00200481"},
        {"Smithsonian Astrophysical Observation", "SAO 164113"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.05642651),
        dec: Angle.Degrees(-18.52331479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111980"},
        {"Hipparcos Number", "HIP 62882"},
        {"Cincinnati Publication", "Ci 20 747"},
        {"Geneva Identification System", "GEN# +1.00111980J"},
        {"Smithsonian Astrophysical Observation", "SAO 157573"},
        {"Wilson Evans Batten Catalogue", "WEB 11146"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.31195357),
        dec: Angle.Degrees(-18.52029024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 300.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -795.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3910 A"},
        {"Henry Draper", "HD 34798"},
        {"Hipparcos Number", "HIP 24825"},
        {"Geneva Identification System", "GEN# +1.00034798"},
        {"Smithsonian Astrophysical Observation", "SAO 150335"},
        {"Wilson Evans Batten Catalogue", "WEB 4805"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.82264928),
        dec: Angle.Degrees(-18.51994134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27500"},
        {"Hipparcos Number", "HIP 20206"},
        {"Geneva Identification System", "GEN# +1.00027500"},
        {"Smithsonian Astrophysical Observation", "SAO 149544"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.94958846),
        dec: Angle.Degrees(-18.51974692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99598"},
        {"Hipparcos Number", "HIP 55894"},
        {"Smithsonian Astrophysical Observation", "SAO 156689"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.85039308),
        dec: Angle.Degrees(-18.51964630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210191"},
        {"Hipparcos Number", "HIP 109332"},
        {"Geneva Identification System", "GEN# +1.00210191"},
        {"Smithsonian Astrophysical Observation", "SAO 164888"},
        {"Wilson Evans Batten Catalogue", "WEB 19645"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.24579432),
        dec: Angle.Degrees(-18.51957349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181426"},
        {"Hipparcos Number", "HIP 95128"},
        {"Smithsonian Astrophysical Observation", "SAO 162499"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.28673884),
        dec: Angle.Degrees(-18.51804563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60092"},
        {"Hipparcos Number", "HIP 36652"},
        {"Geneva Identification System", "GEN# +1.00060092"},
        {"Renson", "Renson 16420"},
        {"Smithsonian Astrophysical Observation", "SAO 153028"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.06774460),
        dec: Angle.Degrees(-18.51782973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11640",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11640"},
    },
    visualMagnitude: 12.07,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.54426992),
        dec: Angle.Degrees(-18.51695212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104357"},
        {"Hipparcos Number", "HIP 58604"},
        {"Geneva Identification System", "GEN# +1.00104357"},
        {"Smithsonian Astrophysical Observation", "SAO 157043"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.25935406),
        dec: Angle.Degrees(-18.51649337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221172"},
        {"Hipparcos Number", "HIP 115968"},
        {"Smithsonian Astrophysical Observation", "SAO 165721"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.44028605),
        dec: Angle.Degrees(-18.51627013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137318"},
        {"Hipparcos Number", "HIP 75532"},
        {"Fundamental Katalog 5th Edition", "FK5 5366"},
        {"Smithsonian Astrophysical Observation", "SAO 159253"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.46713839),
        dec: Angle.Degrees(-18.51593733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66141",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 37"},
        {"Henry Draper", "HD 117880"},
        {"Hipparcos Number", "HIP 66141"},
        {"Geneva Identification System", "GEN# +1.00117880"},
        {"Smithsonian Astrophysical Observation", "SAO 158006"},
        {"Wilson Evans Batten Catalogue", "WEB 11688"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.37441246),
        dec: Angle.Degrees(-18.51474200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24827",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3910 B"},
        {"Henry Draper", "HD 34797"},
        {"Hipparcos Number", "HIP 24827"},
        {"Geneva Identification System", "GEN# +1.00034797"},
        {"Renson", "Renson 8880"},
        {"Smithsonian Astrophysical Observation", "SAO 150336"},
        {"Wilson Evans Batten Catalogue", "WEB 4804"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.82629842),
        dec: Angle.Degrees(-18.50958286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4019",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 703 AB"},
        {"Henry Draper", "HD 4966"},
        {"Hipparcos Number", "HIP 4019"},
        {"Smithsonian Astrophysical Observation", "SAO 147480"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.87784782),
        dec: Angle.Degrees(-18.50767319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224680"},
        {"Hipparcos Number", "HIP 118315"},
        {"Smithsonian Astrophysical Observation", "SAO 165986"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.95908083),
        dec: Angle.Degrees(-18.50728780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66222"},
        {"Hipparcos Number", "HIP 39281"},
        {"Smithsonian Astrophysical Observation", "SAO 153735"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.48463373),
        dec: Angle.Degrees(-18.50716598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20045"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.48066014),
        dec: Angle.Degrees(-18.50708380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19022"},
        {"Hipparcos Number", "HIP 14198"},
        {"Smithsonian Astrophysical Observation", "SAO 148736"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.77737024),
        dec: Angle.Degrees(-18.50622061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4875"},
        {"Hipparcos Number", "HIP 3948"},
        {"Smithsonian Astrophysical Observation", "SAO 147473"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.66657116),
        dec: Angle.Degrees(-18.50583972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211991"},
        {"Hipparcos Number", "HIP 110379"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.35030698),
        dec: Angle.Degrees(-18.50578424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110780"},
        {"Hipparcos Number", "HIP 62174"},
        {"Smithsonian Astrophysical Observation", "SAO 157481"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.12073036),
        dec: Angle.Degrees(-18.50096289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123618"},
        {"Hipparcos Number", "HIP 69128"},
        {"Geneva Identification System", "GEN# +1.00123618"},
        {"Smithsonian Astrophysical Observation", "SAO 158384"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.25472493),
        dec: Angle.Degrees(-18.50095144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54742",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8086 AB"},
        {"Henry Draper", "HD 97411"},
        {"Hipparcos Number", "HIP 54742"},
        {"Geneva Identification System", "GEN# +1.00097411"},
        {"Smithsonian Astrophysical Observation", "SAO 156528"},
    },
    visualMagnitude: 6.11,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.12660137),
        dec: Angle.Degrees(-18.49980038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59075"},
        {"Hipparcos Number", "HIP 36227"},
        {"Geneva Identification System", "GEN# +1.00059075"},
        {"Smithsonian Astrophysical Observation", "SAO 152906"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.90413126),
        dec: Angle.Degrees(-18.49660863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42342"},
        {"Hipparcos Number", "HIP 29179"},
        {"Smithsonian Astrophysical Observation", "SAO 151174"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.33526785),
        dec: Angle.Degrees(-18.49654012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114362"},
        {"Hipparcos Number", "HIP 64266"},
        {"Smithsonian Astrophysical Observation", "SAO 157764"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58363486),
        dec: Angle.Degrees(-18.49579742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94866"},
        {"Hipparcos Number", "HIP 53518"},
        {"Smithsonian Astrophysical Observation", "SAO 156346"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.22104965),
        dec: Angle.Degrees(-18.49239243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9755"},
        {"Hipparcos Number", "HIP 7385"},
        {"Smithsonian Astrophysical Observation", "SAO 147892"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.78877571),
        dec: Angle.Degrees(-18.49212662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59074"},
        {"Hipparcos Number", "HIP 36225"},
        {"Celescope Catalog", "CEL 1862"},
        {"Geneva Identification System", "GEN# +1.00059074"},
        {"Smithsonian Astrophysical Observation", "SAO 152905"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.89369829),
        dec: Angle.Degrees(-18.49187627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151010"},
        {"Hipparcos Number", "HIP 82035"},
        {"Geneva Identification System", "GEN# +1.00151010"},
        {"Smithsonian Astrophysical Observation", "SAO 160079"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.36673190),
        dec: Angle.Degrees(-18.48908841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138325"},
        {"Hipparcos Number", "HIP 76057"},
        {"Smithsonian Astrophysical Observation", "SAO 159322"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.99319349),
        dec: Angle.Degrees(-18.48643467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109344",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15663 AB"},
        {"Henry Draper", "HD 210198"},
        {"Hipparcos Number", "HIP 109344"},
        {"Geneva Identification System", "GEN# +1.00210198J"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.27587903),
        dec: Angle.Degrees(-18.48494030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130194"},
        {"Hipparcos Number", "HIP 72319"},
        {"Smithsonian Astrophysical Observation", "SAO 158803"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.83904807),
        dec: Angle.Degrees(-18.48446886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7488 AB"},
        {"Henry Draper", "HD 83973"},
        {"Hipparcos Number", "HIP 47537"},
        {"Smithsonian Astrophysical Observation", "SAO 155402"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.37477749),
        dec: Angle.Degrees(-18.48349506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194394"},
        {"Hipparcos Number", "HIP 100770"},
        {"Smithsonian Astrophysical Observation", "SAO 163559"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.47489009),
        dec: Angle.Degrees(-18.48269283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11133"},
        {"Hipparcos Number", "HIP 8460"},
        {"Geneva Identification System", "GEN# +1.00011133"},
        {"Smithsonian Astrophysical Observation", "SAO 148030"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.27334457),
        dec: Angle.Degrees(-18.47734287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43429"},
        {"Hipparcos Number", "HIP 29692"},
        {"Geneva Identification System", "GEN# +1.00043429"},
        {"Smithsonian Astrophysical Observation", "SAO 151274"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.82379533),
        dec: Angle.Degrees(-18.47701325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142986"},
        {"Hipparcos Number", "HIP 78219"},
        {"Smithsonian Astrophysical Observation", "SAO 159610"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.59489908),
        dec: Angle.Degrees(-18.47595405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32435"},
        {"Hipparcos Number", "HIP 23456"},
        {"Smithsonian Astrophysical Observation", "SAO 150095"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.62747348),
        dec: Angle.Degrees(-18.47389853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21162"},
        {"Hipparcos Number", "HIP 15865"},
        {"Smithsonian Astrophysical Observation", "SAO 148945"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.08998026),
        dec: Angle.Degrees(-18.47341939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2066"},
        {"Hipparcos Number", "HIP 1962"},
        {"Geneva Identification System", "GEN# +1.00002066"},
        {"Smithsonian Astrophysical Observation", "SAO 147258"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.20681977),
        dec: Angle.Degrees(-18.47171868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217608"},
        {"Hipparcos Number", "HIP 113744"},
        {"Smithsonian Astrophysical Observation", "SAO 165448"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52910525),
        dec: Angle.Degrees(-18.46741515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21861"},
        {"Hipparcos Number", "HIP 16364"},
        {"Smithsonian Astrophysical Observation", "SAO 149002"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.70463376),
        dec: Angle.Degrees(-18.46603657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61183"},
        {"Hipparcos Number", "HIP 37097"},
        {"Smithsonian Astrophysical Observation", "SAO 153163"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.34672335),
        dec: Angle.Degrees(-18.46586947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167771"},
        {"Hipparcos Number", "HIP 89630"},
        {"Geneva Identification System", "GEN# +1.00167771"},
        {"Smithsonian Astrophysical Observation", "SAO 161267"},
        {"Wilson Evans Batten Catalogue", "WEB 15267"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.36898577),
        dec: Angle.Degrees(-18.46344703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49771"},
        {"Hipparcos Number", "HIP 32699"},
        {"Smithsonian Astrophysical Observation", "SAO 151969"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31893823),
        dec: Angle.Degrees(-18.46114233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24471"},
        {"Hipparcos Number", "HIP 18159"},
        {"Smithsonian Astrophysical Observation", "SAO 149227"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.23793878),
        dec: Angle.Degrees(-18.45955771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150668"},
        {"Hipparcos Number", "HIP 81868"},
        {"Smithsonian Astrophysical Observation", "SAO 160059"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.81815156),
        dec: Angle.Degrees(-18.45828768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148184"},
        {"Hipparcos Number", "HIP 80569"},
        {"Fundamental Katalog 5th Edition", "FK5 3298"},
        {"Geneva Identification System", "GEN# +1.00148184"},
        {"Smithsonian Astrophysical Observation", "SAO 159918"},
        {"Wilson Evans Batten Catalogue", "WEB 13630"},
    },
    visualMagnitude: 4.22,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.75599294),
        dec: Angle.Degrees(-18.45619698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139394"},
        {"Hipparcos Number", "HIP 76590"},
        {"Smithsonian Astrophysical Observation", "SAO 159405"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.62892558),
        dec: Angle.Degrees(-18.44844089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17966"},
        {"Hipparcos Number", "HIP 13415"},
        {"Smithsonian Astrophysical Observation", "SAO 148650"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.18590462),
        dec: Angle.Degrees(-18.44663486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157546"},
        {"Hipparcos Number", "HIP 85195"},
        {"Fundamental Katalog 5th Edition", "FK5 3382"},
        {"Geneva Identification System", "GEN# +1.00157546"},
        {"Smithsonian Astrophysical Observation", "SAO 160523"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.15429357),
        dec: Angle.Degrees(-18.44574264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133011"},
        {"Hipparcos Number", "HIP 73606"},
        {"Smithsonian Astrophysical Observation", "SAO 158987"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.68536697),
        dec: Angle.Degrees(-18.44450849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73824"},
        {"Hipparcos Number", "HIP 42494"},
        {"Smithsonian Astrophysical Observation", "SAO 154512"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.94483558),
        dec: Angle.Degrees(-18.44364074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205674"},
        {"Hipparcos Number", "HIP 106741"},
        {"Geneva Identification System", "GEN# +1.00205674"},
        {"Smithsonian Astrophysical Observation", "SAO 164524"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.33782238),
        dec: Angle.Degrees(-18.44092406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21348"},
        {"Hipparcos Number", "HIP 16002"},
        {"Geneva Identification System", "GEN# +1.00021348"},
        {"Smithsonian Astrophysical Observation", "SAO 148956"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51950783),
        dec: Angle.Degrees(-18.44057898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141188"},
        {"Hipparcos Number", "HIP 77422"},
        {"Smithsonian Astrophysical Observation", "SAO 159505"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09033458),
        dec: Angle.Degrees(-18.43884992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20068"},
        {"Hipparcos Number", "HIP 14965"},
        {"Smithsonian Astrophysical Observation", "SAO 148838"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.22982941),
        dec: Angle.Degrees(-18.43862710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113290"},
        {"Hipparcos Number", "HIP 63662"},
        {"Smithsonian Astrophysical Observation", "SAO 157674"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.71652347),
        dec: Angle.Degrees(-18.43825416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154766"},
        {"Hipparcos Number", "HIP 83850"},
    },
    visualMagnitude: 9.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.03666429),
        dec: Angle.Degrees(-18.43756692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141937"},
        {"Hipparcos Number", "HIP 77740"},
        {"Geneva Identification System", "GEN# +1.00141937"},
        {"Smithsonian Astrophysical Observation", "SAO 159551"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.07286532),
        dec: Angle.Degrees(-18.43612342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18499"},
        {"Hipparcos Number", "HIP 13817"},
        {"Smithsonian Astrophysical Observation", "SAO 148687"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.46274680),
        dec: Angle.Degrees(-18.43588176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105491"},
        {"Hipparcos Number", "HIP 59217"},
        {"Geneva Identification System", "GEN# +1.00105491"},
        {"Smithsonian Astrophysical Observation", "SAO 157103"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.17891524),
        dec: Angle.Degrees(-18.43540371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55933"},
        {"Hipparcos Number", "HIP 34989"},
        {"Celescope Catalog", "CEL 1696"},
        {"Smithsonian Astrophysical Observation", "SAO 152601"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.58713391),
        dec: Angle.Degrees(-18.43528493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24497"},
        {"Hipparcos Number", "HIP 18173"},
        {"Fundamental Katalog 5th Edition", "FK5 2276"},
        {"Geneva Identification System", "GEN# +1.00024497"},
        {"Smithsonian Astrophysical Observation", "SAO 149229"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.30386773),
        dec: Angle.Degrees(-18.43444969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59674"},
        {"Hipparcos Number", "HIP 36473"},
        {"Celescope Catalog", "CEL 1892"},
        {"Geneva Identification System", "GEN# +1.00059674"},
        {"Smithsonian Astrophysical Observation", "SAO 152974"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.57668226),
        dec: Angle.Degrees(-18.43217663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1160"},
        {"Smithsonian Astrophysical Observation", "SAO 147166"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.61622070),
        dec: Angle.Degrees(-18.43147408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192736"},
        {"Hipparcos Number", "HIP 99984"},
        {"Smithsonian Astrophysical Observation", "SAO 163412"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.25126780),
        dec: Angle.Degrees(-18.43143269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124574"},
        {"Hipparcos Number", "HIP 69608"},
        {"Geneva Identification System", "GEN# +1.00124574"},
        {"Smithsonian Astrophysical Observation", "SAO 158446"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.69240134),
        dec: Angle.Degrees(-18.43037929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135208"},
        {"Hipparcos Number", "HIP 74593"},
        {"Geneva Identification System", "GEN# +1.00135208A"},
        {"Smithsonian Astrophysical Observation", "SAO 159118"},
        {"Wilson Evans Batten Catalogue", "WEB 12730"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61746865),
        dec: Angle.Degrees(-18.42848104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13816"},
    },
    visualMagnitude: 11.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.46164348),
        dec: Angle.Degrees(-18.42673817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26529"},
        {"Hipparcos Number", "HIP 19535"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.77185410),
        dec: Angle.Degrees(-18.42666551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115931"},
        {"Hipparcos Number", "HIP 65111"},
        {"Smithsonian Astrophysical Observation", "SAO 157873"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.15189365),
        dec: Angle.Degrees(-18.42458587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3217"},
        {"Hipparcos Number", "HIP 2769"},
        {"Geneva Identification System", "GEN# +1.00003217"},
        {"Smithsonian Astrophysical Observation", "SAO 147347"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.82392582),
        dec: Angle.Degrees(-18.42402480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87979"},
        {"Hipparcos Number", "HIP 49666"},
        {"Geneva Identification System", "GEN# +1.00087979"},
        {"Smithsonian Astrophysical Observation", "SAO 155756"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.08730617),
        dec: Angle.Degrees(-18.42015613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82430"},
        {"Hipparcos Number", "HIP 46722"},
        {"Smithsonian Astrophysical Observation", "SAO 155255"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.86121637),
        dec: Angle.Degrees(-18.41708187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16082 AB"},
        {"Henry Draper", "HD 213923"},
        {"Hipparcos Number", "HIP 111477"},
        {"Smithsonian Astrophysical Observation", "SAO 165174"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.79007536),
        dec: Angle.Degrees(-18.41634460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7594"},
        {"Hipparcos Number", "HIP 5892"},
        {"Geneva Identification System", "GEN# +1.00007594"},
        {"Smithsonian Astrophysical Observation", "SAO 147698"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.92687040),
        dec: Angle.Degrees(-18.41613386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22097"},
        {"Hipparcos Number", "HIP 16546"},
        {"Smithsonian Astrophysical Observation", "SAO 149030"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.27010298),
        dec: Angle.Degrees(-18.41464397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99931"},
        {"Hipparcos Number", "HIP 56082"},
        {"Smithsonian Astrophysical Observation", "SAO 156712"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.42724635),
        dec: Angle.Degrees(-18.41317060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86402",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 43"},
        {"Henry Draper", "HD 160186"},
        {"Hipparcos Number", "HIP 86402"},
        {"Geneva Identification System", "GEN# +1.00160186"},
        {"Smithsonian Astrophysical Observation", "SAO 160720"},
        {"Wilson Evans Batten Catalogue", "WEB 14578"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.82503112),
        dec: Angle.Degrees(-18.41148920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126681"},
        {"Hipparcos Number", "HIP 70681"},
        {"Cincinnati Publication", "Ci 18 1898"},
        {"Geneva Identification System", "GEN# +1.00126681"},
        {"Smithsonian Astrophysical Observation", "SAO 158574"},
        {"Wilson Evans Batten Catalogue", "WEB 12246"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.85397557),
        dec: Angle.Degrees(-18.41047531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58515"},
        {"Geneva Identification System", "GEN# -0.01703526"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.00184199),
        dec: Angle.Degrees(-18.40806758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186937"},
        {"Hipparcos Number", "HIP 97409"},
        {"Geneva Identification System", "GEN# +1.00186937"},
        {"Smithsonian Astrophysical Observation", "SAO 162993"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.97317815),
        dec: Angle.Degrees(-18.40429106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90806",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11411 A"},
        {"Henry Draper", "HD 170680"},
        {"Hipparcos Number", "HIP 90806"},
        {"Geneva Identification System", "GEN# +1.00170680"},
        {"Smithsonian Astrophysical Observation", "SAO 161564"},
        {"Wilson Evans Batten Catalogue", "WEB 15560"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.85958633),
        dec: Angle.Degrees(-18.40264541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8152"},
        {"Smithsonian Astrophysical Observation", "SAO 147995"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.20987223),
        dec: Angle.Degrees(-18.40063824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107574"},
        {"Hipparcos Number", "HIP 60299"},
        {"Fundamental Katalog 5th Edition", "FK5 5092"},
        {"Geneva Identification System", "GEN# +1.00107574"},
        {"Renson", "Renson 31180"},
        {"Smithsonian Astrophysical Observation", "SAO 157237"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.46647100),
        dec: Angle.Degrees(-18.40006597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30420"},
        {"Hipparcos Number", "HIP 22227"},
        {"Geneva Identification System", "GEN# +1.00030420"},
        {"Smithsonian Astrophysical Observation", "SAO 149879"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.70954729),
        dec: Angle.Degrees(-18.39929236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65810"},
        {"Hipparcos Number", "HIP 39095"},
        {"Fundamental Katalog 5th Edition", "FK5 1212"},
        {"Geneva Identification System", "GEN# +1.00065810"},
        {"Smithsonian Astrophysical Observation", "SAO 153687"},
        {"Wilson Evans Batten Catalogue", "WEB 7667"},
    },
    visualMagnitude: 4.61,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.96689649),
        dec: Angle.Degrees(-18.39914242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48757"},
        {"Hipparcos Number", "HIP 32259"},
        {"Smithsonian Astrophysical Observation", "SAO 151859"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04521933),
        dec: Angle.Degrees(-18.39857548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195734"},
        {"Hipparcos Number", "HIP 101448"},
        {"Smithsonian Astrophysical Observation", "SAO 163679"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.40720914),
        dec: Angle.Degrees(-18.39608058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67696"},
        {"Hipparcos Number", "HIP 39870"},
        {"Renson", "Renson 18675"},
        {"Smithsonian Astrophysical Observation", "SAO 153882"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.16402557),
        dec: Angle.Degrees(-18.39594135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142359"},
        {"Hipparcos Number", "HIP 77926"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.71533425),
        dec: Angle.Degrees(-18.39526752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31667"},
        {"Hipparcos Number", "HIP 23021"},
        {"Geneva Identification System", "GEN# +1.00031667"},
        {"Smithsonian Astrophysical Observation", "SAO 150018"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.26064559),
        dec: Angle.Degrees(-18.39371916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20502"},
        {"Hipparcos Number", "HIP 15303"},
        {"Smithsonian Astrophysical Observation", "SAO 148882"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.35131142),
        dec: Angle.Degrees(-18.39367472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205527"},
        {"Hipparcos Number", "HIP 106673"},
        {"Geneva Identification System", "GEN# +1.00205527"},
        {"Smithsonian Astrophysical Observation", "SAO 164508"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.09268414),
        dec: Angle.Degrees(-18.39210811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219773"},
        {"Hipparcos Number", "HIP 115081"},
        {"Smithsonian Astrophysical Observation", "SAO 165618"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.63584644),
        dec: Angle.Degrees(-18.39091139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72379"},
        {"Hipparcos Number", "HIP 41850"},
        {"Geneva Identification System", "GEN# +1.00072379"},
        {"Smithsonian Astrophysical Observation", "SAO 154363"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.99643766),
        dec: Angle.Degrees(-18.39014218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207439"},
        {"Hipparcos Number", "HIP 107724"},
        {"Geneva Identification System", "GEN# +1.00207439"},
        {"Renson", "Renson 57716"},
        {"Smithsonian Astrophysical Observation", "SAO 164674"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.33268239),
        dec: Angle.Degrees(-18.38653526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34153"},
        {"Hipparcos Number", "HIP 24427"},
        {"Smithsonian Astrophysical Observation", "SAO 150267"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.62076653),
        dec: Angle.Degrees(-18.38513413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81999"},
        {"Hipparcos Number", "HIP 46479"},
        {"Smithsonian Astrophysical Observation", "SAO 155222"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.19330537),
        dec: Angle.Degrees(-18.38299754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103785"},
        {"Hipparcos Number", "HIP 58279"},
        {"Smithsonian Astrophysical Observation", "SAO 157004"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.28276560),
        dec: Angle.Degrees(-18.38276130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166524"},
        {"Hipparcos Number", "HIP 89158"},
        {"Geneva Identification System", "GEN# +1.00166524J"},
    },
    visualMagnitude: 9.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94496683),
        dec: Angle.Degrees(-18.38120214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102433"},
        {"Hipparcos Number", "HIP 57522"},
        {"Smithsonian Astrophysical Observation", "SAO 156888"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.84415799),
        dec: Angle.Degrees(-18.38056798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8442",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1447 AB"},
        {"Henry Draper", "HD 11106"},
        {"Hipparcos Number", "HIP 8442"},
        {"Smithsonian Astrophysical Observation", "SAO 148026"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.21253325),
        dec: Angle.Degrees(-18.37746744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21605"},
        {"Hipparcos Number", "HIP 16197"},
        {"Geneva Identification System", "GEN# +1.00021605"},
        {"Smithsonian Astrophysical Observation", "SAO 148977"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.16832664),
        dec: Angle.Degrees(-18.37675360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67213"},
        {"Hipparcos Number", "HIP 39658"},
        {"Smithsonian Astrophysical Observation", "SAO 153837"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.57204731),
        dec: Angle.Degrees(-18.37313242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149775"},
        {"Hipparcos Number", "HIP 81406"},
        {"Smithsonian Astrophysical Observation", "SAO 160010"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.39389520),
        dec: Angle.Degrees(-18.37101976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219085"},
        {"Hipparcos Number", "HIP 114630"},
        {"Geneva Identification System", "GEN# +1.00219085"},
        {"Smithsonian Astrophysical Observation", "SAO 165562"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31854560),
        dec: Angle.Degrees(-18.36948604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171012"},
        {"Hipparcos Number", "HIP 90950"},
        {"Geneva Identification System", "GEN# +1.00171012"},
        {"Smithsonian Astrophysical Observation", "SAO 161592"},
        {"Wilson Evans Batten Catalogue", "WEB 15599"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.29207372),
        dec: Angle.Degrees(-18.36836719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25436"},
        {"Hipparcos Number", "HIP 18809"},
        {"Geneva Identification System", "GEN# +1.00025436"},
        {"Smithsonian Astrophysical Observation", "SAO 149324"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.45884724),
        dec: Angle.Degrees(-18.36747398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216802"},
        {"Hipparcos Number", "HIP 113261"},
        {"Smithsonian Astrophysical Observation", "SAO 165387"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.03481026),
        dec: Angle.Degrees(-18.36744804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131729"},
        {"Hipparcos Number", "HIP 73061"},
        {"Geneva Identification System", "GEN# +1.00131729"},
        {"Smithsonian Astrophysical Observation", "SAO 158899"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.96083340),
        dec: Angle.Degrees(-18.36725952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144607"},
        {"Hipparcos Number", "HIP 78984"},
        {"Smithsonian Astrophysical Observation", "SAO 159709"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.83990397),
        dec: Angle.Degrees(-18.36692696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223932"},
        {"Henry Draper 2", "HD 223933"},
        {"Hipparcos Number", "HIP 117824"},
        {"Geneva Identification System", "GEN# +1.00223932"},
        {"Smithsonian Astrophysical Observation", "SAO 165947"},
        {"Wilson Evans Batten Catalogue", "WEB 20727"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.44147381),
        dec: Angle.Degrees(-18.36480593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173406"},
        {"Hipparcos Number", "HIP 92066"},
        {"Geneva Identification System", "GEN# +1.00173406"},
        {"Renson", "Renson 48570"},
        {"Smithsonian Astrophysical Observation", "SAO 161801"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.47180085),
        dec: Angle.Degrees(-18.36404071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58698"},
        {"Hipparcos Number", "HIP 36079"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.51293809),
        dec: Angle.Degrees(-18.36295628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218135"},
        {"Hipparcos Number", "HIP 114042"},
        {"Smithsonian Astrophysical Observation", "SAO 165486"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.41796958),
        dec: Angle.Degrees(-18.36283782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20349"},
        {"Hipparcos Number", "HIP 15194"},
        {"Smithsonian Astrophysical Observation", "SAO 148866"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.95256299),
        dec: Angle.Degrees(-18.36228607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38146"},
        {"Hipparcos Number", "HIP 26918"},
        {"Smithsonian Astrophysical Observation", "SAO 150731"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.71026140),
        dec: Angle.Degrees(-18.36170746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98379"},
        {"Hipparcos Number", "HIP 55248"},
        {"Smithsonian Astrophysical Observation", "SAO 156599"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.72298455),
        dec: Angle.Degrees(-18.36114292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17909"},
        {"Hipparcos Number", "HIP 13368"},
        {"Smithsonian Astrophysical Observation", "SAO 148643"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.99718990),
        dec: Angle.Degrees(-18.36084283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182998"},
        {"Hipparcos Number", "HIP 95713"},
        {"Smithsonian Astrophysical Observation", "SAO 162643"},
        {"Wilson Evans Batten Catalogue", "WEB 16745"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.02191311),
        dec: Angle.Degrees(-18.35928501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12755"},
        {"Smithsonian Astrophysical Observation", "SAO 148574"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.98459244),
        dec: Angle.Degrees(-18.35840619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64133"},
        {"Hipparcos Number", "HIP 38379"},
        {"Smithsonian Astrophysical Observation", "SAO 153506"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.93957555),
        dec: Angle.Degrees(-18.35755411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120727"},
        {"Hipparcos Number", "HIP 67641"},
        {"Renson", "Renson 34764"},
        {"Smithsonian Astrophysical Observation", "SAO 158201"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.88979389),
        dec: Angle.Degrees(-18.35714597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212641"},
        {"Hipparcos Number", "HIP 110735"},
        {"Smithsonian Astrophysical Observation", "SAO 165067"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.51919318),
        dec: Angle.Degrees(-18.35617998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131027"},
        {"Hipparcos Number", "HIP 72702"},
        {"Smithsonian Astrophysical Observation", "SAO 158860"},
        {"Wilson Evans Batten Catalogue", "WEB 12500"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.96380800),
        dec: Angle.Degrees(-18.35532204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15916"},
        {"Hipparcos Number", "HIP 11868"},
        {"Smithsonian Astrophysical Observation", "SAO 148458"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.28289531),
        dec: Angle.Degrees(-18.35515746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14830"},
        {"Hipparcos Number", "HIP 11108"},
        {"Geneva Identification System", "GEN# +1.00014830"},
        {"Smithsonian Astrophysical Observation", "SAO 148366"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.73977990),
        dec: Angle.Degrees(-18.35465998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182926"},
        {"Hipparcos Number", "HIP 95677"},
        {"Geneva Identification System", "GEN# +1.00182926"},
        {"Smithsonian Astrophysical Observation", "SAO 162637"},
        {"Wilson Evans Batten Catalogue", "WEB 16736"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.91704045),
        dec: Angle.Degrees(-18.35075092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102070"},
        {"Hipparcos Number", "HIP 57283"},
        {"Fundamental Katalog 5th Edition", "FK5 1301"},
        {"Geneva Identification System", "GEN# +1.00102070"},
        {"Smithsonian Astrophysical Observation", "SAO 156869"},
        {"Wilson Evans Batten Catalogue", "WEB 10302"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.19066226),
        dec: Angle.Degrees(-18.35061467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204550"},
        {"Hipparcos Number", "HIP 106126"},
        {"Smithsonian Astrophysical Observation", "SAO 164431"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.45896254),
        dec: Angle.Degrees(-18.34961891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58305"},
        {"Hipparcos Number", "HIP 35922"},
        {"Geneva Identification System", "GEN# +1.00058305"},
        {"Smithsonian Astrophysical Observation", "SAO 152827"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.07273245),
        dec: Angle.Degrees(-18.34827383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191287"},
        {"Hipparcos Number", "HIP 99333"},
        {"Renson", "Renson 53290"},
        {"Smithsonian Astrophysical Observation", "SAO 163301"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.42493159),
        dec: Angle.Degrees(-18.34663138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77237"},
        {"Hipparcos Number", "HIP 44258"},
        {"Smithsonian Astrophysical Observation", "SAO 154833"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.19607481),
        dec: Angle.Degrees(-18.34630678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10066"},
        {"Smithsonian Astrophysical Observation", "SAO 148243"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39052316),
        dec: Angle.Degrees(-18.34466010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187823"},
        {"Hipparcos Number", "HIP 97811"},
        {"Smithsonian Astrophysical Observation", "SAO 163071"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.14305438),
        dec: Angle.Degrees(-18.34334370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193864"},
        {"Hipparcos Number", "HIP 100533"},
        {"Geneva Identification System", "GEN# +1.00193864"},
        {"Smithsonian Astrophysical Observation", "SAO 163510"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.78257130),
        dec: Angle.Degrees(-18.34242151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145100"},
        {"Hipparcos Number", "HIP 79203"},
        {"Geneva Identification System", "GEN# +1.00145100"},
        {"Smithsonian Astrophysical Observation", "SAO 159745"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.48046789),
        dec: Angle.Degrees(-18.34045197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159086"},
        {"Hipparcos Number", "HIP 85918"},
        {"Geneva Identification System", "GEN# +1.00159086"},
        {"Smithsonian Astrophysical Observation", "SAO 160635"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.36250490),
        dec: Angle.Degrees(-18.33974577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36922"},
        {"Hipparcos Number", "HIP 26119"},
        {"Smithsonian Astrophysical Observation", "SAO 150577"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.55728177),
        dec: Angle.Degrees(-18.33853819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67761"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22350293),
        dec: Angle.Degrees(-18.33772485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53091"},
        {"Hipparcos Number", "HIP 33975"},
        {"Celescope Catalog", "CEL 1531"},
        {"Smithsonian Astrophysical Observation", "SAO 152290"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.74840356),
        dec: Angle.Degrees(-18.33589507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139183"},
        {"Hipparcos Number", "HIP 76480"},
        {"Smithsonian Astrophysical Observation", "SAO 159385"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.30572754),
        dec: Angle.Degrees(-18.33502877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94046"},
        {"Hipparcos Number", "HIP 53037"},
        {"Geneva Identification System", "GEN# +1.00094046"},
        {"Smithsonian Astrophysical Observation", "SAO 156271"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.77507536),
        dec: Angle.Degrees(-18.33222979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6452 A"},
        {"Henry Draper", "HD 64611"},
        {"Hipparcos Number", "HIP 38591"},
        {"Smithsonian Astrophysical Observation", "SAO 153563"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.52993653),
        dec: Angle.Degrees(-18.33103329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29465"},
        {"Hipparcos Number", "HIP 21561"},
        {"Smithsonian Astrophysical Observation", "SAO 149773"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.43457404),
        dec: Angle.Degrees(-18.33077391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201494"},
        {"Hipparcos Number", "HIP 104540"},
        {"Fundamental Katalog 5th Edition", "FK5 5866"},
        {"Smithsonian Astrophysical Observation", "SAO 164192"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.63512609),
        dec: Angle.Degrees(-18.33072036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78702"},
        {"Hipparcos Number", "HIP 44923"},
        {"Geneva Identification System", "GEN# +1.00078702"},
        {"Renson", "Renson 22310"},
        {"Smithsonian Astrophysical Observation", "SAO 154950"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.26770246),
        dec: Angle.Degrees(-18.32859911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19625"},
        {"Smithsonian Astrophysical Observation", "SAO 149454"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.07680136),
        dec: Angle.Degrees(-18.32806241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74161"},
        {"Hipparcos Number", "HIP 42665"},
        {"Smithsonian Astrophysical Observation", "SAO 154553"},
    },
    visualMagnitude: 8.92,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.43727938),
        dec: Angle.Degrees(-18.32725982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95384"},
        {"Hipparcos Number", "HIP 53809"},
        {"Geneva Identification System", "GEN# +1.00095384"},
        {"Smithsonian Astrophysical Observation", "SAO 156389"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.14112824),
        dec: Angle.Degrees(-18.32487936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193455"},
        {"Hipparcos Number", "HIP 100348"},
        {"Smithsonian Astrophysical Observation", "SAO 163479"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.25510936),
        dec: Angle.Degrees(-18.32390548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51778"},
        {"Smithsonian Astrophysical Observation", "SAO 156077"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70410006),
        dec: Angle.Degrees(-18.32359006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183499"},
        {"Hipparcos Number", "HIP 95942"},
        {"Smithsonian Astrophysical Observation", "SAO 162699"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.67106518),
        dec: Angle.Degrees(-18.32348842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6399"},
        {"Hipparcos Number", "HIP 5061"},
        {"Smithsonian Astrophysical Observation", "SAO 147595"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.18226197),
        dec: Angle.Degrees(-18.32173861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99007"},
        {"Hipparcos Number", "HIP 55608"},
        {"Smithsonian Astrophysical Observation", "SAO 156648"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.89016740),
        dec: Angle.Degrees(-18.32009565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49770"},
        {"Hipparcos Number", "HIP 32695"},
        {"Smithsonian Astrophysical Observation", "SAO 151967"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.31618190),
        dec: Angle.Degrees(-18.31946177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85130"},
        {"Hipparcos Number", "HIP 48194"},
        {"Smithsonian Astrophysical Observation", "SAO 155516"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.37126660),
        dec: Angle.Degrees(-18.31906746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13048",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2138 AB"},
        {"Henry Draper", "HD 17474"},
        {"Hipparcos Number", "HIP 13048"},
        {"Smithsonian Astrophysical Observation", "SAO 148610"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.91099128),
        dec: Angle.Degrees(-18.31738325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67997"},
        {"Hipparcos Number", "HIP 39983"},
        {"Smithsonian Astrophysical Observation", "SAO 153910"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.48510123),
        dec: Angle.Degrees(-18.31481931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89167"},
        {"Hipparcos Number", "HIP 50337"},
        {"Smithsonian Astrophysical Observation", "SAO 155868"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.18590658),
        dec: Angle.Degrees(-18.31133507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115617"},
        {"Hipparcos Number", "HIP 64924"},
        {"Cincinnati Publication", "Ci 20 769"},
        {"Fundamental Katalog 5th Edition", "FK5 1345"},
        {"Geneva Identification System", "GEN# +1.00115617"},
        {"Smithsonian Astrophysical Observation", "SAO 157844"},
        {"Wilson Evans Batten Catalogue", "WEB 11474"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.60405000),
        dec: Angle.Degrees(-18.30861062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1069.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1063.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181645"},
        {"Hipparcos Number", "HIP 95188"},
        {"Geneva Identification System", "GEN# +1.00181645"},
        {"Smithsonian Astrophysical Observation", "SAO 162521"},
        {"Wilson Evans Batten Catalogue", "WEB 16629"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.46180286),
        dec: Angle.Degrees(-18.30816237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190642"},
        {"Hipparcos Number", "HIP 99042"},
        {"Geneva Identification System", "GEN# +1.00190642"},
        {"Smithsonian Astrophysical Observation", "SAO 163264"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.62252879),
        dec: Angle.Degrees(-18.30790174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1374"},
        {"Geneva Identification System", "GEN# -0.01900027"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.29981419),
        dec: Angle.Degrees(-18.30585823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155909"},
        {"Hipparcos Number", "HIP 84390"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.80000907),
        dec: Angle.Degrees(-18.30579530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217515"},
        {"Hipparcos Number", "HIP 113678"},
        {"Geneva Identification System", "GEN# +1.00217515"},
        {"Smithsonian Astrophysical Observation", "SAO 165441"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.36599749),
        dec: Angle.Degrees(-18.30501879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149364"},
        {"Hipparcos Number", "HIP 81179"},
        {"Geneva Identification System", "GEN# +1.00149364"},
        {"Smithsonian Astrophysical Observation", "SAO 159988"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.71790294),
        dec: Angle.Degrees(-18.30381372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206496"},
        {"Hipparcos Number", "HIP 107210"},
        {"Smithsonian Astrophysical Observation", "SAO 164597"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.72099896),
        dec: Angle.Degrees(-18.30313984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23817"},
        {"Smithsonian Astrophysical Observation", "SAO 150155"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.79044822),
        dec: Angle.Degrees(-18.30216487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53740",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alkes"},
        {"Henry Draper", "HD 95272"},
        {"Hipparcos Number", "HIP 53740"},
        {"Cincinnati Publication", "Ci 20 602"},
        {"Fundamental Katalog 5th Edition", "FK5 1283"},
        {"Geneva Identification System", "GEN# +1.00095272"},
        {"Smithsonian Astrophysical Observation", "SAO 156375"},
        {"Wilson Evans Batten Catalogue", "WEB 9736"},
    },
    visualMagnitude: 4.08,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94478664),
        dec: Angle.Degrees(-18.29909723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -462.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4484"},
        {"Hipparcos Number", "HIP 3663"},
        {"Smithsonian Astrophysical Observation", "SAO 147444"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.71693858),
        dec: Angle.Degrees(-18.29864204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108581"},
        {"Hipparcos Number", "HIP 60866"},
        {"Geneva Identification System", "GEN# +1.00108581"},
        {"Smithsonian Astrophysical Observation", "SAO 157311"},
        {"Wilson Evans Batten Catalogue", "WEB 10833"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.13120324),
        dec: Angle.Degrees(-18.29685881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59320"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.53707245),
        dec: Angle.Degrees(-18.29354762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -267.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40234"},
        {"Hipparcos Number", "HIP 28130"},
        {"Smithsonian Astrophysical Observation", "SAO 150965"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.18997731),
        dec: Angle.Degrees(-18.29298204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223586"},
        {"Hipparcos Number", "HIP 117585"},
        {"Geneva Identification System", "GEN# +1.00223586"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.69406524),
        dec: Angle.Degrees(-18.29234869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163082"},
        {"Hipparcos Number", "HIP 87718"},
        {"Smithsonian Astrophysical Observation", "SAO 160900"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.77553068),
        dec: Angle.Degrees(-18.29205346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161755"},
        {"Hipparcos Number", "HIP 87129"},
        {"Renson", "Renson 45660"},
        {"Smithsonian Astrophysical Observation", "SAO 160825"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.02757269),
        dec: Angle.Degrees(-18.29121481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64132"},
        {"Hipparcos Number", "HIP 38383"},
        {"Smithsonian Astrophysical Observation", "SAO 153508"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.94904847),
        dec: Angle.Degrees(-18.28972619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189465"},
        {"Hipparcos Number", "HIP 98502"},
        {"Smithsonian Astrophysical Observation", "SAO 163175"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.17601699),
        dec: Angle.Degrees(-18.28955547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40971"},
        {"Hipparcos Number", "HIP 28539"},
        {"Smithsonian Astrophysical Observation", "SAO 151031"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.37264463),
        dec: Angle.Degrees(-18.28885724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38313"},
        {"Hipparcos Number", "HIP 27038"},
        {"Smithsonian Astrophysical Observation", "SAO 150749"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.01745414),
        dec: Angle.Degrees(-18.28805428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90606"},
        {"Hipparcos Number", "HIP 51193"},
        {"Geneva Identification System", "GEN# +9.00050025"},
        {"Smithsonian Astrophysical Observation", "SAO 155994"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85574390),
        dec: Angle.Degrees(-18.28679430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215583"},
        {"Hipparcos Number", "HIP 112438"},
        {"Geneva Identification System", "GEN# +1.00215583"},
        {"Smithsonian Astrophysical Observation", "SAO 165286"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.62841550),
        dec: Angle.Degrees(-18.28648864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203553"},
        {"Hipparcos Number", "HIP 105611"},
        {"Smithsonian Astrophysical Observation", "SAO 164357"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.85623512),
        dec: Angle.Degrees(-18.28645030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110683"},
        {"Hipparcos Number", "HIP 62120"},
        {"Smithsonian Astrophysical Observation", "SAO 157474"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.96971768),
        dec: Angle.Degrees(-18.28463434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174053"},
        {"Hipparcos Number", "HIP 92360"},
        {"Smithsonian Astrophysical Observation", "SAO 161864"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.35109932),
        dec: Angle.Degrees(-18.28236492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63413"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.91242172),
        dec: Angle.Degrees(-18.27956030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222847"},
        {"Hipparcos Number", "HIP 117089"},
        {"Fundamental Katalog 5th Edition", "FK5 1621"},
        {"Geneva Identification System", "GEN# +1.00222847"},
        {"Smithsonian Astrophysical Observation", "SAO 165854"},
        {"Wilson Evans Batten Catalogue", "WEB 20640"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.05025914),
        dec: Angle.Degrees(-18.27692862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48288"},
        {"Hipparcos Number", "HIP 32060"},
        {"Smithsonian Astrophysical Observation", "SAO 151804"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.47542538),
        dec: Angle.Degrees(-18.27193188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214145"},
        {"Hipparcos Number", "HIP 111603"},
        {"Smithsonian Astrophysical Observation", "SAO 165188"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.15340546),
        dec: Angle.Degrees(-18.27137135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54602"},
        {"Hipparcos Number", "HIP 34479"},
        {"Celescope Catalog", "CEL 1611"},
        {"Geneva Identification System", "GEN# +1.00054602"},
        {"Smithsonian Astrophysical Observation", "SAO 152459"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18655090),
        dec: Angle.Degrees(-18.27087303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196029"},
        {"Hipparcos Number", "HIP 101582"},
        {"Smithsonian Astrophysical Observation", "SAO 163703"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.81126955),
        dec: Angle.Degrees(-18.26869352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48923"},
        {"Hipparcos Number", "HIP 32352"},
        {"Geneva Identification System", "GEN# +1.00048923"},
        {"Smithsonian Astrophysical Observation", "SAO 151882"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.29172167),
        dec: Angle.Degrees(-18.26824482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73791"},
        {"Hipparcos Number", "HIP 42466"},
        {"Renson", "Renson 20566"},
        {"Smithsonian Astrophysical Observation", "SAO 154508"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.87055446),
        dec: Angle.Degrees(-18.26731238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85835"},
        {"Hipparcos Number", "HIP 48555"},
        {"Geneva Identification System", "GEN# +1.00085835"},
        {"Smithsonian Astrophysical Observation", "SAO 155579"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.53493854),
        dec: Angle.Degrees(-18.26533472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70138"},
        {"Hipparcos Number", "HIP 40805"},
        {"Geneva Identification System", "GEN# +1.00070138"},
        {"Smithsonian Astrophysical Observation", "SAO 154116"},
        {"Wilson Evans Batten Catalogue", "WEB 7918"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.92956181),
        dec: Angle.Degrees(-18.26469009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192922"},
        {"Hipparcos Number", "HIP 100060"},
        {"Smithsonian Astrophysical Observation", "SAO 163426"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.50243575),
        dec: Angle.Degrees(-18.26391063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56677"},
        {"Hipparcos Number", "HIP 35284"},
        {"Smithsonian Astrophysical Observation", "SAO 152670"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.33600033),
        dec: Angle.Degrees(-18.26362774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170656"},
        {"Hipparcos Number", "HIP 90799"},
        {"Geneva Identification System", "GEN# +1.00170656"},
        {"Smithsonian Astrophysical Observation", "SAO 161563"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.84728269),
        dec: Angle.Degrees(-18.26257411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151720"},
        {"Hipparcos Number", "HIP 82364"},
        {"Fundamental Katalog 5th Edition", "FK5 5486"},
        {"Geneva Identification System", "GEN# +1.00151720"},
        {"Smithsonian Astrophysical Observation", "SAO 160117"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.44746598),
        dec: Angle.Degrees(-18.26053426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113719"},
        {"Hipparcos Number", "HIP 63903"},
        {"Geneva Identification System", "GEN# +1.00113719"},
        {"Smithsonian Astrophysical Observation", "SAO 157713"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44080912),
        dec: Angle.Degrees(-18.25960264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174774"},
        {"Hipparcos Number", "HIP 92662"},
        {"Smithsonian Astrophysical Observation", "SAO 161929"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.23350065),
        dec: Angle.Degrees(-18.25918237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32530"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.81599851),
        dec: Angle.Degrees(-18.25888017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 312386"},
        {"Hipparcos Number", "HIP 87967"},
        {"Smithsonian Astrophysical Observation", "SAO 160946"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.53305129),
        dec: Angle.Degrees(-18.25787850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106863"},
        {"Hipparcos Number", "HIP 59922"},
        {"Smithsonian Astrophysical Observation", "SAO 157188"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.37506124),
        dec: Angle.Degrees(-18.25715345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76377"},
        {"Hipparcos Number", "HIP 43800"},
        {"Smithsonian Astrophysical Observation", "SAO 154746"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.81115270),
        dec: Angle.Degrees(-18.25680958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90574"},
        {"Hipparcos Number", "HIP 51170"},
        {"Geneva Identification System", "GEN# +9.00050018"},
        {"Smithsonian Astrophysical Observation", "SAO 155992"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.78347712),
        dec: Angle.Degrees(-18.25610401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136601"},
        {"Hipparcos Number", "HIP 75217"},
        {"Smithsonian Astrophysical Observation", "SAO 159202"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55692557),
        dec: Angle.Degrees(-18.25465656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116428"},
        {"Hipparcos Number", "HIP 65369"},
        {"Geneva Identification System", "GEN# +1.00116428"},
        {"Smithsonian Astrophysical Observation", "SAO 157911"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.95833537),
        dec: Angle.Degrees(-18.25345027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108042"},
        {"Hipparcos Number", "HIP 60558"},
        {"Smithsonian Astrophysical Observation", "SAO 157269"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.21502667),
        dec: Angle.Degrees(-18.25313750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93293"},
    },
    visualMagnitude: 11.75,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.03408297),
        dec: Angle.Degrees(-18.25279389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143163"},
        {"Hipparcos Number", "HIP 78314"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.85998892),
        dec: Angle.Degrees(-18.25256919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109931"},
        {"Hipparcos Number", "HIP 61688"},
        {"Fundamental Katalog 5th Edition", "FK5 3010"},
        {"Geneva Identification System", "GEN# +1.00109931"},
        {"Smithsonian Astrophysical Observation", "SAO 157415"},
        {"Wilson Evans Batten Catalogue", "WEB 10972"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68619461),
        dec: Angle.Degrees(-18.25016480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121447"},
        {"Hipparcos Number", "HIP 68023"},
        {"Geneva Identification System", "GEN# +1.00121447"},
        {"Smithsonian Astrophysical Observation", "SAO 158240"},
        {"Wilson Evans Batten Catalogue", "WEB 11945"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.94579602),
        dec: Angle.Degrees(-18.24905218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153361"},
        {"Hipparcos Number", "HIP 83163"},
        {"Geneva Identification System", "GEN# +1.00153361"},
        {"Smithsonian Astrophysical Observation", "SAO 160216"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.93469985),
        dec: Angle.Degrees(-18.24799544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80240"},
        {"Hipparcos Number", "HIP 45640"},
        {"Smithsonian Astrophysical Observation", "SAO 155076"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.54300678),
        dec: Angle.Degrees(-18.24770070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64000"},
        {"Hipparcos Number", "HIP 38331"},
        {"Smithsonian Astrophysical Observation", "SAO 153488"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77629975),
        dec: Angle.Degrees(-18.24733443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61590"},
        {"Hipparcos Number", "HIP 37285"},
        {"Celescope Catalog", "CEL 1964"},
        {"Geneva Identification System", "GEN# +1.00061590"},
        {"Smithsonian Astrophysical Observation", "SAO 153203"},
    },
    visualMagnitude: 9.74,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.84229735),
        dec: Angle.Degrees(-18.24682801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90936"},
        {"Hipparcos Number", "HIP 51372"},
        {"Geneva Identification System", "GEN# +1.00090936"},
        {"Smithsonian Astrophysical Observation", "SAO 156017"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.38972566),
        dec: Angle.Degrees(-18.24394411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183408"},
        {"Hipparcos Number", "HIP 95893"},
        {"Renson", "Renson 50646"},
        {"Smithsonian Astrophysical Observation", "SAO 162685"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.53562254),
        dec: Angle.Degrees(-18.24312863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144766"},
        {"Hipparcos Number", "HIP 79048"},
        {"Geneva Identification System", "GEN# +1.00144766"},
        {"Smithsonian Astrophysical Observation", "SAO 159724"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.02963685),
        dec: Angle.Degrees(-18.24282071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189927"},
        {"Hipparcos Number", "HIP 98732"},
        {"Smithsonian Astrophysical Observation", "SAO 163211"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.80409901),
        dec: Angle.Degrees(-18.24217030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76376"},
        {"Hipparcos Number", "HIP 43798"},
        {"Fundamental Katalog 5th Edition", "FK5 1231"},
        {"Geneva Identification System", "GEN# +1.00076376"},
        {"Smithsonian Astrophysical Observation", "SAO 154745"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.80174626),
        dec: Angle.Degrees(-18.24120659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208257"},
        {"Hipparcos Number", "HIP 108214"},
        {"Smithsonian Astrophysical Observation", "SAO 164741"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.84180854),
        dec: Angle.Degrees(-18.23990052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10542",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1733 AB"},
        {"Henry Draper", "HD 14001"},
        {"Hipparcos Number", "HIP 10542"},
        {"Geneva Identification System", "GEN# +1.00014001"},
        {"Smithsonian Astrophysical Observation", "SAO 148298"},
        {"Wilson Evans Batten Catalogue", "WEB 2214"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.94236630),
        dec: Angle.Degrees(-18.23787400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47442"},
        {"Henry Draper 2", "HD 47442A"},
        {"Hipparcos Number", "HIP 31700"},
        {"Geneva Identification System", "GEN# +1.00047442"},
        {"Smithsonian Astrophysical Observation", "SAO 151730"},
        {"Wilson Evans Batten Catalogue", "WEB 6359"},
    },
    visualMagnitude: 4.42,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.47260802),
        dec: Angle.Degrees(-18.23745713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60559"},
        {"Cincinnati Publication", "Ci 20 703"},
        {"Geneva Identification System", "GEN# +6.00104685"},
        {"Geneva Identification System 2", "GEN# +6.10010465"},
        {"Geneva Identification System 3", "GEN# +6.10220695"},
        {"Wilson Evans Batten Catalogue", "WEB 10768"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.21595803),
        dec: Angle.Degrees(-18.23667929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1095.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2307.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108458"},
        {"Hipparcos Number", "HIP 60807"},
        {"Smithsonian Astrophysical Observation", "SAO 157297"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.94437236),
        dec: Angle.Degrees(-18.23523173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30659"},
        {"Smithsonian Astrophysical Observation", "SAO 151511"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.64120326),
        dec: Angle.Degrees(-18.23293193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145518"},
        {"Hipparcos Number", "HIP 79377"},
        {"Geneva Identification System", "GEN# +1.00145518"},
        {"Smithsonian Astrophysical Observation", "SAO 159765"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.01012322),
        dec: Angle.Degrees(-18.23254292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184835"},
        {"Hipparcos Number", "HIP 96496"},
        {"Fundamental Katalog 5th Edition", "FK5 3565"},
        {"Geneva Identification System", "GEN# +1.00184835"},
        {"Smithsonian Astrophysical Observation", "SAO 162816"},
        {"Wilson Evans Batten Catalogue", "WEB 16933"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.26389422),
        dec: Angle.Degrees(-18.23101861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19021"},
        {"Hipparcos Number", "HIP 14195"},
        {"Smithsonian Astrophysical Observation", "SAO 148735"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.75956933),
        dec: Angle.Degrees(-18.23071833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92245",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92245"},
        {"Smithsonian Astrophysical Observation", "SAO 161834"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.99340444),
        dec: Angle.Degrees(-18.22868540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2894"},
        {"Hipparcos Number", "HIP 2527"},
        {"Smithsonian Astrophysical Observation", "SAO 147325"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.01946253),
        dec: Angle.Degrees(-18.22193008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8602"},
        {"Hipparcos Number", "HIP 6585"},
        {"Smithsonian Astrophysical Observation", "SAO 147791"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.14841496),
        dec: Angle.Degrees(-18.22148256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159273"},
        {"Hipparcos Number", "HIP 85997"},
        {"Geneva Identification System", "GEN# +1.00159273"},
        {"Smithsonian Astrophysical Observation", "SAO 160649"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.63913843),
        dec: Angle.Degrees(-18.22081287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149914"},
        {"Hipparcos Number", "HIP 81474"},
        {"Geneva Identification System", "GEN# +1.00149914"},
        {"Smithsonian Astrophysical Observation", "SAO 160017"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.61942262),
        dec: Angle.Degrees(-18.22042658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111006"},
        {"Hipparcos Number", "HIP 62329"},
        {"Smithsonian Astrophysical Observation", "SAO 157498"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.59581622),
        dec: Angle.Degrees(-18.21979355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136444"},
        {"Hipparcos Number", "HIP 75137"},
        {"Smithsonian Astrophysical Observation", "SAO 159194"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.32260228),
        dec: Angle.Degrees(-18.21789565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153418"},
        {"Hipparcos Number", "HIP 83203"},
        {"Smithsonian Astrophysical Observation", "SAO 160221"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.06052079),
        dec: Angle.Degrees(-18.21414840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207208"},
        {"Hipparcos Number", "HIP 107610"},
        {"Geneva Identification System", "GEN# +1.00207208"},
        {"Smithsonian Astrophysical Observation", "SAO 164657"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.93676364),
        dec: Angle.Degrees(-18.21302944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179005"},
        {"Hipparcos Number", "HIP 94296"},
        {"Smithsonian Astrophysical Observation", "SAO 162291"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.89685935),
        dec: Angle.Degrees(-18.21192108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100881",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13860 A"},
        {"Henry Draper", "HD 194636"},
        {"Hipparcos Number", "HIP 100881"},
        {"Geneva Identification System", "GEN# +1.00194636"},
        {"Smithsonian Astrophysical Observation", "SAO 163592"},
        {"Wilson Evans Batten Catalogue", "WEB 18226"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.83001454),
        dec: Angle.Degrees(-18.21169433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62167"},
        {"Hipparcos Number", "HIP 37526"},
        {"Smithsonian Astrophysical Observation", "SAO 153271"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.53275696),
        dec: Angle.Degrees(-18.20890276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18921"},
        {"Hipparcos Number", "HIP 14117"},
        {"Fundamental Katalog 5th Edition", "FK5 1084"},
        {"Geneva Identification System", "GEN# +1.00018921"},
        {"Smithsonian Astrophysical Observation", "SAO 148724"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.51055116),
        dec: Angle.Degrees(-18.20766431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14315"},
        {"Hipparcos Number", "HIP 10759"},
        {"Smithsonian Astrophysical Observation", "SAO 148322"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.61156205),
        dec: Angle.Degrees(-18.20743521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14299 A"},
        {"Henry Draper", "HD 198063"},
        {"Hipparcos Number", "HIP 102685"},
        {"Smithsonian Astrophysical Observation", "SAO 163895"},
        {"Wilson Evans Batten Catalogue", "WEB 18612"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10818152),
        dec: Angle.Degrees(-18.20169070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78302"},
        {"Hipparcos Number", "HIP 44733"},
        {"Smithsonian Astrophysical Observation", "SAO 154918"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.72830037),
        dec: Angle.Degrees(-18.20154191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124683"},
        {"Hipparcos Number", "HIP 69658"},
        {"Geneva Identification System", "GEN# +1.00124683"},
        {"Smithsonian Astrophysical Observation", "SAO 158448"},
        {"Wilson Evans Batten Catalogue", "WEB 12129"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.85047098),
        dec: Angle.Degrees(-18.20066197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102681",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14299 B"},
        {"Hipparcos Number", "HIP 102681"},
        {"Smithsonian Astrophysical Observation", "SAO 163894"},
        {"Wilson Evans Batten Catalogue", "WEB 18614"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10401966),
        dec: Angle.Degrees(-18.19994119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186040"},
        {"Hipparcos Number", "HIP 96994"},
        {"Fundamental Katalog 5th Edition", "FK5 5739"},
        {"Smithsonian Astrophysical Observation", "SAO 162919"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.71055087),
        dec: Angle.Degrees(-18.19899944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145899"},
        {"Hipparcos Number", "HIP 79565"},
        {"Smithsonian Astrophysical Observation", "SAO 159795"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.52408097),
        dec: Angle.Degrees(-18.19717201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8597 AB"},
        {"Henry Draper", "HD 109349"},
        {"Hipparcos Number", "HIP 61345"},
        {"Smithsonian Astrophysical Observation", "SAO 157369"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.53969398),
        dec: Angle.Degrees(-18.19502175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51921"},
        {"Hipparcos Number", "HIP 33571"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.63125993),
        dec: Angle.Degrees(-18.19346667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16570"},
        {"Hipparcos Number", "HIP 12343"},
        {"Smithsonian Astrophysical Observation", "SAO 148521"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.73567564),
        dec: Angle.Degrees(-18.19249198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68086"},
        {"Hipparcos Number", "HIP 40017"},
        {"Smithsonian Astrophysical Observation", "SAO 153918"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.58893250),
        dec: Angle.Degrees(-18.19188105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101122"},
        {"Hipparcos Number", "HIP 56746"},
        {"Smithsonian Astrophysical Observation", "SAO 156793"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52079957),
        dec: Angle.Degrees(-18.19185731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105292"},
        {"Hipparcos Number", "HIP 59124"},
        {"Smithsonian Astrophysical Observation", "SAO 157091"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.86644281),
        dec: Angle.Degrees(-18.19080142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42747"},
        {"Hipparcos Number", "HIP 29399"},
        {"Smithsonian Astrophysical Observation", "SAO 151208"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92962305),
        dec: Angle.Degrees(-18.18613020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47668"},
        {"Hipparcos Number", "HIP 31811"},
        {"Fundamental Katalog 5th Edition", "FK5 4605"},
        {"Smithsonian Astrophysical Observation", "SAO 151749"},
        {"Wilson Evans Batten Catalogue", "WEB 6391"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.76493817),
        dec: Angle.Degrees(-18.18582838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83573"},
        {"Hipparcos Number", "HIP 47360"},
        {"Smithsonian Astrophysical Observation", "SAO 155369"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.74373776),
        dec: Angle.Degrees(-18.18371891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74906",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74906"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.62583504),
        dec: Angle.Degrees(-18.18257588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29073"},
        {"Hipparcos Number", "HIP 21279"},
        {"Geneva Identification System", "GEN# +1.00029073"},
        {"Smithsonian Astrophysical Observation", "SAO 149732"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.47899520),
        dec: Angle.Degrees(-18.17979802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7513"},
        {"Hipparcos Number", "HIP 5847"},
        {"Geneva Identification System", "GEN# +1.00007513"},
        {"Smithsonian Astrophysical Observation", "SAO 147693"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75500980),
        dec: Angle.Degrees(-18.17892199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225280"},
        {"Hipparcos Number", "HIP 403"},
        {"Smithsonian Astrophysical Observation", "SAO 147071"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23720433),
        dec: Angle.Degrees(-18.17850304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101473"},
        {"Hipparcos Number", "HIP 56949"},
        {"Smithsonian Astrophysical Observation", "SAO 156826"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.11943047),
        dec: Angle.Degrees(-18.17807862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20321"},
        {"Hipparcos Number", "HIP 15165"},
        {"Geneva Identification System", "GEN# +1.00020321"},
        {"Smithsonian Astrophysical Observation", "SAO 148861"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.87247678),
        dec: Angle.Degrees(-18.17478769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163702"},
        {"Hipparcos Number", "HIP 87975"},
        {"Smithsonian Astrophysical Observation", "SAO 160949"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.56646589),
        dec: Angle.Degrees(-18.17334077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71416"},
        {"Hipparcos Number", "HIP 41409"},
        {"Smithsonian Astrophysical Observation", "SAO 154266"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.70046553),
        dec: Angle.Degrees(-18.17314501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168080"},
        {"Hipparcos Number", "HIP 89736"},
        {"Geneva Identification System", "GEN# +1.00168080"},
        {"Smithsonian Astrophysical Observation", "SAO 161309"},
        {"Wilson Evans Batten Catalogue", "WEB 15299"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.69536237),
        dec: Angle.Degrees(-18.17217603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
