using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_102() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110511"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.80681495),
        dec: Angle.Degrees(+47.44097147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63442",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63442"},
        {"Smithsonian Astrophysical Observation", "SAO 44421"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.01036949),
        dec: Angle.Degrees(+47.44233359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96696"},
        {"Smithsonian Astrophysical Observation", "SAO 48696"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.87296521),
        dec: Angle.Degrees(+47.44691368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114587"},
        {"Smithsonian Astrophysical Observation", "SAO 52792"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.20399011),
        dec: Angle.Degrees(+47.44861619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151689"},
        {"Hipparcos Number", "HIP 82117"},
        {"Geneva Identification System", "GEN# +1.00151689"},
        {"Smithsonian Astrophysical Observation", "SAO 46280"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.62783558),
        dec: Angle.Degrees(+47.44918168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93755"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.37967223),
        dec: Angle.Degrees(+47.44923649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213129"},
        {"Hipparcos Number", "HIP 110921"},
        {"Smithsonian Astrophysical Observation", "SAO 52037"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.09389734),
        dec: Angle.Degrees(+47.44982439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25099"},
        {"Hipparcos Number", "HIP 18782"},
        {"Smithsonian Astrophysical Observation", "SAO 39249"},
        {"Wilson Evans Batten Catalogue", "WEB 3616"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.35858524),
        dec: Angle.Degrees(+47.45042439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208471"},
        {"Hipparcos Number", "HIP 108197"},
        {"Smithsonian Astrophysical Observation", "SAO 51438"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.80119817),
        dec: Angle.Degrees(+47.45055381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99632"},
        {"Hipparcos Number", "HIP 55974"},
        {"Geneva Identification System", "GEN# +1.00099632"},
        {"Renson", "Renson 28680"},
        {"Smithsonian Astrophysical Observation", "SAO 43754"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.05229391),
        dec: Angle.Degrees(+47.45652050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107291"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.98298937),
        dec: Angle.Degrees(+47.46026686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38776"},
        {"Hipparcos Number", "HIP 27591"},
        {"Smithsonian Astrophysical Observation", "SAO 40636"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64056631),
        dec: Angle.Degrees(+47.46105011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8242 AB"},
        {"Hipparcos Number", "HIP 56685"},
        {"Geneva Identification System", "GEN# +0.04801958"},
        {"Wilson Evans Batten Catalogue", "WEB 10194"},
    },
    visualMagnitude: 10.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.35204325),
        dec: Angle.Degrees(+47.46252604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58659"},
        {"Smithsonian Astrophysical Observation", "SAO 44001"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43382806),
        dec: Angle.Degrees(+47.46411054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150843"},
        {"Hipparcos Number", "HIP 81698"},
        {"Geneva Identification System", "GEN# +1.00150843"},
        {"Smithsonian Astrophysical Observation", "SAO 46230"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.33027310),
        dec: Angle.Degrees(+47.46495644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38258"},
        {"Hipparcos Number", "HIP 27278"},
        {"Celescope Catalog", "CEL 965"},
        {"Geneva Identification System", "GEN# +1.00038258"},
        {"Smithsonian Astrophysical Observation", "SAO 40600"},
        {"Wilson Evans Batten Catalogue", "WEB 5360"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.71446966),
        dec: Angle.Degrees(+47.46737620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55299",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8130 AB"},
        {"Henry Draper", "HD 98375"},
        {"Hipparcos Number", "HIP 55299"},
        {"Smithsonian Astrophysical Observation", "SAO 43694"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.87234685),
        dec: Angle.Degrees(+47.47049284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38705"},
        {"Smithsonian Astrophysical Observation", "SAO 42071"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.86266949),
        dec: Angle.Degrees(+47.47195785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119147"},
        {"Hipparcos Number", "HIP 66713"},
        {"Geneva Identification System", "GEN# +1.00119147"},
        {"Smithsonian Astrophysical Observation", "SAO 44706"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.12384932),
        dec: Angle.Degrees(+47.47207238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211974"},
        {"Hipparcos Number", "HIP 110253"},
        {"Smithsonian Astrophysical Observation", "SAO 51884"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.99512435),
        dec: Angle.Degrees(+47.47269122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141970"},
        {"Hipparcos Number", "HIP 77528"},
        {"Geneva Identification System", "GEN# +1.00141970"},
        {"Smithsonian Astrophysical Observation", "SAO 45753"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.45686822),
        dec: Angle.Degrees(+47.47287915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29951"},
        {"Hipparcos Number", "HIP 22106"},
        {"Geneva Identification System", "GEN# +1.00029951"},
        {"Smithsonian Astrophysical Observation", "SAO 39724"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.36557691),
        dec: Angle.Degrees(+47.47643476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108641"},
        {"Hipparcos Number", "HIP 60873"},
        {"Geneva Identification System", "GEN# +1.00108641"},
        {"Smithsonian Astrophysical Observation", "SAO 44194"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.14730546),
        dec: Angle.Degrees(+47.47861552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54981",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8104 AB"},
        {"Aitken 2", "ADS 8104 A"},
        {"Henry Draper", "HD 97773"},
        {"Hipparcos Number", "HIP 54981"},
        {"Smithsonian Astrophysical Observation", "SAO 43659"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.86949179),
        dec: Angle.Degrees(+47.47950834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73636"},
        {"Hipparcos Number", "HIP 42627"},
        {"Geneva Identification System", "GEN# +1.00073636"},
        {"Smithsonian Astrophysical Observation", "SAO 42492"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.31082727),
        dec: Angle.Degrees(+47.48071672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12567"},
        {"Henry Draper", "HD 184242"},
        {"Hipparcos Number", "HIP 96011"},
        {"Renson", "Renson 50840"},
        {"Smithsonian Astrophysical Observation", "SAO 48548"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81823731),
        dec: Angle.Degrees(+47.48127153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88061"},
        {"Smithsonian Astrophysical Observation", "SAO 47109"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.77771206),
        dec: Angle.Degrees(+47.48329505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114926"},
        {"Smithsonian Astrophysical Observation", "SAO 52853"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.18329407),
        dec: Angle.Degrees(+47.53221076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24582"},
        {"Hipparcos Number", "HIP 18460"},
        {"Smithsonian Astrophysical Observation", "SAO 39205"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.16987902),
        dec: Angle.Degrees(+47.48339124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43007"},
        {"Smithsonian Astrophysical Observation", "SAO 42535"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.46758929),
        dec: Angle.Degrees(+47.48415725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10403",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1709 AB"},
        {"Henry Draper", "HD 13594"},
        {"Hipparcos Number", "HIP 10403"},
        {"Geneva Identification System", "GEN# +1.00013594"},
        {"Smithsonian Astrophysical Observation", "SAO 37878"},
        {"Wilson Evans Batten Catalogue", "WEB 2176"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.51053606),
        dec: Angle.Degrees(+47.48438729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199415"},
        {"Hipparcos Number", "HIP 103273"},
        {"Geneva Identification System", "GEN# +1.00199415"},
        {"Smithsonian Astrophysical Observation", "SAO 50234"},
        {"Wilson Evans Batten Catalogue", "WEB 18766"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.82477909),
        dec: Angle.Degrees(+47.48482193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223661"},
        {"Hipparcos Number", "HIP 117647"},
        {"Geneva Identification System", "GEN# +1.00223661"},
        {"Smithsonian Astrophysical Observation", "SAO 53429"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.88927313),
        dec: Angle.Degrees(+47.48778915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58018"},
        {"Smithsonian Astrophysical Observation", "SAO 43942"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.49814546),
        dec: Angle.Degrees(+47.48930025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83856"},
        {"Hipparcos Number", "HIP 47618"},
        {"Smithsonian Astrophysical Observation", "SAO 42988"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.64567320),
        dec: Angle.Degrees(+47.49069246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 763"},
        {"Hipparcos Number", "HIP 980"},
        {"Smithsonian Astrophysical Observation", "SAO 36150"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.02849022),
        dec: Angle.Degrees(+47.49116017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7971 AB"},
        {"Henry Draper", "HD 94399"},
        {"Hipparcos Number", "HIP 53336"},
        {"Smithsonian Astrophysical Observation", "SAO 43516"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.62788265),
        dec: Angle.Degrees(+47.49303609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78243"},
        {"Smithsonian Astrophysical Observation", "SAO 45817"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63701539),
        dec: Angle.Degrees(+47.49435649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214765"},
        {"Hipparcos Number", "HIP 111867"},
        {"Smithsonian Astrophysical Observation", "SAO 52238"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.89151319),
        dec: Angle.Degrees(+47.49573081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115972"},
        {"Smithsonian Astrophysical Observation", "SAO 53081"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.45438115),
        dec: Angle.Degrees(+47.50155330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200406"},
        {"Hipparcos Number", "HIP 103767"},
        {"Geneva Identification System", "GEN# +1.00200406"},
        {"Smithsonian Astrophysical Observation", "SAO 50366"},
        {"Wilson Evans Batten Catalogue", "WEB 18884"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.41107865),
        dec: Angle.Degrees(+47.50182085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135544"},
        {"Hipparcos Number", "HIP 74541"},
        {"Geneva Identification System", "GEN# +6.20034003"},
        {"Smithsonian Astrophysical Observation", "SAO 45442"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47604010),
        dec: Angle.Degrees(+47.50193494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71482"},
        {"Smithsonian Astrophysical Observation", "SAO 45136"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.27063394),
        dec: Angle.Degrees(+47.50247422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78921"},
        {"Geneva Identification System", "GEN# +0.04702298"},
        {"Wilson Evans Batten Catalogue", "WEB 13341"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.66665742),
        dec: Angle.Degrees(+47.50353119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42032"},
        {"Hipparcos Number", "HIP 29318"},
        {"Smithsonian Astrophysical Observation", "SAO 40913"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.73299918),
        dec: Angle.Degrees(+47.50489627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145082"},
        {"Hipparcos Number", "HIP 78946"},
        {"Geneva Identification System", "GEN# +1.00145082"},
        {"Smithsonian Astrophysical Observation", "SAO 45895"},
        {"Wilson Evans Batten Catalogue", "WEB 13344"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.74821720),
        dec: Angle.Degrees(+47.50502320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3446"},
        {"Hipparcos Number", "HIP 2974"},
        {"Smithsonian Astrophysical Observation", "SAO 36525"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46338438),
        dec: Angle.Degrees(+47.50571312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25195"},
        {"Hipparcos Number", "HIP 18838"},
        {"Smithsonian Astrophysical Observation", "SAO 39260"},
        {"Wilson Evans Batten Catalogue", "WEB 3625"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.58441268),
        dec: Angle.Degrees(+47.50664447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117591",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17042 A"},
        {"Henry Draper", "HD 223608"},
        {"Hipparcos Number", "HIP 117591"},
        {"Smithsonian Astrophysical Observation", "SAO 53416"},
        {"Wilson Evans Batten Catalogue", "WEB 20703"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.71579599),
        dec: Angle.Degrees(+47.50789570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30401"},
        {"Hipparcos Number", "HIP 22438"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42496489),
        dec: Angle.Degrees(+47.51156232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20538"},
        {"Hipparcos Number", "HIP 15522"},
        {"Smithsonian Astrophysical Observation", "SAO 38729"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.00553225),
        dec: Angle.Degrees(+47.51192344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174637"},
        {"Hipparcos Number", "HIP 92335"},
        {"Smithsonian Astrophysical Observation", "SAO 47830"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.28292945),
        dec: Angle.Degrees(+47.51583248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103632",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14526 A"},
        {"Henry Draper", "HD 200120"},
        {"Hipparcos Number", "HIP 103632"},
        {"Celescope Catalog", "CEL 5228"},
        {"Fundamental Katalog 5th Edition", "FK5 1551"},
        {"Geneva Identification System", "GEN# +1.00200120A"},
        {"Smithsonian Astrophysical Observation", "SAO 50335"},
        {"Wilson Evans Batten Catalogue", "WEB 18855"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.95645946),
        dec: Angle.Degrees(+47.52094507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84191"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.14896125),
        dec: Angle.Degrees(+47.52208891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46754",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46754"},
    },
    visualMagnitude: 11.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.93835176),
        dec: Angle.Degrees(+47.52256667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82863"},
        {"Hipparcos Number", "HIP 47118"},
        {"Smithsonian Astrophysical Observation", "SAO 42938"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.02733057),
        dec: Angle.Degrees(+47.52426833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19539"},
        {"Hipparcos Number", "HIP 14734"},
        {"Geneva Identification System", "GEN# +5.20200061"},
        {"Smithsonian Astrophysical Observation", "SAO 38618"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.57256861),
        dec: Angle.Degrees(+47.52814182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 416 AB"},
        {"Henry Draper", "HD 2675"},
        {"Hipparcos Number", "HIP 2414"},
        {"Smithsonian Astrophysical Observation", "SAO 36427"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.68983095),
        dec: Angle.Degrees(+47.53000544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114531"},
        {"Smithsonian Astrophysical Observation", "SAO 52781"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.96829435),
        dec: Angle.Degrees(+47.53008351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70428"},
        {"Smithsonian Astrophysical Observation", "SAO 45041"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.11575195),
        dec: Angle.Degrees(+47.53105473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66329"},
        {"Smithsonian Astrophysical Observation", "SAO 44676"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.89691077),
        dec: Angle.Degrees(+47.53224482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103241"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.73972338),
        dec: Angle.Degrees(+47.53381070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183507"},
        {"Hipparcos Number", "HIP 95687"},
        {"Smithsonian Astrophysical Observation", "SAO 48476"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.93957289),
        dec: Angle.Degrees(+47.53684387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91159"},
        {"Hipparcos Number", "HIP 51604"},
        {"Smithsonian Astrophysical Observation", "SAO 43374"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.12232581),
        dec: Angle.Degrees(+47.53886548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98943"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.33276946),
        dec: Angle.Degrees(+47.54044111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188853"},
        {"Hipparcos Number", "HIP 98013"},
        {"Smithsonian Astrophysical Observation", "SAO 48976"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.77161610),
        dec: Angle.Degrees(+47.54097180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209531"},
        {"Hipparcos Number", "HIP 108837"},
        {"Smithsonian Astrophysical Observation", "SAO 51593"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72161797),
        dec: Angle.Degrees(+47.54101573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79308"},
        {"Smithsonian Astrophysical Observation", "SAO 45950"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.78507121),
        dec: Angle.Degrees(+47.54224538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151651"},
        {"Hipparcos Number", "HIP 82113"},
        {"Fundamental Katalog 5th Edition", "FK5 5481"},
        {"Geneva Identification System", "GEN# +1.00151651"},
        {"Smithsonian Astrophysical Observation", "SAO 46278"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.59914140),
        dec: Angle.Degrees(+47.54326571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206523"},
        {"Hipparcos Number", "HIP 107075"},
        {"Smithsonian Astrophysical Observation", "SAO 51182"},
        {"Wilson Evans Batten Catalogue", "WEB 19340"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.29231161),
        dec: Angle.Degrees(+47.54519112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103150"},
        {"Hipparcos Number", "HIP 57918"},
        {"Geneva Identification System", "GEN# +1.00103150"},
        {"Smithsonian Astrophysical Observation", "SAO 43929"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.18995031),
        dec: Angle.Degrees(+47.54662429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57385"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.48143075),
        dec: Angle.Degrees(+47.54743602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116135"},
        {"Smithsonian Astrophysical Observation", "SAO 53119"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.97106841),
        dec: Angle.Degrees(+47.54776192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216329"},
        {"Hipparcos Number", "HIP 112857"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.82272290),
        dec: Angle.Degrees(+47.54834822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98917"},
        {"Smithsonian Astrophysical Observation", "SAO 49164"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.28239697),
        dec: Angle.Degrees(+47.54855689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7372"},
        {"Hipparcos Number", "HIP 5820"},
        {"Geneva Identification System", "GEN# +1.00007372"},
        {"Smithsonian Astrophysical Observation", "SAO 37046"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.67090482),
        dec: Angle.Degrees(+47.54970605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37383"},
        {"Smithsonian Astrophysical Observation", "SAO 41919"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.10677501),
        dec: Angle.Degrees(+47.55127667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77169"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.35946169),
        dec: Angle.Degrees(+47.55231071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144704"},
        {"Hipparcos Number", "HIP 78794"},
        {"Smithsonian Astrophysical Observation", "SAO 45883"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.28761395),
        dec: Angle.Degrees(+47.55707245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68790"},
        {"Hipparcos Number", "HIP 40492"},
        {"Smithsonian Astrophysical Observation", "SAO 42254"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.01041797),
        dec: Angle.Degrees(+47.55984184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79312",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9956 AB"},
        {"Henry Draper", "HD 145873"},
        {"Hipparcos Number", "HIP 79312"},
        {"Smithsonian Astrophysical Observation", "SAO 45953"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.79888083),
        dec: Angle.Degrees(+47.55990797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168066"},
        {"Hipparcos Number", "HIP 89476"},
        {"Geneva Identification System", "GEN# +1.00168066"},
        {"Smithsonian Astrophysical Observation", "SAO 47345"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.89237757),
        dec: Angle.Degrees(+47.56090592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83173"},
        {"Hipparcos Number", "HIP 47270"},
        {"Geneva Identification System", "GEN# +1.00083173"},
        {"Smithsonian Astrophysical Observation", "SAO 42954"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.51282198),
        dec: Angle.Degrees(+47.56127200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23105"},
        {"Hipparcos Number", "HIP 17456"},
        {"Smithsonian Astrophysical Observation", "SAO 39069"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.12555676),
        dec: Angle.Degrees(+47.56411278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75488"},
        {"Hipparcos Number", "HIP 43543"},
        {"Geneva Identification System", "GEN# +1.00075488"},
        {"Smithsonian Astrophysical Observation", "SAO 42578"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.02287501),
        dec: Angle.Degrees(+47.56430319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64144"},
        {"Hipparcos Number", "HIP 38639"},
        {"Fundamental Katalog 5th Edition", "FK5 299"},
        {"Geneva Identification System", "GEN# +1.00064144"},
        {"Smithsonian Astrophysical Observation", "SAO 42058"},
        {"Wilson Evans Batten Catalogue", "WEB 7583"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.67807760),
        dec: Angle.Degrees(+47.56459225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9150"},
        {"Smithsonian Astrophysical Observation", "SAO 37644"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.47873704),
        dec: Angle.Degrees(+47.56470275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90182"},
        {"Hipparcos Number", "HIP 51039"},
        {"Smithsonian Astrophysical Observation", "SAO 43332"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.40406401),
        dec: Angle.Degrees(+47.56740431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24980"},
        {"Hipparcos Number", "HIP 18697"},
        {"Geneva Identification System", "GEN# +1.00024980"},
        {"Smithsonian Astrophysical Observation", "SAO 39238"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.08521563),
        dec: Angle.Degrees(+47.57173703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173415"},
        {"Hipparcos Number", "HIP 91775"},
        {"Geneva Identification System", "GEN# +1.00173415"},
        {"Smithsonian Astrophysical Observation", "SAO 47729"},
        {"Wilson Evans Batten Catalogue", "WEB 15789"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.71086550),
        dec: Angle.Degrees(+47.57514361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22401"},
        {"Hipparcos Number", "HIP 16966"},
        {"Geneva Identification System", "GEN# +5.20201259"},
        {"Renson", "Renson 5690"},
        {"Smithsonian Astrophysical Observation", "SAO 39001"},
        {"Wilson Evans Batten Catalogue", "WEB 3227"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.56484649),
        dec: Angle.Degrees(+47.57704633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224969"},
        {"Hipparcos Number", "HIP 173"},
        {"Geneva Identification System", "GEN# +1.00224969"},
        {"Smithsonian Astrophysical Observation", "SAO 53589"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.54959887),
        dec: Angle.Degrees(+47.57722222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114353"},
        {"Smithsonian Astrophysical Observation", "SAO 52745"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.39493698),
        dec: Angle.Degrees(+47.57888502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199662"},
        {"Hipparcos Number", "HIP 103403"},
        {"Celescope Catalog", "CEL 5217"},
        {"Geneva Identification System", "GEN# +1.00199662"},
        {"Smithsonian Astrophysical Observation", "SAO 50272"},
        {"Wilson Evans Batten Catalogue", "WEB 18802"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.23736311),
        dec: Angle.Degrees(+47.57891002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113349"},
        {"Smithsonian Astrophysical Observation", "SAO 52528"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.33538641),
        dec: Angle.Degrees(+47.57991621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40089"},
        {"Geneva Identification System", "GEN# +6.10140295"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.83553967),
        dec: Angle.Degrees(+47.58133124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162299"},
        {"Hipparcos Number", "HIP 87119"},
        {"Smithsonian Astrophysical Observation", "SAO 46964"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.99736661),
        dec: Angle.Degrees(+47.58394041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70139"},
        {"Smithsonian Astrophysical Observation", "SAO 45006"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.27799780),
        dec: Angle.Degrees(+47.58488146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47003"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.69886959),
        dec: Angle.Degrees(+47.58513991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29630"},
        {"Hipparcos Number", "HIP 21886"},
        {"Smithsonian Astrophysical Observation", "SAO 39696"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.57375138),
        dec: Angle.Degrees(+47.58681364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214223"},
        {"Hipparcos Number", "HIP 111554"},
        {"Smithsonian Astrophysical Observation", "SAO 52172"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.98952980),
        dec: Angle.Degrees(+47.58971594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20726"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.62484239),
        dec: Angle.Degrees(+47.59048486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153206"},
        {"Hipparcos Number", "HIP 82836"},
        {"Smithsonian Astrophysical Observation", "SAO 46375"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.92121334),
        dec: Angle.Degrees(+47.59142007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69616"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.72819927),
        dec: Angle.Degrees(+47.59458448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7214"},
        {"Smithsonian Astrophysical Observation", "SAO 37302"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.23408765),
        dec: Angle.Degrees(+47.59487656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116883"},
        {"Geneva Identification System", "GEN# +0.04604128"},
        {"Smithsonian Astrophysical Observation", "SAO 53278"},
        {"Wilson Evans Batten Catalogue", "WEB 20620"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.37369398),
        dec: Angle.Degrees(+47.59555750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79548",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9976 A"},
        {"Henry Draper", "HD 146386"},
        {"Hipparcos Number", "HIP 79548"},
        {"Geneva Identification System", "GEN# +1.00146386"},
        {"Smithsonian Astrophysical Observation", "SAO 45979"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.48132409),
        dec: Angle.Degrees(+47.59567912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23385"},
        {"Hipparcos Number", "HIP 17644"},
        {"Smithsonian Astrophysical Observation", "SAO 39095"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70692517),
        dec: Angle.Degrees(+47.60391110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54944"},
        {"Hipparcos Number", "HIP 34897"},
        {"Geneva Identification System", "GEN# +1.00054944"},
        {"Smithsonian Astrophysical Observation", "SAO 41625"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.30382505),
        dec: Angle.Degrees(+47.60703083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37868"},
        {"Smithsonian Astrophysical Observation", "SAO 41982"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.43682456),
        dec: Angle.Degrees(+47.60704848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43577"},
        {"Smithsonian Astrophysical Observation", "SAO 42583"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.12214999),
        dec: Angle.Degrees(+47.60905696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162132"},
        {"Hipparcos Number", "HIP 87045"},
        {"Geneva Identification System", "GEN# +1.00162132"},
        {"Renson", "Renson 45760"},
        {"Smithsonian Astrophysical Observation", "SAO 46954"},
        {"Wilson Evans Batten Catalogue", "WEB 14684"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.78352540),
        dec: Angle.Degrees(+47.61222292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35784"},
        {"Hipparcos Number", "HIP 25724"},
        {"Smithsonian Astrophysical Observation", "SAO 40366"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.40079803),
        dec: Angle.Degrees(+47.61466449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59381"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.74429814),
        dec: Angle.Degrees(+47.61514654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203747"},
        {"Hipparcos Number", "HIP 105555"},
        {"Geneva Identification System", "GEN# +1.00203747"},
        {"Smithsonian Astrophysical Observation", "SAO 50776"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.67414097),
        dec: Angle.Degrees(+47.61620908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173630"},
        {"Hipparcos Number", "HIP 91887"},
        {"Smithsonian Astrophysical Observation", "SAO 47744"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.97656881),
        dec: Angle.Degrees(+47.61630344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1676"},
        {"Smithsonian Astrophysical Observation", "SAO 36287"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.24769317),
        dec: Angle.Degrees(+47.61687342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199890"},
        {"Hipparcos Number", "HIP 103509"},
        {"Celescope Catalog", "CEL 5222"},
        {"Geneva Identification System", "GEN# +1.00199890"},
        {"Smithsonian Astrophysical Observation", "SAO 50299"},
        {"Wilson Evans Batten Catalogue", "WEB 18831"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.56376947),
        dec: Angle.Degrees(+47.61767217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61713"},
    },
    visualMagnitude: 12.13,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.73922741),
        dec: Angle.Degrees(+47.62111728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114894"},
        {"Smithsonian Astrophysical Observation", "SAO 52850"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.08663009),
        dec: Angle.Degrees(+47.62346684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70910"},
        {"Smithsonian Astrophysical Observation", "SAO 45079"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.51371310),
        dec: Angle.Degrees(+47.62418284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17394"},
        {"Hipparcos Number", "HIP 13144"},
        {"Smithsonian Astrophysical Observation", "SAO 38355"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.26142249),
        dec: Angle.Degrees(+47.62580332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10038 AB"},
        {"Henry Draper", "HD 148033"},
        {"Hipparcos Number", "HIP 80270"},
        {"Smithsonian Astrophysical Observation", "SAO 46059"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78699382),
        dec: Angle.Degrees(+47.63003831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136044"},
        {"Hipparcos Number", "HIP 74755"},
        {"Geneva Identification System", "GEN# +6.20034005"},
        {"Smithsonian Astrophysical Observation", "SAO 45463"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.16445274),
        dec: Angle.Degrees(+47.63086988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1607 AB"},
        {"Hipparcos Number", "HIP 9462"},
        {"Smithsonian Astrophysical Observation", "SAO 37707"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.44523966),
        dec: Angle.Degrees(+47.63167193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110473"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.66026337),
        dec: Angle.Degrees(+47.63233511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137001"},
        {"Hipparcos Number", "HIP 75175"},
        {"Geneva Identification System", "GEN# +6.20034012"},
        {"Smithsonian Astrophysical Observation", "SAO 45507"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.43710808),
        dec: Angle.Degrees(+47.63435764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35195",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 7.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)16, 23.7300),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)38, 07.300)
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
    primaryId: "HIP 35194",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5932 A"},
        {"Henry Draper", "HD 55725"},
        {"Hipparcos Number", "HIP 35194"},
        {"Smithsonian Astrophysical Observation", "SAO 41656"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.09783914),
        dec: Angle.Degrees(+47.63877693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155357"},
        {"Hipparcos Number", "HIP 83887"},
        {"Geneva Identification System", "GEN# +1.00155357"},
        {"Smithsonian Astrophysical Observation", "SAO 46515"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.18247717),
        dec: Angle.Degrees(+47.63915395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209287"},
        {"Hipparcos Number", "HIP 108677"},
        {"Geneva Identification System", "GEN# +1.00209287"},
        {"Smithsonian Astrophysical Observation", "SAO 51554"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.23283785),
        dec: Angle.Degrees(+47.64009456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6226"},
        {"Hipparcos Number", "HIP 4983"},
        {"Celescope Catalog", "CEL 113"},
        {"Geneva Identification System", "GEN# +1.00006226"},
        {"Renson", "Renson 1590"},
        {"Smithsonian Astrophysical Observation", "SAO 36891"},
        {"Wilson Evans Batten Catalogue", "WEB 1005"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.97234676),
        dec: Angle.Degrees(+47.64230158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81356"},
        {"Smithsonian Astrophysical Observation", "SAO 46192"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.22205455),
        dec: Angle.Degrees(+47.64362785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58271"},
        {"Hipparcos Number", "HIP 36185"},
        {"Smithsonian Astrophysical Observation", "SAO 41771"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.78306222),
        dec: Angle.Degrees(+47.64592935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113747"},
        {"Smithsonian Astrophysical Observation", "SAO 52617"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.54392990),
        dec: Angle.Degrees(+47.64598951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21022"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.61819714),
        dec: Angle.Degrees(+47.64737191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104194",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14649 A"},
        {"Henry Draper", "HD 201251"},
        {"Hipparcos Number", "HIP 104194"},
        {"Fundamental Katalog 5th Edition", "FK5 3688"},
        {"Geneva Identification System", "GEN# +1.00201251"},
        {"Smithsonian Astrophysical Observation", "SAO 50456"},
        {"Wilson Evans Batten Catalogue", "WEB 18982"},
    },
    visualMagnitude: 4.56,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.65036722),
        dec: Angle.Degrees(+47.64840597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199998"},
        {"Hipparcos Number", "HIP 103562"},
        {"Geneva Identification System", "GEN# +1.00199998"},
        {"Smithsonian Astrophysical Observation", "SAO 50315"},
        {"Wilson Evans Batten Catalogue", "WEB 18842"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.74402046),
        dec: Angle.Degrees(+47.64937113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 461 AB"},
        {"Henry Draper", "HD 2982"},
        {"Hipparcos Number", "HIP 2635"},
        {"Smithsonian Astrophysical Observation", "SAO 36463"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.36116287),
        dec: Angle.Degrees(+47.64946249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48171"},
        {"Smithsonian Astrophysical Observation", "SAO 43051"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.28348878),
        dec: Angle.Degrees(+47.65187977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204292"},
        {"Hipparcos Number", "HIP 105829"},
        {"Celescope Catalog", "CEL 5311"},
        {"Smithsonian Astrophysical Observation", "SAO 50843"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.51924441),
        dec: Angle.Degrees(+47.65378179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73695",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "I Boo*"},
        {"Aitken", "ADS 9494 AB"},
        {"Henry Draper", "HD 133640"},
        {"Hipparcos Number", "HIP 73695"},
        {"Cincinnati Publication", "Ci 20 907"},
        {"Geneva Identification System", "GEN# +1.00133640"},
        {"Smithsonian Astrophysical Observation", "SAO 45357"},
        {"Wilson Evans Batten Catalogue", "WEB 12597"},
    },
    visualMagnitude: 4.83,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.94867417),
        dec: Angle.Degrees(+47.65401409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -436.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24364"},
        {"Hipparcos Number", "HIP 18290"},
        {"Smithsonian Astrophysical Observation", "SAO 39185"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.67513266),
        dec: Angle.Degrees(+47.65494982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176153"},
        {"Hipparcos Number", "HIP 92983"},
        {"Smithsonian Astrophysical Observation", "SAO 47943"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.15271733),
        dec: Angle.Degrees(+47.65640691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82844"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.95142627),
        dec: Angle.Degrees(+47.65693036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 171.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112046"},
        {"Hipparcos Number", "HIP 62854"},
        {"Smithsonian Astrophysical Observation", "SAO 44371"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.25014567),
        dec: Angle.Degrees(+47.65870773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89142"},
        {"Smithsonian Astrophysical Observation", "SAO 47291"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.89268282),
        dec: Angle.Degrees(+47.65956914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27504"},
        {"Hipparcos Number", "HIP 20436"},
        {"Geneva Identification System", "GEN# +1.00027504"},
        {"Smithsonian Astrophysical Observation", "SAO 39490"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.66622509),
        dec: Angle.Degrees(+47.66003962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23219"},
        {"Hipparcos Number", "HIP 17548"},
        {"Celescope Catalog", "CEL 314"},
        {"Geneva Identification System", "GEN# +1.00023219"},
        {"Smithsonian Astrophysical Observation", "SAO 39079"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.36474500),
        dec: Angle.Degrees(+47.66041482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32233"},
        {"Hipparcos Number", "HIP 23569"},
        {"Fundamental Katalog 5th Edition", "FK5 4466"},
        {"Smithsonian Astrophysical Observation", "SAO 39984"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.01262340),
        dec: Angle.Degrees(+47.66486626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64815"},
        {"Smithsonian Astrophysical Observation", "SAO 44547"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.27063611),
        dec: Angle.Degrees(+47.66631916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102158"},
        {"Hipparcos Number", "HIP 57349"},
        {"Cincinnati Publication", "Ci 20 659"},
        {"Cincinnati Publication 2", "Ci 18 1452"},
        {"Geneva Identification System", "GEN# +1.00102158"},
        {"Smithsonian Astrophysical Observation", "SAO 43884"},
        {"Wilson Evans Batten Catalogue", "WEB 10309"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.37925145),
        dec: Angle.Degrees(+47.66758659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -591.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17960"},
        {"Hipparcos Number", "HIP 13580"},
        {"Smithsonian Astrophysical Observation", "SAO 38434"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.73100833),
        dec: Angle.Degrees(+47.66902788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204994"},
        {"Hipparcos Number", "HIP 106211"},
        {"Smithsonian Astrophysical Observation", "SAO 50960"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.69573254),
        dec: Angle.Degrees(+47.66991496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155038"},
        {"Hipparcos Number", "HIP 83743"},
        {"Smithsonian Astrophysical Observation", "SAO 46493"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.72898813),
        dec: Angle.Degrees(+47.67066666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8750"},
        {"Smithsonian Astrophysical Observation", "SAO 37577"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.14423209),
        dec: Angle.Degrees(+47.67095066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94317"},
        {"Hipparcos Number", "HIP 53288"},
        {"Geneva Identification System", "GEN# +1.00094317"},
        {"Smithsonian Astrophysical Observation", "SAO 43511"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.48136556),
        dec: Angle.Degrees(+47.67119685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7153 AB"},
        {"Henry Draper", "HD 77263"},
        {"Hipparcos Number", "HIP 44440"},
        {"Smithsonian Astrophysical Observation", "SAO 42657"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81668733),
        dec: Angle.Degrees(+47.67176265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32900"},
        {"Wilson Evans Batten Catalogue", "WEB 6620"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.82697017),
        dec: Angle.Degrees(+47.67339990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114012"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.34519736),
        dec: Angle.Degrees(+47.67632205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7734"},
        {"Hipparcos Number", "HIP 6073"},
        {"Smithsonian Astrophysical Observation", "SAO 37091"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.49055245),
        dec: Angle.Degrees(+47.68075772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56983"},
    },
    visualMagnitude: 12.06,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.21647314),
        dec: Angle.Degrees(+47.68147135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95330"},
        {"Hipparcos Number", "HIP 53855"},
        {"Geneva Identification System", "GEN# +1.00095330"},
        {"Smithsonian Astrophysical Observation", "SAO 43568"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.26441958),
        dec: Angle.Degrees(+47.68229902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81242"},
        {"Smithsonian Astrophysical Observation", "SAO 46178"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.88896630),
        dec: Angle.Degrees(+47.68304676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143367"},
        {"Hipparcos Number", "HIP 78194"},
        {"Smithsonian Astrophysical Observation", "SAO 45807"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.49126792),
        dec: Angle.Degrees(+47.68419264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14119 AB"},
        {"Henry Draper", "HD 196989"},
        {"Hipparcos Number", "HIP 101896"},
        {"Smithsonian Astrophysical Observation", "SAO 49895"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.73639896),
        dec: Angle.Degrees(+47.68682314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71401"},
        {"Smithsonian Astrophysical Observation", "SAO 45130"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.01557648),
        dec: Angle.Degrees(+47.68999380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14720 AB"},
        {"Henry Draper", "HD 201836"},
        {"Hipparcos Number", "HIP 104537"},
        {"Celescope Catalog", "CEL 5260"},
        {"Geneva Identification System", "GEN# +1.00201836"},
        {"Smithsonian Astrophysical Observation", "SAO 50536"},
        {"Wilson Evans Batten Catalogue", "WEB 19027"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62900308),
        dec: Angle.Degrees(+47.69223284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79477"},
        {"Hipparcos Number", "HIP 45476"},
        {"Smithsonian Astrophysical Observation", "SAO 42774"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.00409873),
        dec: Angle.Degrees(+47.69270282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6092"},
        {"Hipparcos Number", "HIP 4888"},
        {"Celescope Catalog", "CEL 109"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.69575039),
        dec: Angle.Degrees(+47.69875023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29956"},
        {"Hipparcos Number", "HIP 22124"},
        {"Smithsonian Astrophysical Observation", "SAO 39726"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.42013810),
        dec: Angle.Degrees(+47.69881763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15667"},
    },
    visualMagnitude: 11.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.46149875),
        dec: Angle.Degrees(+60.24398756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185893"},
        {"Hipparcos Number", "HIP 96669"},
        {"Smithsonian Astrophysical Observation", "SAO 48688"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80822441),
        dec: Angle.Degrees(+47.70141821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36761"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.40231155),
        dec: Angle.Degrees(+47.70202893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91841"},
        {"Smithsonian Astrophysical Observation", "SAO 47735"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.86790313),
        dec: Angle.Degrees(+47.70363665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41571"},
        {"Smithsonian Astrophysical Observation", "SAO 42382"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.14415446),
        dec: Angle.Degrees(+47.70398224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5982"},
        {"Hipparcos Number", "HIP 4812"},
        {"Geneva Identification System", "GEN# +1.00005982"},
        {"Smithsonian Astrophysical Observation", "SAO 36857"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.44255644),
        dec: Angle.Degrees(+47.70538818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203989"},
        {"Hipparcos Number", "HIP 105658"},
        {"Celescope Catalog", "CEL 5304"},
        {"Geneva Identification System", "GEN# +1.00203989"},
        {"Smithsonian Astrophysical Observation", "SAO 50798"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.02336168),
        dec: Angle.Degrees(+47.70653543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44388"},
        {"Hipparcos Number", "HIP 30449"},
        {"Wilson Evans Batten Catalogue", "WEB 6058"},
    },
    visualMagnitude: 10.20,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00972497),
        dec: Angle.Degrees(+47.70663100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213311"},
        {"Henry Draper 2", "HD 213310"},
        {"Hipparcos Number", "HIP 111022"},
        {"Fundamental Katalog 5th Edition", "FK5 3799"},
        {"Geneva Identification System", "GEN# +1.00213310"},
        {"Smithsonian Astrophysical Observation", "SAO 52055"},
        {"Wilson Evans Batten Catalogue", "WEB 19877"},
    },
    visualMagnitude: 4.34,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38259473),
        dec: Angle.Degrees(+47.70689488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198858"},
        {"Hipparcos Number", "HIP 102951"},
        {"Geneva Identification System", "GEN# +1.00198858"},
        {"Smithsonian Astrophysical Observation", "SAO 50145"},
        {"Wilson Evans Batten Catalogue", "WEB 18681"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.87791735),
        dec: Angle.Degrees(+47.70761837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192783"},
        {"Hipparcos Number", "HIP 99781"},
        {"Smithsonian Astrophysical Observation", "SAO 49356"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.67707662),
        dec: Angle.Degrees(+47.70963290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25940"},
        {"Hipparcos Number", "HIP 19343"},
        {"Fundamental Katalog 5th Edition", "FK5 152"},
        {"Geneva Identification System", "GEN# +1.00025940"},
        {"Smithsonian Astrophysical Observation", "SAO 39336"},
        {"Wilson Evans Batten Catalogue", "WEB 3717"},
    },
    visualMagnitude: 3.96,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.16530527),
        dec: Angle.Degrees(+47.71259359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75825",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9673 A"},
        {"Henry Draper", "HD 138302"},
        {"Hipparcos Number", "HIP 75825"},
        {"Geneva Identification System", "GEN# +1.00138302"},
        {"Smithsonian Astrophysical Observation", "SAO 45565"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.34704372),
        dec: Angle.Degrees(+47.71343687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8669"},
        {"Hipparcos Number", "HIP 6713"},
        {"Smithsonian Astrophysical Observation", "SAO 37202"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.58243492),
        dec: Angle.Degrees(+47.71369966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37840"},
        {"Hipparcos Number", "HIP 27019"},
        {"Smithsonian Astrophysical Observation", "SAO 40563"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95874137),
        dec: Angle.Degrees(+47.71370180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192910"},
        {"Henry Draper 2", "HD 192909"},
        {"Hipparcos Number", "HIP 99848"},
        {"Celescope Catalog", "CEL 5001"},
        {"Geneva Identification System", "GEN# +1.00192909"},
        {"Geneva Identification System 2", "GEN# +1.00192910"},
        {"Smithsonian Astrophysical Observation", "SAO 49385"},
        {"Wilson Evans Batten Catalogue", "WEB 17952"},
    },
    visualMagnitude: 3.96,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.86799270),
        dec: Angle.Degrees(+47.71420530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95274"},
        {"Smithsonian Astrophysical Observation", "SAO 48388"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.75808453),
        dec: Angle.Degrees(+47.71476367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36719"},
        {"Hipparcos Number", "HIP 26315"},
        {"Fundamental Katalog 5th Edition", "FK5 2417"},
        {"Geneva Identification System", "GEN# +1.00036719"},
        {"Smithsonian Astrophysical Observation", "SAO 40466"},
        {"Wilson Evans Batten Catalogue", "WEB 5176"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.06644622),
        dec: Angle.Degrees(+47.71533787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39643"},
        {"Hipparcos Number", "HIP 28100"},
        {"Smithsonian Astrophysical Observation", "SAO 40712"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.09674061),
        dec: Angle.Degrees(+47.71633537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35780"},
        {"Smithsonian Astrophysical Observation", "SAO 41727"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70521604),
        dec: Angle.Degrees(+47.71833348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91782"},
        {"Hipparcos Number", "HIP 51955"},
        {"Smithsonian Astrophysical Observation", "SAO 43405"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19958572),
        dec: Angle.Degrees(+47.72033256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2689"},
        {"Smithsonian Astrophysical Observation", "SAO 36476"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.53690685),
        dec: Angle.Degrees(+47.72143984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19735"},
        {"Hipparcos Number", "HIP 14914"},
        {"Fundamental Katalog 5th Edition", "FK5 2225"},
        {"Geneva Identification System", "GEN# +5.20200138J"},
        {"Smithsonian Astrophysical Observation", "SAO 38638"},
        {"Wilson Evans Batten Catalogue", "WEB 2878"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10981974),
        dec: Angle.Degrees(+47.72608113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224100"},
        {"Hipparcos Number", "HIP 117925"},
        {"Smithsonian Astrophysical Observation", "SAO 53477"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.78053268),
        dec: Angle.Degrees(+47.72855382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120231"},
        {"Hipparcos Number", "HIP 67263"},
        {"Smithsonian Astrophysical Observation", "SAO 44750"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79552410),
        dec: Angle.Degrees(+47.72913422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60118"},
        {"Smithsonian Astrophysical Observation", "SAO 44126"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.93531424),
        dec: Angle.Degrees(+47.72961092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86465",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86465"},
        {"Smithsonian Astrophysical Observation", "SAO 46881"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.99069027),
        dec: Angle.Degrees(+47.72984847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5243",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 916 AB"},
        {"Henry Draper", "HD 6553"},
        {"Hipparcos Number", "HIP 5243"},
        {"Smithsonian Astrophysical Observation", "SAO 36934"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.76267264),
        dec: Angle.Degrees(+47.73033937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133483"},
        {"Hipparcos Number", "HIP 73628"},
        {"Smithsonian Astrophysical Observation", "SAO 45347"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.75348669),
        dec: Angle.Degrees(+47.73131845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52110"},
        {"Smithsonian Astrophysical Observation", "SAO 43416"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.70332506),
        dec: Angle.Degrees(+47.73155386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104245",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14665 A"},
        {"Henry Draper", "HD 201320"},
        {"Hipparcos Number", "HIP 104245"},
        {"Geneva Identification System", "GEN# +1.00201320"},
        {"Smithsonian Astrophysical Observation", "SAO 50471"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.80567763),
        dec: Angle.Degrees(+47.73429407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112966"},
        {"Smithsonian Astrophysical Observation", "SAO 52447"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.16307481),
        dec: Angle.Degrees(+47.73430214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47748"},
        {"Hipparcos Number", "HIP 32135"},
        {"Geneva Identification System", "GEN# +1.00047748"},
        {"Smithsonian Astrophysical Observation", "SAO 41282"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.66765532),
        dec: Angle.Degrees(+47.73577966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21279"},
        {"Hipparcos Number", "HIP 16137"},
        {"Geneva Identification System", "GEN# +5.20200775"},
        {"Smithsonian Astrophysical Observation", "SAO 38847"},
        {"Wilson Evans Batten Catalogue", "WEB 3076"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.98233024),
        dec: Angle.Degrees(+47.73599529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192276"},
        {"Hipparcos Number", "HIP 99539"},
        {"Celescope Catalog", "CEL 4972"},
        {"Geneva Identification System", "GEN# +1.00192276"},
        {"Smithsonian Astrophysical Observation", "SAO 49314"},
        {"Wilson Evans Batten Catalogue", "WEB 17810"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01558749),
        dec: Angle.Degrees(+47.73703999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104243",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.01,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)07, 13.1600),
        dec: Angle.DegreesMinutesSeconds((int)+47, (int)44, 14.900)
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
    primaryId: "HIP 82408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82408"},
        {"Geneva Identification System", "GEN# +0.04702391"},
        {"Smithsonian Astrophysical Observation", "SAO 46318"},
        {"Wilson Evans Batten Catalogue", "WEB 13913"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.61061064),
        dec: Angle.Degrees(+47.73863888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111883"},
        {"Cincinnati Publication", "Ci 18 2951"},
        {"Smithsonian Astrophysical Observation", "SAO 52241"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.94576272),
        dec: Angle.Degrees(+47.73925214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -376.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136230"},
        {"Hipparcos Number", "HIP 74835"},
        {"Geneva Identification System", "GEN# +6.20034002"},
        {"Smithsonian Astrophysical Observation", "SAO 45473"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.40996097),
        dec: Angle.Degrees(+47.73966403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199309"},
        {"Hipparcos Number", "HIP 103210"},
        {"Celescope Catalog", "CEL 5204"},
        {"Geneva Identification System", "GEN# +1.00199309"},
        {"Smithsonian Astrophysical Observation", "SAO 50217"},
        {"Wilson Evans Batten Catalogue", "WEB 18748"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.65249232),
        dec: Angle.Degrees(+47.73972648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64902"},
        {"Smithsonian Astrophysical Observation", "SAO 44555"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.54454848),
        dec: Angle.Degrees(+47.74035738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15729"},
        {"Hipparcos Number", "HIP 11875"},
        {"Smithsonian Astrophysical Observation", "SAO 38110"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.30426481),
        dec: Angle.Degrees(+47.74127481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70626"},
        {"Hipparcos Number", "HIP 41256"},
        {"Geneva Identification System", "GEN# +1.00070626"},
        {"Smithsonian Astrophysical Observation", "SAO 42345"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.25380891),
        dec: Angle.Degrees(+47.74166887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133389"},
        {"Hipparcos Number", "HIP 73585"},
        {"Smithsonian Astrophysical Observation", "SAO 45344"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.62196263),
        dec: Angle.Degrees(+47.74336429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104485",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14704 AB"},
        {"Hipparcos Number", "HIP 104485"},
        {"Smithsonian Astrophysical Observation", "SAO 50526"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49642452),
        dec: Angle.Degrees(+47.74553163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52835"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.04964842),
        dec: Angle.Degrees(+47.74823675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60737"},
        {"Hipparcos Number", "HIP 37170"},
        {"Geneva Identification System", "GEN# +1.00060737"},
        {"Smithsonian Astrophysical Observation", "SAO 41897"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.56856049),
        dec: Angle.Degrees(+47.74907646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8846"},
        {"Hipparcos Number", "HIP 6850"},
        {"Smithsonian Astrophysical Observation", "SAO 37236"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02769051),
        dec: Angle.Degrees(+47.75258408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91701"},
        {"Hipparcos Number", "HIP 51896"},
        {"Smithsonian Astrophysical Observation", "SAO 43400"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.03809714),
        dec: Angle.Degrees(+47.75371665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41553"},
        {"Smithsonian Astrophysical Observation", "SAO 42381"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09322865),
        dec: Angle.Degrees(+47.75391433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17047 AB"},
        {"Henry Draper", "HD 223660"},
        {"Hipparcos Number", "HIP 117637"},
        {"Renson", "Renson 61310"},
        {"Smithsonian Astrophysical Observation", "SAO 53426"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.86220394),
        dec: Angle.Degrees(+47.75437239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222658"},
        {"Hipparcos Number", "HIP 116954"},
        {"Fundamental Katalog 5th Edition", "FK5 6098"},
        {"Smithsonian Astrophysical Observation", "SAO 53297"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.60654710),
        dec: Angle.Degrees(+47.75501231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76170"},
        {"Hipparcos Number", "HIP 43872"},
        {"Smithsonian Astrophysical Observation", "SAO 42606"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.06320626),
        dec: Angle.Degrees(+47.75652812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94832"},
        {"Hipparcos Number", "HIP 53581"},
        {"Geneva Identification System", "GEN# +1.00094832"},
        {"Smithsonian Astrophysical Observation", "SAO 43544"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.41653831),
        dec: Angle.Degrees(+47.75811300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29080"},
        {"Hipparcos Number", "HIP 21496"},
        {"Smithsonian Astrophysical Observation", "SAO 39640"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.25470982),
        dec: Angle.Degrees(+47.75827072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118019"},
        {"Hipparcos Number", "HIP 66116"},
        {"Fundamental Katalog 5th Edition", "FK5 5195"},
        {"Smithsonian Astrophysical Observation", "SAO 44653"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.30471749),
        dec: Angle.Degrees(+47.75882471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8910 A"},
        {"Henry Draper", "HD 117174"},
        {"Hipparcos Number", "HIP 65664"},
        {"Smithsonian Astrophysical Observation", "SAO 44617"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.94052006),
        dec: Angle.Degrees(+47.75905063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48931"},
        {"Smithsonian Astrophysical Observation", "SAO 43125"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.73749034),
        dec: Angle.Degrees(+47.75974711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216487"},
        {"Hipparcos Number", "HIP 112949"},
        {"Smithsonian Astrophysical Observation", "SAO 52442"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.13523921),
        dec: Angle.Degrees(+47.76013419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19110"},
        {"Hipparcos Number", "HIP 14430"},
        {"Smithsonian Astrophysical Observation", "SAO 38575"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.56713225),
        dec: Angle.Degrees(+47.76219589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8910 B"},
        {"Hipparcos Number", "HIP 65663"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.93895604),
        dec: Angle.Degrees(+47.76307263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4701"},
        {"Hipparcos Number", "HIP 3865"},
        {"Smithsonian Astrophysical Observation", "SAO 36696"},
        {"Wilson Evans Batten Catalogue", "WEB 687"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.40522789),
        dec: Angle.Degrees(+47.76398890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41787",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6845 A"},
        {"Hipparcos Number", "HIP 41787"},
        {"Smithsonian Astrophysical Observation", "SAO 42405"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.80381072),
        dec: Angle.Degrees(+47.76516426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103984"},
        {"Hipparcos Number", "HIP 58406"},
        {"Geneva Identification System", "GEN# +1.00103984"},
        {"Smithsonian Astrophysical Observation", "SAO 43980"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.63313704),
        dec: Angle.Degrees(+47.76538918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6370 A"},
        {"Henry Draper", "HD 62923"},
        {"Hipparcos Number", "HIP 38104"},
        {"Geneva Identification System", "GEN# +1.00062923"},
        {"Smithsonian Astrophysical Observation", "SAO 42009"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.13227084),
        dec: Angle.Degrees(+47.76550849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140769"},
        {"Hipparcos Number", "HIP 77003"},
        {"Smithsonian Astrophysical Observation", "SAO 45696"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.84988223),
        dec: Angle.Degrees(+47.76840031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81405"},
        {"Hipparcos Number", "HIP 46351"},
        {"Renson", "Renson 23136"},
        {"Smithsonian Astrophysical Observation", "SAO 42864"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.75581633),
        dec: Angle.Degrees(+47.77321880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4135"},
        {"Smithsonian Astrophysical Observation", "SAO 36739"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22976904),
        dec: Angle.Degrees(+47.77414894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52860"},
        {"Hipparcos Number", "HIP 34168"},
        {"Geneva Identification System", "GEN# +1.00052860"},
        {"Smithsonian Astrophysical Observation", "SAO 41538"},
        {"Wilson Evans Batten Catalogue", "WEB 6845"},
    },
    visualMagnitude: 6.37,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.28745032),
        dec: Angle.Degrees(+47.77504347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92193"},
        {"Hipparcos Number", "HIP 52177"},
        {"Geneva Identification System", "GEN# +1.00092193"},
        {"Smithsonian Astrophysical Observation", "SAO 43419"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.89658987),
        dec: Angle.Degrees(+47.77516862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116605"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.46484677),
        dec: Angle.Degrees(+47.77521890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183647"},
        {"Hipparcos Number", "HIP 95738"},
        {"Smithsonian Astrophysical Observation", "SAO 48490"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.09508714),
        dec: Angle.Degrees(+47.77579932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20450"},
        {"Smithsonian Astrophysical Observation", "SAO 39495"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.72223506),
        dec: Angle.Degrees(+47.77628003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65026",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8862 AB"},
        {"Henry Draper", "HD 115953"},
        {"Hipparcos Number", "HIP 65026"},
        {"Geneva Identification System", "GEN# +1.00115953"},
        {"Smithsonian Astrophysical Observation", "SAO 44566"},
        {"Wilson Evans Batten Catalogue", "WEB 11489"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.93990390),
        dec: Angle.Degrees(+47.77807170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113828"},
        {"Hipparcos Number", "HIP 63904"},
        {"Smithsonian Astrophysical Observation", "SAO 44464"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.44154817),
        dec: Angle.Degrees(+47.77839459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57399",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Taiyangshou"},
        {"Common Name 2", "Alkafzah"},
        {"Henry Draper", "HD 102224"},
        {"Hipparcos Number", "HIP 57399"},
        {"Fundamental Katalog 5th Edition", "FK5 441"},
        {"Geneva Identification System", "GEN# +1.00102224"},
        {"Smithsonian Astrophysical Observation", "SAO 43886"},
        {"Wilson Evans Batten Catalogue", "WEB 10316"},
    },
    visualMagnitude: 3.69,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.51305887),
        dec: Angle.Degrees(+47.77933701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110869"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.92853271),
        dec: Angle.Degrees(+47.78306906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11546"},
        {"Hipparcos Number", "HIP 8898"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.64787102),
        dec: Angle.Degrees(+47.78409570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65239"},
        {"Hipparcos Number", "HIP 39103"},
        {"Geneva Identification System", "GEN# +1.00065239"},
        {"Smithsonian Astrophysical Observation", "SAO 42111"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.99538508),
        dec: Angle.Degrees(+47.78534198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1774"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.61497515),
        dec: Angle.Degrees(+47.78622652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22928"},
        {"Hipparcos Number", "HIP 17358"},
        {"Celescope Catalog", "CEL 308"},
        {"Fundamental Katalog 5th Edition", "FK5 131"},
        {"Geneva Identification System", "GEN# +1.00022928"},
        {"Smithsonian Astrophysical Observation", "SAO 39053"},
        {"Wilson Evans Batten Catalogue", "WEB 3280"},
    },
    visualMagnitude: 3.01,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.73117540),
        dec: Angle.Degrees(+47.78765330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103845"},
        {"Hipparcos Number", "HIP 58313"},
        {"Geneva Identification System", "GEN# +1.00103845"},
        {"Smithsonian Astrophysical Observation", "SAO 43970"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.37166884),
        dec: Angle.Degrees(+47.78862944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205332"},
        {"Hipparcos Number", "HIP 106413"},
        {"Smithsonian Astrophysical Observation", "SAO 51025"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.29704623),
        dec: Angle.Degrees(+47.79038309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53503"},
        {"Hipparcos Number", "HIP 34375"},
        {"Geneva Identification System", "GEN# +1.00053503"},
        {"Smithsonian Astrophysical Observation", "SAO 41569"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.89759578),
        dec: Angle.Degrees(+47.79101245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47607"},
        {"Hipparcos Number", "HIP 32061"},
        {"Smithsonian Astrophysical Observation", "SAO 41272"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.47578146),
        dec: Angle.Degrees(+47.79359057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103768"},
        {"Hipparcos Number", "HIP 58269"},
        {"Geneva Identification System", "GEN# +1.00103768"},
        {"Smithsonian Astrophysical Observation", "SAO 43959"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.25689512),
        dec: Angle.Degrees(+47.79660256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96973"},
        {"Hipparcos Number", "HIP 54598"},
        {"Fundamental Katalog 5th Edition", "FK5 4987"},
        {"Geneva Identification System", "GEN# +1.00096973"},
        {"Smithsonian Astrophysical Observation", "SAO 43635"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.61425001),
        dec: Angle.Degrees(+47.79788656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115003"},
        {"Hipparcos Number", "HIP 64528"},
        {"Geneva Identification System", "GEN# +1.00115003"},
        {"Smithsonian Astrophysical Observation", "SAO 44517"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.38881819),
        dec: Angle.Degrees(+47.79793620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5604",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 978 AB"},
        {"Henry Draper", "HD 7072"},
        {"Hipparcos Number", "HIP 5604"},
        {"Smithsonian Astrophysical Observation", "SAO 37007"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.96800752),
        dec: Angle.Degrees(+47.79831139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152029"},
        {"Hipparcos Number", "HIP 82278"},
        {"Geneva Identification System", "GEN# +1.00152029"},
        {"Smithsonian Astrophysical Observation", "SAO 46298"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.17964447),
        dec: Angle.Degrees(+47.79831850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42467"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.87114047),
        dec: Angle.Degrees(+47.80034994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57650"},
        {"Smithsonian Astrophysical Observation", "SAO 43901"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.31984373),
        dec: Angle.Degrees(+47.80174735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204497"},
        {"Hipparcos Number", "HIP 105955"},
        {"Celescope Catalog", "CEL 5317"},
        {"Geneva Identification System", "GEN# +1.00204497"},
        {"Smithsonian Astrophysical Observation", "SAO 50883"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87321682),
        dec: Angle.Degrees(+47.80243632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36750"},
    },
    visualMagnitude: 11.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.38222976),
        dec: Angle.Degrees(+47.80271624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107275"},
        {"Hipparcos Number", "HIP 60125"},
        {"Geneva Identification System", "GEN# +1.00107275"},
        {"Smithsonian Astrophysical Observation", "SAO 44128"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.96417106),
        dec: Angle.Degrees(+47.80286715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104127",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14627 A"},
        {"Henry Draper", "HD 201076"},
        {"Hipparcos Number", "HIP 104127"},
        {"Celescope Catalog", "CEL 5244"},
        {"Geneva Identification System", "GEN# +1.00201076"},
        {"Smithsonian Astrophysical Observation", "SAO 50439"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.43330324),
        dec: Angle.Degrees(+47.80470934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4460"},
        {"Hipparcos Number", "HIP 3690"},
        {"Celescope Catalog", "CEL 89"},
        {"Geneva Identification System", "GEN# +1.00004460"},
        {"Smithsonian Astrophysical Observation", "SAO 36656"},
        {"Wilson Evans Batten Catalogue", "WEB 654"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.82925580),
        dec: Angle.Degrees(+47.80575671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45783"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.02459794),
        dec: Angle.Degrees(+47.80627045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79254",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9950 A"},
        {"Henry Draper", "HD 145768"},
        {"Hipparcos Number", "HIP 79254"},
        {"Smithsonian Astrophysical Observation", "SAO 45940"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.63223418),
        dec: Angle.Degrees(+47.80698198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188439"},
        {"Hipparcos Number", "HIP 97845"},
        {"Celescope Catalog", "CEL 4869"},
        {"Geneva Identification System", "GEN# +1.00188439"},
        {"Smithsonian Astrophysical Observation", "SAO 48940"},
        {"Wilson Evans Batten Catalogue", "WEB 17214"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.25521888),
        dec: Angle.Degrees(+47.80773842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40650"},
        {"Hipparcos Number", "HIP 28634"},
        {"Geneva Identification System", "GEN# +1.00040650"},
        {"Smithsonian Astrophysical Observation", "SAO 40802"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.68796982),
        dec: Angle.Degrees(+47.80930399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15435"},
        {"Hipparcos Number", "HIP 11673"},
        {"Geneva Identification System", "GEN# +1.00015435"},
        {"Smithsonian Astrophysical Observation", "SAO 38077"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.64792646),
        dec: Angle.Degrees(+47.81038101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13818"},
        {"Hipparcos Number", "HIP 10562"},
        {"Smithsonian Astrophysical Observation", "SAO 37905"},
        {"Wilson Evans Batten Catalogue", "WEB 2220"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.99039099),
        dec: Angle.Degrees(+47.81205813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215896"},
        {"Hipparcos Number", "HIP 112556"},
        {"Smithsonian Astrophysical Observation", "SAO 52370"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.94941952),
        dec: Angle.Degrees(+47.81222459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192035"},
        {"Hipparcos Number", "HIP 99424"},
        {"Celescope Catalog", "CEL 4963"},
        {"Geneva Identification System", "GEN# +1.00192035"},
        {"Smithsonian Astrophysical Observation", "SAO 49282"},
        {"Wilson Evans Batten Catalogue", "WEB 17756"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.70663157),
        dec: Angle.Degrees(+47.81311413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213002"},
        {"Hipparcos Number", "HIP 110846"},
        {"Smithsonian Astrophysical Observation", "SAO 52021"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.85883147),
        dec: Angle.Degrees(+47.81725509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117115"},
        {"Smithsonian Astrophysical Observation", "SAO 53333"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.13983556),
        dec: Angle.Degrees(+47.81824886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56408"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.47153020),
        dec: Angle.Degrees(+47.81986084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149119"},
        {"Hipparcos Number", "HIP 80835"},
        {"Smithsonian Astrophysical Observation", "SAO 46132"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.61737636),
        dec: Angle.Degrees(+47.82065882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67526"},
        {"Smithsonian Astrophysical Observation", "SAO 44773"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.53055193),
        dec: Angle.Degrees(+47.82112984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110847",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110847"},
        {"Smithsonian Astrophysical Observation", "SAO 52022"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.86028120),
        dec: Angle.Degrees(+47.82399151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70446",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9259 B"},
        {"Henry Draper", "HD 126531B"},
        {"Hipparcos Number", "HIP 70446"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.16119658),
        dec: Angle.Degrees(+47.82512981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19881"},
        {"Hipparcos Number", "HIP 15026"},
        {"Wilson Evans Batten Catalogue", "WEB 2895"},
    },
    visualMagnitude: 9.05,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.41101832),
        dec: Angle.Degrees(+47.82608619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206510"},
        {"Hipparcos Number", "HIP 107069"},
        {"Smithsonian Astrophysical Observation", "SAO 51179"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.27194848),
        dec: Angle.Degrees(+47.82846551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59411"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.81084821),
        dec: Angle.Degrees(+47.82887214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61596"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.32150948),
        dec: Angle.Degrees(+47.82888746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9259 A"},
        {"Henry Draper", "HD 126531"},
        {"Hipparcos Number", "HIP 70447"},
        {"Smithsonian Astrophysical Observation", "SAO 45045"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.16211440),
        dec: Angle.Degrees(+47.83056625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14318 A"},
        {"Henry Draper", "HD 198345"},
        {"Hipparcos Number", "HIP 102635"},
        {"Fundamental Katalog 5th Edition", "FK5 3662"},
        {"Geneva Identification System", "GEN# +1.00198345"},
        {"Smithsonian Astrophysical Observation", "SAO 50073"},
        {"Wilson Evans Batten Catalogue", "WEB 18602"},
    },
    visualMagnitude: 5.60,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.95539218),
        dec: Angle.Degrees(+47.83191224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12233"},
        {"Smithsonian Astrophysical Observation", "SAO 38174"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.37332899),
        dec: Angle.Degrees(+47.83637966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176526"},
        {"Hipparcos Number", "HIP 93137"},
        {"Geneva Identification System", "GEN# +1.00176526"},
        {"Smithsonian Astrophysical Observation", "SAO 47963"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.59641170),
        dec: Angle.Degrees(+47.83690747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96277"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.65192715),
        dec: Angle.Degrees(+47.83728190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19767"},
        {"Hipparcos Number", "HIP 14949"},
        {"Geneva Identification System", "GEN# +5.20200151"},
        {"Smithsonian Astrophysical Observation", "SAO 38644"},
        {"Wilson Evans Batten Catalogue", "WEB 2886"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.17763757),
        dec: Angle.Degrees(+47.83866322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49971"},
    },
    visualMagnitude: 12.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.02224824),
        dec: Angle.Degrees(+47.83968424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58770"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.81244985),
        dec: Angle.Degrees(+47.84260576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33104"},
        {"Hipparcos Number", "HIP 24077"},
        {"Smithsonian Astrophysical Observation", "SAO 40069"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.59086801),
        dec: Angle.Degrees(+47.84490209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49968"},
        {"Smithsonian Astrophysical Observation", "SAO 43229"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.01566493),
        dec: Angle.Degrees(+47.84669871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117377"},
        {"Hipparcos Number", "HIP 65768"},
        {"Geneva Identification System", "GEN# +1.00117377"},
        {"Smithsonian Astrophysical Observation", "SAO 44625"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25698722),
        dec: Angle.Degrees(+47.84712734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18878"},
        {"Hipparcos Number", "HIP 14264"},
        {"Geneva Identification System", "GEN# +1.00018878"},
        {"Smithsonian Astrophysical Observation", "SAO 38543"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.98645966),
        dec: Angle.Degrees(+47.84849463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95329"},
        {"Hipparcos Number", "HIP 53858"},
        {"Smithsonian Astrophysical Observation", "SAO 43569"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.26886807),
        dec: Angle.Degrees(+47.85087583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15418"},
        {"Hipparcos Number", "HIP 11663"},
        {"Smithsonian Astrophysical Observation", "SAO 38074"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.60514953),
        dec: Angle.Degrees(+47.85373765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6148"},
        {"Hipparcos Number", "HIP 4919"},
        {"Smithsonian Astrophysical Observation", "SAO 36878"},
        {"Wilson Evans Batten Catalogue", "WEB 978"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.79123612),
        dec: Angle.Degrees(+47.85477545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52643"},
        {"Smithsonian Astrophysical Observation", "SAO 43465"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46937175),
        dec: Angle.Degrees(+47.85621912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61945"},
        {"Smithsonian Astrophysical Observation", "SAO 44289"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.42945697),
        dec: Angle.Degrees(+47.85928768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16430",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2579 A"},
        {"Henry Draper", "HD 21641"},
        {"Hipparcos Number", "HIP 16430"},
        {"Geneva Identification System", "GEN# +5.20200955"},
        {"Smithsonian Astrophysical Observation", "SAO 38908"},
        {"Wilson Evans Batten Catalogue", "WEB 3140"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.88798701),
        dec: Angle.Degrees(+47.86248143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4142"},
        {"Hipparcos Number", "HIP 3478"},
        {"Celescope Catalog", "CEL 87"},
        {"Geneva Identification System", "GEN# +1.00004142"},
        {"Smithsonian Astrophysical Observation", "SAO 36617"},
        {"Wilson Evans Batten Catalogue", "WEB 614"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.10927611),
        dec: Angle.Degrees(+47.86396300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200944"},
        {"Hipparcos Number", "HIP 104062"},
        {"Geneva Identification System", "GEN# +1.00200944"},
        {"Smithsonian Astrophysical Observation", "SAO 50430"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.23571034),
        dec: Angle.Degrees(+47.86990693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171703"},
        {"Hipparcos Number", "HIP 91008"},
        {"Smithsonian Astrophysical Observation", "SAO 47604"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.47858980),
        dec: Angle.Degrees(+47.87020952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81962"},
        {"Hipparcos Number", "HIP 46640"},
        {"Geneva Identification System", "GEN# +1.00081962"},
        {"Smithsonian Astrophysical Observation", "SAO 42897"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.65395173),
        dec: Angle.Degrees(+47.87029773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20488"},
        {"Hipparcos Number", "HIP 15498"},
        {"Smithsonian Astrophysical Observation", "SAO 38722"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.92216504),
        dec: Angle.Degrees(+47.87072279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89601"},
        {"Hipparcos Number", "HIP 50726"},
        {"Smithsonian Astrophysical Observation", "SAO 43301"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.36236602),
        dec: Angle.Degrees(+47.87078827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191738"},
        {"Hipparcos Number", "HIP 99310"},
        {"Geneva Identification System", "GEN# +1.00191738"},
        {"Wilson Evans Batten Catalogue", "WEB 17714"},
    },
    visualMagnitude: 8.65,
    bvColour: 2.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.37537754),
        dec: Angle.Degrees(+47.87145414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24504"},
        {"Hipparcos Number", "HIP 18396"},
        {"Fundamental Katalog 5th Edition", "FK5 2279"},
        {"Geneva Identification System", "GEN# +1.00024504"},
        {"Smithsonian Astrophysical Observation", "SAO 39195"},
        {"Wilson Evans Batten Catalogue", "WEB 3549"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.99232459),
        dec: Angle.Degrees(+47.87147012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121388"},
        {"Hipparcos Number", "HIP 67857"},
        {"Geneva Identification System", "GEN# +1.00121388"},
        {"Smithsonian Astrophysical Observation", "SAO 44790"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48290522),
        dec: Angle.Degrees(+47.87275933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218561"},
        {"Hipparcos Number", "HIP 114264"},
        {"Smithsonian Astrophysical Observation", "SAO 52726"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.12879214),
        dec: Angle.Degrees(+47.87463331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105215"},
        {"Hipparcos Number", "HIP 59079"},
        {"Smithsonian Astrophysical Observation", "SAO 44033"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.73212690),
        dec: Angle.Degrees(+47.87477541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70354"},
        {"Hipparcos Number", "HIP 41137"},
        {"Smithsonian Astrophysical Observation", "SAO 42329"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.90358013),
        dec: Angle.Degrees(+47.87575945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203417"},
        {"Hipparcos Number", "HIP 105361"},
        {"Smithsonian Astrophysical Observation", "SAO 50733"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.11219213),
        dec: Angle.Degrees(+47.87600844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31326"},
        {"Hipparcos Number", "HIP 23024"},
        {"Celescope Catalog", "CEL 493"},
        {"Geneva Identification System", "GEN# +1.00031326"},
        {"Smithsonian Astrophysical Observation", "SAO 39886"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.26917525),
        dec: Angle.Degrees(+47.87884494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11048"},
        {"Geneva Identification System", "GEN# +0.04700612"},
        {"Wilson Evans Batten Catalogue", "WEB 2324"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.56023207),
        dec: Angle.Degrees(+47.87992925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111181"},
        {"Smithsonian Astrophysical Observation", "SAO 52102"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84803965),
        dec: Angle.Degrees(+47.88050900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16108 A"},
        {"Henry Draper", "HD 214370"},
        {"Hipparcos Number", "HIP 111626"},
        {"Geneva Identification System", "GEN# +1.00214370"},
        {"Smithsonian Astrophysical Observation", "SAO 52184"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.19976585),
        dec: Angle.Degrees(+47.88369091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2271 AB"},
        {"Henry Draper", "HD 18549"},
        {"Hipparcos Number", "HIP 14029"},
        {"Smithsonian Astrophysical Observation", "SAO 38504"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15830369),
        dec: Angle.Degrees(+47.88510057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165109"},
        {"Hipparcos Number", "HIP 88302"},
        {"Smithsonian Astrophysical Observation", "SAO 47157"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.49026736),
        dec: Angle.Degrees(+47.88510694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85872",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10630 B"},
        {"Hipparcos Number", "HIP 85872"},
    },
    visualMagnitude: 11.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.21579589),
        dec: Angle.Degrees(+47.88775522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10630 A"},
        {"Henry Draper", "HD 159543"},
        {"Hipparcos Number", "HIP 85868"},
        {"Smithsonian Astrophysical Observation", "SAO 46791"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.20715641),
        dec: Angle.Degrees(+47.88866571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1289"},
        {"Geneva Identification System", "GEN# +0.04700043"},
        {"Smithsonian Astrophysical Observation", "SAO 36219"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.03929629),
        dec: Angle.Degrees(+47.89287030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141565"},
        {"Hipparcos Number", "HIP 77377"},
        {"Geneva Identification System", "GEN# +1.00141565"},
        {"Smithsonian Astrophysical Observation", "SAO 45734"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.93225235),
        dec: Angle.Degrees(+47.89300489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193680"},
        {"Hipparcos Number", "HIP 100219"},
        {"Geneva Identification System", "GEN# +1.00193680"},
        {"Smithsonian Astrophysical Observation", "SAO 49477"},
        {"Wilson Evans Batten Catalogue", "WEB 18060"},
    },
    visualMagnitude: 8.25,
    bvColour: 3.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.90248731),
        dec: Angle.Degrees(+47.89418686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118954"},
        {"Hipparcos Number", "HIP 66609"},
        {"Geneva Identification System", "GEN# +1.00118954"},
        {"Smithsonian Astrophysical Observation", "SAO 44695"},
        {"Wilson Evans Batten Catalogue", "WEB 11750"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.80248192),
        dec: Angle.Degrees(+47.89621104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1438 AB"},
        {"Aitken 2", "ADS 1438"},
        {"Henry Draper", "HD 11031"},
        {"Hipparcos Number", "HIP 8475"},
        {"Geneva Identification System", "GEN# +1.00011031J"},
        {"Smithsonian Astrophysical Observation", "SAO 37536"},
        {"Wilson Evans Batten Catalogue", "WEB 1800"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.31483954),
        dec: Angle.Degrees(+47.89695175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211782"},
        {"Hipparcos Number", "HIP 110139"},
        {"Smithsonian Astrophysical Observation", "SAO 51862"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.64902855),
        dec: Angle.Degrees(+47.89699327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144236"},
        {"Hipparcos Number", "HIP 78584"},
        {"Smithsonian Astrophysical Observation", "SAO 45866"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68812653),
        dec: Angle.Degrees(+47.90169673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40394"},
        {"Hipparcos Number", "HIP 28499"},
        {"Celescope Catalog", "CEL 1054"},
        {"Geneva Identification System", "GEN# +1.00040394"},
        {"Renson", "Renson 10790"},
        {"Smithsonian Astrophysical Observation", "SAO 40778"},
        {"Wilson Evans Batten Catalogue", "WEB 5569"},
    },
    visualMagnitude: 5.71,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.24399472),
        dec: Angle.Degrees(+47.90197432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38179"},
        {"Hipparcos Number", "HIP 27239"},
        {"Celescope Catalog", "CEL 963"},
        {"Geneva Identification System", "GEN# +1.00038179"},
        {"Smithsonian Astrophysical Observation", "SAO 40591"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.60272953),
        dec: Angle.Degrees(+47.90296478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193700"},
        {"Hipparcos Number", "HIP 100230"},
        {"Geneva Identification System", "GEN# +1.00193700"},
        {"Smithsonian Astrophysical Observation", "SAO 49479"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.92351500),
        dec: Angle.Degrees(+47.90550709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42084"},
        {"Hipparcos Number", "HIP 29357"},
        {"Smithsonian Astrophysical Observation", "SAO 40919"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81594385),
        dec: Angle.Degrees(+47.90683954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19691"},
        {"Smithsonian Astrophysical Observation", "SAO 39387"},
    },
    visualMagnitude: 8.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.26846393),
        dec: Angle.Degrees(+47.90757904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187372"},
        {"Hipparcos Number", "HIP 97372"},
        {"Geneva Identification System", "GEN# +1.00187372"},
        {"Smithsonian Astrophysical Observation", "SAO 48842"},
        {"Wilson Evans Batten Catalogue", "WEB 17112"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.86185855),
        dec: Angle.Degrees(+47.90765516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18992"},
        {"Hipparcos Number", "HIP 14346"},
        {"Geneva Identification System", "GEN# +1.00018992"},
        {"Smithsonian Astrophysical Observation", "SAO 38554"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.25392135),
        dec: Angle.Degrees(+47.90777726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130582"},
        {"Hipparcos Number", "HIP 72325"},
        {"Geneva Identification System", "GEN# +1.00130582"},
        {"Smithsonian Astrophysical Observation", "SAO 45217"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.84809015),
        dec: Angle.Degrees(+47.90932644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54401"},
        {"Hipparcos Number", "HIP 34691"},
        {"Smithsonian Astrophysical Observation", "SAO 41605"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.78185421),
        dec: Angle.Degrees(+47.91113500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168321"},
        {"Hipparcos Number", "HIP 89572"},
        {"Geneva Identification System", "GEN# +1.00168321"},
        {"Smithsonian Astrophysical Observation", "SAO 47357"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.17267251),
        dec: Angle.Degrees(+47.91115123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106628"},
        {"Geneva Identification System", "GEN# +0.04703487"},
        {"Smithsonian Astrophysical Observation", "SAO 51076"},
        {"Wilson Evans Batten Catalogue", "WEB 19288"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.96524536),
        dec: Angle.Degrees(+47.91187869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52420"},
        {"Hipparcos Number", "HIP 34019"},
        {"Smithsonian Astrophysical Observation", "SAO 41520"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.88235116),
        dec: Angle.Degrees(+47.91365838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109467",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15698 A"},
        {"Henry Draper", "HD 210629"},
        {"Hipparcos Number", "HIP 109467"},
        {"Geneva Identification System", "GEN# +1.00210629"},
        {"Smithsonian Astrophysical Observation", "SAO 51728"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.64355480),
        dec: Angle.Degrees(+47.91378957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97959"},
        {"Fundamental Katalog 5th Edition", "FK5 5757"},
        {"Geneva Identification System", "GEN# +0.04702949"},
        {"Smithsonian Astrophysical Observation", "SAO 48966"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.62206745),
        dec: Angle.Degrees(+47.91383893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25137"},
        {"Geneva Identification System", "GEN# +0.04701140"},
        {"Smithsonian Astrophysical Observation", "SAO 40284"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.69158009),
        dec: Angle.Degrees(+47.91405389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3079"},
        {"Hipparcos Number", "HIP 2712"},
        {"Cincinnati Publication", "Ci 20 36"},
        {"Geneva Identification System", "GEN# +1.00003079"},
        {"Smithsonian Astrophysical Observation", "SAO 36481"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.62236013),
        dec: Angle.Degrees(+47.91539661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 397.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15698 B"},
        {"Hipparcos Number", "HIP 109464"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63638309),
        dec: Angle.Degrees(+47.91730782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58640"},
        {"Hipparcos Number", "HIP 36334"},
        {"Smithsonian Astrophysical Observation", "SAO 41795"},
        {"Wilson Evans Batten Catalogue", "WEB 7228"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.18154796),
        dec: Angle.Degrees(+47.92093093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113591"},
        {"Smithsonian Astrophysical Observation", "SAO 52581"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.09958918),
        dec: Angle.Degrees(+47.92146270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195047"},
        {"Hipparcos Number", "HIP 100861"},
        {"Geneva Identification System", "GEN# +1.00195047"},
        {"Smithsonian Astrophysical Observation", "SAO 49641"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.76818027),
        dec: Angle.Degrees(+47.92315050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100030"},
        {"Hipparcos Number", "HIP 56170"},
        {"Geneva Identification System", "GEN# +1.00100030"},
        {"Smithsonian Astrophysical Observation", "SAO 43790"},
        {"Wilson Evans Batten Catalogue", "WEB 10088"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72142828),
        dec: Angle.Degrees(+47.92910067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216092"},
        {"Hipparcos Number", "HIP 112698"},
        {"Geneva Identification System", "GEN# +1.00216092"},
        {"Smithsonian Astrophysical Observation", "SAO 52394"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32368520),
        dec: Angle.Degrees(+47.93008787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101801"},
        {"Smithsonian Astrophysical Observation", "SAO 49878"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45721119),
        dec: Angle.Degrees(+47.93009806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188252"},
        {"Hipparcos Number", "HIP 97774"},
        {"Celescope Catalog", "CEL 4864"},
        {"Geneva Identification System", "GEN# +1.00188252"},
        {"Smithsonian Astrophysical Observation", "SAO 48920"},
        {"Wilson Evans Batten Catalogue", "WEB 17199"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.02988134),
        dec: Angle.Degrees(+47.93181856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189879"},
        {"Hipparcos Number", "HIP 98450"},
        {"Geneva Identification System", "GEN# +1.00189879"},
        {"Smithsonian Astrophysical Observation", "SAO 49072"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05210016),
        dec: Angle.Degrees(+47.93269054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210353"},
        {"Hipparcos Number", "HIP 109304"},
        {"Celescope Catalog", "CEL 5441"},
        {"Geneva Identification System", "GEN# +1.00210353"},
        {"Smithsonian Astrophysical Observation", "SAO 51686"},
        {"Wilson Evans Batten Catalogue", "WEB 19642"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.17418983),
        dec: Angle.Degrees(+47.93358774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69620"},
        {"Smithsonian Astrophysical Observation", "SAO 44954"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.74658561),
        dec: Angle.Degrees(+47.93441353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20701"},
        {"Hipparcos Number", "HIP 15684"},
        {"Geneva Identification System", "GEN# +5.20200507"},
        {"Smithsonian Astrophysical Observation", "SAO 38756"},
        {"Wilson Evans Batten Catalogue", "WEB 3007"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.51476219),
        dec: Angle.Degrees(+47.93470553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15497"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.92243602),
        dec: Angle.Degrees(+47.93524690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98075"},
        {"Hipparcos Number", "HIP 55141"},
        {"Smithsonian Astrophysical Observation", "SAO 43679"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.32962371),
        dec: Angle.Degrees(+47.93639939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36878"},
        {"Hipparcos Number", "HIP 26417"},
        {"Geneva Identification System", "GEN# +1.00036878"},
        {"Smithsonian Astrophysical Observation", "SAO 40484"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.33447150),
        dec: Angle.Degrees(+47.93966247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86414"},
        {"Hipparcos Number", "HIP 48986"},
        {"Geneva Identification System", "GEN# +1.00086414"},
        {"Smithsonian Astrophysical Observation", "SAO 43128"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.91601434),
        dec: Angle.Degrees(+47.94208579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12219"},
        {"Hipparcos Number", "HIP 9441"},
        {"Smithsonian Astrophysical Observation", "SAO 37699"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.31191371),
        dec: Angle.Degrees(+47.94365546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196808"},
        {"Hipparcos Number", "HIP 101804"},
        {"Celescope Catalog", "CEL 5131"},
        {"Geneva Identification System", "GEN# +1.00196808A"},
        {"Smithsonian Astrophysical Observation", "SAO 49879"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.46306569),
        dec: Angle.Degrees(+47.94496338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1279"},
        {"Hipparcos Number", "HIP 1372"},
        {"Fundamental Katalog 5th Edition", "FK5 2016"},
        {"Geneva Identification System", "GEN# +1.00001279"},
        {"Smithsonian Astrophysical Observation", "SAO 36236"},
        {"Wilson Evans Batten Catalogue", "WEB 247"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.28766746),
        dec: Angle.Degrees(+47.94741495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66112"},
        {"Hipparcos Number", "HIP 39489"},
        {"Geneva Identification System", "GEN# +1.00066112"},
        {"Smithsonian Astrophysical Observation", "SAO 42150"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.06988331),
        dec: Angle.Degrees(+47.94793733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46320"},
        {"Hipparcos Number", "HIP 31439"},
        {"Geneva Identification System", "GEN# +1.00046320"},
        {"Smithsonian Astrophysical Observation", "SAO 41191"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.80828024),
        dec: Angle.Degrees(+47.94886724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21844"},
        {"Hipparcos Number", "HIP 16570"},
        {"Geneva Identification System", "GEN# +5.20201047"},
        {"Smithsonian Astrophysical Observation", "SAO 38937"},
        {"Wilson Evans Batten Catalogue", "WEB 3163"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.33696844),
        dec: Angle.Degrees(+47.95014257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101807"},
        {"Geneva Identification System", "GEN# +1.00196808B"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.46757611),
        dec: Angle.Degrees(+47.95026879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181278"},
        {"Hipparcos Number", "HIP 94813"},
        {"Geneva Identification System", "GEN# +1.00181278"},
        {"Smithsonian Astrophysical Observation", "SAO 48299"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.38612281),
        dec: Angle.Degrees(+47.95237034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29976"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.66323202),
        dec: Angle.Degrees(+47.95269516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149105"},
        {"Hipparcos Number", "HIP 80818"},
        {"Fundamental Katalog 5th Edition", "FK5 5460"},
        {"Geneva Identification System", "GEN# +1.00149105"},
        {"Smithsonian Astrophysical Observation", "SAO 46129"},
        {"Wilson Evans Batten Catalogue", "WEB 13668"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.56266387),
        dec: Angle.Degrees(+47.95304953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204600"},
        {"Hipparcos Number", "HIP 106009"},
        {"Celescope Catalog", "CEL 5320"},
        {"Geneva Identification System", "GEN# +1.00204600"},
        {"Smithsonian Astrophysical Observation", "SAO 50904"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.06189942),
        dec: Angle.Degrees(+47.95392805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217695"},
        {"Hipparcos Number", "HIP 113720"},
        {"Smithsonian Astrophysical Observation", "SAO 52610"},
        {"Wilson Evans Batten Catalogue", "WEB 20209"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.47229610),
        dec: Angle.Degrees(+47.95526559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97247"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.47646710),
        dec: Angle.Degrees(+47.95533221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8350"},
        {"Smithsonian Astrophysical Observation", "SAO 37508"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91741096),
        dec: Angle.Degrees(+47.95564863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34985"},
        {"Hipparcos Number", "HIP 25246"},
        {"Smithsonian Astrophysical Observation", "SAO 40303"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.97873624),
        dec: Angle.Degrees(+47.95616737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30882"},
        {"Hipparcos Number", "HIP 22764"},
        {"Smithsonian Astrophysical Observation", "SAO 39834"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.45968403),
        dec: Angle.Degrees(+47.95637951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148543"},
        {"Hipparcos Number", "HIP 80538"},
        {"Smithsonian Astrophysical Observation", "SAO 46090"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.63367762),
        dec: Angle.Degrees(+47.95730316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114379",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16557 B"},
        {"Henry Draper", "HD 218738"},
        {"Hipparcos Number", "HIP 114379"},
        {"Geneva Identification System", "GEN# +1.00218738"},
        {"Smithsonian Astrophysical Observation", "SAO 52753"},
        {"Wilson Evans Batten Catalogue", "WEB 20306"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.48847477),
        dec: Angle.Degrees(+47.95834319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115758"},
        {"Smithsonian Astrophysical Observation", "SAO 53041"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.78483647),
        dec: Angle.Degrees(+47.95865865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16557 A"},
        {"Henry Draper", "HD 218739"},
        {"Hipparcos Number", "HIP 114385"},
        {"Smithsonian Astrophysical Observation", "SAO 52754"},
        {"Wilson Evans Batten Catalogue", "WEB 20308"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49475005),
        dec: Angle.Degrees(+47.95941493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108640"},
        {"Hipparcos Number", "HIP 60868"},
        {"Smithsonian Astrophysical Observation", "SAO 44193"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.13951194),
        dec: Angle.Degrees(+47.96675176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41369"},
        {"Smithsonian Astrophysical Observation", "SAO 42354"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.59001924),
        dec: Angle.Degrees(+47.96684072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113458"},
        {"Hipparcos Number", "HIP 63699"},
        {"Smithsonian Astrophysical Observation", "SAO 44444"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.81500792),
        dec: Angle.Degrees(+47.96826212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194838"},
        {"Hipparcos Number", "HIP 100775"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.49143926),
        dec: Angle.Degrees(+47.96839127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135558"},
        {"Hipparcos Number", "HIP 74551"},
        {"Geneva Identification System", "GEN# +6.20034001"},
        {"Smithsonian Astrophysical Observation", "SAO 45444"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.49545303),
        dec: Angle.Degrees(+47.96907129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183280"},
        {"Hipparcos Number", "HIP 95581"},
        {"Smithsonian Astrophysical Observation", "SAO 48449"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61874239),
        dec: Angle.Degrees(+47.96990849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68438"},
        {"Smithsonian Astrophysical Observation", "SAO 44841"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.16645927),
        dec: Angle.Degrees(+47.97047282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61012"},
        {"Hipparcos Number", "HIP 37299"},
        {"Geneva Identification System", "GEN# +1.00061012"},
        {"Smithsonian Astrophysical Observation", "SAO 41913"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.86541733),
        dec: Angle.Degrees(+47.97112526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202654"},
        {"Hipparcos Number", "HIP 104962"},
        {"Celescope Catalog", "CEL 5283"},
        {"Geneva Identification System", "GEN# +1.00202654"},
        {"Smithsonian Astrophysical Observation", "SAO 50631"},
        {"Wilson Evans Batten Catalogue", "WEB 19076"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.90489622),
        dec: Angle.Degrees(+47.97400214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109974",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15800 A"},
        {"Henry Draper", "HD 211495"},
        {"Hipparcos Number", "HIP 109974"},
        {"Smithsonian Astrophysical Observation", "SAO 51826"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.11410097),
        dec: Angle.Degrees(+47.97571121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103809"},
        {"Geneva Identification System", "GEN# +0.04703265J"},
        {"Smithsonian Astrophysical Observation", "SAO 50378"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.53220420),
        dec: Angle.Degrees(+47.97619320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21481"},
        {"Hipparcos Number", "HIP 16275"},
        {"Geneva Identification System", "GEN# +5.20200875"},
        {"Smithsonian Astrophysical Observation", "SAO 38882"},
        {"Wilson Evans Batten Catalogue", "WEB 3102"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.45819367),
        dec: Angle.Degrees(+47.97689558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43429",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43429"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69079798),
        dec: Angle.Degrees(+47.97738639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15800 B"},
        {"Hipparcos Number", "HIP 109971"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.10994296),
        dec: Angle.Degrees(+47.97792179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172392"},
        {"Hipparcos Number", "HIP 91319"},
        {"Smithsonian Astrophysical Observation", "SAO 47662"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.39752336),
        dec: Angle.Degrees(+47.98137405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69141"},
        {"Smithsonian Astrophysical Observation", "SAO 44913"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.29972762),
        dec: Angle.Degrees(+47.98205762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108508"},
        {"Celescope Catalog", "CEL 5416"},
        {"Geneva Identification System", "GEN# +0.04703639"},
        {"Smithsonian Astrophysical Observation", "SAO 51509"},
        {"Wilson Evans Batten Catalogue", "WEB 19538"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.73579901),
        dec: Angle.Degrees(+47.98334342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72111"},
        {"Smithsonian Astrophysical Observation", "SAO 45203"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.25373019),
        dec: Angle.Degrees(+47.98366393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15329 AB"},
        {"Henry Draper", "HD 207350"},
        {"Hipparcos Number", "HIP 107554"},
        {"Smithsonian Astrophysical Observation", "SAO 51296"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.75272818),
        dec: Angle.Degrees(+47.98402504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40710"},
        {"Hipparcos Number", "HIP 28661"},
        {"Smithsonian Astrophysical Observation", "SAO 40810"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.78326149),
        dec: Angle.Degrees(+47.98804460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45083"},
        {"Hipparcos Number", "HIP 30768"},
        {"Smithsonian Astrophysical Observation", "SAO 41110"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.98219589),
        dec: Angle.Degrees(+47.98808299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127319"},
        {"Hipparcos Number", "HIP 70841"},
        {"Smithsonian Astrophysical Observation", "SAO 45073"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.30219480),
        dec: Angle.Degrees(+47.98957172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48601"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.67511708),
        dec: Angle.Degrees(+47.99225266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21552"},
        {"Hipparcos Number", "HIP 16335"},
        {"Fundamental Katalog 5th Edition", "FK5 124"},
        {"Geneva Identification System", "GEN# +5.20200900"},
        {"Smithsonian Astrophysical Observation", "SAO 38890"},
        {"Wilson Evans Batten Catalogue", "WEB 3123"},
    },
    visualMagnitude: 4.36,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.64367585),
        dec: Angle.Degrees(+47.99517199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16457 AB"},
        {"Henry Draper", "HD 217712"},
        {"Hipparcos Number", "HIP 113729"},
        {"Smithsonian Astrophysical Observation", "SAO 52611"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.48798448),
        dec: Angle.Degrees(+47.99854589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92609"},
        {"Hipparcos Number", "HIP 52390"},
        {"Smithsonian Astrophysical Observation", "SAO 43436"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.62587322),
        dec: Angle.Degrees(+47.99920791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153668"},
        {"Hipparcos Number", "HIP 83069"},
        {"Geneva Identification System", "GEN# +1.00153668"},
        {"Smithsonian Astrophysical Observation", "SAO 46416"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.60500513),
        dec: Angle.Degrees(+48.00076983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134900"},
        {"Hipparcos Number", "HIP 74257"},
        {"Smithsonian Astrophysical Observation", "SAO 45412"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.63568358),
        dec: Angle.Degrees(+48.00087401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35760"},
        {"Hipparcos Number", "HIP 25715"},
        {"Geneva Identification System", "GEN# +1.00035760"},
        {"Smithsonian Astrophysical Observation", "SAO 40362"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.35923132),
        dec: Angle.Degrees(+48.00095714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117098"},
        {"Hipparcos Number", "HIP 65620"},
        {"Smithsonian Astrophysical Observation", "SAO 44613"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.80778887),
        dec: Angle.Degrees(+48.00173288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125406"},
        {"Hipparcos Number", "HIP 69862"},
        {"Geneva Identification System", "GEN# +1.00125406"},
        {"Smithsonian Astrophysical Observation", "SAO 44982"},
        {"Wilson Evans Batten Catalogue", "WEB 12154"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.45504117),
        dec: Angle.Degrees(+48.00209628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83127"},
        {"Hipparcos Number", "HIP 47245"},
        {"Smithsonian Astrophysical Observation", "SAO 42948"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.45175632),
        dec: Angle.Degrees(+48.00291731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48863"},
        {"Hipparcos Number", "HIP 32588"},
        {"Smithsonian Astrophysical Observation", "SAO 41349"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.98969888),
        dec: Angle.Degrees(+48.00493036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126893"},
        {"Hipparcos Number", "HIP 70625"},
        {"Smithsonian Astrophysical Observation", "SAO 45052"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.70641841),
        dec: Angle.Degrees(+48.00957954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68444"},
        {"Smithsonian Astrophysical Observation", "SAO 44842"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.18638767),
        dec: Angle.Degrees(+48.00977725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19032"},
        {"Hipparcos Number", "HIP 14375"},
        {"Smithsonian Astrophysical Observation", "SAO 38557"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.36062443),
        dec: Angle.Degrees(+48.01187657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41762"},
        {"Smithsonian Astrophysical Observation", "SAO 42402"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.74216614),
        dec: Angle.Degrees(+48.01346115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181094"},
        {"Hipparcos Number", "HIP 94745"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.19267178),
        dec: Angle.Degrees(+48.01945304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5764"},
        {"Hipparcos Number", "HIP 4672"},
        {"Celescope Catalog", "CEL 104"},
        {"Geneva Identification System", "GEN# +1.00005764"},
        {"Smithsonian Astrophysical Observation", "SAO 36829"},
        {"Wilson Evans Batten Catalogue", "WEB 877"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.99870743),
        dec: Angle.Degrees(+48.01997649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107996"},
        {"Geneva Identification System", "GEN# +0.04703588"},
        {"Smithsonian Astrophysical Observation", "SAO 51398"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.19924177),
        dec: Angle.Degrees(+48.02245584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21699"},
        {"Hipparcos Number", "HIP 16470"},
        {"Celescope Catalog", "CEL 306"},
        {"Geneva Identification System", "GEN# +5.20200985"},
        {"Renson", "Renson 5410"},
        {"Smithsonian Astrophysical Observation", "SAO 38917"},
        {"Wilson Evans Batten Catalogue", "WEB 3146"},
    },
    visualMagnitude: 5.47,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.03575392),
        dec: Angle.Degrees(+48.02353391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113878"},
        {"Hipparcos Number", "HIP 63926"},
        {"Geneva Identification System", "GEN# +1.00113878"},
        {"Renson", "Renson 32990"},
        {"Smithsonian Astrophysical Observation", "SAO 44467"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.50316518),
        dec: Angle.Degrees(+48.02815005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132562"},
        {"Hipparcos Number", "HIP 73239"},
        {"Geneva Identification System", "GEN# +1.00132562"},
        {"Smithsonian Astrophysical Observation", "SAO 45309"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.52869730),
        dec: Angle.Degrees(+48.02901607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198794"},
        {"Hipparcos Number", "HIP 102912"},
        {"Geneva Identification System", "GEN# +1.00198794"},
        {"Smithsonian Astrophysical Observation", "SAO 50131"},
        {"Wilson Evans Batten Catalogue", "WEB 18666"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.73746743),
        dec: Angle.Degrees(+48.03040943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200576"},
        {"Hipparcos Number", "HIP 103850"},
        {"Geneva Identification System", "GEN# +1.00200576"},
        {"Smithsonian Astrophysical Observation", "SAO 50387"},
        {"Wilson Evans Batten Catalogue", "WEB 18907"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.64624253),
        dec: Angle.Degrees(+48.03067566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84526"},
        {"Hipparcos Number", "HIP 48013"},
        {"Geneva Identification System", "GEN# +1.00084526"},
        {"Smithsonian Astrophysical Observation", "SAO 43036"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.81751285),
        dec: Angle.Degrees(+48.03494713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177151"},
        {"Hipparcos Number", "HIP 93376"},
        {"Smithsonian Astrophysical Observation", "SAO 48006"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27728547),
        dec: Angle.Degrees(+48.03563365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137590"},
        {"Hipparcos Number", "HIP 75463"},
        {"Smithsonian Astrophysical Observation", "SAO 45527"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.24340256),
        dec: Angle.Degrees(+48.03810576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208786"},
        {"Hipparcos Number", "HIP 108382"},
        {"Celescope Catalog", "CEL 5410"},
        {"Geneva Identification System", "GEN# +1.00208786"},
        {"Smithsonian Astrophysical Observation", "SAO 51482"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.36563194),
        dec: Angle.Degrees(+48.03889524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112142"},
        {"Smithsonian Astrophysical Observation", "SAO 52295"},
    },
    visualMagnitude: 9.63,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72962591),
        dec: Angle.Degrees(+48.04013985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107497"},
        {"Smithsonian Astrophysical Observation", "SAO 51282"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.58719130),
        dec: Angle.Degrees(+48.04105982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89652"},
        {"Hipparcos Number", "HIP 50742"},
        {"Geneva Identification System", "GEN# +1.00089652"},
        {"Smithsonian Astrophysical Observation", "SAO 43303"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.42520656),
        dec: Angle.Degrees(+48.04197552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29556"},
        {"Smithsonian Astrophysical Observation", "SAO 40956"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.41869520),
        dec: Angle.Degrees(+48.04231294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44127",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Talitha"},
        {"Henry Draper", "HD 76644"},
        {"Hipparcos Number", "HIP 44127"},
        {"Cincinnati Publication", "Ci 20 499"},
        {"Fundamental Katalog 5th Edition", "FK5 335"},
        {"Geneva Identification System", "GEN# +1.00076644"},
        {"Smithsonian Astrophysical Observation", "SAO 42630"},
        {"Wilson Evans Batten Catalogue", "WEB 8476"},
    },
    visualMagnitude: 3.12,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.80349479),
        dec: Angle.Degrees(+48.04234956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -441.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17308"},
        {"Hipparcos Number", "HIP 13099"},
        {"Smithsonian Astrophysical Observation", "SAO 38347"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.10365786),
        dec: Angle.Degrees(+48.04414986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201114"},
        {"Hipparcos Number", "HIP 104136"},
        {"Geneva Identification System", "GEN# +1.00201114"},
        {"Smithsonian Astrophysical Observation", "SAO 50445"},
        {"Wilson Evans Batten Catalogue", "WEB 18969"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48437846),
        dec: Angle.Degrees(+48.04446656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159947"},
        {"Hipparcos Number", "HIP 86034"},
        {"Smithsonian Astrophysical Observation", "SAO 46814"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.73657480),
        dec: Angle.Degrees(+48.04512723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2057"},
        {"Hipparcos Number", "HIP 1987"},
        {"Cincinnati Publication", "Ci 18 42"},
        {"Fundamental Katalog 5th Edition", "FK5 4041"},
        {"Geneva Identification System", "GEN# +1.00002057"},
        {"Smithsonian Astrophysical Observation", "SAO 36347"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.28540806),
        dec: Angle.Degrees(+48.04745932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 274.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112328"},
        {"Smithsonian Astrophysical Observation", "SAO 52332"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.27030227),
        dec: Angle.Degrees(+48.04887664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118759"},
        {"Hipparcos Number", "HIP 66485"},
        {"Smithsonian Astrophysical Observation", "SAO 44689"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.45024962),
        dec: Angle.Degrees(+48.04917713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148093"},
        {"Hipparcos Number", "HIP 80301"},
        {"Smithsonian Astrophysical Observation", "SAO 46062"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.89235221),
        dec: Angle.Degrees(+48.05273951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23104"},
        {"Smithsonian Astrophysical Observation", "SAO 39898"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.56901362),
        dec: Angle.Degrees(+48.05322783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78460",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78460"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26162124),
        dec: Angle.Degrees(+48.05360259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32878"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.76783210),
        dec: Angle.Degrees(+48.05387726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6583"},
        {"Hipparcos Number", "HIP 5271"},
        {"Geneva Identification System", "GEN# +1.00006583"},
        {"Smithsonian Astrophysical Observation", "SAO 36939"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.84775590),
        dec: Angle.Degrees(+48.05399024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202902"},
        {"Hipparcos Number", "HIP 105092"},
        {"Smithsonian Astrophysical Observation", "SAO 50673"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.33035146),
        dec: Angle.Degrees(+48.05442583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140208"},
        {"Hipparcos Number", "HIP 76748"},
        {"Geneva Identification System", "GEN# +1.00140208"},
        {"Smithsonian Astrophysical Observation", "SAO 45673"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08186473),
        dec: Angle.Degrees(+48.05469696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 699 AB"},
        {"Henry Draper", "HD 4912"},
        {"Hipparcos Number", "HIP 4038"},
        {"Smithsonian Astrophysical Observation", "SAO 36721"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.94608448),
        dec: Angle.Degrees(+48.05658159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23910"},
        {"Hipparcos Number", "HIP 18003"},
        {"Smithsonian Astrophysical Observation", "SAO 39145"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.73523317),
        dec: Angle.Degrees(+48.05662958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54234"},
        {"Smithsonian Astrophysical Observation", "SAO 43607"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.44819349),
        dec: Angle.Degrees(+48.05688064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84531"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.20743668),
        dec: Angle.Degrees(+48.05845651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58548"},
        {"Hipparcos Number", "HIP 36301"},
        {"Fundamental Katalog 5th Edition", "FK5 4672"},
        {"Geneva Identification System", "GEN# +1.00058548"},
        {"Smithsonian Astrophysical Observation", "SAO 41788"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.08890621),
        dec: Angle.Degrees(+48.06003722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202383"},
        {"Hipparcos Number", "HIP 104789"},
        {"Geneva Identification System", "GEN# +1.00202383"},
        {"Smithsonian Astrophysical Observation", "SAO 50595"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.43221063),
        dec: Angle.Degrees(+48.06146377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114675"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.46028334),
        dec: Angle.Degrees(+48.06348727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189573"},
        {"Hipparcos Number", "HIP 98309"},
        {"Smithsonian Astrophysical Observation", "SAO 49049"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.62675430),
        dec: Angle.Degrees(+48.06527999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101496"},
        {"Smithsonian Astrophysical Observation", "SAO 49811"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.52101066),
        dec: Angle.Degrees(+48.06911208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65199"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.42404636),
        dec: Angle.Degrees(+48.06961393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182692"},
        {"Hipparcos Number", "HIP 95314"},
        {"Smithsonian Astrophysical Observation", "SAO 48397"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.87808089),
        dec: Angle.Degrees(+48.06967546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101839",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14100 A"},
        {"Henry Draper", "HD 196865"},
        {"Hipparcos Number", "HIP 101839"},
        {"Geneva Identification System", "GEN# +1.00196865"},
        {"Smithsonian Astrophysical Observation", "SAO 49886"},
        {"Wilson Evans Batten Catalogue", "WEB 18401"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.57045677),
        dec: Angle.Degrees(+48.07005582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9778"},
        {"Hipparcos Number", "HIP 7499"},
        {"Smithsonian Astrophysical Observation", "SAO 37354"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.16275186),
        dec: Angle.Degrees(+48.07297809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58784"},
        {"Smithsonian Astrophysical Observation", "SAO 44013"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.85290978),
        dec: Angle.Degrees(+48.07630817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109016"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.28418560),
        dec: Angle.Degrees(+48.07633611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80161"},
        {"Hipparcos Number", "HIP 45753"},
        {"Smithsonian Astrophysical Observation", "SAO 42806"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.94895683),
        dec: Angle.Degrees(+48.07695178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36625"},
        {"Hipparcos Number", "HIP 26267"},
        {"Smithsonian Astrophysical Observation", "SAO 40457"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.90884366),
        dec: Angle.Degrees(+48.07811732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51693"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.39808567),
        dec: Angle.Degrees(+48.07844263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132189"},
        {"Hipparcos Number", "HIP 73081"},
        {"Geneva Identification System", "GEN# +1.00132189"},
        {"Smithsonian Astrophysical Observation", "SAO 45286"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.04023381),
        dec: Angle.Degrees(+48.07888685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7523"},
        {"Smithsonian Astrophysical Observation", "SAO 37358"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.21345666),
        dec: Angle.Degrees(+48.07895585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8115"},
        {"Hipparcos Number", "HIP 6349"},
        {"Smithsonian Astrophysical Observation", "SAO 37144"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.38674888),
        dec: Angle.Degrees(+48.07996076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97657"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.70890221),
        dec: Angle.Degrees(+48.08029551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 230.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90333"},
        {"Hipparcos Number", "HIP 51128"},
        {"Geneva Identification System", "GEN# +1.00090333"},
        {"Smithsonian Astrophysical Observation", "SAO 43337"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.67307851),
        dec: Angle.Degrees(+48.08184535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7546"},
        {"Hipparcos Number", "HIP 5939"},
        {"Fundamental Katalog 5th Edition", "FK5 2085"},
        {"Geneva Identification System", "GEN# +1.00007546"},
        {"Renson", "Renson 1870"},
        {"Smithsonian Astrophysical Observation", "SAO 37067"},
        {"Wilson Evans Batten Catalogue", "WEB 1352"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.10202255),
        dec: Angle.Degrees(+48.08225579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3078"},
        {"Hipparcos Number", "HIP 2705"},
        {"Smithsonian Astrophysical Observation", "SAO 36480"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.59790896),
        dec: Angle.Degrees(+48.08665218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26975"},
        {"Hipparcos Number", "HIP 20064"},
        {"Smithsonian Astrophysical Observation", "SAO 39444"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.54127228),
        dec: Angle.Degrees(+48.08701036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22519"},
        {"Hipparcos Number", "HIP 17050"},
        {"Smithsonian Astrophysical Observation", "SAO 39018"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.82417860),
        dec: Angle.Degrees(+48.08706694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57859",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8325 AB"},
        {"Hipparcos Number", "HIP 57859"},
        {"Smithsonian Astrophysical Observation", "SAO 43918"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.99195195),
        dec: Angle.Degrees(+48.08856918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49189"},
        {"Geneva Identification System", "GEN# +0.04801829"},
        {"Wilson Evans Batten Catalogue", "WEB 9109"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.59293613),
        dec: Angle.Degrees(+48.09238590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -637.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1473.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68338"},
        {"Smithsonian Astrophysical Observation", "SAO 44830"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.83228193),
        dec: Angle.Degrees(+48.09324733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2268"},
        {"Smithsonian Astrophysical Observation", "SAO 36406"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.22620574),
        dec: Angle.Degrees(+48.09466185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168930"},
        {"Hipparcos Number", "HIP 89822"},
        {"Geneva Identification System", "GEN# +1.00168930"},
        {"Smithsonian Astrophysical Observation", "SAO 47395"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95640835),
        dec: Angle.Degrees(+48.10055387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12844"},
        {"Hipparcos Number", "HIP 9890"},
        {"Smithsonian Astrophysical Observation", "SAO 37779"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.81298627),
        dec: Angle.Degrees(+48.10072279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97797"},
        {"Hipparcos Number", "HIP 54997"},
        {"Smithsonian Astrophysical Observation", "SAO 43662"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.90682817),
        dec: Angle.Degrees(+48.10106050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21551"},
        {"Hipparcos Number", "HIP 16340"},
        {"Geneva Identification System", "GEN# +5.20200904"},
        {"Renson", "Renson 5380"},
        {"Smithsonian Astrophysical Observation", "SAO 38893"},
        {"Wilson Evans Batten Catalogue", "WEB 3122"},
    },
    visualMagnitude: 5.82,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65388405),
        dec: Angle.Degrees(+48.10365477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168320"},
        {"Hipparcos Number", "HIP 89570"},
        {"Smithsonian Astrophysical Observation", "SAO 47355"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.15453594),
        dec: Angle.Degrees(+48.10525023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188360"},
        {"Hipparcos Number", "HIP 97815"},
        {"Celescope Catalog", "CEL 4867"},
        {"Geneva Identification System", "GEN# +1.00188360"},
        {"Smithsonian Astrophysical Observation", "SAO 48930"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.15309522),
        dec: Angle.Degrees(+48.10616485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63124"},
        {"Hipparcos Number", "HIP 38190"},
        {"Geneva Identification System", "GEN# +1.00063124"},
        {"Smithsonian Astrophysical Observation", "SAO 42016"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37617797),
        dec: Angle.Degrees(+48.10799784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15003"},
        {"Smithsonian Astrophysical Observation", "SAO 38651"},
        {"Wilson Evans Batten Catalogue", "WEB 2894"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.34302164),
        dec: Angle.Degrees(+48.10885658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 652"},
        {"Hipparcos Number", "HIP 889"},
        {"Geneva Identification System", "GEN# +1.00000652"},
        {"Smithsonian Astrophysical Observation", "SAO 36134"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.73299802),
        dec: Angle.Degrees(+48.11040510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18125"},
        {"Smithsonian Astrophysical Observation", "SAO 39163"},
    },
    visualMagnitude: 8.76,
    bvColour: 2.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.14289731),
        dec: Angle.Degrees(+48.11116043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115282"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.22600499),
        dec: Angle.Degrees(+48.11292163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32228"},
        {"Smithsonian Astrophysical Observation", "SAO 41292"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.91772117),
        dec: Angle.Degrees(+48.11340418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101127"},
        {"Smithsonian Astrophysical Observation", "SAO 49705"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.48246765),
        dec: Angle.Degrees(+48.11491889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8485 AB"},
        {"Henry Draper", "HD 106689"},
        {"Hipparcos Number", "HIP 59820"},
        {"Smithsonian Astrophysical Observation", "SAO 44096"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.00174104),
        dec: Angle.Degrees(+48.11621214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16915",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2643 AB"},
        {"Henry Draper", "HD 22326"},
        {"Hipparcos Number", "HIP 16915"},
        {"Smithsonian Astrophysical Observation", "SAO 38992"},
        {"Wilson Evans Batten Catalogue", "WEB 3219"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.42921151),
        dec: Angle.Degrees(+48.11736921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167327"},
        {"Hipparcos Number", "HIP 89205"},
        {"Smithsonian Astrophysical Observation", "SAO 47302"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.06334384),
        dec: Angle.Degrees(+48.11998275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56244"},
        {"Hipparcos Number", "HIP 35409"},
        {"Smithsonian Astrophysical Observation", "SAO 41685"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.66569694),
        dec: Angle.Degrees(+48.12322131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40776"},
        {"Smithsonian Astrophysical Observation", "SAO 42286"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.83326960),
        dec: Angle.Degrees(+48.12619994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20218"},
        {"Hipparcos Number", "HIP 15261"},
        {"Smithsonian Astrophysical Observation", "SAO 38692"},
        {"Wilson Evans Batten Catalogue", "WEB 2940"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.21643819),
        dec: Angle.Degrees(+48.12984794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61363"},
        {"Hipparcos Number", "HIP 37441"},
        {"Fundamental Katalog 5th Edition", "FK5 2594"},
        {"Geneva Identification System", "GEN# +1.00061363"},
        {"Smithsonian Astrophysical Observation", "SAO 41934"},
        {"Wilson Evans Batten Catalogue", "WEB 7405"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.30185616),
        dec: Angle.Degrees(+48.13185153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77228"},
        {"Hipparcos Number", "HIP 44422"},
        {"Smithsonian Astrophysical Observation", "SAO 42653"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.77062672),
        dec: Angle.Degrees(+48.13186584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85104"},
        {"Smithsonian Astrophysical Observation", "SAO 46690"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.90033939),
        dec: Angle.Degrees(+48.13339612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 298.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94352"},
        {"Smithsonian Astrophysical Observation", "SAO 48198"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.06662750),
        dec: Angle.Degrees(+48.13349355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88555",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11058 AB"},
        {"Henry Draper", "HD 165717"},
        {"Hipparcos Number", "HIP 88555"},
        {"Smithsonian Astrophysical Observation", "SAO 47200"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.23719621),
        dec: Angle.Degrees(+48.13604362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159061"},
        {"Hipparcos Number", "HIP 85645"},
        {"Geneva Identification System", "GEN# +1.00159061"},
        {"Smithsonian Astrophysical Observation", "SAO 46759"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.53778575),
        dec: Angle.Degrees(+48.13715495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66492",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8980 AB"},
        {"Hipparcos Number", "HIP 66492"},
        {"Wilson Evans Batten Catalogue", "WEB 11739"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.46429347),
        dec: Angle.Degrees(+48.13841570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114277"},
        {"Smithsonian Astrophysical Observation", "SAO 52733"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.19066693),
        dec: Angle.Degrees(+48.13905960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24909B"},
        {"Hipparcos Number", "HIP 18663"},
        {"Geneva Identification System", "GEN# +0.04700921"},
        {"Geneva Identification System 2", "GEN# +1.00024909B"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.93718956),
        dec: Angle.Degrees(+48.14044109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102082"},
        {"Smithsonian Astrophysical Observation", "SAO 49940"},
        {"Wilson Evans Batten Catalogue", "WEB 18462"},
    },
    visualMagnitude: 9.11,
    bvColour: 2.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.32614933),
        dec: Angle.Degrees(+48.14137378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17034"},
        {"Hipparcos Number", "HIP 12891"},
        {"Smithsonian Astrophysical Observation", "SAO 38304"},
        {"Wilson Evans Batten Catalogue", "WEB 2618"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.42550185),
        dec: Angle.Degrees(+48.14386468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17921"},
        {"Hipparcos Number", "HIP 13550"},
        {"Geneva Identification System", "GEN# +1.00017921"},
        {"Smithsonian Astrophysical Observation", "SAO 38430"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.63464758),
        dec: Angle.Degrees(+48.14510018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17496"},
        {"Hipparcos Number", "HIP 13217"},
        {"Geneva Identification System", "GEN# +1.00017496"},
        {"Smithsonian Astrophysical Observation", "SAO 38377"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.53015926),
        dec: Angle.Degrees(+48.14567048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113653"},
        {"Smithsonian Astrophysical Observation", "SAO 52598"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.27296883),
        dec: Angle.Degrees(+48.14661963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6447 AB"},
        {"Henry Draper", "HD 64252"},
        {"Hipparcos Number", "HIP 38687"},
        {"Smithsonian Astrophysical Observation", "SAO 42065"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.80781382),
        dec: Angle.Degrees(+48.14818648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14094"},
        {"Hipparcos Number", "HIP 10736"},
        {"Smithsonian Astrophysical Observation", "SAO 37932"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.54726319),
        dec: Angle.Degrees(+48.14830669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9500 A"},
        {"Henry Draper", "HD 133962"},
        {"Hipparcos Number", "HIP 73841"},
        {"Fundamental Katalog 5th Edition", "FK5 1395"},
        {"Geneva Identification System", "GEN# +1.00133962"},
        {"Smithsonian Astrophysical Observation", "SAO 45370"},
        {"Wilson Evans Batten Catalogue", "WEB 12614"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.35788174),
        dec: Angle.Degrees(+48.15090031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24909"},
        {"Hipparcos Number", "HIP 18662"},
        {"Geneva Identification System", "GEN# +1.00024909A"},
        {"Smithsonian Astrophysical Observation", "SAO 39231"},
        {"Wilson Evans Batten Catalogue", "WEB 3592"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.93609781),
        dec: Angle.Degrees(+48.15128493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 743"},
        {"Hipparcos Number", "HIP 967"},
        {"Geneva Identification System", "GEN# +1.00000743"},
        {"Smithsonian Astrophysical Observation", "SAO 36148"},
        {"Wilson Evans Batten Catalogue", "WEB 173"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.99596734),
        dec: Angle.Degrees(+48.15237121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42761"},
        {"Smithsonian Astrophysical Observation", "SAO 42503"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.71449103),
        dec: Angle.Degrees(+48.15307386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192597"},
        {"Hipparcos Number", "HIP 99674"},
        {"Smithsonian Astrophysical Observation", "SAO 49340"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.40724993),
        dec: Angle.Degrees(+48.15472289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78416"},
        {"Hipparcos Number", "HIP 44992"},
        {"Smithsonian Astrophysical Observation", "SAO 42724"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.46494560),
        dec: Angle.Degrees(+48.15498148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215591"},
        {"Hipparcos Number", "HIP 112363"},
        {"Smithsonian Astrophysical Observation", "SAO 52338"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.38631898),
        dec: Angle.Degrees(+48.16160299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67027"},
        {"Hipparcos Number", "HIP 39824"},
        {"Smithsonian Astrophysical Observation", "SAO 42184"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.05328564),
        dec: Angle.Degrees(+48.16384714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184977"},
        {"Hipparcos Number", "HIP 96286"},
        {"Fundamental Katalog 5th Edition", "FK5 5723"},
        {"Geneva Identification System", "GEN# +1.00184977"},
        {"Smithsonian Astrophysical Observation", "SAO 48606"},
        {"Wilson Evans Batten Catalogue", "WEB 16882"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.66614421),
        dec: Angle.Degrees(+48.16474084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82287"},
        {"Hipparcos Number", "HIP 46835"},
        {"Geneva Identification System", "GEN# +1.00082287"},
        {"Smithsonian Astrophysical Observation", "SAO 42911"},
        {"Wilson Evans Batten Catalogue", "WEB 8831"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.16025864),
        dec: Angle.Degrees(+48.16681216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203577"},
        {"Hipparcos Number", "HIP 105447"},
        {"Geneva Identification System", "GEN# +1.00203577"},
        {"Smithsonian Astrophysical Observation", "SAO 50755"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37134839),
        dec: Angle.Degrees(+48.16732042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224558"},
        {"Hipparcos Number", "HIP 118216"},
        {"Smithsonian Astrophysical Observation", "SAO 53542"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.69845383),
        dec: Angle.Degrees(+48.16961865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68504",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68504"},
        {"Smithsonian Astrophysical Observation", "SAO 44850"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.35394632),
        dec: Angle.Degrees(+48.17275876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204481"},
        {"Hipparcos Number", "HIP 105944"},
        {"Celescope Catalog", "CEL 5316"},
        {"Geneva Identification System", "GEN# +1.00204481"},
        {"Smithsonian Astrophysical Observation", "SAO 50876"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.84152697),
        dec: Angle.Degrees(+48.17407991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29827"},
        {"Hipparcos Number", "HIP 22041"},
        {"Smithsonian Astrophysical Observation", "SAO 39713"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.08918965),
        dec: Angle.Degrees(+48.17593358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183558"},
        {"Hipparcos Number", "HIP 95692"},
        {"Celescope Catalog", "CEL 4768"},
        {"Geneva Identification System", "GEN# +1.00183558"},
        {"Smithsonian Astrophysical Observation", "SAO 48479"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.95570724),
        dec: Angle.Degrees(+48.17673190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19845"},
        {"Hipparcos Number", "HIP 15004"},
        {"Geneva Identification System", "GEN# +5.20200175"},
        {"Smithsonian Astrophysical Observation", "SAO 38652"},
        {"Wilson Evans Batten Catalogue", "WEB 2893"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.34940955),
        dec: Angle.Degrees(+48.17699884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3462"},
        {"Smithsonian Astrophysical Observation", "SAO 36613"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.07399329),
        dec: Angle.Degrees(+48.18052652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 762"},
        {"Hipparcos Number", "HIP 982"},
        {"Smithsonian Astrophysical Observation", "SAO 36151"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.03640453),
        dec: Angle.Degrees(+48.18225854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108684"},
        {"Geneva Identification System", "GEN# +0.04703656"},
        {"Smithsonian Astrophysical Observation", "SAO 51556"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.25542893),
        dec: Angle.Degrees(+48.18402331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6095 AB"},
        {"Henry Draper", "HD 58661"},
        {"Hipparcos Number", "HIP 36348"},
        {"Geneva Identification System", "GEN# +1.00058661J"},
        {"Smithsonian Astrophysical Observation", "SAO 41797"},
        {"Wilson Evans Batten Catalogue", "WEB 7230"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21452104),
        dec: Angle.Degrees(+48.18403758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157373"},
        {"Hipparcos Number", "HIP 84855"},
        {"Geneva Identification System", "GEN# +1.00157373"},
        {"Smithsonian Astrophysical Observation", "SAO 46651"},
        {"Wilson Evans Batten Catalogue", "WEB 14324"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.13998009),
        dec: Angle.Degrees(+48.18879904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201269"},
        {"Hipparcos Number", "HIP 104207"},
        {"Geneva Identification System", "GEN# +1.00201269"},
        {"Smithsonian Astrophysical Observation", "SAO 50460"},
        {"Wilson Evans Batten Catalogue", "WEB 18983"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.68213036),
        dec: Angle.Degrees(+48.18906200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191353"},
        {"Hipparcos Number", "HIP 99112"},
        {"Geneva Identification System", "GEN# +1.00191353"},
        {"Smithsonian Astrophysical Observation", "SAO 49201"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.82652145),
        dec: Angle.Degrees(+48.19070574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59975"},
        {"Hipparcos Number", "HIP 36851"},
        {"Smithsonian Astrophysical Observation", "SAO 41857"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.65101049),
        dec: Angle.Degrees(+48.19140518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22192"},
        {"Hipparcos Number", "HIP 16826"},
        {"Celescope Catalog", "CEL 307"},
        {"Geneva Identification System", "GEN# +5.20201164"},
        {"Smithsonian Astrophysical Observation", "SAO 38980"},
        {"Wilson Evans Batten Catalogue", "WEB 3200"},
    },
    visualMagnitude: 4.32,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12233383),
        dec: Angle.Degrees(+48.19270068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73933"},
        {"Hipparcos Number", "HIP 42773"},
        {"Geneva Identification System", "GEN# +1.00073933"},
        {"Smithsonian Astrophysical Observation", "SAO 42504"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.73435744),
        dec: Angle.Degrees(+48.19280408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23191"},
        {"Hipparcos Number", "HIP 17533"},
        {"Smithsonian Astrophysical Observation", "SAO 39076"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.31086319),
        dec: Angle.Degrees(+48.19523012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208394"},
        {"Hipparcos Number", "HIP 108150"},
        {"Geneva Identification System", "GEN# +1.00208394"},
        {"Smithsonian Astrophysical Observation", "SAO 51427"},
        {"Wilson Evans Batten Catalogue", "WEB 19496"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.67527351),
        dec: Angle.Degrees(+48.19881228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130174"},
        {"Hipparcos Number", "HIP 72109"},
        {"Smithsonian Astrophysical Observation", "SAO 45202"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.25172788),
        dec: Angle.Degrees(+48.20181259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19092"},
        {"Smithsonian Astrophysical Observation", "SAO 39300"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.40279628),
        dec: Angle.Degrees(+48.20270439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103912"},
        {"Hipparcos Number", "HIP 58357"},
        {"Geneva Identification System", "GEN# +1.00103912"},
        {"Smithsonian Astrophysical Observation", "SAO 43973"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.50122776),
        dec: Angle.Degrees(+48.20376081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -244.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21181"},
        {"Hipparcos Number", "HIP 16079"},
        {"Geneva Identification System", "GEN# +5.20200735"},
        {"Smithsonian Astrophysical Observation", "SAO 38838"},
        {"Wilson Evans Batten Catalogue", "WEB 3067"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.77144860),
        dec: Angle.Degrees(+48.20556953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1847"},
        {"Hipparcos Number", "HIP 1826"},
        {"Smithsonian Astrophysical Observation", "SAO 36311"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.78413497),
        dec: Angle.Degrees(+48.21020263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71110"},
        {"Smithsonian Astrophysical Observation", "SAO 45098"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.12907911),
        dec: Angle.Degrees(+48.21044484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123691"},
        {"Hipparcos Number", "HIP 69040"},
        {"Geneva Identification System", "GEN# +1.00123691"},
        {"Smithsonian Astrophysical Observation", "SAO 44904"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98560122),
        dec: Angle.Degrees(+48.21084198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10577"},
        {"Hipparcos Number", "HIP 8108"},
        {"Celescope Catalog", "CEL 163"},
        {"Geneva Identification System", "GEN# +1.00010577"},
        {"Smithsonian Astrophysical Observation", "SAO 37469"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.05717266),
        dec: Angle.Degrees(+48.21134059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92786"},
        {"Hipparcos Number", "HIP 52470"},
        {"Geneva Identification System", "GEN# +1.00092786"},
        {"Smithsonian Astrophysical Observation", "SAO 43443"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.89214187),
        dec: Angle.Degrees(+48.21368383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48746"},
        {"Hipparcos Number", "HIP 32540"},
        {"Geneva Identification System", "GEN# +1.00048746"},
        {"Smithsonian Astrophysical Observation", "SAO 41344"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.85851429),
        dec: Angle.Degrees(+48.21546918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7286"},
        {"Hipparcos Number", "HIP 5751"},
        {"Geneva Identification System", "GEN# +1.00007286"},
        {"Smithsonian Astrophysical Observation", "SAO 37040"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46464806),
        dec: Angle.Degrees(+48.21599863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195965"},
        {"Hipparcos Number", "HIP 101350"},
        {"Celescope Catalog", "CEL 5103"},
        {"Geneva Identification System", "GEN# +1.00195965"},
        {"Smithsonian Astrophysical Observation", "SAO 49765"},
        {"Wilson Evans Batten Catalogue", "WEB 18311"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.10665663),
        dec: Angle.Degrees(+48.21646393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112296"},
        {"Hipparcos Number", "HIP 63038"},
        {"Smithsonian Astrophysical Observation", "SAO 44385"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.76470855),
        dec: Angle.Degrees(+48.21663110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17890"},
        {"Hipparcos Number", "HIP 13521"},
        {"Smithsonian Astrophysical Observation", "SAO 38425"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.53286411),
        dec: Angle.Degrees(+48.21831447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148894"},
        {"Hipparcos Number", "HIP 80737"},
        {"Smithsonian Astrophysical Observation", "SAO 46114"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.24671835),
        dec: Angle.Degrees(+48.21912486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53608"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.51033380),
        dec: Angle.Degrees(+48.21930120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5581"},
        {"Hipparcos Number", "HIP 4554"},
        {"Smithsonian Astrophysical Observation", "SAO 36805"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.56873571),
        dec: Angle.Degrees(+48.21977056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86144"},
        {"Hipparcos Number", "HIP 48871"},
        {"Geneva Identification System", "GEN# +1.00086144"},
        {"Smithsonian Astrophysical Observation", "SAO 43118"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50903550),
        dec: Angle.Degrees(+48.21992734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224175"},
        {"Hipparcos Number", "HIP 117979"},
        {"Smithsonian Astrophysical Observation", "SAO 53489"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.94850757),
        dec: Angle.Degrees(+48.22039666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57877"},
        {"Smithsonian Astrophysical Observation", "SAO 43922"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.06238874),
        dec: Angle.Degrees(+48.22141139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71467",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9324"},
        {"Aitken 2", "ADS 9324 AB"},
        {"Henry Draper", "HD 128718"},
        {"Hipparcos Number", "HIP 71467"},
        {"Geneva Identification System", "GEN# +1.00128718J"},
        {"Smithsonian Astrophysical Observation", "SAO 45134"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.23413912),
        dec: Angle.Degrees(+48.22152014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75123"},
        {"Geneva Identification System", "GEN# +6.20034013"},
        {"Smithsonian Astrophysical Observation", "SAO 45502"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.26934735),
        dec: Angle.Degrees(+48.22515357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195374"},
        {"Hipparcos Number", "HIP 101038"},
        {"Smithsonian Astrophysical Observation", "SAO 49685"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.24805438),
        dec: Angle.Degrees(+48.22554164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25294"},
        {"Hipparcos Number", "HIP 18925"},
        {"Geneva Identification System", "GEN# +1.00025294"},
        {"Smithsonian Astrophysical Observation", "SAO 39275"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.85233265),
        dec: Angle.Degrees(+48.22641971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35543"},
        {"Hipparcos Number", "HIP 25569"},
        {"Smithsonian Astrophysical Observation", "SAO 40347"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.97790869),
        dec: Angle.Degrees(+48.22672776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79423"},
        {"Hipparcos Number", "HIP 45443"},
        {"Smithsonian Astrophysical Observation", "SAO 42769"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.91477263),
        dec: Angle.Degrees(+48.22965931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190781"},
        {"Hipparcos Number", "HIP 98858"},
        {"Fundamental Katalog 5th Edition", "FK5 3610"},
        {"Geneva Identification System", "GEN# +1.00190781"},
        {"Smithsonian Astrophysical Observation", "SAO 49152"},
        {"Wilson Evans Batten Catalogue", "WEB 17541"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11994393),
        dec: Angle.Degrees(+48.22966326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99748"},
        {"Hipparcos Number", "HIP 56020"},
        {"Geneva Identification System", "GEN# +1.00099748"},
        {"Smithsonian Astrophysical Observation", "SAO 43763"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.21816641),
        dec: Angle.Degrees(+48.23074999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191998"},
        {"Hipparcos Number", "HIP 99405"},
        {"Geneva Identification System", "GEN# +1.00191998"},
        {"Smithsonian Astrophysical Observation", "SAO 49276"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.64041661),
        dec: Angle.Degrees(+48.23118019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209961"},
        {"Hipparcos Number", "HIP 109082"},
        {"Celescope Catalog", "CEL 5434"},
        {"Geneva Identification System", "GEN# +1.00209961"},
        {"Smithsonian Astrophysical Observation", "SAO 51645"},
        {"Wilson Evans Batten Catalogue", "WEB 19614"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.46341622),
        dec: Angle.Degrees(+48.23150457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15113"},
        {"Hipparcos Number", "HIP 11444"},
        {"Smithsonian Astrophysical Observation", "SAO 38036"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.89413471),
        dec: Angle.Degrees(+48.23186270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198494"},
        {"Hipparcos Number", "HIP 102716"},
        {"Geneva Identification System", "GEN# +1.00198494"},
        {"Renson", "Renson 55240"},
        {"Smithsonian Astrophysical Observation", "SAO 50097"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.19934820),
        dec: Angle.Degrees(+48.23326632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112705"},
        {"Hipparcos Number", "HIP 63284"},
        {"Smithsonian Astrophysical Observation", "SAO 44404"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.53136620),
        dec: Angle.Degrees(+48.23449499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152106"},
        {"Hipparcos Number", "HIP 82312"},
        {"Geneva Identification System", "GEN# +1.00152106"},
        {"Smithsonian Astrophysical Observation", "SAO 46304"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.27255584),
        dec: Angle.Degrees(+48.23537980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101393"},
        {"Hipparcos Number", "HIP 56940"},
        {"Geneva Identification System", "GEN# +1.00101393"},
        {"Renson", "Renson 29220"},
        {"Smithsonian Astrophysical Observation", "SAO 43856"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.09850535),
        dec: Angle.Degrees(+48.23672222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35399",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35399"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65174688),
        dec: Angle.Degrees(+48.23682905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41867"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.05866306),
        dec: Angle.Degrees(+48.23976745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179040"},
        {"Hipparcos Number", "HIP 94036"},
        {"Smithsonian Astrophysical Observation", "SAO 48128"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.17583047),
        dec: Angle.Degrees(+48.23977124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212139"},
        {"Hipparcos Number", "HIP 110361"},
        {"Smithsonian Astrophysical Observation", "SAO 51906"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.28374927),
        dec: Angle.Degrees(+48.24000328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116514"},
        {"Geneva Identification System", "GEN# +0.04704206"},
        {"Smithsonian Astrophysical Observation", "SAO 53184"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.16875439),
        dec: Angle.Degrees(+48.24075303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22372"},
        {"Hipparcos Number", "HIP 16948"},
        {"Smithsonian Astrophysical Observation", "SAO 38996"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51447663),
        dec: Angle.Degrees(+48.24132374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40279"},
        {"Hipparcos Number", "HIP 28444"},
        {"Smithsonian Astrophysical Observation", "SAO 40765"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.08777653),
        dec: Angle.Degrees(+48.24150616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25031"},
        {"Hipparcos Number", "HIP 18740"},
        {"Geneva Identification System", "GEN# +1.00025031"},
        {"Smithsonian Astrophysical Observation", "SAO 39245"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.21137998),
        dec: Angle.Degrees(+48.24406932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26972"},
        {"Smithsonian Astrophysical Observation", "SAO 40557"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.85791903),
        dec: Angle.Degrees(+48.24476271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69521"},
        {"Smithsonian Astrophysical Observation", "SAO 44948"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.47489102),
        dec: Angle.Degrees(+48.24477353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17328"},
        {"Hipparcos Number", "HIP 13116"},
        {"Smithsonian Astrophysical Observation", "SAO 38351"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.17898544),
        dec: Angle.Degrees(+48.24481138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54485"},
        {"Smithsonian Astrophysical Observation", "SAO 43622"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.20231180),
        dec: Angle.Degrees(+48.24654181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28881",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4655 A"},
        {"Henry Draper", "HD 41161"},
        {"Hipparcos Number", "HIP 28881"},
        {"Geneva Identification System", "GEN# +1.00041161"},
        {"Smithsonian Astrophysical Observation", "SAO 40844"},
        {"Wilson Evans Batten Catalogue", "WEB 5650"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.46857568),
        dec: Angle.Degrees(+48.24928669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213189"},
        {"Hipparcos Number", "HIP 110938"},
        {"Smithsonian Astrophysical Observation", "SAO 52043"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.16361116),
        dec: Angle.Degrees(+48.25033614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24066"},
        {"Hipparcos Number", "HIP 18103"},
        {"Smithsonian Astrophysical Observation", "SAO 39158"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.03362658),
        dec: Angle.Degrees(+48.25272344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31967",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5300 A"},
        {"Henry Draper", "HD 47375"},
        {"Hipparcos Number", "HIP 31967"},
        {"Smithsonian Astrophysical Observation", "SAO 41257"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.21132502),
        dec: Angle.Degrees(+48.25518554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112206"},
        {"Smithsonian Astrophysical Observation", "SAO 52305"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.88121343),
        dec: Angle.Degrees(+48.25541296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213777"},
        {"Hipparcos Number", "HIP 111304"},
        {"Smithsonian Astrophysical Observation", "SAO 52128"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.23122457),
        dec: Angle.Degrees(+48.25580208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49055"},
        {"Smithsonian Astrophysical Observation", "SAO 43137"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.15091477),
        dec: Angle.Degrees(+48.25617334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98535",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13269 AB"},
        {"Henry Draper", "HD 190042"},
        {"Hipparcos Number", "HIP 98535"},
        {"Smithsonian Astrophysical Observation", "SAO 49086"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25704080),
        dec: Angle.Degrees(+48.25791206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62210"},
        {"Smithsonian Astrophysical Observation", "SAO 44316"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.25679120),
        dec: Angle.Degrees(+48.25901288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158414"},
        {"Hipparcos Number", "HIP 85379"},
        {"Fundamental Katalog 5th Edition", "FK5 650"},
        {"Geneva Identification System", "GEN# +1.00158414"},
        {"Smithsonian Astrophysical Observation", "SAO 46723"},
        {"Wilson Evans Batten Catalogue", "WEB 14417"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.68434277),
        dec: Angle.Degrees(+48.26007218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17984"},
        {"Hipparcos Number", "HIP 13592"},
        {"Smithsonian Astrophysical Observation", "SAO 38436"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.78349739),
        dec: Angle.Degrees(+48.26167147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151352"},
        {"Hipparcos Number", "HIP 81963"},
        {"Smithsonian Astrophysical Observation", "SAO 46257"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.15201782),
        dec: Angle.Degrees(+48.26438301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2064 A"},
        {"Henry Draper", "HD 16780"},
        {"Hipparcos Number", "HIP 12690"},
        {"Fundamental Katalog 5th Edition", "FK5 4249"},
        {"Smithsonian Astrophysical Observation", "SAO 38274"},
        {"Wilson Evans Batten Catalogue", "WEB 2580"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.75771535),
        dec: Angle.Degrees(+48.26525502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113458"},
        {"Smithsonian Astrophysical Observation", "SAO 52550"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.66157959),
        dec: Angle.Degrees(+48.26685250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199154"},
        {"Hipparcos Number", "HIP 103104"},
        {"Geneva Identification System", "GEN# +1.00199154"},
        {"Renson", "Renson 55440"},
        {"Smithsonian Astrophysical Observation", "SAO 50185"},
        {"Wilson Evans Batten Catalogue", "WEB 18722"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35628092),
        dec: Angle.Degrees(+48.26747274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102513"},
        {"Smithsonian Astrophysical Observation", "SAO 50049"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.62777033),
        dec: Angle.Degrees(+48.27007235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76656"},
        {"Hipparcos Number", "HIP 44139"},
        {"Geneva Identification System", "GEN# +1.00076656"},
        {"Smithsonian Astrophysical Observation", "SAO 42633"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.84580320),
        dec: Angle.Degrees(+48.27165151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46659"},
        {"Geneva Identification System", "GEN# +0.04801777"},
        {"Renson", "Renson 23310"},
    },
    visualMagnitude: 10.74,
    bvColour: -0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.69462280),
        dec: Angle.Degrees(+48.27347331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36358"},
        {"Hipparcos Number", "HIP 26075"},
        {"Geneva Identification System", "GEN# +1.00036358"},
        {"Smithsonian Astrophysical Observation", "SAO 40425"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.41717347),
        dec: Angle.Degrees(+48.27759625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106270",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15058 AB"},
        {"Henry Draper", "HD 205085"},
        {"Hipparcos Number", "HIP 106270"},
        {"Geneva Identification System", "GEN# +2.70920065"},
        {"Smithsonian Astrophysical Observation", "SAO 50979"},
        {"New General Catalogue", "NGC 7092 65"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.87721748),
        dec: Angle.Degrees(+48.27822462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62720"},
        {"Smithsonian Astrophysical Observation", "SAO 44356"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.79853199),
        dec: Angle.Degrees(+48.27829957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68194"},
        {"Hipparcos Number", "HIP 40273"},
        {"Fundamental Katalog 5th Edition", "FK5 2639"},
        {"Geneva Identification System", "GEN# +1.00068194"},
        {"Smithsonian Astrophysical Observation", "SAO 42232"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.36580574),
        dec: Angle.Degrees(+48.28085011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224380"},
        {"Hipparcos Number", "HIP 118097"},
        {"Smithsonian Astrophysical Observation", "SAO 53518"},
        {"Wilson Evans Batten Catalogue", "WEB 20763"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34185737),
        dec: Angle.Degrees(+48.28101783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28543"},
        {"Hipparcos Number", "HIP 21166"},
        {"Smithsonian Astrophysical Observation", "SAO 39585"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.07115952),
        dec: Angle.Degrees(+48.28259499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114593"},
        {"Smithsonian Astrophysical Observation", "SAO 52793"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.21851569),
        dec: Angle.Degrees(+48.28369177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 622 A"},
        {"Henry Draper", "HD 4180"},
        {"Hipparcos Number", "HIP 3504"},
        {"Fundamental Katalog 5th Edition", "FK5 25"},
        {"Geneva Identification System", "GEN# +1.00004180"},
        {"Smithsonian Astrophysical Observation", "SAO 36620"},
        {"Wilson Evans Batten Catalogue", "WEB 619"},
    },
    visualMagnitude: 4.48,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.18125882),
        dec: Angle.Degrees(+48.28438262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8418"},
        {"Hipparcos Number", "HIP 6553"},
        {"Smithsonian Astrophysical Observation", "SAO 37175"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.05255166),
        dec: Angle.Degrees(+48.28779314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53637"},
        {"Geneva Identification System", "GEN# +0.04902004"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.59864920),
        dec: Angle.Degrees(+48.28833287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167190"},
        {"Hipparcos Number", "HIP 89143"},
        {"Smithsonian Astrophysical Observation", "SAO 47293"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.89655138),
        dec: Angle.Degrees(+48.28964011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17553"},
        {"Hipparcos Number", "HIP 13264"},
        {"Smithsonian Astrophysical Observation", "SAO 38382"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.66573180),
        dec: Angle.Degrees(+48.29078305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108650"},
        {"Hipparcos Number", "HIP 60879"},
        {"Smithsonian Astrophysical Observation", "SAO 44195"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.15635368),
        dec: Angle.Degrees(+48.29133986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3445"},
        {"Hipparcos Number", "HIP 2977"},
        {"Geneva Identification System", "GEN# +1.00003445"},
        {"Smithsonian Astrophysical Observation", "SAO 36527"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.47937057),
        dec: Angle.Degrees(+48.29311666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15209"},
        {"Hipparcos Number", "HIP 11520"},
        {"Geneva Identification System", "GEN# +1.00015209"},
        {"Smithsonian Astrophysical Observation", "SAO 38051"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14114714),
        dec: Angle.Degrees(+48.29422123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164181"},
        {"Hipparcos Number", "HIP 87912"},
        {"Smithsonian Astrophysical Observation", "SAO 47095"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.37660055),
        dec: Angle.Degrees(+48.29559782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199714"},
        {"Hipparcos Number", "HIP 103428"},
        {"Geneva Identification System", "GEN# +1.00199714"},
        {"Smithsonian Astrophysical Observation", "SAO 50280"},
        {"Wilson Evans Batten Catalogue", "WEB 18810"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.31908209),
        dec: Angle.Degrees(+48.29577214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170110"},
        {"Hipparcos Number", "HIP 90291"},
        {"Smithsonian Astrophysical Observation", "SAO 47485"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.34107232),
        dec: Angle.Degrees(+48.29699761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28004"},
        {"Hipparcos Number", "HIP 20814"},
        {"Geneva Identification System", "GEN# +1.00028004"},
        {"Smithsonian Astrophysical Observation", "SAO 39541"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.89872765),
        dec: Angle.Degrees(+48.29754817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171124"},
        {"Hipparcos Number", "HIP 90722"},
        {"Smithsonian Astrophysical Observation", "SAO 47554"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.64117166),
        dec: Angle.Degrees(+48.29802660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209329"},
        {"Hipparcos Number", "HIP 108725"},
        {"Geneva Identification System", "GEN# +1.00209329"},
        {"Smithsonian Astrophysical Observation", "SAO 51564"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.36834313),
        dec: Angle.Degrees(+48.29838853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165261"},
        {"Hipparcos Number", "HIP 88361"},
        {"Geneva Identification System", "GEN# +1.00165261"},
        {"Smithsonian Astrophysical Observation", "SAO 47167"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.65493776),
        dec: Angle.Degrees(+48.29909232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29526"},
        {"Hipparcos Number", "HIP 21823"},
        {"Celescope Catalog", "CEL 454"},
        {"Fundamental Katalog 5th Edition", "FK5 2347"},
        {"Geneva Identification System", "GEN# +1.00029526"},
        {"Smithsonian Astrophysical Observation", "SAO 39688"},
        {"Wilson Evans Batten Catalogue", "WEB 4196"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.35037233),
        dec: Angle.Degrees(+48.30098864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76929"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.62978687),
        dec: Angle.Degrees(+48.30289200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46990"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.65915621),
        dec: Angle.Degrees(+48.30332372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205331"},
        {"Hipparcos Number", "HIP 106409"},
        {"Celescope Catalog", "CEL 5340"},
        {"Fundamental Katalog 5th Edition", "FK5 5903"},
        {"Geneva Identification System", "GEN# +2.70920118"},
        {"Renson", "Renson 57220"},
        {"Smithsonian Astrophysical Observation", "SAO 51024"},
        {"New General Catalogue", "NGC 7092 118"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.29215741),
        dec: Angle.Degrees(+48.30345550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33479"},
        {"Hipparcos Number", "HIP 24308"},
        {"Smithsonian Astrophysical Observation", "SAO 40117"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.24314810),
        dec: Angle.Degrees(+48.30529593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8855"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.47365111),
        dec: Angle.Degrees(+48.30877937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78886"},
        {"Hipparcos Number", "HIP 45174"},
        {"Smithsonian Astrophysical Observation", "SAO 42740"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.08539862),
        dec: Angle.Degrees(+48.30946492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76237"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.59437073),
        dec: Angle.Degrees(+48.31143370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9800"},
        {"Hipparcos Number", "HIP 7511"},
        {"Geneva Identification System", "GEN# +1.00009800"},
        {"Smithsonian Astrophysical Observation", "SAO 37355"},
        {"Wilson Evans Batten Catalogue", "WEB 1607"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.19475144),
        dec: Angle.Degrees(+48.31546838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8881"},
        {"Hipparcos Number", "HIP 6874"},
        {"Smithsonian Astrophysical Observation", "SAO 37246"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.11931410),
        dec: Angle.Degrees(+48.32036444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55880"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.80414630),
        dec: Angle.Degrees(+48.32410726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41701"},
        {"Smithsonian Astrophysical Observation", "SAO 42390"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.56161020),
        dec: Angle.Degrees(+48.32588110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146671"},
        {"Hipparcos Number", "HIP 79655"},
        {"Geneva Identification System", "GEN# +1.00146671"},
        {"Smithsonian Astrophysical Observation", "SAO 45995"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81577135),
        dec: Angle.Degrees(+48.32839408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82261"},
        {"Hipparcos Number", "HIP 46830"},
        {"Smithsonian Astrophysical Observation", "SAO 42909"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.14010052),
        dec: Angle.Degrees(+48.33156594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34730"},
        {"Geneva Identification System", "GEN# +9.80107055"},
    },
    visualMagnitude: 12.21,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.86676682),
        dec: Angle.Degrees(+48.33177839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -574.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42233"},
        {"Smithsonian Astrophysical Observation", "SAO 42445"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.16459785),
        dec: Angle.Degrees(+48.33286984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107076"},
        {"Smithsonian Astrophysical Observation", "SAO 51184"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.31820814),
        dec: Angle.Degrees(+48.33406680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190914"},
        {"Hipparcos Number", "HIP 98925"},
        {"Geneva Identification System", "GEN# +1.00190914"},
        {"Renson", "Renson 53100"},
        {"Smithsonian Astrophysical Observation", "SAO 49167"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.29910792),
        dec: Angle.Degrees(+48.33439427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20359"},
        {"Geneva Identification System", "GEN# +0.04700977"},
        {"Wilson Evans Batten Catalogue", "WEB 3891"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.39964854),
        dec: Angle.Degrees(+48.33696228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101295"},
        {"Celescope Catalog", "CEL 5100"},
        {"Geneva Identification System", "GEN# +0.04703131"},
        {"Smithsonian Astrophysical Observation", "SAO 49755"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.97413111),
        dec: Angle.Degrees(+48.33755222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70105"},
        {"Hipparcos Number", "HIP 41019"},
        {"Smithsonian Astrophysical Observation", "SAO 42313"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.56094833),
        dec: Angle.Degrees(+48.33817216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18040"},
        {"Hipparcos Number", "HIP 13640"},
        {"Geneva Identification System", "GEN# +1.00018040"},
        {"Smithsonian Astrophysical Observation", "SAO 38443"},
        {"Wilson Evans Batten Catalogue", "WEB 2705"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.90836647),
        dec: Angle.Degrees(+48.34009759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18017"},
        {"Hipparcos Number", "HIP 13625"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.87043280),
        dec: Angle.Degrees(+48.34091425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152414"},
        {"Hipparcos Number", "HIP 82437"},
        {"Smithsonian Astrophysical Observation", "SAO 46322"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.71315357),
        dec: Angle.Degrees(+48.34381519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180348"},
        {"Hipparcos Number", "HIP 94487"},
        {"Smithsonian Astrophysical Observation", "SAO 48224"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.47314822),
        dec: Angle.Degrees(+48.34930086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70048"},
        {"Smithsonian Astrophysical Observation", "SAO 44999"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.02501970),
        dec: Angle.Degrees(+48.34975915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171762"},
        {"Hipparcos Number", "HIP 91029"},
        {"Smithsonian Astrophysical Observation", "SAO 47607"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.54043430),
        dec: Angle.Degrees(+48.35039829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144247"},
        {"Hipparcos Number", "HIP 78587"},
        {"Smithsonian Astrophysical Observation", "SAO 45867"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68974184),
        dec: Angle.Degrees(+48.35098283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107740"},
        {"Hipparcos Number", "HIP 60356"},
        {"Geneva Identification System", "GEN# +1.00107740"},
        {"Smithsonian Astrophysical Observation", "SAO 44145"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.63791835),
        dec: Angle.Degrees(+48.35283366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80346"},
        {"Cincinnati Publication", "Ci 20 986"},
        {"Geneva Identification System", "GEN# +9.80202045"},
        {"Wilson Evans Batten Catalogue", "WEB 13595"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.03466158),
        dec: Angle.Degrees(+48.35400404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1145.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -452.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205073"},
        {"Hipparcos Number", "HIP 106262"},
        {"Geneva Identification System", "GEN# +2.70920060"},
        {"Renson", "Renson 57110"},
        {"Smithsonian Astrophysical Observation", "SAO 50974"},
        {"New General Catalogue", "NGC 7092 60"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.84658838),
        dec: Angle.Degrees(+48.35654157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67381",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9030 AB"},
        {"Henry Draper", "HD 120475"},
        {"Hipparcos Number", "HIP 67381"},
        {"Smithsonian Astrophysical Observation", "SAO 44759"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.15049080),
        dec: Angle.Degrees(+48.35659067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84796"},
        {"Smithsonian Astrophysical Observation", "SAO 46639"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.98715424),
        dec: Angle.Degrees(+48.35668704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181021"},
        {"Hipparcos Number", "HIP 94728"},
        {"Geneva Identification System", "GEN# +1.00181021"},
        {"Smithsonian Astrophysical Observation", "SAO 48271"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.12982166),
        dec: Angle.Degrees(+48.35679457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11301 AB"},
        {"Henry Draper", "HD 169431"},
        {"Hipparcos Number", "HIP 90025"},
        {"Smithsonian Astrophysical Observation", "SAO 47429"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.53738889),
        dec: Angle.Degrees(+48.35748215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115750"},
        {"Hipparcos Number", "HIP 64926"},
        {"Smithsonian Astrophysical Observation", "SAO 44559"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.60840890),
        dec: Angle.Degrees(+48.36076603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116911"},
        {"Smithsonian Astrophysical Observation", "SAO 53286"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.47625373),
        dec: Angle.Degrees(+48.36147121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121763"},
        {"Hipparcos Number", "HIP 68066"},
        {"Smithsonian Astrophysical Observation", "SAO 44808"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.04447259),
        dec: Angle.Degrees(+48.36156754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33784"},
        {"Hipparcos Number", "HIP 24481"},
        {"Smithsonian Astrophysical Observation", "SAO 40155"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79806382),
        dec: Angle.Degrees(+48.36168208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111925"},
        {"Hipparcos Number", "HIP 62812"},
        {"Smithsonian Astrophysical Observation", "SAO 44363"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.06460669),
        dec: Angle.Degrees(+48.36186019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16746"},
        {"Hipparcos Number", "HIP 12663"},
        {"Smithsonian Astrophysical Observation", "SAO 38266"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.67321777),
        dec: Angle.Degrees(+48.36299768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168269"},
        {"Hipparcos Number", "HIP 89553"},
        {"Fundamental Katalog 5th Edition", "FK5 5608"},
        {"Smithsonian Astrophysical Observation", "SAO 47352"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.10374875),
        dec: Angle.Degrees(+48.36876845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108186"},
        {"Hipparcos Number", "HIP 60622"},
        {"Geneva Identification System", "GEN# +1.00108186"},
        {"Smithsonian Astrophysical Observation", "SAO 44169"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.36718951),
        dec: Angle.Degrees(+48.37130561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221515"},
        {"Hipparcos Number", "HIP 116192"},
        {"Smithsonian Astrophysical Observation", "SAO 53132"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.13521311),
        dec: Angle.Degrees(+48.37230511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36550"},
        {"Smithsonian Astrophysical Observation", "SAO 41826"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.77817235),
        dec: Angle.Degrees(+48.37447344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46013"},
        {"Hipparcos Number", "HIP 31267"},
        {"Geneva Identification System", "GEN# +1.00046013"},
        {"Smithsonian Astrophysical Observation", "SAO 41174"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36302007),
        dec: Angle.Degrees(+48.37449817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67369"},
        {"Hipparcos Number", "HIP 39972"},
        {"Geneva Identification System", "GEN# +1.00067369"},
        {"Smithsonian Astrophysical Observation", "SAO 42202"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.44152353),
        dec: Angle.Degrees(+48.37472933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8373"},
        {"Hipparcos Number", "HIP 6520"},
        {"Fundamental Katalog 5th Edition", "FK5 4127"},
        {"Smithsonian Astrophysical Observation", "SAO 37171"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.94333883),
        dec: Angle.Degrees(+48.37619089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41854"},
        {"Smithsonian Astrophysical Observation", "SAO 42413"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.00549425),
        dec: Angle.Degrees(+48.37787222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51866"},
        {"Hipparcos Number", "HIP 33852"},
        {"Cincinnati Publication", "Ci 20 408"},
        {"Geneva Identification System", "GEN# +1.00051866"},
        {"Smithsonian Astrophysical Observation", "SAO 41500"},
        {"Wilson Evans Batten Catalogue", "WEB 6795"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.40878559),
        dec: Angle.Degrees(+48.37971973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 546.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -430.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4949"},
        {"Smithsonian Astrophysical Observation", "SAO 36884"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.86966179),
        dec: Angle.Degrees(+48.38035653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219962"},
        {"Hipparcos Number", "HIP 115171"},
        {"Geneva Identification System", "GEN# +1.00219962"},
        {"Smithsonian Astrophysical Observation", "SAO 52912"},
        {"Wilson Evans Batten Catalogue", "WEB 20402"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92239405),
        dec: Angle.Degrees(+48.38085976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221188"},
        {"Hipparcos Number", "HIP 115959"},
        {"Smithsonian Astrophysical Observation", "SAO 53076"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.40305357),
        dec: Angle.Degrees(+48.38096174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35542"},
        {"Hipparcos Number", "HIP 25575"},
        {"Smithsonian Astrophysical Observation", "SAO 40350"},
        {"Wilson Evans Batten Catalogue", "WEB 4963"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.99339817),
        dec: Angle.Degrees(+48.38125624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61250"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.27951001),
        dec: Angle.Degrees(+48.38126138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21091"},
        {"Hipparcos Number", "HIP 16011"},
        {"Geneva Identification System", "GEN# +5.20200692"},
        {"Smithsonian Astrophysical Observation", "SAO 38824"},
        {"Wilson Evans Batten Catalogue", "WEB 3056"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54514005),
        dec: Angle.Degrees(+48.38410464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64031"},
        {"Smithsonian Astrophysical Observation", "SAO 44478"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.84942378),
        dec: Angle.Degrees(+48.38612755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204917"},
        {"Hipparcos Number", "HIP 106170"},
        {"Celescope Catalog", "CEL 5328"},
        {"Geneva Identification System", "GEN# +2.70920019"},
        {"Smithsonian Astrophysical Observation", "SAO 50948"},
        {"New General Catalogue", "NGC 7092 19"},
    },
    visualMagnitude: 7.36,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.57892823),
        dec: Angle.Degrees(+48.39089278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187919"},
        {"Hipparcos Number", "HIP 97595"},
        {"Smithsonian Astrophysical Observation", "SAO 48889"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.55487436),
        dec: Angle.Degrees(+48.39158110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162732"},
        {"Hipparcos Number", "HIP 87280"},
        {"Fundamental Katalog 5th Edition", "FK5 3417"},
        {"Geneva Identification System", "GEN# +1.00162732"},
        {"Smithsonian Astrophysical Observation", "SAO 46997"},
        {"Wilson Evans Batten Catalogue", "WEB 14724"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.51389021),
        dec: Angle.Degrees(+48.39411945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62196"},
        {"Hipparcos Number", "HIP 37802"},
        {"Geneva Identification System", "GEN# +1.00062196"},
        {"Smithsonian Astrophysical Observation", "SAO 41974"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.26759854),
        dec: Angle.Degrees(+48.39446739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132369"},
        {"Hipparcos Number", "HIP 73163"},
        {"Geneva Identification System", "GEN# +1.00132369"},
        {"Smithsonian Astrophysical Observation", "SAO 45297"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.28448555),
        dec: Angle.Degrees(+48.39498611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25194"},
        {"Hipparcos Number", "HIP 18846"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.61473196),
        dec: Angle.Degrees(+48.39530723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89319"},
        {"Hipparcos Number", "HIP 50546"},
        {"Fundamental Katalog 5th Edition", "FK5 2827"},
        {"Geneva Identification System", "GEN# +1.00089319"},
        {"Smithsonian Astrophysical Observation", "SAO 43285"},
        {"Wilson Evans Batten Catalogue", "WEB 9272"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.86200567),
        dec: Angle.Degrees(+48.39703112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10845 AB"},
        {"Henry Draper", "HD 162879"},
        {"Hipparcos Number", "HIP 87340"},
        {"Smithsonian Astrophysical Observation", "SAO 47007"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.69646464),
        dec: Angle.Degrees(+48.39788010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155136"},
        {"Hipparcos Number", "HIP 83780"},
        {"Smithsonian Astrophysical Observation", "SAO 46501"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.84335966),
        dec: Angle.Degrees(+48.39921662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92053"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.43661934),
        dec: Angle.Degrees(+48.39938919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21507",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3325 AB"},
        {"Henry Draper", "HD 29093"},
        {"Hipparcos Number", "HIP 21507"},
        {"Smithsonian Astrophysical Observation", "SAO 39641"},
        {"Wilson Evans Batten Catalogue", "WEB 4127"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.28386023),
        dec: Angle.Degrees(+48.39941347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11130 A"},
        {"Henry Draper", "HD 166821"},
        {"Hipparcos Number", "HIP 88999"},
        {"Geneva Identification System", "GEN# +1.00166821"},
        {"Smithsonian Astrophysical Observation", "SAO 47273"},
        {"Wilson Evans Batten Catalogue", "WEB 15102"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.47440410),
        dec: Angle.Degrees(+48.40144835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11130 B"},
        {"Hipparcos Number", "HIP 89003"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.47977566),
        dec: Angle.Degrees(+48.40189753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92637",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92637"},
        {"Geneva Identification System", "GEN# +0.04802781"},
    },
    visualMagnitude: 9.83,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11985480),
        dec: Angle.Degrees(+48.40392149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50012"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.15806798),
        dec: Angle.Degrees(+48.40569924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151056"},
        {"Hipparcos Number", "HIP 81815"},
        {"Smithsonian Astrophysical Observation", "SAO 46239"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.66311667),
        dec: Angle.Degrees(+48.40659435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3071 A"},
        {"Henry Draper", "HD 26630"},
        {"Hipparcos Number", "HIP 19812"},
        {"Fundamental Katalog 5th Edition", "FK5 1117"},
        {"Geneva Identification System", "GEN# +1.00026630A"},
        {"Smithsonian Astrophysical Observation", "SAO 39404"},
        {"Wilson Evans Batten Catalogue", "WEB 3784"},
    },
    visualMagnitude: 4.12,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.72440722),
        dec: Angle.Degrees(+48.40937312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222590"},
        {"Hipparcos Number", "HIP 116895"},
        {"Geneva Identification System", "GEN# +1.00222590"},
        {"Smithsonian Astrophysical Observation", "SAO 53281"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.41787451),
        dec: Angle.Degrees(+48.40966339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164841"},
        {"Hipparcos Number", "HIP 88189"},
        {"Geneva Identification System", "GEN# +1.00164841"},
        {"Smithsonian Astrophysical Observation", "SAO 47133"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.15000934),
        dec: Angle.Degrees(+48.40992277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80609"},
        {"Hipparcos Number", "HIP 45960"},
        {"Geneva Identification System", "GEN# +1.00080609"},
        {"Smithsonian Astrophysical Observation", "SAO 42824"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.59571831),
        dec: Angle.Degrees(+48.41022719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79043"},
        {"Hipparcos Number", "HIP 45254"},
        {"Smithsonian Astrophysical Observation", "SAO 42750"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.34902195),
        dec: Angle.Degrees(+48.41052652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15898"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.19611859),
        dec: Angle.Degrees(+48.41172488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9901"},
        {"Hipparcos Number", "HIP 7589"},
        {"Geneva Identification System", "GEN# +1.00009901"},
        {"Smithsonian Astrophysical Observation", "SAO 37371"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.43484502),
        dec: Angle.Degrees(+48.41273309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46441"},
        {"Hipparcos Number", "HIP 31522"},
        {"Smithsonian Astrophysical Observation", "SAO 41197"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.99869241),
        dec: Angle.Degrees(+48.41318834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207991"},
        {"Hipparcos Number", "HIP 107923"},
        {"Geneva Identification System", "GEN# +1.00207991"},
        {"Smithsonian Astrophysical Observation", "SAO 51382"},
        {"Wilson Evans Batten Catalogue", "WEB 19462"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.98080944),
        dec: Angle.Degrees(+48.43708796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2486"},
        {"Hipparcos Number", "HIP 2271"},
        {"Smithsonian Astrophysical Observation", "SAO 36408"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.23749526),
        dec: Angle.Degrees(+48.41371782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78021"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.96261588),
        dec: Angle.Degrees(+48.41646818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10404"},
        {"Hipparcos Number", "HIP 7988"},
        {"Celescope Catalog", "CEL 158"},
        {"Geneva Identification System", "GEN# +1.00010404"},
        {"Smithsonian Astrophysical Observation", "SAO 37451"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.65306169),
        dec: Angle.Degrees(+48.41646989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62059"},
        {"Smithsonian Astrophysical Observation", "SAO 44299"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.79513221),
        dec: Angle.Degrees(+48.41880427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17745"},
        {"Hipparcos Number", "HIP 13407"},
        {"Smithsonian Astrophysical Observation", "SAO 38408"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.16158504),
        dec: Angle.Degrees(+48.42010715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49560"},
        {"Smithsonian Astrophysical Observation", "SAO 43196"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77901078),
        dec: Angle.Degrees(+48.42044109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62764"},
        {"Hipparcos Number", "HIP 38044"},
        {"Smithsonian Astrophysical Observation", "SAO 42002"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.97883629),
        dec: Angle.Degrees(+48.42394872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48239"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51589191),
        dec: Angle.Degrees(+48.42438767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149860"},
        {"Hipparcos Number", "HIP 81195"},
        {"Geneva Identification System", "GEN# +1.00149860"},
        {"Smithsonian Astrophysical Observation", "SAO 46173"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.77540759),
        dec: Angle.Degrees(+48.42553145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182828"},
        {"Hipparcos Number", "HIP 95376"},
        {"Smithsonian Astrophysical Observation", "SAO 48409"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.04122688),
        dec: Angle.Degrees(+48.42796036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60336"},
        {"Geneva Identification System", "GEN# +6.20030651"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.57061205),
        dec: Angle.Degrees(+48.43004597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83869"},
        {"Hipparcos Number", "HIP 47633"},
        {"Fundamental Katalog 5th Edition", "FK5 2774"},
        {"Geneva Identification System", "GEN# +1.00083869"},
        {"Smithsonian Astrophysical Observation", "SAO 42990"},
        {"Wilson Evans Batten Catalogue", "WEB 8925"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67966736),
        dec: Angle.Degrees(+48.43105765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11950"},
        {"Hipparcos Number", "HIP 9226"},
        {"Smithsonian Astrophysical Observation", "SAO 37667"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.64782562),
        dec: Angle.Degrees(+48.43284221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106851"},
        {"Hipparcos Number", "HIP 59894"},
        {"Geneva Identification System", "GEN# +1.00106851"},
        {"Smithsonian Astrophysical Observation", "SAO 44105"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.26385611),
        dec: Angle.Degrees(+48.43287636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186546"},
        {"Hipparcos Number", "HIP 96991"},
        {"Smithsonian Astrophysical Observation", "SAO 48761"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70769865),
        dec: Angle.Degrees(+48.43547887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225124"},
        {"Hipparcos Number", "HIP 297"},
        {"Geneva Identification System", "GEN# +1.00225124"},
        {"Smithsonian Astrophysical Observation", "SAO 36025"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.92444478),
        dec: Angle.Degrees(+48.43692667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207662"},
        {"Hipparcos Number", "HIP 107713"},
        {"Geneva Identification System", "GEN# +1.00207662"},
        {"Smithsonian Astrophysical Observation", "SAO 51338"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.29952691),
        dec: Angle.Degrees(+48.43730489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199217"},
        {"Hipparcos Number", "HIP 103159"},
        {"Celescope Catalog", "CEL 5199"},
        {"Geneva Identification System", "GEN# +1.00199217"},
        {"Renson", "Renson 55490"},
        {"Smithsonian Astrophysical Observation", "SAO 50206"},
        {"Wilson Evans Batten Catalogue", "WEB 18736"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.50594585),
        dec: Angle.Degrees(+48.43752490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39825"},
        {"Hipparcos Number", "HIP 28210"},
        {"Smithsonian Astrophysical Observation", "SAO 40725"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.41031688),
        dec: Angle.Degrees(+48.43885751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38613"},
        {"Smithsonian Astrophysical Observation", "SAO 42054"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.60238183),
        dec: Angle.Degrees(+48.44056192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160761"},
        {"Hipparcos Number", "HIP 86390"},
        {"Geneva Identification System", "GEN# +1.00160761"},
        {"Smithsonian Astrophysical Observation", "SAO 46868"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.78493445),
        dec: Angle.Degrees(+48.44124231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18685"},
        {"Hipparcos Number", "HIP 14118"},
        {"Smithsonian Astrophysical Observation", "SAO 38520"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.52077963),
        dec: Angle.Degrees(+48.44374098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205210"},
        {"Hipparcos Number", "HIP 106346"},
        {"Celescope Catalog", "CEL 5338"},
        {"Geneva Identification System", "GEN# +2.70920088"},
        {"Smithsonian Astrophysical Observation", "SAO 51001"},
        {"New General Catalogue", "NGC 7092 88"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.07114623),
        dec: Angle.Degrees(+48.44387289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179483"},
        {"Hipparcos Number", "HIP 94183"},
        {"Smithsonian Astrophysical Observation", "SAO 48160"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.61448629),
        dec: Angle.Degrees(+48.44440571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16508"},
        {"Hipparcos Number", "HIP 12459"},
        {"Smithsonian Astrophysical Observation", "SAO 38208"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.10974880),
        dec: Angle.Degrees(+48.44471218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14751"},
        {"Hipparcos Number", "HIP 11197"},
        {"Smithsonian Astrophysical Observation", "SAO 38003"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.04982916),
        dec: Angle.Degrees(+48.44520946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220523"},
        {"Hipparcos Number", "HIP 115514"},
        {"Smithsonian Astrophysical Observation", "SAO 52977"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.99549072),
        dec: Angle.Degrees(+48.44650523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19648"},
        {"Smithsonian Astrophysical Observation", "SAO 39380"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.15337939),
        dec: Angle.Degrees(+48.45127575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193006"},
        {"Hipparcos Number", "HIP 99885"},
        {"Smithsonian Astrophysical Observation", "SAO 49397"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.98760867),
        dec: Angle.Degrees(+48.45144094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109158"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.66636200),
        dec: Angle.Degrees(+48.45191468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17315"},
        {"Hipparcos Number", "HIP 13104"},
        {"Smithsonian Astrophysical Observation", "SAO 38348"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.12466905),
        dec: Angle.Degrees(+48.45415549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160291"},
        {"Hipparcos Number", "HIP 86173"},
        {"Geneva Identification System", "GEN# +1.00160291"},
        {"Smithsonian Astrophysical Observation", "SAO 46836"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.14134418),
        dec: Angle.Degrees(+48.45805911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88420",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11028 B"},
        {"Hipparcos Number", "HIP 88420"},
        {"Geneva Identification System", "GEN# +1.00165358B"},
        {"Geneva Identification System 2", "GEN# +1.20165358"},
        {"Wilson Evans Batten Catalogue", "WEB 14949"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79600482),
        dec: Angle.Degrees(+48.45980767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58641"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.37028864),
        dec: Angle.Degrees(+48.46031879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139875"},
        {"Hipparcos Number", "HIP 76592"},
        {"Smithsonian Astrophysical Observation", "SAO 45655"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.63847358),
        dec: Angle.Degrees(+48.46275227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3111"},
        {"Smithsonian Astrophysical Observation", "SAO 36556"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.90202871),
        dec: Angle.Degrees(+48.46351579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55894"},
        {"Hipparcos Number", "HIP 35277"},
        {"Smithsonian Astrophysical Observation", "SAO 41661"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32391595),
        dec: Angle.Degrees(+48.46413477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11028 A"},
        {"Henry Draper", "HD 165358"},
        {"Hipparcos Number", "HIP 88415"},
        {"Geneva Identification System", "GEN# +1.00165358A"},
        {"Smithsonian Astrophysical Observation", "SAO 47173"},
        {"Wilson Evans Batten Catalogue", "WEB 14947"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.78697484),
        dec: Angle.Degrees(+48.46423648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164940"},
        {"Hipparcos Number", "HIP 88232"},
        {"Smithsonian Astrophysical Observation", "SAO 47141"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.26435981),
        dec: Angle.Degrees(+48.46547104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37514"},
        {"Hipparcos Number", "HIP 26827"},
        {"Fundamental Katalog 5th Edition", "FK5 4520"},
        {"Smithsonian Astrophysical Observation", "SAO 40537"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.44211299),
        dec: Angle.Degrees(+48.46553498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111421"},
        {"Hipparcos Number", "HIP 62516"},
        {"Geneva Identification System", "GEN# +1.00111421"},
        {"Renson", "Renson 32360"},
        {"Smithsonian Astrophysical Observation", "SAO 44332"},
        {"Wilson Evans Batten Catalogue", "WEB 11096"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.17441404),
        dec: Angle.Degrees(+48.46681210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42418"},
        {"Hipparcos Number", "HIP 29523"},
        {"Smithsonian Astrophysical Observation", "SAO 40945"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.29994052),
        dec: Angle.Degrees(+48.46778999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131597"},
        {"Hipparcos Number", "HIP 72803"},
        {"Geneva Identification System", "GEN# +1.00131597"},
        {"Smithsonian Astrophysical Observation", "SAO 45256"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.21577332),
        dec: Angle.Degrees(+48.46813838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14697"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.46692491),
        dec: Angle.Degrees(+48.47100932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85783"},
        {"Hipparcos Number", "HIP 48673"},
        {"Smithsonian Astrophysical Observation", "SAO 43102"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.89844921),
        dec: Angle.Degrees(+48.47101421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51639"},
        {"Hipparcos Number", "HIP 33755"},
        {"Smithsonian Astrophysical Observation", "SAO 41489"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16587410),
        dec: Angle.Degrees(+48.47550506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15"},
        {"Hipparcos Number", "HIP 437"},
        {"Geneva Identification System", "GEN# +1.00000015"},
        {"Smithsonian Astrophysical Observation", "SAO 36043"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.32451324),
        dec: Angle.Degrees(+48.47719511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76331"},
        {"Hipparcos Number", "HIP 43977"},
        {"Geneva Identification System", "GEN# +1.00076331"},
        {"Smithsonian Astrophysical Observation", "SAO 42614"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.33264357),
        dec: Angle.Degrees(+48.47822456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223819"},
        {"Hipparcos Number", "HIP 117754"},
        {"Smithsonian Astrophysical Observation", "SAO 53441"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20837671),
        dec: Angle.Degrees(+48.48180573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222086"},
        {"Hipparcos Number", "HIP 116562"},
        {"Geneva Identification System", "GEN# +1.00222086"},
        {"Smithsonian Astrophysical Observation", "SAO 53194"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.32575707),
        dec: Angle.Degrees(+48.48205597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41407"},
        {"Smithsonian Astrophysical Observation", "SAO 42357"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.69661190),
        dec: Angle.Degrees(+48.48217558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142143"},
        {"Hipparcos Number", "HIP 77619"},
        {"Smithsonian Astrophysical Observation", "SAO 45758"},
        {"Wilson Evans Batten Catalogue", "WEB 13134"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.69427714),
        dec: Angle.Degrees(+48.48306801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205117"},
        {"Hipparcos Number", "HIP 106297"},
        {"Celescope Catalog", "CEL 5334"},
        {"Geneva Identification System", "GEN# +2.70920075"},
        {"Renson", "Renson 57140"},
        {"Smithsonian Astrophysical Observation", "SAO 50985"},
        {"New General Catalogue", "NGC 7092 75"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.93607164),
        dec: Angle.Degrees(+48.48440052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15158 A"},
        {"Henry Draper", "HD 206041"},
        {"Hipparcos Number", "HIP 106812"},
        {"Celescope Catalog", "CEL 5355"},
        {"Geneva Identification System", "GEN# +1.00206041"},
        {"Smithsonian Astrophysical Observation", "SAO 51123"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.49739269),
        dec: Angle.Degrees(+48.48717863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23178"},
        {"Hipparcos Number", "HIP 17526"},
        {"Smithsonian Astrophysical Observation", "SAO 39075"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.28621231),
        dec: Angle.Degrees(+48.48732619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95211"},
        {"Hipparcos Number", "HIP 53790"},
        {"Geneva Identification System", "GEN# +1.00095211"},
        {"Smithsonian Astrophysical Observation", "SAO 43563"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.08389828),
        dec: Angle.Degrees(+48.48855253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6060"},
        {"Hipparcos Number", "HIP 4857"},
        {"Geneva Identification System", "GEN# +1.00006060"},
        {"Smithsonian Astrophysical Observation", "SAO 36867"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.61942555),
        dec: Angle.Degrees(+48.49036525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82792"},
        {"Hipparcos Number", "HIP 47094"},
        {"Geneva Identification System", "GEN# +1.00082792"},
        {"Smithsonian Astrophysical Observation", "SAO 42933"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.96153527),
        dec: Angle.Degrees(+48.49154046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8180"},
        {"Hipparcos Number", "HIP 6381"},
        {"Smithsonian Astrophysical Observation", "SAO 37150"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.49831188),
        dec: Angle.Degrees(+48.49168017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205665"},
        {"Hipparcos Number", "HIP 106606"},
        {"Smithsonian Astrophysical Observation", "SAO 51067"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.87143950),
        dec: Angle.Degrees(+48.49370582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15654"},
        {"Geneva Identification System", "GEN# +5.20200481"},
        {"Smithsonian Astrophysical Observation", "SAO 38746"},
        {"Wilson Evans Batten Catalogue", "WEB 3002"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.37589602),
        dec: Angle.Degrees(+48.49391728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11705"},
        {"Hipparcos Number", "HIP 9013"},
        {"Geneva Identification System", "GEN# +1.00011705"},
        {"Smithsonian Astrophysical Observation", "SAO 37617"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.00894848),
        dec: Angle.Degrees(+48.49444288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59416"},
        {"Smithsonian Astrophysical Observation", "SAO 44067"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.82415338),
        dec: Angle.Degrees(+48.49475878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219890"},
        {"Hipparcos Number", "HIP 115114"},
        {"Geneva Identification System", "GEN# +1.00219890"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.73750094),
        dec: Angle.Degrees(+48.49590958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50972"},
        {"Hipparcos Number", "HIP 33519"},
        {"Smithsonian Astrophysical Observation", "SAO 41465"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50330036),
        dec: Angle.Degrees(+48.49626608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222142"},
        {"Hipparcos Number", "HIP 116606"},
        {"Geneva Identification System", "GEN# +1.00222142"},
        {"Smithsonian Astrophysical Observation", "SAO 53209"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.46498918),
        dec: Angle.Degrees(+48.49657086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5879 AB"},
        {"Henry Draper", "HD 55078"},
        {"Hipparcos Number", "HIP 34946"},
        {"Smithsonian Astrophysical Observation", "SAO 41630"},
    },
    visualMagnitude: 7.26,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.46921649),
        dec: Angle.Degrees(+48.49884391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21527"},
        {"Hipparcos Number", "HIP 16318"},
        {"Geneva Identification System", "GEN# +5.20200885"},
        {"Renson", "Renson 5370"},
        {"Smithsonian Astrophysical Observation", "SAO 38884"},
        {"Wilson Evans Batten Catalogue", "WEB 3115"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.58046536),
        dec: Angle.Degrees(+48.49938329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15397"},
        {"Hipparcos Number", "HIP 11645"},
        {"Smithsonian Astrophysical Observation", "SAO 38070"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.55850101),
        dec: Angle.Degrees(+48.50157467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9229 AB"},
        {"Henry Draper", "HD 125796"},
        {"Hipparcos Number", "HIP 70066"},
        {"Geneva Identification System", "GEN# +1.00125796"},
        {"Smithsonian Astrophysical Observation", "SAO 45000"},
        {"Wilson Evans Batten Catalogue", "WEB 12183"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.07336207),
        dec: Angle.Degrees(+48.50704186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46794"},
        {"Hipparcos Number", "HIP 31710"},
        {"Geneva Identification System", "GEN# +1.00046794"},
        {"Smithsonian Astrophysical Observation", "SAO 41219"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.49848031),
        dec: Angle.Degrees(+48.50945538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177672"},
        {"Hipparcos Number", "HIP 93556"},
        {"Smithsonian Astrophysical Observation", "SAO 48038"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.82986515),
        dec: Angle.Degrees(+48.51000645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36064"},
        {"Smithsonian Astrophysical Observation", "SAO 41760"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.47887500),
        dec: Angle.Degrees(+48.51234256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186221"},
        {"Hipparcos Number", "HIP 96815"},
        {"Geneva Identification System", "GEN# +1.00186221"},
        {"Smithsonian Astrophysical Observation", "SAO 48720"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18915683),
        dec: Angle.Degrees(+48.51248142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11104"},
        {"Hipparcos Number", "HIP 8551"},
        {"Smithsonian Astrophysical Observation", "SAO 37552"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.57672369),
        dec: Angle.Degrees(+48.51571282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185396"},
        {"Hipparcos Number", "HIP 96457"},
        {"Smithsonian Astrophysical Observation", "SAO 48651"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.15643404),
        dec: Angle.Degrees(+48.51632255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101998"},
        {"Hipparcos Number", "HIP 57257"},
        {"Geneva Identification System", "GEN# +1.00101998"},
        {"Smithsonian Astrophysical Observation", "SAO 43880"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.12185973),
        dec: Angle.Degrees(+48.51639695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10465"},
        {"Hipparcos Number", "HIP 8034"},
        {"Smithsonian Astrophysical Observation", "SAO 37456"},
        {"Wilson Evans Batten Catalogue", "WEB 1720"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.79628206),
        dec: Angle.Degrees(+48.51677663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200615"},
        {"Hipparcos Number", "HIP 103872"},
        {"Geneva Identification System", "GEN# +1.00200615"},
        {"Renson", "Renson 55930"},
        {"Smithsonian Astrophysical Observation", "SAO 50392"},
        {"Wilson Evans Batten Catalogue", "WEB 18910"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.70339347),
        dec: Angle.Degrees(+48.51758415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163504"},
        {"Hipparcos Number", "HIP 87618"},
        {"Geneva Identification System", "GEN# +1.00163504"},
        {"Smithsonian Astrophysical Observation", "SAO 47047"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.47973127),
        dec: Angle.Degrees(+48.51847573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210404"},
        {"Hipparcos Number", "HIP 109338"},
        {"Fundamental Katalog 5th Edition", "FK5 5956"},
        {"Geneva Identification System", "GEN# +1.00210404"},
        {"Smithsonian Astrophysical Observation", "SAO 51693"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.25565499),
        dec: Angle.Degrees(+48.51872614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5111"},
        {"Hipparcos Number", "HIP 4192"},
        {"Smithsonian Astrophysical Observation", "SAO 36747"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.38896610),
        dec: Angle.Degrees(+48.51889752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203839"},
        {"Hipparcos Number", "HIP 105584"},
        {"Geneva Identification System", "GEN# +1.00203839"},
        {"Smithsonian Astrophysical Observation", "SAO 50783"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.78418209),
        dec: Angle.Degrees(+48.51898611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44569"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.20997850),
        dec: Angle.Degrees(+48.52192733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61658"},
        {"Hipparcos Number", "HIP 37571"},
        {"Smithsonian Astrophysical Observation", "SAO 41948"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.66278867),
        dec: Angle.Degrees(+48.52292219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17437",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2712 A"},
        {"Henry Draper", "HD 23049"},
        {"Hipparcos Number", "HIP 17437"},
        {"Geneva Identification System", "GEN# +1.00023049"},
        {"Smithsonian Astrophysical Observation", "SAO 39063"},
        {"Wilson Evans Batten Catalogue", "WEB 3298"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.02678089),
        dec: Angle.Degrees(+48.52368506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57582"},
        {"Smithsonian Astrophysical Observation", "SAO 43895"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.06122956),
        dec: Angle.Degrees(+48.52376926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86842"},
        {"Smithsonian Astrophysical Observation", "SAO 46927"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.16389723),
        dec: Angle.Degrees(+48.52991961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77601"},
        {"Hipparcos Number", "HIP 44613"},
        {"Geneva Identification System", "GEN# +1.00077601"},
        {"Smithsonian Astrophysical Observation", "SAO 42682"},
        {"Wilson Evans Batten Catalogue", "WEB 8537"},
    },
    visualMagnitude: 5.48,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.35044363),
        dec: Angle.Degrees(+48.53035841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105739"},
        {"Hipparcos Number", "HIP 59324"},
        {"Geneva Identification System", "GEN# +1.00105739"},
        {"Smithsonian Astrophysical Observation", "SAO 44060"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.55214609),
        dec: Angle.Degrees(+48.53130749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72526"},
        {"Smithsonian Astrophysical Observation", "SAO 45232"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.42508838),
        dec: Angle.Degrees(+48.53139514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104966",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104966"},
        {"Geneva Identification System", "GEN# +0.04703349"},
        {"Smithsonian Astrophysical Observation", "SAO 50633"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.92166591),
        dec: Angle.Degrees(+48.53148408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72441"},
        {"Hipparcos Number", "HIP 42101"},
        {"Smithsonian Astrophysical Observation", "SAO 42434"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.72297251),
        dec: Angle.Degrees(+48.53378578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17648"},
    },
    visualMagnitude: 12.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.70977512),
        dec: Angle.Degrees(+48.53773818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112758"},
        {"Smithsonian Astrophysical Observation", "SAO 52410"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.53015578),
        dec: Angle.Degrees(+48.54180728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92247",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92247"},
        {"Smithsonian Astrophysical Observation", "SAO 47818"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.00031392),
        dec: Angle.Degrees(+48.54219938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59088"},
        {"Smithsonian Astrophysical Observation", "SAO 44036"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.75713826),
        dec: Angle.Degrees(+48.54275284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213141"},
        {"Hipparcos Number", "HIP 110929"},
        {"Smithsonian Astrophysical Observation", "SAO 52040"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.12219974),
        dec: Angle.Degrees(+48.54289419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30280"},
        {"Hipparcos Number", "HIP 22331"},
        {"Smithsonian Astrophysical Observation", "SAO 39766"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14350270),
        dec: Angle.Degrees(+48.54440821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92953"},
        {"Hipparcos Number", "HIP 52568"},
        {"Smithsonian Astrophysical Observation", "SAO 43457"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.22685812),
        dec: Angle.Degrees(+48.54594143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41251"},
        {"Smithsonian Astrophysical Observation", "SAO 42344"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23942349),
        dec: Angle.Degrees(+48.54702490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111940"},
        {"Smithsonian Astrophysical Observation", "SAO 52252"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11538818),
        dec: Angle.Degrees(+48.54747170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220843"},
        {"Hipparcos Number", "HIP 115730"},
        {"Smithsonian Astrophysical Observation", "SAO 53031"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.69080168),
        dec: Angle.Degrees(+48.54765568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57950"},
        {"Hipparcos Number", "HIP 36056"},
        {"Smithsonian Astrophysical Observation", "SAO 41759"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.46653195),
        dec: Angle.Degrees(+48.54783287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208022"},
        {"Hipparcos Number", "HIP 107938"},
        {"Smithsonian Astrophysical Observation", "SAO 51387"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.01779759),
        dec: Angle.Degrees(+48.54877241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122236"},
        {"Hipparcos Number", "HIP 68356"},
        {"Smithsonian Astrophysical Observation", "SAO 44831"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.88791023),
        dec: Angle.Degrees(+48.54943236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100560"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.86437862),
        dec: Angle.Degrees(+48.55174844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208441"},
        {"Hipparcos Number", "HIP 108164"},
        {"Smithsonian Astrophysical Observation", "SAO 51432"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.71896601),
        dec: Angle.Degrees(+48.55465667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181490"},
        {"Hipparcos Number", "HIP 94874"},
        {"Smithsonian Astrophysical Observation", "SAO 48310"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.60127717),
        dec: Angle.Degrees(+48.55474210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3264"},
        {"Hipparcos Number", "HIP 2860"},
        {"Geneva Identification System", "GEN# +1.00003264"},
        {"Smithsonian Astrophysical Observation", "SAO 36504"},
        {"Wilson Evans Batten Catalogue", "WEB 515"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.06440006),
        dec: Angle.Degrees(+48.55577673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204002"},
        {"Hipparcos Number", "HIP 105659"},
        {"Geneva Identification System", "GEN# +1.00204002"},
        {"Smithsonian Astrophysical Observation", "SAO 50799"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.02492783),
        dec: Angle.Degrees(+48.55695453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25024"},
        {"Smithsonian Astrophysical Observation", "SAO 40264"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.36820853),
        dec: Angle.Degrees(+48.55888536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68664"},
        {"Smithsonian Astrophysical Observation", "SAO 44866"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.83643123),
        dec: Angle.Degrees(+48.55953409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32538"},
        {"Hipparcos Number", "HIP 23751"},
        {"Smithsonian Astrophysical Observation", "SAO 40019"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.57847864),
        dec: Angle.Degrees(+48.56066013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5555 AB"},
        {"Henry Draper", "HD 50363"},
        {"Hipparcos Number", "HIP 33284"},
        {"Smithsonian Astrophysical Observation", "SAO 41428"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.85512167),
        dec: Angle.Degrees(+48.56447538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1370"},
        {"Smithsonian Astrophysical Observation", "SAO 36235"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.28107877),
        dec: Angle.Degrees(+48.56457428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68970"},
        {"Hipparcos Number", "HIP 40567"},
        {"Smithsonian Astrophysical Observation", "SAO 42263"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.23715833),
        dec: Angle.Degrees(+48.56653191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191022"},
        {"Hipparcos Number", "HIP 98978"},
        {"Geneva Identification System", "GEN# +1.00191022"},
        {"Smithsonian Astrophysical Observation", "SAO 49176"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.41878307),
        dec: Angle.Degrees(+48.56680305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223345"},
        {"Hipparcos Number", "HIP 117435"},
        {"Smithsonian Astrophysical Observation", "SAO 53395"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.18037879),
        dec: Angle.Degrees(+48.56754353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21659"},
    },
    visualMagnitude: 11.36,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.75581540),
        dec: Angle.Degrees(+48.56797613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100485"},
        {"Hipparcos Number", "HIP 56424"},
        {"Geneva Identification System", "GEN# +1.00100485"},
        {"Smithsonian Astrophysical Observation", "SAO 43806"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.52993896),
        dec: Angle.Degrees(+48.56819299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13462",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2192 A"},
        {"Henry Draper", "HD 17818"},
        {"Hipparcos Number", "HIP 13462"},
        {"Geneva Identification System", "GEN# +1.00017818J"},
        {"Smithsonian Astrophysical Observation", "SAO 38418"},
        {"Wilson Evans Batten Catalogue", "WEB 2689"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.33778660),
        dec: Angle.Degrees(+48.56998491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168774"},
        {"Hipparcos Number", "HIP 89756"},
        {"Geneva Identification System", "GEN# +1.00168774"},
        {"Smithsonian Astrophysical Observation", "SAO 47385"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.74823333),
        dec: Angle.Degrees(+48.57030559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91576"},
    },
    visualMagnitude: 11.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.10317607),
        dec: Angle.Degrees(+48.57161176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13453"},
        {"Hipparcos Number", "HIP 10317"},
        {"Smithsonian Astrophysical Observation", "SAO 37862"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.22312658),
        dec: Angle.Degrees(+48.57166963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92400"},
        {"Hipparcos Number", "HIP 52289"},
        {"Geneva Identification System", "GEN# +1.00092400"},
        {"Smithsonian Astrophysical Observation", "SAO 43431"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.26448323),
        dec: Angle.Degrees(+48.57280347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216630"},
        {"Hipparcos Number", "HIP 113062"},
        {"Smithsonian Astrophysical Observation", "SAO 52466"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.45241611),
        dec: Angle.Degrees(+48.57375511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55377"},
        {"Smithsonian Astrophysical Observation", "SAO 43701"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.08873235),
        dec: Angle.Degrees(+48.57618135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54190"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.29287766),
        dec: Angle.Degrees(+48.57926903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74433",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9539 A"},
        {"Henry Draper", "HD 135364"},
        {"Hipparcos Number", "HIP 74433"},
        {"Smithsonian Astrophysical Observation", "SAO 45436"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.18231730),
        dec: Angle.Degrees(+48.58067264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184215"},
        {"Hipparcos Number", "HIP 95989"},
        {"Celescope Catalog", "CEL 4780"},
        {"Smithsonian Astrophysical Observation", "SAO 48544"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77322331),
        dec: Angle.Degrees(+48.58212383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71596"},
        {"Smithsonian Astrophysical Observation", "SAO 45150"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.64305342),
        dec: Angle.Degrees(+48.58342927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16452"},
        {"Smithsonian Astrophysical Observation", "SAO 38914"},
        {"Wilson Evans Batten Catalogue", "WEB 3143"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.98243616),
        dec: Angle.Degrees(+48.58387132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75329"},
        {"Hipparcos Number", "HIP 43469"},
        {"Smithsonian Astrophysical Observation", "SAO 42569"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.81586466),
        dec: Angle.Degrees(+48.58405673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205116"},
        {"Hipparcos Number", "HIP 106293"},
        {"Celescope Catalog", "CEL 5333"},
        {"Geneva Identification System", "GEN# +2.70920074"},
        {"Renson", "Renson 57130"},
        {"Smithsonian Astrophysical Observation", "SAO 50984"},
        {"New General Catalogue", "NGC 7092 74"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.92662929),
        dec: Angle.Degrees(+48.58466541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45715"},
        {"Smithsonian Astrophysical Observation", "SAO 42801"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.79559132),
        dec: Angle.Degrees(+48.58526724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160290"},
        {"Hipparcos Number", "HIP 86182"},
        {"Geneva Identification System", "GEN# +1.00160290"},
        {"Smithsonian Astrophysical Observation", "SAO 46838"},
        {"Wilson Evans Batten Catalogue", "WEB 14535"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.15677461),
        dec: Angle.Degrees(+48.58547866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47568"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.48580766),
        dec: Angle.Degrees(+48.58638947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23884"},
        {"Hipparcos Number", "HIP 17991"},
        {"Smithsonian Astrophysical Observation", "SAO 39140"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.68201492),
        dec: Angle.Degrees(+48.58678128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87113"},
        {"Hipparcos Number", "HIP 49330"},
        {"Geneva Identification System", "GEN# +1.00087113"},
        {"Smithsonian Astrophysical Observation", "SAO 43166"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.03708075),
        dec: Angle.Degrees(+48.59123277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184400"},
        {"Hipparcos Number", "HIP 96062"},
        {"Cincinnati Publication", "Ci 18 2549"},
        {"Geneva Identification System", "GEN# +1.00184400"},
        {"Smithsonian Astrophysical Observation", "SAO 48555"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.98315982),
        dec: Angle.Degrees(+48.59201634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 330.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125558"},
        {"Hipparcos Number", "HIP 69951"},
        {"Geneva Identification System", "GEN# +1.00125558"},
        {"Smithsonian Astrophysical Observation", "SAO 44991"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.71826856),
        dec: Angle.Degrees(+48.59256498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65800"},
        {"Hipparcos Number", "HIP 39357"},
        {"Smithsonian Astrophysical Observation", "SAO 42137"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.67703381),
        dec: Angle.Degrees(+48.59257252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22440"},
        {"Hipparcos Number", "HIP 16995"},
        {"Geneva Identification System", "GEN# +5.20201260"},
        {"Smithsonian Astrophysical Observation", "SAO 39009"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.64618335),
        dec: Angle.Degrees(+48.59355014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112813"},
        {"Hipparcos Number", "HIP 63343"},
        {"Smithsonian Astrophysical Observation", "SAO 44407"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70128146),
        dec: Angle.Degrees(+48.59550126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52802"},
        {"Smithsonian Astrophysical Observation", "SAO 43473"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.92069547),
        dec: Angle.Degrees(+48.59632534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88700"},
        {"Smithsonian Astrophysical Observation", "SAO 47223"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.61552530),
        dec: Angle.Degrees(+48.59640552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6694"},
        {"Hipparcos Number", "HIP 5349"},
        {"Smithsonian Astrophysical Observation", "SAO 36957"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.09833659),
        dec: Angle.Degrees(+48.59651577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106135"},
        {"Hipparcos Number", "HIP 59542"},
        {"Smithsonian Astrophysical Observation", "SAO 44078"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.16092103),
        dec: Angle.Degrees(+48.59728645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75857"},
        {"Smithsonian Astrophysical Observation", "SAO 45568"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.42693405),
        dec: Angle.Degrees(+48.60363377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20863"},
        {"Hipparcos Number", "HIP 15819"},
        {"Geneva Identification System", "GEN# +5.20200581"},
        {"Smithsonian Astrophysical Observation", "SAO 38779"},
        {"Wilson Evans Batten Catalogue", "WEB 3022"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.94711273),
        dec: Angle.Degrees(+48.60447866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90683"},
        {"Geneva Identification System", "GEN# +0.04802704"},
        {"Smithsonian Astrophysical Observation", "SAO 47545"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.54219819),
        dec: Angle.Degrees(+48.60466394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112484"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.76327012),
        dec: Angle.Degrees(+48.60553391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99073"},
        {"Hipparcos Number", "HIP 55682"},
        {"Smithsonian Astrophysical Observation", "SAO 43732"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.14378075),
        dec: Angle.Degrees(+48.60579165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82825"},
        {"Smithsonian Astrophysical Observation", "SAO 46374"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89118088),
        dec: Angle.Degrees(+48.61080008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6829"},
        {"Smithsonian Astrophysical Observation", "SAO 37233"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.96868106),
        dec: Angle.Degrees(+48.61135864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145727"},
        {"Hipparcos Number", "HIP 79236"},
        {"Geneva Identification System", "GEN# +1.00145727"},
        {"Smithsonian Astrophysical Observation", "SAO 45935"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.56703962),
        dec: Angle.Degrees(+48.61142124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65989"},
        {"Hipparcos Number", "HIP 39437"},
        {"Geneva Identification System", "GEN# +1.00065989"},
        {"Smithsonian Astrophysical Observation", "SAO 42143"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.92278825),
        dec: Angle.Degrees(+48.61179051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38848"},
        {"Hipparcos Number", "HIP 27651"},
        {"Geneva Identification System", "GEN# +1.00038848"},
        {"Smithsonian Astrophysical Observation", "SAO 40649"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.81678231),
        dec: Angle.Degrees(+48.61344897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16649",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2609 AB"},
        {"Henry Draper", "HD 21931"},
        {"Hipparcos Number", "HIP 16649"},
        {"Geneva Identification System", "GEN# +5.20201082J"},
        {"Smithsonian Astrophysical Observation", "SAO 38946"},
        {"Wilson Evans Batten Catalogue", "WEB 3175"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.55393833),
        dec: Angle.Degrees(+48.61753937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50507"},
        {"Smithsonian Astrophysical Observation", "SAO 43280"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.73503047),
        dec: Angle.Degrees(+48.61817685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63850"},
        {"Smithsonian Astrophysical Observation", "SAO 44457"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.28323344),
        dec: Angle.Degrees(+48.61856982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16662"},
        {"Hipparcos Number", "HIP 12589"},
        {"Smithsonian Astrophysical Observation", "SAO 38235"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.47854966),
        dec: Angle.Degrees(+48.61994513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9583",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1620 AB"},
        {"Henry Draper", "HD 12424"},
        {"Hipparcos Number", "HIP 9583"},
        {"Smithsonian Astrophysical Observation", "SAO 37731"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.78923278),
        dec: Angle.Degrees(+48.62050240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51397"},
        {"Hipparcos Number", "HIP 33668"},
        {"Smithsonian Astrophysical Observation", "SAO 41476"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.91873802),
        dec: Angle.Degrees(+48.62235782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136495"},
        {"Hipparcos Number", "HIP 74964"},
        {"Geneva Identification System", "GEN# +6.20034004"},
        {"Smithsonian Astrophysical Observation", "SAO 45486"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.78278912),
        dec: Angle.Degrees(+48.62276079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19457"},
        {"Hipparcos Number", "HIP 14673"},
        {"Geneva Identification System", "GEN# +5.20200050"},
        {"Smithsonian Astrophysical Observation", "SAO 38608"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.39540952),
        dec: Angle.Degrees(+48.62473876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207297"},
        {"Hipparcos Number", "HIP 107519"},
        {"Celescope Catalog", "CEL 5384"},
        {"Smithsonian Astrophysical Observation", "SAO 51287"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.63458195),
        dec: Angle.Degrees(+48.62505444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219945"},
        {"Hipparcos Number", "HIP 115152"},
        {"Geneva Identification System", "GEN# +1.00219945"},
        {"Smithsonian Astrophysical Observation", "SAO 52907"},
        {"Wilson Evans Batten Catalogue", "WEB 20401"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.87411644),
        dec: Angle.Degrees(+48.62519601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65019"},
        {"Hipparcos Number", "HIP 39005"},
        {"Smithsonian Astrophysical Observation", "SAO 42101"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.73851398),
        dec: Angle.Degrees(+48.62557970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201250"},
        {"Hipparcos Number", "HIP 104196"},
        {"Geneva Identification System", "GEN# +1.00201250"},
        {"Renson", "Renson 56153"},
        {"Smithsonian Astrophysical Observation", "SAO 50457"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.65366768),
        dec: Angle.Degrees(+48.62782579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91045"},
        {"Smithsonian Astrophysical Observation", "SAO 47613"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.58448538),
        dec: Angle.Degrees(+48.62790127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20487"},
        {"Hipparcos Number", "HIP 15505"},
        {"Geneva Identification System", "GEN# +5.20200423"},
        {"Smithsonian Astrophysical Observation", "SAO 38723"},
        {"Wilson Evans Batten Catalogue", "WEB 2979"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.94681830),
        dec: Angle.Degrees(+48.62798087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7607",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Nembus"},
        {"Henry Draper", "HD 9927"},
        {"Hipparcos Number", "HIP 7607"},
        {"Fundamental Katalog 5th Edition", "FK5 52"},
        {"Geneva Identification System", "GEN# +1.00009927"},
        {"Smithsonian Astrophysical Observation", "SAO 37375"},
        {"Wilson Evans Batten Catalogue", "WEB 1628"},
    },
    visualMagnitude: 3.59,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.49792651),
        dec: Angle.Degrees(+48.62848641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223998"},
        {"Hipparcos Number", "HIP 117867"},
        {"Smithsonian Astrophysical Observation", "SAO 53467"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.60757297),
        dec: Angle.Degrees(+48.63072418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87972"},
        {"Hipparcos Number", "HIP 49789"},
        {"Smithsonian Astrophysical Observation", "SAO 43214"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.45175824),
        dec: Angle.Degrees(+48.63144653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203340"},
        {"Hipparcos Number", "HIP 105321"},
        {"Geneva Identification System", "GEN# +1.00203340"},
        {"Smithsonian Astrophysical Observation", "SAO 50725"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.99163438),
        dec: Angle.Degrees(+48.63472914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113419"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.55323780),
        dec: Angle.Degrees(+48.63698128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110277"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.06295007),
        dec: Angle.Degrees(+48.63968003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195557"},
        {"Hipparcos Number", "HIP 101140"},
        {"Celescope Catalog", "CEL 5088"},
        {"Geneva Identification System", "GEN# +1.00195557"},
        {"Smithsonian Astrophysical Observation", "SAO 49714"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.52081773),
        dec: Angle.Degrees(+48.64139093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205796"},
        {"Hipparcos Number", "HIP 106670"},
        {"Geneva Identification System", "GEN# +1.00205796"},
        {"Smithsonian Astrophysical Observation", "SAO 51095"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.07469781),
        dec: Angle.Degrees(+48.64140896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113917"},
        {"Smithsonian Astrophysical Observation", "SAO 52648"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.03384125),
        dec: Angle.Degrees(+48.64237977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221074"},
        {"Hipparcos Number", "HIP 115874"},
        {"Geneva Identification System", "GEN# +1.00221074"},
        {"Smithsonian Astrophysical Observation", "SAO 53063"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.13905226),
        dec: Angle.Degrees(+48.64432815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58256"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.21490655),
        dec: Angle.Degrees(+48.64551188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114363"},
        {"Smithsonian Astrophysical Observation", "SAO 52747"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.42822062),
        dec: Angle.Degrees(+48.64680541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113305"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.18644218),
        dec: Angle.Degrees(+48.64741499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85695"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.68737814),
        dec: Angle.Degrees(+48.64843257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113359"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.37690565),
        dec: Angle.Degrees(+48.64949958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24240"},
        {"Hipparcos Number", "HIP 18212"},
        {"Geneva Identification System", "GEN# +1.00024240"},
        {"Smithsonian Astrophysical Observation", "SAO 39175"},
        {"Wilson Evans Batten Catalogue", "WEB 3510"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.41112532),
        dec: Angle.Degrees(+48.65056848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95907"},
        {"Smithsonian Astrophysical Observation", "SAO 48524"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.57218996),
        dec: Angle.Degrees(+48.65652656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136376"},
        {"Hipparcos Number", "HIP 74905"},
        {"Geneva Identification System", "GEN# +6.20034008"},
        {"Smithsonian Astrophysical Observation", "SAO 45479"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.62307771),
        dec: Angle.Degrees(+48.65683676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2804"},
        {"Hipparcos Number", "HIP 2514"},
        {"Smithsonian Astrophysical Observation", "SAO 36444"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.97004376),
        dec: Angle.Degrees(+48.65786294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2596"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.24550460),
        dec: Angle.Degrees(+48.65825780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32499"},
        {"Hipparcos Number", "HIP 23729"},
        {"Smithsonian Astrophysical Observation", "SAO 40015"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.52252369),
        dec: Angle.Degrees(+48.65972039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108380"},
        {"Hipparcos Number", "HIP 60728"},
        {"Fundamental Katalog 5th Edition", "FK5 5096"},
        {"Geneva Identification System", "GEN# +1.00108380"},
        {"Smithsonian Astrophysical Observation", "SAO 44180"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.70263280),
        dec: Angle.Degrees(+48.66154270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205778"},
        {"Hipparcos Number", "HIP 106650"},
        {"Celescope Catalog", "CEL 5349"},
        {"Geneva Identification System", "GEN# +1.00205778"},
        {"Smithsonian Astrophysical Observation", "SAO 51090"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.03926993),
        dec: Angle.Degrees(+48.66726768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21800"},
        {"Smithsonian Astrophysical Observation", "SAO 39686"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.25223562),
        dec: Angle.Degrees(+48.66825206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208727"},
        {"Hipparcos Number", "HIP 108348"},
        {"Celescope Catalog", "CEL 5409"},
        {"Fundamental Katalog 5th Edition", "FK5 3754"},
        {"Geneva Identification System", "GEN# +1.00208727"},
        {"Smithsonian Astrophysical Observation", "SAO 51477"},
        {"Wilson Evans Batten Catalogue", "WEB 19516"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25925036),
        dec: Angle.Degrees(+48.66856413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38216"},
        {"Hipparcos Number", "HIP 27267"},
        {"Geneva Identification System", "GEN# +1.00038216"},
        {"Smithsonian Astrophysical Observation", "SAO 40597"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69121503),
        dec: Angle.Degrees(+48.66968790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131526"},
        {"Hipparcos Number", "HIP 72749"},
        {"Geneva Identification System", "GEN# +1.00131526"},
        {"Smithsonian Astrophysical Observation", "SAO 45252"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.08753275),
        dec: Angle.Degrees(+48.67079828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57592"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.10843982),
        dec: Angle.Degrees(+48.67262785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210697"},
        {"Hipparcos Number", "HIP 109514"},
        {"Celescope Catalog", "CEL 5449"},
        {"Geneva Identification System", "GEN# +1.00210697"},
        {"Smithsonian Astrophysical Observation", "SAO 51738"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.76999151),
        dec: Angle.Degrees(+48.67739197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5273"},
        {"Hipparcos Number", "HIP 4298"},
        {"Geneva Identification System", "GEN# +1.00005273"},
        {"Smithsonian Astrophysical Observation", "SAO 36763"},
        {"Wilson Evans Batten Catalogue", "WEB 774"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.77176755),
        dec: Angle.Degrees(+48.67854824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103658",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14531 AB"},
        {"Henry Draper", "HD 200177"},
        {"Hipparcos Number", "HIP 103658"},
        {"Celescope Catalog", "CEL 5229"},
        {"Geneva Identification System", "GEN# +1.00200177J"},
        {"Renson", "Renson 55750"},
        {"Smithsonian Astrophysical Observation", "SAO 50340"},
        {"Wilson Evans Batten Catalogue", "WEB 18865"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.02749524),
        dec: Angle.Degrees(+48.67943262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 754"},
        {"Hipparcos Number", "HIP 972"},
        {"Smithsonian Astrophysical Observation", "SAO 36149"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.00807432),
        dec: Angle.Degrees(+48.68005386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60063"},
        {"Hipparcos Number", "HIP 36893"},
        {"Geneva Identification System", "GEN# +1.00060063"},
        {"Smithsonian Astrophysical Observation", "SAO 41864"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.78087697),
        dec: Angle.Degrees(+48.68075606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46361"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.79214980),
        dec: Angle.Degrees(+48.68109176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51969"},
        {"Smithsonian Astrophysical Observation", "SAO 43408"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.26479755),
        dec: Angle.Degrees(+48.68131888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18843"},
        {"Hipparcos Number", "HIP 14243"},
        {"Smithsonian Astrophysical Observation", "SAO 38536"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.91859931),
        dec: Angle.Degrees(+48.68352826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217050"},
        {"Hipparcos Number", "HIP 113327"},
        {"Fundamental Katalog 5th Edition", "FK5 3833"},
        {"Geneva Identification System", "GEN# +1.00217050"},
        {"Smithsonian Astrophysical Observation", "SAO 52526"},
        {"Wilson Evans Batten Catalogue", "WEB 20163"},
    },
    visualMagnitude: 5.34,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26872427),
        dec: Angle.Degrees(+48.68408117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108888",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15588 A"},
        {"Henry Draper", "HD 209595"},
        {"Hipparcos Number", "HIP 108888"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.85468076),
        dec: Angle.Degrees(+48.68416717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37615"},
        {"Smithsonian Astrophysical Observation", "SAO 41956"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.77682150),
        dec: Angle.Degrees(+48.68614595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141825"},
        {"Hipparcos Number", "HIP 77465"},
        {"Smithsonian Astrophysical Observation", "SAO 45747"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.23954159),
        dec: Angle.Degrees(+48.68717211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71655"},
        {"Smithsonian Astrophysical Observation", "SAO 45156"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.85095328),
        dec: Angle.Degrees(+48.68827793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36054"},
        {"Smithsonian Astrophysical Observation", "SAO 41757"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.45856156),
        dec: Angle.Degrees(+48.68917345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160676"},
        {"Hipparcos Number", "HIP 86350"},
        {"Smithsonian Astrophysical Observation", "SAO 46861"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.68055050),
        dec: Angle.Degrees(+48.69207027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13831 A"},
        {"Henry Draper", "HD 194614"},
        {"Hipparcos Number", "HIP 100657"},
        {"Celescope Catalog", "CEL 5054"},
        {"Geneva Identification System", "GEN# +1.00194614"},
        {"Smithsonian Astrophysical Observation", "SAO 49590"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.14717935),
        dec: Angle.Degrees(+48.69279731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135100"},
        {"Hipparcos Number", "HIP 74320"},
        {"Geneva Identification System", "GEN# +1.00135100"},
        {"Smithsonian Astrophysical Observation", "SAO 45424"},
        {"Wilson Evans Batten Catalogue", "WEB 12686"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.86096797),
        dec: Angle.Degrees(+48.69293630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93011"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.22235351),
        dec: Angle.Degrees(+48.69399639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20017"},
        {"Hipparcos Number", "HIP 15114"},
        {"Geneva Identification System", "GEN# +5.20200247"},
        {"Smithsonian Astrophysical Observation", "SAO 38672"},
        {"Wilson Evans Batten Catalogue", "WEB 2911"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73046618),
        dec: Angle.Degrees(+48.69579891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94761"},
        {"Hipparcos Number", "HIP 53528"},
        {"Smithsonian Astrophysical Observation", "SAO 43540"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.27850522),
        dec: Angle.Degrees(+48.69750618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82414"},
        {"Smithsonian Astrophysical Observation", "SAO 46320"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.63187878),
        dec: Angle.Degrees(+48.69769171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78992"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.85671328),
        dec: Angle.Degrees(+48.69868080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18180"},
        {"Hipparcos Number", "HIP 13741"},
        {"Geneva Identification System", "GEN# +1.00018180"},
        {"Smithsonian Astrophysical Observation", "SAO 38460"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.22998978),
        dec: Angle.Degrees(+48.70400971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76575"},
        {"Smithsonian Astrophysical Observation", "SAO 45653"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.57288033),
        dec: Angle.Degrees(+48.70467610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9339 A"},
        {"Henry Draper", "HD 129308"},
        {"Hipparcos Number", "HIP 71723"},
        {"Smithsonian Astrophysical Observation", "SAO 45163"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.07008340),
        dec: Angle.Degrees(+48.70888859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7745 AB"},
        {"Hipparcos Number", "HIP 50875"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.82451111),
        dec: Angle.Degrees(+48.71097316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29388",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4773 AB"},
        {"Hipparcos Number", "HIP 29388"},
        {"Geneva Identification System", "GEN# +1.00042127"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.90241065),
        dec: Angle.Degrees(+48.71112468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37051",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37051"},
        {"Smithsonian Astrophysical Observation", "SAO 41881"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.20709692),
        dec: Angle.Degrees(+48.71181207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1263 AB"},
        {"Henry Draper", "HD 9841"},
        {"Hipparcos Number", "HIP 7540"},
        {"Geneva Identification System", "GEN# +1.00009841"},
        {"Smithsonian Astrophysical Observation", "SAO 37367"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.28968010),
        dec: Angle.Degrees(+48.71187032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206111"},
        {"Hipparcos Number", "HIP 106849"},
        {"Smithsonian Astrophysical Observation", "SAO 51133"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.62092756),
        dec: Angle.Degrees(+48.71362593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51230"},
        {"Smithsonian Astrophysical Observation", "SAO 43347"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.95848246),
        dec: Angle.Degrees(+48.71562152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205171"},
        {"Hipparcos Number", "HIP 106329"},
        {"Geneva Identification System", "GEN# +2.70920084"},
        {"Renson", "Renson 57157"},
        {"Smithsonian Astrophysical Observation", "SAO 50997"},
        {"New General Catalogue", "NGC 7092 84"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02811338),
        dec: Angle.Degrees(+48.71649337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180501"},
        {"Hipparcos Number", "HIP 94538"},
        {"Celescope Catalog", "CEL 4726"},
        {"Geneva Identification System", "GEN# +1.00180501"},
        {"Smithsonian Astrophysical Observation", "SAO 48232"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.60987037),
        dec: Angle.Degrees(+48.71930898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26974"},
        {"Hipparcos Number", "HIP 20067"},
        {"Geneva Identification System", "GEN# +1.00026974"},
        {"Smithsonian Astrophysical Observation", "SAO 39443"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.54711840),
        dec: Angle.Degrees(+48.71994149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72524",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9406 AB"},
        {"Henry Draper", "HD 131041"},
        {"Hipparcos Number", "HIP 72524"},
        {"Geneva Identification System", "GEN# +1.00131041J"},
        {"Smithsonian Astrophysical Observation", "SAO 45231"},
        {"Wilson Evans Batten Catalogue", "WEB 12472"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.42233956),
        dec: Angle.Degrees(+48.72056284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 259"},
        {"Smithsonian Astrophysical Observation", "SAO 36021"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.80590410),
        dec: Angle.Degrees(+48.72233890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9746"},
        {"Hipparcos Number", "HIP 7493"},
        {"Geneva Identification System", "GEN# +1.00009746"},
        {"Smithsonian Astrophysical Observation", "SAO 37351"},
        {"Wilson Evans Batten Catalogue", "WEB 1603"},
    },
    visualMagnitude: 6.20,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.11339268),
        dec: Angle.Degrees(+48.72282149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153957"},
        {"Hipparcos Number", "HIP 83198"},
        {"Geneva Identification System", "GEN# +1.00153957"},
        {"Smithsonian Astrophysical Observation", "SAO 46432"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.04241618),
        dec: Angle.Degrees(+48.72450469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62157"},
        {"Hipparcos Number", "HIP 37785"},
        {"Geneva Identification System", "GEN# +1.00062157"},
        {"Smithsonian Astrophysical Observation", "SAO 41971"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.22269419),
        dec: Angle.Degrees(+48.72827122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30567"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.37591062),
        dec: Angle.Degrees(+48.72865222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -399.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59748"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.78772789),
        dec: Angle.Degrees(+48.73270130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216321"},
        {"Hipparcos Number", "HIP 112850"},
        {"Geneva Identification System", "GEN# +1.00216321"},
        {"Smithsonian Astrophysical Observation", "SAO 52426"},
        {"Wilson Evans Batten Catalogue", "WEB 20099"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.80547840),
        dec: Angle.Degrees(+48.73324506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24718"},
        {"Hipparcos Number", "HIP 18546"},
        {"Smithsonian Astrophysical Observation", "SAO 39214"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.51247927),
        dec: Angle.Degrees(+48.73330441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27684",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4439 D"},
        {"Hipparcos Number", "HIP 27684"},
        {"Smithsonian Astrophysical Observation", "SAO 40654"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.91382675),
        dec: Angle.Degrees(+48.73495515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21672"},
        {"Hipparcos Number", "HIP 16450"},
        {"Geneva Identification System", "GEN# +5.20200965"},
        {"Smithsonian Astrophysical Observation", "SAO 38913"},
        {"Wilson Evans Batten Catalogue", "WEB 3142"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.97469738),
        dec: Angle.Degrees(+48.73521837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8354"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91972383),
        dec: Angle.Degrees(+48.73748317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111572"},
        {"Hipparcos Number", "HIP 62600"},
        {"Geneva Identification System", "GEN# +1.00111572"},
        {"Smithsonian Astrophysical Observation", "SAO 44343"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.40854567),
        dec: Angle.Degrees(+48.74004824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30557"},
        {"Hipparcos Number", "HIP 22545"},
        {"Fundamental Katalog 5th Edition", "FK5 2361"},
        {"Geneva Identification System", "GEN# +1.00030557"},
        {"Smithsonian Astrophysical Observation", "SAO 39799"},
        {"Wilson Evans Batten Catalogue", "WEB 4356"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.78901570),
        dec: Angle.Degrees(+48.74075831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50296",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7698 AB"},
        {"Hipparcos Number", "HIP 50296"},
        {"Smithsonian Astrophysical Observation", "SAO 43252"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.03966664),
        dec: Angle.Degrees(+48.74144140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201612"},
        {"Hipparcos Number", "HIP 104404"},
        {"Fundamental Katalog 5th Edition", "FK5 5863"},
        {"Geneva Identification System", "GEN# +1.00201612"},
        {"Smithsonian Astrophysical Observation", "SAO 50501"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.26014064),
        dec: Angle.Degrees(+48.74579386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2369"},
        {"Hipparcos Number", "HIP 2199"},
        {"Smithsonian Astrophysical Observation", "SAO 36384"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.95112894),
        dec: Angle.Degrees(+48.74760265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213496"},
        {"Hipparcos Number", "HIP 111132"},
        {"Smithsonian Astrophysical Observation", "SAO 52092"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.69799868),
        dec: Angle.Degrees(+48.75176526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82581"},
        {"Hipparcos Number", "HIP 46981"},
        {"Smithsonian Astrophysical Observation", "SAO 42926"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.63243933),
        dec: Angle.Degrees(+48.75468580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214037"},
        {"Hipparcos Number", "HIP 111442"},
        {"Geneva Identification System", "GEN# +1.00214037"},
        {"Smithsonian Astrophysical Observation", "SAO 52157"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.65141842),
        dec: Angle.Degrees(+48.75622277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97569"},
        {"Hipparcos Number", "HIP 54882"},
        {"Smithsonian Astrophysical Observation", "SAO 43652"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.56376447),
        dec: Angle.Degrees(+48.75880050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199889"},
        {"Hipparcos Number", "HIP 103506"},
        {"Geneva Identification System", "GEN# +1.00199889"},
        {"Smithsonian Astrophysical Observation", "SAO 50300"},
        {"Wilson Evans Batten Catalogue", "WEB 18826"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.55647906),
        dec: Angle.Degrees(+48.76075493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11344"},
        {"Henry Draper", "HD 170109"},
        {"Hipparcos Number", "HIP 90284"},
        {"Geneva Identification System", "GEN# +1.00170109"},
        {"Smithsonian Astrophysical Observation", "SAO 47482"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.32584543),
        dec: Angle.Degrees(+48.76180981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24854"},
        {"Hipparcos Number", "HIP 18637"},
        {"Smithsonian Astrophysical Observation", "SAO 39225"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.83831187),
        dec: Angle.Degrees(+48.76208704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174481"},
        {"Hipparcos Number", "HIP 92269"},
        {"Fundamental Katalog 5th Edition", "FK5 3497"},
        {"Geneva Identification System", "GEN# +1.00174481"},
        {"Smithsonian Astrophysical Observation", "SAO 47823"},
        {"Wilson Evans Batten Catalogue", "WEB 15921"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.06704599),
        dec: Angle.Degrees(+48.76743801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196708"},
        {"Hipparcos Number", "HIP 101727"},
        {"Smithsonian Astrophysical Observation", "SAO 49868"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30163066),
        dec: Angle.Degrees(+48.76816928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66190"},
    },
    visualMagnitude: 10.31,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.49710637),
        dec: Angle.Degrees(+48.76874077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95092"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.19024944),
        dec: Angle.Degrees(+48.77045379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137423"},
        {"Hipparcos Number", "HIP 75371"},
        {"Geneva Identification System", "GEN# +6.20034007"},
        {"Smithsonian Astrophysical Observation", "SAO 45522"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.02732864),
        dec: Angle.Degrees(+48.77049189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113042"},
        {"Smithsonian Astrophysical Observation", "SAO 52464"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.40161295),
        dec: Angle.Degrees(+48.77348993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60652"},
        {"Hipparcos Number", "HIP 37140"},
        {"Geneva Identification System", "GEN# +1.00060652"},
        {"Renson", "Renson 16570"},
        {"Smithsonian Astrophysical Observation", "SAO 41893"},
        {"Wilson Evans Batten Catalogue", "WEB 7361"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.47449454),
        dec: Angle.Degrees(+48.77391150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218585"},
        {"Hipparcos Number", "HIP 114274"},
        {"Geneva Identification System", "GEN# +1.00218585"},
        {"Smithsonian Astrophysical Observation", "SAO 52731"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.17107669),
        dec: Angle.Degrees(+48.77526807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65156"},
        {"Hipparcos Number", "HIP 39072"},
        {"Geneva Identification System", "GEN# +1.00065156"},
        {"Smithsonian Astrophysical Observation", "SAO 42108"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.90825155),
        dec: Angle.Degrees(+48.77627874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83804"},
        {"Hipparcos Number", "HIP 47605"},
        {"Cincinnati Publication", "Ci 18 1151"},
        {"Smithsonian Astrophysical Observation", "SAO 42986"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.60463094),
        dec: Angle.Degrees(+48.77655099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45004"},
        {"Hipparcos Number", "HIP 30745"},
        {"Geneva Identification System", "GEN# +1.00045004"},
        {"Smithsonian Astrophysical Observation", "SAO 41106"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.90959286),
        dec: Angle.Degrees(+48.77675776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65800"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.31789421),
        dec: Angle.Degrees(+48.77764300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186686"},
        {"Hipparcos Number", "HIP 97068"},
        {"Geneva Identification System", "GEN# +1.00186686"},
        {"Smithsonian Astrophysical Observation", "SAO 48773"},
        {"Wilson Evans Batten Catalogue", "WEB 17035"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.90739937),
        dec: Angle.Degrees(+48.77811637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101135"},
        {"Smithsonian Astrophysical Observation", "SAO 49709"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.50480641),
        dec: Angle.Degrees(+48.77925669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155829"},
        {"Hipparcos Number", "HIP 84091"},
        {"Smithsonian Astrophysical Observation", "SAO 46553"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.87249137),
        dec: Angle.Degrees(+48.77964016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23198"},
        {"Wilson Evans Batten Catalogue", "WEB 4502"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.88303111),
        dec: Angle.Degrees(+48.77986543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13690"},
        {"Hipparcos Number", "HIP 10462"},
        {"Geneva Identification System", "GEN# +1.00013690"},
        {"Smithsonian Astrophysical Observation", "SAO 37891"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.71880011),
        dec: Angle.Degrees(+48.78242880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115046"},
        {"Wilson Evans Batten Catalogue", "WEB 20382"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.50978272),
        dec: Angle.Degrees(+48.78287790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7271"},
        {"Hipparcos Number", "HIP 5747"},
        {"Smithsonian Astrophysical Observation", "SAO 37039"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.45267073),
        dec: Angle.Degrees(+48.78699707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90508"},
        {"Hipparcos Number", "HIP 51248"},
        {"Cincinnati Publication", "Ci 20 577"},
        {"Geneva Identification System", "GEN# +1.00090508J"},
        {"Smithsonian Astrophysical Observation", "SAO 43351"},
        {"Wilson Evans Batten Catalogue", "WEB 9365"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.01587881),
        dec: Angle.Degrees(+48.78704437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -881.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222515"},
        {"Hipparcos Number", "HIP 116848"},
        {"Geneva Identification System", "GEN# +1.00222515"},
        {"Smithsonian Astrophysical Observation", "SAO 53269"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.27274269),
        dec: Angle.Degrees(+48.78710315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48781"},
        {"Hipparcos Number", "HIP 32562"},
        {"Fundamental Katalog 5th Edition", "FK5 1176"},
        {"Geneva Identification System", "GEN# +1.00048781"},
        {"Smithsonian Astrophysical Observation", "SAO 41346"},
        {"Wilson Evans Batten Catalogue", "WEB 6566"},
    },
    visualMagnitude: 5.22,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.91491974),
        dec: Angle.Degrees(+48.78946087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100055"},
        {"Hipparcos Number", "HIP 56194"},
        {"Geneva Identification System", "GEN# +1.00100055"},
        {"Smithsonian Astrophysical Observation", "SAO 43793"},
        {"Wilson Evans Batten Catalogue", "WEB 10094"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.79282933),
        dec: Angle.Degrees(+48.78963578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27981"},
        {"Hipparcos Number", "HIP 20796"},
        {"Smithsonian Astrophysical Observation", "SAO 39539"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.84498843),
        dec: Angle.Degrees(+48.79090143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202766"},
        {"Hipparcos Number", "HIP 105030"},
        {"Smithsonian Astrophysical Observation", "SAO 50657"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.11170041),
        dec: Angle.Degrees(+48.79247417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
