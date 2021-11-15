using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_89() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208640"},
        {"Hipparcos Number", "HIP 108338"},
        {"Smithsonian Astrophysical Observation", "SAO 71866"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.23281325),
        dec: Angle.Degrees(+31.86076126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84937"},
        {"Smithsonian Astrophysical Observation", "SAO 65978"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.38831933),
        dec: Angle.Degrees(+31.86105447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116856"},
        {"Hipparcos Number", "HIP 65526"},
        {"Geneva Identification System", "GEN# +1.00116856"},
        {"Smithsonian Astrophysical Observation", "SAO 63533"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.48260446),
        dec: Angle.Degrees(+31.86139137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74057"},
        {"Hipparcos Number", "HIP 42753"},
        {"Geneva Identification System", "GEN# +1.00074057"},
        {"Smithsonian Astrophysical Observation", "SAO 61003"},
        {"Wilson Evans Batten Catalogue", "WEB 8257"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.69264192),
        dec: Angle.Degrees(+31.86270164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58830"},
        {"Hipparcos Number", "HIP 36322"},
        {"Geneva Identification System", "GEN# +1.00058830"},
        {"Smithsonian Astrophysical Observation", "SAO 60106"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.14923495),
        dec: Angle.Degrees(+31.86392737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108153"},
        {"Hipparcos Number", "HIP 60605"},
        {"Cincinnati Publication", "Ci 20 705"},
        {"Cincinnati Publication 2", "Ci 18 1566"},
        {"Geneva Identification System", "GEN# +1.00108153"},
        {"Smithsonian Astrophysical Observation", "SAO 62996"},
        {"Wilson Evans Batten Catalogue", "WEB 10780"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.32811968),
        dec: Angle.Degrees(+31.86483392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -353.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121625"},
        {"Hipparcos Number", "HIP 68046"},
        {"Smithsonian Astrophysical Observation", "SAO 63835"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.99097964),
        dec: Angle.Degrees(+31.86504891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108857"},
        {"Smithsonian Astrophysical Observation", "SAO 71982"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.78861259),
        dec: Angle.Degrees(+31.86584923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88976"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.41951352),
        dec: Angle.Degrees(+31.86975819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102089"},
        {"Smithsonian Astrophysical Observation", "SAO 70372"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.34012830),
        dec: Angle.Degrees(+31.86998561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119315"},
        {"Hipparcos Number", "HIP 66855"},
        {"Geneva Identification System", "GEN# +1.00119315"},
        {"Smithsonian Astrophysical Observation", "SAO 63690"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.52172298),
        dec: Angle.Degrees(+31.87002433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 249"},
        {"Fundamental Katalog 5th Edition", "FK5 4005"},
        {"Smithsonian Astrophysical Observation", "SAO 53601"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.77419621),
        dec: Angle.Degrees(+31.87010321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70230"},
        {"Smithsonian Astrophysical Observation", "SAO 64099"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.51888055),
        dec: Angle.Degrees(+31.87297592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246361"},
        {"Hipparcos Number", "HIP 26863"},
        {"Geneva Identification System", "GEN# +1.00246361"},
        {"Smithsonian Astrophysical Observation", "SAO 58349"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.55212340),
        dec: Angle.Degrees(+31.87335731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40140"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.96334858),
        dec: Angle.Degrees(+31.87358579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124138"},
        {"Hipparcos Number", "HIP 69283"},
        {"Geneva Identification System", "GEN# +1.00124138"},
        {"Smithsonian Astrophysical Observation", "SAO 63975"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.73894843),
        dec: Angle.Degrees(+31.87365187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331172"},
        {"Hipparcos Number", "HIP 97092"},
        {"Geneva Identification System", "GEN# +1.00331172"},
        {"Smithsonian Astrophysical Observation", "SAO 68765"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.98409081),
        dec: Angle.Degrees(+31.87403609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143893"},
        {"Hipparcos Number", "HIP 78516"},
        {"Geneva Identification System", "GEN# +1.00143893"},
        {"Smithsonian Astrophysical Observation", "SAO 65028"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.44030140),
        dec: Angle.Degrees(+31.87619458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80634"},
        {"Smithsonian Astrophysical Observation", "SAO 65318"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.96528378),
        dec: Angle.Degrees(+31.87692225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82354"},
        {"Hipparcos Number", "HIP 46809"},
        {"Smithsonian Astrophysical Observation", "SAO 61549"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.07586133),
        dec: Angle.Degrees(+31.87785696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101091"},
        {"Hipparcos Number", "HIP 56750"},
        {"Geneva Identification System", "GEN# +1.00101091"},
        {"Smithsonian Astrophysical Observation", "SAO 62632"},
        {"Wilson Evans Batten Catalogue", "WEB 10208"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52337252),
        dec: Angle.Degrees(+31.88089336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121696"},
        {"Hipparcos Number", "HIP 68082"},
        {"Geneva Identification System", "GEN# +1.00121696"},
        {"Smithsonian Astrophysical Observation", "SAO 63841"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.08565296),
        dec: Angle.Degrees(+31.88175168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18246",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2843 A"},
        {"Henry Draper", "HD 24398"},
        {"Hipparcos Number", "HIP 18246"},
        {"Fundamental Katalog 5th Edition", "FK5 144"},
        {"Geneva Identification System", "GEN# +1.00024398A"},
        {"Smithsonian Astrophysical Observation", "SAO 56799"},
        {"Wilson Evans Batten Catalogue", "WEB 3522"},
    },
    visualMagnitude: 2.84,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.53299363),
        dec: Angle.Degrees(+31.88365776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154126"},
        {"Hipparcos Number", "HIP 83365"},
        {"Geneva Identification System", "GEN# +1.00154126"},
        {"Smithsonian Astrophysical Observation", "SAO 65745"},
        {"Wilson Evans Batten Catalogue", "WEB 14090"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.57121184),
        dec: Angle.Degrees(+31.88406501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160541"},
        {"Hipparcos Number", "HIP 86392"},
        {"Smithsonian Astrophysical Observation", "SAO 66218"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.78964142),
        dec: Angle.Degrees(+31.88626119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36850",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Castor"},
        {"Common Name 2", "Castor AB"},
        {"Aitken", "ADS 6175 AB"},
        {"Henry Draper", "HD 60178J"},
        {"Hipparcos Number", "HIP 36850"},
        {"Fundamental Katalog 5th Edition", "FK5 287"},
        {"Geneva Identification System", "GEN# +1.00060179"},
        {"Smithsonian Astrophysical Observation", "SAO 60198"},
    },
    visualMagnitude: 1.58,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.65001898),
        dec: Angle.Degrees(+31.88863645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56900"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.96020980),
        dec: Angle.Degrees(+31.89077991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5479"},
        {"Hipparcos Number", "HIP 4452"},
        {"Smithsonian Astrophysical Observation", "SAO 54284"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.24672604),
        dec: Angle.Degrees(+31.89635702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58244"},
        {"Hipparcos Number", "HIP 36087"},
        {"Smithsonian Astrophysical Observation", "SAO 60073"},
        {"Wilson Evans Batten Catalogue", "WEB 7185"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.52745671),
        dec: Angle.Degrees(+31.89667891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202779"},
        {"Hipparcos Number", "HIP 105097"},
        {"Geneva Identification System", "GEN# +1.00202779"},
        {"Smithsonian Astrophysical Observation", "SAO 71157"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.33867817),
        dec: Angle.Degrees(+31.89945292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204276"},
        {"Hipparcos Number", "HIP 105886"},
        {"Smithsonian Astrophysical Observation", "SAO 71343"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67737536),
        dec: Angle.Degrees(+31.90666740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57579"},
        {"Geneva Identification System", "GEN# +0.03202189"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.05941479),
        dec: Angle.Degrees(+31.90908769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223868"},
        {"Hipparcos Number", "HIP 117785"},
        {"Geneva Identification System", "GEN# +1.00223868"},
        {"Smithsonian Astrophysical Observation", "SAO 73585"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.29570493),
        dec: Angle.Degrees(+31.91008537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207908"},
        {"Hipparcos Number", "HIP 107904"},
        {"Smithsonian Astrophysical Observation", "SAO 71774"},
        {"Wilson Evans Batten Catalogue", "WEB 19457"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.93535259),
        dec: Angle.Degrees(+31.91212858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198197"},
        {"Hipparcos Number", "HIP 102623"},
        {"Smithsonian Astrophysical Observation", "SAO 70511"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.93226045),
        dec: Angle.Degrees(+31.91282300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16161"},
        {"Smithsonian Astrophysical Observation", "SAO 56474"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.06171862),
        dec: Angle.Degrees(+31.91408673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169953"},
        {"Hipparcos Number", "HIP 90324"},
        {"Smithsonian Astrophysical Observation", "SAO 66959"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.44336565),
        dec: Angle.Degrees(+31.91465662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42392"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.62740555),
        dec: Angle.Degrees(+31.91612225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76765"},
        {"Hipparcos Number", "HIP 44118"},
        {"Geneva Identification System", "GEN# +1.00076765"},
        {"Smithsonian Astrophysical Observation", "SAO 61169"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.78182148),
        dec: Angle.Degrees(+31.91628988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13609"},
        {"Hipparcos Number", "HIP 10369"},
        {"Geneva Identification System", "GEN# +1.00013609"},
        {"Smithsonian Astrophysical Observation", "SAO 55362"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.40582648),
        dec: Angle.Degrees(+31.91910687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331777"},
        {"Hipparcos Number", "HIP 98729"},
        {"Geneva Identification System", "GEN# +1.00331777"},
        {"Smithsonian Astrophysical Observation", "SAO 69313"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.79843570),
        dec: Angle.Degrees(+31.91945872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264635"},
        {"Hipparcos Number", "HIP 32857"},
        {"Smithsonian Astrophysical Observation", "SAO 59544"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.72530235),
        dec: Angle.Degrees(+31.91995601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103965"},
        {"Hipparcos Number", "HIP 58398"},
        {"Geneva Identification System", "GEN# +1.00103965"},
        {"Smithsonian Astrophysical Observation", "SAO 62779"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.61832096),
        dec: Angle.Degrees(+31.92057807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37536"},
        {"Hipparcos Number", "HIP 26718"},
        {"Geneva Identification System", "GEN# +1.00037536"},
        {"Smithsonian Astrophysical Observation", "SAO 58322"},
        {"Wilson Evans Batten Catalogue", "WEB 5268"},
    },
    visualMagnitude: 6.23,
    bvColour: 2.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.17520877),
        dec: Angle.Degrees(+31.92061792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105547"},
        {"Hipparcos Number", "HIP 59244"},
        {"Geneva Identification System", "GEN# +1.00105547"},
        {"Smithsonian Astrophysical Observation", "SAO 62862"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.28334258),
        dec: Angle.Degrees(+31.92231157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86728"},
        {"Hipparcos Number", "HIP 49081"},
        {"Cincinnati Publication", "Ci 20 559"},
        {"Fundamental Katalog 5th Edition", "FK5 1258"},
        {"Geneva Identification System", "GEN# +1.00086728"},
        {"Smithsonian Astrophysical Observation", "SAO 61808"},
        {"Wilson Evans Batten Catalogue", "WEB 9100"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.25425132),
        dec: Angle.Degrees(+31.92471460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -529.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -428.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131451"},
        {"Hipparcos Number", "HIP 72794"},
        {"Fundamental Katalog 5th Edition", "FK5 5318"},
        {"Smithsonian Astrophysical Observation", "SAO 64373"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.18236986),
        dec: Angle.Degrees(+31.92505382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278942"},
        {"Hipparcos Number", "HIP 17113"},
        {"Smithsonian Astrophysical Observation", "SAO 56612"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.98200917),
        dec: Angle.Degrees(+31.92589965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15226"},
        {"Smithsonian Astrophysical Observation", "SAO 56304"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.07277439),
        dec: Angle.Degrees(+31.92590414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95393",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95393"},
        {"Smithsonian Astrophysical Observation", "SAO 68261"},
    },
    visualMagnitude: 9.26,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.08004449),
        dec: Angle.Degrees(+31.92658134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129515"},
        {"Hipparcos Number", "HIP 71887"},
        {"Smithsonian Astrophysical Observation", "SAO 64282"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.54707517),
        dec: Angle.Degrees(+31.92662829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173417"},
        {"Hipparcos Number", "HIP 91883"},
        {"Geneva Identification System", "GEN# +1.00173417"},
        {"Smithsonian Astrophysical Observation", "SAO 67293"},
        {"Wilson Evans Batten Catalogue", "WEB 15821"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.96505950),
        dec: Angle.Degrees(+31.92691949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33217"},
        {"Hipparcos Number", "HIP 24049"},
        {"Geneva Identification System", "GEN# +1.00033217"},
        {"Smithsonian Astrophysical Observation", "SAO 57703"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.52174189),
        dec: Angle.Degrees(+31.93062813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65003"},
        {"Geneva Identification System", "GEN# +0.03202341"},
        {"Smithsonian Astrophysical Observation", "SAO 63471"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.86006773),
        dec: Angle.Degrees(+31.93082391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281486"},
        {"Hipparcos Number", "HIP 18886"},
        {"Geneva Identification System", "GEN# +1.00281486"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.73599747),
        dec: Angle.Degrees(+31.93180245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39579"},
        {"Smithsonian Astrophysical Observation", "SAO 60547"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.31117411),
        dec: Angle.Degrees(+31.93391585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80589"},
        {"Smithsonian Astrophysical Observation", "SAO 65311"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80973722),
        dec: Angle.Degrees(+31.93395002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18296"},
        {"Hipparcos Number", "HIP 13775"},
        {"Celescope Catalog", "CEL 298"},
        {"Fundamental Katalog 5th Edition", "FK5 2205"},
        {"Geneva Identification System", "GEN# +1.00018296"},
        {"Renson", "Renson 4560"},
        {"Smithsonian Astrophysical Observation", "SAO 56031"},
        {"Wilson Evans Batten Catalogue", "WEB 2727"},
    },
    visualMagnitude: 5.10,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.32200201),
        dec: Angle.Degrees(+31.93429432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96075"},
        {"Hipparcos Number", "HIP 54198"},
        {"Smithsonian Astrophysical Observation", "SAO 62397"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.32034061),
        dec: Angle.Degrees(+31.93433240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190551"},
        {"Hipparcos Number", "HIP 98838"},
        {"Smithsonian Astrophysical Observation", "SAO 69350"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.07455677),
        dec: Angle.Degrees(+31.93597504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85935"},
        {"Smithsonian Astrophysical Observation", "SAO 66136"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.42980868),
        dec: Angle.Degrees(+31.93673875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62831"},
        {"Hipparcos Number", "HIP 37991"},
        {"Smithsonian Astrophysical Observation", "SAO 60333"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.79217120),
        dec: Angle.Degrees(+31.93795010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224531"},
        {"Hipparcos Number", "HIP 118213"},
        {"Geneva Identification System", "GEN# +1.00224531"},
        {"Smithsonian Astrophysical Observation", "SAO 73646"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.69076324),
        dec: Angle.Degrees(+31.93982311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11486"},
        {"Hipparcos Number", "HIP 8829"},
        {"Geneva Identification System", "GEN# +1.00011486"},
        {"Smithsonian Astrophysical Observation", "SAO 55065"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.37586070),
        dec: Angle.Degrees(+31.94060678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263781"},
        {"Hipparcos Number", "HIP 32603"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.02566284),
        dec: Angle.Degrees(+31.94069350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47191"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.26858397),
        dec: Angle.Degrees(+31.94118609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73596"},
        {"Hipparcos Number", "HIP 42538"},
        {"Geneva Identification System", "GEN# +1.00073596"},
        {"Smithsonian Astrophysical Observation", "SAO 60970"},
        {"Wilson Evans Batten Catalogue", "WEB 8199"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07630863),
        dec: Angle.Degrees(+31.94197425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165129"},
        {"Hipparcos Number", "HIP 88408"},
        {"Smithsonian Astrophysical Observation", "SAO 66583"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77481557),
        dec: Angle.Degrees(+31.94512065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18994"},
        {"Hipparcos Number", "HIP 14297"},
        {"Smithsonian Astrophysical Observation", "SAO 56129"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.07797221),
        dec: Angle.Degrees(+31.94553676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255549"},
        {"Hipparcos Number", "HIP 30253"},
        {"Smithsonian Astrophysical Observation", "SAO 59014"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.46031134),
        dec: Angle.Degrees(+31.94578602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76941"},
        {"Geneva Identification System", "GEN# +6.20030316"},
        {"Wilson Evans Batten Catalogue", "WEB 13052"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.66093196),
        dec: Angle.Degrees(+31.94607225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41331"},
        {"Hipparcos Number", "HIP 28890"},
        {"Geneva Identification System", "GEN# +1.00041331"},
        {"Smithsonian Astrophysical Observation", "SAO 58734"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.49295518),
        dec: Angle.Degrees(+31.95076776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35903"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.02157930),
        dec: Angle.Degrees(+31.95133898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27349"},
        {"Hipparcos Number", "HIP 20231"},
        {"Geneva Identification System", "GEN# +1.00027349"},
        {"Smithsonian Astrophysical Observation", "SAO 57166"},
        {"Wilson Evans Batten Catalogue", "WEB 3860"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.04145111),
        dec: Angle.Degrees(+31.95320670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14067"},
        {"Smithsonian Astrophysical Observation", "SAO 56094"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.31602265),
        dec: Angle.Degrees(+31.95522606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204890"},
        {"Hipparcos Number", "HIP 106215"},
        {"Geneva Identification System", "GEN# +1.00204890"},
        {"Smithsonian Astrophysical Observation", "SAO 71415"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.70228812),
        dec: Angle.Degrees(+31.95776224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190227"},
        {"Hipparcos Number", "HIP 98701"},
        {"Geneva Identification System", "GEN# +1.00190227"},
        {"Smithsonian Astrophysical Observation", "SAO 69307"},
        {"Wilson Evans Batten Catalogue", "WEB 17478"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.70335846),
        dec: Angle.Degrees(+31.95880063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27982"},
        {"Hipparcos Number", "HIP 20710"},
        {"Smithsonian Astrophysical Observation", "SAO 57231"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.57210572),
        dec: Angle.Degrees(+31.95918091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149720"},
        {"Hipparcos Number", "HIP 81222"},
        {"Smithsonian Astrophysical Observation", "SAO 65411"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.84779771),
        dec: Angle.Degrees(+31.96053218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56151"},
        {"Hipparcos Number", "HIP 35272"},
        {"Smithsonian Astrophysical Observation", "SAO 59947"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.30543444),
        dec: Angle.Degrees(+31.96166530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23699"},
        {"Hipparcos Number", "HIP 17784"},
        {"Geneva Identification System", "GEN# +1.00023699"},
        {"Smithsonian Astrophysical Observation", "SAO 56717"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09850196),
        dec: Angle.Degrees(+31.96276415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55129"},
        {"Hipparcos Number", "HIP 34881"},
        {"Smithsonian Astrophysical Observation", "SAO 59892"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.26752066),
        dec: Angle.Degrees(+31.96549921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331288"},
        {"Hipparcos Number", "HIP 97579"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.50805676),
        dec: Angle.Degrees(+31.96596190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181492"},
        {"Hipparcos Number", "HIP 94962"},
        {"Celescope Catalog", "CEL 4736"},
        {"Geneva Identification System", "GEN# +1.00181492"},
        {"Smithsonian Astrophysical Observation", "SAO 68136"},
        {"Wilson Evans Batten Catalogue", "WEB 16585"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.86542458),
        dec: Angle.Degrees(+31.96632890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8847"},
        {"Hipparcos Number", "HIP 6819"},
        {"Smithsonian Astrophysical Observation", "SAO 54711"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.92805944),
        dec: Angle.Degrees(+31.96676096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181210"},
        {"Hipparcos Number", "HIP 94867"},
        {"Smithsonian Astrophysical Observation", "SAO 68104"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.58182474),
        dec: Angle.Degrees(+31.96693715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112531"},
        {"Smithsonian Astrophysical Observation", "SAO 72725"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.89283098),
        dec: Angle.Degrees(+31.96758277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159368"},
        {"Hipparcos Number", "HIP 85883"},
        {"Smithsonian Astrophysical Observation", "SAO 66129"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.26819831),
        dec: Angle.Degrees(+31.96921134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48391"},
        {"Hipparcos Number", "HIP 32299"},
        {"Geneva Identification System", "GEN# +1.00048391"},
        {"Smithsonian Astrophysical Observation", "SAO 59436"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.15127811),
        dec: Angle.Degrees(+31.97025200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190786"},
        {"Hipparcos Number", "HIP 98955"},
        {"Renson", "Renson 53060"},
        {"Smithsonian Astrophysical Observation", "SAO 69381"},
        {"Wilson Evans Batten Catalogue", "WEB 17571"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.36535516),
        dec: Angle.Degrees(+31.97170038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17606"},
        {"Hipparcos Number", "HIP 13241"},
        {"Geneva Identification System", "GEN# +1.00017606"},
        {"Smithsonian Astrophysical Observation", "SAO 55927"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.60837902),
        dec: Angle.Degrees(+31.97299926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103329"},
    },
    visualMagnitude: 10.26,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.00881867),
        dec: Angle.Degrees(+31.97432415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92125"},
        {"Hipparcos Number", "HIP 52098"},
        {"Fundamental Katalog 5th Edition", "FK5 1275"},
        {"Geneva Identification System", "GEN# +1.00092125"},
        {"Smithsonian Astrophysical Observation", "SAO 62173"},
        {"Wilson Evans Batten Catalogue", "WEB 9495"},
    },
    visualMagnitude: 4.68,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.68005265),
        dec: Angle.Degrees(+31.97622008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56107"},
        {"Geneva Identification System", "GEN# +0.03202152"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.51286882),
        dec: Angle.Degrees(+31.97760693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61783"},
        {"Geneva Identification System", "GEN# +0.03202267"},
        {"Smithsonian Astrophysical Observation", "SAO 63125"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.94404438),
        dec: Angle.Degrees(+31.97858556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54534"},
        {"Hipparcos Number", "HIP 34648"},
        {"Smithsonian Astrophysical Observation", "SAO 59845"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.63592663),
        dec: Angle.Degrees(+31.97946290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183909"},
        {"Hipparcos Number", "HIP 95934"},
        {"Smithsonian Astrophysical Observation", "SAO 68410"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.64915690),
        dec: Angle.Degrees(+31.98010534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1568"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.87733543),
        dec: Angle.Degrees(+31.98062713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105926"},
        {"Hipparcos Number", "HIP 59425"},
        {"Geneva Identification System", "GEN# +1.00105926"},
        {"Smithsonian Astrophysical Observation", "SAO 62885"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84540790),
        dec: Angle.Degrees(+31.98233189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30842"},
        {"Hipparcos Number", "HIP 22662"},
        {"Fundamental Katalog 5th Edition", "FK5 4448"},
        {"Smithsonian Astrophysical Observation", "SAO 57474"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.11608518),
        dec: Angle.Degrees(+31.98649982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157465"},
        {"Hipparcos Number", "HIP 84977"},
        {"Smithsonian Astrophysical Observation", "SAO 65985"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.52104321),
        dec: Angle.Degrees(+31.98737116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114145"},
        {"Smithsonian Astrophysical Observation", "SAO 73005"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.75117024),
        dec: Angle.Degrees(+31.99235050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59962"},
        {"Geneva Identification System", "GEN# +0.03202233"},
        {"Smithsonian Astrophysical Observation", "SAO 62940"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.47310757),
        dec: Angle.Degrees(+31.99259019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36357"},
        {"Cincinnati Publication", "Ci 18 891"},
        {"Geneva Identification System", "GEN# +0.03201561"},
        {"Smithsonian Astrophysical Observation", "SAO 60116"},
        {"Wilson Evans Batten Catalogue", "WEB 7233"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.25691754),
        dec: Angle.Degrees(+31.99341530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17181"},
        {"Hipparcos Number", "HIP 12933"},
        {"Smithsonian Astrophysical Observation", "SAO 55860"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58496459),
        dec: Angle.Degrees(+31.99495718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41375"},
        {"Hipparcos Number", "HIP 28919"},
        {"Smithsonian Astrophysical Observation", "SAO 58743"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.56547447),
        dec: Angle.Degrees(+31.99702009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192539"},
        {"Hipparcos Number", "HIP 99741"},
        {"Geneva Identification System", "GEN# +1.00192539"},
        {"Smithsonian Astrophysical Observation", "SAO 69659"},
        {"Wilson Evans Batten Catalogue", "WEB 17903"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.56707516),
        dec: Angle.Degrees(+31.99778721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200562"},
        {"Hipparcos Number", "HIP 103905"},
        {"Smithsonian Astrophysical Observation", "SAO 70830"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.80011804),
        dec: Angle.Degrees(+31.99796916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29309"},
        {"Hipparcos Number", "HIP 21602"},
        {"Geneva Identification System", "GEN# +1.00029309"},
        {"Smithsonian Astrophysical Observation", "SAO 57353"},
        {"Wilson Evans Batten Catalogue", "WEB 4148"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.56347032),
        dec: Angle.Degrees(+31.99881070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248048"},
        {"Hipparcos Number", "HIP 27571"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.58969215),
        dec: Angle.Degrees(+32.00053140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112353"},
        {"Hipparcos Number", "HIP 63104"},
        {"Geneva Identification System", "GEN# +1.00112353"},
        {"Smithsonian Astrophysical Observation", "SAO 63255"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.93670739),
        dec: Angle.Degrees(+32.00070193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176053"},
        {"Hipparcos Number", "HIP 93032"},
        {"Smithsonian Astrophysical Observation", "SAO 67614"},
        {"Wilson Evans Batten Catalogue", "WEB 16111"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27128786),
        dec: Angle.Degrees(+32.00074464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4951"},
        {"Hipparcos Number", "HIP 4047"},
        {"Geneva Identification System", "GEN# +1.00004951"},
        {"Smithsonian Astrophysical Observation", "SAO 54209"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.96232658),
        dec: Angle.Degrees(+32.00090328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76035"},
        {"Hipparcos Number", "HIP 43752"},
        {"Smithsonian Astrophysical Observation", "SAO 61129"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.67673374),
        dec: Angle.Degrees(+32.00119052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13689"},
        {"Smithsonian Astrophysical Observation", "SAO 56018"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.07699921),
        dec: Angle.Degrees(+32.00262540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145644"},
        {"Hipparcos Number", "HIP 79289"},
        {"Geneva Identification System", "GEN# +1.00145644"},
        {"Smithsonian Astrophysical Observation", "SAO 65125"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.73140048),
        dec: Angle.Degrees(+32.00310851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82387"},
        {"Smithsonian Astrophysical Observation", "SAO 65587"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.52043206),
        dec: Angle.Degrees(+32.00333127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36909"},
        {"Hipparcos Number", "HIP 26326"},
        {"Geneva Identification System", "GEN# +1.00036909"},
        {"Smithsonian Astrophysical Observation", "SAO 58238"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.10422167),
        dec: Angle.Degrees(+32.00366143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136954"},
        {"Hipparcos Number", "HIP 75240"},
        {"Geneva Identification System", "GEN# +1.00136954"},
        {"Smithsonian Astrophysical Observation", "SAO 64660"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.61269178),
        dec: Angle.Degrees(+32.00371529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109649"},
        {"Hipparcos Number", "HIP 61499"},
        {"Geneva Identification System", "GEN# +1.00109649"},
        {"Smithsonian Astrophysical Observation", "SAO 63095"},
        {"Wilson Evans Batten Catalogue", "WEB 10946"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.00525607),
        dec: Angle.Degrees(+32.00404846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13163"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.32111092),
        dec: Angle.Degrees(+32.00639077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119534"},
        {"Hipparcos Number", "HIP 66946"},
        {"Geneva Identification System", "GEN# +1.00119534"},
        {"Smithsonian Astrophysical Observation", "SAO 63705"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.81290098),
        dec: Angle.Degrees(+32.00825298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51352"},
        {"Cincinnati Publication", "Ci 18 1265"},
        {"Smithsonian Astrophysical Observation", "SAO 62066"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.33584665),
        dec: Angle.Degrees(+32.00840683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -269.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 617"},
        {"Smithsonian Astrophysical Observation", "SAO 53656"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.88664549),
        dec: Angle.Degrees(+32.00877870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92076"},
        {"Hipparcos Number", "HIP 52067"},
        {"Smithsonian Astrophysical Observation", "SAO 62171"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.59196003),
        dec: Angle.Degrees(+32.00878401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61295"},
        {"Hipparcos Number", "HIP 37339"},
        {"Geneva Identification System", "GEN# +1.00061295"},
        {"Smithsonian Astrophysical Observation", "SAO 60254"},
        {"Wilson Evans Batten Catalogue", "WEB 7389"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97540702),
        dec: Angle.Degrees(+32.00982411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86950"},
    },
    visualMagnitude: 11.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.50774887),
        dec: Angle.Degrees(+32.01207577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6680"},
        {"Hipparcos Number", "HIP 5319"},
        {"Fundamental Katalog 5th Edition", "FK5 2072"},
        {"Geneva Identification System", "GEN# +1.00006680"},
        {"Smithsonian Astrophysical Observation", "SAO 54445"},
        {"Wilson Evans Batten Catalogue", "WEB 1142"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.00501793),
        dec: Angle.Degrees(+32.01219214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91793"},
        {"Smithsonian Astrophysical Observation", "SAO 67281"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.75952289),
        dec: Angle.Degrees(+32.01364043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162936"},
        {"Hipparcos Number", "HIP 87459"},
        {"Smithsonian Astrophysical Observation", "SAO 66399"},
        {"Wilson Evans Batten Catalogue", "WEB 14752"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.05555520),
        dec: Angle.Degrees(+32.01393726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28206"},
    },
    visualMagnitude: 10.45,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.39656809),
        dec: Angle.Degrees(+32.01601926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131724"},
        {"Hipparcos Number", "HIP 72927"},
        {"Smithsonian Astrophysical Observation", "SAO 64388"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.57528098),
        dec: Angle.Degrees(+32.01678092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4575"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.64280875),
        dec: Angle.Degrees(+32.53899662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2622 A"},
        {"Henry Draper", "HD 22124"},
        {"Hipparcos Number", "HIP 16713"},
        {"Fundamental Katalog 5th Edition", "FK5 2255"},
        {"Geneva Identification System", "GEN# +1.00022124J"},
        {"Smithsonian Astrophysical Observation", "SAO 56559"},
        {"Wilson Evans Batten Catalogue", "WEB 3182"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.75484857),
        dec: Angle.Degrees(+32.01687284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76242",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9700 AB"},
        {"Henry Draper", "HD 138982"},
        {"Hipparcos Number", "HIP 76242"},
        {"Smithsonian Astrophysical Observation", "SAO 64779"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.60938963),
        dec: Angle.Degrees(+32.01699976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331161"},
        {"Hipparcos Number", "HIP 97292"},
        {"Cincinnati Publication", "Ci 20 1165"},
        {"Geneva Identification System", "GEN# +1.00331161"},
        {"Smithsonian Astrophysical Observation", "SAO 68825"},
        {"Wilson Evans Batten Catalogue", "WEB 17094"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.59837325),
        dec: Angle.Degrees(+32.01800544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 464.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -392.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149559"},
        {"Hipparcos Number", "HIP 81147"},
        {"Smithsonian Astrophysical Observation", "SAO 65396"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.60054093),
        dec: Angle.Degrees(+32.01891313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123783"},
        {"Hipparcos Number", "HIP 69118"},
        {"Geneva Identification System", "GEN# +1.00123783"},
        {"Smithsonian Astrophysical Observation", "SAO 63956"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.22860784),
        dec: Angle.Degrees(+32.01897637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119515"},
        {"Henry Draper 2", "HD 119515A"},
        {"Hipparcos Number", "HIP 66937"},
        {"Geneva Identification System", "GEN# +1.00119515"},
        {"Smithsonian Astrophysical Observation", "SAO 63704"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.77622326),
        dec: Angle.Degrees(+32.01929831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117301"},
        {"Hipparcos Number", "HIP 65764"},
        {"Geneva Identification System", "GEN# +1.00117301"},
        {"Smithsonian Astrophysical Observation", "SAO 63561"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.23970323),
        dec: Angle.Degrees(+32.01937894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15530"},
        {"Smithsonian Astrophysical Observation", "SAO 56354"},
        {"Wilson Evans Batten Catalogue", "WEB 2984"},
    },
    visualMagnitude: 8.87,
    bvColour: 2.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.02494362),
        dec: Angle.Degrees(+32.02166661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61124"},
        {"Geneva Identification System", "GEN# +0.03202254J"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.89885541),
        dec: Angle.Degrees(+32.02291609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193683"},
        {"Hipparcos Number", "HIP 100296"},
        {"Celescope Catalog", "CEL 5031"},
        {"Geneva Identification System", "GEN# +1.00193683"},
        {"Smithsonian Astrophysical Observation", "SAO 69858"},
        {"Wilson Evans Batten Catalogue", "WEB 18088"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.12826473),
        dec: Angle.Degrees(+32.02345331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282362"},
        {"Hipparcos Number", "HIP 21726"},
        {"Smithsonian Astrophysical Observation", "SAO 57366"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.97431118),
        dec: Angle.Degrees(+32.02377710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50920"},
        {"Smithsonian Astrophysical Observation", "SAO 62014"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.97918960),
        dec: Angle.Degrees(+32.02595084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113673"},
        {"Hipparcos Number", "HIP 63845"},
        {"Geneva Identification System", "GEN# +1.00113673"},
        {"Smithsonian Astrophysical Observation", "SAO 63333"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.27168185),
        dec: Angle.Degrees(+32.02596014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41490"},
        {"Smithsonian Astrophysical Observation", "SAO 60828"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.92092877),
        dec: Angle.Degrees(+32.02598326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109390"},
        {"Hipparcos Number", "HIP 61339"},
        {"Geneva Identification System", "GEN# +1.00109390"},
        {"Smithsonian Astrophysical Observation", "SAO 63073"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.52700367),
        dec: Angle.Degrees(+32.02693653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143953"},
        {"Hipparcos Number", "HIP 78538"},
        {"Smithsonian Astrophysical Observation", "SAO 65030"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.51514129),
        dec: Angle.Degrees(+32.02699272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93860"},
        {"Hipparcos Number", "HIP 53002"},
        {"Geneva Identification System", "GEN# +1.00093860"},
        {"Smithsonian Astrophysical Observation", "SAO 62278"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.64110832),
        dec: Angle.Degrees(+32.02754338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105320"},
        {"Hipparcos Number", "HIP 59141"},
        {"Geneva Identification System", "GEN# +1.00105320"},
        {"Smithsonian Astrophysical Observation", "SAO 62848"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.90731431),
        dec: Angle.Degrees(+32.02817167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331510"},
        {"Hipparcos Number", "HIP 98137"},
        {"Smithsonian Astrophysical Observation", "SAO 69123"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.17357607),
        dec: Angle.Degrees(+32.02885219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224457"},
        {"Hipparcos Number", "HIP 118157"},
        {"Geneva Identification System", "GEN# +1.00224457"},
        {"Smithsonian Astrophysical Observation", "SAO 73636"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.51197327),
        dec: Angle.Degrees(+32.03001242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202033"},
        {"Hipparcos Number", "HIP 104703"},
        {"Smithsonian Astrophysical Observation", "SAO 71061"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12983419),
        dec: Angle.Degrees(+32.03051606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2338 A"},
        {"Henry Draper", "HD 19132"},
        {"Hipparcos Number", "HIP 14399"},
        {"Smithsonian Astrophysical Observation", "SAO 56147"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.43985717),
        dec: Angle.Degrees(+32.03094390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79511"},
        {"Smithsonian Astrophysical Observation", "SAO 65157"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.37146404),
        dec: Angle.Degrees(+32.03124433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121682"},
        {"Hipparcos Number", "HIP 68065"},
        {"Fundamental Katalog 5th Edition", "FK5 1360"},
        {"Geneva Identification System", "GEN# +1.00121682"},
        {"Smithsonian Astrophysical Observation", "SAO 63837"},
        {"Wilson Evans Batten Catalogue", "WEB 11949"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.04392096),
        dec: Angle.Degrees(+32.03248107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89667"},
        {"Smithsonian Astrophysical Observation", "SAO 66836"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.47108209),
        dec: Angle.Degrees(+32.03333258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331914"},
        {"Hipparcos Number", "HIP 99334"},
        {"Geneva Identification System", "GEN# +1.00331914"},
        {"Smithsonian Astrophysical Observation", "SAO 69525"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.42506951),
        dec: Angle.Degrees(+32.03441588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196242"},
        {"Hipparcos Number", "HIP 101561"},
        {"Smithsonian Astrophysical Observation", "SAO 70227"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.75450886),
        dec: Angle.Degrees(+32.03459662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249338"},
        {"Hipparcos Number", "HIP 28147"},
        {"Smithsonian Astrophysical Observation", "SAO 58597"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.22571554),
        dec: Angle.Degrees(+32.03667993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33334"},
        {"Hipparcos Number", "HIP 24133"},
        {"Smithsonian Astrophysical Observation", "SAO 57719"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.74662906),
        dec: Angle.Degrees(+32.03875744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143704"},
        {"Hipparcos Number", "HIP 78431"},
        {"Smithsonian Astrophysical Observation", "SAO 65020"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.18173455),
        dec: Angle.Degrees(+32.03952425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109269"},
        {"Hipparcos Number", "HIP 61269"},
        {"Wilson Evans Batten Catalogue", "WEB 10902"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.34308712),
        dec: Angle.Degrees(+32.03982723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81996"},
        {"Hipparcos Number", "HIP 46590"},
        {"Geneva Identification System", "GEN# +1.00081996"},
        {"Smithsonian Astrophysical Observation", "SAO 61523"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.51238283),
        dec: Angle.Degrees(+32.04130415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331770"},
        {"Hipparcos Number", "HIP 98876"},
        {"Geneva Identification System", "GEN# +1.00331770"},
        {"Smithsonian Astrophysical Observation", "SAO 69367"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19380325),
        dec: Angle.Degrees(+32.04179944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117458"},
        {"Smithsonian Astrophysical Observation", "SAO 73526"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.24177068),
        dec: Angle.Degrees(+32.04224126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98685"},
        {"Hipparcos Number", "HIP 55471"},
        {"Smithsonian Astrophysical Observation", "SAO 62509"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.40072516),
        dec: Angle.Degrees(+32.04313665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136563"},
        {"Hipparcos Number", "HIP 75059"},
        {"Smithsonian Astrophysical Observation", "SAO 64642"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.07573420),
        dec: Angle.Degrees(+32.04454291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202572"},
        {"Hipparcos Number", "HIP 104983"},
        {"Geneva Identification System", "GEN# +1.00202572"},
        {"Smithsonian Astrophysical Observation", "SAO 71131"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.95215687),
        dec: Angle.Degrees(+32.04510572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64107"},
        {"Geneva Identification System", "GEN# +0.03202321"},
        {"Smithsonian Astrophysical Observation", "SAO 63361"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.06677893),
        dec: Angle.Degrees(+32.04652694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44199"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.05183782),
        dec: Angle.Degrees(+32.04671399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193517"},
        {"Hipparcos Number", "HIP 100211"},
        {"Geneva Identification System", "GEN# +1.00193517"},
        {"Renson", "Renson 54023"},
        {"Smithsonian Astrophysical Observation", "SAO 69830"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.87959243),
        dec: Angle.Degrees(+32.04724875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42156"},
        {"Hipparcos Number", "HIP 29302"},
        {"Smithsonian Astrophysical Observation", "SAO 58827"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.66425162),
        dec: Angle.Degrees(+32.04836146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209707"},
        {"Hipparcos Number", "HIP 108980"},
        {"Geneva Identification System", "GEN# +1.00209707"},
        {"Smithsonian Astrophysical Observation", "SAO 72000"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.17225260),
        dec: Angle.Degrees(+32.05221755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71638"},
        {"Hipparcos Number", "HIP 41657"},
        {"Smithsonian Astrophysical Observation", "SAO 60852"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40532425),
        dec: Angle.Degrees(+32.05241404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267597"},
        {"Hipparcos Number", "HIP 33767"},
        {"Smithsonian Astrophysical Observation", "SAO 59685"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.19272907),
        dec: Angle.Degrees(+32.05383434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196605"},
        {"Hipparcos Number", "HIP 101762"},
        {"Celescope Catalog", "CEL 5127"},
        {"Geneva Identification System", "GEN# +1.00196605"},
        {"Smithsonian Astrophysical Observation", "SAO 70282"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.36805913),
        dec: Angle.Degrees(+32.05505151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134901"},
        {"Hipparcos Number", "HIP 74315"},
        {"Smithsonian Astrophysical Observation", "SAO 64546"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.84553952),
        dec: Angle.Degrees(+32.05579086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10376"},
        {"Hipparcos Number", "HIP 7933"},
        {"Smithsonian Astrophysical Observation", "SAO 54911"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.49609728),
        dec: Angle.Degrees(+32.05648776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74292"},
        {"Hipparcos Number", "HIP 42874"},
        {"Geneva Identification System", "GEN# +1.00074292"},
        {"Smithsonian Astrophysical Observation", "SAO 61019"},
        {"Wilson Evans Batten Catalogue", "WEB 8285"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.06196313),
        dec: Angle.Degrees(+32.06260652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281377"},
        {"Hipparcos Number", "HIP 18670"},
        {"Geneva Identification System", "GEN# +1.00281377"},
        {"Smithsonian Astrophysical Observation", "SAO 56874"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.97165836),
        dec: Angle.Degrees(+32.06405485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73378"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.92655189),
        dec: Angle.Degrees(+32.06426201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223836"},
        {"Hipparcos Number", "HIP 117765"},
        {"Geneva Identification System", "GEN# +1.00223836"},
        {"Smithsonian Astrophysical Observation", "SAO 73583"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.24392012),
        dec: Angle.Degrees(+32.06528192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112298"},
        {"Hipparcos Number", "HIP 63072"},
        {"Geneva Identification System", "GEN# +1.00112298"},
        {"Smithsonian Astrophysical Observation", "SAO 63252"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.85095206),
        dec: Angle.Degrees(+32.06958078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 988 B"},
        {"Hipparcos Number", "HIP 5669"},
        {"Smithsonian Astrophysical Observation", "SAO 54513"},
        {"Wilson Evans Batten Catalogue", "WEB 1286"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.21477524),
        dec: Angle.Degrees(+32.07348104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183508"},
        {"Hipparcos Number", "HIP 95770"},
        {"Geneva Identification System", "GEN# +1.00183508"},
        {"Smithsonian Astrophysical Observation", "SAO 68367"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.17538906),
        dec: Angle.Degrees(+32.07521409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5671",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 988 A"},
        {"Henry Draper", "HD 7215"},
        {"Hipparcos Number", "HIP 5671"},
        {"Geneva Identification System", "GEN# +1.00007215"},
        {"Smithsonian Astrophysical Observation", "SAO 54514"},
        {"Wilson Evans Batten Catalogue", "WEB 1284"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.22075670),
        dec: Angle.Degrees(+32.07546528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13513 B"},
        {"Hipparcos Number", "HIP 99566"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.08103951),
        dec: Angle.Degrees(+32.07576351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47955"},
        {"Smithsonian Astrophysical Observation", "SAO 61676"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.57324414),
        dec: Angle.Degrees(+32.07882898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192165"},
        {"Hipparcos Number", "HIP 99564"},
        {"Smithsonian Astrophysical Observation", "SAO 69594"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.07754110),
        dec: Angle.Degrees(+32.08106074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80515",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80515"},
        {"Smithsonian Astrophysical Observation", "SAO 65298"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.54873807),
        dec: Angle.Degrees(+32.08175874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107114"},
        {"Smithsonian Astrophysical Observation", "SAO 71609"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44571333),
        dec: Angle.Degrees(+32.08224808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2610 A"},
        {"Henry Draper", "HD 22005"},
        {"Hipparcos Number", "HIP 16626"},
        {"Smithsonian Astrophysical Observation", "SAO 56545"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.48165894),
        dec: Angle.Degrees(+32.08359745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112959"},
        {"Hipparcos Number", "HIP 63440"},
        {"Geneva Identification System", "GEN# +1.00112959"},
        {"Smithsonian Astrophysical Observation", "SAO 63285"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.00853385),
        dec: Angle.Degrees(+32.08397759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116634"},
        {"Hipparcos Number", "HIP 65410"},
        {"Geneva Identification System", "GEN# +1.00116634"},
        {"Smithsonian Astrophysical Observation", "SAO 63516"},
        {"Wilson Evans Batten Catalogue", "WEB 11544"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.09762062),
        dec: Angle.Degrees(+32.08460567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8814 AB"},
        {"Henry Draper", "HD 114723"},
        {"Hipparcos Number", "HIP 64405"},
        {"Smithsonian Astrophysical Observation", "SAO 63396"},
        {"Wilson Evans Batten Catalogue", "WEB 11382"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.00846274),
        dec: Angle.Degrees(+32.08528207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109552",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15709 AB"},
        {"Henry Draper", "HD 210684"},
        {"Hipparcos Number", "HIP 109552"},
        {"Smithsonian Astrophysical Observation", "SAO 72108"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.86802316),
        dec: Angle.Degrees(+32.08605853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114511"},
        {"Smithsonian Astrophysical Observation", "SAO 73070"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.90900486),
        dec: Angle.Degrees(+32.08649691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19103"},
        {"Hipparcos Number", "HIP 14370"},
        {"Geneva Identification System", "GEN# +1.00019103"},
        {"Smithsonian Astrophysical Observation", "SAO 56143"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34651042),
        dec: Angle.Degrees(+32.09670904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104646"},
    },
    visualMagnitude: 11.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.97433831),
        dec: Angle.Degrees(+32.09823642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15704"},
        {"Hipparcos Number", "HIP 11805"},
        {"Geneva Identification System", "GEN# +1.00015704"},
        {"Smithsonian Astrophysical Observation", "SAO 55641"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.06452297),
        dec: Angle.Degrees(+32.09867287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181750"},
        {"Hipparcos Number", "HIP 95051"},
        {"Celescope Catalog", "CEL 4738"},
        {"Geneva Identification System", "GEN# +1.00181750"},
        {"Smithsonian Astrophysical Observation", "SAO 68159"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.10641262),
        dec: Angle.Degrees(+32.09893579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205733"},
        {"Hipparcos Number", "HIP 106690"},
        {"Smithsonian Astrophysical Observation", "SAO 71513"},
        {"Wilson Evans Batten Catalogue", "WEB 19293"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.14078258),
        dec: Angle.Degrees(+32.10272035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156297"},
        {"Hipparcos Number", "HIP 84415"},
        {"Smithsonian Astrophysical Observation", "SAO 65897"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.86628776),
        dec: Angle.Degrees(+32.10291120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155060"},
        {"Hipparcos Number", "HIP 83827"},
        {"Geneva Identification System", "GEN# +1.00155060"},
        {"Smithsonian Astrophysical Observation", "SAO 65809"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.98308692),
        dec: Angle.Degrees(+32.10558623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4593"},
    },
    visualMagnitude: 10.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.69104459),
        dec: Angle.Degrees(+32.10564421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3935"},
        {"Hipparcos Number", "HIP 3312"},
        {"Smithsonian Astrophysical Observation", "SAO 54090"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.54105414),
        dec: Angle.Degrees(+32.10704014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86348"},
        {"Smithsonian Astrophysical Observation", "SAO 66211"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.66891014),
        dec: Angle.Degrees(+32.10798540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53637"},
        {"Hipparcos Number", "HIP 34340"},
        {"Smithsonian Astrophysical Observation", "SAO 59792"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.78835767),
        dec: Angle.Degrees(+32.10937683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7691"},
        {"Smithsonian Astrophysical Observation", "SAO 54867"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.75021315),
        dec: Angle.Degrees(+32.10953511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193292"},
        {"Hipparcos Number", "HIP 100095"},
        {"Geneva Identification System", "GEN# +1.00193292"},
        {"Renson", "Renson 53950"},
        {"Smithsonian Astrophysical Observation", "SAO 69794"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.60099261),
        dec: Angle.Degrees(+32.11050444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49426"},
        {"Hipparcos Number", "HIP 32752"},
        {"Geneva Identification System", "GEN# +1.00049426"},
        {"Smithsonian Astrophysical Observation", "SAO 59522"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45234038),
        dec: Angle.Degrees(+32.11304862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48082"},
        {"Smithsonian Astrophysical Observation", "SAO 61691"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.03648802),
        dec: Angle.Degrees(+32.11455846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66630"},
        {"Smithsonian Astrophysical Observation", "SAO 63669"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85924049),
        dec: Angle.Degrees(+32.11613315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186980"},
        {"Hipparcos Number", "HIP 97280"},
        {"Celescope Catalog", "CEL 4839"},
        {"Geneva Identification System", "GEN# +1.00186980"},
        {"Smithsonian Astrophysical Observation", "SAO 68823"},
        {"Wilson Evans Batten Catalogue", "WEB 17090"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.56626656),
        dec: Angle.Degrees(+32.11617613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106125"},
        {"Smithsonian Astrophysical Observation", "SAO 71395"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.45873257),
        dec: Angle.Degrees(+32.11665916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12353"},
        {"Hipparcos Number", "HIP 9460"},
        {"Smithsonian Astrophysical Observation", "SAO 55198"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.43909067),
        dec: Angle.Degrees(+32.12136867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46174"},
        {"Smithsonian Astrophysical Observation", "SAO 61465"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23692188),
        dec: Angle.Degrees(+32.12148716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35563"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.08592817),
        dec: Angle.Degrees(+32.12184488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83068"},
        {"Hipparcos Number", "HIP 47170"},
        {"Smithsonian Astrophysical Observation", "SAO 61595"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.18239130),
        dec: Angle.Degrees(+32.12260805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39143"},
        {"Geneva Identification System", "GEN# +0.03201660"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09455430),
        dec: Angle.Degrees(+32.12326264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105707"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.15296145),
        dec: Angle.Degrees(+32.12327161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201360"},
        {"Hipparcos Number", "HIP 104339"},
        {"Smithsonian Astrophysical Observation", "SAO 70957"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.04471961),
        dec: Angle.Degrees(+32.12426068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120278"},
        {"Hipparcos Number", "HIP 67316"},
        {"Geneva Identification System", "GEN# +1.00120278"},
        {"Smithsonian Astrophysical Observation", "SAO 63750"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.97614366),
        dec: Angle.Degrees(+32.12455330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4443 A"},
        {"Henry Draper", "HD 39045"},
        {"Hipparcos Number", "HIP 27661"},
        {"Geneva Identification System", "GEN# +1.00039045"},
        {"Smithsonian Astrophysical Observation", "SAO 58504"},
        {"Wilson Evans Batten Catalogue", "WEB 5430"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.85726997),
        dec: Angle.Degrees(+32.12469631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250112"},
        {"Hipparcos Number", "HIP 28477"},
        {"Smithsonian Astrophysical Observation", "SAO 58652"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.18113569),
        dec: Angle.Degrees(+32.12482816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88825"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.97943135),
        dec: Angle.Degrees(+32.12561420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 187.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69453"},
        {"Geneva Identification System", "GEN# +0.03202446"},
        {"Smithsonian Astrophysical Observation", "SAO 63993"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.29736038),
        dec: Angle.Degrees(+32.12677601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78553"},
        {"Hipparcos Number", "HIP 44986"},
        {"Smithsonian Astrophysical Observation", "SAO 61297"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.45161821),
        dec: Angle.Degrees(+32.12842392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129987"},
        {"Hipparcos Number", "HIP 72085"},
        {"Smithsonian Astrophysical Observation", "SAO 64302"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.19403364),
        dec: Angle.Degrees(+32.12971881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74236"},
        {"Smithsonian Astrophysical Observation", "SAO 64531"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.56183362),
        dec: Angle.Degrees(+32.12975311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169668"},
        {"Hipparcos Number", "HIP 90209"},
        {"Fundamental Katalog 5th Edition", "FK5 5618"},
        {"Smithsonian Astrophysical Observation", "SAO 66941"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.10664333),
        dec: Angle.Degrees(+32.13083319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108788"},
        {"Smithsonian Astrophysical Observation", "SAO 71964"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.56585452),
        dec: Angle.Degrees(+32.13261307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89207"},
        {"Hipparcos Number", "HIP 50453"},
        {"Geneva Identification System", "GEN# +1.00089207"},
        {"Smithsonian Astrophysical Observation", "SAO 61973"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.52529621),
        dec: Angle.Degrees(+32.13315004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45375"},
        {"Hipparcos Number", "HIP 30816"},
        {"Smithsonian Astrophysical Observation", "SAO 59123"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.11900394),
        dec: Angle.Degrees(+32.13325634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193185"},
        {"Hipparcos Number", "HIP 100041"},
        {"Smithsonian Astrophysical Observation", "SAO 69768"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.44115666),
        dec: Angle.Degrees(+32.13529389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2688"},
        {"Hipparcos Number", "HIP 2407"},
        {"Geneva Identification System", "GEN# +1.00002688"},
        {"Smithsonian Astrophysical Observation", "SAO 53947"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.66614894),
        dec: Angle.Degrees(+32.13651591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176052"},
        {"Hipparcos Number", "HIP 93024"},
        {"Celescope Catalog", "CEL 4671"},
        {"Geneva Identification System", "GEN# +1.00176052"},
        {"Smithsonian Astrophysical Observation", "SAO 67613"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26333444),
        dec: Angle.Degrees(+32.13875691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55225"},
        {"Hipparcos Number", "HIP 34920"},
        {"Smithsonian Astrophysical Observation", "SAO 59896"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.37894520),
        dec: Angle.Degrees(+32.14546094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176670"},
        {"Hipparcos Number", "HIP 93279"},
        {"Geneva Identification System", "GEN# +1.00176670"},
        {"Smithsonian Astrophysical Observation", "SAO 67682"},
        {"Wilson Evans Batten Catalogue", "WEB 16175"},
    },
    visualMagnitude: 4.94,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00342257),
        dec: Angle.Degrees(+32.14549051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105100"},
        {"Hipparcos Number", "HIP 59023"},
        {"Geneva Identification System", "GEN# +1.00105100"},
        {"Smithsonian Astrophysical Observation", "SAO 62836"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.52526757),
        dec: Angle.Degrees(+32.14669889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146470"},
        {"Hipparcos Number", "HIP 79652"},
        {"Geneva Identification System", "GEN# +1.00146470"},
        {"Smithsonian Astrophysical Observation", "SAO 65172"},
        {"Wilson Evans Batten Catalogue", "WEB 13479"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81273602),
        dec: Angle.Degrees(+32.14715907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67656"},
        {"Geneva Identification System", "GEN# +0.03202397"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.92391450),
        dec: Angle.Degrees(+32.14890092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40408"},
        {"Smithsonian Astrophysical Observation", "SAO 60673"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.73711484),
        dec: Angle.Degrees(+32.14927319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13479"},
        {"Hipparcos Number", "HIP 10286"},
        {"Smithsonian Astrophysical Observation", "SAO 55348"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.12320514),
        dec: Angle.Degrees(+32.14975451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65822"},
        {"Hipparcos Number", "HIP 39266"},
        {"Smithsonian Astrophysical Observation", "SAO 60522"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.44692106),
        dec: Angle.Degrees(+32.15061848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260194"},
        {"Hipparcos Number", "HIP 31576"},
        {"Smithsonian Astrophysical Observation", "SAO 59283"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.13112932),
        dec: Angle.Degrees(+32.15439492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31234"},
        {"Hipparcos Number", "HIP 22894"},
        {"Smithsonian Astrophysical Observation", "SAO 57503"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.86720008),
        dec: Angle.Degrees(+32.15484149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18392",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2866 AB"},
        {"Henry Draper", "HD 24601"},
        {"Hipparcos Number", "HIP 18392"},
        {"Geneva Identification System", "GEN# +1.00024601J"},
        {"Smithsonian Astrophysical Observation", "SAO 56819"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.97854285),
        dec: Angle.Degrees(+32.15494518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144424"},
        {"Hipparcos Number", "HIP 78751"},
        {"Smithsonian Astrophysical Observation", "SAO 65060"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.17206408),
        dec: Angle.Degrees(+32.15824514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20659",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3200 AB"},
        {"Henry Draper", "HD 27922"},
        {"Hipparcos Number", "HIP 20659"},
        {"Smithsonian Astrophysical Observation", "SAO 57226"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.40185221),
        dec: Angle.Degrees(+32.15872398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49733"},
        {"Hipparcos Number", "HIP 32903"},
        {"Smithsonian Astrophysical Observation", "SAO 59548"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.83798764),
        dec: Angle.Degrees(+32.15930571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93090"},
        {"Hipparcos Number", "HIP 52609"},
        {"Smithsonian Astrophysical Observation", "SAO 62232"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.37085800),
        dec: Angle.Degrees(+32.16089213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2730 AB"},
        {"Henry Draper", "HD 281159"},
        {"Hipparcos Number", "HIP 17465"},
        {"Geneva Identification System", "GEN# +3.03480020"},
        {"Smithsonian Astrophysical Observation", "SAO 56680"},
        {"Wilson Evans Batten Catalogue", "WEB 3311"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.14244038),
        dec: Angle.Degrees(+32.16283181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2866 C"},
        {"Henry Draper", "HD 24600"},
        {"Hipparcos Number", "HIP 18397"},
        {"Geneva Identification System", "GEN# +1.00024600"},
        {"Smithsonian Astrophysical Observation", "SAO 56820"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.99444915),
        dec: Angle.Degrees(+32.16336837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105076"},
        {"Smithsonian Astrophysical Observation", "SAO 71154"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.29644280),
        dec: Angle.Degrees(+32.16600503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5151 AB"},
        {"Henry Draper", "HD 45899"},
        {"Hipparcos Number", "HIP 31104"},
        {"Smithsonian Astrophysical Observation", "SAO 59177"},
        {"Wilson Evans Batten Catalogue", "WEB 6193"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.90281828),
        dec: Angle.Degrees(+32.16625335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125122"},
        {"Hipparcos Number", "HIP 69768"},
        {"Geneva Identification System", "GEN# +1.00125122"},
        {"Smithsonian Astrophysical Observation", "SAO 64043"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.17506229),
        dec: Angle.Degrees(+32.16628710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221887"},
        {"Hipparcos Number", "HIP 116445"},
        {"Smithsonian Astrophysical Observation", "SAO 73362"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.93700321),
        dec: Angle.Degrees(+32.16657504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17468",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2730 C"},
        {"Hipparcos Number", "HIP 17468"},
        {"Geneva Identification System", "GEN# +3.03480012"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.14731143),
        dec: Angle.Degrees(+32.16796130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199358"},
        {"Hipparcos Number", "HIP 103306"},
        {"Smithsonian Astrophysical Observation", "SAO 70672"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.93054375),
        dec: Angle.Degrees(+32.16940043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24039"},
        {"Hipparcos Number", "HIP 18008"},
        {"Geneva Identification System", "GEN# +1.00024039"},
        {"Smithsonian Astrophysical Observation", "SAO 56743"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74522779),
        dec: Angle.Degrees(+32.16964258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100598"},
        {"Hipparcos Number", "HIP 56486"},
        {"Geneva Identification System", "GEN# +1.00100598"},
        {"Smithsonian Astrophysical Observation", "SAO 62608"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.70418143),
        dec: Angle.Degrees(+32.16988513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115752"},
        {"Hipparcos Number", "HIP 64943"},
        {"Geneva Identification System", "GEN# +1.00115752"},
        {"Smithsonian Astrophysical Observation", "SAO 63464"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.68868932),
        dec: Angle.Degrees(+32.16990309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72114"},
        {"Hipparcos Number", "HIP 41868"},
        {"Geneva Identification System", "GEN# +1.00072114"},
        {"Smithsonian Astrophysical Observation", "SAO 60881"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.05899263),
        dec: Angle.Degrees(+32.17028124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198108"},
        {"Hipparcos Number", "HIP 102568"},
        {"Celescope Catalog", "CEL 5165"},
        {"Geneva Identification System", "GEN# +1.00198108"},
        {"Smithsonian Astrophysical Observation", "SAO 70498"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.78527742),
        dec: Angle.Degrees(+32.17220678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78934"},
        {"Smithsonian Astrophysical Observation", "SAO 65085"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.70302718),
        dec: Angle.Degrees(+32.17225233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27066"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.09623567),
        dec: Angle.Degrees(+32.17343924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244335"},
        {"Hipparcos Number", "HIP 25876"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.86115999),
        dec: Angle.Degrees(+32.17423749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107512"},
        {"Hipparcos Number", "HIP 60256"},
        {"Geneva Identification System", "GEN# +1.00107512"},
        {"Smithsonian Astrophysical Observation", "SAO 62966"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.33711695),
        dec: Angle.Degrees(+32.17651322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2666"},
        {"Hipparcos Number", "HIP 2393"},
        {"Geneva Identification System", "GEN# +1.00002666"},
        {"Smithsonian Astrophysical Observation", "SAO 53944"},
        {"Wilson Evans Batten Catalogue", "WEB 440"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62232666),
        dec: Angle.Degrees(+32.17694681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45517"},
        {"Fundamental Katalog 5th Edition", "FK5 4825"},
        {"Smithsonian Astrophysical Observation", "SAO 61375"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.15056169),
        dec: Angle.Degrees(+32.17694789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68933"},
        {"Hipparcos Number", "HIP 40472"},
        {"Geneva Identification System", "GEN# +1.00068933"},
        {"Smithsonian Astrophysical Observation", "SAO 60688"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.95583335),
        dec: Angle.Degrees(+32.17724663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89144"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.90877340),
        dec: Angle.Degrees(+32.17787641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155524"},
        {"Hipparcos Number", "HIP 84040"},
        {"Geneva Identification System", "GEN# +1.00155524"},
        {"Smithsonian Astrophysical Observation", "SAO 65846"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.70082467),
        dec: Angle.Degrees(+32.17912398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203065"},
        {"Hipparcos Number", "HIP 105234"},
        {"Smithsonian Astrophysical Observation", "SAO 71192"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.74253039),
        dec: Angle.Degrees(+32.18079615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6476"},
        {"Hipparcos Number", "HIP 5175"},
        {"Fundamental Katalog 5th Edition", "FK5 4100"},
        {"Geneva Identification System", "GEN# +1.00006476"},
        {"Smithsonian Astrophysical Observation", "SAO 54421"},
        {"Wilson Evans Batten Catalogue", "WEB 1080"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.54664936),
        dec: Angle.Degrees(+32.18154253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58533"},
        {"Smithsonian Astrophysical Observation", "SAO 62791"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.05507513),
        dec: Angle.Degrees(+32.18393623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20277"},
        {"Hipparcos Number", "HIP 15241"},
        {"Geneva Identification System", "GEN# +1.00020277"},
        {"Smithsonian Astrophysical Observation", "SAO 56308"},
        {"Wilson Evans Batten Catalogue", "WEB 2938"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.14663457),
        dec: Angle.Degrees(+32.18421948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87828"},
        {"Smithsonian Astrophysical Observation", "SAO 66490"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.11122513),
        dec: Angle.Degrees(+32.18669354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26438"},
        {"Hipparcos Number", "HIP 19618"},
        {"Fundamental Katalog 5th Edition", "FK5 4382"},
        {"Smithsonian Astrophysical Observation", "SAO 57061"},
    },
    visualMagnitude: 8.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.05597716),
        dec: Angle.Degrees(+32.18681129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9129"},
        {"Hipparcos Number", "HIP 7020"},
        {"Smithsonian Astrophysical Observation", "SAO 54744"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.61144854),
        dec: Angle.Degrees(+32.18779005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210389"},
        {"Hipparcos Number", "HIP 109366"},
        {"Smithsonian Astrophysical Observation", "SAO 72066"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.35262613),
        dec: Angle.Degrees(+32.18833766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80866"},
        {"Smithsonian Astrophysical Observation", "SAO 65352"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68751990),
        dec: Angle.Degrees(+32.18969774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194317"},
        {"Hipparcos Number", "HIP 100587"},
        {"Fundamental Katalog 5th Edition", "FK5 3633"},
        {"Geneva Identification System", "GEN# +1.00194317"},
        {"Smithsonian Astrophysical Observation", "SAO 69950"},
        {"Wilson Evans Batten Catalogue", "WEB 18178"},
    },
    visualMagnitude: 4.43,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.96498335),
        dec: Angle.Degrees(+32.19018607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222961"},
        {"Hipparcos Number", "HIP 117175"},
        {"Smithsonian Astrophysical Observation", "SAO 73481"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.34333705),
        dec: Angle.Degrees(+32.19159692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88269"},
        {"Hipparcos Number", "HIP 49906"},
        {"Smithsonian Astrophysical Observation", "SAO 61918"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.84329803),
        dec: Angle.Degrees(+32.19192212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10588"},
        {"Hipparcos Number", "HIP 8086"},
        {"Geneva Identification System", "GEN# +1.00010588"},
        {"Smithsonian Astrophysical Observation", "SAO 54939"},
        {"Wilson Evans Batten Catalogue", "WEB 1729"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.95895146),
        dec: Angle.Degrees(+32.19201138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36371"},
        {"Hipparcos Number", "HIP 25984"},
        {"Celescope Catalog", "CEL 766"},
        {"Fundamental Katalog 5th Edition", "FK5 1151"},
        {"Geneva Identification System", "GEN# +1.00036371"},
        {"Smithsonian Astrophysical Observation", "SAO 58164"},
        {"Wilson Evans Batten Catalogue", "WEB 5053"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.18197584),
        dec: Angle.Degrees(+32.19203140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23626"},
        {"Hipparcos Number", "HIP 17732"},
        {"Geneva Identification System", "GEN# +1.00023626"},
        {"Smithsonian Astrophysical Observation", "SAO 56707"},
        {"Wilson Evans Batten Catalogue", "WEB 3388"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.95431974),
        dec: Angle.Degrees(+32.19549815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183788"},
        {"Hipparcos Number", "HIP 95874"},
        {"Smithsonian Astrophysical Observation", "SAO 68396"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.48392864),
        dec: Angle.Degrees(+32.19577143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109691"},
        {"Hipparcos Number", "HIP 61534"},
        {"Geneva Identification System", "GEN# +1.00109691"},
        {"Smithsonian Astrophysical Observation", "SAO 63100"},
        {"Wilson Evans Batten Catalogue", "WEB 10950"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.10106148),
        dec: Angle.Degrees(+32.19583615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109389"},
        {"Hipparcos Number", "HIP 61348"},
        {"Geneva Identification System", "GEN# +1.00109389"},
        {"Smithsonian Astrophysical Observation", "SAO 63074"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.55000339),
        dec: Angle.Degrees(+32.19592582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103608"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.87969535),
        dec: Angle.Degrees(+32.19646753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41423",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6814 AB"},
        {"Hipparcos Number", "HIP 41423"},
        {"Smithsonian Astrophysical Observation", "SAO 60818"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.73540631),
        dec: Angle.Degrees(+32.19676004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221850"},
        {"Hipparcos Number", "HIP 116427"},
        {"Smithsonian Astrophysical Observation", "SAO 73359"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.88008682),
        dec: Angle.Degrees(+32.19786228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217013"},
        {"Hipparcos Number", "HIP 113342"},
        {"Smithsonian Astrophysical Observation", "SAO 72874"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.31468049),
        dec: Angle.Degrees(+32.19927480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35898"},
        {"Hipparcos Number", "HIP 25696"},
        {"Geneva Identification System", "GEN# +1.00035898"},
        {"Smithsonian Astrophysical Observation", "SAO 58091"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.31962348),
        dec: Angle.Degrees(+32.19956449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64051"},
        {"Hipparcos Number", "HIP 38513"},
        {"Smithsonian Astrophysical Observation", "SAO 60413"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.30856386),
        dec: Angle.Degrees(+32.20130913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103719"},
        {"Hipparcos Number", "HIP 58250"},
        {"Geneva Identification System", "GEN# +1.00103719"},
        {"Smithsonian Astrophysical Observation", "SAO 62767"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.19387575),
        dec: Angle.Degrees(+32.20302037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 803"},
        {"Hipparcos Number", "HIP 998"},
        {"Geneva Identification System", "GEN# +1.00000803"},
        {"Smithsonian Astrophysical Observation", "SAO 53719"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.12479109),
        dec: Angle.Degrees(+32.20391674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201656"},
        {"Hipparcos Number", "HIP 104492"},
        {"Smithsonian Astrophysical Observation", "SAO 70997"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50881027),
        dec: Angle.Degrees(+32.20577060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125113"},
        {"Hipparcos Number", "HIP 69753"},
        {"Geneva Identification System", "GEN# +1.00125113"},
        {"Smithsonian Astrophysical Observation", "SAO 64041"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.14134164),
        dec: Angle.Degrees(+32.20841754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69047"},
        {"Smithsonian Astrophysical Observation", "SAO 63944"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.00104340),
        dec: Angle.Degrees(+32.20922043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7181"},
        {"Hipparcos Number", "HIP 5645"},
        {"Geneva Identification System", "GEN# +1.00007181"},
        {"Smithsonian Astrophysical Observation", "SAO 54509"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.12668996),
        dec: Angle.Degrees(+32.21103847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8785"},
        {"Smithsonian Astrophysical Observation", "SAO 55056"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.24861775),
        dec: Angle.Degrees(+32.21105339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31070"},
        {"Hipparcos Number", "HIP 22789"},
        {"Geneva Identification System", "GEN# +1.00031070"},
        {"Smithsonian Astrophysical Observation", "SAO 57490"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.54434137),
        dec: Angle.Degrees(+32.21107161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27584"},
    },
    visualMagnitude: 10.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62067077),
        dec: Angle.Degrees(+32.21115849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25239"},
        {"Hipparcos Number", "HIP 18807"},
        {"Geneva Identification System", "GEN# +1.00025239"},
        {"Smithsonian Astrophysical Observation", "SAO 56909"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.44318440),
        dec: Angle.Degrees(+32.21535007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13335 A"},
        {"Henry Draper", "HD 190603"},
        {"Hipparcos Number", "HIP 98863"},
        {"Geneva Identification System", "GEN# +1.00190603A"},
        {"Smithsonian Astrophysical Observation", "SAO 69362"},
        {"Wilson Evans Batten Catalogue", "WEB 17544"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.15073631),
        dec: Angle.Degrees(+32.21862467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39948",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6623 AB"},
        {"Henry Draper", "HD 67501"},
        {"Hipparcos Number", "HIP 39948"},
        {"Smithsonian Astrophysical Observation", "SAO 60604"},
        {"Wilson Evans Batten Catalogue", "WEB 7783"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.37641586),
        dec: Angle.Degrees(+32.22116021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54592"},
        {"Hipparcos Number", "HIP 34671"},
        {"Geneva Identification System", "GEN# +1.00054592"},
        {"Smithsonian Astrophysical Observation", "SAO 59850"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.70361925),
        dec: Angle.Degrees(+32.22334333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332296"},
        {"Hipparcos Number", "HIP 100978"},
        {"Smithsonian Astrophysical Observation", "SAO 70071"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.10507221),
        dec: Angle.Degrees(+32.22346709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204485"},
        {"Hipparcos Number", "HIP 106003"},
        {"Fundamental Katalog 5th Edition", "FK5 3716"},
        {"Geneva Identification System", "GEN# +1.00204485"},
        {"Renson", "Renson 56940"},
        {"Smithsonian Astrophysical Observation", "SAO 71371"},
        {"Wilson Evans Batten Catalogue", "WEB 19216"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.03399511),
        dec: Angle.Degrees(+32.22513677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250173"},
        {"Hipparcos Number", "HIP 28502"},
        {"Smithsonian Astrophysical Observation", "SAO 58656"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.25558558),
        dec: Angle.Degrees(+32.22548806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94904"},
        {"Smithsonian Astrophysical Observation", "SAO 68112"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.68680222),
        dec: Angle.Degrees(+32.22567278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141954"},
        {"Hipparcos Number", "HIP 77602"},
        {"Geneva Identification System", "GEN# +1.00141954"},
        {"Smithsonian Astrophysical Observation", "SAO 64938"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.64215058),
        dec: Angle.Degrees(+32.22573222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19645"},
        {"Hipparcos Number", "HIP 14784"},
        {"Fundamental Katalog 5th Edition", "FK5 4291"},
        {"Smithsonian Astrophysical Observation", "SAO 56223"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.71765270),
        dec: Angle.Degrees(+32.22653301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247040"},
        {"Hipparcos Number", "HIP 27163"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.37224255),
        dec: Angle.Degrees(+32.22778088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215291"},
        {"Hipparcos Number", "HIP 112218"},
        {"Smithsonian Astrophysical Observation", "SAO 72667"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.91476600),
        dec: Angle.Degrees(+32.22864481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172470"},
        {"Hipparcos Number", "HIP 91444"},
        {"Smithsonian Astrophysical Observation", "SAO 67209"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.74408091),
        dec: Angle.Degrees(+32.22924612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165683"},
        {"Hipparcos Number", "HIP 88636"},
        {"Geneva Identification System", "GEN# +1.00165683"},
        {"Smithsonian Astrophysical Observation", "SAO 66626"},
        {"Wilson Evans Batten Catalogue", "WEB 15015"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45665820),
        dec: Angle.Degrees(+32.23072212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3226"},
        {"Hipparcos Number", "HIP 2804"},
        {"Smithsonian Astrophysical Observation", "SAO 54010"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.92505477),
        dec: Angle.Degrees(+32.23230955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153300"},
        {"Hipparcos Number", "HIP 82962"},
        {"Smithsonian Astrophysical Observation", "SAO 65667"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.30252314),
        dec: Angle.Degrees(+32.23365182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199912"},
        {"Hipparcos Number", "HIP 103565"},
        {"Geneva Identification System", "GEN# +1.00199912"},
        {"Smithsonian Astrophysical Observation", "SAO 70751"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.75394658),
        dec: Angle.Degrees(+32.23786857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20844"},
        {"Hipparcos Number", "HIP 15721"},
        {"Smithsonian Astrophysical Observation", "SAO 56389"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.62961374),
        dec: Angle.Degrees(+32.23990648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104205"},
        {"Hipparcos Number", "HIP 58529"},
        {"Geneva Identification System", "GEN# +1.00104205"},
        {"Smithsonian Astrophysical Observation", "SAO 62790"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.04060615),
        dec: Angle.Degrees(+32.24094852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 640"},
        {"Hipparcos Number", "HIP 882"},
        {"Smithsonian Astrophysical Observation", "SAO 53698"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69663452),
        dec: Angle.Degrees(+32.24257302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43260"},
        {"Hipparcos Number", "HIP 29815"},
        {"Smithsonian Astrophysical Observation", "SAO 58933"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.18122746),
        dec: Angle.Degrees(+32.24270916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214505"},
        {"Hipparcos Number", "HIP 111739"},
        {"Smithsonian Astrophysical Observation", "SAO 72555"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.52148448),
        dec: Angle.Degrees(+32.24372140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171026"},
        {"Hipparcos Number", "HIP 90766"},
        {"Smithsonian Astrophysical Observation", "SAO 67059"},
        {"Wilson Evans Batten Catalogue", "WEB 15551"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.77891863),
        dec: Angle.Degrees(+32.24538578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2233"},
        {"Hipparcos Number", "HIP 2082"},
        {"Smithsonian Astrophysical Observation", "SAO 53894"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.57108821),
        dec: Angle.Degrees(+32.24639194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169128"},
        {"Hipparcos Number", "HIP 89998"},
        {"Smithsonian Astrophysical Observation", "SAO 66903"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.45102216),
        dec: Angle.Degrees(+32.24750929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144682"},
        {"Hipparcos Number", "HIP 78851"},
        {"Smithsonian Astrophysical Observation", "SAO 65073"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.43809780),
        dec: Angle.Degrees(+32.24783869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85191"},
        {"Smithsonian Astrophysical Observation", "SAO 66016"},
        {"Wilson Evans Batten Catalogue", "WEB 14387"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.14935135),
        dec: Angle.Degrees(+32.24970382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7137 A"},
        {"Henry Draper", "HD 77104"},
        {"Hipparcos Number", "HIP 44307"},
        {"Geneva Identification System", "GEN# +1.00077104"},
        {"Smithsonian Astrophysical Observation", "SAO 61202"},
        {"Wilson Evans Batten Catalogue", "WEB 8496"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.35053849),
        dec: Angle.Degrees(+32.25229474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94350",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12161 AB"},
        {"Henry Draper", "HD 179708"},
        {"Hipparcos Number", "HIP 94350"},
        {"Celescope Catalog", "CEL 4719"},
        {"Geneva Identification System", "GEN# +1.00179708J"},
        {"Smithsonian Astrophysical Observation", "SAO 67959"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.06166266),
        dec: Angle.Degrees(+32.25275891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70755"},
        {"Hipparcos Number", "HIP 41248"},
        {"Smithsonian Astrophysical Observation", "SAO 60792"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23468084),
        dec: Angle.Degrees(+32.25588586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85719"},
        {"Hipparcos Number", "HIP 48570"},
        {"Geneva Identification System", "GEN# +1.00085719"},
        {"Smithsonian Astrophysical Observation", "SAO 61747"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.59516521),
        dec: Angle.Degrees(+32.25712421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134225"},
        {"Hipparcos Number", "HIP 74032"},
        {"Geneva Identification System", "GEN# +1.00134225"},
        {"Smithsonian Astrophysical Observation", "SAO 64512"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.93805188),
        dec: Angle.Degrees(+32.25920287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11542"},
        {"Geneva Identification System", "GEN# +0.03100434J"},
        {"Wilson Evans Batten Catalogue", "WEB 2409"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.19241883),
        dec: Angle.Degrees(+32.25925538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 445.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43403"},
        {"Hipparcos Number", "HIP 29878"},
        {"Geneva Identification System", "GEN# +1.00043403"},
        {"Smithsonian Astrophysical Observation", "SAO 58945"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.37563467),
        dec: Angle.Degrees(+32.26336071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2784 AB"},
        {"Henry Draper", "HD 23802"},
        {"Hipparcos Number", "HIP 17845"},
        {"Geneva Identification System", "GEN# +1.00023802"},
        {"Smithsonian Astrophysical Observation", "SAO 56722"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.28038951),
        dec: Angle.Degrees(+32.26429158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80580"},
        {"Hipparcos Number", "HIP 45910"},
        {"Geneva Identification System", "GEN# +1.00080580"},
        {"Smithsonian Astrophysical Observation", "SAO 61425"},
        {"Wilson Evans Batten Catalogue", "WEB 8709"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.41434234),
        dec: Angle.Degrees(+32.26433245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84004"},
        {"Hipparcos Number", "HIP 47652"},
        {"Geneva Identification System", "GEN# +1.00084004"},
        {"Smithsonian Astrophysical Observation", "SAO 61651"},
        {"Wilson Evans Batten Catalogue", "WEB 8930"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.72939378),
        dec: Angle.Degrees(+32.26481293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91892",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91892"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.98980631),
        dec: Angle.Degrees(+32.26785866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94081"},
        {"Smithsonian Astrophysical Observation", "SAO 67876"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.27846969),
        dec: Angle.Degrees(+32.26867272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25185"},
        {"Hipparcos Number", "HIP 18780"},
        {"Geneva Identification System", "GEN# +1.00025185"},
        {"Smithsonian Astrophysical Observation", "SAO 56901"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.35454339),
        dec: Angle.Degrees(+32.26877269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261822"},
        {"Hipparcos Number", "HIP 32056"},
        {"Smithsonian Astrophysical Observation", "SAO 59376"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.46293850),
        dec: Angle.Degrees(+32.27097885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44794"},
        {"Hipparcos Number", "HIP 30540"},
        {"Smithsonian Astrophysical Observation", "SAO 59063"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.30345056),
        dec: Angle.Degrees(+32.27176626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8368 A"},
        {"Henry Draper", "HD 103928"},
        {"Hipparcos Number", "HIP 58369"},
        {"Fundamental Katalog 5th Edition", "FK5 1310"},
        {"Geneva Identification System", "GEN# +1.00103928"},
        {"Smithsonian Astrophysical Observation", "SAO 62774"},
        {"Wilson Evans Batten Catalogue", "WEB 10433"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.53020284),
        dec: Angle.Degrees(+32.27405870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34669"},
        {"Hipparcos Number", "HIP 24949"},
        {"Smithsonian Astrophysical Observation", "SAO 57920"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15999900),
        dec: Angle.Degrees(+32.27415422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70846"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.31874062),
        dec: Angle.Degrees(+32.27827173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64389"},
        {"Hipparcos Number", "HIP 38658"},
        {"Geneva Identification System", "GEN# +1.00064389"},
        {"Smithsonian Astrophysical Observation", "SAO 60441"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.72593587),
        dec: Angle.Degrees(+32.28481700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198425"},
        {"Hipparcos Number", "HIP 102766"},
        {"Cincinnati Publication", "Ci 18 2698"},
        {"Smithsonian Astrophysical Observation", "SAO 70545"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31809562),
        dec: Angle.Degrees(+32.28543792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82996"},
        {"Smithsonian Astrophysical Observation", "SAO 65673"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.40178220),
        dec: Angle.Degrees(+32.28570318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191918"},
        {"Hipparcos Number", "HIP 99449"},
        {"Smithsonian Astrophysical Observation", "SAO 69566"},
        {"Wilson Evans Batten Catalogue", "WEB 17771"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.77111378),
        dec: Angle.Degrees(+32.28683494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210514"},
        {"Hipparcos Number", "HIP 109437"},
        {"Smithsonian Astrophysical Observation", "SAO 72084"},
        {"Wilson Evans Batten Catalogue", "WEB 19663"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.57071665),
        dec: Angle.Degrees(+32.28818251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17448",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Atik"},
        {"Aitken", "ADS 2726 AB"},
        {"Henry Draper", "HD 23180"},
        {"Hipparcos Number", "HIP 17448"},
        {"Geneva Identification System", "GEN# +1.00023180"},
        {"Smithsonian Astrophysical Observation", "SAO 56673"},
        {"Wilson Evans Batten Catalogue", "WEB 3303"},
    },
    visualMagnitude: 3.84,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.07969347),
        dec: Angle.Degrees(+32.28827325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73133"},
        {"Hipparcos Number", "HIP 42330"},
        {"Smithsonian Astrophysical Observation", "SAO 60932"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.45489020),
        dec: Angle.Degrees(+32.28859589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36453"},
        {"Hipparcos Number", "HIP 26034"},
        {"Celescope Catalog", "CEL 773"},
        {"Geneva Identification System", "GEN# +1.00036453"},
        {"Smithsonian Astrophysical Observation", "SAO 58177"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.31470388),
        dec: Angle.Degrees(+32.28940600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51023"},
        {"Hipparcos Number", "HIP 33430"},
        {"Geneva Identification System", "GEN# +1.00051023"},
        {"Smithsonian Astrophysical Observation", "SAO 59633"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.27424605),
        dec: Angle.Degrees(+32.29002035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23478"},
        {"Hipparcos Number", "HIP 17631"},
        {"Geneva Identification System", "GEN# +1.00023478"},
        {"Smithsonian Astrophysical Observation", "SAO 56695"},
        {"Wilson Evans Batten Catalogue", "WEB 3361"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.67027283),
        dec: Angle.Degrees(+32.29020752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85203"},
        {"Smithsonian Astrophysical Observation", "SAO 66017"},
        {"Wilson Evans Batten Catalogue", "WEB 14388"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.16220551),
        dec: Angle.Degrees(+32.29031585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46641"},
        {"Hipparcos Number", "HIP 31519"},
        {"Smithsonian Astrophysical Observation", "SAO 59271"},
        {"Wilson Evans Batten Catalogue", "WEB 6308"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.99705766),
        dec: Angle.Degrees(+32.29082178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4304"},
        {"Smithsonian Astrophysical Observation", "SAO 54259"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.78622944),
        dec: Angle.Degrees(+32.29261045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70566"},
        {"Hipparcos Number", "HIP 41159"},
        {"Fundamental Katalog 5th Edition", "FK5 4754"},
        {"Geneva Identification System", "GEN# +1.00070566"},
        {"Smithsonian Astrophysical Observation", "SAO 60784"},
        {"Wilson Evans Batten Catalogue", "WEB 7966"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.96685890),
        dec: Angle.Degrees(+32.29351381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114658"},
        {"Hipparcos Number", "HIP 64358"},
        {"Geneva Identification System", "GEN# +1.00114658"},
        {"Smithsonian Astrophysical Observation", "SAO 63390"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87154998),
        dec: Angle.Degrees(+32.29384793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7963"},
        {"Hipparcos Number", "HIP 6209"},
        {"Smithsonian Astrophysical Observation", "SAO 54602"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.89980174),
        dec: Angle.Degrees(+32.29493930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124186"},
        {"Hipparcos Number", "HIP 69316"},
        {"Geneva Identification System", "GEN# +1.00124186"},
        {"Smithsonian Astrophysical Observation", "SAO 63979"},
        {"Wilson Evans Batten Catalogue", "WEB 12089"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.81306894),
        dec: Angle.Degrees(+32.29579911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83326"},
        {"Smithsonian Astrophysical Observation", "SAO 65740"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.45655213),
        dec: Angle.Degrees(+32.29685567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282508"},
        {"Hipparcos Number", "HIP 22603"},
        {"Smithsonian Astrophysical Observation", "SAO 57461"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.94907237),
        dec: Angle.Degrees(+32.29846689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132029"},
        {"Hipparcos Number", "HIP 73068"},
        {"Geneva Identification System", "GEN# +1.00132029"},
        {"Smithsonian Astrophysical Observation", "SAO 64408"},
        {"Wilson Evans Batten Catalogue", "WEB 12527"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.99429053),
        dec: Angle.Degrees(+32.30007060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111826"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.75681355),
        dec: Angle.Degrees(+32.30125815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92195"},
        {"Hipparcos Number", "HIP 52141"},
        {"Smithsonian Astrophysical Observation", "SAO 62180"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.78599938),
        dec: Angle.Degrees(+32.30170814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95789"},
        {"Hipparcos Number", "HIP 54058"},
        {"Smithsonian Astrophysical Observation", "SAO 62380"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.92424103),
        dec: Angle.Degrees(+32.30427837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102066",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14158 A"},
        {"Henry Draper", "HD 197177"},
        {"Hipparcos Number", "HIP 102066"},
        {"Geneva Identification System", "GEN# +1.00197177"},
        {"Smithsonian Astrophysical Observation", "SAO 70362"},
        {"Wilson Evans Batten Catalogue", "WEB 18453"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.26058373),
        dec: Angle.Degrees(+32.30731586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258087"},
        {"Hipparcos Number", "HIP 30969"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.50857330),
        dec: Angle.Degrees(+32.30886239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49066"},
        {"Cincinnati Publication", "Ci 20 557"},
    },
    visualMagnitude: 11.93,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.18742511),
        dec: Angle.Degrees(+32.31099111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1008.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -663.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174125"},
        {"Hipparcos Number", "HIP 92216"},
        {"Smithsonian Astrophysical Observation", "SAO 67387"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.90609596),
        dec: Angle.Degrees(+32.31184657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192244"},
        {"Hipparcos Number", "HIP 99601"},
        {"Geneva Identification System", "GEN# +1.00192244"},
        {"Smithsonian Astrophysical Observation", "SAO 69607"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.19263351),
        dec: Angle.Degrees(+32.31352176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178210"},
        {"Hipparcos Number", "HIP 93813"},
        {"Smithsonian Astrophysical Observation", "SAO 67816"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.58160650),
        dec: Angle.Degrees(+32.31352196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6741 AB"},
        {"Henry Draper", "HD 69845"},
        {"Hipparcos Number", "HIP 40852"},
        {"Smithsonian Astrophysical Observation", "SAO 60737"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.03443652),
        dec: Angle.Degrees(+32.31582881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100067"},
        {"Hipparcos Number", "HIP 56186"},
        {"Cincinnati Publication", "Ci 20 643"},
        {"Geneva Identification System", "GEN# +1.00100067"},
        {"Smithsonian Astrophysical Observation", "SAO 62584"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.75532907),
        dec: Angle.Degrees(+32.31613331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -325.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13189"},
        {"Hipparcos Number", "HIP 10085"},
        {"Smithsonian Astrophysical Observation", "SAO 55309"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.41737787),
        dec: Angle.Degrees(+32.31642158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14361"},
        {"Hipparcos Number", "HIP 10881"},
        {"Smithsonian Astrophysical Observation", "SAO 55462"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.01186168),
        dec: Angle.Degrees(+32.31857455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32428"},
        {"Hipparcos Number", "HIP 23611"},
        {"Geneva Identification System", "GEN# +1.00032428"},
        {"Renson", "Renson 8240"},
        {"Smithsonian Astrophysical Observation", "SAO 57614"},
        {"Wilson Evans Batten Catalogue", "WEB 4601"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15382930),
        dec: Angle.Degrees(+32.32043676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16594"},
        {"Hipparcos Number", "HIP 12457"},
        {"Smithsonian Astrophysical Observation", "SAO 55773"},
        {"Wilson Evans Batten Catalogue", "WEB 2547"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.10900425),
        dec: Angle.Degrees(+32.32043925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38050"},
        {"Smithsonian Astrophysical Observation", "SAO 60344"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.98704154),
        dec: Angle.Degrees(+32.32062513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53391"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.80873883),
        dec: Angle.Degrees(+32.32351079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332196"},
        {"Hipparcos Number", "HIP 100465"},
        {"Smithsonian Astrophysical Observation", "SAO 69914"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.59823876),
        dec: Angle.Degrees(+32.32463251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 257.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208313"},
        {"Hipparcos Number", "HIP 108156"},
        {"Cincinnati Publication", "Ci 18 2850"},
        {"Geneva Identification System", "GEN# +1.00208313"},
        {"Smithsonian Astrophysical Observation", "SAO 71824"},
        {"Wilson Evans Batten Catalogue", "WEB 19495"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.68706116),
        dec: Angle.Degrees(+32.32913686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278776"},
        {"Hipparcos Number", "HIP 16408"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.81820620),
        dec: Angle.Degrees(+32.33040395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58386"},
        {"Geneva Identification System", "GEN# +0.03302175"},
        {"Smithsonian Astrophysical Observation", "SAO 62778"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.57901366),
        dec: Angle.Degrees(+32.33070408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52655"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.50946756),
        dec: Angle.Degrees(+32.33242026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4998 AB"},
        {"Henry Draper", "HD 256097"},
        {"Hipparcos Number", "HIP 30411"},
        {"Smithsonian Astrophysical Observation", "SAO 59036"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.91584030),
        dec: Angle.Degrees(+32.33291296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80247",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10031 A"},
        {"Henry Draper", "HD 147835"},
        {"Hipparcos Number", "HIP 80247"},
        {"Fundamental Katalog 5th Edition", "FK5 1428"},
        {"Geneva Identification System", "GEN# +1.00147835A"},
        {"Smithsonian Astrophysical Observation", "SAO 65262"},
        {"Wilson Evans Batten Catalogue", "WEB 13581"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.73534870),
        dec: Angle.Degrees(+32.33303005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104495"},
        {"Hipparcos Number", "HIP 58683"},
        {"Geneva Identification System", "GEN# +1.00104495"},
        {"Smithsonian Astrophysical Observation", "SAO 62805"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.51673913),
        dec: Angle.Degrees(+32.33309107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7549"},
        {"Hipparcos Number", "HIP 5911"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.01483526),
        dec: Angle.Degrees(+32.33415068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17962"},
        {"Hipparcos Number", "HIP 13522"},
        {"Geneva Identification System", "GEN# +1.00017962"},
        {"Smithsonian Astrophysical Observation", "SAO 55986"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.53690200),
        dec: Angle.Degrees(+32.33631989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74049"},
        {"Hipparcos Number", "HIP 42750"},
        {"Smithsonian Astrophysical Observation", "SAO 61000"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.68910648),
        dec: Angle.Degrees(+32.33700432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118051"},
        {"Hipparcos Number", "HIP 66175"},
        {"Geneva Identification System", "GEN# +1.00118051"},
        {"Smithsonian Astrophysical Observation", "SAO 63609"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45752800),
        dec: Angle.Degrees(+32.33727329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208345"},
        {"Hipparcos Number", "HIP 108167"},
        {"Fundamental Katalog 5th Edition", "FK5 3747"},
        {"Geneva Identification System", "GEN# +1.00208345"},
        {"Smithsonian Astrophysical Observation", "SAO 71831"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.72657325),
        dec: Angle.Degrees(+32.33874311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133799"},
        {"Hipparcos Number", "HIP 73831"},
        {"Smithsonian Astrophysical Observation", "SAO 64495"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.33410951),
        dec: Angle.Degrees(+32.34223788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5375"},
        {"Hipparcos Number", "HIP 4373"},
        {"Geneva Identification System", "GEN# +1.00005375"},
        {"Smithsonian Astrophysical Observation", "SAO 54274"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.00771768),
        dec: Angle.Degrees(+32.34230343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142613"},
        {"Hipparcos Number", "HIP 77877"},
        {"Geneva Identification System", "GEN# +1.00142613"},
        {"Smithsonian Astrophysical Observation", "SAO 64967"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.55138837),
        dec: Angle.Degrees(+32.34263230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63941"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.56011251),
        dec: Angle.Degrees(+32.34377136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95596",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12456 B"},
        {"Hipparcos Number", "HIP 95596"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.66075736),
        dec: Angle.Degrees(+32.34393294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12456 A"},
        {"Henry Draper", "HD 183101"},
        {"Hipparcos Number", "HIP 95599"},
        {"Geneva Identification System", "GEN# +1.00183101"},
        {"Smithsonian Astrophysical Observation", "SAO 68315"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.66497589),
        dec: Angle.Degrees(+32.34571604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62343"},
        {"Hipparcos Number", "HIP 37775"},
        {"Geneva Identification System", "GEN# +1.00062343"},
        {"Smithsonian Astrophysical Observation", "SAO 60314"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.18715435),
        dec: Angle.Degrees(+32.34597043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54403"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.99104399),
        dec: Angle.Degrees(+32.34969209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200510"},
        {"Hipparcos Number", "HIP 103876"},
        {"Smithsonian Astrophysical Observation", "SAO 70824"},
        {"Wilson Evans Batten Catalogue", "WEB 18914"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.72944756),
        dec: Angle.Degrees(+32.34989185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3613"},
        {"Smithsonian Astrophysical Observation", "SAO 54134"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.56817521),
        dec: Angle.Degrees(+32.35072120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196523"},
        {"Hipparcos Number", "HIP 101709"},
        {"Smithsonian Astrophysical Observation", "SAO 70268"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.24466335),
        dec: Angle.Degrees(+32.35124372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89041",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11131 AB"},
        {"Henry Draper", "HD 166682"},
        {"Hipparcos Number", "HIP 89041"},
        {"Smithsonian Astrophysical Observation", "SAO 66709"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.60925288),
        dec: Angle.Degrees(+32.35280526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49740"},
        {"Smithsonian Astrophysical Observation", "SAO 61901"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.31213885),
        dec: Angle.Degrees(+32.36098607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75758"},
        {"Smithsonian Astrophysical Observation", "SAO 64720"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.15257777),
        dec: Angle.Degrees(+32.36253746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17648"},
        {"Hipparcos Number", "HIP 13284"},
        {"Smithsonian Astrophysical Observation", "SAO 55939"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.74860581),
        dec: Angle.Degrees(+32.36403541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37326"},
        {"Smithsonian Astrophysical Observation", "SAO 60252"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.93904762),
        dec: Angle.Degrees(+32.36465722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49737"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.30388712),
        dec: Angle.Degrees(+32.36664931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4962"},
        {"Hipparcos Number", "HIP 4053"},
        {"Smithsonian Astrophysical Observation", "SAO 54210"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.97751777),
        dec: Angle.Degrees(+32.36701383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163186"},
        {"Hipparcos Number", "HIP 87577"},
        {"Geneva Identification System", "GEN# +1.00163186"},
        {"Smithsonian Astrophysical Observation", "SAO 66431"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.36535241),
        dec: Angle.Degrees(+32.36804703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16954"},
        {"Hipparcos Number", "HIP 12765"},
        {"Smithsonian Astrophysical Observation", "SAO 55822"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.00571126),
        dec: Angle.Degrees(+32.37039247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92591"},
        {"Smithsonian Astrophysical Observation", "SAO 67493"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.00688421),
        dec: Angle.Degrees(+32.37408574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111216"},
        {"Smithsonian Astrophysical Observation", "SAO 72437"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.96877201),
        dec: Angle.Degrees(+32.37498070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93289"},
        {"Hipparcos Number", "HIP 52725"},
        {"Smithsonian Astrophysical Observation", "SAO 62248"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.69151783),
        dec: Angle.Degrees(+32.37607738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184941"},
        {"Hipparcos Number", "HIP 96364"},
        {"Celescope Catalog", "CEL 4794"},
        {"Geneva Identification System", "GEN# +1.00184941"},
        {"Smithsonian Astrophysical Observation", "SAO 68543"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88878835),
        dec: Angle.Degrees(+32.37650440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77660"},
        {"Hipparcos Number", "HIP 44574"},
        {"Geneva Identification System", "GEN# +1.00077660"},
        {"Smithsonian Astrophysical Observation", "SAO 61242"},
        {"Wilson Evans Batten Catalogue", "WEB 8531"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.22967098),
        dec: Angle.Degrees(+32.37698738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21086"},
        {"Hipparcos Number", "HIP 15937"},
        {"Smithsonian Astrophysical Observation", "SAO 56430"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30553246),
        dec: Angle.Degrees(+32.37945870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51556",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7813 A"},
        {"Henry Draper", "HD 91130"},
        {"Hipparcos Number", "HIP 51556"},
        {"Geneva Identification System", "GEN# +1.00091130"},
        {"Smithsonian Astrophysical Observation", "SAO 62101"},
        {"Wilson Evans Batten Catalogue", "WEB 9406"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.96401631),
        dec: Angle.Degrees(+32.37953760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78959"},
        {"Smithsonian Astrophysical Observation", "SAO 65088"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.78611775),
        dec: Angle.Degrees(+32.37957626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193009"},
        {"Hipparcos Number", "HIP 99953"},
        {"Geneva Identification System", "GEN# +1.00193009"},
        {"Smithsonian Astrophysical Observation", "SAO 69737"},
        {"Wilson Evans Batten Catalogue", "WEB 17986"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.20077487),
        dec: Angle.Degrees(+32.37985586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73180"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.35088624),
        dec: Angle.Degrees(+32.38082159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23557",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3642 A"},
        {"Henry Draper", "HD 32344"},
        {"Hipparcos Number", "HIP 23557"},
        {"Smithsonian Astrophysical Observation", "SAO 57604"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.97684150),
        dec: Angle.Degrees(+32.38143475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224544"},
        {"Hipparcos Number", "HIP 118224"},
        {"Fundamental Katalog 5th Edition", "FK5 3927"},
        {"Geneva Identification System", "GEN# +1.00224544"},
        {"Smithsonian Astrophysical Observation", "SAO 73650"},
        {"Wilson Evans Batten Catalogue", "WEB 20779"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70514690),
        dec: Angle.Degrees(+32.38171073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70353"},
        {"Smithsonian Astrophysical Observation", "SAO 64119"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.92007927),
        dec: Angle.Degrees(+32.38287784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86012"},
        {"Hipparcos Number", "HIP 48742"},
        {"Fundamental Katalog 5th Edition", "FK5 4885"},
        {"Geneva Identification System", "GEN# +1.00086012"},
        {"Smithsonian Astrophysical Observation", "SAO 61771"},
        {"Wilson Evans Batten Catalogue", "WEB 9065"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.13065969),
        dec: Angle.Degrees(+32.38460896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220599"},
        {"Hipparcos Number", "HIP 115591"},
        {"Fundamental Katalog 5th Edition", "FK5 1613"},
        {"Geneva Identification System", "GEN# +1.00220599"},
        {"Smithsonian Astrophysical Observation", "SAO 73241"},
        {"Wilson Evans Batten Catalogue", "WEB 20460"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.21175378),
        dec: Angle.Degrees(+32.38487495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109066"},
        {"Smithsonian Astrophysical Observation", "SAO 72017"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.41885690),
        dec: Angle.Degrees(+32.38501549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25799"},
        {"Hipparcos Number", "HIP 19178"},
        {"Geneva Identification System", "GEN# +1.00025799"},
        {"Smithsonian Astrophysical Observation", "SAO 56968"},
        {"Wilson Evans Batten Catalogue", "WEB 3683"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.66267028),
        dec: Angle.Degrees(+32.38507127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97241"},
    },
    visualMagnitude: 10.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.45614527),
        dec: Angle.Degrees(+32.38665088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 387.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 193.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50506"},
        {"Smithsonian Astrophysical Observation", "SAO 61981"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.73312938),
        dec: Angle.Degrees(+32.38925086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12502"},
        {"Hipparcos Number", "HIP 9590"},
        {"Smithsonian Astrophysical Observation", "SAO 55225"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.82603049),
        dec: Angle.Degrees(+32.38991710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27128"},
        {"Hipparcos Number", "HIP 20072"},
        {"Geneva Identification System", "GEN# +1.00027128"},
        {"Smithsonian Astrophysical Observation", "SAO 57138"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56101543),
        dec: Angle.Degrees(+32.39060424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177006"},
        {"Hipparcos Number", "HIP 93413"},
        {"Celescope Catalog", "CEL 4690"},
        {"Geneva Identification System", "GEN# +1.00177006"},
        {"Smithsonian Astrophysical Observation", "SAO 67716"},
        {"Wilson Evans Batten Catalogue", "WEB 16208"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.37478388),
        dec: Angle.Degrees(+32.39232993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68813"},
        {"Geneva Identification System", "GEN# +0.03302410"},
        {"Smithsonian Astrophysical Observation", "SAO 63926"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.32143326),
        dec: Angle.Degrees(+32.39535945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40891"},
        {"Smithsonian Astrophysical Observation", "SAO 60743"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.17131563),
        dec: Angle.Degrees(+32.39560372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50660"},
        {"Smithsonian Astrophysical Observation", "SAO 61990"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.19179450),
        dec: Angle.Degrees(+32.39856057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175701"},
        {"Hipparcos Number", "HIP 92851"},
        {"Celescope Catalog", "CEL 4668"},
        {"Geneva Identification System", "GEN# +1.00175701"},
        {"Smithsonian Astrophysical Observation", "SAO 67572"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81200779),
        dec: Angle.Degrees(+32.40017526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332293"},
        {"Hipparcos Number", "HIP 100914"},
        {"Smithsonian Astrophysical Observation", "SAO 70053"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.90646958),
        dec: Angle.Degrees(+32.40185137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31618"},
        {"Hipparcos Number", "HIP 23136"},
        {"Smithsonian Astrophysical Observation", "SAO 57543"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.67668530),
        dec: Angle.Degrees(+32.40382970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44107"},
        {"Hipparcos Number", "HIP 30222"},
        {"Smithsonian Astrophysical Observation", "SAO 59004"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.37164153),
        dec: Angle.Degrees(+32.40411978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185602"},
        {"Hipparcos Number", "HIP 96619"},
        {"Smithsonian Astrophysical Observation", "SAO 68617"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.66402954),
        dec: Angle.Degrees(+32.40609788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70921"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.54473347),
        dec: Angle.Degrees(+32.40706588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93611"},
        {"Hipparcos Number", "HIP 52880"},
        {"Geneva Identification System", "GEN# +1.00093611"},
        {"Smithsonian Astrophysical Observation", "SAO 62264"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.23645743),
        dec: Angle.Degrees(+32.40766259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14948"},
        {"Hipparcos Number", "HIP 11299"},
        {"Fundamental Katalog 5th Edition", "FK5 4225"},
        {"Smithsonian Astrophysical Observation", "SAO 55539"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.36643404),
        dec: Angle.Degrees(+32.40769784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223867"},
        {"Hipparcos Number", "HIP 117784"},
        {"Geneva Identification System", "GEN# +1.00223867"},
        {"Smithsonian Astrophysical Observation", "SAO 73586"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.29561685),
        dec: Angle.Degrees(+32.40852554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24228"},
        {"Hipparcos Number", "HIP 18138"},
        {"Geneva Identification System", "GEN# +1.00024228"},
        {"Smithsonian Astrophysical Observation", "SAO 56775"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.16535938),
        dec: Angle.Degrees(+32.40858934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143174"},
        {"Hipparcos Number", "HIP 78161"},
        {"Smithsonian Astrophysical Observation", "SAO 64986"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.40471071),
        dec: Angle.Degrees(+32.40882194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74029",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74029"},
        {"Cincinnati Publication", "Ci 20 912"},
        {"Geneva Identification System", "GEN# +0.03202547"},
        {"Wilson Evans Batten Catalogue", "WEB 12643"},
    },
    visualMagnitude: 11.14,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.92280346),
        dec: Angle.Degrees(+32.41150681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -458.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243357"},
        {"Hipparcos Number", "HIP 25361"},
        {"Geneva Identification System", "GEN# +1.00243357"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.36614479),
        dec: Angle.Degrees(+32.41191060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14081",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2286 A"},
        {"Henry Draper", "HD 18715"},
        {"Hipparcos Number", "HIP 14081"},
        {"Geneva Identification System", "GEN# +1.00018715"},
        {"Smithsonian Astrophysical Observation", "SAO 56095"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.37107017),
        dec: Angle.Degrees(+32.41276331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5680 A"},
        {"Henry Draper", "HD 52100"},
        {"Hipparcos Number", "HIP 33823"},
        {"Geneva Identification System", "GEN# +1.00052100"},
        {"Smithsonian Astrophysical Observation", "SAO 59697"},
        {"Wilson Evans Batten Catalogue", "WEB 6791"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.32092169),
        dec: Angle.Degrees(+32.41460608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47649"},
        {"Hipparcos Number", "HIP 31997"},
        {"Smithsonian Astrophysical Observation", "SAO 59361"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.29058770),
        dec: Angle.Degrees(+32.41664656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159695"},
        {"Hipparcos Number", "HIP 86015"},
        {"Geneva Identification System", "GEN# +1.00159695"},
        {"Smithsonian Astrophysical Observation", "SAO 66147"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.68415451),
        dec: Angle.Degrees(+32.41718630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44230",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7124 AB"},
        {"Henry Draper", "HD 76975"},
        {"Hipparcos Number", "HIP 44230"},
        {"Smithsonian Astrophysical Observation", "SAO 61192"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.12781722),
        dec: Angle.Degrees(+32.41755799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151779"},
        {"Hipparcos Number", "HIP 82243"},
        {"Smithsonian Astrophysical Observation", "SAO 65563"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.04818540),
        dec: Angle.Degrees(+32.41785387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76813"},
        {"Hipparcos Number", "HIP 44154"},
        {"Fundamental Katalog 5th Edition", "FK5 1232"},
        {"Geneva Identification System", "GEN# +1.00076813"},
        {"Smithsonian Astrophysical Observation", "SAO 61177"},
        {"Wilson Evans Batten Catalogue", "WEB 8482"},
    },
    visualMagnitude: 5.23,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.88618568),
        dec: Angle.Degrees(+32.41864339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198056"},
        {"Hipparcos Number", "HIP 102542"},
        {"Celescope Catalog", "CEL 5163"},
        {"Geneva Identification System", "GEN# +1.00198056"},
        {"Smithsonian Astrophysical Observation", "SAO 70480"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.69779479),
        dec: Angle.Degrees(+32.41995342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25143"},
        {"Hipparcos Number", "HIP 18747"},
        {"Geneva Identification System", "GEN# +1.00025143"},
        {"Smithsonian Astrophysical Observation", "SAO 56891"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.23548111),
        dec: Angle.Degrees(+32.42090565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66683"},
        {"Hipparcos Number", "HIP 39630"},
        {"Geneva Identification System", "GEN# +1.00066683"},
        {"Smithsonian Astrophysical Observation", "SAO 60555"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.48078889),
        dec: Angle.Degrees(+32.42419992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186377"},
        {"Hipparcos Number", "HIP 96977"},
        {"Celescope Catalog", "CEL 4820"},
        {"Fundamental Katalog 5th Edition", "FK5 3577"},
        {"Geneva Identification System", "GEN# +1.00186377"},
        {"Smithsonian Astrophysical Observation", "SAO 68730"},
        {"Wilson Evans Batten Catalogue", "WEB 17018"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.68585235),
        dec: Angle.Degrees(+32.42674436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205745"},
        {"Hipparcos Number", "HIP 106692"},
        {"Smithsonian Astrophysical Observation", "SAO 71515"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.14842864),
        dec: Angle.Degrees(+32.42863907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66654"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.94398535),
        dec: Angle.Degrees(+32.42955952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23963"},
        {"Hipparcos Number", "HIP 17967"},
        {"Geneva Identification System", "GEN# +1.00023963"},
        {"Smithsonian Astrophysical Observation", "SAO 56739"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.62181496),
        dec: Angle.Degrees(+32.43128281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113319"},
        {"Hipparcos Number", "HIP 63636"},
        {"Geneva Identification System", "GEN# +1.00113319"},
        {"Smithsonian Astrophysical Observation", "SAO 63314"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.63996681),
        dec: Angle.Degrees(+32.43313939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2453"},
        {"Hipparcos Number", "HIP 2243"},
        {"Geneva Identification System", "GEN# +1.00002453"},
        {"Renson", "Renson 560"},
        {"Smithsonian Astrophysical Observation", "SAO 53921"},
        {"Wilson Evans Batten Catalogue", "WEB 418"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.11912255),
        dec: Angle.Degrees(+32.43779213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241701"},
        {"Hipparcos Number", "HIP 24411"},
        {"Smithsonian Astrophysical Observation", "SAO 57777"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.55477016),
        dec: Angle.Degrees(+32.43795819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163590"},
        {"Hipparcos Number", "HIP 87749"},
        {"Smithsonian Astrophysical Observation", "SAO 66469"},
        {"Wilson Evans Batten Catalogue", "WEB 14808"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.85570321),
        dec: Angle.Degrees(+32.43834395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150844"},
        {"Hipparcos Number", "HIP 81790"},
        {"Geneva Identification System", "GEN# +1.00150844"},
        {"Smithsonian Astrophysical Observation", "SAO 65494"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.57479662),
        dec: Angle.Degrees(+32.43871161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48952"},
        {"Smithsonian Astrophysical Observation", "SAO 61792"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.79579722),
        dec: Angle.Degrees(+32.43894064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52033"},
        {"Hipparcos Number", "HIP 33801"},
        {"Geneva Identification System", "GEN# +1.00052033"},
        {"Smithsonian Astrophysical Observation", "SAO 59694"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.27332456),
        dec: Angle.Degrees(+32.43907341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281157"},
        {"Hipparcos Number", "HIP 17561"},
        {"Smithsonian Astrophysical Observation", "SAO 56688"},
    },
    visualMagnitude: 9.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.41315332),
        dec: Angle.Degrees(+32.44005758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194178"},
        {"Hipparcos Number", "HIP 100532"},
        {"Geneva Identification System", "GEN# +1.00194178"},
        {"Smithsonian Astrophysical Observation", "SAO 69928"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.77299097),
        dec: Angle.Degrees(+32.44194615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216207"},
        {"Hipparcos Number", "HIP 112801"},
        {"Smithsonian Astrophysical Observation", "SAO 72771"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.65814602),
        dec: Angle.Degrees(+32.44328175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76461"},
        {"Hipparcos Number", "HIP 43976"},
        {"Geneva Identification System", "GEN# +1.00076461"},
        {"Renson", "Renson 21540"},
        {"Smithsonian Astrophysical Observation", "SAO 61152"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.32802130),
        dec: Angle.Degrees(+32.44517723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212557"},
        {"Hipparcos Number", "HIP 110627"},
        {"Smithsonian Astrophysical Observation", "SAO 72308"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15998625),
        dec: Angle.Degrees(+32.44939946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1344"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.21006997),
        dec: Angle.Degrees(+32.45079528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131450"},
        {"Hipparcos Number", "HIP 72792"},
        {"Smithsonian Astrophysical Observation", "SAO 64372"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.17836800),
        dec: Angle.Degrees(+32.45122461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15896"},
        {"Hipparcos Number", "HIP 11942"},
        {"Smithsonian Astrophysical Observation", "SAO 55664"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.52206651),
        dec: Angle.Degrees(+32.45206151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14889 AB"},
        {"Henry Draper", "HD 203358"},
        {"Hipparcos Number", "HIP 105390"},
        {"Geneva Identification System", "GEN# +1.00203358"},
        {"Smithsonian Astrophysical Observation", "SAO 71230"},
        {"Wilson Evans Batten Catalogue", "WEB 19140"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.20838513),
        dec: Angle.Degrees(+32.45233066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87210"},
        {"Hipparcos Number", "HIP 49334"},
        {"Smithsonian Astrophysical Observation", "SAO 61841"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.06705799),
        dec: Angle.Degrees(+32.45251447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104182",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14637 A"},
        {"Henry Draper", "HD 201093"},
        {"Hipparcos Number", "HIP 104182"},
        {"Geneva Identification System", "GEN# +1.00201093"},
        {"Smithsonian Astrophysical Observation", "SAO 70915"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.61528083),
        dec: Angle.Degrees(+32.45328992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53560"},
        {"Hipparcos Number", "HIP 34323"},
        {"Smithsonian Astrophysical Observation", "SAO 59789"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.73132759),
        dec: Angle.Degrees(+32.45331111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193910"},
        {"Hipparcos Number", "HIP 100400"},
        {"Smithsonian Astrophysical Observation", "SAO 69891"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40327173),
        dec: Angle.Degrees(+32.45410696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46052"},
        {"Hipparcos Number", "HIP 31173"},
        {"Fundamental Katalog 5th Edition", "FK5 2500"},
        {"Geneva Identification System", "GEN# +1.00046052"},
        {"Renson", "Renson 12320"},
        {"Smithsonian Astrophysical Observation", "SAO 59194"},
        {"Wilson Evans Batten Catalogue", "WEB 6228"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.11334517),
        dec: Angle.Degrees(+32.45494059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5704"},
        {"Hipparcos Number", "HIP 4612"},
        {"Smithsonian Astrophysical Observation", "SAO 54316"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.77736519),
        dec: Angle.Degrees(+32.45579866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14637 B"},
        {"Hipparcos Number", "HIP 104180"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.61246733),
        dec: Angle.Degrees(+32.45780258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28459"},
        {"Hipparcos Number", "HIP 21038"},
        {"Geneva Identification System", "GEN# +1.00028459"},
        {"Smithsonian Astrophysical Observation", "SAO 57269"},
        {"Wilson Evans Batten Catalogue", "WEB 4044"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.66000962),
        dec: Angle.Degrees(+32.45781487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68017"},
        {"Hipparcos Number", "HIP 40118"},
        {"Cincinnati Publication", "Ci 20 461"},
        {"Geneva Identification System", "GEN# +1.00068017"},
        {"Smithsonian Astrophysical Observation", "SAO 60631"},
        {"Wilson Evans Batten Catalogue", "WEB 7828"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.91234372),
        dec: Angle.Degrees(+32.45869655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -460.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -644.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110526"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.87051591),
        dec: Angle.Degrees(+32.45993621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25999"},
        {"Hipparcos Number", "HIP 19306"},
        {"Renson", "Renson 6600"},
        {"Smithsonian Astrophysical Observation", "SAO 57004"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.07601502),
        dec: Angle.Degrees(+32.45999115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282408"},
        {"Hipparcos Number", "HIP 22133"},
        {"Smithsonian Astrophysical Observation", "SAO 57418"},
    },
    visualMagnitude: 8.88,
    bvColour: 2.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.44545066),
        dec: Angle.Degrees(+32.46058827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18393"},
        {"Hipparcos Number", "HIP 13851"},
        {"Smithsonian Astrophysical Observation", "SAO 56043"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.57814806),
        dec: Angle.Degrees(+32.46073168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40560"},
        {"Smithsonian Astrophysical Observation", "SAO 60700"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22540265),
        dec: Angle.Degrees(+32.46366750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68691"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.90690600),
        dec: Angle.Degrees(+32.46396328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 332129"},
        {"Hipparcos Number", "HIP 100251"},
        {"Geneva Identification System", "GEN# +1.00332129"},
        {"Smithsonian Astrophysical Observation", "SAO 69843"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.98828600),
        dec: Angle.Degrees(+32.46400168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27596"},
        {"Hipparcos Number", "HIP 20426"},
        {"Smithsonian Astrophysical Observation", "SAO 57194"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.64139657),
        dec: Angle.Degrees(+32.46793820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148096"},
        {"Hipparcos Number", "HIP 80388"},
        {"Smithsonian Astrophysical Observation", "SAO 65281"},
        {"Wilson Evans Batten Catalogue", "WEB 13601"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.12720141),
        dec: Angle.Degrees(+32.46833241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194541"},
        {"Hipparcos Number", "HIP 100711"},
        {"Smithsonian Astrophysical Observation", "SAO 69990"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.26674579),
        dec: Angle.Degrees(+32.46853059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220655"},
        {"Hipparcos Number", "HIP 115619"},
        {"Smithsonian Astrophysical Observation", "SAO 73244"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.32900033),
        dec: Angle.Degrees(+32.46916168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44926"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.27135349),
        dec: Angle.Degrees(+32.46930260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84862",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10488 A"},
        {"Henry Draper", "HD 157214"},
        {"Hipparcos Number", "HIP 84862"},
        {"Cincinnati Publication", "Ci 20 1035"},
        {"Fundamental Katalog 5th Edition", "FK5 1456"},
        {"Geneva Identification System", "GEN# +1.00157214"},
        {"Smithsonian Astrophysical Observation", "SAO 65963"},
        {"Wilson Evans Batten Catalogue", "WEB 14326"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.16447313),
        dec: Angle.Degrees(+32.47027246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1040.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253590"},
        {"Hipparcos Number", "HIP 29615"},
        {"Smithsonian Astrophysical Observation", "SAO 58883"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.61376352),
        dec: Angle.Degrees(+32.47297342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88057",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10954 AB"},
        {"Hipparcos Number", "HIP 88057"},
        {"Smithsonian Astrophysical Observation", "SAO 66537"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76919459),
        dec: Angle.Degrees(+32.47397568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137630"},
        {"Hipparcos Number", "HIP 75543"},
        {"Geneva Identification System", "GEN# +1.00137630"},
        {"Smithsonian Astrophysical Observation", "SAO 64699"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.49878053),
        dec: Angle.Degrees(+32.47408494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7057 A"},
        {"Henry Draper", "HD 75698"},
        {"Henry Draper 2", "HD 75698A"},
        {"Hipparcos Number", "HIP 43584"},
        {"Geneva Identification System", "GEN# +1.00075698"},
        {"Renson", "Renson 21200"},
        {"Smithsonian Astrophysical Observation", "SAO 61102"},
        {"Wilson Evans Batten Catalogue", "WEB 8399"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.14426783),
        dec: Angle.Degrees(+32.47412331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37252"},
        {"Hipparcos Number", "HIP 26544"},
        {"Geneva Identification System", "GEN# +1.00037252"},
        {"Smithsonian Astrophysical Observation", "SAO 58281"},
        {"Wilson Evans Batten Catalogue", "WEB 5231"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.67357853),
        dec: Angle.Degrees(+32.47510928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222631"},
        {"Hipparcos Number", "HIP 116938"},
        {"Smithsonian Astrophysical Observation", "SAO 73448"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.55717555),
        dec: Angle.Degrees(+32.47638918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 753"},
        {"Smithsonian Astrophysical Observation", "SAO 53684"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.31118231),
        dec: Angle.Degrees(+32.47666637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102944"},
        {"Hipparcos Number", "HIP 57804"},
        {"Smithsonian Astrophysical Observation", "SAO 62730"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.78719399),
        dec: Angle.Degrees(+32.47940254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331746"},
        {"Hipparcos Number", "HIP 99009"},
        {"Smithsonian Astrophysical Observation", "SAO 69400"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.50411992),
        dec: Angle.Degrees(+32.47973500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112958"},
        {"Hipparcos Number", "HIP 63434"},
        {"Geneva Identification System", "GEN# +1.00112958"},
        {"Smithsonian Astrophysical Observation", "SAO 63284"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.98333245),
        dec: Angle.Degrees(+32.47984972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47714"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.91419932),
        dec: Angle.Degrees(+32.48017382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141350"},
        {"Hipparcos Number", "HIP 77356"},
        {"Smithsonian Astrophysical Observation", "SAO 64906"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.87076347),
        dec: Angle.Degrees(+32.48193127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19541"},
        {"Hipparcos Number", "HIP 14681"},
        {"Smithsonian Astrophysical Observation", "SAO 56209"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.41775311),
        dec: Angle.Degrees(+32.48255557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208941"},
        {"Hipparcos Number", "HIP 108512"},
        {"Smithsonian Astrophysical Observation", "SAO 71905"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.74809866),
        dec: Angle.Degrees(+32.48325412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16561 AB"},
        {"Henry Draper", "HD 218767"},
        {"Hipparcos Number", "HIP 114415"},
        {"Geneva Identification System", "GEN# +1.00218767J"},
        {"Smithsonian Astrophysical Observation", "SAO 73054"},
        {"Wilson Evans Batten Catalogue", "WEB 20312"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.57136395),
        dec: Angle.Degrees(+32.48705479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331491"},
        {"Hipparcos Number", "HIP 98063"},
        {"Geneva Identification System", "GEN# +1.00331491"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.93701585),
        dec: Angle.Degrees(+32.48746950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115519"},
        {"Hipparcos Number", "HIP 64826"},
        {"Geneva Identification System", "GEN# +1.00115519"},
        {"Smithsonian Astrophysical Observation", "SAO 63448"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.33286650),
        dec: Angle.Degrees(+32.48788200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122422"},
        {"Hipparcos Number", "HIP 68466"},
        {"Geneva Identification System", "GEN# +1.00122422"},
        {"Smithsonian Astrophysical Observation", "SAO 63887"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.26439913),
        dec: Angle.Degrees(+32.48949083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96596"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54827916),
        dec: Angle.Degrees(+32.48957988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102493"},
        {"Hipparcos Number", "HIP 57561"},
        {"Geneva Identification System", "GEN# +1.00102493"},
        {"Smithsonian Astrophysical Observation", "SAO 62706"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.97863093),
        dec: Angle.Degrees(+32.49097570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5986"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.24571553),
        dec: Angle.Degrees(+32.49224575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200043"},
        {"Hipparcos Number", "HIP 103645"},
        {"Smithsonian Astrophysical Observation", "SAO 70771"},
        {"Wilson Evans Batten Catalogue", "WEB 18862"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.99498628),
        dec: Angle.Degrees(+32.49570600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144360"},
        {"Hipparcos Number", "HIP 78729"},
        {"Smithsonian Astrophysical Observation", "SAO 65058"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.08175794),
        dec: Angle.Degrees(+32.49737858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69716"},
        {"Hipparcos Number", "HIP 40782"},
        {"Smithsonian Astrophysical Observation", "SAO 60728"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.85736049),
        dec: Angle.Degrees(+32.49764670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130304"},
        {"Hipparcos Number", "HIP 72249"},
        {"Smithsonian Astrophysical Observation", "SAO 64321"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.61862863),
        dec: Angle.Degrees(+32.49958601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12061 A"},
        {"Henry Draper", "HD 178449"},
        {"Hipparcos Number", "HIP 93917"},
        {"Celescope Catalog", "CEL 4702"},
        {"Geneva Identification System", "GEN# +1.00178449"},
        {"Smithsonian Astrophysical Observation", "SAO 67835"},
        {"Wilson Evans Batten Catalogue", "WEB 16345"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.85623123),
        dec: Angle.Degrees(+32.50166027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201253"},
        {"Hipparcos Number", "HIP 104262"},
        {"Smithsonian Astrophysical Observation", "SAO 70940"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.83340991),
        dec: Angle.Degrees(+32.50224133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1997",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 341 AB"},
        {"Hipparcos Number", "HIP 1997"},
        {"Smithsonian Astrophysical Observation", "SAO 53878"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.32802915),
        dec: Angle.Degrees(+32.50352913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9243 A"},
        {"Henry Draper", "HD 126081"},
        {"Hipparcos Number", "HIP 70268"},
        {"Smithsonian Astrophysical Observation", "SAO 64105"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.65945142),
        dec: Angle.Degrees(+32.50356148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43478"},
        {"Hipparcos Number", "HIP 29911"},
        {"Geneva Identification System", "GEN# +1.00043478"},
        {"Renson", "Renson 11540"},
        {"Smithsonian Astrophysical Observation", "SAO 58954"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.46466340),
        dec: Angle.Degrees(+32.50460131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14027 A"},
        {"Henry Draper", "HD 196197"},
        {"Hipparcos Number", "HIP 101544"},
        {"Geneva Identification System", "GEN# +1.00196197A"},
        {"Smithsonian Astrophysical Observation", "SAO 70220"},
        {"Wilson Evans Batten Catalogue", "WEB 18349"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68581747),
        dec: Angle.Degrees(+32.50584340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113898"},
        {"Smithsonian Astrophysical Observation", "SAO 72970"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.99290800),
        dec: Angle.Degrees(+32.50605130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14027 B"},
        {"Hipparcos Number", "HIP 101539"},
        {"Geneva Identification System", "GEN# +1.00196197B"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.67816765),
        dec: Angle.Degrees(+32.50754113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112126"},
        {"Hipparcos Number", "HIP 62932"},
        {"Geneva Identification System", "GEN# +1.00112126"},
        {"Smithsonian Astrophysical Observation", "SAO 63240"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.45499945),
        dec: Angle.Degrees(+32.50776161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87367"},
        {"Smithsonian Astrophysical Observation", "SAO 66384"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.77871405),
        dec: Angle.Degrees(+32.50952119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50316"},
        {"Hipparcos Number", "HIP 33150"},
        {"Smithsonian Astrophysical Observation", "SAO 59594"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.53159718),
        dec: Angle.Degrees(+32.51139769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28405"},
        {"Hipparcos Number", "HIP 20988"},
        {"Geneva Identification System", "GEN# +1.00028405"},
        {"Smithsonian Astrophysical Observation", "SAO 57258"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.51547581),
        dec: Angle.Degrees(+32.51167497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113633"},
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.20206861),
        dec: Angle.Degrees(+32.51205239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3934 AB"},
        {"Henry Draper", "HD 34842"},
        {"Hipparcos Number", "HIP 25050"},
        {"Smithsonian Astrophysical Observation", "SAO 57941"},
    },
    visualMagnitude: 9.81,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21, 48.8800),
        dec: Angle.DegreesMinutesSeconds((int)+32, (int)30, 43.400)
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
    primaryId: "HIP 65947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117656"},
        {"Hipparcos Number", "HIP 65947"},
        {"Geneva Identification System", "GEN# +1.00117656"},
        {"Smithsonian Astrophysical Observation", "SAO 63580"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.79719462),
        dec: Angle.Degrees(+32.51454329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136403"},
        {"Hipparcos Number", "HIP 75000"},
        {"Geneva Identification System", "GEN# +1.00136403"},
        {"Renson", "Renson 38770"},
        {"Smithsonian Astrophysical Observation", "SAO 64630"},
        {"Wilson Evans Batten Catalogue", "WEB 12794"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.87530891),
        dec: Angle.Degrees(+32.51488753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73427"},
        {"Hipparcos Number", "HIP 42472"},
        {"Smithsonian Astrophysical Observation", "SAO 60963"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.88278937),
        dec: Angle.Degrees(+32.51565801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140716"},
        {"Hipparcos Number", "HIP 77048"},
        {"Fundamental Katalog 5th Edition", "FK5 3249"},
        {"Geneva Identification System", "GEN# +1.00140716"},
        {"Smithsonian Astrophysical Observation", "SAO 64870"},
        {"Wilson Evans Batten Catalogue", "WEB 13067"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.99716849),
        dec: Angle.Degrees(+32.51582804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10638"},
        {"Hipparcos Number", "HIP 8122"},
        {"Geneva Identification System", "GEN# +1.00010638"},
        {"Smithsonian Astrophysical Observation", "SAO 54945"},
        {"Wilson Evans Batten Catalogue", "WEB 1737"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.09486099),
        dec: Angle.Degrees(+32.51604103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154083"},
        {"Hipparcos Number", "HIP 83337"},
        {"Geneva Identification System", "GEN# +1.00154083"},
        {"Smithsonian Astrophysical Observation", "SAO 65741"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.47296094),
        dec: Angle.Degrees(+32.51654122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87632"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.51329177),
        dec: Angle.Degrees(+32.51693650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7033"},
        {"Hipparcos Number", "HIP 5543"},
        {"Geneva Identification System", "GEN# +1.00007033"},
        {"Smithsonian Astrophysical Observation", "SAO 54492"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.77716733),
        dec: Angle.Degrees(+32.51781516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10120"},
        {"Smithsonian Astrophysical Observation", "SAO 55319"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.53665709),
        dec: Angle.Degrees(+32.51885639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50411"},
        {"Geneva Identification System", "GEN# +9.80118049"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.40062757),
        dec: Angle.Degrees(+32.51979430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220856"},
        {"Hipparcos Number", "HIP 115749"},
        {"Geneva Identification System", "GEN# +1.00220856"},
        {"Smithsonian Astrophysical Observation", "SAO 73260"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.75518456),
        dec: Angle.Degrees(+32.52079646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5579"},
    },
    visualMagnitude: 10.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.89174195),
        dec: Angle.Degrees(+32.52195180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120650"},
        {"Hipparcos Number", "HIP 67504"},
        {"Geneva Identification System", "GEN# +1.00120650"},
        {"Smithsonian Astrophysical Observation", "SAO 63774"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.49442469),
        dec: Angle.Degrees(+32.52206097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195691"},
        {"Hipparcos Number", "HIP 101282"},
        {"Smithsonian Astrophysical Observation", "SAO 70155"},
        {"Wilson Evans Batten Catalogue", "WEB 18300"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.93842568),
        dec: Angle.Degrees(+32.52254962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132863"},
        {"Hipparcos Number", "HIP 73431"},
        {"Smithsonian Astrophysical Observation", "SAO 64458"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09393339),
        dec: Angle.Degrees(+32.52259213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35707"},
        {"Hipparcos Number", "HIP 25590"},
        {"Geneva Identification System", "GEN# +1.00035707"},
        {"Smithsonian Astrophysical Observation", "SAO 58072"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.03890195),
        dec: Angle.Degrees(+32.52771215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195610"},
        {"Hipparcos Number", "HIP 101240"},
        {"Geneva Identification System", "GEN# +1.00195610"},
        {"Smithsonian Astrophysical Observation", "SAO 70140"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.81441079),
        dec: Angle.Degrees(+32.52887590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216068"},
        {"Hipparcos Number", "HIP 112701"},
        {"Smithsonian Astrophysical Observation", "SAO 72757"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.34393845),
        dec: Angle.Degrees(+32.52956862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43439"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.70795956),
        dec: Angle.Degrees(+32.52960286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114988"},
        {"Hipparcos Number", "HIP 64543"},
        {"Geneva Identification System", "GEN# +1.00114988"},
        {"Smithsonian Astrophysical Observation", "SAO 63419"},
        {"Wilson Evans Batten Catalogue", "WEB 11415"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.43595895),
        dec: Angle.Degrees(+32.53048063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112445"},
        {"Hipparcos Number", "HIP 63144"},
        {"Geneva Identification System", "GEN# +1.00112445"},
        {"Smithsonian Astrophysical Observation", "SAO 63260"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.07463727),
        dec: Angle.Degrees(+32.53096749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96921"},
        {"Hipparcos Number", "HIP 54567"},
        {"Smithsonian Astrophysical Observation", "SAO 62432"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.48177824),
        dec: Angle.Degrees(+32.53112508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220460"},
        {"Hipparcos Number", "HIP 115500"},
        {"Geneva Identification System", "GEN# +1.00220460"},
        {"Smithsonian Astrophysical Observation", "SAO 73223"},
        {"Wilson Evans Batten Catalogue", "WEB 20447"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.94740769),
        dec: Angle.Degrees(+32.53121801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109845"},
        {"Hipparcos Number", "HIP 61623"},
        {"Geneva Identification System", "GEN# +1.00109845"},
        {"Smithsonian Astrophysical Observation", "SAO 63109"},
        {"Wilson Evans Batten Catalogue", "WEB 10964"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.44660438),
        dec: Angle.Degrees(+32.53251403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26526"},
        {"Hipparcos Number", "HIP 19679"},
        {"Smithsonian Astrophysical Observation", "SAO 57072"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.24353115),
        dec: Angle.Degrees(+32.53277052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46915"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.43825758),
        dec: Angle.Degrees(+32.53415323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128093"},
        {"Hipparcos Number", "HIP 71243"},
        {"Fundamental Katalog 5th Edition", "FK5 3153"},
        {"Geneva Identification System", "GEN# +1.00128093"},
        {"Smithsonian Astrophysical Observation", "SAO 64221"},
        {"Wilson Evans Batten Catalogue", "WEB 12311"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.54847412),
        dec: Angle.Degrees(+32.53446287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84914"},
        {"Smithsonian Astrophysical Observation", "SAO 65970"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.29850302),
        dec: Angle.Degrees(+32.53599842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118316"},
        {"Smithsonian Astrophysical Observation", "SAO 73661"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.96089863),
        dec: Angle.Degrees(+32.53693255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129004"},
        {"Hipparcos Number", "HIP 71644"},
        {"Geneva Identification System", "GEN# +1.00129004"},
        {"Smithsonian Astrophysical Observation", "SAO 64256"},
        {"Wilson Evans Batten Catalogue", "WEB 12349"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81604777),
        dec: Angle.Degrees(+32.53952706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78234"},
        {"Hipparcos Number", "HIP 44825"},
        {"Geneva Identification System", "GEN# +1.00078234"},
        {"Smithsonian Astrophysical Observation", "SAO 61276"},
        {"Wilson Evans Batten Catalogue", "WEB 8568"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.01754785),
        dec: Angle.Degrees(+32.54045613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9305"},
        {"Hipparcos Number", "HIP 7153"},
        {"Geneva Identification System", "GEN# +1.00009305"},
        {"Smithsonian Astrophysical Observation", "SAO 54766"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.05388072),
        dec: Angle.Degrees(+32.54216432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116304"},
        {"Hipparcos Number", "HIP 65251"},
        {"Smithsonian Astrophysical Observation", "SAO 63500"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.58651386),
        dec: Angle.Degrees(+32.54506357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214201"},
        {"Hipparcos Number", "HIP 111568"},
        {"Fundamental Katalog 5th Edition", "FK5 5994"},
        {"Smithsonian Astrophysical Observation", "SAO 72515"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.03299894),
        dec: Angle.Degrees(+32.54582803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66117"},
        {"Smithsonian Astrophysical Observation", "SAO 63603"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.30485867),
        dec: Angle.Degrees(+32.54631980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117059"},
    },
    visualMagnitude: 13.11,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.96196546),
        dec: Angle.Degrees(+32.54646133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13211"},
        {"Hipparcos Number", "HIP 10101"},
        {"Smithsonian Astrophysical Observation", "SAO 55314"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.47792286),
        dec: Angle.Degrees(+32.54941458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11737 A"},
        {"Henry Draper", "HD 174602"},
        {"Hipparcos Number", "HIP 92405"},
        {"Celescope Catalog", "CEL 4656"},
        {"Geneva Identification System", "GEN# +1.00174602"},
        {"Smithsonian Astrophysical Observation", "SAO 67446"},
        {"Wilson Evans Batten Catalogue", "WEB 15963"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.47052043),
        dec: Angle.Degrees(+32.55108873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144043"},
        {"Hipparcos Number", "HIP 78576"},
        {"Geneva Identification System", "GEN# +1.00144043"},
        {"Smithsonian Astrophysical Observation", "SAO 65040"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.67709996),
        dec: Angle.Degrees(+32.55267357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152224"},
        {"Hipparcos Number", "HIP 82426"},
        {"Geneva Identification System", "GEN# +1.00152224"},
        {"Smithsonian Astrophysical Observation", "SAO 65595"},
        {"Wilson Evans Batten Catalogue", "WEB 13916"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.67972265),
        dec: Angle.Degrees(+32.55355943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263175"},
        {"Hipparcos Number", "HIP 32423"},
        {"Cincinnati Publication", "Ci 18 829"},
        {"Cincinnati Publication 2", "Ci 20 395"},
        {"Geneva Identification System", "GEN# +1.00263175"},
        {"Smithsonian Astrophysical Observation", "SAO 59465"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.52236005),
        dec: Angle.Degrees(+32.55543654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -454.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57205"},
        {"Wilson Evans Batten Catalogue", "WEB 10290"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.95105387),
        dec: Angle.Degrees(+32.55560918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62815"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.07289604),
        dec: Angle.Degrees(+32.55590960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278884"},
        {"Hipparcos Number", "HIP 17052"},
        {"Smithsonian Astrophysical Observation", "SAO 56606"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.84553924),
        dec: Angle.Degrees(+32.55681438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18014",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2804 AB"},
        {"Henry Draper", "HD 24038"},
        {"Hipparcos Number", "HIP 18014"},
        {"Geneva Identification System", "GEN# +1.00024038J"},
        {"Smithsonian Astrophysical Observation", "SAO 56744"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.75601105),
        dec: Angle.Degrees(+32.55843585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48006"},
        {"Hipparcos Number", "HIP 32143"},
        {"Fundamental Katalog 5th Edition", "FK5 4610"},
        {"Geneva Identification System", "GEN# +1.00048006"},
        {"Smithsonian Astrophysical Observation", "SAO 59397"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.68764428),
        dec: Angle.Degrees(+32.55888351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16928 AB"},
        {"Henry Draper", "HD 222529"},
        {"Hipparcos Number", "HIP 116863"},
        {"Smithsonian Astrophysical Observation", "SAO 73436"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32316186),
        dec: Angle.Degrees(+32.56109197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83519"},
        {"Smithsonian Astrophysical Observation", "SAO 65771"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.03442625),
        dec: Angle.Degrees(+32.56114562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198769"},
        {"Hipparcos Number", "HIP 102958"},
        {"Smithsonian Astrophysical Observation", "SAO 70587"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.89981564),
        dec: Angle.Degrees(+32.56207783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185660"},
        {"Hipparcos Number", "HIP 96648"},
        {"Smithsonian Astrophysical Observation", "SAO 68626"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.74149697),
        dec: Angle.Degrees(+32.56209160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45192"},
        {"Hipparcos Number", "HIP 30741"},
        {"Geneva Identification System", "GEN# +1.00045192"},
        {"Smithsonian Astrophysical Observation", "SAO 59096"},
        {"Wilson Evans Batten Catalogue", "WEB 6130"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.89798668),
        dec: Angle.Degrees(+32.56311006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195665"},
        {"Hipparcos Number", "HIP 101270"},
        {"Smithsonian Astrophysical Observation", "SAO 70151"},
        {"Wilson Evans Batten Catalogue", "WEB 18296"},
    },
    visualMagnitude: 8.61,
    bvColour: 2.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.90215277),
        dec: Angle.Degrees(+32.56456064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156296"},
        {"Hipparcos Number", "HIP 84408"},
        {"Smithsonian Astrophysical Observation", "SAO 65895"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.84290738),
        dec: Angle.Degrees(+32.56676520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111180"},
        {"Hipparcos Number", "HIP 62386"},
        {"Geneva Identification System", "GEN# +1.00111180"},
        {"Smithsonian Astrophysical Observation", "SAO 63190"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.78213551),
        dec: Angle.Degrees(+32.56778530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27784"},
        {"Geneva Identification System", "GEN# +2.20990485"},
        {"New General Catalogue", "NGC 2099 485"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.19394136),
        dec: Angle.Degrees(+32.56869195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25539"},
        {"Hipparcos Number", "HIP 19039"},
        {"Geneva Identification System", "GEN# +1.00025539"},
        {"Smithsonian Astrophysical Observation", "SAO 56951"},
        {"Wilson Evans Batten Catalogue", "WEB 3660"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.17943823),
        dec: Angle.Degrees(+32.57122919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213323"},
        {"Hipparcos Number", "HIP 111068"},
        {"Fundamental Katalog 5th Edition", "FK5 1590"},
        {"Geneva Identification System", "GEN# +1.00213323"},
        {"Smithsonian Astrophysical Observation", "SAO 72406"},
        {"Wilson Evans Batten Catalogue", "WEB 19885"},
    },
    visualMagnitude: 5.64,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.50746956),
        dec: Angle.Degrees(+32.57267245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79965"},
    },
    visualMagnitude: 11.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.82986935),
        dec: Angle.Degrees(+32.57292900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46552"},
        {"Hipparcos Number", "HIP 31485"},
        {"Geneva Identification System", "GEN# +1.00046552"},
        {"Smithsonian Astrophysical Observation", "SAO 59265"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.90687933),
        dec: Angle.Degrees(+32.57681720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184471"},
        {"Hipparcos Number", "HIP 96177"},
        {"Geneva Identification System", "GEN# +1.00184471"},
        {"Renson", "Renson 50890"},
        {"Smithsonian Astrophysical Observation", "SAO 68486"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.33510197),
        dec: Angle.Degrees(+32.57701655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190256"},
        {"Hipparcos Number", "HIP 98706"},
        {"Geneva Identification System", "GEN# +1.00190256"},
        {"Smithsonian Astrophysical Observation", "SAO 69308"},
        {"Wilson Evans Batten Catalogue", "WEB 17482"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.71823296),
        dec: Angle.Degrees(+32.57741885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165461"},
        {"Hipparcos Number", "HIP 88526"},
        {"Smithsonian Astrophysical Observation", "SAO 66608"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.16432411),
        dec: Angle.Degrees(+32.57825090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34761"},
        {"Hipparcos Number", "HIP 25000"},
        {"Celescope Catalog", "CEL 631"},
        {"Geneva Identification System", "GEN# +1.00034761"},
        {"Smithsonian Astrophysical Observation", "SAO 57929"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30206652),
        dec: Angle.Degrees(+32.57949579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29037"},
        {"Hipparcos Number", "HIP 21397"},
        {"Geneva Identification System", "GEN# +1.00029037"},
        {"Smithsonian Astrophysical Observation", "SAO 57328"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.89761765),
        dec: Angle.Degrees(+32.57986012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107430"},
        {"Smithsonian Astrophysical Observation", "SAO 71672"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37809872),
        dec: Angle.Degrees(+32.58124266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139421"},
        {"Hipparcos Number", "HIP 76460"},
        {"Smithsonian Astrophysical Observation", "SAO 64810"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.22983724),
        dec: Angle.Degrees(+32.58182702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8911 AB"},
        {"Henry Draper", "HD 117157"},
        {"Hipparcos Number", "HIP 65676"},
        {"Geneva Identification System", "GEN# +1.00117157J"},
        {"Smithsonian Astrophysical Observation", "SAO 63555"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.99705716),
        dec: Angle.Degrees(+32.58191690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122503"},
        {"Hipparcos Number", "HIP 68512"},
        {"Geneva Identification System", "GEN# +1.00122503"},
        {"Smithsonian Astrophysical Observation", "SAO 63891"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.38772151),
        dec: Angle.Degrees(+32.58272473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51352"},
        {"Hipparcos Number", "HIP 33557"},
        {"Smithsonian Astrophysical Observation", "SAO 59652"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.60444117),
        dec: Angle.Degrees(+32.58287458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65566"},
        {"Smithsonian Astrophysical Observation", "SAO 63541"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.64654845),
        dec: Angle.Degrees(+32.58436168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48920"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.68867212),
        dec: Angle.Degrees(+32.58543914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99168",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13410 A"},
        {"Henry Draper", "HD 191292"},
        {"Hipparcos Number", "HIP 99168"},
        {"Geneva Identification System", "GEN# +4.28050008"},
        {"Geneva Identification System 2", "GEN# +1.00191292"},
        {"Smithsonian Astrophysical Observation", "SAO 69467"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.99138913),
        dec: Angle.Degrees(+32.58634543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30453"},
        {"Hipparcos Number", "HIP 22407"},
        {"Geneva Identification System", "GEN# +1.00030453"},
        {"Renson", "Renson 7860"},
        {"Smithsonian Astrophysical Observation", "SAO 57444"},
        {"Wilson Evans Batten Catalogue", "WEB 4319"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.32941395),
        dec: Angle.Degrees(+32.58826794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63379"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.80130734),
        dec: Angle.Degrees(+32.58838419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57926"},
        {"Hipparcos Number", "HIP 35962"},
        {"Smithsonian Astrophysical Observation", "SAO 60057"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.19924614),
        dec: Angle.Degrees(+32.58916476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55862"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.74500451),
        dec: Angle.Degrees(+32.58989312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40787"},
        {"Hipparcos Number", "HIP 28626"},
        {"Geneva Identification System", "GEN# +1.00040787"},
        {"Smithsonian Astrophysical Observation", "SAO 58683"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.65672697),
        dec: Angle.Degrees(+32.59139240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81975"},
        {"Smithsonian Astrophysical Observation", "SAO 65518"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.18614250),
        dec: Angle.Degrees(+32.59189914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138512"},
        {"Hipparcos Number", "HIP 76010"},
        {"Smithsonian Astrophysical Observation", "SAO 64752"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.85862046),
        dec: Angle.Degrees(+32.59235273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38532"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.35662891),
        dec: Angle.Degrees(+32.59543654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93135"},
        {"Hipparcos Number", "HIP 52632"},
        {"Geneva Identification System", "GEN# +1.00093135"},
        {"Smithsonian Astrophysical Observation", "SAO 62234"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.44419607),
        dec: Angle.Degrees(+32.59733544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83656"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.47033461),
        dec: Angle.Degrees(+32.59919818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146025"},
        {"Hipparcos Number", "HIP 79452"},
        {"Smithsonian Astrophysical Observation", "SAO 65147"},
        {"Wilson Evans Batten Catalogue", "WEB 13435"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21249967),
        dec: Angle.Degrees(+32.59920748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121934"},
        {"Hipparcos Number", "HIP 68216"},
        {"Geneva Identification System", "GEN# +1.00121934"},
        {"Smithsonian Astrophysical Observation", "SAO 63857"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.48729450),
        dec: Angle.Degrees(+32.60088521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175700"},
        {"Hipparcos Number", "HIP 92849"},
        {"Geneva Identification System", "GEN# +1.00175700"},
        {"Smithsonian Astrophysical Observation", "SAO 67571"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.80688174),
        dec: Angle.Degrees(+32.60459305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64869"},
        {"Smithsonian Astrophysical Observation", "SAO 63455"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.44518322),
        dec: Angle.Degrees(+32.60460015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117386"},
        {"Smithsonian Astrophysical Observation", "SAO 73515"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.01829041),
        dec: Angle.Degrees(+32.60654324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49380"},
        {"Hipparcos Number", "HIP 32740"},
        {"Fundamental Katalog 5th Edition", "FK5 2525"},
        {"Geneva Identification System", "GEN# +1.00049380"},
        {"Smithsonian Astrophysical Observation", "SAO 59521"},
        {"Wilson Evans Batten Catalogue", "WEB 6592"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.42224358),
        dec: Angle.Degrees(+32.60687904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76525"},
        {"Smithsonian Astrophysical Observation", "SAO 64815"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.43200866),
        dec: Angle.Degrees(+32.60837971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82579"},
        {"Smithsonian Astrophysical Observation", "SAO 65625"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.22713729),
        dec: Angle.Degrees(+32.60891449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41269"},
        {"Cincinnati Publication", "Ci 20 473"},
        {"Geneva Identification System", "GEN# +0.03301694"},
        {"Wilson Evans Batten Catalogue", "WEB 7986"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.29753139),
        dec: Angle.Degrees(+32.61078024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -674.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3925"},
        {"Hipparcos Number", "HIP 3301"},
        {"Smithsonian Astrophysical Observation", "SAO 54088"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.51969138),
        dec: Angle.Degrees(+32.61104337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60346"},
        {"Cincinnati Publication", "Ci 18 1554"},
        {"Geneva Identification System", "GEN# +0.03302227"},
        {"Smithsonian Astrophysical Observation", "SAO 62973"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.59873469),
        dec: Angle.Degrees(+32.61265772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203439"},
        {"Hipparcos Number", "HIP 105432"},
        {"Geneva Identification System", "GEN# +1.00203439"},
        {"Smithsonian Astrophysical Observation", "SAO 71237"},
        {"Wilson Evans Batten Catalogue", "WEB 19150"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34136809),
        dec: Angle.Degrees(+32.61276805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217600"},
        {"Hipparcos Number", "HIP 113687"},
        {"Smithsonian Astrophysical Observation", "SAO 72935"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.38646534),
        dec: Angle.Degrees(+32.61299304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97288"},
        {"Hipparcos Number", "HIP 54713"},
        {"Smithsonian Astrophysical Observation", "SAO 62445"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.03750316),
        dec: Angle.Degrees(+32.61479840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54718"},
        {"Hipparcos Number", "HIP 34700"},
        {"Geneva Identification System", "GEN# +1.00054718"},
        {"Smithsonian Astrophysical Observation", "SAO 59860"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.81165550),
        dec: Angle.Degrees(+32.61503306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186047"},
        {"Hipparcos Number", "HIP 96836"},
        {"Smithsonian Astrophysical Observation", "SAO 68688"},
        {"Wilson Evans Batten Catalogue", "WEB 16995"},
    },
    visualMagnitude: 7.63,
    bvColour: 2.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.23757991),
        dec: Angle.Degrees(+32.61827060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138278"},
        {"Hipparcos Number", "HIP 75881"},
        {"Geneva Identification System", "GEN# +1.00138278"},
        {"Smithsonian Astrophysical Observation", "SAO 64731"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.49016949),
        dec: Angle.Degrees(+32.61871709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54562"},
        {"Hipparcos Number", "HIP 34663"},
        {"Smithsonian Astrophysical Observation", "SAO 59846"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.68016891),
        dec: Angle.Degrees(+32.61874422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92940"},
        {"Hipparcos Number", "HIP 52530"},
        {"Geneva Identification System", "GEN# +1.00092940"},
        {"Smithsonian Astrophysical Observation", "SAO 62224"},
        {"Wilson Evans Batten Catalogue", "WEB 9567"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.10564486),
        dec: Angle.Degrees(+32.61985044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257282"},
        {"Hipparcos Number", "HIP 30751"},
        {"Smithsonian Astrophysical Observation", "SAO 59098"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91941891),
        dec: Angle.Degrees(+32.62070354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281563"},
        {"Hipparcos Number", "HIP 19013"},
        {"Geneva Identification System", "GEN# +1.00281563"},
        {"Renson", "Renson 6510"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.10014950),
        dec: Angle.Degrees(+32.62135109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211446"},
        {"Hipparcos Number", "HIP 109979"},
        {"Fundamental Katalog 5th Edition", "FK5 5965"},
        {"Smithsonian Astrophysical Observation", "SAO 72195"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.12666458),
        dec: Angle.Degrees(+32.62156135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331246"},
        {"Hipparcos Number", "HIP 97506"},
        {"Celescope Catalog", "CEL 4852"},
        {"Smithsonian Astrophysical Observation", "SAO 68904"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.27232959),
        dec: Angle.Degrees(+32.62160908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91374"},
        {"Smithsonian Astrophysical Observation", "SAO 67188"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.52703360),
        dec: Angle.Degrees(+32.62430296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35132"},
        {"Hipparcos Number", "HIP 25252"},
        {"Celescope Catalog", "CEL 668"},
        {"Geneva Identification System", "GEN# +1.00035132J"},
        {"Smithsonian Astrophysical Observation", "SAO 57976"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.00321610),
        dec: Angle.Degrees(+32.62556585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59924"},
        {"Hipparcos Number", "HIP 36753"},
        {"Smithsonian Astrophysical Observation", "SAO 60181"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.38864275),
        dec: Angle.Degrees(+32.62626213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147851"},
        {"Hipparcos Number", "HIP 80254"},
        {"Smithsonian Astrophysical Observation", "SAO 65265"},
        {"Wilson Evans Batten Catalogue", "WEB 13582"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.75812892),
        dec: Angle.Degrees(+32.62653144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147162"},
        {"Hipparcos Number", "HIP 79937"},
        {"Smithsonian Astrophysical Observation", "SAO 65222"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.73494587),
        dec: Angle.Degrees(+32.62703771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94087"},
        {"Hipparcos Number", "HIP 53125"},
        {"Smithsonian Astrophysical Observation", "SAO 62289"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01730443),
        dec: Angle.Degrees(+32.62867079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180287"},
        {"Hipparcos Number", "HIP 94551"},
        {"Smithsonian Astrophysical Observation", "SAO 68025"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.65635180),
        dec: Angle.Degrees(+32.62879964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3649"},
        {"Hipparcos Number", "HIP 3102"},
        {"Smithsonian Astrophysical Observation", "SAO 54060"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.87351560),
        dec: Angle.Degrees(+32.62993201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159856"},
        {"Hipparcos Number", "HIP 86077"},
        {"Smithsonian Astrophysical Observation", "SAO 66161"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.87196438),
        dec: Angle.Degrees(+32.63109186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282407"},
        {"Hipparcos Number", "HIP 22217"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.66514342),
        dec: Angle.Degrees(+32.63183417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40832"},
        {"Hipparcos Number", "HIP 28644"},
        {"Geneva Identification System", "GEN# +1.00040832"},
        {"Smithsonian Astrophysical Observation", "SAO 58688"},
        {"Wilson Evans Batten Catalogue", "WEB 5599"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.72965494),
        dec: Angle.Degrees(+32.63621103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47773"},
        {"Hipparcos Number", "HIP 32051"},
        {"Geneva Identification System", "GEN# +1.00047773"},
        {"Smithsonian Astrophysical Observation", "SAO 59371"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.44961997),
        dec: Angle.Degrees(+32.63695586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183300"},
        {"Hipparcos Number", "HIP 95663"},
        {"Smithsonian Astrophysical Observation", "SAO 68339"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.88858941),
        dec: Angle.Degrees(+32.63909690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8184"},
        {"Hipparcos Number", "HIP 6362"},
        {"Smithsonian Astrophysical Observation", "SAO 54627"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.43274500),
        dec: Angle.Degrees(+32.63963393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187688"},
        {"Hipparcos Number", "HIP 97584"},
        {"Celescope Catalog", "CEL 4856"},
        {"Geneva Identification System", "GEN# +1.00187688"},
        {"Smithsonian Astrophysical Observation", "SAO 68922"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.51718244),
        dec: Angle.Degrees(+32.64022503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170931"},
        {"Hipparcos Number", "HIP 90716"},
        {"Geneva Identification System", "GEN# +1.00170931"},
        {"Smithsonian Astrophysical Observation", "SAO 67044"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.63159305),
        dec: Angle.Degrees(+32.64177223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251521"},
        {"Hipparcos Number", "HIP 28974"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.71823946),
        dec: Angle.Degrees(+32.64317036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175717"},
        {"Hipparcos Number", "HIP 92860"},
        {"Geneva Identification System", "GEN# +1.00175717"},
        {"Smithsonian Astrophysical Observation", "SAO 67575"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.83306874),
        dec: Angle.Degrees(+32.64339252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108200"},
        {"Cincinnati Publication", "Ci 20 1321"},
        {"Geneva Identification System", "GEN# +9.80188030"},
        {"Wilson Evans Batten Catalogue", "WEB 19501"},
    },
    visualMagnitude: 11.07,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.81507983),
        dec: Angle.Degrees(+32.64446162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 762.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49315",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7624 AB"},
        {"Henry Draper", "HD 87158"},
        {"Hipparcos Number", "HIP 49315"},
        {"Smithsonian Astrophysical Observation", "SAO 61840"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.99628328),
        dec: Angle.Degrees(+32.64686402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95357"},
        {"Smithsonian Astrophysical Observation", "SAO 68250"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.99594620),
        dec: Angle.Degrees(+32.64794955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164078"},
        {"Hipparcos Number", "HIP 87958"},
        {"Geneva Identification System", "GEN# +1.00164078"},
        {"Smithsonian Astrophysical Observation", "SAO 66518"},
        {"Wilson Evans Batten Catalogue", "WEB 14852"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52094692),
        dec: Angle.Degrees(+32.64813081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45946"},
        {"Smithsonian Astrophysical Observation", "SAO 61428"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.54912645),
        dec: Angle.Degrees(+32.65047186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106558"},
        {"Hipparcos Number", "HIP 59765"},
        {"Geneva Identification System", "GEN# +1.00106558"},
        {"Smithsonian Astrophysical Observation", "SAO 62917"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.83585098),
        dec: Angle.Degrees(+32.65095241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67087"},
        {"Wilson Evans Batten Catalogue", "WEB 11816"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.26272177),
        dec: Angle.Degrees(+32.65464176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145911"},
        {"Hipparcos Number", "HIP 79401"},
        {"Smithsonian Astrophysical Observation", "SAO 65140"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.07319043),
        dec: Angle.Degrees(+32.65527992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87123"},
        {"Smithsonian Astrophysical Observation", "SAO 66339"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.00456127),
        dec: Angle.Degrees(+32.65579975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64934"},
        {"Hipparcos Number", "HIP 38891"},
        {"Geneva Identification System", "GEN# +1.00064934"},
        {"Smithsonian Astrophysical Observation", "SAO 60474"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.38604236),
        dec: Angle.Degrees(+32.65674587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4903"},
        {"Hipparcos Number", "HIP 4005"},
        {"Geneva Identification System", "GEN# +1.00004903"},
        {"Smithsonian Astrophysical Observation", "SAO 54203"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.85403677),
        dec: Angle.Degrees(+32.65728762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207756"},
        {"Hipparcos Number", "HIP 107813"},
        {"Smithsonian Astrophysical Observation", "SAO 71754"},
        {"Wilson Evans Batten Catalogue", "WEB 19442"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.62842561),
        dec: Angle.Degrees(+32.65771450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15377 A"},
        {"Henry Draper", "HD 207805"},
        {"Hipparcos Number", "HIP 107844"},
        {"Smithsonian Astrophysical Observation", "SAO 71763"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.72754557),
        dec: Angle.Degrees(+32.65859831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20099"},
        {"Hipparcos Number", "HIP 15102"},
        {"Geneva Identification System", "GEN# +1.00020099"},
        {"Smithsonian Astrophysical Observation", "SAO 56279"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.70151681),
        dec: Angle.Degrees(+32.65896365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10459 AB"},
        {"Aitken 2", "ADS 10459"},
        {"Hipparcos Number", "HIP 84653"},
        {"Smithsonian Astrophysical Observation", "SAO 65929"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.59265386),
        dec: Angle.Degrees(+32.66080936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19281"},
        {"Hipparcos Number", "HIP 14491"},
        {"Smithsonian Astrophysical Observation", "SAO 56169"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.78198963),
        dec: Angle.Degrees(+32.66219896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37633"},
        {"Smithsonian Astrophysical Observation", "SAO 60298"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.83712236),
        dec: Angle.Degrees(+32.66538684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221132"},
        {"Hipparcos Number", "HIP 115927"},
        {"Geneva Identification System", "GEN# +1.00221132"},
        {"Smithsonian Astrophysical Observation", "SAO 73288"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.30949836),
        dec: Angle.Degrees(+32.66566155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218965"},
        {"Hipparcos Number", "HIP 114533"},
        {"Smithsonian Astrophysical Observation", "SAO 73075"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.98056656),
        dec: Angle.Degrees(+32.66600290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15406"},
    },
    visualMagnitude: 11.33,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.65908041),
        dec: Angle.Degrees(+32.66603415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63970"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.63590470),
        dec: Angle.Degrees(+32.66691725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73173"},
        {"Hipparcos Number", "HIP 42359"},
        {"Smithsonian Astrophysical Observation", "SAO 60936"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.54718102),
        dec: Angle.Degrees(+32.66992426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157911"},
        {"Hipparcos Number", "HIP 85204"},
        {"Smithsonian Astrophysical Observation", "SAO 66018"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.16365071),
        dec: Angle.Degrees(+32.67034216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107840",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15377 C"},
        {"Henry Draper", "HD 207804"},
        {"Hipparcos Number", "HIP 107840"},
        {"Smithsonian Astrophysical Observation", "SAO 71762"},
        {"Wilson Evans Batten Catalogue", "WEB 19446"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.71568949),
        dec: Angle.Degrees(+32.67145624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208312"},
        {"Hipparcos Number", "HIP 108160"},
        {"Smithsonian Astrophysical Observation", "SAO 71825"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.69034156),
        dec: Angle.Degrees(+32.67328996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157255"},
        {"Hipparcos Number", "HIP 84871"},
        {"Geneva Identification System", "GEN# +1.00157255"},
        {"Smithsonian Astrophysical Observation", "SAO 65965"},
        {"Wilson Evans Batten Catalogue", "WEB 14332"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.18943563),
        dec: Angle.Degrees(+32.67438151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159183"},
        {"Hipparcos Number", "HIP 85800"},
        {"Smithsonian Astrophysical Observation", "SAO 66113"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.98328260),
        dec: Angle.Degrees(+32.67489245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108373",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15487 AB"},
        {"Henry Draper", "HD 208687"},
        {"Hipparcos Number", "HIP 108373"},
        {"Smithsonian Astrophysical Observation", "SAO 71873"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.32374518),
        dec: Angle.Degrees(+32.67566719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37251"},
        {"Hipparcos Number", "HIP 26538"},
        {"Geneva Identification System", "GEN# +1.00037251"},
        {"Smithsonian Astrophysical Observation", "SAO 58279"},
        {"Wilson Evans Batten Catalogue", "WEB 5228"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.66087638),
        dec: Angle.Degrees(+32.67572947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182031"},
        {"Hipparcos Number", "HIP 95146"},
        {"Smithsonian Astrophysical Observation", "SAO 68189"},
        {"Wilson Evans Batten Catalogue", "WEB 16615"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.36210419),
        dec: Angle.Degrees(+32.67779099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55406"},
        {"Hipparcos Number", "HIP 34977"},
        {"Smithsonian Astrophysical Observation", "SAO 59906"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.55558006),
        dec: Angle.Degrees(+32.67796997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82751"},
        {"Smithsonian Astrophysical Observation", "SAO 65648"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.70212156),
        dec: Angle.Degrees(+32.68086230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89100"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.77633161),
        dec: Angle.Degrees(+32.68265589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 321.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93400"},
        {"Smithsonian Astrophysical Observation", "SAO 67711"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.33888911),
        dec: Angle.Degrees(+32.68451808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24502",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3824 C"},
        {"Henry Draper", "HD 33959C"},
        {"Hipparcos Number", "HIP 24502"},
        {"Geneva Identification System", "GEN# +1.30033959"},
        {"Geneva Identification System 2", "GEN# +1.00033959C"},
        {"Smithsonian Astrophysical Observation", "SAO 57798"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.84839010),
        dec: Angle.Degrees(+32.68475457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91987"},
        {"Hipparcos Number", "HIP 52027"},
        {"Geneva Identification System", "GEN# +1.00091987"},
        {"Smithsonian Astrophysical Observation", "SAO 62164"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.44931596),
        dec: Angle.Degrees(+32.68738062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3824 A"},
        {"Henry Draper", "HD 33959A"},
        {"Henry Draper 2", "HD 33959"},
        {"Hipparcos Number", "HIP 24504"},
        {"Celescope Catalog", "CEL 580"},
        {"Geneva Identification System", "GEN# +1.00033959J"},
        {"Renson", "Renson 8660"},
        {"Smithsonian Astrophysical Observation", "SAO 57799"},
        {"Wilson Evans Batten Catalogue", "WEB 4746"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.85171534),
        dec: Angle.Degrees(+32.68756990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14753"},
        {"Hipparcos Number", "HIP 11148"},
        {"Geneva Identification System", "GEN# +1.00014753"},
        {"Smithsonian Astrophysical Observation", "SAO 55506"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.85974145),
        dec: Angle.Degrees(+32.68816609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38080"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.05962761),
        dec: Angle.Degrees(+32.68856966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199317"},
        {"Hipparcos Number", "HIP 103278"},
        {"Smithsonian Astrophysical Observation", "SAO 70668"},
        {"Wilson Evans Batten Catalogue", "WEB 18769"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.84913490),
        dec: Angle.Degrees(+32.68911817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11007"},
        {"Hipparcos Number", "HIP 8433"},
        {"Fundamental Katalog 5th Edition", "FK5 2120"},
        {"Geneva Identification System", "GEN# +1.00011007"},
        {"Smithsonian Astrophysical Observation", "SAO 54994"},
        {"Wilson Evans Batten Catalogue", "WEB 1797"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.17366149),
        dec: Angle.Degrees(+32.68948705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 297.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93194",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sulafat"},
        {"Aitken", "ADS 11908 A"},
        {"Henry Draper", "HD 176437"},
        {"Hipparcos Number", "HIP 93194"},
        {"Celescope Catalog", "CEL 4678"},
        {"Fundamental Katalog 5th Edition", "FK5 713"},
        {"Geneva Identification System", "GEN# +1.00176437"},
        {"Renson", "Renson 49230"},
        {"Smithsonian Astrophysical Observation", "SAO 67663"},
        {"Wilson Evans Batten Catalogue", "WEB 16153"},
    },
    visualMagnitude: 3.25,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.73593568),
        dec: Angle.Degrees(+32.68955312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131495"},
        {"Hipparcos Number", "HIP 72807"},
        {"Geneva Identification System", "GEN# +1.00131495"},
        {"Smithsonian Astrophysical Observation", "SAO 64377"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22266243),
        dec: Angle.Degrees(+32.69089637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71537"},
        {"Hipparcos Number", "HIP 41629"},
        {"Fundamental Katalog 5th Edition", "FK5 2663"},
        {"Geneva Identification System", "GEN# +1.00071537"},
        {"Smithsonian Astrophysical Observation", "SAO 60846"},
        {"Wilson Evans Batten Catalogue", "WEB 8034"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.30310234),
        dec: Angle.Degrees(+32.69231326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151058"},
        {"Hipparcos Number", "HIP 81889"},
        {"Smithsonian Astrophysical Observation", "SAO 65510"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91052051),
        dec: Angle.Degrees(+32.69234954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42471"},
        {"Hipparcos Number", "HIP 29451"},
        {"Fundamental Katalog 5th Edition", "FK5 2470"},
        {"Geneva Identification System", "GEN# +1.00042471"},
        {"Smithsonian Astrophysical Observation", "SAO 58852"},
        {"Wilson Evans Batten Catalogue", "WEB 5789"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.08387494),
        dec: Angle.Degrees(+32.69338941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217650"},
        {"Hipparcos Number", "HIP 113728"},
        {"Geneva Identification System", "GEN# +1.00217650"},
        {"Smithsonian Astrophysical Observation", "SAO 72942"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.48678115),
        dec: Angle.Degrees(+32.69345915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89411"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68797965),
        dec: Angle.Degrees(+32.69373034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38447"},
        {"Smithsonian Astrophysical Observation", "SAO 60402"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.14970434),
        dec: Angle.Degrees(+32.69903486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148616"},
        {"Hipparcos Number", "HIP 80648"},
        {"Smithsonian Astrophysical Observation", "SAO 65320"},
        {"Wilson Evans Batten Catalogue", "WEB 13640"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99047421),
        dec: Angle.Degrees(+32.69947648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46660"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.69803012),
        dec: Angle.Degrees(+32.70092592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74547"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.48769088),
        dec: Angle.Degrees(+32.70251713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103232",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14421 AB"},
        {"Henry Draper", "HD 199220"},
        {"Hipparcos Number", "HIP 103232"},
        {"Smithsonian Astrophysical Observation", "SAO 70660"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.70762672),
        dec: Angle.Degrees(+32.70630194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59225"},
        {"Hipparcos Number", "HIP 36476"},
        {"Smithsonian Astrophysical Observation", "SAO 60137"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.57965503),
        dec: Angle.Degrees(+32.70758902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254339"},
        {"Hipparcos Number", "HIP 29874"},
        {"Smithsonian Astrophysical Observation", "SAO 58943"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.35326172),
        dec: Angle.Degrees(+32.70763129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35237"},
        {"Hipparcos Number", "HIP 25304"},
        {"Smithsonian Astrophysical Observation", "SAO 57990"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.19448047),
        dec: Angle.Degrees(+32.70773769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85592",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10591 A"},
        {"Henry Draper", "HD 158734"},
        {"Hipparcos Number", "HIP 85592"},
        {"Smithsonian Astrophysical Observation", "SAO 66083"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36186935),
        dec: Angle.Degrees(+32.70935197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281367"},
        {"Hipparcos Number", "HIP 18627"},
        {"Geneva Identification System", "GEN# +1.00281367"},
        {"Renson", "Renson 6370"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.80406812),
        dec: Angle.Degrees(+32.71286129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85593",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10591 B"},
        {"Hipparcos Number", "HIP 85593"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.36250825),
        dec: Angle.Degrees(+32.71302649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186859"},
        {"Hipparcos Number", "HIP 97234"},
        {"Smithsonian Astrophysical Observation", "SAO 68804"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.42373953),
        dec: Angle.Degrees(+32.71382005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201805"},
        {"Hipparcos Number", "HIP 104576"},
        {"Smithsonian Astrophysical Observation", "SAO 71028"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.76123972),
        dec: Angle.Degrees(+32.71821373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182567"},
        {"Hipparcos Number", "HIP 95354"},
        {"Smithsonian Astrophysical Observation", "SAO 68248"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.99148124),
        dec: Angle.Degrees(+32.72367649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170736"},
        {"Hipparcos Number", "HIP 90636"},
        {"Smithsonian Astrophysical Observation", "SAO 67022"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39838992),
        dec: Angle.Degrees(+32.72498256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101769"},
        {"Hipparcos Number", "HIP 57128"},
        {"Smithsonian Astrophysical Observation", "SAO 62666"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.69384864),
        dec: Angle.Degrees(+32.72596752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73508"},
        {"Hipparcos Number", "HIP 42503"},
        {"Smithsonian Astrophysical Observation", "SAO 60968"},
        {"Wilson Evans Batten Catalogue", "WEB 8181"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.98488098),
        dec: Angle.Degrees(+32.72735150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69547"},
        {"Smithsonian Astrophysical Observation", "SAO 64011"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.54872224),
        dec: Angle.Degrees(+32.72792879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94273"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.82933413),
        dec: Angle.Degrees(+32.72983047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106971"},
        {"Hipparcos Number", "HIP 59973"},
        {"Geneva Identification System", "GEN# +1.00106971"},
        {"Smithsonian Astrophysical Observation", "SAO 62941"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.49477124),
        dec: Angle.Degrees(+32.73391072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160507"},
        {"Hipparcos Number", "HIP 86362"},
        {"Smithsonian Astrophysical Observation", "SAO 66214"},
        {"Wilson Evans Batten Catalogue", "WEB 14571"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.70652935),
        dec: Angle.Degrees(+32.73938928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247586"},
        {"Hipparcos Number", "HIP 27394"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.02133812),
        dec: Angle.Degrees(+32.73948177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11423"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.83133113),
        dec: Angle.Degrees(+32.73969805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10601"},
        {"Hipparcos Number", "HIP 8096"},
        {"Fundamental Katalog 5th Edition", "FK5 4154"},
        {"Smithsonian Astrophysical Observation", "SAO 54941"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.98384501),
        dec: Angle.Degrees(+32.74010920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17759"},
        {"Hipparcos Number", "HIP 13372"},
        {"Smithsonian Astrophysical Observation", "SAO 55955"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.00627686),
        dec: Angle.Degrees(+32.74204497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76069"},
        {"Hipparcos Number", "HIP 43775"},
        {"Smithsonian Astrophysical Observation", "SAO 61131"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74501036),
        dec: Angle.Degrees(+32.74390514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69819"},
        {"Geneva Identification System", "GEN# +6.20030714"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.33809173),
        dec: Angle.Degrees(+32.74611325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111732"},
        {"Hipparcos Number", "HIP 62709"},
        {"Geneva Identification System", "GEN# +1.00111732"},
        {"Smithsonian Astrophysical Observation", "SAO 63222"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.76410412),
        dec: Angle.Degrees(+32.74696348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45374"},
        {"Smithsonian Astrophysical Observation", "SAO 61352"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.70048095),
        dec: Angle.Degrees(+32.74763690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59369"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.70597930),
        dec: Angle.Degrees(+32.74854698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107053"},
        {"Hipparcos Number", "HIP 60014"},
        {"Geneva Identification System", "GEN# +1.00107053"},
        {"Smithsonian Astrophysical Observation", "SAO 62942"},
        {"Wilson Evans Batten Catalogue", "WEB 10665"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.62118680),
        dec: Angle.Degrees(+32.74891999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36506"},
        {"Hipparcos Number", "HIP 26077"},
        {"Geneva Identification System", "GEN# +1.00036506"},
        {"Smithsonian Astrophysical Observation", "SAO 58184"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.42956846),
        dec: Angle.Degrees(+32.74895761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74154"},
        {"Hipparcos Number", "HIP 42810"},
        {"Smithsonian Astrophysical Observation", "SAO 61010"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.84653911),
        dec: Angle.Degrees(+32.75160014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60071"},
        {"Geneva Identification System", "GEN# +0.03302221"},
        {"Smithsonian Astrophysical Observation", "SAO 62947"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77299978),
        dec: Angle.Degrees(+32.75437714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24913"},
        {"Hipparcos Number", "HIP 18610"},
        {"Geneva Identification System", "GEN# +1.00024913"},
        {"Smithsonian Astrophysical Observation", "SAO 56857"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.73115103),
        dec: Angle.Degrees(+32.75649792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18558",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2897 AB"},
        {"Henry Draper", "HD 24856"},
        {"Hipparcos Number", "HIP 18558"},
        {"Smithsonian Astrophysical Observation", "SAO 56850"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.58503230),
        dec: Angle.Degrees(+32.75652504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96651"},
        {"Smithsonian Astrophysical Observation", "SAO 68629"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.75941339),
        dec: Angle.Degrees(+32.75881954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30316",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4982 AB"},
        {"Henry Draper", "HD 44299"},
        {"Hipparcos Number", "HIP 30316"},
        {"Smithsonian Astrophysical Observation", "SAO 59022"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.64571532),
        dec: Angle.Degrees(+32.76029088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90251"},
        {"Hipparcos Number", "HIP 51044"},
        {"Smithsonian Astrophysical Observation", "SAO 62035"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.42548317),
        dec: Angle.Degrees(+32.76056243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81299"},
        {"Hipparcos Number", "HIP 46248"},
        {"Geneva Identification System", "GEN# +1.00081299"},
        {"Smithsonian Astrophysical Observation", "SAO 61481"},
        {"Wilson Evans Batten Catalogue", "WEB 8752"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.43758761),
        dec: Angle.Degrees(+32.76212800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32863"},
        {"Hipparcos Number", "HIP 23850"},
        {"Smithsonian Astrophysical Observation", "SAO 57655"},
        {"Wilson Evans Batten Catalogue", "WEB 4651"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90458831),
        dec: Angle.Degrees(+32.76412756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48464"},
        {"Smithsonian Astrophysical Observation", "SAO 61734"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.22708372),
        dec: Angle.Degrees(+32.76471474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10405"},
        {"Hipparcos Number", "HIP 7946"},
        {"Geneva Identification System", "GEN# +1.00010405"},
        {"Smithsonian Astrophysical Observation", "SAO 54914"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.52342602),
        dec: Angle.Degrees(+32.76712322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88452"},
        {"Smithsonian Astrophysical Observation", "SAO 66592"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.88327212),
        dec: Angle.Degrees(+32.76779472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56753"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52857736),
        dec: Angle.Degrees(+32.77163081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102126"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43246740),
        dec: Angle.Degrees(+32.77403055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205201"},
        {"Hipparcos Number", "HIP 106388"},
        {"Geneva Identification System", "GEN# +1.00205201"},
        {"Smithsonian Astrophysical Observation", "SAO 71448"},
        {"Wilson Evans Batten Catalogue", "WEB 19261"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.21150900),
        dec: Angle.Degrees(+32.77668480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113043"},
    },
    visualMagnitude: 11.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.40478312),
        dec: Angle.Degrees(+32.77753527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115707"},
        {"Hipparcos Number", "HIP 64922"},
        {"Smithsonian Astrophysical Observation", "SAO 63460"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.60181958),
        dec: Angle.Degrees(+32.77794193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174297"},
        {"Hipparcos Number", "HIP 92281"},
        {"Smithsonian Astrophysical Observation", "SAO 67403"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.11533002),
        dec: Angle.Degrees(+32.77964085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207021"},
        {"Hipparcos Number", "HIP 107410"},
        {"Geneva Identification System", "GEN# +1.00207021"},
        {"Smithsonian Astrophysical Observation", "SAO 71670"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.33717613),
        dec: Angle.Degrees(+32.78071209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84615"},
        {"Hipparcos Number", "HIP 48020"},
        {"Smithsonian Astrophysical Observation", "SAO 61684"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.83487378),
        dec: Angle.Degrees(+32.78234721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31233"},
        {"Hipparcos Number", "HIP 22898"},
        {"Smithsonian Astrophysical Observation", "SAO 57504"},
        {"Wilson Evans Batten Catalogue", "WEB 4441"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.87688941),
        dec: Angle.Degrees(+32.78397225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8470 A"},
        {"Henry Draper", "HD 106365"},
        {"Hipparcos Number", "HIP 59660"},
        {"Geneva Identification System", "GEN# +1.00106365A"},
        {"Smithsonian Astrophysical Observation", "SAO 62904"},
        {"Wilson Evans Batten Catalogue", "WEB 10601"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.52753285),
        dec: Angle.Degrees(+32.78421791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8470 BC"},
        {"Aitken 2", "ADS 8470 B"},
        {"Hipparcos Number", "HIP 59667"},
        {"Geneva Identification System", "GEN# +0.03302206"},
        {"Geneva Identification System 2", "GEN# +1.00106365B"},
        {"Smithsonian Astrophysical Observation", "SAO 62906"},
        {"Wilson Evans Batten Catalogue", "WEB 10602"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.53639070),
        dec: Angle.Degrees(+32.78451811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34590"},
        {"Hipparcos Number", "HIP 24877"},
        {"Geneva Identification System", "GEN# +1.00034590"},
        {"Smithsonian Astrophysical Observation", "SAO 57907"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00293918),
        dec: Angle.Degrees(+32.78569297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158387"},
        {"Hipparcos Number", "HIP 85433"},
        {"Geneva Identification System", "GEN# +1.00158387"},
        {"Smithsonian Astrophysical Observation", "SAO 66066"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.88180714),
        dec: Angle.Degrees(+32.78649340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130084"},
        {"Hipparcos Number", "HIP 72124"},
        {"Fundamental Katalog 5th Edition", "FK5 1384"},
        {"Geneva Identification System", "GEN# +1.00130084"},
        {"Smithsonian Astrophysical Observation", "SAO 64306"},
        {"Wilson Evans Batten Catalogue", "WEB 12412"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.30700457),
        dec: Angle.Degrees(+32.78851016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214127"},
        {"Hipparcos Number", "HIP 111527"},
        {"Smithsonian Astrophysical Observation", "SAO 72504"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.92668781),
        dec: Angle.Degrees(+32.78909533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104769"},
        {"Smithsonian Astrophysical Observation", "SAO 71085"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36760725),
        dec: Angle.Degrees(+32.78940062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53505"},
        {"Hipparcos Number", "HIP 34311"},
        {"Geneva Identification System", "GEN# +1.00053505"},
        {"Smithsonian Astrophysical Observation", "SAO 59786"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.70862705),
        dec: Angle.Degrees(+32.78967494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189689"},
        {"Hipparcos Number", "HIP 98441"},
        {"Geneva Identification System", "GEN# +1.00189689"},
        {"Smithsonian Astrophysical Observation", "SAO 69234"},
        {"Wilson Evans Batten Catalogue", "WEB 17379"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.02940465),
        dec: Angle.Degrees(+32.78968231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188992"},
        {"Hipparcos Number", "HIP 98145"},
        {"Celescope Catalog", "CEL 4883"},
        {"Geneva Identification System", "GEN# +1.00188992"},
        {"Smithsonian Astrophysical Observation", "SAO 69127"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.18555858),
        dec: Angle.Degrees(+32.79012579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212611"},
        {"Hipparcos Number", "HIP 110657"},
        {"Smithsonian Astrophysical Observation", "SAO 72313"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26115167),
        dec: Angle.Degrees(+32.79123577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126532"},
        {"Hipparcos Number", "HIP 70500"},
        {"Smithsonian Astrophysical Observation", "SAO 64134"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.32216452),
        dec: Angle.Degrees(+32.79133868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265119"},
        {"Hipparcos Number", "HIP 32999"},
        {"Smithsonian Astrophysical Observation", "SAO 59568"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.12085651),
        dec: Angle.Degrees(+32.79599497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207469"},
        {"Hipparcos Number", "HIP 107657"},
        {"Smithsonian Astrophysical Observation", "SAO 71718"},
        {"Wilson Evans Batten Catalogue", "WEB 19423"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.09795124),
        dec: Angle.Degrees(+32.79618054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191177"},
        {"Hipparcos Number", "HIP 99116"},
        {"Geneva Identification System", "GEN# +4.28050006"},
        {"Geneva Identification System 2", "GEN# +1.00191177"},
        {"Smithsonian Astrophysical Observation", "SAO 69442"},
        {"Wilson Evans Batten Catalogue", "WEB 17632"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.83267648),
        dec: Angle.Degrees(+32.79836835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36484"},
        {"Hipparcos Number", "HIP 26054"},
        {"Geneva Identification System", "GEN# +1.00036484"},
        {"Renson", "Renson 9430"},
        {"Smithsonian Astrophysical Observation", "SAO 58179"},
        {"Wilson Evans Batten Catalogue", "WEB 5067"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36418803),
        dec: Angle.Degrees(+32.80131934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73192"},
        {"Hipparcos Number", "HIP 42365"},
        {"Geneva Identification System", "GEN# +1.00073192"},
        {"Smithsonian Astrophysical Observation", "SAO 60939"},
        {"Wilson Evans Batten Catalogue", "WEB 8142"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.57915784),
        dec: Angle.Degrees(+32.80202805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45783"},
        {"Hipparcos Number", "HIP 31054"},
        {"Smithsonian Astrophysical Observation", "SAO 59166"},
        {"Wilson Evans Batten Catalogue", "WEB 6182"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.74885229),
        dec: Angle.Degrees(+32.80545021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68185"},
        {"Geneva Identification System", "GEN# +0.03302389"},
        {"Smithsonian Astrophysical Observation", "SAO 63856"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.38440994),
        dec: Angle.Degrees(+32.80869083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102056"},
        {"Smithsonian Astrophysical Observation", "SAO 70359"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.23095257),
        dec: Angle.Degrees(+32.80951636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204756"},
        {"Hipparcos Number", "HIP 106141"},
        {"Smithsonian Astrophysical Observation", "SAO 71397"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.49033754),
        dec: Angle.Degrees(+32.81009834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21403"},
        {"Hipparcos Number", "HIP 16154"},
        {"Smithsonian Astrophysical Observation", "SAO 56471"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.04329841),
        dec: Angle.Degrees(+32.81152763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11732 A"},
        {"Henry Draper", "HD 174585"},
        {"Hipparcos Number", "HIP 92398"},
        {"Celescope Catalog", "CEL 4655"},
        {"Geneva Identification System", "GEN# +1.00174585A"},
        {"Smithsonian Astrophysical Observation", "SAO 67441"},
        {"Wilson Evans Batten Catalogue", "WEB 15959"},
    },
    visualMagnitude: 5.93,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.44130295),
        dec: Angle.Degrees(+32.81283298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206366"},
        {"Hipparcos Number", "HIP 107048"},
        {"Smithsonian Astrophysical Observation", "SAO 71585"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.20512223),
        dec: Angle.Degrees(+32.81284614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61422"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.78691434),
        dec: Angle.Degrees(+32.81325039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122784"},
        {"Hipparcos Number", "HIP 68654"},
        {"Geneva Identification System", "GEN# +1.00122784"},
        {"Smithsonian Astrophysical Observation", "SAO 63911"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.79997334),
        dec: Angle.Degrees(+32.81377613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16513"},
        {"Hipparcos Number", "HIP 12419"},
        {"Smithsonian Astrophysical Observation", "SAO 55764"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.96268065),
        dec: Angle.Degrees(+32.81476460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216323"},
        {"Hipparcos Number", "HIP 112883"},
        {"Fundamental Katalog 5th Edition", "FK5 3827"},
        {"Geneva Identification System", "GEN# +1.00216323"},
        {"Smithsonian Astrophysical Observation", "SAO 72786"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.89192942),
        dec: Angle.Degrees(+32.81560488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39896"},
        {"Wilson Evans Batten Catalogue", "WEB 7779"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.23509144),
        dec: Angle.Degrees(+32.82029756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44955",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44955"},
        {"Geneva Identification System", "GEN# +0.03301814"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37850887),
        dec: Angle.Degrees(+32.82083717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -333.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -628.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82165"},
        {"Smithsonian Astrophysical Observation", "SAO 65556"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.80015837),
        dec: Angle.Degrees(+32.82155030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214089"},
        {"Hipparcos Number", "HIP 111493"},
        {"Geneva Identification System", "GEN# +1.00214089"},
        {"Smithsonian Astrophysical Observation", "SAO 72496"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.82848665),
        dec: Angle.Degrees(+32.82161912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116130"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96442794),
        dec: Angle.Degrees(+32.82183092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215290"},
        {"Hipparcos Number", "HIP 112212"},
        {"Smithsonian Astrophysical Observation", "SAO 72666"},
        {"Wilson Evans Batten Catalogue", "WEB 20026"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.89705232),
        dec: Angle.Degrees(+32.82206482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94670"},
        {"Hipparcos Number", "HIP 53457"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.03146806),
        dec: Angle.Degrees(+32.82238634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12888"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.41988686),
        dec: Angle.Degrees(+32.82387940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131893"},
        {"Hipparcos Number", "HIP 73015"},
        {"Smithsonian Astrophysical Observation", "SAO 64400"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.82881837),
        dec: Angle.Degrees(+32.82393101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98397"},
        {"Hipparcos Number", "HIP 55302"},
        {"Smithsonian Astrophysical Observation", "SAO 62494"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.88263828),
        dec: Angle.Degrees(+32.82507265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114187",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16519 AB"},
        {"Henry Draper", "HD 218395"},
        {"Hipparcos Number", "HIP 114187"},
        {"Geneva Identification System", "GEN# +1.00218395"},
        {"Wilson Evans Batten Catalogue", "WEB 20278"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.86557899),
        dec: Angle.Degrees(+32.82537306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76"},
        {"Smithsonian Astrophysical Observation", "SAO 73681"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.22821959),
        dec: Angle.Degrees(+32.82567452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122547"},
        {"Hipparcos Number", "HIP 68543"},
        {"Geneva Identification System", "GEN# +1.00122547"},
        {"Smithsonian Astrophysical Observation", "SAO 63896"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.48119817),
        dec: Angle.Degrees(+32.82590854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121298"},
        {"Hipparcos Number", "HIP 67871"},
        {"Smithsonian Astrophysical Observation", "SAO 63816"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.52132233),
        dec: Angle.Degrees(+32.82633557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56356"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.28457833),
        dec: Angle.Degrees(+32.82642575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213245"},
        {"Hipparcos Number", "HIP 111033"},
        {"Smithsonian Astrophysical Observation", "SAO 72393"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.40599949),
        dec: Angle.Degrees(+32.82885066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35495"},
        {"Cincinnati Publication", "Ci 20 418"},
        {"Geneva Identification System", "GEN# +0.03301505"},
        {"Wilson Evans Batten Catalogue", "WEB 7079"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.87910788),
        dec: Angle.Degrees(+32.83093125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 433.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -345.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92194"},
        {"Hipparcos Number", "HIP 52140"},
        {"Smithsonian Astrophysical Observation", "SAO 62179"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.78290861),
        dec: Angle.Degrees(+32.83335722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119054"},
        {"Hipparcos Number", "HIP 66712"},
        {"Geneva Identification System", "GEN# +1.00119054"},
        {"Smithsonian Astrophysical Observation", "SAO 63680"},
        {"Wilson Evans Batten Catalogue", "WEB 11769"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.12352832),
        dec: Angle.Degrees(+32.83590099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60521"},
        {"Hipparcos Number", "HIP 36993"},
        {"Geneva Identification System", "GEN# +1.00060521"},
        {"Smithsonian Astrophysical Observation", "SAO 60215"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.05861390),
        dec: Angle.Degrees(+32.83632885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115343"},
        {"Smithsonian Astrophysical Observation", "SAO 73204"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.44759908),
        dec: Angle.Degrees(+32.83679967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68546"},
        {"Geneva Identification System", "GEN# +0.03302400"},
        {"Smithsonian Astrophysical Observation", "SAO 63897"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.48882697),
        dec: Angle.Degrees(+32.83781154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90890"},
        {"Smithsonian Astrophysical Observation", "SAO 67086"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.09940180),
        dec: Angle.Degrees(+32.83910477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106541"},
        {"Hipparcos Number", "HIP 59749"},
        {"Geneva Identification System", "GEN# +1.00106541"},
        {"Smithsonian Astrophysical Observation", "SAO 62915"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.79004205),
        dec: Angle.Degrees(+32.84107900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62425"},
        {"Geneva Identification System", "GEN# +0.03302271"},
        {"Smithsonian Astrophysical Observation", "SAO 63194"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.89894379),
        dec: Angle.Degrees(+32.84383118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17470"},
        {"Hipparcos Number", "HIP 13146"},
        {"Smithsonian Astrophysical Observation", "SAO 55904"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.27202530),
        dec: Angle.Degrees(+32.84492607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228132"},
        {"Hipparcos Number", "HIP 99440"},
        {"Smithsonian Astrophysical Observation", "SAO 69563"},
        {"Wilson Evans Batten Catalogue", "WEB 17766"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.75185157),
        dec: Angle.Degrees(+32.84563983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 262"},
        {"Smithsonian Astrophysical Observation", "SAO 53603"},
        {"Wilson Evans Batten Catalogue", "WEB 39"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.82579542),
        dec: Angle.Degrees(+32.84586959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110267"},
        {"Smithsonian Astrophysical Observation", "SAO 72241"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.03023198),
        dec: Angle.Degrees(+32.84684768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17595"},
        {"Hipparcos Number", "HIP 13237"},
        {"Renson", "Renson 4410"},
        {"Smithsonian Astrophysical Observation", "SAO 55925"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.59796216),
        dec: Angle.Degrees(+32.84802359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28135"},
        {"Hipparcos Number", "HIP 20817"},
        {"Smithsonian Astrophysical Observation", "SAO 57241"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.90849079),
        dec: Angle.Degrees(+32.84827776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41046"},
        {"Smithsonian Astrophysical Observation", "SAO 60765"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.64612372),
        dec: Angle.Degrees(+32.84855710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198820"},
        {"Hipparcos Number", "HIP 102993"},
        {"Celescope Catalog", "CEL 5188"},
        {"Geneva Identification System", "GEN# +1.00198820"},
        {"Smithsonian Astrophysical Observation", "SAO 70596"},
        {"Wilson Evans Batten Catalogue", "WEB 18691"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.00162315),
        dec: Angle.Degrees(+32.84891554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64915"},
        {"Smithsonian Astrophysical Observation", "SAO 63459"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.59102392),
        dec: Angle.Degrees(+32.84903153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104906"},
        {"Hipparcos Number", "HIP 58914"},
        {"Geneva Identification System", "GEN# +1.00104906"},
        {"Smithsonian Astrophysical Observation", "SAO 62828"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.21314931),
        dec: Angle.Degrees(+32.85139012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331647"},
        {"Hipparcos Number", "HIP 98437"},
        {"Smithsonian Astrophysical Observation", "SAO 69232"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.01178650),
        dec: Angle.Degrees(+32.85170891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96046"},
        {"Hipparcos Number", "HIP 54183"},
        {"Smithsonian Astrophysical Observation", "SAO 62396"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.25974768),
        dec: Angle.Degrees(+32.85238983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9232"},
        {"Smithsonian Astrophysical Observation", "SAO 55160"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.67296166),
        dec: Angle.Degrees(+32.85299095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9854"},
        {"Hipparcos Number", "HIP 7516"},
        {"Smithsonian Astrophysical Observation", "SAO 54834"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.20203501),
        dec: Angle.Degrees(+32.85359823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15191",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2431 A"},
        {"Henry Draper", "HD 20193"},
        {"Hipparcos Number", "HIP 15191"},
        {"Geneva Identification System", "GEN# +1.00020193"},
        {"Smithsonian Astrophysical Observation", "SAO 56293"},
        {"Wilson Evans Batten Catalogue", "WEB 2923"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.94645147),
        dec: Angle.Degrees(+32.85666604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120996"},
        {"Hipparcos Number", "HIP 67716"},
        {"Geneva Identification System", "GEN# +1.00120996"},
        {"Smithsonian Astrophysical Observation", "SAO 63801"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.07801788),
        dec: Angle.Degrees(+32.85709052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74973"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.81331653),
        dec: Angle.Degrees(+32.85803975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281465"},
        {"Hipparcos Number", "HIP 18862"},
        {"Geneva Identification System", "GEN# +1.00281465"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.65819755),
        dec: Angle.Degrees(+32.85921754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58206"},
        {"Hipparcos Number", "HIP 36066"},
        {"Smithsonian Astrophysical Observation", "SAO 60069"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.48213680),
        dec: Angle.Degrees(+32.86115346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110464"},
        {"Hipparcos Number", "HIP 61979"},
        {"Geneva Identification System", "GEN# +1.00110464"},
        {"Smithsonian Astrophysical Observation", "SAO 63142"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.51901485),
        dec: Angle.Degrees(+32.86307225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102553",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14285 A"},
        {"Henry Draper", "HD 198088"},
        {"Hipparcos Number", "HIP 102553"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.73115728),
        dec: Angle.Degrees(+32.86397592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16015"},
        {"Hipparcos Number", "HIP 12043"},
        {"Geneva Identification System", "GEN# +1.00016015"},
        {"Smithsonian Astrophysical Observation", "SAO 55679"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.81199660),
        dec: Angle.Degrees(+32.86400845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102554",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14285 B"},
        {"Hipparcos Number", "HIP 102554"},
        {"Smithsonian Astrophysical Observation", "SAO 70488"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.73476410),
        dec: Angle.Degrees(+32.86409150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39382"},
        {"Smithsonian Astrophysical Observation", "SAO 60528"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.77680747),
        dec: Angle.Degrees(+32.86425139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156910"},
        {"Hipparcos Number", "HIP 84692"},
        {"Smithsonian Astrophysical Observation", "SAO 65932"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.70218536),
        dec: Angle.Degrees(+32.86496024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29867"},
        {"Hipparcos Number", "HIP 22003"},
        {"Geneva Identification System", "GEN# +1.00029867"},
        {"Smithsonian Astrophysical Observation", "SAO 57393"},
        {"Wilson Evans Batten Catalogue", "WEB 4227"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.95113685),
        dec: Angle.Degrees(+32.86556708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35768"},
        {"Hipparcos Number", "HIP 25639"},
        {"Smithsonian Astrophysical Observation", "SAO 58077"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.14635952),
        dec: Angle.Degrees(+32.86613238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112275"},
        {"Hipparcos Number", "HIP 63057"},
        {"Geneva Identification System", "GEN# +1.00112275"},
        {"Smithsonian Astrophysical Observation", "SAO 63251"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.80492031),
        dec: Angle.Degrees(+32.86619247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2666"},
        {"Smithsonian Astrophysical Observation", "SAO 53989"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.45256739),
        dec: Angle.Degrees(+32.86619947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36430"},
        {"Geneva Identification System", "GEN# +9.80090003"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.46180173),
        dec: Angle.Degrees(+32.86667941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20883"},
        {"Hipparcos Number", "HIP 15761"},
        {"Smithsonian Astrophysical Observation", "SAO 56397"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.77137881),
        dec: Angle.Degrees(+32.86762120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192684"},
        {"Hipparcos Number", "HIP 99801"},
        {"Smithsonian Astrophysical Observation", "SAO 69685"},
        {"Wilson Evans Batten Catalogue", "WEB 17927"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.72560963),
        dec: Angle.Degrees(+32.86867122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178973"},
        {"Hipparcos Number", "HIP 94097"},
        {"Fundamental Katalog 5th Edition", "FK5 5684"},
        {"Smithsonian Astrophysical Observation", "SAO 67882"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.32509814),
        dec: Angle.Degrees(+32.86896575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205351"},
        {"Hipparcos Number", "HIP 106473"},
        {"Geneva Identification System", "GEN# +1.00205351"},
        {"Smithsonian Astrophysical Observation", "SAO 71466"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.47619488),
        dec: Angle.Degrees(+32.86943179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16819"},
        {"Hipparcos Number", "HIP 12669"},
        {"Geneva Identification System", "GEN# +1.00016819"},
        {"Smithsonian Astrophysical Observation", "SAO 55806"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.69613034),
        dec: Angle.Degrees(+32.86949404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 577"},
        {"Smithsonian Astrophysical Observation", "SAO 53649"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.75224377),
        dec: Angle.Degrees(+32.87028504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 331970"},
        {"Hipparcos Number", "HIP 99567"},
        {"Geneva Identification System", "GEN# +1.00331970"},
        {"Wilson Evans Batten Catalogue", "WEB 17818"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.09513263),
        dec: Angle.Degrees(+32.87163541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247206"},
        {"Hipparcos Number", "HIP 27234"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.57076679),
        dec: Angle.Degrees(+32.87339732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10726"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.51008720),
        dec: Angle.Degrees(+32.87343568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66716"},
        {"Smithsonian Astrophysical Observation", "SAO 63681"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.13300863),
        dec: Angle.Degrees(+32.87520140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169029"},
        {"Hipparcos Number", "HIP 89953"},
        {"Geneva Identification System", "GEN# +1.00169029"},
        {"Smithsonian Astrophysical Observation", "SAO 66890"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.29926789),
        dec: Angle.Degrees(+32.87804520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98115"},
        {"Hipparcos Number", "HIP 55154"},
        {"Smithsonian Astrophysical Observation", "SAO 62478"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.38014410),
        dec: Angle.Degrees(+32.88112696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77408"},
        {"Hipparcos Number", "HIP 44441"},
        {"Cincinnati Publication", "Ci 20 507"},
        {"Geneva Identification System", "GEN# +1.00077408"},
        {"Smithsonian Astrophysical Observation", "SAO 61221"},
        {"Wilson Evans Batten Catalogue", "WEB 8519"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.81680674),
        dec: Angle.Degrees(+32.88144381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -419.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249845"},
        {"Hipparcos Number", "HIP 28361"},
        {"Geneva Identification System", "GEN# +1.00249845"},
        {"Smithsonian Astrophysical Observation", "SAO 58635"},
        {"Wilson Evans Batten Catalogue", "WEB 5545"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88323238),
        dec: Angle.Degrees(+32.88694375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54056"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.92060793),
        dec: Angle.Degrees(+32.88732635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24736"},
        {"Hipparcos Number", "HIP 18500"},
        {"Geneva Identification System", "GEN# +1.00024736"},
        {"Smithsonian Astrophysical Observation", "SAO 56836"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.33065112),
        dec: Angle.Degrees(+32.88824275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5196"},
        {"Hipparcos Number", "HIP 4246"},
        {"Smithsonian Astrophysical Observation", "SAO 54248"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.54152281),
        dec: Angle.Degrees(+32.88844350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97307",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12920 A"},
        {"Henry Draper", "HD 187038"},
        {"Hipparcos Number", "HIP 97307"},
        {"Geneva Identification System", "GEN# +1.00187038"},
        {"Smithsonian Astrophysical Observation", "SAO 68835"},
        {"Wilson Evans Batten Catalogue", "WEB 17099"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.64598291),
        dec: Angle.Degrees(+32.88860483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8777"},
        {"Smithsonian Astrophysical Observation", "SAO 55053"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.21593711),
        dec: Angle.Degrees(+32.88880138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93522"},
        {"Hipparcos Number", "HIP 52845"},
        {"Smithsonian Astrophysical Observation", "SAO 62256"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.08193299),
        dec: Angle.Degrees(+32.88920876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81526"},
    },
    visualMagnitude: 11.24,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.77769908),
        dec: Angle.Degrees(+32.88924455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282501"},
        {"Hipparcos Number", "HIP 22559"},
        {"Cincinnati Publication", "Ci 18 620"},
        {"Geneva Identification System", "GEN# +1.00282501"},
        {"Smithsonian Astrophysical Observation", "SAO 57458"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.81990611),
        dec: Angle.Degrees(+32.89023121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -261.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16220"},
        {"Hipparcos Number", "HIP 12200"},
        {"Geneva Identification System", "GEN# +1.00016220"},
        {"Smithsonian Astrophysical Observation", "SAO 55711"},
        {"Wilson Evans Batten Catalogue", "WEB 2505"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.27713577),
        dec: Angle.Degrees(+32.89101724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36952"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.95161342),
        dec: Angle.Degrees(+32.89193776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224127"},
        {"Hipparcos Number", "HIP 117938"},
        {"Smithsonian Astrophysical Observation", "SAO 73612"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84444450),
        dec: Angle.Degrees(+32.89204289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12596 AB"},
        {"Henry Draper", "HD 184425"},
        {"Hipparcos Number", "HIP 96162"},
        {"Smithsonian Astrophysical Observation", "SAO 68481"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.28724292),
        dec: Angle.Degrees(+32.89408603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33503"},
        {"Hipparcos Number", "HIP 24232"},
        {"Geneva Identification System", "GEN# +1.00033503"},
        {"Smithsonian Astrophysical Observation", "SAO 57737"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.04007519),
        dec: Angle.Degrees(+32.89514275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37574"},
        {"Hipparcos Number", "HIP 26744"},
        {"Geneva Identification System", "GEN# +1.00037574"},
        {"Smithsonian Astrophysical Observation", "SAO 58327"},
        {"Wilson Evans Batten Catalogue", "WEB 5277"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24093606),
        dec: Angle.Degrees(+32.89599354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19902"},
        {"Hipparcos Number", "HIP 14976"},
        {"Geneva Identification System", "GEN# +1.00019902"},
        {"Smithsonian Astrophysical Observation", "SAO 56256"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.26110500),
        dec: Angle.Degrees(+32.89659875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16810"},
        {"Hipparcos Number", "HIP 12661"},
        {"Geneva Identification System", "GEN# +1.00016810"},
        {"Smithsonian Astrophysical Observation", "SAO 55804"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.67233202),
        dec: Angle.Degrees(+32.90158684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11871 AB"},
        {"Henry Draper", "HD 176051"},
        {"Hipparcos Number", "HIP 93017"},
        {"Geneva Identification System", "GEN# +1.00176051"},
        {"Smithsonian Astrophysical Observation", "SAO 67612"},
        {"Wilson Evans Batten Catalogue", "WEB 16108"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.25612303),
        dec: Angle.Degrees(+32.90162351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80546"},
        {"Hipparcos Number", "HIP 45896"},
        {"Geneva Identification System", "GEN# +1.00080546"},
        {"Smithsonian Astrophysical Observation", "SAO 61424"},
        {"Wilson Evans Batten Catalogue", "WEB 8705"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.36322747),
        dec: Angle.Degrees(+32.90220650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58204"},
        {"Geneva Identification System", "GEN# +0.03302171"},
        {"Renson", "Renson 29930"},
        {"Wilson Evans Batten Catalogue", "WEB 10418"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.05821980),
        dec: Angle.Degrees(+32.90329718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221970"},
        {"Hipparcos Number", "HIP 116505"},
        {"Geneva Identification System", "GEN# +1.00221970"},
        {"Smithsonian Astrophysical Observation", "SAO 73368"},
        {"Wilson Evans Batten Catalogue", "WEB 20575"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.12715115),
        dec: Angle.Degrees(+32.90419730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69135"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.28497118),
        dec: Angle.Degrees(+32.90549758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282683"},
        {"Hipparcos Number", "HIP 23378"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.39416433),
        dec: Angle.Degrees(+32.90659856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196006"},
        {"Hipparcos Number", "HIP 101442"},
        {"Celescope Catalog", "CEL 5110"},
        {"Geneva Identification System", "GEN# +1.00196006"},
        {"Smithsonian Astrophysical Observation", "SAO 70194"},
        {"Wilson Evans Batten Catalogue", "WEB 18327"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.37661420),
        dec: Angle.Degrees(+32.90773607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25309"},
        {"Hipparcos Number", "HIP 18858"},
        {"Geneva Identification System", "GEN# +1.00025309"},
        {"Smithsonian Astrophysical Observation", "SAO 56919"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.65087224),
        dec: Angle.Degrees(+32.90950270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76398"},
        {"Hipparcos Number", "HIP 43932"},
        {"Geneva Identification System", "GEN# +1.00076398"},
        {"Smithsonian Astrophysical Observation", "SAO 61146"},
        {"Wilson Evans Batten Catalogue", "WEB 8447"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23597642),
        dec: Angle.Degrees(+32.91058931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1632"},
        {"Hipparcos Number", "HIP 1657"},
        {"Geneva Identification System", "GEN# +1.00001632"},
        {"Smithsonian Astrophysical Observation", "SAO 53825"},
        {"Wilson Evans Batten Catalogue", "WEB 303"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18974442),
        dec: Angle.Degrees(+32.91122853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139858"},
        {"Hipparcos Number", "HIP 76665"},
        {"Smithsonian Astrophysical Observation", "SAO 64829"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.82805733),
        dec: Angle.Degrees(+32.91252864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38148"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.25888485),
        dec: Angle.Degrees(+32.91257195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47223"},
        {"Smithsonian Astrophysical Observation", "SAO 61602"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.36768674),
        dec: Angle.Degrees(+32.91268782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187796"},
        {"Hipparcos Number", "HIP 97629"},
        {"Geneva Identification System", "GEN# +1.00187796"},
        {"Smithsonian Astrophysical Observation", "SAO 68943"},
        {"Wilson Evans Batten Catalogue", "WEB 17165"},
    },
    visualMagnitude: 7.91,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.64140992),
        dec: Angle.Degrees(+32.91415201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17917"},
        {"Hipparcos Number", "HIP 13486"},
        {"Smithsonian Astrophysical Observation", "SAO 55977"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.41751321),
        dec: Angle.Degrees(+32.91874896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72603"},
        {"Hipparcos Number", "HIP 42104"},
        {"Smithsonian Astrophysical Observation", "SAO 60908"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.73957914),
        dec: Angle.Degrees(+32.91914338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113492"},
        {"Hipparcos Number", "HIP 63747"},
        {"Geneva Identification System", "GEN# +1.00113492"},
        {"Smithsonian Astrophysical Observation", "SAO 63320"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.97160220),
        dec: Angle.Degrees(+32.92048537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80870"},
        {"Hipparcos Number", "HIP 46023"},
        {"Geneva Identification System", "GEN# +1.00080870"},
        {"Smithsonian Astrophysical Observation", "SAO 61438"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.79311364),
        dec: Angle.Degrees(+32.92105681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90992"},
        {"Hipparcos Number", "HIP 51471"},
        {"Smithsonian Astrophysical Observation", "SAO 62089"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.70488318),
        dec: Angle.Degrees(+32.92330917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60887"},
        {"Geneva Identification System", "GEN# +0.03302240"},
        {"Smithsonian Astrophysical Observation", "SAO 63015"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.17639624),
        dec: Angle.Degrees(+32.92336000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60903"},
        {"Geneva Identification System", "GEN# +0.03302242"},
        {"Smithsonian Astrophysical Observation", "SAO 63018"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.22738811),
        dec: Angle.Degrees(+32.92360519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84234"},
        {"Smithsonian Astrophysical Observation", "SAO 65874"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.27177529),
        dec: Angle.Degrees(+32.92417231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133963"},
        {"Hipparcos Number", "HIP 73910"},
        {"Smithsonian Astrophysical Observation", "SAO 64500"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57071125),
        dec: Angle.Degrees(+32.92432179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64619"},
        {"Geneva Identification System", "GEN# +0.03302314"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.66791601),
        dec: Angle.Degrees(+32.92437569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4653"},
        {"Hipparcos Number", "HIP 3805"},
        {"Geneva Identification System", "GEN# +1.00004653"},
        {"Smithsonian Astrophysical Observation", "SAO 54164"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.22782635),
        dec: Angle.Degrees(+32.92466589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14924"},
    },
    visualMagnitude: 11.51,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.12826162),
        dec: Angle.Degrees(+32.92754225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136849"},
        {"Hipparcos Number", "HIP 75178"},
        {"Geneva Identification System", "GEN# +1.00136849"},
        {"Smithsonian Astrophysical Observation", "SAO 64656"},
        {"Wilson Evans Batten Catalogue", "WEB 12826"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.45253799),
        dec: Angle.Degrees(+32.93366086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155640"},
        {"Hipparcos Number", "HIP 84089"},
        {"Smithsonian Astrophysical Observation", "SAO 65854"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.86856534),
        dec: Angle.Degrees(+32.93702743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17320",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2701 A"},
        {"Henry Draper", "HD 22963"},
        {"Hipparcos Number", "HIP 17320"},
        {"Geneva Identification System", "GEN# +1.00022963"},
        {"Smithsonian Astrophysical Observation", "SAO 56650"},
        {"Wilson Evans Batten Catalogue", "WEB 3273"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.61508293),
        dec: Angle.Degrees(+32.93945824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169060"},
        {"Hipparcos Number", "HIP 89964"},
        {"Geneva Identification System", "GEN# +1.00169060"},
        {"Smithsonian Astrophysical Observation", "SAO 66893"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.33164070),
        dec: Angle.Degrees(+32.93959855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65021"},
        {"Hipparcos Number", "HIP 38932"},
        {"Smithsonian Astrophysical Observation", "SAO 60480"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.49353508),
        dec: Angle.Degrees(+32.94108403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53677"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.74019396),
        dec: Angle.Degrees(+32.94143236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108969",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15602 A"},
        {"Henry Draper", "HD 209693"},
        {"Hipparcos Number", "HIP 108969"},
        {"Geneva Identification System", "GEN# +1.00209693"},
        {"Smithsonian Astrophysical Observation", "SAO 71998"},
        {"Wilson Evans Batten Catalogue", "WEB 19597"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.14380705),
        dec: Angle.Degrees(+32.94176333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24411"},
        {"Hipparcos Number", "HIP 18257"},
        {"Geneva Identification System", "GEN# +1.00024411"},
        {"Smithsonian Astrophysical Observation", "SAO 56801"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.57984676),
        dec: Angle.Degrees(+32.94382319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60412"},
        {"Geneva Identification System", "GEN# +0.03302230"},
        {"Smithsonian Astrophysical Observation", "SAO 62979"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.80135706),
        dec: Angle.Degrees(+32.94504517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86430"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.90334949),
        dec: Angle.Degrees(+32.94626495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204584"},
        {"Hipparcos Number", "HIP 106041"},
        {"Smithsonian Astrophysical Observation", "SAO 71377"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.18233084),
        dec: Angle.Degrees(+32.94672426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226401"},
        {"Hipparcos Number", "HIP 97917"},
        {"Geneva Identification System", "GEN# +1.00226401"},
        {"Smithsonian Astrophysical Observation", "SAO 69042"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.47373161),
        dec: Angle.Degrees(+32.94720044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77716"},
        {"Geneva Identification System", "GEN# +0.03302642"},
    },
    visualMagnitude: 10.84,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99956419),
        dec: Angle.Degrees(+32.94842227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259142"},
        {"Hipparcos Number", "HIP 31257"},
        {"Smithsonian Astrophysical Observation", "SAO 59218"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.33680660),
        dec: Angle.Degrees(+32.94999428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9271 AB"},
        {"Henry Draper", "HD 126944"},
        {"Hipparcos Number", "HIP 70712"},
        {"Smithsonian Astrophysical Observation", "SAO 64149"},
        {"Wilson Evans Batten Catalogue", "WEB 12254"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93880100),
        dec: Angle.Degrees(+32.95080616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281540"},
        {"Hipparcos Number", "HIP 19143"},
        {"Cincinnati Publication", "Ci 20 279"},
        {"Geneva Identification System", "GEN# +1.00281540"},
        {"Wilson Evans Batten Catalogue", "WEB 3676"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.54702839),
        dec: Angle.Degrees(+32.95288368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 682.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -831.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203959"},
        {"Hipparcos Number", "HIP 105702"},
        {"Smithsonian Astrophysical Observation", "SAO 71297"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.13560968),
        dec: Angle.Degrees(+32.95689313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15234"},
        {"Cincinnati Publication", "Ci 20 217"},
        {"Geneva Identification System", "GEN# +9.80078026"},
        {"Wilson Evans Batten Catalogue", "WEB 2937"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.10944237),
        dec: Angle.Degrees(+38.10145522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 739.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1063.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220951"},
        {"Hipparcos Number", "HIP 115820"},
        {"Geneva Identification System", "GEN# +1.00220951"},
        {"Smithsonian Astrophysical Observation", "SAO 73272"},
        {"Wilson Evans Batten Catalogue", "WEB 20492"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.95721757),
        dec: Angle.Degrees(+32.95890901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90053"},
    },
    visualMagnitude: 11.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.65837071),
        dec: Angle.Degrees(+32.95897494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10439"},
        {"Hipparcos Number", "HIP 7969"},
        {"Smithsonian Astrophysical Observation", "SAO 54918"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.60031881),
        dec: Angle.Degrees(+32.96188784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104318"},
        {"Hipparcos Number", "HIP 58586"},
        {"Geneva Identification System", "GEN# +1.00104318"},
        {"Smithsonian Astrophysical Observation", "SAO 62795"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.21196247),
        dec: Angle.Degrees(+32.96392085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131176"},
        {"Hipparcos Number", "HIP 72628"},
        {"Smithsonian Astrophysical Observation", "SAO 64361"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.74531355),
        dec: Angle.Degrees(+32.96474869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90733"},
        {"Hipparcos Number", "HIP 51337"},
        {"Smithsonian Astrophysical Observation", "SAO 62063"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.29067440),
        dec: Angle.Degrees(+32.96730546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86104"},
        {"Hipparcos Number", "HIP 48798"},
        {"Smithsonian Astrophysical Observation", "SAO 61775"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.28706023),
        dec: Angle.Degrees(+32.96888261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88811"},
        {"Smithsonian Astrophysical Observation", "SAO 66658"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.94636501),
        dec: Angle.Degrees(+32.96902843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13719"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.16035344),
        dec: Angle.Degrees(+32.97077109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57541"},
        {"Smithsonian Astrophysical Observation", "SAO 62703"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.90046203),
        dec: Angle.Degrees(+32.97189973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42529"},
        {"Hipparcos Number", "HIP 29478"},
        {"Smithsonian Astrophysical Observation", "SAO 58857"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.16604544),
        dec: Angle.Degrees(+32.97265578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255976"},
        {"Hipparcos Number", "HIP 30367"},
        {"Smithsonian Astrophysical Observation", "SAO 59029"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.79593701),
        dec: Angle.Degrees(+32.97287474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247909"},
        {"Hipparcos Number", "HIP 27528"},
        {"Fundamental Katalog 5th Edition", "FK5 4534"},
        {"Smithsonian Astrophysical Observation", "SAO 58481"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.44243821),
        dec: Angle.Degrees(+32.97313681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131913"},
        {"Hipparcos Number", "HIP 73018"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.84381436),
        dec: Angle.Degrees(+32.97410751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43789"},
        {"Smithsonian Astrophysical Observation", "SAO 61132"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.78109012),
        dec: Angle.Degrees(+32.97590176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120419"},
        {"Hipparcos Number", "HIP 67391"},
        {"Geneva Identification System", "GEN# +1.00120419"},
        {"Smithsonian Astrophysical Observation", "SAO 63762"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.17822364),
        dec: Angle.Degrees(+32.97694965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 285 AB"},
        {"Henry Draper", "HD 1641"},
        {"Hipparcos Number", "HIP 1669"},
        {"Geneva Identification System", "GEN# +1.00001641"},
        {"Smithsonian Astrophysical Observation", "SAO 53827"},
        {"Wilson Evans Batten Catalogue", "WEB 305"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.22549183),
        dec: Angle.Degrees(+32.97816304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38340"},
        {"Smithsonian Astrophysical Observation", "SAO 60387"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80466689),
        dec: Angle.Degrees(+32.97986204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13608"},
        {"Hipparcos Number", "HIP 10373"},
        {"Geneva Identification System", "GEN# +1.00013608"},
        {"Smithsonian Astrophysical Observation", "SAO 55363"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.41641516),
        dec: Angle.Degrees(+32.98131510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39723"},
        {"Smithsonian Astrophysical Observation", "SAO 60572"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.79181691),
        dec: Angle.Degrees(+32.98217602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161288"},
        {"Hipparcos Number", "HIP 86723"},
        {"Smithsonian Astrophysical Observation", "SAO 66282"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.81645488),
        dec: Angle.Degrees(+32.98438364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180139"},
        {"Hipparcos Number", "HIP 94503"},
        {"Smithsonian Astrophysical Observation", "SAO 68016"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.51460482),
        dec: Angle.Degrees(+32.98687666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2591"},
        {"Hipparcos Number", "HIP 2324"},
        {"Geneva Identification System", "GEN# +1.00002591"},
        {"Smithsonian Astrophysical Observation", "SAO 53935"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.41288311),
        dec: Angle.Degrees(+32.98716291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176356"},
        {"Hipparcos Number", "HIP 93156"},
        {"Smithsonian Astrophysical Observation", "SAO 67652"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.63048365),
        dec: Angle.Degrees(+32.98731603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94178"},
        {"Hipparcos Number", "HIP 53179"},
        {"Geneva Identification System", "GEN# +1.00094178"},
        {"Smithsonian Astrophysical Observation", "SAO 62291"},
        {"Wilson Evans Batten Catalogue", "WEB 9657"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.17124440),
        dec: Angle.Degrees(+32.98888002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176174"},
        {"Hipparcos Number", "HIP 93073"},
        {"Geneva Identification System", "GEN# +1.00176174"},
        {"Smithsonian Astrophysical Observation", "SAO 67630"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.38843130),
        dec: Angle.Degrees(+32.98953104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211527"},
        {"Hipparcos Number", "HIP 110027"},
        {"Smithsonian Astrophysical Observation", "SAO 72203"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.27954794),
        dec: Angle.Degrees(+32.99125223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6455"},
        {"Hipparcos Number", "HIP 5148"},
        {"Smithsonian Astrophysical Observation", "SAO 54416"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.47580777),
        dec: Angle.Degrees(+32.99364454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20933"},
        {"Hipparcos Number", "HIP 15804"},
        {"Geneva Identification System", "GEN# +1.00020933"},
        {"Smithsonian Astrophysical Observation", "SAO 56407"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.90390686),
        dec: Angle.Degrees(+32.99468381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83934"},
        {"Hipparcos Number", "HIP 47617"},
        {"Geneva Identification System", "GEN# +1.00083934"},
        {"Smithsonian Astrophysical Observation", "SAO 61647"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.64424691),
        dec: Angle.Degrees(+32.99484570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95957"},
        {"Hipparcos Number", "HIP 54134"},
        {"Smithsonian Astrophysical Observation", "SAO 62388"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12867245),
        dec: Angle.Degrees(+32.99565995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207242"},
        {"Hipparcos Number", "HIP 107536"},
        {"Geneva Identification System", "GEN# +1.00207242"},
        {"Smithsonian Astrophysical Observation", "SAO 71689"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.70381734),
        dec: Angle.Degrees(+32.99586400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4766 A"},
        {"Henry Draper", "HD 42175"},
        {"Hipparcos Number", "HIP 29309"},
        {"Geneva Identification System", "GEN# +1.00042175"},
        {"Smithsonian Astrophysical Observation", "SAO 58832"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.69257803),
        dec: Angle.Degrees(+32.99621398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65657"},
        {"Geneva Identification System", "GEN# +0.03302340"},
        {"Smithsonian Astrophysical Observation", "SAO 63551"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.92698276),
        dec: Angle.Degrees(+32.99857336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83630"},
        {"Hipparcos Number", "HIP 47483"},
        {"Geneva Identification System", "GEN# +1.00083630"},
        {"Smithsonian Astrophysical Observation", "SAO 61624"},
        {"Wilson Evans Batten Catalogue", "WEB 8910"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.19086254),
        dec: Angle.Degrees(+32.99937497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278830"},
        {"Hipparcos Number", "HIP 16676"},
        {"Smithsonian Astrophysical Observation", "SAO 56553"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65145719),
        dec: Angle.Degrees(+33.00098181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50341"},
        {"Hipparcos Number", "HIP 33166"},
        {"Renson", "Renson 13780"},
        {"Smithsonian Astrophysical Observation", "SAO 59598"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55670722),
        dec: Angle.Degrees(+33.00252054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101302"},
        {"Cincinnati Publication", "Ci 20 1212"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.00075549),
        dec: Angle.Degrees(+33.00540715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 300.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 286.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209149"},
        {"Hipparcos Number", "HIP 108632"},
        {"Geneva Identification System", "GEN# +1.00209149"},
        {"Smithsonian Astrophysical Observation", "SAO 71932"},
        {"Wilson Evans Batten Catalogue", "WEB 19547"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.11129256),
        dec: Angle.Degrees(+33.00578827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281735"},
        {"Hipparcos Number", "HIP 19754"},
        {"Smithsonian Astrophysical Observation", "SAO 57085"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.52658149),
        dec: Angle.Degrees(+33.00660182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259869"},
        {"Hipparcos Number", "HIP 31467"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.86999972),
        dec: Angle.Degrees(+33.00692609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95674"},
        {"Smithsonian Astrophysical Observation", "SAO 68342"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.91338882),
        dec: Angle.Degrees(+33.00863244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105843"},
        {"Hipparcos Number", "HIP 59375"},
        {"Geneva Identification System", "GEN# +1.00105843"},
        {"Smithsonian Astrophysical Observation", "SAO 62881"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.72870231),
        dec: Angle.Degrees(+33.00912683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74588"},
        {"Geneva Identification System", "GEN# +0.03302560"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.60907303),
        dec: Angle.Degrees(+33.01112506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129469"},
        {"Hipparcos Number", "HIP 71846"},
        {"Smithsonian Astrophysical Observation", "SAO 64277"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.44422764),
        dec: Angle.Degrees(+33.01164802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141417"},
        {"Hipparcos Number", "HIP 77379"},
        {"Smithsonian Astrophysical Observation", "SAO 64911"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.93772596),
        dec: Angle.Degrees(+33.01195151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189846"},
        {"Hipparcos Number", "HIP 98519"},
        {"Geneva Identification System", "GEN# +1.00189846"},
        {"Smithsonian Astrophysical Observation", "SAO 69253"},
        {"Wilson Evans Batten Catalogue", "WEB 17401"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.22700276),
        dec: Angle.Degrees(+33.01248993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109029"},
        {"Hipparcos Number", "HIP 61114"},
        {"Geneva Identification System", "GEN# +1.00109029"},
        {"Smithsonian Astrophysical Observation", "SAO 63046"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.87818796),
        dec: Angle.Degrees(+33.01523667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8488"},
        {"Smithsonian Astrophysical Observation", "SAO 55004"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.36116701),
        dec: Angle.Degrees(+33.01591975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82637"},
        {"Hipparcos Number", "HIP 46947"},
        {"Smithsonian Astrophysical Observation", "SAO 61567"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.52624059),
        dec: Angle.Degrees(+33.01639550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50835",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50835"},
        {"Smithsonian Astrophysical Observation", "SAO 62004"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.70487371),
        dec: Angle.Degrees(+33.01646365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47216"},
        {"Hipparcos Number", "HIP 31796"},
        {"Geneva Identification System", "GEN# +1.00047216"},
        {"Smithsonian Astrophysical Observation", "SAO 59326"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.71954305),
        dec: Angle.Degrees(+33.01808175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104069"},
        {"Smithsonian Astrophysical Observation", "SAO 70878"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.25949307),
        dec: Angle.Degrees(+33.01849430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228506"},
        {"Hipparcos Number", "HIP 99780"},
        {"Geneva Identification System", "GEN# +1.00228506"},
        {"Smithsonian Astrophysical Observation", "SAO 69680"},
        {"Wilson Evans Batten Catalogue", "WEB 17921"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.67649369),
        dec: Angle.Degrees(+33.02083145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46251"},
        {"Hipparcos Number", "HIP 31290"},
        {"Geneva Identification System", "GEN# +1.00046251"},
        {"Smithsonian Astrophysical Observation", "SAO 59222"},
        {"Wilson Evans Batten Catalogue", "WEB 6256"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.42771283),
        dec: Angle.Degrees(+33.02403655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47590"},
        {"Hipparcos Number", "HIP 31960"},
        {"Smithsonian Astrophysical Observation", "SAO 59351"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.19556987),
        dec: Angle.Degrees(+33.02553678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6594"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.17284789),
        dec: Angle.Degrees(+33.02583028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197262"},
        {"Hipparcos Number", "HIP 102109"},
        {"Smithsonian Astrophysical Observation", "SAO 70377"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.38934977),
        dec: Angle.Degrees(+33.02787504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220150"},
        {"Hipparcos Number", "HIP 115306"},
        {"Geneva Identification System", "GEN# +1.00220150"},
        {"Smithsonian Astrophysical Observation", "SAO 73194"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.30237844),
        dec: Angle.Degrees(+33.02795120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143241"},
        {"Hipparcos Number", "HIP 78205"},
        {"Smithsonian Astrophysical Observation", "SAO 64991"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.53534619),
        dec: Angle.Degrees(+33.02882571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114121"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.67663563),
        dec: Angle.Degrees(+33.02962296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -153.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48684"},
        {"Hipparcos Number", "HIP 32415"},
        {"Geneva Identification System", "GEN# +1.00048684"},
        {"Smithsonian Astrophysical Observation", "SAO 59463"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.51135706),
        dec: Angle.Degrees(+33.02968689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114717"},
        {"Smithsonian Astrophysical Observation", "SAO 73104"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.56620286),
        dec: Angle.Degrees(+33.03005253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7587"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.42299215),
        dec: Angle.Degrees(+33.03014406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74277"},
        {"Smithsonian Astrophysical Observation", "SAO 64538"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.70063174),
        dec: Angle.Degrees(+33.03020866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1074"},
        {"Hipparcos Number", "HIP 1207"},
        {"Geneva Identification System", "GEN# +1.00001074"},
        {"Smithsonian Astrophysical Observation", "SAO 53754"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.77828112),
        dec: Angle.Degrees(+33.03049687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
