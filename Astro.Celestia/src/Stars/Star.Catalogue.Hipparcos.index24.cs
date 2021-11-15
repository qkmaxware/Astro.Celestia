using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_24() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104613"},
        {"Hipparcos Number", "HIP 58733"},
        {"Smithsonian Astrophysical Observation", "SAO 223185"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69958612),
        dec: Angle.Degrees(-42.77295415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66503"},
        {"Hipparcos Number", "HIP 39290"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.51031421),
        dec: Angle.Degrees(-42.77017256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71302"},
        {"Hipparcos Number", "HIP 41250"},
        {"Celescope Catalog", "CEL 2481"},
        {"Geneva Identification System", "GEN# +1.00071302J"},
        {"Smithsonian Astrophysical Observation", "SAO 219890"},
        {"Wilson Evans Batten Catalogue", "WEB 7982"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23839828),
        dec: Angle.Degrees(-42.76985034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93521"},
        {"Geneva Identification System", "GEN# +6.20145028"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.70786379),
        dec: Angle.Degrees(-42.76827062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37165"},
        {"Hipparcos Number", "HIP 26141"},
        {"Smithsonian Astrophysical Observation", "SAO 217403"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60472843),
        dec: Angle.Degrees(-42.76573403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118483"},
        {"Hipparcos Number", "HIP 66515"},
        {"Smithsonian Astrophysical Observation", "SAO 224292"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.51442843),
        dec: Angle.Degrees(-42.76499278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8680"},
        {"Hipparcos Number", "HIP 6609"},
        {"Geneva Identification System", "GEN# +1.00008680"},
        {"Smithsonian Astrophysical Observation", "SAO 215495"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.20856252),
        dec: Angle.Degrees(-42.76445496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116437"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.91769341),
        dec: Angle.Degrees(-42.76441937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31802"},
        {"Hipparcos Number", "HIP 22977"},
        {"Geneva Identification System", "GEN# +1.00031802"},
        {"Smithsonian Astrophysical Observation", "SAO 217070"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.17002986),
        dec: Angle.Degrees(-42.76237325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22946"},
        {"Hipparcos Number", "HIP 17047"},
        {"Geneva Identification System", "GEN# +1.00022946"},
        {"Smithsonian Astrophysical Observation", "SAO 216428"},
        {"Wilson Evans Batten Catalogue", "WEB 3240"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.82001172),
        dec: Angle.Degrees(-42.76228280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216744"},
        {"Hipparcos Number", "HIP 113248"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.99133088),
        dec: Angle.Degrees(-42.76098061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67059"},
        {"Hipparcos Number", "HIP 39508"},
        {"Smithsonian Astrophysical Observation", "SAO 219382"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.12581271),
        dec: Angle.Degrees(-42.75874475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75083"},
        {"Hipparcos Number", "HIP 43055"},
        {"Celescope Catalog", "CEL 2883"},
        {"Geneva Identification System", "GEN# +4.35100014"},
        {"Smithsonian Astrophysical Observation", "SAO 220430"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.57372739),
        dec: Angle.Degrees(-42.75869639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68184"},
        {"Hipparcos Number", "HIP 39964"},
        {"Smithsonian Astrophysical Observation", "SAO 219499"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.40380395),
        dec: Angle.Degrees(-42.75459965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28538"},
        {"Hipparcos Number", "HIP 20844"},
        {"Renson", "Renson 7330"},
        {"Smithsonian Astrophysical Observation", "SAO 216818"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.00848669),
        dec: Angle.Degrees(-42.75388859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92328"},
        {"Hipparcos Number", "HIP 52112"},
        {"Fundamental Katalog 5th Edition", "FK5 2853"},
        {"Geneva Identification System", "GEN# +1.00092328J"},
        {"Renson", "Renson 26580"},
        {"Smithsonian Astrophysical Observation", "SAO 222222"},
        {"Wilson Evans Batten Catalogue", "WEB 9496"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.70970482),
        dec: Angle.Degrees(-42.75341389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44466"},
        {"Hipparcos Number", "HIP 30077"},
        {"Smithsonian Astrophysical Observation", "SAO 217852"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.94862508),
        dec: Angle.Degrees(-42.75290729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125496"},
        {"Hipparcos Number", "HIP 70112"},
        {"Smithsonian Astrophysical Observation", "SAO 224850"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.19810031),
        dec: Angle.Degrees(-42.75024497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211848"},
        {"Hipparcos Number", "HIP 110343"},
        {"Smithsonian Astrophysical Observation", "SAO 231091"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.23556832),
        dec: Angle.Degrees(-42.74908438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116905"},
        {"Geneva Identification System", "GEN# +6.20145143"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.46218121),
        dec: Angle.Degrees(-42.74806686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -322.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51291"},
        {"Hipparcos Number", "HIP 33214"},
        {"Smithsonian Astrophysical Observation", "SAO 218304"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.68321546),
        dec: Angle.Degrees(-42.74656023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89479"},
        {"Hipparcos Number", "HIP 50486"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.63906488),
        dec: Angle.Degrees(-42.74339256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142852"},
        {"Hipparcos Number", "HIP 78238"},
        {"Smithsonian Astrophysical Observation", "SAO 226415"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63168745),
        dec: Angle.Degrees(-42.74262528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146475"},
        {"Hipparcos Number", "HIP 79888"},
        {"Geneva Identification System", "GEN# +1.00146475"},
        {"Smithsonian Astrophysical Observation", "SAO 226639"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.59831831),
        dec: Angle.Degrees(-42.74213275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148707"},
        {"Hipparcos Number", "HIP 80955"},
        {"Geneva Identification System", "GEN# +1.00148707"},
        {"Smithsonian Astrophysical Observation", "SAO 226856"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.95130101),
        dec: Angle.Degrees(-42.74018739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213436"},
        {"Hipparcos Number", "HIP 111223"},
        {"Smithsonian Astrophysical Observation", "SAO 231187"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.01310536),
        dec: Angle.Degrees(-42.74011644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90518"},
        {"Hipparcos Number", "HIP 51077"},
        {"Geneva Identification System", "GEN# +1.00090518"},
        {"Smithsonian Astrophysical Observation", "SAO 222047"},
        {"Wilson Evans Batten Catalogue", "WEB 9338"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.54127857),
        dec: Angle.Degrees(-42.73839839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35138"},
        {"Hipparcos Number", "HIP 24935"},
        {"Smithsonian Astrophysical Observation", "SAO 217291"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13672855),
        dec: Angle.Degrees(-42.73690103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101539"},
        {"Hipparcos Number", "HIP 56984"},
        {"Geneva Identification System", "GEN# +1.00101539"},
        {"Smithsonian Astrophysical Observation", "SAO 222954"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.21951327),
        dec: Angle.Degrees(-42.73660812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219264"},
        {"Hipparcos Number", "HIP 114772"},
        {"Smithsonian Astrophysical Observation", "SAO 231509"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.73838639),
        dec: Angle.Degrees(-42.73357235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163559"},
        {"Hipparcos Number", "HIP 88023"},
        {"Smithsonian Astrophysical Observation", "SAO 228593"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.69076273),
        dec: Angle.Degrees(-42.73001430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160928"},
        {"Hipparcos Number", "HIP 86847"},
        {"Celescope Catalog", "CEL 4562"},
        {"Geneva Identification System", "GEN# +1.00160928J"},
        {"Smithsonian Astrophysical Observation", "SAO 228363"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.17502411),
        dec: Angle.Degrees(-42.72930009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24249"},
        {"Hipparcos Number", "HIP 17912"},
        {"Geneva Identification System", "GEN# +1.00024249"},
        {"Smithsonian Astrophysical Observation", "SAO 216509"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.45561491),
        dec: Angle.Degrees(-42.72758216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37762"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.15951980),
        dec: Angle.Degrees(-42.72664663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209430"},
        {"Hipparcos Number", "HIP 108946"},
        {"Renson", "Renson 58270"},
        {"Smithsonian Astrophysical Observation", "SAO 230965"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07976686),
        dec: Angle.Degrees(-42.72452962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89382"},
        {"Hipparcos Number", "HIP 50441"},
        {"Smithsonian Astrophysical Observation", "SAO 221939"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.47788642),
        dec: Angle.Degrees(-42.72329624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96859"},
        {"Hipparcos Number", "HIP 54473"},
        {"Smithsonian Astrophysical Observation", "SAO 222593"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.17305063),
        dec: Angle.Degrees(-42.72258978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120076"},
        {"Hipparcos Number", "HIP 67340"},
        {"Smithsonian Astrophysical Observation", "SAO 224438"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.03047886),
        dec: Angle.Degrees(-42.72133557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148172"},
        {"Hipparcos Number", "HIP 80664"},
        {"Smithsonian Astrophysical Observation", "SAO 226790"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.03451397),
        dec: Angle.Degrees(-42.71960920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87646"},
        {"Celescope Catalog", "CEL 4577"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.53927910),
        dec: Angle.Degrees(-42.71652575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37551"},
        {"Hipparcos Number", "HIP 26401"},
        {"Smithsonian Astrophysical Observation", "SAO 217431"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.30379718),
        dec: Angle.Degrees(-42.71543481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48969"},
        {"Hipparcos Number", "HIP 32251"},
        {"Geneva Identification System", "GEN# +1.00048969"},
        {"Smithsonian Astrophysical Observation", "SAO 218162"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.00598706),
        dec: Angle.Degrees(-42.71505973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 215.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12904"},
        {"Hipparcos Number", "HIP 9735"},
        {"Geneva Identification System", "GEN# +1.00012904"},
        {"Renson", "Renson 3300"},
        {"Smithsonian Astrophysical Observation", "SAO 215762"},
        {"Wilson Evans Batten Catalogue", "WEB 2047"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.31076250),
        dec: Angle.Degrees(-42.71406067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205756"},
        {"Hipparcos Number", "HIP 106866"},
        {"Smithsonian Astrophysical Observation", "SAO 230767"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.66907944),
        dec: Angle.Degrees(-42.71095425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175219"},
        {"Hipparcos Number", "HIP 92953"},
        {"Geneva Identification System", "GEN# +1.00175219"},
        {"Smithsonian Astrophysical Observation", "SAO 229383"},
        {"Wilson Evans Batten Catalogue", "WEB 16098"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.07071918),
        dec: Angle.Degrees(-42.71060161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146550"},
        {"Hipparcos Number", "HIP 79913"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.67296107),
        dec: Angle.Degrees(-42.70825807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77684"},
        {"Hipparcos Number", "HIP 44395"},
        {"Celescope Catalog", "CEL 3158"},
        {"Geneva Identification System", "GEN# +1.00077684"},
        {"Smithsonian Astrophysical Observation", "SAO 220772"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.64824901),
        dec: Angle.Degrees(-42.70737011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9283"},
        {"Henry Draper 2", "HD 9283A"},
        {"Hipparcos Number", "HIP 7024"},
        {"Geneva Identification System", "GEN# +1.00009283"},
        {"Smithsonian Astrophysical Observation", "SAO 215532"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.62845761),
        dec: Angle.Degrees(-42.70686740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58588"},
        {"Hipparcos Number", "HIP 35924"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.07571848),
        dec: Angle.Degrees(-42.70635166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37894"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50243719),
        dec: Angle.Degrees(-42.70324332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121834"},
        {"Hipparcos Number", "HIP 68300"},
        {"Smithsonian Astrophysical Observation", "SAO 224590"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.72167777),
        dec: Angle.Degrees(-42.70311499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117598"},
        {"Hipparcos Number", "HIP 66021"},
        {"Geneva Identification System", "GEN# +1.00117598"},
        {"Smithsonian Astrophysical Observation", "SAO 224224"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.03754132),
        dec: Angle.Degrees(-42.70311458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161563"},
        {"Hipparcos Number", "HIP 87148"},
        {"Smithsonian Astrophysical Observation", "SAO 228433"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.07732725),
        dec: Angle.Degrees(-42.70263874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69045"},
        {"Hipparcos Number", "HIP 40260"},
        {"Smithsonian Astrophysical Observation", "SAO 219620"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.33526287),
        dec: Angle.Degrees(-42.70014960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143463"},
        {"Hipparcos Number", "HIP 78547"},
        {"Geneva Identification System", "GEN# +1.00143463"},
        {"Smithsonian Astrophysical Observation", "SAO 226457"},
        {"Wilson Evans Batten Catalogue", "WEB 13277"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.54318470),
        dec: Angle.Degrees(-42.69981812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114707"},
        {"Hipparcos Number", "HIP 64472"},
        {"Geneva Identification System", "GEN# +1.00114707"},
        {"Smithsonian Astrophysical Observation", "SAO 223980"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.21191296),
        dec: Angle.Degrees(-42.69971196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211133"},
        {"Hipparcos Number", "HIP 109932"},
        {"Smithsonian Astrophysical Observation", "SAO 231058"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.98575938),
        dec: Angle.Degrees(-42.69704365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274255"},
        {"Hipparcos Number", "HIP 25775"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.55823834),
        dec: Angle.Degrees(-42.69697908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29291"},
    },
    visualMagnitude: 11.46,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.63137466),
        dec: Angle.Degrees(-42.69498647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 243.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154645"},
        {"Hipparcos Number", "HIP 83882"},
        {"Geneva Identification System", "GEN# +1.00154645"},
        {"Renson", "Renson 43690"},
        {"Smithsonian Astrophysical Observation", "SAO 227666"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.16757038),
        dec: Angle.Degrees(-42.69471425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214624"},
        {"Hipparcos Number", "HIP 111906"},
        {"Smithsonian Astrophysical Observation", "SAO 231241"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.02051752),
        dec: Angle.Degrees(-42.69127123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12239"},
        {"Hipparcos Number", "HIP 9270"},
        {"Smithsonian Astrophysical Observation", "SAO 215723"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.77869225),
        dec: Angle.Degrees(-42.69126172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219369"},
        {"Hipparcos Number", "HIP 114837"},
        {"Smithsonian Astrophysical Observation", "SAO 231520"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92239058),
        dec: Angle.Degrees(-42.69053276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89166"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.95101865),
        dec: Angle.Degrees(-42.69013305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92081"},
        {"Hipparcos Number", "HIP 51972"},
        {"Smithsonian Astrophysical Observation", "SAO 222196"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.29114166),
        dec: Angle.Degrees(-42.68566007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221736"},
        {"Hipparcos Number", "HIP 116370"},
        {"Smithsonian Astrophysical Observation", "SAO 231672"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.70976800),
        dec: Angle.Degrees(-42.68429061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71841"},
    },
    visualMagnitude: 10.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.43638033),
        dec: Angle.Degrees(-42.68409520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201993"},
        {"Hipparcos Number", "HIP 104868"},
        {"Smithsonian Astrophysical Observation", "SAO 230590"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.64416049),
        dec: Angle.Degrees(-42.68328066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188741"},
        {"Hipparcos Number", "HIP 98305"},
        {"Fundamental Katalog 5th Edition", "FK5 5760"},
        {"Smithsonian Astrophysical Observation", "SAO 229956"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.60939929),
        dec: Angle.Degrees(-42.68295540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119326"},
        {"Hipparcos Number", "HIP 66962"},
        {"Smithsonian Astrophysical Observation", "SAO 224364"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.86507559),
        dec: Angle.Degrees(-42.68198785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193112"},
        {"Hipparcos Number", "HIP 100270"},
        {"Smithsonian Astrophysical Observation", "SAO 230159"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.06950948),
        dec: Angle.Degrees(-42.67983244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169502"},
        {"Hipparcos Number", "HIP 90416"},
        {"Smithsonian Astrophysical Observation", "SAO 229025"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.73149468),
        dec: Angle.Degrees(-42.67969015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124404"},
        {"Hipparcos Number", "HIP 69583"},
        {"Smithsonian Astrophysical Observation", "SAO 224786"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.64506728),
        dec: Angle.Degrees(-42.67930197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22863"},
        {"Hipparcos Number", "HIP 16994"},
        {"Smithsonian Astrophysical Observation", "SAO 216422"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.64277796),
        dec: Angle.Degrees(-42.67901651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202871"},
        {"Hipparcos Number", "HIP 105327"},
        {"Geneva Identification System", "GEN# +1.00202871"},
        {"Smithsonian Astrophysical Observation", "SAO 230634"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.01988230),
        dec: Angle.Degrees(-42.67864677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5510"},
        {"Hipparcos Number", "HIP 4392"},
        {"Geneva Identification System", "GEN# +1.00005510"},
        {"Smithsonian Astrophysical Observation", "SAO 215293"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.06747159),
        dec: Angle.Degrees(-42.67850115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56001"},
        {"Renson", "Renson 28700"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.14730399),
        dec: Angle.Degrees(-42.67775852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96067"},
        {"Hipparcos Number", "HIP 54116"},
        {"Smithsonian Astrophysical Observation", "SAO 222536"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.09979843),
        dec: Angle.Degrees(-42.67756919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27655"},
        {"Hipparcos Number", "HIP 20213"},
        {"Smithsonian Astrophysical Observation", "SAO 216754"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97630331),
        dec: Angle.Degrees(-42.67644534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4293"},
        {"Hipparcos Number", "HIP 3521"},
        {"Fundamental Katalog 5th Edition", "FK5 1017"},
        {"Geneva Identification System", "GEN# +1.00004293"},
        {"Smithsonian Astrophysical Observation", "SAO 215221"},
        {"Wilson Evans Batten Catalogue", "WEB 622"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.23801546),
        dec: Angle.Degrees(-42.67632489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87467"},
        {"Hipparcos Number", "HIP 49332"},
        {"Geneva Identification System", "GEN# +1.00087467"},
        {"Smithsonian Astrophysical Observation", "SAO 221746"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.04352152),
        dec: Angle.Degrees(-42.67618510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186783"},
        {"Hipparcos Number", "HIP 97449"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.10415487),
        dec: Angle.Degrees(-42.67563881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46083"},
        {"Hipparcos Number", "HIP 30896"},
        {"Smithsonian Astrophysical Observation", "SAO 217962"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.28577872),
        dec: Angle.Degrees(-42.67447188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99803"},
        {"Hipparcos Number", "HIP 56000"},
        {"Geneva Identification System", "GEN# +1.00099803A"},
        {"Geneva Identification System 2", "GEN# +1.00099803J"},
        {"Smithsonian Astrophysical Observation", "SAO 222813"},
        {"Wilson Evans Batten Catalogue", "WEB 10055"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.14627993),
        dec: Angle.Degrees(-42.67421801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146667"},
        {"Hipparcos Number", "HIP 79963"},
        {"Geneva Identification System", "GEN# +1.00146667"},
        {"Renson", "Renson 41450"},
        {"Smithsonian Astrophysical Observation", "SAO 226650"},
        {"Wilson Evans Batten Catalogue", "WEB 13535"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.82350183),
        dec: Angle.Degrees(-42.67394008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20310"},
        {"Hipparcos Number", "HIP 15079"},
        {"Smithsonian Astrophysical Observation", "SAO 216224"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.60552924),
        dec: Angle.Degrees(-42.67299750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223678"},
        {"Hipparcos Number", "HIP 117665"},
        {"Smithsonian Astrophysical Observation", "SAO 231815"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.94387045),
        dec: Angle.Degrees(-42.67290968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1189"},
        {"Hipparcos Number", "HIP 1279"},
        {"Smithsonian Astrophysical Observation", "SAO 215025"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.01066071),
        dec: Angle.Degrees(-42.67102048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47407"},
        {"Hipparcos Number", "HIP 31556"},
        {"Smithsonian Astrophysical Observation", "SAO 218054"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.07964878),
        dec: Angle.Degrees(-42.67041943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97194"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31038197),
        dec: Angle.Degrees(-42.67030590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53660"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.67284062),
        dec: Angle.Degrees(-42.66936518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99171"},
        {"Hipparcos Number", "HIP 55667"},
        {"Fundamental Katalog 5th Edition", "FK5 1294"},
        {"Geneva Identification System", "GEN# +1.00099171"},
        {"Smithsonian Astrophysical Observation", "SAO 222773"},
        {"Wilson Evans Batten Catalogue", "WEB 10008"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.09191996),
        dec: Angle.Degrees(-42.66910033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26786"},
        {"Hipparcos Number", "HIP 19635"},
        {"Smithsonian Astrophysical Observation", "SAO 216693"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.10817665),
        dec: Angle.Degrees(-42.66739641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130134"},
        {"Hipparcos Number", "HIP 72359"},
        {"Smithsonian Astrophysical Observation", "SAO 225188"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.93963660),
        dec: Angle.Degrees(-42.66738272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57252"},
    },
    visualMagnitude: 12.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.09140022),
        dec: Angle.Degrees(-42.66179410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156661"},
        {"Hipparcos Number", "HIP 84879"},
        {"Smithsonian Astrophysical Observation", "SAO 227845"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.20312640),
        dec: Angle.Degrees(-42.65841158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165617"},
        {"Hipparcos Number", "HIP 88903"},
        {"Geneva Identification System", "GEN# +1.00165617"},
        {"Smithsonian Astrophysical Observation", "SAO 228742"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22310060),
        dec: Angle.Degrees(-42.65702459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199757"},
        {"Hipparcos Number", "HIP 103684"},
        {"Geneva Identification System", "GEN# +1.00199757"},
        {"Smithsonian Astrophysical Observation", "SAO 230477"},
        {"Wilson Evans Batten Catalogue", "WEB 18871"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.14666699),
        dec: Angle.Degrees(-42.65559453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156674"},
        {"Hipparcos Number", "HIP 84885"},
        {"Geneva Identification System", "GEN# +1.00156674"},
        {"Smithsonian Astrophysical Observation", "SAO 227846"},
        {"Wilson Evans Batten Catalogue", "WEB 14334"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.22368689),
        dec: Angle.Degrees(-42.65279526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3667"},
        {"Hipparcos Number", "HIP 3081"},
        {"Smithsonian Astrophysical Observation", "SAO 215183"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.78437250),
        dec: Angle.Degrees(-42.65200076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40053"},
        {"Hipparcos Number", "HIP 27910"},
        {"Geneva Identification System", "GEN# +1.00040053"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.58836513),
        dec: Angle.Degrees(-42.65192603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100626"},
        {"Hipparcos Number", "HIP 56455"},
        {"Smithsonian Astrophysical Observation", "SAO 222878"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.63172203),
        dec: Angle.Degrees(-42.65006074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18150"},
        {"Hipparcos Number", "HIP 13469"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.37070453),
        dec: Angle.Degrees(-42.65000592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74772"},
        {"Hipparcos Number", "HIP 42884"},
        {"Smithsonian Astrophysical Observation", "SAO 220371"},
        {"Wilson Evans Batten Catalogue", "WEB 8286"},
    },
    visualMagnitude: 4.05,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.09985828),
        dec: Angle.Degrees(-42.64932331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28431"},
        {"Hipparcos Number", "HIP 20786"},
        {"Smithsonian Astrophysical Observation", "SAO 216808"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.78380022),
        dec: Angle.Degrees(-42.64532380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188031"},
        {"Hipparcos Number", "HIP 98002"},
        {"Geneva Identification System", "GEN# +1.00188031"},
        {"Wilson Evans Batten Catalogue", "WEB 17254"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.74438166),
        dec: Angle.Degrees(-42.64433693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -435.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6896"},
        {"Hipparcos Number", "HIP 5392"},
        {"Geneva Identification System", "GEN# +1.00006896"},
        {"Smithsonian Astrophysical Observation", "SAO 215381"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.25283286),
        dec: Angle.Degrees(-42.64395334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93412"},
        {"Hipparcos Number", "HIP 52694"},
        {"Geneva Identification System", "GEN# +1.00093412"},
        {"Smithsonian Astrophysical Observation", "SAO 222314"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.61388461),
        dec: Angle.Degrees(-42.64346325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78261"},
        {"Hipparcos Number", "HIP 44641"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.44632015),
        dec: Angle.Degrees(-42.64333061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5062"},
        {"Hipparcos Number", "HIP 4057"},
        {"Geneva Identification System", "GEN# +1.00005062"},
        {"Smithsonian Astrophysical Observation", "SAO 215271"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.98651881),
        dec: Angle.Degrees(-42.64312018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20723"},
        {"Hipparcos Number", "HIP 15407"},
        {"Smithsonian Astrophysical Observation", "SAO 216254"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.66178847),
        dec: Angle.Degrees(-42.64212426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68242"},
        {"Henry Draper 2", "HD 68242A"},
        {"Hipparcos Number", "HIP 39974"},
        {"Geneva Identification System", "GEN# +1.00068242"},
        {"Smithsonian Astrophysical Observation", "SAO 219507"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.44875204),
        dec: Angle.Degrees(-42.64082338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201466"},
        {"Hipparcos Number", "HIP 104590"},
        {"Smithsonian Astrophysical Observation", "SAO 230566"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.80215035),
        dec: Angle.Degrees(-42.64026209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11023"},
        {"Hipparcos Number", "HIP 8322"},
        {"Geneva Identification System", "GEN# +1.00011023"},
        {"Smithsonian Astrophysical Observation", "SAO 215651"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.82531075),
        dec: Angle.Degrees(-42.63903224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96616"},
        {"Hipparcos Number", "HIP 54360"},
        {"Geneva Identification System", "GEN# +1.00096616"},
        {"Renson", "Renson 27860"},
        {"Smithsonian Astrophysical Observation", "SAO 222581"},
        {"Wilson Evans Batten Catalogue", "WEB 9818"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.81981683),
        dec: Angle.Degrees(-42.63878147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164915"},
        {"Hipparcos Number", "HIP 88603"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.36507297),
        dec: Angle.Degrees(-42.63779204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49753"},
        {"Hipparcos Number", "HIP 32580"},
        {"Geneva Identification System", "GEN# +1.00049753"},
        {"Smithsonian Astrophysical Observation", "SAO 218204"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.96805350),
        dec: Angle.Degrees(-42.63769423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139332"},
        {"Hipparcos Number", "HIP 76650"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.78224687),
        dec: Angle.Degrees(-42.63711529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161878"},
        {"Hipparcos Number", "HIP 87279"},
        {"Smithsonian Astrophysical Observation", "SAO 228463"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.50914339),
        dec: Angle.Degrees(-42.63549545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111354"},
        {"Hipparcos Number", "HIP 62562"},
        {"Geneva Identification System", "GEN# +1.00111354"},
        {"Smithsonian Astrophysical Observation", "SAO 223684"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.27947227),
        dec: Angle.Degrees(-42.63433649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21882"},
        {"Hipparcos Number", "HIP 16285"},
        {"Geneva Identification System", "GEN# +1.00021882"},
        {"Smithsonian Astrophysical Observation", "SAO 216347"},
        {"Wilson Evans Batten Catalogue", "WEB 3106"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.47997851),
        dec: Angle.Degrees(-42.63425261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74842"},
        {"Hipparcos Number", "HIP 42916"},
        {"Geneva Identification System", "GEN# +1.00074842"},
        {"Smithsonian Astrophysical Observation", "SAO 220383"},
        {"Wilson Evans Batten Catalogue", "WEB 8292"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.18738252),
        dec: Angle.Degrees(-42.63386077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -289.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171272"},
        {"Hipparcos Number", "HIP 91155"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.96088699),
        dec: Angle.Degrees(-42.63327868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72898"},
        {"Hipparcos Number", "HIP 42003"},
        {"Celescope Catalog", "CEL 2650"},
        {"Geneva Identification System", "GEN# +1.00072898"},
        {"Smithsonian Astrophysical Observation", "SAO 220104"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.41129548),
        dec: Angle.Degrees(-42.63313068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53252"},
        {"Hipparcos Number", "HIP 33922"},
        {"Celescope Catalog", "CEL 1530"},
        {"Geneva Identification System", "GEN# +1.00053252"},
        {"Smithsonian Astrophysical Observation", "SAO 218397"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.58591034),
        dec: Angle.Degrees(-42.63249966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213334"},
        {"Hipparcos Number", "HIP 111182"},
        {"Smithsonian Astrophysical Observation", "SAO 231178"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.84846579),
        dec: Angle.Degrees(-42.63153156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117383"},
        {"Hipparcos Number", "HIP 65906"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.65178786),
        dec: Angle.Degrees(-42.63068378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153578"},
        {"Hipparcos Number", "HIP 83358"},
        {"Smithsonian Astrophysical Observation", "SAO 227564"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.55645528),
        dec: Angle.Degrees(-42.62812481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50882"},
        {"Hipparcos Number", "HIP 33038"},
        {"Geneva Identification System", "GEN# +1.00050882"},
        {"Smithsonian Astrophysical Observation", "SAO 218280"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24858643),
        dec: Angle.Degrees(-42.62757810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27231"},
        {"Hipparcos Number", "HIP 19900"},
        {"Geneva Identification System", "GEN# +1.00027231"},
        {"Smithsonian Astrophysical Observation", "SAO 216727"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.03787480),
        dec: Angle.Degrees(-42.62599804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24989"},
        {"Hipparcos Number", "HIP 18429"},
        {"Smithsonian Astrophysical Observation", "SAO 216563"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11518868),
        dec: Angle.Degrees(-42.62596648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142709"},
        {"Hipparcos Number", "HIP 78170"},
        {"Geneva Identification System", "GEN# +1.00142709"},
        {"Smithsonian Astrophysical Observation", "SAO 226403"},
        {"Wilson Evans Batten Catalogue", "WEB 13219"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.42061616),
        dec: Angle.Degrees(-42.62377014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -256.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187539"},
        {"Hipparcos Number", "HIP 97793"},
        {"Smithsonian Astrophysical Observation", "SAO 229906"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.08623516),
        dec: Angle.Degrees(-42.62275373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26560"},
        {"Hipparcos Number", "HIP 19471"},
        {"Geneva Identification System", "GEN# +1.00026560"},
        {"Smithsonian Astrophysical Observation", "SAO 216679"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.55282119),
        dec: Angle.Degrees(-42.62244130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210162"},
        {"Hipparcos Number", "HIP 109371"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36646352),
        dec: Angle.Degrees(-42.62155180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87008"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67604278),
        dec: Angle.Degrees(-42.62043240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192826"},
        {"Hipparcos Number", "HIP 100123"},
        {"Geneva Identification System", "GEN# +1.00192826"},
        {"Smithsonian Astrophysical Observation", "SAO 230143"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.66303354),
        dec: Angle.Degrees(-42.62004714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194552"},
        {"Hipparcos Number", "HIP 100937"},
        {"Geneva Identification System", "GEN# +1.00194552"},
        {"Smithsonian Astrophysical Observation", "SAO 230222"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.98573085),
        dec: Angle.Degrees(-42.61983887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194570"},
        {"Hipparcos Number", "HIP 100941"},
        {"Geneva Identification System", "GEN# +1.00194570"},
        {"Smithsonian Astrophysical Observation", "SAO 230226"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.99911773),
        dec: Angle.Degrees(-42.61930238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116775"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.00056684),
        dec: Angle.Degrees(-42.61826818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141011"},
        {"Hipparcos Number", "HIP 77432"},
        {"Smithsonian Astrophysical Observation", "SAO 226229"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.10331627),
        dec: Angle.Degrees(-42.61798541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120761"},
        {"Hipparcos Number", "HIP 67717"},
        {"Smithsonian Astrophysical Observation", "SAO 224502"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.08296427),
        dec: Angle.Degrees(-42.61725201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30550"},
        {"Hipparcos Number", "HIP 22218"},
        {"Smithsonian Astrophysical Observation", "SAO 216992"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.68153835),
        dec: Angle.Degrees(-42.61713564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118043"},
        {"Hipparcos Number", "HIP 66276"},
        {"Geneva Identification System", "GEN# +1.00118043"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.75760194),
        dec: Angle.Degrees(-42.61611373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62469"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.03249333),
        dec: Angle.Degrees(-42.61573229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204205"},
        {"Hipparcos Number", "HIP 106010"},
        {"Smithsonian Astrophysical Observation", "SAO 230701"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.07362791),
        dec: Angle.Degrees(-42.61564553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34420"},
        {"Hipparcos Number", "HIP 24484"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.80289274),
        dec: Angle.Degrees(-42.61556427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221760"},
        {"Hipparcos Number", "HIP 116389"},
        {"Fundamental Katalog 5th Edition", "FK5 1617"},
        {"Renson", "Renson 60770"},
        {"Smithsonian Astrophysical Observation", "SAO 231675"},
        {"Wilson Evans Batten Catalogue", "WEB 20563"},
    },
    visualMagnitude: 4.69,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.76887742),
        dec: Angle.Degrees(-42.61510105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158057"},
        {"Hipparcos Number", "HIP 85552"},
        {"Smithsonian Astrophysical Observation", "SAO 228012"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.25766464),
        dec: Angle.Degrees(-42.61433709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132920"},
        {"Hipparcos Number", "HIP 73639"},
        {"Geneva Identification System", "GEN# +1.00132920"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.78681945),
        dec: Angle.Degrees(-42.61430059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -280.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97957"},
        {"Hipparcos Number", "HIP 54984"},
        {"Geneva Identification System", "GEN# +1.00097957"},
        {"Smithsonian Astrophysical Observation", "SAO 222678"},
        {"Wilson Evans Batten Catalogue", "WEB 9923"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.87846960),
        dec: Angle.Degrees(-42.61314999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93452"},
        {"Hipparcos Number", "HIP 52710"},
        {"Geneva Identification System", "GEN# +1.00093452"},
        {"Smithsonian Astrophysical Observation", "SAO 222319"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65621249),
        dec: Angle.Degrees(-42.61035751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37690"},
        {"Hipparcos Number", "HIP 26516"},
        {"Smithsonian Astrophysical Observation", "SAO 217443"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.57424138),
        dec: Angle.Degrees(-42.60945020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30908"},
        {"Hipparcos Number", "HIP 22430"},
        {"Smithsonian Astrophysical Observation", "SAO 217023"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.40194687),
        dec: Angle.Degrees(-42.60821284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165161"},
        {"Hipparcos Number", "HIP 88712"},
        {"Smithsonian Astrophysical Observation", "SAO 228704"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.65465327),
        dec: Angle.Degrees(-42.60670617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52096"},
        {"Hipparcos Number", "HIP 33502"},
        {"Smithsonian Astrophysical Observation", "SAO 218342"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.45567545),
        dec: Angle.Degrees(-42.60652304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161825"},
        {"Hipparcos Number", "HIP 87255"},
        {"Smithsonian Astrophysical Observation", "SAO 228458"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.43697972),
        dec: Angle.Degrees(-42.60527346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142254"},
        {"Hipparcos Number", "HIP 77958"},
        {"Geneva Identification System", "GEN# +1.00142254"},
        {"Smithsonian Astrophysical Observation", "SAO 226361"},
        {"Wilson Evans Batten Catalogue", "WEB 13183"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.81665788),
        dec: Angle.Degrees(-42.60503326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77166"},
        {"Hipparcos Number", "HIP 44136"},
        {"Celescope Catalog", "CEL 3129"},
        {"Geneva Identification System", "GEN# +1.00077166"},
        {"Smithsonian Astrophysical Observation", "SAO 220720"},
    },
    visualMagnitude: 9.29,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.84249754),
        dec: Angle.Degrees(-42.60182781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33614"},
        {"Hipparcos Number", "HIP 23992"},
        {"Smithsonian Astrophysical Observation", "SAO 217203"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.35503246),
        dec: Angle.Degrees(-42.60149836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168634"},
        {"Hipparcos Number", "HIP 90065"},
        {"Smithsonian Astrophysical Observation", "SAO 228960"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.69685975),
        dec: Angle.Degrees(-42.60128093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123431"},
        {"Hipparcos Number", "HIP 69104"},
        {"Geneva Identification System", "GEN# +1.00123431"},
        {"Smithsonian Astrophysical Observation", "SAO 224719"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.18483603),
        dec: Angle.Degrees(-42.59866039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4262"},
        {"Hipparcos Number", "HIP 3492"},
        {"Smithsonian Astrophysical Observation", "SAO 215220"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.15176164),
        dec: Angle.Degrees(-42.59860543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172302"},
        {"Hipparcos Number", "HIP 91654"},
        {"Smithsonian Astrophysical Observation", "SAO 229197"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.35855519),
        dec: Angle.Degrees(-42.59839593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27824"},
        {"Hipparcos Number", "HIP 20365"},
        {"Smithsonian Astrophysical Observation", "SAO 216763"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.42311510),
        dec: Angle.Degrees(-42.59834739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74370"},
        {"Hipparcos Number", "HIP 42685"},
        {"Smithsonian Astrophysical Observation", "SAO 220299"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.50042979),
        dec: Angle.Degrees(-42.59769723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182584"},
        {"Hipparcos Number", "HIP 95636"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.80556987),
        dec: Angle.Degrees(-42.59729533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11263"},
        {"Hipparcos Number", "HIP 8511"},
        {"Smithsonian Astrophysical Observation", "SAO 215670"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.43658115),
        dec: Angle.Degrees(-42.59727042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82899"},
        {"Hipparcos Number", "HIP 46906"},
        {"Smithsonian Astrophysical Observation", "SAO 221284"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.38928970),
        dec: Angle.Degrees(-42.59441936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74289"},
        {"Hipparcos Number", "HIP 42655"},
        {"Geneva Identification System", "GEN# +1.00074289"},
        {"Smithsonian Astrophysical Observation", "SAO 220291"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.39749921),
        dec: Angle.Degrees(-42.59249314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141702"},
        {"Hipparcos Number", "HIP 77727"},
        {"Geneva Identification System", "GEN# +1.00141702"},
        {"Smithsonian Astrophysical Observation", "SAO 226310"},
        {"Wilson Evans Batten Catalogue", "WEB 13150"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.03685624),
        dec: Angle.Degrees(-42.59126307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125007"},
        {"Hipparcos Number", "HIP 69871"},
        {"Geneva Identification System", "GEN# +1.00125007"},
        {"Smithsonian Astrophysical Observation", "SAO 224823"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.47119107),
        dec: Angle.Degrees(-42.59120840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171000"},
        {"Hipparcos Number", "HIP 91040"},
        {"Geneva Identification System", "GEN# +1.00171000"},
        {"Smithsonian Astrophysical Observation", "SAO 229117"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.57546660),
        dec: Angle.Degrees(-42.59071525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219380"},
        {"Hipparcos Number", "HIP 114847"},
        {"Smithsonian Astrophysical Observation", "SAO 231521"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.94614736),
        dec: Angle.Degrees(-42.58763632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72014"},
        {"Hipparcos Number", "HIP 41599"},
        {"Celescope Catalog", "CEL 2553"},
        {"Geneva Identification System", "GEN# +1.00072014A"},
        {"Smithsonian Astrophysical Observation", "SAO 219977"},
        {"Wilson Evans Batten Catalogue", "WEB 8029"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.21694699),
        dec: Angle.Degrees(-42.58749881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198633"},
        {"Hipparcos Number", "HIP 103076"},
        {"Smithsonian Astrophysical Observation", "SAO 230416"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.27118264),
        dec: Angle.Degrees(-42.58588361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84992"},
        {"Hipparcos Number", "HIP 48058"},
        {"Smithsonian Astrophysical Observation", "SAO 221494"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.95182356),
        dec: Angle.Degrees(-42.58144033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81987"},
        {"Hipparcos Number", "HIP 46402"},
        {"Smithsonian Astrophysical Observation", "SAO 221183"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.94342989),
        dec: Angle.Degrees(-42.57835356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113441"},
        {"Hipparcos Number", "HIP 63769"},
        {"Smithsonian Astrophysical Observation", "SAO 223875"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.06590226),
        dec: Angle.Degrees(-42.57738056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172877"},
        {"Hipparcos Number", "HIP 91947"},
        {"Smithsonian Astrophysical Observation", "SAO 229237"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.14255726),
        dec: Angle.Degrees(-42.57707295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101761"},
        {"Hipparcos Number", "HIP 57110"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.61799515),
        dec: Angle.Degrees(-42.57665457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166724"},
        {"Hipparcos Number", "HIP 89354"},
        {"Geneva Identification System", "GEN# +1.00166724"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.49852847),
        dec: Angle.Degrees(-42.57518256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6578"},
        {"Hipparcos Number", "HIP 5171"},
        {"Geneva Identification System", "GEN# +1.00006578"},
        {"Smithsonian Astrophysical Observation", "SAO 215366"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.53324309),
        dec: Angle.Degrees(-42.57431763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136148"},
        {"Hipparcos Number", "HIP 75073"},
        {"Smithsonian Astrophysical Observation", "SAO 225671"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.11925973),
        dec: Angle.Degrees(-42.57277325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132153"},
        {"Hipparcos Number", "HIP 73328"},
        {"Smithsonian Astrophysical Observation", "SAO 225342"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.76386022),
        dec: Angle.Degrees(-42.57200071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48676"},
        {"Hipparcos Number", "HIP 32111"},
        {"Geneva Identification System", "GEN# +1.00048676"},
        {"Smithsonian Astrophysical Observation", "SAO 218138"},
        {"Wilson Evans Batten Catalogue", "WEB 6484"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.61289996),
        dec: Angle.Degrees(-42.57157797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20805"},
        {"Hipparcos Number", "HIP 15475"},
        {"Geneva Identification System", "GEN# +1.00020805"},
        {"Smithsonian Astrophysical Observation", "SAO 216258"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.88024631),
        dec: Angle.Degrees(-42.57054350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179298"},
        {"Hipparcos Number", "HIP 94492"},
        {"Smithsonian Astrophysical Observation", "SAO 229570"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.48942788),
        dec: Angle.Degrees(-42.56960542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18239"},
        {"Hipparcos Number", "HIP 13535"},
        {"Geneva Identification System", "GEN# +1.00018239"},
        {"Smithsonian Astrophysical Observation", "SAO 216090"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.58157506),
        dec: Angle.Degrees(-42.56839053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10"},
        {"Hipparcos Number", "HIP 419"},
        {"Smithsonian Astrophysical Observation", "SAO 214955"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.27871117),
        dec: Angle.Degrees(-42.56781669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139127"},
        {"Hipparcos Number", "HIP 76552"},
        {"Fundamental Katalog 5th Edition", "FK5 3232"},
        {"Geneva Identification System", "GEN# +1.00139127A"},
        {"Smithsonian Astrophysical Observation", "SAO 226004"},
        {"Wilson Evans Batten Catalogue", "WEB 12994"},
    },
    visualMagnitude: 4.34,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.51384287),
        dec: Angle.Degrees(-42.56748493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62560"},
        {"Hipparcos Number", "HIP 37577"},
        {"Celescope Catalog", "CEL 1994"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.67072490),
        dec: Angle.Degrees(-42.56745535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24331"},
        {"Hipparcos Number", "HIP 17978"},
        {"Cincinnati Publication", "Ci 20 266"},
        {"Cincinnati Publication 2", "Ci 18 523"},
        {"Geneva Identification System", "GEN# +1.00024331"},
        {"Smithsonian Astrophysical Observation", "SAO 216515"},
        {"Wilson Evans Batten Catalogue", "WEB 3466"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64721409),
        dec: Angle.Degrees(-42.56704861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 622.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8092"},
        {"Hipparcos Number", "HIP 6214"},
        {"Smithsonian Astrophysical Observation", "SAO 215461"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.91892091),
        dec: Angle.Degrees(-42.56689083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159656"},
        {"Hipparcos Number", "HIP 86289"},
        {"Cincinnati Publication", "Ci 20 1047"},
        {"Geneva Identification System", "GEN# +1.00159656"},
        {"Smithsonian Astrophysical Observation", "SAO 228216"},
        {"Wilson Evans Batten Catalogue", "WEB 14557"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.47416140),
        dec: Angle.Degrees(-42.56669599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -357.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173183"},
        {"Hipparcos Number", "HIP 92085"},
        {"Geneva Identification System", "GEN# +1.00173183"},
        {"Smithsonian Astrophysical Observation", "SAO 229260"},
        {"Wilson Evans Batten Catalogue", "WEB 15871"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51467453),
        dec: Angle.Degrees(-42.56633780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75126"},
        {"Hipparcos Number", "HIP 43085"},
        {"Celescope Catalog", "CEL 2889"},
        {"Geneva Identification System", "GEN# +4.35100003J"},
        {"Smithsonian Astrophysical Observation", "SAO 220439"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.63795777),
        dec: Angle.Degrees(-42.56628109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170626"},
        {"Hipparcos Number", "HIP 90892"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.10167214),
        dec: Angle.Degrees(-42.56478921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142508"},
        {"Hipparcos Number", "HIP 78085"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.16337091),
        dec: Angle.Degrees(-42.56304787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107422"},
        {"Hipparcos Number", "HIP 60235"},
        {"Geneva Identification System", "GEN# +1.00107422J"},
        {"Smithsonian Astrophysical Observation", "SAO 223366"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.27748556),
        dec: Angle.Degrees(-42.56198865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4751"},
        {"Hipparcos Number", "HIP 3820"},
        {"Geneva Identification System", "GEN# +1.00004751"},
        {"Smithsonian Astrophysical Observation", "SAO 215246"},
        {"Wilson Evans Batten Catalogue", "WEB 679"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.26587361),
        dec: Angle.Degrees(-42.56177739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119655"},
        {"Hipparcos Number", "HIP 67121"},
        {"Geneva Identification System", "GEN# +1.00119655"},
        {"Smithsonian Astrophysical Observation", "SAO 224397"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.34622278),
        dec: Angle.Degrees(-42.56132512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112818"},
        {"Hipparcos Number", "HIP 63426"},
        {"Smithsonian Astrophysical Observation", "SAO 223819"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.96668699),
        dec: Angle.Degrees(-42.56107867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220427"},
        {"Hipparcos Number", "HIP 115509"},
        {"Smithsonian Astrophysical Observation", "SAO 231588"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.97466530),
        dec: Angle.Degrees(-42.56099349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73218"},
        {"Hipparcos Number", "HIP 42157"},
        {"Celescope Catalog", "CEL 2686"},
        {"Geneva Identification System", "GEN# +1.00073218"},
        {"Smithsonian Astrophysical Observation", "SAO 220155"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.90500798),
        dec: Angle.Degrees(-42.56047985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182731"},
        {"Hipparcos Number", "HIP 95701"},
        {"Smithsonian Astrophysical Observation", "SAO 229691"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.97636799),
        dec: Angle.Degrees(-42.56033380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 307"},
        {"Geneva Identification System", "GEN# +6.20145150"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.97971157),
        dec: Angle.Degrees(-42.55949968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46625"},
        {"Hipparcos Number", "HIP 31163"},
        {"Renson", "Renson 12480"},
        {"Smithsonian Astrophysical Observation", "SAO 218000"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08597221),
        dec: Angle.Degrees(-42.55942533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73676"},
        {"Hipparcos Number", "HIP 42335"},
        {"Smithsonian Astrophysical Observation", "SAO 220210"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.46982764),
        dec: Angle.Degrees(-42.55925697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126952"},
        {"Hipparcos Number", "HIP 70896"},
        {"Smithsonian Astrophysical Observation", "SAO 224966"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.46368105),
        dec: Angle.Degrees(-42.55625618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71123"},
        {"Hipparcos Number", "HIP 41162"},
        {"Celescope Catalog", "CEL 2467"},
        {"Geneva Identification System", "GEN# +1.00071123"},
        {"Smithsonian Astrophysical Observation", "SAO 219873"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.97706826),
        dec: Angle.Degrees(-42.55497733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30424"},
        {"Hipparcos Number", "HIP 22114"},
        {"Smithsonian Astrophysical Observation", "SAO 216980"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.39574418),
        dec: Angle.Degrees(-42.55434386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123094"},
        {"Hipparcos Number", "HIP 68929"},
        {"Smithsonian Astrophysical Observation", "SAO 224683"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.66939467),
        dec: Angle.Degrees(-42.55316544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91256",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91256"},
    },
    visualMagnitude: 11.04,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)36, 49.3400),
        dec: Angle.DegreesMinutesSeconds((int)-42, (int)33, 09.400)
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
    primaryId: "HIP 104012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200345"},
        {"Hipparcos Number", "HIP 104012"},
        {"Smithsonian Astrophysical Observation", "SAO 230505"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.08551249),
        dec: Angle.Degrees(-42.55115177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65090"},
        {"Hipparcos Number", "HIP 38689"},
        {"Smithsonian Astrophysical Observation", "SAO 219145"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.81067037),
        dec: Angle.Degrees(-42.54944480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28688"},
        {"Hipparcos Number", "HIP 20945"},
        {"Smithsonian Astrophysical Observation", "SAO 216831"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.36019862),
        dec: Angle.Degrees(-42.54824754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204018"},
        {"Hipparcos Number", "HIP 105913"},
        {"Geneva Identification System", "GEN# +1.00204018"},
        {"Renson", "Renson 56810"},
        {"Smithsonian Astrophysical Observation", "SAO 230692"},
        {"Wilson Evans Batten Catalogue", "WEB 19205"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.75692385),
        dec: Angle.Degrees(-42.54796563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158023"},
        {"Hipparcos Number", "HIP 85536"},
        {"Smithsonian Astrophysical Observation", "SAO 228007"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.20625492),
        dec: Angle.Degrees(-42.54603022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106537"},
        {"Hipparcos Number", "HIP 59768"},
        {"Smithsonian Astrophysical Observation", "SAO 223308"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.83818568),
        dec: Angle.Degrees(-42.54083963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218143"},
        {"Hipparcos Number", "HIP 114067"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.53011463),
        dec: Angle.Degrees(-42.54069107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7453"},
        {"Hipparcos Number", "HIP 5767"},
        {"Smithsonian Astrophysical Observation", "SAO 215420"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.51467329),
        dec: Angle.Degrees(-42.53834132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114303"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.23725924),
        dec: Angle.Degrees(-42.53409412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210638"},
        {"Hipparcos Number", "HIP 109648"},
        {"Renson", "Renson 58550"},
        {"Smithsonian Astrophysical Observation", "SAO 231030"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.18678758),
        dec: Angle.Degrees(-42.53403432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215585"},
        {"Hipparcos Number", "HIP 112459"},
        {"Smithsonian Astrophysical Observation", "SAO 231293"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70229713),
        dec: Angle.Degrees(-42.53307712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7795"},
        {"Hipparcos Number", "HIP 5988"},
        {"Geneva Identification System", "GEN# +1.00007795"},
        {"Smithsonian Astrophysical Observation", "SAO 215438"},
        {"Wilson Evans Batten Catalogue", "WEB 1358"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.25327093),
        dec: Angle.Degrees(-42.53267883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16989"},
        {"Hipparcos Number", "HIP 12614"},
        {"Smithsonian Astrophysical Observation", "SAO 216011"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.53874704),
        dec: Angle.Degrees(-42.53221387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116324"},
        {"Hipparcos Number", "HIP 65348"},
        {"Smithsonian Astrophysical Observation", "SAO 224102"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.90124952),
        dec: Angle.Degrees(-42.53136069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63828"},
        {"Hipparcos Number", "HIP 38145"},
        {"Smithsonian Astrophysical Observation", "SAO 219026"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.25504723),
        dec: Angle.Degrees(-42.52675138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70195"},
        {"Hipparcos Number", "HIP 40735"},
        {"Geneva Identification System", "GEN# +1.00070195"},
        {"Smithsonian Astrophysical Observation", "SAO 219772"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.72386292),
        dec: Angle.Degrees(-42.52673858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76954"},
        {"Hipparcos Number", "HIP 44019"},
        {"Celescope Catalog", "CEL 3110"},
        {"Geneva Identification System", "GEN# +1.00076954"},
        {"Smithsonian Astrophysical Observation", "SAO 220699"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.47237662),
        dec: Angle.Degrees(-42.52499086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87749"},
        {"Hipparcos Number", "HIP 49475"},
        {"Geneva Identification System", "GEN# +1.00087749"},
        {"Smithsonian Astrophysical Observation", "SAO 221771"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.51697753),
        dec: Angle.Degrees(-42.52486222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71607"},
        {"Hipparcos Number", "HIP 41391"},
        {"Celescope Catalog", "CEL 2514"},
        {"Geneva Identification System", "GEN# +1.00071607"},
        {"Smithsonian Astrophysical Observation", "SAO 219924"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.66878820),
        dec: Angle.Degrees(-42.52417623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327154"},
        {"Hipparcos Number", "HIP 84466"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.02248025),
        dec: Angle.Degrees(-42.52396076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21959"},
        {"Hipparcos Number", "HIP 16345"},
        {"Smithsonian Astrophysical Observation", "SAO 216356"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.65997483),
        dec: Angle.Degrees(-42.52209125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69882"},
        {"Hipparcos Number", "HIP 40596"},
        {"Celescope Catalog", "CEL 2318"},
        {"Geneva Identification System", "GEN# +1.00069882"},
        {"Smithsonian Astrophysical Observation", "SAO 219733"},
        {"Wilson Evans Batten Catalogue", "WEB 7895"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.32342869),
        dec: Angle.Degrees(-42.52154432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74877"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54166608),
        dec: Angle.Degrees(-42.51982722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194901"},
        {"Hipparcos Number", "HIP 101113"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.43650451),
        dec: Angle.Degrees(-42.51976705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126965"},
        {"Hipparcos Number", "HIP 70898"},
        {"Smithsonian Astrophysical Observation", "SAO 224968"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.47132247),
        dec: Angle.Degrees(-42.51804653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112424"},
        {"Hipparcos Number", "HIP 63207"},
        {"Geneva Identification System", "GEN# +1.00112424"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.24851194),
        dec: Angle.Degrees(-42.51761811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34599"},
        {"Hipparcos Number", "HIP 24597"},
        {"Geneva Identification System", "GEN# +1.00034599"},
        {"Smithsonian Astrophysical Observation", "SAO 217264"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.14607434),
        dec: Angle.Degrees(-42.51462622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118468"},
        {"Hipparcos Number", "HIP 66494"},
        {"Smithsonian Astrophysical Observation", "SAO 224289"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.46704310),
        dec: Angle.Degrees(-42.51454377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108063"},
        {"Hipparcos Number", "HIP 60591"},
        {"Fundamental Katalog 5th Edition", "FK5 2995"},
        {"Geneva Identification System", "GEN# +1.00108063"},
        {"Smithsonian Astrophysical Observation", "SAO 223426"},
        {"Wilson Evans Batten Catalogue", "WEB 10773"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.28593652),
        dec: Angle.Degrees(-42.51425806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14573"},
        {"Smithsonian Astrophysical Observation", "SAO 216176"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.03627465),
        dec: Angle.Degrees(-42.51377740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81587"},
        {"Hipparcos Number", "HIP 46201"},
        {"Smithsonian Astrophysical Observation", "SAO 221148"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.30331794),
        dec: Angle.Degrees(-42.51076218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157113"},
        {"Hipparcos Number", "HIP 85077"},
        {"Smithsonian Astrophysical Observation", "SAO 227891"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.81599597),
        dec: Angle.Degrees(-42.51053092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63641"},
        {"Hipparcos Number", "HIP 38076"},
        {"Celescope Catalog", "CEL 2046"},
        {"Geneva Identification System", "GEN# +1.00063641"},
        {"Smithsonian Astrophysical Observation", "SAO 219009"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.04121038),
        dec: Angle.Degrees(-42.50772655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11323"},
        {"Hipparcos Number", "HIP 8563"},
        {"Smithsonian Astrophysical Observation", "SAO 215674"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.61924970),
        dec: Angle.Degrees(-42.50760334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143561"},
        {"Hipparcos Number", "HIP 78585"},
        {"Smithsonian Astrophysical Observation", "SAO 226463"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68843204),
        dec: Angle.Degrees(-42.50707589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75926"},
        {"Hipparcos Number", "HIP 43486"},
        {"Celescope Catalog", "CEL 3004"},
        {"Geneva Identification System", "GEN# +1.00075926"},
        {"Smithsonian Astrophysical Observation", "SAO 220581"},
        {"Wilson Evans Batten Catalogue", "WEB 8381"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.86598200),
        dec: Angle.Degrees(-42.50455687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50785"},
        {"Hipparcos Number", "HIP 33006"},
        {"Geneva Identification System", "GEN# +1.00050785"},
        {"Smithsonian Astrophysical Observation", "SAO 218272"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.16514650),
        dec: Angle.Degrees(-42.50439893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118973"},
        {"Hipparcos Number", "HIP 66778"},
        {"Fundamental Katalog 5th Edition", "FK5 5210"},
        {"Smithsonian Astrophysical Observation", "SAO 224334"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30009353),
        dec: Angle.Degrees(-42.50238956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209827"},
        {"Hipparcos Number", "HIP 109188"},
        {"Smithsonian Astrophysical Observation", "SAO 230987"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.78324671),
        dec: Angle.Degrees(-42.50148563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29919"},
        {"Hipparcos Number", "HIP 21794"},
        {"Smithsonian Astrophysical Observation", "SAO 216930"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.23377066),
        dec: Angle.Degrees(-42.50098937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191054"},
        {"Hipparcos Number", "HIP 99329"},
        {"Smithsonian Astrophysical Observation", "SAO 230073"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.41638963),
        dec: Angle.Degrees(-42.50087203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112881"},
        {"Hipparcos Number", "HIP 63468"},
        {"Geneva Identification System", "GEN# +1.00112881"},
        {"Smithsonian Astrophysical Observation", "SAO 223828"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.07432776),
        dec: Angle.Degrees(-42.50087142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95699"},
        {"Hipparcos Number", "HIP 53938"},
        {"Geneva Identification System", "GEN# +1.00095699"},
        {"Renson", "Renson 27560"},
        {"Smithsonian Astrophysical Observation", "SAO 222507"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.54874131),
        dec: Angle.Degrees(-42.49791251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32693"},
        {"Hipparcos Number", "HIP 23495"},
        {"Smithsonian Astrophysical Observation", "SAO 217138"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.75866590),
        dec: Angle.Degrees(-42.49786838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131903"},
        {"Hipparcos Number", "HIP 73215"},
        {"Geneva Identification System", "GEN# +1.00131903"},
        {"Smithsonian Astrophysical Observation", "SAO 225326"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.44804443),
        dec: Angle.Degrees(-42.49723465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11753"},
        {"Hipparcos Number", "HIP 8882"},
        {"Fundamental Katalog 5th Edition", "FK5 1053"},
        {"Geneva Identification System", "GEN# +1.00011753"},
        {"Renson", "Renson 3010"},
        {"Smithsonian Astrophysical Observation", "SAO 215697"},
        {"Wilson Evans Batten Catalogue", "WEB 1869"},
    },
    visualMagnitude: 5.12,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.59191795),
        dec: Angle.Degrees(-42.49688104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1118"},
        {"Hipparcos Number", "HIP 1232"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.82355833),
        dec: Angle.Degrees(-42.49652440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25060"},
        {"Hipparcos Number", "HIP 18494"},
        {"Smithsonian Astrophysical Observation", "SAO 216573"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.30154402),
        dec: Angle.Degrees(-42.49337942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143735"},
        {"Hipparcos Number", "HIP 78692"},
        {"Geneva Identification System", "GEN# +1.00143735"},
        {"Smithsonian Astrophysical Observation", "SAO 226468"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.96013390),
        dec: Angle.Degrees(-42.49294222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112239"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.02034117),
        dec: Angle.Degrees(-42.49237493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38227"},
        {"Hipparcos Number", "HIP 26860"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.53832220),
        dec: Angle.Degrees(-42.49150909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82614"},
        {"Hipparcos Number", "HIP 46752"},
        {"Smithsonian Astrophysical Observation", "SAO 221250"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.93530172),
        dec: Angle.Degrees(-42.48916428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198246"},
        {"Hipparcos Number", "HIP 102872"},
        {"Geneva Identification System", "GEN# +1.00198246"},
        {"Smithsonian Astrophysical Observation", "SAO 230399"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.63705598),
        dec: Angle.Degrees(-42.48856484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73986"},
        {"Hipparcos Number", "HIP 42477"},
        {"Celescope Catalog", "CEL 2748"},
        {"Geneva Identification System", "GEN# +1.00073986"},
        {"Smithsonian Astrophysical Observation", "SAO 220240"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.90291239),
        dec: Angle.Degrees(-42.48686073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187370"},
        {"Hipparcos Number", "HIP 97714"},
        {"Geneva Identification System", "GEN# +1.00187370"},
        {"Smithsonian Astrophysical Observation", "SAO 229897"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87233526),
        dec: Angle.Degrees(-42.48624539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163522"},
        {"Hipparcos Number", "HIP 88004"},
        {"Celescope Catalog", "CEL 4580"},
        {"Geneva Identification System", "GEN# +1.00163522"},
        {"Smithsonian Astrophysical Observation", "SAO 228590"},
        {"Wilson Evans Batten Catalogue", "WEB 14861"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.64679703),
        dec: Angle.Degrees(-42.48613794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76341"},
        {"Hipparcos Number", "HIP 43702"},
        {"Celescope Catalog", "CEL 3056"},
        {"Geneva Identification System", "GEN# +1.00076341"},
        {"Smithsonian Astrophysical Observation", "SAO 220638"},
        {"Wilson Evans Batten Catalogue", "WEB 8414"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.50257817),
        dec: Angle.Degrees(-42.48577487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87102"},
        {"Hipparcos Number", "HIP 49145"},
        {"Smithsonian Astrophysical Observation", "SAO 221706"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.45366348),
        dec: Angle.Degrees(-42.48544278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155738"},
        {"Hipparcos Number", "HIP 84410"},
        {"Smithsonian Astrophysical Observation", "SAO 227749"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.84722287),
        dec: Angle.Degrees(-42.48317090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120834"},
        {"Hipparcos Number", "HIP 67751"},
        {"Smithsonian Astrophysical Observation", "SAO 224505"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.20017449),
        dec: Angle.Degrees(-42.48307644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10884"},
        {"Hipparcos Number", "HIP 8219"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.46001761),
        dec: Angle.Degrees(-42.48268491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14665"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.36505135),
        dec: Angle.Degrees(-42.48151928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 320.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 331.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32681"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.26421736),
        dec: Angle.Degrees(-42.48102083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7718"},
        {"Hipparcos Number", "HIP 5935"},
        {"Smithsonian Astrophysical Observation", "SAO 215434"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.07598894),
        dec: Angle.Degrees(-42.47997130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152293"},
        {"Hipparcos Number", "HIP 82716"},
        {"Geneva Identification System", "GEN# +1.00152293"},
        {"Smithsonian Astrophysical Observation", "SAO 227392"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61225569),
        dec: Angle.Degrees(-42.47887550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200641"},
        {"Hipparcos Number", "HIP 104145"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.50201869),
        dec: Angle.Degrees(-42.47864880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144416"},
        {"Hipparcos Number", "HIP 79006"},
        {"Geneva Identification System", "GEN# +1.00144416"},
        {"Smithsonian Astrophysical Observation", "SAO 226522"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90162525),
        dec: Angle.Degrees(-42.47600429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41022"},
        {"Hipparcos Number", "HIP 28451"},
        {"Smithsonian Astrophysical Observation", "SAO 217665"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11064906),
        dec: Angle.Degrees(-42.47546051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120324"},
        {"Hipparcos Number", "HIP 67472"},
        {"Fundamental Katalog 5th Edition", "FK5 508"},
        {"Geneva Identification System", "GEN# +1.00120324A"},
        {"Geneva Identification System 2", "GEN# +1.00120324J"},
        {"Smithsonian Astrophysical Observation", "SAO 224471"},
        {"Wilson Evans Batten Catalogue", "WEB 11866"},
    },
    visualMagnitude: 3.47,
    bvColour: -0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.40419934),
        dec: Angle.Degrees(-42.47368506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49385"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.23437580),
        dec: Angle.Degrees(-42.47168578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86832"},
        {"Hipparcos Number", "HIP 49025"},
        {"Smithsonian Astrophysical Observation", "SAO 221681"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.02753957),
        dec: Angle.Degrees(-42.47060572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209429"},
        {"Hipparcos Number", "HIP 108951"},
        {"Smithsonian Astrophysical Observation", "SAO 230966"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.09896611),
        dec: Angle.Degrees(-42.46976113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22717"},
        {"Hipparcos Number", "HIP 16901"},
        {"Geneva Identification System", "GEN# +1.00022717"},
        {"Smithsonian Astrophysical Observation", "SAO 216409"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.36747070),
        dec: Angle.Degrees(-42.46956410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21825"},
        {"Hipparcos Number", "HIP 16253"},
        {"Geneva Identification System", "GEN# +1.00021825"},
        {"Smithsonian Astrophysical Observation", "SAO 216346"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.36039914),
        dec: Angle.Degrees(-42.46897934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181040"},
        {"Hipparcos Number", "HIP 95089"},
        {"Smithsonian Astrophysical Observation", "SAO 229631"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.18518123),
        dec: Angle.Degrees(-42.46877028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148024"},
        {"Hipparcos Number", "HIP 80581"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.79375420),
        dec: Angle.Degrees(-42.46814929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54538"},
        {"Geneva Identification System", "GEN# -0.04106367"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.41119083),
        dec: Angle.Degrees(-42.46803369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 270.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79668"},
        {"Hipparcos Number", "HIP 45312"},
        {"Geneva Identification System", "GEN# +1.00079668"},
        {"Smithsonian Astrophysical Observation", "SAO 220970"},
        {"Wilson Evans Batten Catalogue", "WEB 8631"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53363524),
        dec: Angle.Degrees(-42.46753086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90393"},
        {"Hipparcos Number", "HIP 51014"},
        {"Geneva Identification System", "GEN# +1.00090393"},
        {"Smithsonian Astrophysical Observation", "SAO 222041"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.32173230),
        dec: Angle.Degrees(-42.46737380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117483"},
        {"Hipparcos Number", "HIP 65955"},
        {"Smithsonian Astrophysical Observation", "SAO 224214"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.84372999),
        dec: Angle.Degrees(-42.46470670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57284"},
        {"Hipparcos Number", "HIP 35394"},
        {"Geneva Identification System", "GEN# +1.00057284"},
        {"Smithsonian Astrophysical Observation", "SAO 218625"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.64516902),
        dec: Angle.Degrees(-42.46438420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75387"},
        {"Hipparcos Number", "HIP 43209"},
        {"Celescope Catalog", "CEL 2931"},
        {"Geneva Identification System", "GEN# +4.35100002"},
        {"Smithsonian Astrophysical Observation", "SAO 220495"},
        {"Wilson Evans Batten Catalogue", "WEB 8333"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.03661085),
        dec: Angle.Degrees(-42.46346345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41822"},
        {"Hipparcos Number", "HIP 28838"},
        {"Geneva Identification System", "GEN# +1.00041822"},
        {"Smithsonian Astrophysical Observation", "SAO 217710"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.31037515),
        dec: Angle.Degrees(-42.46197056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131777"},
        {"Hipparcos Number", "HIP 73147"},
        {"Geneva Identification System", "GEN# +1.00131777"},
        {"Smithsonian Astrophysical Observation", "SAO 225315"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.23237320),
        dec: Angle.Degrees(-42.46123819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161996"},
        {"Hipparcos Number", "HIP 87337"},
        {"Smithsonian Astrophysical Observation", "SAO 228479"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.68487190),
        dec: Angle.Degrees(-42.46117220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173260"},
        {"Hipparcos Number", "HIP 92110"},
        {"Geneva Identification System", "GEN# +1.00173260"},
        {"Smithsonian Astrophysical Observation", "SAO 229268"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.58307241),
        dec: Angle.Degrees(-42.45848288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10154"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.65315093),
        dec: Angle.Degrees(-42.45796952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13488"},
        {"Hipparcos Number", "HIP 10157"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.65897503),
        dec: Angle.Degrees(-42.45584282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129054"},
        {"Hipparcos Number", "HIP 71833"},
        {"Smithsonian Astrophysical Observation", "SAO 225125"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.41812772),
        dec: Angle.Degrees(-42.45497026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 323486"},
        {"Hipparcos Number", "HIP 85265"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.34635827),
        dec: Angle.Degrees(-42.45383890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208926"},
        {"Henry Draper 2", "HD 208927"},
        {"Hipparcos Number", "HIP 108639"},
        {"Geneva Identification System", "GEN# +1.00208926"},
        {"Smithsonian Astrophysical Observation", "SAO 230936"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.13353270),
        dec: Angle.Degrees(-42.45179277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218483"},
        {"Hipparcos Number", "HIP 114286"},
        {"Geneva Identification System", "GEN# +1.00218483"},
        {"Smithsonian Astrophysical Observation", "SAO 231456"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.20833745),
        dec: Angle.Degrees(-42.45089331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87965"},
        {"Hipparcos Number", "HIP 49618"},
        {"Smithsonian Astrophysical Observation", "SAO 221790"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.89651452),
        dec: Angle.Degrees(-42.45031424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73811"},
        {"Hipparcos Number", "HIP 42395"},
        {"Celescope Catalog", "CEL 2736"},
        {"Geneva Identification System", "GEN# +1.00073811"},
        {"Smithsonian Astrophysical Observation", "SAO 220227"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.66856603),
        dec: Angle.Degrees(-42.44698771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205913"},
        {"Hipparcos Number", "HIP 106955"},
        {"Smithsonian Astrophysical Observation", "SAO 230776"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.92696158),
        dec: Angle.Degrees(-42.44559457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224375"},
        {"Hipparcos Number", "HIP 118098"},
        {"Smithsonian Astrophysical Observation", "SAO 231864"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.34181539),
        dec: Angle.Degrees(-42.44428847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125495"},
        {"Hipparcos Number", "HIP 70111"},
        {"Smithsonian Astrophysical Observation", "SAO 224849"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.19583167),
        dec: Angle.Degrees(-42.44330016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217470"},
        {"Hipparcos Number", "HIP 113681"},
        {"Smithsonian Astrophysical Observation", "SAO 231395"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.37409770),
        dec: Angle.Degrees(-42.44294885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35739"},
        {"Hipparcos Number", "HIP 25308"},
        {"Smithsonian Astrophysical Observation", "SAO 217323"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.20219858),
        dec: Angle.Degrees(-42.43993422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136147"},
        {"Hipparcos Number", "HIP 75072"},
        {"Smithsonian Astrophysical Observation", "SAO 225670"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.11810451),
        dec: Angle.Degrees(-42.43720252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104731"},
        {"Hipparcos Number", "HIP 58803"},
        {"Fundamental Katalog 5th Edition", "FK5 449"},
        {"Geneva Identification System", "GEN# +1.00104731"},
        {"Smithsonian Astrophysical Observation", "SAO 223193"},
        {"Wilson Evans Batten Catalogue", "WEB 10477"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.91381150),
        dec: Angle.Degrees(-42.43378714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 323.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86424"},
        {"Hipparcos Number", "HIP 48811"},
        {"Smithsonian Astrophysical Observation", "SAO 221636"},
    },
    visualMagnitude: 9.14,
    bvColour: -0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.34685125),
        dec: Angle.Degrees(-42.43353337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93172"},
        {"Hipparcos Number", "HIP 52566"},
        {"Renson", "Renson 26910"},
        {"Smithsonian Astrophysical Observation", "SAO 222291"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.21114032),
        dec: Angle.Degrees(-42.43337642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69492"},
        {"Hipparcos Number", "HIP 40444"},
        {"Smithsonian Astrophysical Observation", "SAO 219680"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.86904824),
        dec: Angle.Degrees(-42.43290082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17265"},
        {"Hipparcos Number", "HIP 12834"},
        {"Smithsonian Astrophysical Observation", "SAO 216027"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.24410232),
        dec: Angle.Degrees(-42.43247521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3136"},
        {"Hipparcos Number", "HIP 2701"},
        {"Geneva Identification System", "GEN# +1.00003136"},
        {"Smithsonian Astrophysical Observation", "SAO 215146"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.58088296),
        dec: Angle.Degrees(-42.43128561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183504"},
        {"Hipparcos Number", "HIP 96053"},
        {"Geneva Identification System", "GEN# +1.00183504"},
        {"Smithsonian Astrophysical Observation", "SAO 229731"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.94960690),
        dec: Angle.Degrees(-42.42964426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80225"},
        {"Hipparcos Number", "HIP 45561"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.29299580),
        dec: Angle.Degrees(-42.42943964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177996"},
        {"Hipparcos Number", "HIP 94050"},
        {"Geneva Identification System", "GEN# +1.00177996"},
        {"Smithsonian Astrophysical Observation", "SAO 229520"},
        {"Wilson Evans Batten Catalogue", "WEB 16369"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.21029808),
        dec: Angle.Degrees(-42.42781102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107008"},
        {"Hipparcos Number", "HIP 60016"},
        {"Geneva Identification System", "GEN# +1.00107008"},
        {"Smithsonian Astrophysical Observation", "SAO 223345"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.62353776),
        dec: Angle.Degrees(-42.42718770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8640"},
        {"Hipparcos Number", "HIP 6582"},
        {"Smithsonian Astrophysical Observation", "SAO 215490"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.13646948),
        dec: Angle.Degrees(-42.42569221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173123"},
        {"Hipparcos Number", "HIP 92046"},
        {"Geneva Identification System", "GEN# +1.00173123"},
        {"Smithsonian Astrophysical Observation", "SAO 229251"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.42235476),
        dec: Angle.Degrees(-42.42557427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206119"},
        {"Hipparcos Number", "HIP 107074"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.28770844),
        dec: Angle.Degrees(-42.42545990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15481"},
        {"Hipparcos Number", "HIP 11493"},
        {"Geneva Identification System", "GEN# +1.00015481"},
        {"Smithsonian Astrophysical Observation", "SAO 215910"},
        {"Wilson Evans Batten Catalogue", "WEB 2402"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.05987085),
        dec: Angle.Degrees(-42.42484293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125494"},
        {"Hipparcos Number", "HIP 70120"},
        {"Smithsonian Astrophysical Observation", "SAO 224851"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.21130208),
        dec: Angle.Degrees(-42.42478658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193807"},
        {"Hipparcos Number", "HIP 100591"},
        {"Geneva Identification System", "GEN# +1.00193807"},
        {"Smithsonian Astrophysical Observation", "SAO 230184"},
        {"Wilson Evans Batten Catalogue", "WEB 18176"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97161225),
        dec: Angle.Degrees(-42.42290463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215467"},
        {"Hipparcos Number", "HIP 112396"},
        {"Geneva Identification System", "GEN# +1.00215467"},
        {"Smithsonian Astrophysical Observation", "SAO 231281"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.48898911),
        dec: Angle.Degrees(-42.42221800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168841"},
        {"Hipparcos Number", "HIP 90152"},
        {"Smithsonian Astrophysical Observation", "SAO 228977"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.96270497),
        dec: Angle.Degrees(-42.42221241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13501"},
        {"Hipparcos Number", "HIP 10166"},
        {"Geneva Identification System", "GEN# +1.00013501"},
        {"Smithsonian Astrophysical Observation", "SAO 215802"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.68436535),
        dec: Angle.Degrees(-42.41985331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33809"},
        {"Hipparcos Number", "HIP 24119"},
        {"Smithsonian Astrophysical Observation", "SAO 217219"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.70084351),
        dec: Angle.Degrees(-42.41966468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71018"},
        {"Hipparcos Number", "HIP 41121"},
        {"Geneva Identification System", "GEN# +1.00071018J"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.86022538),
        dec: Angle.Degrees(-42.41874662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95261"},
        {"Hipparcos Number", "HIP 53720"},
        {"Smithsonian Astrophysical Observation", "SAO 222474"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.86257418),
        dec: Angle.Degrees(-42.41872709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121174"},
        {"Hipparcos Number", "HIP 67940"},
        {"Smithsonian Astrophysical Observation", "SAO 224529"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.70230945),
        dec: Angle.Degrees(-42.41579169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118252"},
        {"Hipparcos Number", "HIP 66376"},
        {"Renson", "Renson 34120"},
        {"Smithsonian Astrophysical Observation", "SAO 224271"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.10905212),
        dec: Angle.Degrees(-42.41536336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66208"},
        {"Hipparcos Number", "HIP 39165"},
        {"Smithsonian Astrophysical Observation", "SAO 219289"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.16260770),
        dec: Angle.Degrees(-42.41480822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30877"},
        {"Hipparcos Number", "HIP 22411"},
        {"Geneva Identification System", "GEN# +1.00030877"},
        {"Renson", "Renson 7980"},
        {"Smithsonian Astrophysical Observation", "SAO 217016"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.33498516),
        dec: Angle.Degrees(-42.41368246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154770"},
        {"Hipparcos Number", "HIP 83933"},
        {"Smithsonian Astrophysical Observation", "SAO 227674"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.33973487),
        dec: Angle.Degrees(-42.41327158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8500"},
        {"Hipparcos Number", "HIP 6482"},
        {"Smithsonian Astrophysical Observation", "SAO 215482"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82551863),
        dec: Angle.Degrees(-42.41322546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101050"},
        {"Hipparcos Number", "HIP 56695"},
        {"Smithsonian Astrophysical Observation", "SAO 222915"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.37608385),
        dec: Angle.Degrees(-42.41160683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127271"},
        {"Hipparcos Number", "HIP 71027"},
        {"Smithsonian Astrophysical Observation", "SAO 224994"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.90251584),
        dec: Angle.Degrees(-42.41135616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184841"},
        {"Hipparcos Number", "HIP 96586"},
        {"Smithsonian Astrophysical Observation", "SAO 229784"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.53434322),
        dec: Angle.Degrees(-42.40908849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157887"},
        {"Hipparcos Number", "HIP 85468"},
        {"Geneva Identification System", "GEN# +1.00157887"},
        {"Smithsonian Astrophysical Observation", "SAO 227994"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.97961755),
        dec: Angle.Degrees(-42.40841575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65442"},
        {"Hipparcos Number", "HIP 38845"},
        {"Geneva Identification System", "GEN# +1.00065442"},
        {"Smithsonian Astrophysical Observation", "SAO 219186"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.24088448),
        dec: Angle.Degrees(-42.40651530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127498"},
        {"Hipparcos Number", "HIP 71140"},
        {"Geneva Identification System", "GEN# +1.00127498"},
        {"Smithsonian Astrophysical Observation", "SAO 225011"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.23783957),
        dec: Angle.Degrees(-42.40541421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214275"},
        {"Hipparcos Number", "HIP 111711"},
        {"Smithsonian Astrophysical Observation", "SAO 231222"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44072658),
        dec: Angle.Degrees(-42.40457662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165902"},
        {"Hipparcos Number", "HIP 89031"},
        {"Smithsonian Astrophysical Observation", "SAO 228763"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.56074750),
        dec: Angle.Degrees(-42.40319662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6910"},
        {"Hipparcos Number", "HIP 5395"},
        {"Geneva Identification System", "GEN# +1.00006910"},
        {"Smithsonian Astrophysical Observation", "SAO 215382"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.25999785),
        dec: Angle.Degrees(-42.40181366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75446"},
        {"Hipparcos Number", "HIP 43240"},
        {"Celescope Catalog", "CEL 2939"},
        {"Geneva Identification System", "GEN# +4.35100006"},
        {"Smithsonian Astrophysical Observation", "SAO 220504"},
        {"Wilson Evans Batten Catalogue", "WEB 8337"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.12848410),
        dec: Angle.Degrees(-42.40067225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7094"},
        {"Hipparcos Number", "HIP 5516"},
        {"Smithsonian Astrophysical Observation", "SAO 215396"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.65787916),
        dec: Angle.Degrees(-42.40025096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88135"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.03584641),
        dec: Angle.Degrees(-42.40003922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158846"},
        {"Hipparcos Number", "HIP 85919"},
        {"Celescope Catalog", "CEL 4528"},
        {"Geneva Identification System", "GEN# +1.00158846J"},
        {"Smithsonian Astrophysical Observation", "SAO 228115"},
        {"Wilson Evans Batten Catalogue", "WEB 14498"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.37102340),
        dec: Angle.Degrees(-42.39964738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60813"},
        {"Hipparcos Number", "HIP 36830"},
        {"Geneva Identification System", "GEN# +1.00060813"},
        {"Renson", "Renson 16580"},
        {"Smithsonian Astrophysical Observation", "SAO 218813"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61322986),
        dec: Angle.Degrees(-42.39905642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92658"},
        {"Hipparcos Number", "HIP 52304"},
        {"Smithsonian Astrophysical Observation", "SAO 222257"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.30830771),
        dec: Angle.Degrees(-42.39895764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137232"},
        {"Hipparcos Number", "HIP 75575"},
        {"Geneva Identification System", "GEN# +1.00137232"},
        {"Smithsonian Astrophysical Observation", "SAO 225777"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.58411357),
        dec: Angle.Degrees(-42.39834375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26136"},
        {"Hipparcos Number", "HIP 19156"},
        {"Smithsonian Astrophysical Observation", "SAO 216642"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.59160631),
        dec: Angle.Degrees(-42.39772812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196748"},
        {"Hipparcos Number", "HIP 102057"},
        {"Geneva Identification System", "GEN# +1.00196748"},
        {"Smithsonian Astrophysical Observation", "SAO 230321"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.23172120),
        dec: Angle.Degrees(-42.39671643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103480"},
        {"Hipparcos Number", "HIP 58090"},
        {"Smithsonian Astrophysical Observation", "SAO 223104"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.70156098),
        dec: Angle.Degrees(-42.39500393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47080"},
        {"Hipparcos Number", "HIP 31387"},
        {"Geneva Identification System", "GEN# +1.00047080"},
        {"Smithsonian Astrophysical Observation", "SAO 218032"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69646500),
        dec: Angle.Degrees(-42.39451841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31461"},
        {"Hipparcos Number", "HIP 22784"},
        {"Smithsonian Astrophysical Observation", "SAO 217058"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.51406001),
        dec: Angle.Degrees(-42.39363594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138091"},
        {"Hipparcos Number", "HIP 76007"},
        {"Smithsonian Astrophysical Observation", "SAO 225867"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.85215458),
        dec: Angle.Degrees(-42.39289479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96749"},
        {"Hipparcos Number", "HIP 54411"},
        {"Smithsonian Astrophysical Observation", "SAO 222590"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.01257587),
        dec: Angle.Degrees(-42.39114625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25358"},
        {"Hipparcos Number", "HIP 18679"},
        {"Smithsonian Astrophysical Observation", "SAO 216594"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.00761797),
        dec: Angle.Degrees(-42.39016244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74105"},
        {"Hipparcos Number", "HIP 42544"},
        {"Geneva Identification System", "GEN# +1.00074105"},
        {"Smithsonian Astrophysical Observation", "SAO 220257"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.08804893),
        dec: Angle.Degrees(-42.38928047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10027"},
        {"Hipparcos Number", "HIP 7534"},
        {"Smithsonian Astrophysical Observation", "SAO 215582"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.26665113),
        dec: Angle.Degrees(-42.38698858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30848"},
        {"Hipparcos Number", "HIP 22389"},
        {"Geneva Identification System", "GEN# +1.00030848"},
        {"Smithsonian Astrophysical Observation", "SAO 217012"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.29437816),
        dec: Angle.Degrees(-42.38480948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126019"},
        {"Hipparcos Number", "HIP 70389"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.02543066),
        dec: Angle.Degrees(-42.38324048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88966"},
        {"Hipparcos Number", "HIP 50200"},
        {"Geneva Identification System", "GEN# +1.00088966"},
        {"Smithsonian Astrophysical Observation", "SAO 221899"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.72374207),
        dec: Angle.Degrees(-42.38305753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10910"},
        {"Hipparcos Number", "HIP 8253"},
        {"Smithsonian Astrophysical Observation", "SAO 215640"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.55696025),
        dec: Angle.Degrees(-42.38187510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112012"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.33674116),
        dec: Angle.Degrees(-42.38067216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145357"},
        {"Hipparcos Number", "HIP 79400"},
        {"Smithsonian Astrophysical Observation", "SAO 226568"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.06985522),
        dec: Angle.Degrees(-42.37498373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110056"},
        {"Hipparcos Number", "HIP 61777"},
        {"Renson", "Renson 31950"},
        {"Smithsonian Astrophysical Observation", "SAO 223580"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.91919979),
        dec: Angle.Degrees(-42.37447206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20170"},
        {"Hipparcos Number", "HIP 14967"},
        {"Fundamental Katalog 5th Edition", "FK5 4294"},
        {"Geneva Identification System", "GEN# +1.00020170"},
        {"Smithsonian Astrophysical Observation", "SAO 216213"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.23572359),
        dec: Angle.Degrees(-42.37405821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7430"},
        {"Hipparcos Number", "HIP 5748"},
        {"Smithsonian Astrophysical Observation", "SAO 215418"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.45579519),
        dec: Angle.Degrees(-42.37179136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223633"},
        {"Hipparcos Number", "HIP 117630"},
        {"Geneva Identification System", "GEN# +1.00223633"},
        {"Smithsonian Astrophysical Observation", "SAO 231811"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.84006366),
        dec: Angle.Degrees(-42.37175188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48675"},
        {"Hipparcos Number", "HIP 32115"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.61838213),
        dec: Angle.Degrees(-42.37131552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76225"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.56550972),
        dec: Angle.Degrees(-42.37032188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135454"},
        {"Hipparcos Number", "HIP 74752"},
        {"Celescope Catalog", "CEL 4360"},
        {"Geneva Identification System", "GEN# +1.00135454"},
        {"Smithsonian Astrophysical Observation", "SAO 225612"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.15486310),
        dec: Angle.Degrees(-42.37009041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93850"},
        {"Hipparcos Number", "HIP 52924"},
        {"Smithsonian Astrophysical Observation", "SAO 222360"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.35722367),
        dec: Angle.Degrees(-42.36750513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60363"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.66297236),
        dec: Angle.Degrees(-42.36592872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5272"},
        {"Smithsonian Astrophysical Observation", "SAO 147617"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.84964268),
        dec: Angle.Degrees(-10.57134130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51208"},
        {"Hipparcos Number", "HIP 33189"},
        {"Fundamental Katalog 5th Edition", "FK5 2534"},
        {"Geneva Identification System", "GEN# +1.00051208"},
        {"Smithsonian Astrophysical Observation", "SAO 218296"},
        {"Wilson Evans Batten Catalogue", "WEB 6673"},
    },
    visualMagnitude: 6.32,
    bvColour: 2.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.61118619),
        dec: Angle.Degrees(-42.36561926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218685"},
        {"Hipparcos Number", "HIP 114422"},
        {"Smithsonian Astrophysical Observation", "SAO 231469"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.59462064),
        dec: Angle.Degrees(-42.36494811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26144"},
        {"Hipparcos Number", "HIP 19160"},
        {"Smithsonian Astrophysical Observation", "SAO 216645"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.62684111),
        dec: Angle.Degrees(-42.36468848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273011"},
        {"Hipparcos Number", "HIP 23573"},
        {"Geneva Identification System", "GEN# +1.00273011"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.02249072),
        dec: Angle.Degrees(-42.36325393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87908"},
        {"Hipparcos Number", "HIP 49574"},
        {"Smithsonian Astrophysical Observation", "SAO 221783"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.79933300),
        dec: Angle.Degrees(-42.36258331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221954"},
        {"Hipparcos Number", "HIP 116517"},
        {"Geneva Identification System", "GEN# +1.00221954"},
        {"Smithsonian Astrophysical Observation", "SAO 231694"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.18564498),
        dec: Angle.Degrees(-42.36219574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152236"},
        {"Hipparcos Number", "HIP 82671"},
        {"Celescope Catalog", "CEL 4441"},
        {"Geneva Identification System", "GEN# +1.00152236"},
        {"Smithsonian Astrophysical Observation", "SAO 227375"},
        {"Wilson Evans Batten Catalogue", "WEB 13962"},
        {"New General Catalogue", "NGC 6231 318"},
    },
    visualMagnitude: 4.70,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.49886366),
        dec: Angle.Degrees(-42.36201968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67726"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11667152),
        dec: Angle.Degrees(-42.36123974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152334"},
        {"Hipparcos Number", "HIP 82729"},
        {"Geneva Identification System", "GEN# +1.00152334"},
        {"Smithsonian Astrophysical Observation", "SAO 227402"},
        {"Wilson Evans Batten Catalogue", "WEB 13982"},
    },
    visualMagnitude: 3.62,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.64627156),
        dec: Angle.Degrees(-42.36075916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89004"},
        {"Hipparcos Number", "HIP 50228"},
        {"Smithsonian Astrophysical Observation", "SAO 221909"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.79869061),
        dec: Angle.Degrees(-42.35700907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118907"},
        {"Hipparcos Number", "HIP 66737"},
        {"Smithsonian Astrophysical Observation", "SAO 224327"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.18426426),
        dec: Angle.Degrees(-42.35493763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74104"},
        {"Hipparcos Number", "HIP 42543"},
        {"Geneva Identification System", "GEN# +1.00074104"},
        {"Smithsonian Astrophysical Observation", "SAO 220256"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.08776134),
        dec: Angle.Degrees(-42.35319556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12368"},
        {"Smithsonian Astrophysical Observation", "SAO 215990"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.80408408),
        dec: Angle.Degrees(-42.35119203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4784"},
        {"Hipparcos Number", "HIP 3847"},
        {"Smithsonian Astrophysical Observation", "SAO 215248"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.34994207),
        dec: Angle.Degrees(-42.34866695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51397"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.46302485),
        dec: Angle.Degrees(-42.34686523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133261"},
        {"Hipparcos Number", "HIP 73792"},
        {"Smithsonian Astrophysical Observation", "SAO 225424"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.23367358),
        dec: Angle.Degrees(-42.34389440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111697"},
        {"Hipparcos Number", "HIP 62753"},
        {"Smithsonian Astrophysical Observation", "SAO 223715"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.88925578),
        dec: Angle.Degrees(-42.34310949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129551"},
        {"Hipparcos Number", "HIP 72067"},
        {"Smithsonian Astrophysical Observation", "SAO 225153"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.12109072),
        dec: Angle.Degrees(-42.34150081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222997"},
        {"Hipparcos Number", "HIP 117203"},
        {"Smithsonian Astrophysical Observation", "SAO 231767"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46917494),
        dec: Angle.Degrees(-42.34116523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175586"},
        {"Hipparcos Number", "HIP 93098"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.49144009),
        dec: Angle.Degrees(-42.33955364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155896"},
        {"Hipparcos Number", "HIP 84483"},
        {"Celescope Catalog", "CEL 4490"},
        {"Geneva Identification System", "GEN# +1.00155896J"},
        {"Smithsonian Astrophysical Observation", "SAO 227768"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.07327164),
        dec: Angle.Degrees(-42.33903340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105350"},
        {"Hipparcos Number", "HIP 59156"},
        {"Smithsonian Astrophysical Observation", "SAO 223229"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.96987363),
        dec: Angle.Degrees(-42.33802604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75008"},
        {"Hipparcos Number", "HIP 43010"},
        {"Geneva Identification System", "GEN# +4.35100010"},
        {"Smithsonian Astrophysical Observation", "SAO 220414"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.47673088),
        dec: Angle.Degrees(-42.33780240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53704"},
        {"Hipparcos Number", "HIP 34081"},
        {"Celescope Catalog", "CEL 1556"},
        {"Fundamental Katalog 5th Edition", "FK5 1184"},
        {"Geneva Identification System", "GEN# +1.00053704"},
        {"Renson", "Renson 14750"},
        {"Smithsonian Astrophysical Observation", "SAO 218424"},
        {"Wilson Evans Batten Catalogue", "WEB 6830"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.01169961),
        dec: Angle.Degrees(-42.33745341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158107"},
        {"Hipparcos Number", "HIP 85578"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.32463642),
        dec: Angle.Degrees(-42.33425814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192253"},
        {"Hipparcos Number", "HIP 99865"},
        {"Smithsonian Astrophysical Observation", "SAO 230123"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.92339832),
        dec: Angle.Degrees(-42.33298939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99294"},
        {"Hipparcos Number", "HIP 55734"},
        {"Renson", "Renson 28590"},
        {"Smithsonian Astrophysical Observation", "SAO 222779"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.29799220),
        dec: Angle.Degrees(-42.33270769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162021"},
        {"Hipparcos Number", "HIP 87344"},
        {"Geneva Identification System", "GEN# +1.00162021"},
        {"Smithsonian Astrophysical Observation", "SAO 228481"},
        {"Wilson Evans Batten Catalogue", "WEB 14737"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.71573260),
        dec: Angle.Degrees(-42.32996711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54208"},
        {"Hipparcos Number", "HIP 34246"},
        {"Celescope Catalog", "CEL 1587"},
        {"Geneva Identification System", "GEN# +1.00054208A"},
        {"Smithsonian Astrophysical Observation", "SAO 218447"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.49077757),
        dec: Angle.Degrees(-42.32757096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30371"},
        {"Smithsonian Astrophysical Observation", "SAO 217895"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.80352063),
        dec: Angle.Degrees(-42.32601887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9867"},
        {"Hipparcos Number", "HIP 7409"},
        {"Fundamental Katalog 5th Edition", "FK5 4144"},
        {"Smithsonian Astrophysical Observation", "SAO 215571"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.87467719),
        dec: Angle.Degrees(-42.32574704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39192"},
        {"Hipparcos Number", "HIP 27455"},
        {"Geneva Identification System", "GEN# +1.00039192"},
        {"Smithsonian Astrophysical Observation", "SAO 217551"},
        {"Wilson Evans Batten Catalogue", "WEB 5390"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.19721477),
        dec: Angle.Degrees(-42.32573482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133866"},
        {"Hipparcos Number", "HIP 74064"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.04531998),
        dec: Angle.Degrees(-42.32406824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29470"},
        {"Hipparcos Number", "HIP 21461"},
        {"Smithsonian Astrophysical Observation", "SAO 216893"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.13510393),
        dec: Angle.Degrees(-42.32387991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64441"},
        {"Hipparcos Number", "HIP 38408"},
        {"Smithsonian Astrophysical Observation", "SAO 219081"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.03251293),
        dec: Angle.Degrees(-42.32379851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163025"},
        {"Hipparcos Number", "HIP 87794"},
        {"Geneva Identification System", "GEN# +1.00163025"},
        {"Renson", "Renson 46120"},
        {"Smithsonian Astrophysical Observation", "SAO 228557"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.01853240),
        dec: Angle.Degrees(-42.32323899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142527"},
        {"Hipparcos Number", "HIP 78092"},
        {"Geneva Identification System", "GEN# +1.00142527"},
        {"Smithsonian Astrophysical Observation", "SAO 226389"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17457785),
        dec: Angle.Degrees(-42.32307241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168786"},
        {"Hipparcos Number", "HIP 90125"},
        {"Smithsonian Astrophysical Observation", "SAO 228970"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.87500957),
        dec: Angle.Degrees(-42.32290156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64458"},
        {"Hipparcos Number", "HIP 38420"},
        {"Celescope Catalog", "CEL 2070"},
        {"Smithsonian Astrophysical Observation", "SAO 219083"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.06029686),
        dec: Angle.Degrees(-42.32253920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85280"},
        {"Hipparcos Number", "HIP 48200"},
        {"Smithsonian Astrophysical Observation", "SAO 221518"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.39706153),
        dec: Angle.Degrees(-42.32191928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35471"},
        {"Hipparcos Number", "HIP 25148"},
        {"Geneva Identification System", "GEN# +1.00035471"},
        {"Smithsonian Astrophysical Observation", "SAO 217313"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.72352412),
        dec: Angle.Degrees(-42.32097290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170625"},
        {"Hipparcos Number", "HIP 90894"},
        {"Geneva Identification System", "GEN# +1.00170625"},
        {"Smithsonian Astrophysical Observation", "SAO 229101"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.10324427),
        dec: Angle.Degrees(-42.32035187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135088"},
        {"Hipparcos Number", "HIP 74622"},
        {"Celescope Catalog", "CEL 4353"},
        {"Geneva Identification System", "GEN# +1.00135088"},
        {"Smithsonian Astrophysical Observation", "SAO 225574"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.70702290),
        dec: Angle.Degrees(-42.31974119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136680"},
        {"Hipparcos Number", "HIP 75333"},
        {"Geneva Identification System", "GEN# +1.00136680"},
        {"Smithsonian Astrophysical Observation", "SAO 225726"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.88905718),
        dec: Angle.Degrees(-42.31885287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126386"},
        {"Hipparcos Number", "HIP 70580"},
        {"Geneva Identification System", "GEN# +1.00126386"},
        {"Smithsonian Astrophysical Observation", "SAO 224923"},
        {"Wilson Evans Batten Catalogue", "WEB 12239"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.55638492),
        dec: Angle.Degrees(-42.31847181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31942"},
        {"Hipparcos Number", "HIP 23062"},
        {"Smithsonian Astrophysical Observation", "SAO 217083"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.44464261),
        dec: Angle.Degrees(-42.31837911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210883"},
        {"Hipparcos Number", "HIP 109796"},
        {"Geneva Identification System", "GEN# +1.00210883"},
        {"Smithsonian Astrophysical Observation", "SAO 231044"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58776994),
        dec: Angle.Degrees(-42.31780048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16168"},
        {"Hipparcos Number", "HIP 11965"},
        {"Geneva Identification System", "GEN# +1.00016168"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59529405),
        dec: Angle.Degrees(-42.31631533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66998"},
        {"Hipparcos Number", "HIP 39485"},
        {"Smithsonian Astrophysical Observation", "SAO 219369"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.05439861),
        dec: Angle.Degrees(-42.31455305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141521"},
        {"Hipparcos Number", "HIP 77656"},
        {"Geneva Identification System", "GEN# +1.00141521"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.80727844),
        dec: Angle.Degrees(-42.31418707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54234"},
        {"Hipparcos Number", "HIP 34252"},
        {"Geneva Identification System", "GEN# +1.00054234"},
        {"Smithsonian Astrophysical Observation", "SAO 218448"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50861026),
        dec: Angle.Degrees(-42.31246245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170845"},
        {"Hipparcos Number", "HIP 90982"},
        {"Fundamental Katalog 5th Edition", "FK5 697"},
        {"Geneva Identification System", "GEN# +1.00170845"},
        {"Smithsonian Astrophysical Observation", "SAO 229111"},
        {"Wilson Evans Batten Catalogue", "WEB 15608"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.37566714),
        dec: Angle.Degrees(-42.31245871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85863"},
        {"Hipparcos Number", "HIP 48513"},
        {"Geneva Identification System", "GEN# +1.00085863"},
        {"Smithsonian Astrophysical Observation", "SAO 221579"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.40413394),
        dec: Angle.Degrees(-42.31032745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79601"},
        {"Hipparcos Number", "HIP 45283"},
        {"Geneva Identification System", "GEN# +1.00079601"},
        {"Smithsonian Astrophysical Observation", "SAO 220966"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.43646887),
        dec: Angle.Degrees(-42.31026974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109590"},
        {"Hipparcos Number", "HIP 61502"},
        {"Geneva Identification System", "GEN# +1.00109590"},
        {"Smithsonian Astrophysical Observation", "SAO 223545"},
        {"Wilson Evans Batten Catalogue", "WEB 10948"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.02266457),
        dec: Angle.Degrees(-42.30972504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110337"},
        {"Cincinnati Publication", "Ci 20 1354"},
    },
    visualMagnitude: 12.44,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.21371210),
        dec: Angle.Degrees(-42.30648750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 502.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2081",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ankaa"},
        {"Henry Draper", "HD 2261"},
        {"Hipparcos Number", "HIP 2081"},
        {"Cincinnati Publication", "Ci 20 32"},
        {"Fundamental Katalog 5th Edition", "FK5 12"},
        {"Geneva Identification System", "GEN# +1.00002261J"},
        {"Smithsonian Astrophysical Observation", "SAO 215093"},
        {"Wilson Evans Batten Catalogue", "WEB 393"},
    },
    visualMagnitude: 2.40,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.57028075),
        dec: Angle.Degrees(-42.30512197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -353.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141559"},
        {"Hipparcos Number", "HIP 77673"},
        {"Geneva Identification System", "GEN# +1.00141559"},
        {"Smithsonian Astrophysical Observation", "SAO 226297"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.86420645),
        dec: Angle.Degrees(-42.30070782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223480"},
        {"Hipparcos Number", "HIP 117515"},
        {"Geneva Identification System", "GEN# +1.00223480"},
        {"Smithsonian Astrophysical Observation", "SAO 231800"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.47778177),
        dec: Angle.Degrees(-42.30068463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36648"},
        {"Hipparcos Number", "HIP 25856"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.79345632),
        dec: Angle.Degrees(-42.29993828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42078"},
        {"Hipparcos Number", "HIP 28957"},
        {"Geneva Identification System", "GEN# +1.00042078"},
        {"Renson", "Renson 11210"},
        {"Smithsonian Astrophysical Observation", "SAO 217720"},
        {"Wilson Evans Batten Catalogue", "WEB 5669"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.67111635),
        dec: Angle.Degrees(-42.29879701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101956"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.90587572),
        dec: Angle.Degrees(-10.57115757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45139"},
        {"Geneva Identification System", "GEN# -0.04104886"},
    },
    visualMagnitude: 10.47,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.95387605),
        dec: Angle.Degrees(-42.29559476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102911"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.73759844),
        dec: Angle.Degrees(-42.29444539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26967"},
        {"Hipparcos Number", "HIP 19747"},
        {"Fundamental Katalog 5th Edition", "FK5 155"},
        {"Geneva Identification System", "GEN# +1.00026967"},
        {"Smithsonian Astrophysical Observation", "SAO 216710"},
        {"Wilson Evans Batten Catalogue", "WEB 3769"},
    },
    visualMagnitude: 3.85,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.50033880),
        dec: Angle.Degrees(-42.29387294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2785"},
        {"Hipparcos Number", "HIP 2448"},
        {"Smithsonian Astrophysical Observation", "SAO 215127"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.78343399),
        dec: Angle.Degrees(-42.29299328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46042"},
        {"Hipparcos Number", "HIP 30884"},
        {"Geneva Identification System", "GEN# +1.00046042"},
        {"Smithsonian Astrophysical Observation", "SAO 217954"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.24497713),
        dec: Angle.Degrees(-42.29243333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213155"},
        {"Hipparcos Number", "HIP 111085"},
        {"Geneva Identification System", "GEN# +1.00213155"},
        {"Smithsonian Astrophysical Observation", "SAO 231168"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.56550044),
        dec: Angle.Degrees(-42.29106542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112192"},
        {"Hipparcos Number", "HIP 63045"},
        {"Geneva Identification System", "GEN# +1.00112192"},
        {"Smithsonian Astrophysical Observation", "SAO 223756"},
        {"Wilson Evans Batten Catalogue", "WEB 11179"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.77910572),
        dec: Angle.Degrees(-42.29086884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167756"},
        {"Hipparcos Number", "HIP 89726"},
        {"Geneva Identification System", "GEN# +1.00167756"},
        {"Smithsonian Astrophysical Observation", "SAO 228895"},
        {"Wilson Evans Batten Catalogue", "WEB 15293"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66730983),
        dec: Angle.Degrees(-42.28838505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166533"},
        {"Hipparcos Number", "HIP 89274"},
        {"Smithsonian Astrophysical Observation", "SAO 228812"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.25760650),
        dec: Angle.Degrees(-42.28817588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217070"},
        {"Hipparcos Number", "HIP 113442"},
        {"Smithsonian Astrophysical Observation", "SAO 231375"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.63313307),
        dec: Angle.Degrees(-42.28794186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192926"},
        {"Hipparcos Number", "HIP 100169"},
        {"Smithsonian Astrophysical Observation", "SAO 230149"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.77611819),
        dec: Angle.Degrees(-42.28648187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206682"},
        {"Hipparcos Number", "HIP 107372"},
        {"Geneva Identification System", "GEN# +1.00206682"},
        {"Smithsonian Astrophysical Observation", "SAO 230820"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.21587218),
        dec: Angle.Degrees(-42.28562022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224644"},
        {"Hipparcos Number", "HIP 118291"},
        {"Smithsonian Astrophysical Observation", "SAO 231879"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.89245422),
        dec: Angle.Degrees(-42.28321806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25261"},
        {"Hipparcos Number", "HIP 18619"},
        {"Geneva Identification System", "GEN# +1.00025261"},
        {"Smithsonian Astrophysical Observation", "SAO 216586"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.75938950),
        dec: Angle.Degrees(-42.28308207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84171"},
        {"Hipparcos Number", "HIP 47571"},
        {"Smithsonian Astrophysical Observation", "SAO 221411"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.50598638),
        dec: Angle.Degrees(-42.28267761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112327"},
        {"Smithsonian Astrophysical Observation", "SAO 165268"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.26973722),
        dec: Angle.Degrees(-10.50771640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211120"},
        {"Hipparcos Number", "HIP 109924"},
        {"Geneva Identification System", "GEN# +1.00211120"},
        {"Smithsonian Astrophysical Observation", "SAO 231057"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.96400386),
        dec: Angle.Degrees(-42.28235754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48474",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48474"},
    },
    visualMagnitude: 11.79,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.27768613),
        dec: Angle.Degrees(-42.28088207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183606"},
        {"Hipparcos Number", "HIP 96091"},
        {"Geneva Identification System", "GEN# +1.00183606"},
        {"Smithsonian Astrophysical Observation", "SAO 229735"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.05005566),
        dec: Angle.Degrees(-42.27891235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223451"},
        {"Hipparcos Number", "HIP 117509"},
        {"Smithsonian Astrophysical Observation", "SAO 231799"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.44697181),
        dec: Angle.Degrees(-42.27821105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46208"},
        {"Hipparcos Number", "HIP 30962"},
        {"Smithsonian Astrophysical Observation", "SAO 217974"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.48901795),
        dec: Angle.Degrees(-42.27788384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66134"},
        {"Hipparcos Number", "HIP 39145"},
        {"Geneva Identification System", "GEN# +1.00066134"},
        {"Smithsonian Astrophysical Observation", "SAO 219278"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09647443),
        dec: Angle.Degrees(-42.27496461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126340"},
        {"Hipparcos Number", "HIP 70559"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.49883644),
        dec: Angle.Degrees(-42.27456392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20700"},
        {"Hipparcos Number", "HIP 15390"},
        {"Smithsonian Astrophysical Observation", "SAO 216252"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.60596191),
        dec: Angle.Degrees(-42.27444282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79524"},
        {"Hipparcos Number", "HIP 45242"},
        {"Geneva Identification System", "GEN# +1.00079524"},
        {"Smithsonian Astrophysical Observation", "SAO 220962"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.32781495),
        dec: Angle.Degrees(-42.27344152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38123"},
        {"Hipparcos Number", "HIP 26791"},
        {"Smithsonian Astrophysical Observation", "SAO 217476"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.35470981),
        dec: Angle.Degrees(-42.27334055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75324"},
        {"Hipparcos Number", "HIP 43182"},
        {"Celescope Catalog", "CEL 2924"},
        {"Geneva Identification System", "GEN# +4.35100004"},
        {"Smithsonian Astrophysical Observation", "SAO 220484"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.94976153),
        dec: Angle.Degrees(-42.27286940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213716"},
        {"Hipparcos Number", "HIP 111404"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.53992818),
        dec: Angle.Degrees(-42.27275966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40663"},
        {"Hipparcos Number", "HIP 28247"},
        {"Geneva Identification System", "GEN# +1.00040663"},
        {"Smithsonian Astrophysical Observation", "SAO 217645"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.54226108),
        dec: Angle.Degrees(-42.27192448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14576"},
        {"Hipparcos Number", "HIP 10891"},
        {"Smithsonian Astrophysical Observation", "SAO 215864"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.03809988),
        dec: Angle.Degrees(-42.27171454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44845"},
        {"Hipparcos Number", "HIP 30259"},
        {"Smithsonian Astrophysical Observation", "SAO 217883"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.48361592),
        dec: Angle.Degrees(-42.27142277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77054"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01410698),
        dec: Angle.Degrees(-42.26968918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77848"},
        {"Hipparcos Number", "HIP 44466"},
        {"Smithsonian Astrophysical Observation", "SAO 220790"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.89106795),
        dec: Angle.Degrees(-42.26896079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222576"},
        {"Hipparcos Number", "HIP 116920"},
        {"Geneva Identification System", "GEN# +1.00222576"},
        {"Smithsonian Astrophysical Observation", "SAO 231744"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48833600),
        dec: Angle.Degrees(-42.26872203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109275"},
        {"Hipparcos Number", "HIP 61321"},
        {"Geneva Identification System", "GEN# +1.00109275"},
        {"Smithsonian Astrophysical Observation", "SAO 223514"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.45143932),
        dec: Angle.Degrees(-42.26863602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84569"},
        {"Hipparcos Number", "HIP 47835"},
        {"Smithsonian Astrophysical Observation", "SAO 221450"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.25538926),
        dec: Angle.Degrees(-42.26675370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176540"},
        {"Hipparcos Number", "HIP 93513"},
        {"Smithsonian Astrophysical Observation", "SAO 229453"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.66954881),
        dec: Angle.Degrees(-42.26655338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196862"},
        {"Hipparcos Number", "HIP 102112"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.40097187),
        dec: Angle.Degrees(-42.26580762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119872"},
        {"Hipparcos Number", "HIP 67235"},
        {"Smithsonian Astrophysical Observation", "SAO 224415"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.66378610),
        dec: Angle.Degrees(-42.26171363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172019"},
        {"Hipparcos Number", "HIP 91519"},
        {"Smithsonian Astrophysical Observation", "SAO 229177"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.95581389),
        dec: Angle.Degrees(-42.26010595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92264"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.05320390),
        dec: Angle.Degrees(-42.25999541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70117"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.20932245),
        dec: Angle.Degrees(-42.25973074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190204"},
        {"Hipparcos Number", "HIP 98972"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.40638467),
        dec: Angle.Degrees(-42.25769129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12418"},
        {"Hipparcos Number", "HIP 9402"},
        {"Smithsonian Astrophysical Observation", "SAO 215736"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19863052),
        dec: Angle.Degrees(-42.25759414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106502"},
        {"Hipparcos Number", "HIP 59741"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.77427772),
        dec: Angle.Degrees(-42.25737517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46666"},
        {"Hipparcos Number", "HIP 31189"},
        {"Smithsonian Astrophysical Observation", "SAO 218004"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.15786917),
        dec: Angle.Degrees(-42.25639810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97666"},
        {"Hipparcos Number", "HIP 54855"},
        {"Smithsonian Astrophysical Observation", "SAO 222653"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.46352975),
        dec: Angle.Degrees(-42.25618918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70114"},
    },
    visualMagnitude: 11.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.20648335),
        dec: Angle.Degrees(-42.25467011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81573"},
        {"Hipparcos Number", "HIP 46193"},
        {"Geneva Identification System", "GEN# +1.00081573"},
        {"Smithsonian Astrophysical Observation", "SAO 221145"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.28091030),
        dec: Angle.Degrees(-42.25272448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82727"},
        {"Hipparcos Number", "HIP 46821"},
        {"Geneva Identification System", "GEN# +1.00082727"},
        {"Smithsonian Astrophysical Observation", "SAO 221267"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.12587478),
        dec: Angle.Degrees(-42.25263962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 673"},
        {"Hipparcos Number", "HIP 891"},
        {"Smithsonian Astrophysical Observation", "SAO 214993"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.73329241),
        dec: Angle.Degrees(-42.25160366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23890"},
        {"Hipparcos Number", "HIP 17653"},
        {"Smithsonian Astrophysical Observation", "SAO 216484"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.71747213),
        dec: Angle.Degrees(-42.25142933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220519"},
        {"Hipparcos Number", "HIP 115574"},
        {"Smithsonian Astrophysical Observation", "SAO 231595"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.16304516),
        dec: Angle.Degrees(-42.25141176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81782"},
        {"Hipparcos Number", "HIP 46290"},
        {"Smithsonian Astrophysical Observation", "SAO 221166"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.60242188),
        dec: Angle.Degrees(-42.25115294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94660"},
        {"Hipparcos Number", "HIP 53379"},
        {"Geneva Identification System", "GEN# +1.00094660"},
        {"Renson", "Renson 27310"},
        {"Smithsonian Astrophysical Observation", "SAO 222422"},
    },
    visualMagnitude: 6.08,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.75433505),
        dec: Angle.Degrees(-42.25109194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326647"},
        {"Hipparcos Number", "HIP 83403"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.69159136),
        dec: Angle.Degrees(-42.25022837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105669"},
        {"Hipparcos Number", "HIP 59298"},
        {"Smithsonian Astrophysical Observation", "SAO 223251"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.48495162),
        dec: Angle.Degrees(-42.24659580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119401"},
        {"Hipparcos Number", "HIP 67000"},
        {"Geneva Identification System", "GEN# +1.00119401"},
        {"Smithsonian Astrophysical Observation", "SAO 224368"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.96571180),
        dec: Angle.Degrees(-42.24621694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200902"},
        {"Hipparcos Number", "HIP 104301"},
        {"Smithsonian Astrophysical Observation", "SAO 230537"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.94514738),
        dec: Angle.Degrees(-42.24537545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162480"},
        {"Hipparcos Number", "HIP 87554"},
        {"Smithsonian Astrophysical Observation", "SAO 228514"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.30163012),
        dec: Angle.Degrees(-42.24512900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72476"},
    },
    visualMagnitude: 12.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.28956556),
        dec: Angle.Degrees(-42.24335464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72477"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.29028610),
        dec: Angle.Degrees(-42.23894491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52467"},
        {"Hipparcos Number", "HIP 33641"},
        {"Celescope Catalog", "CEL 1487"},
        {"Geneva Identification System", "GEN# +1.00052467"},
        {"Smithsonian Astrophysical Observation", "SAO 218367"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.83213902),
        dec: Angle.Degrees(-42.23763053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118777"},
        {"Hipparcos Number", "HIP 66600"},
        {"Smithsonian Astrophysical Observation", "SAO 158067"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.77934328),
        dec: Angle.Degrees(-10.39015227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224596"},
        {"Hipparcos Number", "HIP 118256"},
        {"Geneva Identification System", "GEN# +1.00224596"},
        {"Smithsonian Astrophysical Observation", "SAO 231874"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.79016625),
        dec: Angle.Degrees(-42.23694330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159957"},
        {"Hipparcos Number", "HIP 86417"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.86842545),
        dec: Angle.Degrees(-42.23679774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114435"},
        {"Hipparcos Number", "HIP 64332"},
        {"Geneva Identification System", "GEN# +1.00114435"},
        {"Smithsonian Astrophysical Observation", "SAO 223960"},
        {"Wilson Evans Batten Catalogue", "WEB 11371"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.78725433),
        dec: Angle.Degrees(-42.23282785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157696"},
        {"Hipparcos Number", "HIP 85377"},
        {"Geneva Identification System", "GEN# +1.00157696"},
        {"Smithsonian Astrophysical Observation", "SAO 227970"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.68027084),
        dec: Angle.Degrees(-42.23212048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9564"},
        {"Hipparcos Number", "HIP 7219"},
        {"Geneva Identification System", "GEN# +1.00009564"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.24753595),
        dec: Angle.Degrees(-42.23126747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39962"},
        {"Hipparcos Number", "HIP 27870"},
        {"Geneva Identification System", "GEN# +1.00039962"},
        {"Smithsonian Astrophysical Observation", "SAO 217604"},
        {"Wilson Evans Batten Catalogue", "WEB 5456"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.46531052),
        dec: Angle.Degrees(-42.23048581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71915"},
        {"Hipparcos Number", "HIP 41537"},
        {"Fundamental Katalog 5th Edition", "FK5 4763"},
        {"Geneva Identification System", "GEN# +1.00071915"},
        {"Smithsonian Astrophysical Observation", "SAO 219968"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.06034628),
        dec: Angle.Degrees(-42.23045417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62542"},
        {"Hipparcos Number", "HIP 37565"},
        {"Geneva Identification System", "GEN# +1.00062542"},
        {"Smithsonian Astrophysical Observation", "SAO 218917"},
        {"Wilson Evans Batten Catalogue", "WEB 7428"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.65509070),
        dec: Angle.Degrees(-42.22996619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147598"},
        {"Hipparcos Number", "HIP 80397"},
        {"Smithsonian Astrophysical Observation", "SAO 226728"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.16326774),
        dec: Angle.Degrees(-42.22969525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67101"},
        {"Hipparcos Number", "HIP 39536"},
        {"Smithsonian Astrophysical Observation", "SAO 219384"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.18927407),
        dec: Angle.Degrees(-42.22956252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91239"},
        {"Hipparcos Number", "HIP 51512"},
        {"Celescope Catalog", "CEL 3560"},
        {"Geneva Identification System", "GEN# +1.00091239"},
        {"Renson", "Renson 26240"},
        {"Smithsonian Astrophysical Observation", "SAO 222113"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.80551434),
        dec: Angle.Degrees(-42.22933869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169094"},
        {"Hipparcos Number", "HIP 90248"},
        {"Smithsonian Astrophysical Observation", "SAO 228998"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.21747049),
        dec: Angle.Degrees(-42.22895681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17831"},
        {"Hipparcos Number", "HIP 13239"},
        {"Geneva Identification System", "GEN# +1.00017831"},
        {"Smithsonian Astrophysical Observation", "SAO 216062"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.60361041),
        dec: Angle.Degrees(-42.22791231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95370"},
        {"Hipparcos Number", "HIP 53773"},
        {"Fundamental Katalog 5th Edition", "FK5 415"},
        {"Geneva Identification System", "GEN# +1.00095370"},
        {"Smithsonian Astrophysical Observation", "SAO 222487"},
        {"Wilson Evans Batten Catalogue", "WEB 9744"},
    },
    visualMagnitude: 4.37,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.03852431),
        dec: Angle.Degrees(-42.22586959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88792"},
        {"Hipparcos Number", "HIP 50092"},
        {"Smithsonian Astrophysical Observation", "SAO 221874"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.42148033),
        dec: Angle.Degrees(-42.22522499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164723"},
        {"Hipparcos Number", "HIP 88517"},
        {"Smithsonian Astrophysical Observation", "SAO 228670"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.13671094),
        dec: Angle.Degrees(-42.22337534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7425"},
        {"Hipparcos Number", "HIP 5731"},
        {"Smithsonian Astrophysical Observation", "SAO 215417"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.42224930),
        dec: Angle.Degrees(-42.22321254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 326053"},
        {"Hipparcos Number", "HIP 82057"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.42512500),
        dec: Angle.Degrees(-42.22312903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49921"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.88858784),
        dec: Angle.Degrees(-42.22295136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91223"},
        {"Hipparcos Number", "HIP 51504"},
        {"Geneva Identification System", "GEN# +1.00091223"},
        {"Smithsonian Astrophysical Observation", "SAO 222112"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.77643681),
        dec: Angle.Degrees(-42.22085324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56316"},
        {"Hipparcos Number", "HIP 35013"},
        {"Geneva Identification System", "GEN# +1.00056316"},
        {"Smithsonian Astrophysical Observation", "SAO 218564"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64315105),
        dec: Angle.Degrees(-42.21391907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1837"},
        {"Hipparcos Number", "HIP 1782"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.66800708),
        dec: Angle.Degrees(-42.21390672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128875"},
        {"Hipparcos Number", "HIP 71758"},
        {"Smithsonian Astrophysical Observation", "SAO 225114"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.17591835),
        dec: Angle.Degrees(-42.21226458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96099"},
        {"Wilson Evans Batten Catalogue", "WEB 16833"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.08089020),
        dec: Angle.Degrees(-42.21141319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -301.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173972"},
        {"Hipparcos Number", "HIP 92425"},
        {"Smithsonian Astrophysical Observation", "SAO 229308"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.53512494),
        dec: Angle.Degrees(-42.21111378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98566"},
        {"Hipparcos Number", "HIP 55349"},
        {"Geneva Identification System", "GEN# +1.00098566"},
        {"Smithsonian Astrophysical Observation", "SAO 222723"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.01607114),
        dec: Angle.Degrees(-42.21060682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122333"},
        {"Hipparcos Number", "HIP 68571"},
        {"Smithsonian Astrophysical Observation", "SAO 224626"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58214192),
        dec: Angle.Degrees(-42.20871703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95774"},
        {"Hipparcos Number", "HIP 53993"},
        {"Geneva Identification System", "GEN# +1.00095774"},
        {"Smithsonian Astrophysical Observation", "SAO 222515"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.68886284),
        dec: Angle.Degrees(-42.20637483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140785"},
        {"Hipparcos Number", "HIP 77325"},
        {"Geneva Identification System", "GEN# +1.00140785"},
        {"Smithsonian Astrophysical Observation", "SAO 226198"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.80360981),
        dec: Angle.Degrees(-42.20437963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96536"},
        {"Hipparcos Number", "HIP 54333"},
        {"Smithsonian Astrophysical Observation", "SAO 222575"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.72075446),
        dec: Angle.Degrees(-42.20336185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8014"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.73029947),
        dec: Angle.Degrees(-42.20310863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 648.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114948"},
        {"Hipparcos Number", "HIP 64611"},
        {"Geneva Identification System", "GEN# +1.00114948"},
        {"Smithsonian Astrophysical Observation", "SAO 223998"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.64926955),
        dec: Angle.Degrees(-42.20258426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28666"},
        {"Hipparcos Number", "HIP 20929"},
        {"Renson", "Renson 7370"},
        {"Smithsonian Astrophysical Observation", "SAO 216828"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.31809734),
        dec: Angle.Degrees(-42.19837677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63218"},
        {"Hipparcos Number", "HIP 37893"},
        {"Geneva Identification System", "GEN# +1.00063218"},
        {"Smithsonian Astrophysical Observation", "SAO 218969"},
        {"Wilson Evans Batten Catalogue", "WEB 7481"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.48898022),
        dec: Angle.Degrees(-42.19559366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86553"},
        {"Hipparcos Number", "HIP 48885"},
        {"Smithsonian Astrophysical Observation", "SAO 221652"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.56261240),
        dec: Angle.Degrees(-42.19549341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224296"},
        {"Hipparcos Number", "HIP 118049"},
        {"Geneva Identification System", "GEN# +1.00224296"},
        {"Smithsonian Astrophysical Observation", "SAO 231859"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.17778925),
        dec: Angle.Degrees(-42.19522039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81034"},
        {"Hipparcos Number", "HIP 45924"},
        {"Geneva Identification System", "GEN# +1.00081034"},
        {"Smithsonian Astrophysical Observation", "SAO 221103"},
        {"Wilson Evans Batten Catalogue", "WEB 8711"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46224949),
        dec: Angle.Degrees(-42.19473814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219630"},
        {"Hipparcos Number", "HIP 115013"},
        {"Geneva Identification System", "GEN# +1.00219630"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.40748406),
        dec: Angle.Degrees(-42.19154865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207851"},
        {"Hipparcos Number", "HIP 108021"},
        {"Smithsonian Astrophysical Observation", "SAO 230886"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.26521747),
        dec: Angle.Degrees(-42.19135131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134477"},
        {"Hipparcos Number", "HIP 74348"},
        {"Renson", "Renson 38180"},
        {"Smithsonian Astrophysical Observation", "SAO 225522"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.91679065),
        dec: Angle.Degrees(-42.19056042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198082"},
        {"Hipparcos Number", "HIP 102783"},
        {"Smithsonian Astrophysical Observation", "SAO 230392"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.34959377),
        dec: Angle.Degrees(-42.18897406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120095"},
        {"Hipparcos Number", "HIP 67347"},
        {"Geneva Identification System", "GEN# +1.00120095"},
        {"Smithsonian Astrophysical Observation", "SAO 224440"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.05122269),
        dec: Angle.Degrees(-42.18473830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124362"},
        {"Hipparcos Number", "HIP 69550"},
        {"Smithsonian Astrophysical Observation", "SAO 224782"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.55271897),
        dec: Angle.Degrees(-42.18434991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219181"},
        {"Hipparcos Number", "HIP 114721"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.57672079),
        dec: Angle.Degrees(-42.18409888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184234"},
        {"Hipparcos Number", "HIP 96346"},
        {"Smithsonian Astrophysical Observation", "SAO 229754"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.82035717),
        dec: Angle.Degrees(-42.18405486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158623"},
        {"Hipparcos Number", "HIP 85833"},
        {"Renson", "Renson 44640"},
        {"Smithsonian Astrophysical Observation", "SAO 228091"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.08067228),
        dec: Angle.Degrees(-42.18165224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165086"},
        {"Hipparcos Number", "HIP 88679"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.55168434),
        dec: Angle.Degrees(-42.17881295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80834"},
        {"Hipparcos Number", "HIP 45833"},
        {"Geneva Identification System", "GEN# +1.00080834"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.17549008),
        dec: Angle.Degrees(-42.17855444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206565"},
        {"Hipparcos Number", "HIP 107292"},
        {"Geneva Identification System", "GEN# +1.00206565"},
        {"Smithsonian Astrophysical Observation", "SAO 230815"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.98423839),
        dec: Angle.Degrees(-42.17326992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87627"},
        {"Hipparcos Number", "HIP 49413"},
        {"Smithsonian Astrophysical Observation", "SAO 221760"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.30298067),
        dec: Angle.Degrees(-42.17229435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 770"},
        {"Hipparcos Number", "HIP 966"},
        {"Fundamental Katalog 5th Edition", "FK5 2009"},
        {"Smithsonian Astrophysical Observation", "SAO 214999"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.98385733),
        dec: Angle.Degrees(-42.17203471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124940"},
        {"Hipparcos Number", "HIP 69835"},
        {"Geneva Identification System", "GEN# +1.00124940"},
        {"Smithsonian Astrophysical Observation", "SAO 224820"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.38500500),
        dec: Angle.Degrees(-42.17203044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11989"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.65352553),
        dec: Angle.Degrees(-42.17171860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189306"},
        {"Hipparcos Number", "HIP 98539"},
        {"Smithsonian Astrophysical Observation", "SAO 229988"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.26971631),
        dec: Angle.Degrees(-42.16985284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104630"},
        {"Hipparcos Number", "HIP 58747"},
        {"Smithsonian Astrophysical Observation", "SAO 223186"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.73402038),
        dec: Angle.Degrees(-42.16894183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78165"},
        {"Hipparcos Number", "HIP 44612"},
        {"Renson", "Renson 22140"},
        {"Smithsonian Astrophysical Observation", "SAO 220824"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.34744839),
        dec: Angle.Degrees(-42.16713956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172261"},
        {"Hipparcos Number", "HIP 91629"},
        {"Smithsonian Astrophysical Observation", "SAO 229191"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.30466870),
        dec: Angle.Degrees(-42.16665969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60929"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.32858810),
        dec: Angle.Degrees(-42.16623637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134840"},
        {"Hipparcos Number", "HIP 74503"},
        {"Renson", "Renson 38260"},
        {"Smithsonian Astrophysical Observation", "SAO 225549"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.37803165),
        dec: Angle.Degrees(-42.16596913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78353"},
        {"Hipparcos Number", "HIP 44680"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.58670942),
        dec: Angle.Degrees(-42.16580312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1117"},
        {"Hipparcos Number", "HIP 1228"},
        {"Smithsonian Astrophysical Observation", "SAO 215022"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.81692145),
        dec: Angle.Degrees(-42.16494861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188355"},
        {"Hipparcos Number", "HIP 98122"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.13149622),
        dec: Angle.Degrees(-42.16055466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27616"},
        {"Smithsonian Astrophysical Observation", "SAO 150862"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.70929794),
        dec: Angle.Degrees(-10.19992375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221330"},
        {"Hipparcos Number", "HIP 116096"},
        {"Smithsonian Astrophysical Observation", "SAO 231641"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85768572),
        dec: Angle.Degrees(-42.15951210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15122"},
        {"Hipparcos Number", "HIP 11256"},
        {"Smithsonian Astrophysical Observation", "SAO 215894"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.22152251),
        dec: Angle.Degrees(-42.15944368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76692"},
        {"Hipparcos Number", "HIP 43873"},
        {"Smithsonian Astrophysical Observation", "SAO 220672"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.06630296),
        dec: Angle.Degrees(-42.15804451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33953"},
        {"Hipparcos Number", "HIP 24206"},
        {"Smithsonian Astrophysical Observation", "SAO 217229"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.94766094),
        dec: Angle.Degrees(-42.15800316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127972"},
        {"Henry Draper 2", "HD 127973"},
        {"Hipparcos Number", "HIP 71352"},
        {"Fundamental Katalog 5th Edition", "FK5 537"},
        {"Geneva Identification System", "GEN# +1.00127972"},
        {"Smithsonian Astrophysical Observation", "SAO 225044"},
        {"Wilson Evans Batten Catalogue", "WEB 12321"},
    },
    visualMagnitude: 2.33,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.87688163),
        dec: Angle.Degrees(-42.15774562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34999"},
        {"Hipparcos Number", "HIP 24843"},
        {"Smithsonian Astrophysical Observation", "SAO 217286"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.89111403),
        dec: Angle.Degrees(-42.15492069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56585"},
        {"Hipparcos Number", "HIP 35114"},
        {"Smithsonian Astrophysical Observation", "SAO 218575"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.90757765),
        dec: Angle.Degrees(-42.15425012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42303"},
        {"Hipparcos Number", "HIP 29064"},
        {"Geneva Identification System", "GEN# +1.00042303"},
        {"Smithsonian Astrophysical Observation", "SAO 217730"},
        {"Wilson Evans Batten Catalogue", "WEB 5693"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.97028171),
        dec: Angle.Degrees(-42.15400130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76802"},
        {"Hipparcos Number", "HIP 43934"},
        {"Celescope Catalog", "CEL 3099"},
        {"Geneva Identification System", "GEN# +1.00076802"},
        {"Renson", "Renson 21660"},
        {"Smithsonian Astrophysical Observation", "SAO 220685"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.23811233),
        dec: Angle.Degrees(-42.15395346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 643"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.97791396),
        dec: Angle.Degrees(-42.15385091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79069"},
        {"Hipparcos Number", "HIP 45048"},
        {"Smithsonian Astrophysical Observation", "SAO 220918"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.63410278),
        dec: Angle.Degrees(-42.15342860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71459"},
        {"Hipparcos Number", "HIP 41323"},
        {"Celescope Catalog", "CEL 2499"},
        {"Geneva Identification System", "GEN# +1.00071459"},
        {"Smithsonian Astrophysical Observation", "SAO 219910"},
        {"Wilson Evans Batten Catalogue", "WEB 7999"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.46634614),
        dec: Angle.Degrees(-42.15310407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 324239"},
        {"Hipparcos Number", "HIP 86767"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.94424243),
        dec: Angle.Degrees(-42.15164794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22314"},
        {"Hipparcos Number", "HIP 16620"},
        {"Smithsonian Astrophysical Observation", "SAO 216384"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.46643582),
        dec: Angle.Degrees(-42.15159211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38888"},
        {"Hipparcos Number", "HIP 27282"},
        {"Smithsonian Astrophysical Observation", "SAO 217526"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.72303683),
        dec: Angle.Degrees(-42.15090834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51769",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51769"},
        {"Geneva Identification System", "GEN# -0.00903102"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.68101323),
        dec: Angle.Degrees(-10.10988940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100034"},
        {"Hipparcos Number", "HIP 56125"},
        {"Smithsonian Astrophysical Observation", "SAO 222823"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.57671531),
        dec: Angle.Degrees(-42.15017275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129834"},
        {"Hipparcos Number", "HIP 72211"},
        {"Smithsonian Astrophysical Observation", "SAO 225176"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.53176334),
        dec: Angle.Degrees(-42.14788376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180390"},
        {"Hipparcos Number", "HIP 94864"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.55671755),
        dec: Angle.Degrees(-42.14703097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64013"},
        {"Hipparcos Number", "HIP 38230"},
        {"Celescope Catalog", "CEL 2057"},
        {"Geneva Identification System", "GEN# +1.00064013"},
        {"Smithsonian Astrophysical Observation", "SAO 219048"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.48681319),
        dec: Angle.Degrees(-42.14575989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50180"},
        {"Hipparcos Number", "HIP 32780"},
        {"Fundamental Katalog 5th Edition", "FK5 4624"},
        {"Smithsonian Astrophysical Observation", "SAO 218233"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.51395546),
        dec: Angle.Degrees(-42.14537782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199813"},
        {"Hipparcos Number", "HIP 103710"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22417699),
        dec: Angle.Degrees(-42.14391830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47680"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.83099507),
        dec: Angle.Degrees(-42.14069678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56641"},
        {"Hipparcos Number", "HIP 35147"},
        {"Smithsonian Astrophysical Observation", "SAO 218578"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.97932662),
        dec: Angle.Degrees(-42.14023170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71528"},
        {"Hipparcos Number", "HIP 41357"},
        {"Celescope Catalog", "CEL 2507"},
        {"Geneva Identification System", "GEN# +1.00071528"},
        {"Smithsonian Astrophysical Observation", "SAO 219915"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.56618689),
        dec: Angle.Degrees(-42.13749231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131837"},
        {"Hipparcos Number", "HIP 73168"},
        {"Smithsonian Astrophysical Observation", "SAO 225318"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.30250486),
        dec: Angle.Degrees(-42.13742870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32601"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.02002158),
        dec: Angle.Degrees(-42.13503232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92375"},
        {"Hipparcos Number", "HIP 52148"},
        {"Smithsonian Astrophysical Observation", "SAO 222228"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.79896143),
        dec: Angle.Degrees(-42.13396478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196829"},
        {"Hipparcos Number", "HIP 102096"},
        {"Geneva Identification System", "GEN# +1.00196829"},
        {"Smithsonian Astrophysical Observation", "SAO 230323"},
        {"Wilson Evans Batten Catalogue", "WEB 18463"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.35261383),
        dec: Angle.Degrees(-42.13369967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124414"},
        {"Hipparcos Number", "HIP 69593"},
        {"Smithsonian Astrophysical Observation", "SAO 224788"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67101520),
        dec: Angle.Degrees(-42.13249602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10969"},
        {"Hipparcos Number", "HIP 8287"},
        {"Smithsonian Astrophysical Observation", "SAO 215647"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.69500741),
        dec: Angle.Degrees(-42.13198193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116033"},
        {"Hipparcos Number", "HIP 65200"},
        {"Smithsonian Astrophysical Observation", "SAO 224086"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.43445437),
        dec: Angle.Degrees(-42.13171197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138926"},
        {"Hipparcos Number", "HIP 76435"},
        {"Smithsonian Astrophysical Observation", "SAO 225970"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.17000813),
        dec: Angle.Degrees(-42.13015514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206667"},
        {"Hipparcos Number", "HIP 107362"},
        {"Geneva Identification System", "GEN# +1.00206667"},
        {"Smithsonian Astrophysical Observation", "SAO 230819"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.18667116),
        dec: Angle.Degrees(-42.12956811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28537"},
        {"Hipparcos Number", "HIP 20853"},
        {"Smithsonian Astrophysical Observation", "SAO 216819"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.02674668),
        dec: Angle.Degrees(-42.12912530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175129"},
        {"Hipparcos Number", "HIP 92915"},
        {"Smithsonian Astrophysical Observation", "SAO 229378"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.96536366),
        dec: Angle.Degrees(-42.12659912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85279"},
        {"Hipparcos Number", "HIP 48204"},
        {"Smithsonian Astrophysical Observation", "SAO 221520"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.41266842),
        dec: Angle.Degrees(-42.12443051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33041"},
        {"Hipparcos Number", "HIP 23690"},
        {"Smithsonian Astrophysical Observation", "SAO 217167"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.37337179),
        dec: Angle.Degrees(-42.12441587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6190"},
        {"Hipparcos Number", "HIP 4848"},
        {"Smithsonian Astrophysical Observation", "SAO 215338"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.58966857),
        dec: Angle.Degrees(-42.12351323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149313"},
        {"Hipparcos Number", "HIP 81256"},
        {"Geneva Identification System", "GEN# +1.00149313"},
        {"Smithsonian Astrophysical Observation", "SAO 226943"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95275663),
        dec: Angle.Degrees(-42.12290318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88955"},
        {"Hipparcos Number", "HIP 50191"},
        {"Fundamental Katalog 5th Edition", "FK5 382"},
        {"Geneva Identification System", "GEN# +1.00088955"},
        {"Smithsonian Astrophysical Observation", "SAO 221895"},
        {"Wilson Evans Batten Catalogue", "WEB 9221"},
    },
    visualMagnitude: 3.85,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.68447399),
        dec: Angle.Degrees(-42.12206281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55787"},
        {"Hipparcos Number", "HIP 34821"},
        {"Smithsonian Astrophysical Observation", "SAO 218529"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.11346697),
        dec: Angle.Degrees(-42.12022432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150386"},
        {"Hipparcos Number", "HIP 81818"},
        {"Geneva Identification System", "GEN# +1.00150386"},
        {"Smithsonian Astrophysical Observation", "SAO 227083"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.67261163),
        dec: Angle.Degrees(-42.11842470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184991"},
        {"Hipparcos Number", "HIP 96641"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.72447886),
        dec: Angle.Degrees(-42.11817468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174860"},
        {"Hipparcos Number", "HIP 92802"},
        {"Smithsonian Astrophysical Observation", "SAO 229362"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.64111662),
        dec: Angle.Degrees(-42.11656398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16240"},
        {"Hipparcos Number", "HIP 12016"},
        {"Geneva Identification System", "GEN# +1.00016240"},
        {"Smithsonian Astrophysical Observation", "SAO 215950"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.74880983),
        dec: Angle.Degrees(-42.11285164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44968"},
        {"Geneva Identification System", "GEN# -0.04104851A"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.41066585),
        dec: Angle.Degrees(-42.11081273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 226.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67125"},
        {"Hipparcos Number", "HIP 39543"},
        {"Smithsonian Astrophysical Observation", "SAO 219385"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21212905),
        dec: Angle.Degrees(-42.11051948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44965"},
        {"Geneva Identification System", "GEN# -0.04104851B"},
    },
    visualMagnitude: 11.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.40273399),
        dec: Angle.Degrees(-42.10866674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58962"},
        {"Hipparcos Number", "HIP 36074"},
        {"Smithsonian Astrophysical Observation", "SAO 218717"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.49754447),
        dec: Angle.Degrees(-42.10801658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132200"},
        {"Hipparcos Number", "HIP 73334"},
        {"Celescope Catalog", "CEL 4330"},
        {"Fundamental Katalog 5th Edition", "FK5 553"},
        {"Geneva Identification System", "GEN# +1.00132200"},
        {"Smithsonian Astrophysical Observation", "SAO 225344"},
        {"Wilson Evans Batten Catalogue", "WEB 12558"},
    },
    visualMagnitude: 3.13,
    bvColour: -0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.79041254),
        dec: Angle.Degrees(-42.10414199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1106"},
        {"Hipparcos Number", "HIP 1221"},
        {"Smithsonian Astrophysical Observation", "SAO 215020"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.80633024),
        dec: Angle.Degrees(-42.10338272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175505"},
        {"Hipparcos Number", "HIP 93071"},
        {"Smithsonian Astrophysical Observation", "SAO 229402"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.38525010),
        dec: Angle.Degrees(-42.10337958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72996"},
        {"Hipparcos Number", "HIP 42048"},
        {"Smithsonian Astrophysical Observation", "SAO 220118"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.55368442),
        dec: Angle.Degrees(-42.10249756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156706"},
        {"Hipparcos Number", "HIP 84897"},
        {"Geneva Identification System", "GEN# +1.00156706"},
        {"Smithsonian Astrophysical Observation", "SAO 227850"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.25966085),
        dec: Angle.Degrees(-42.10235759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121743"},
        {"Hipparcos Number", "HIP 68245"},
        {"Geneva Identification System", "GEN# +1.00121743"},
        {"Smithsonian Astrophysical Observation", "SAO 224577"},
        {"Wilson Evans Batten Catalogue", "WEB 11971"},
    },
    visualMagnitude: 3.83,
    bvColour: -0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.56785278),
        dec: Angle.Degrees(-42.10070526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186299"},
        {"Hipparcos Number", "HIP 97205"},
        {"Geneva Identification System", "GEN# +1.00186299"},
        {"Smithsonian Astrophysical Observation", "SAO 229850"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.34331948),
        dec: Angle.Degrees(-42.10008363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127716"},
        {"Hipparcos Number", "HIP 71239"},
        {"Geneva Identification System", "GEN# +1.00127716"},
        {"Smithsonian Astrophysical Observation", "SAO 225027"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.53324940),
        dec: Angle.Degrees(-42.09922949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46974"},
        {"Hipparcos Number", "HIP 31330"},
        {"Geneva Identification System", "GEN# +1.00046974"},
        {"Smithsonian Astrophysical Observation", "SAO 218028"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.54258553),
        dec: Angle.Degrees(-42.09892856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138782"},
        {"Hipparcos Number", "HIP 76364"},
        {"Smithsonian Astrophysical Observation", "SAO 225951"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.95203540),
        dec: Angle.Degrees(-42.09840216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88382"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.71981059),
        dec: Angle.Degrees(-42.09766403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43491"},
        {"Hipparcos Number", "HIP 29612"},
        {"Smithsonian Astrophysical Observation", "SAO 217796"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.60514550),
        dec: Angle.Degrees(-42.09660105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112867"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.84706498),
        dec: Angle.Degrees(-42.09542506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176638"},
        {"Hipparcos Number", "HIP 93542"},
        {"Fundamental Katalog 5th Edition", "FK5 3519"},
        {"Geneva Identification System", "GEN# +1.00176638"},
        {"Smithsonian Astrophysical Observation", "SAO 229461"},
        {"Wilson Evans Batten Catalogue", "WEB 16243"},
    },
    visualMagnitude: 4.74,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.77846922),
        dec: Angle.Degrees(-42.09499443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91716"},
        {"Hipparcos Number", "HIP 51766"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.66757737),
        dec: Angle.Degrees(-42.09477161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183485"},
        {"Hipparcos Number", "HIP 96041"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92519351),
        dec: Angle.Degrees(-42.09430178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187369"},
        {"Hipparcos Number", "HIP 97710"},
        {"Geneva Identification System", "GEN# +1.00187369"},
        {"Smithsonian Astrophysical Observation", "SAO 229895"},
        {"Wilson Evans Batten Catalogue", "WEB 17187"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.86363559),
        dec: Angle.Degrees(-42.09329105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152424"},
        {"Hipparcos Number", "HIP 82783"},
        {"Celescope Catalog", "CEL 4452"},
        {"Geneva Identification System", "GEN# +1.00152424"},
        {"Smithsonian Astrophysical Observation", "SAO 227430"},
        {"Wilson Evans Batten Catalogue", "WEB 13996"},
        {"New General Catalogue", "NGC 6231 328"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.76387657),
        dec: Angle.Degrees(-42.09082407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75759"},
        {"Hipparcos Number", "HIP 43392"},
        {"Celescope Catalog", "CEL 2980"},
        {"Geneva Identification System", "GEN# +1.00075759"},
        {"Smithsonian Astrophysical Observation", "SAO 220552"},
        {"Wilson Evans Batten Catalogue", "WEB 8360"},
    },
    visualMagnitude: 6.00,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.58758781),
        dec: Angle.Degrees(-42.08979986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197113"},
        {"Hipparcos Number", "HIP 102245"},
        {"Smithsonian Astrophysical Observation", "SAO 230337"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.76971446),
        dec: Angle.Degrees(-42.08919048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56531"},
        {"Hipparcos Number", "HIP 35090"},
        {"Celescope Catalog", "CEL 1725"},
        {"Geneva Identification System", "GEN# +1.00056531J"},
        {"Smithsonian Astrophysical Observation", "SAO 218572"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.84999908),
        dec: Angle.Degrees(-42.08803105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83356"},
        {"Hipparcos Number", "HIP 47161"},
        {"Smithsonian Astrophysical Observation", "SAO 221340"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.15304718),
        dec: Angle.Degrees(-42.08485972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209189"},
        {"Hipparcos Number", "HIP 108800"},
        {"Smithsonian Astrophysical Observation", "SAO 230954"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.61661996),
        dec: Angle.Degrees(-42.08409365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179008"},
        {"Hipparcos Number", "HIP 94392"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18377824),
        dec: Angle.Degrees(-42.08125389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110710"},
        {"Hipparcos Number", "HIP 62155"},
        {"Geneva Identification System", "GEN# +1.00110710"},
        {"Smithsonian Astrophysical Observation", "SAO 223635"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.08364840),
        dec: Angle.Degrees(-42.07985653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199983"},
        {"Hipparcos Number", "HIP 103794"},
        {"Smithsonian Astrophysical Observation", "SAO 230490"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.48038073),
        dec: Angle.Degrees(-42.07958668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90157"},
        {"Hipparcos Number", "HIP 50891"},
        {"Smithsonian Astrophysical Observation", "SAO 222012"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.87682736),
        dec: Angle.Degrees(-42.07924880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102186"},
        {"Hipparcos Number", "HIP 57358"},
        {"Smithsonian Astrophysical Observation", "SAO 223000"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38718521),
        dec: Angle.Degrees(-42.07889720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72778"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.15247303),
        dec: Angle.Degrees(-42.07618516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15590"},
        {"Hipparcos Number", "HIP 11575"},
        {"Geneva Identification System", "GEN# +1.00015590"},
        {"Smithsonian Astrophysical Observation", "SAO 215917"},
        {"Wilson Evans Batten Catalogue", "WEB 2413"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.29958059),
        dec: Angle.Degrees(-42.07529301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68089"},
        {"Hipparcos Number", "HIP 39911"},
        {"Cincinnati Publication", "Ci 20 460"},
        {"Geneva Identification System", "GEN# +1.00068089"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.27228339),
        dec: Angle.Degrees(-42.07504136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -396.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 193.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131030"},
        {"Hipparcos Number", "HIP 72781"},
        {"Smithsonian Astrophysical Observation", "SAO 225265"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.15861664),
        dec: Angle.Degrees(-42.07499538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217899"},
        {"Hipparcos Number", "HIP 113943"},
        {"Smithsonian Astrophysical Observation", "SAO 231423"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.11345293),
        dec: Angle.Degrees(-42.07430915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60791"},
        {"Hipparcos Number", "HIP 36825"},
        {"Smithsonian Astrophysical Observation", "SAO 218812"},
    },
    visualMagnitude: 7.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.59678214),
        dec: Angle.Degrees(-42.07378258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110966"},
        {"Hipparcos Number", "HIP 62313"},
        {"Smithsonian Astrophysical Observation", "SAO 223656"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.52495914),
        dec: Angle.Degrees(-42.07290640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153382"},
        {"Hipparcos Number", "HIP 83266"},
        {"Geneva Identification System", "GEN# +1.00153382J"},
        {"Smithsonian Astrophysical Observation", "SAO 227552"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.27524765),
        dec: Angle.Degrees(-42.07174463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209070"},
        {"Hipparcos Number", "HIP 108734"},
        {"Smithsonian Astrophysical Observation", "SAO 230946"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.39140100),
        dec: Angle.Degrees(-42.07103772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198375"},
        {"Hipparcos Number", "HIP 102934"},
        {"Smithsonian Astrophysical Observation", "SAO 230403"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.82784380),
        dec: Angle.Degrees(-42.07043228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144350"},
        {"Hipparcos Number", "HIP 78966"},
        {"Geneva Identification System", "GEN# +1.00144350"},
        {"Smithsonian Astrophysical Observation", "SAO 226517"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.80641511),
        dec: Angle.Degrees(-42.06956145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12797"},
        {"Hipparcos Number", "HIP 9673"},
        {"Smithsonian Astrophysical Observation", "SAO 215757"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.10606743),
        dec: Angle.Degrees(-42.06774945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119361"},
        {"Hipparcos Number", "HIP 66984"},
        {"Geneva Identification System", "GEN# +1.00119361J"},
        {"Smithsonian Astrophysical Observation", "SAO 224365"},
        {"Wilson Evans Batten Catalogue", "WEB 11804"},
    },
    visualMagnitude: 5.96,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91706644),
        dec: Angle.Degrees(-42.06751103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36380"},
        {"Hipparcos Number", "HIP 25699"},
        {"Smithsonian Astrophysical Observation", "SAO 217357"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.32227168),
        dec: Angle.Degrees(-42.06619504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180751"},
        {"Hipparcos Number", "HIP 94971"},
        {"Geneva Identification System", "GEN# +1.00180751"},
        {"Smithsonian Astrophysical Observation", "SAO 229619"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.88777895),
        dec: Angle.Degrees(-42.06519926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113765"},
        {"Hipparcos Number", "HIP 63961"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.61282721),
        dec: Angle.Degrees(-42.06218148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150214"},
        {"Hipparcos Number", "HIP 81712"},
        {"Smithsonian Astrophysical Observation", "SAO 227059"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.35326342),
        dec: Angle.Degrees(-42.06049553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70424"},
        {"Hipparcos Number", "HIP 40856"},
        {"Smithsonian Astrophysical Observation", "SAO 219800"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.05174357),
        dec: Angle.Degrees(-42.05887905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224622"},
        {"Hipparcos Number", "HIP 118271"},
        {"Geneva Identification System", "GEN# +1.00224622"},
        {"Smithsonian Astrophysical Observation", "SAO 231876"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.83281660),
        dec: Angle.Degrees(-42.05630413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194326"},
        {"Hipparcos Number", "HIP 100830"},
        {"Fundamental Katalog 5th Edition", "FK5 5804"},
        {"Smithsonian Astrophysical Observation", "SAO 230205"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.66669266),
        dec: Angle.Degrees(-42.05549498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89765"},
        {"Hipparcos Number", "HIP 50647"},
        {"Smithsonian Astrophysical Observation", "SAO 221975"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.15620960),
        dec: Angle.Degrees(-42.05523294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115128"},
        {"Hipparcos Number", "HIP 64712"},
        {"Smithsonian Astrophysical Observation", "SAO 224015"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.94595095),
        dec: Angle.Degrees(-42.05488245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201621"},
        {"Hipparcos Number", "HIP 104675"},
        {"Geneva Identification System", "GEN# +1.00201621"},
        {"Smithsonian Astrophysical Observation", "SAO 230574"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.04064939),
        dec: Angle.Degrees(-42.05377148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213657"},
        {"Hipparcos Number", "HIP 111372"},
        {"Geneva Identification System", "GEN# +1.00213657"},
        {"Smithsonian Astrophysical Observation", "SAO 231191"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.44626577),
        dec: Angle.Degrees(-42.05322056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90654"},
        {"Hipparcos Number", "HIP 51173"},
        {"Smithsonian Astrophysical Observation", "SAO 222060"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.79039091),
        dec: Angle.Degrees(-42.05300988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193571"},
        {"Hipparcos Number", "HIP 100469"},
        {"Fundamental Katalog 5th Edition", "FK5 763"},
        {"Geneva Identification System", "GEN# +1.00193571"},
        {"Smithsonian Astrophysical Observation", "SAO 230177"},
        {"Wilson Evans Batten Catalogue", "WEB 18143"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.61449749),
        dec: Angle.Degrees(-42.04934895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23718"},
        {"Hipparcos Number", "HIP 17555"},
        {"Smithsonian Astrophysical Observation", "SAO 216471"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.39181389),
        dec: Angle.Degrees(-42.04867695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197200"},
        {"Hipparcos Number", "HIP 102307"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.93539748),
        dec: Angle.Degrees(-42.04835981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202545"},
        {"Hipparcos Number", "HIP 105132"},
        {"Smithsonian Astrophysical Observation", "SAO 230617"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.46592791),
        dec: Angle.Degrees(-42.04666725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103438"},
        {"Hipparcos Number", "HIP 58064"},
        {"Smithsonian Astrophysical Observation", "SAO 223099"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.62544668),
        dec: Angle.Degrees(-42.04487933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95065"},
        {"Hipparcos Number", "HIP 53605"},
        {"Smithsonian Astrophysical Observation", "SAO 222458"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.49555097),
        dec: Angle.Degrees(-42.03934972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16890"},
        {"Hipparcos Number", "HIP 12519"},
        {"Smithsonian Astrophysical Observation", "SAO 216004"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.27887734),
        dec: Angle.Degrees(-42.03639836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205325"},
        {"Hipparcos Number", "HIP 106619"},
        {"Smithsonian Astrophysical Observation", "SAO 230744"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.92685133),
        dec: Angle.Degrees(-42.03585700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83861"},
        {"Hipparcos Number", "HIP 47438"},
        {"Smithsonian Astrophysical Observation", "SAO 221390"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.00862260),
        dec: Angle.Degrees(-42.03404688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71077"},
        {"Hipparcos Number", "HIP 41151"},
        {"Geneva Identification System", "GEN# +1.00071077"},
        {"Smithsonian Astrophysical Observation", "SAO 219871"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.94894267),
        dec: Angle.Degrees(-42.03385755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217746"},
        {"Hipparcos Number", "HIP 113848"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.83008059),
        dec: Angle.Degrees(-42.03340861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148371"},
        {"Hipparcos Number", "HIP 80759"},
        {"Smithsonian Astrophysical Observation", "SAO 226811"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.33603795),
        dec: Angle.Degrees(-42.03327941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145881"},
        {"Hipparcos Number", "HIP 79635"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.76577239),
        dec: Angle.Degrees(-42.03306532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12296"},
        {"Hipparcos Number", "HIP 9313"},
        {"Geneva Identification System", "GEN# +1.00012296"},
        {"Smithsonian Astrophysical Observation", "SAO 215726"},
        {"Wilson Evans Batten Catalogue", "WEB 1956"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.91189289),
        dec: Angle.Degrees(-42.03028941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110653"},
        {"Smithsonian Astrophysical Observation", "SAO 231127"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.25406358),
        dec: Angle.Degrees(-42.03007831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29277"},
        {"Hipparcos Number", "HIP 21339"},
        {"Smithsonian Astrophysical Observation", "SAO 216881"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.68723863),
        dec: Angle.Degrees(-42.02929938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103713"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.23835497),
        dec: Angle.Degrees(-42.02909236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 408.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161393"},
        {"Hipparcos Number", "HIP 87054"},
        {"Smithsonian Astrophysical Observation", "SAO 228415"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.82893391),
        dec: Angle.Degrees(-42.02906503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52060"},
        {"Hipparcos Number", "HIP 33498"},
        {"Smithsonian Astrophysical Observation", "SAO 218340"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.44466157),
        dec: Angle.Degrees(-42.02872834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212435"},
        {"Hipparcos Number", "HIP 110654"},
        {"Renson", "Renson 58940"},
        {"Smithsonian Astrophysical Observation", "SAO 231128"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.25831715),
        dec: Angle.Degrees(-42.02856073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169052"},
        {"Hipparcos Number", "HIP 90233"},
        {"Smithsonian Astrophysical Observation", "SAO 228993"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.16426049),
        dec: Angle.Degrees(-42.02806412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158382"},
        {"Hipparcos Number", "HIP 85710"},
        {"Geneva Identification System", "GEN# +1.00158382"},
        {"Smithsonian Astrophysical Observation", "SAO 228058"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.72530776),
        dec: Angle.Degrees(-42.02805294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125718"},
        {"Hipparcos Number", "HIP 70241"},
        {"Geneva Identification System", "GEN# +1.00125718"},
        {"Smithsonian Astrophysical Observation", "SAO 224869"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.57462305),
        dec: Angle.Degrees(-42.02381161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83442"},
        {"Hipparcos Number", "HIP 47206"},
        {"Smithsonian Astrophysical Observation", "SAO 221347"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.30424240),
        dec: Angle.Degrees(-42.02073734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14486"},
        {"Hipparcos Number", "HIP 10811"},
        {"Smithsonian Astrophysical Observation", "SAO 215859"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.78623518),
        dec: Angle.Degrees(-42.01967123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33562"},
        {"Hipparcos Number", "HIP 23968"},
        {"Geneva Identification System", "GEN# +1.00033562"},
        {"Smithsonian Astrophysical Observation", "SAO 217201"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28138139),
        dec: Angle.Degrees(-42.01877213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94607"},
        {"Hipparcos Number", "HIP 53356"},
        {"Smithsonian Astrophysical Observation", "SAO 222417"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68041259),
        dec: Angle.Degrees(-42.01809780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44530"},
        {"Hipparcos Number", "HIP 30113"},
        {"Geneva Identification System", "GEN# +1.00044530"},
        {"Smithsonian Astrophysical Observation", "SAO 217859"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.05825425),
        dec: Angle.Degrees(-42.01647475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3946"},
        {"Hipparcos Number", "HIP 3271"},
        {"Smithsonian Astrophysical Observation", "SAO 215197"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.41964817),
        dec: Angle.Degrees(-42.01598569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181401"},
        {"Hipparcos Number", "HIP 95211"},
        {"Geneva Identification System", "GEN# +1.00181401"},
        {"Smithsonian Astrophysical Observation", "SAO 229643"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.53988002),
        dec: Angle.Degrees(-42.01595158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195226"},
        {"Hipparcos Number", "HIP 101269"},
        {"Smithsonian Astrophysical Observation", "SAO 230255"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.90169705),
        dec: Angle.Degrees(-42.01525231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163959"},
        {"Hipparcos Number", "HIP 88205"},
        {"Smithsonian Astrophysical Observation", "SAO 228621"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.18540757),
        dec: Angle.Degrees(-42.01227956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90768"},
        {"Hipparcos Number", "HIP 51244"},
        {"Smithsonian Astrophysical Observation", "SAO 222076"},
        {"Smithsonian Astrophysical Observation 2", "SAO 222077"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.99638036),
        dec: Angle.Degrees(-42.00991033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7706"},
        {"Hipparcos Number", "HIP 5927"},
        {"Geneva Identification System", "GEN# +1.00007706"},
        {"Smithsonian Astrophysical Observation", "SAO 215433"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.05036531),
        dec: Angle.Degrees(-42.00966444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200058"},
        {"Hipparcos Number", "HIP 103830"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.60382888),
        dec: Angle.Degrees(-42.00884583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70307"},
        {"Hipparcos Number", "HIP 40789"},
        {"Celescope Catalog", "CEL 2373"},
        {"Geneva Identification System", "GEN# +1.00070307"},
        {"Smithsonian Astrophysical Observation", "SAO 219788"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.87406357),
        dec: Angle.Degrees(-42.00881124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41662"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.41868992),
        dec: Angle.Degrees(-09.97650145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97394"},
        {"Geneva Identification System", "GEN# -0.04214462"},
        {"Wilson Evans Batten Catalogue", "WEB 17115"},
    },
    visualMagnitude: 10.32,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.91877292),
        dec: Angle.Degrees(-42.00723353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78383"},
        {"Hipparcos Number", "HIP 44698"},
        {"Smithsonian Astrophysical Observation", "SAO 220854"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.62946719),
        dec: Angle.Degrees(-42.00525292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59079"},
        {"Hipparcos Number", "HIP 36124"},
        {"Celescope Catalog", "CEL 1857"},
        {"Smithsonian Astrophysical Observation", "SAO 218723"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.61629344),
        dec: Angle.Degrees(-42.00471582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190620"},
        {"Hipparcos Number", "HIP 99135"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.88862428),
        dec: Angle.Degrees(-42.00411928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147123"},
        {"Hipparcos Number", "HIP 80160"},
        {"Renson", "Renson 41570"},
        {"Smithsonian Astrophysical Observation", "SAO 226686"},
        {"Wilson Evans Batten Catalogue", "WEB 13568"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.44070937),
        dec: Angle.Degrees(-42.00368561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32400"},
        {"Hipparcos Number", "HIP 23321"},
        {"Fundamental Katalog 5th Edition", "FK5 4458"},
        {"Smithsonian Astrophysical Observation", "SAO 217114"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.23546161),
        dec: Angle.Degrees(-42.00303215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92633"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11645978),
        dec: Angle.Degrees(-42.00270084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10589"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.08842863),
        dec: Angle.Degrees(-42.00210087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151515"},
        {"Hipparcos Number", "HIP 82366"},
        {"Celescope Catalog", "CEL 4429"},
        {"Geneva Identification System", "GEN# +1.00151515"},
        {"Smithsonian Astrophysical Observation", "SAO 227272"},
        {"New General Catalogue", "NGC 6231 301"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.45105398),
        dec: Angle.Degrees(-42.00171288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29370"},
        {"Hipparcos Number", "HIP 21404"},
        {"Geneva Identification System", "GEN# +1.00029370"},
        {"Smithsonian Astrophysical Observation", "SAO 216886"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.91686190),
        dec: Angle.Degrees(-42.00154507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41246"},
        {"Hipparcos Number", "HIP 28572"},
        {"Smithsonian Astrophysical Observation", "SAO 217680"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.45545778),
        dec: Angle.Degrees(-42.00145094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162544"},
        {"Hipparcos Number", "HIP 87587"},
        {"Smithsonian Astrophysical Observation", "SAO 228518"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.38379556),
        dec: Angle.Degrees(-42.00124828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80723"},
        {"Hipparcos Number", "HIP 45770"},
        {"Smithsonian Astrophysical Observation", "SAO 221070"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99369137),
        dec: Angle.Degrees(-42.00005800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97756"},
        {"Hipparcos Number", "HIP 54894"},
        {"Smithsonian Astrophysical Observation", "SAO 222662"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.60149730),
        dec: Angle.Degrees(-41.99991143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60270"},
        {"Hipparcos Number", "HIP 36614"},
        {"Smithsonian Astrophysical Observation", "SAO 218781"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.94652896),
        dec: Angle.Degrees(-41.99873781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155165"},
        {"Hipparcos Number", "HIP 84117"},
        {"Smithsonian Astrophysical Observation", "SAO 227706"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.95780617),
        dec: Angle.Degrees(-41.99795531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224067"},
        {"Hipparcos Number", "HIP 117903"},
        {"Smithsonian Astrophysical Observation", "SAO 231844"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.72057210),
        dec: Angle.Degrees(-41.99772163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112760"},
        {"Hipparcos Number", "HIP 63402"},
        {"Smithsonian Astrophysical Observation", "SAO 223814"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.88418754),
        dec: Angle.Degrees(-41.99708905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162396"},
        {"Hipparcos Number", "HIP 87523"},
        {"Geneva Identification System", "GEN# +1.00162396"},
        {"Smithsonian Astrophysical Observation", "SAO 228510"},
        {"Wilson Evans Batten Catalogue", "WEB 14761"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.21863448),
        dec: Angle.Degrees(-41.99605927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203641"},
        {"Hipparcos Number", "HIP 105721"},
        {"Geneva Identification System", "GEN# +1.00203641"},
        {"Smithsonian Astrophysical Observation", "SAO 230670"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.19390104),
        dec: Angle.Degrees(-41.99589955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109723"},
        {"Hipparcos Number", "HIP 61580"},
        {"Geneva Identification System", "GEN# +1.00109723"},
        {"Smithsonian Astrophysical Observation", "SAO 223554"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.28520824),
        dec: Angle.Degrees(-41.99526698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121333"},
        {"Hipparcos Number", "HIP 68019"},
        {"Smithsonian Astrophysical Observation", "SAO 224548"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.93382604),
        dec: Angle.Degrees(-41.99492355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152235"},
        {"Hipparcos Number", "HIP 82669"},
        {"Geneva Identification System", "GEN# +1.00152235"},
        {"Smithsonian Astrophysical Observation", "SAO 227374"},
        {"Wilson Evans Batten Catalogue", "WEB 13961"},
        {"New General Catalogue", "NGC 6231 317"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.49522453),
        dec: Angle.Degrees(-41.99432103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120075"},
        {"Hipparcos Number", "HIP 67334"},
        {"Smithsonian Astrophysical Observation", "SAO 224437"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.01069893),
        dec: Angle.Degrees(-41.99393355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26612"},
        {"Hipparcos Number", "HIP 19515"},
        {"Geneva Identification System", "GEN# +1.00026612"},
        {"Smithsonian Astrophysical Observation", "SAO 216682"},
        {"Wilson Evans Batten Catalogue", "WEB 3738"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.71013758),
        dec: Angle.Degrees(-41.99374121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132899"},
        {"Hipparcos Number", "HIP 73633"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.77512425),
        dec: Angle.Degrees(-41.99206698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14891"},
        {"Hipparcos Number", "HIP 11113"},
        {"Smithsonian Astrophysical Observation", "SAO 215883"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.74899665),
        dec: Angle.Degrees(-41.99042278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57896"},
        {"Hipparcos Number", "HIP 35645"},
        {"Celescope Catalog", "CEL 1803"},
        {"Smithsonian Astrophysical Observation", "SAO 218663"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.33615742),
        dec: Angle.Degrees(-41.99035050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221241"},
        {"Hipparcos Number", "HIP 116025"},
        {"Smithsonian Astrophysical Observation", "SAO 231638"},
        {"Smithsonian Astrophysical Observation 2", "SAO 231637"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.64248752),
        dec: Angle.Degrees(-41.98860353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195781"},
        {"Hipparcos Number", "HIP 101557"},
        {"Smithsonian Astrophysical Observation", "SAO 230282"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.72740134),
        dec: Angle.Degrees(-41.98689617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88837"},
        {"Hipparcos Number", "HIP 50116"},
        {"Smithsonian Astrophysical Observation", "SAO 221880"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.46786846),
        dec: Angle.Degrees(-41.98661780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213641"},
        {"Hipparcos Number", "HIP 111361"},
        {"Smithsonian Astrophysical Observation", "SAO 231190"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.41457205),
        dec: Angle.Degrees(-41.98514506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206757"},
        {"Hipparcos Number", "HIP 107415"},
        {"Smithsonian Astrophysical Observation", "SAO 230826"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.34807294),
        dec: Angle.Degrees(-41.98380686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31825"},
        {"Hipparcos Number", "HIP 23012"},
        {"Smithsonian Astrophysical Observation", "SAO 217074"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24505898),
        dec: Angle.Degrees(-41.98366459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28048"},
        {"Hipparcos Number", "HIP 20519"},
        {"Smithsonian Astrophysical Observation", "SAO 216777"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.95574009),
        dec: Angle.Degrees(-41.98305068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42625"},
        {"Hipparcos Number", "HIP 29217"},
        {"Geneva Identification System", "GEN# +1.00042625"},
        {"Smithsonian Astrophysical Observation", "SAO 217743"},
        {"Smithsonian Astrophysical Observation 2", "SAO 217746"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.41481951),
        dec: Angle.Degrees(-41.98045851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98476"},
        {"Hipparcos Number", "HIP 55286"},
        {"Geneva Identification System", "GEN# +1.00098476"},
        {"Smithsonian Astrophysical Observation", "SAO 222715"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.84059469),
        dec: Angle.Degrees(-41.98006816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146474"},
        {"Hipparcos Number", "HIP 79886"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.59496943),
        dec: Angle.Degrees(-41.97995704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84068"},
        {"Hipparcos Number", "HIP 47528"},
        {"Geneva Identification System", "GEN# +1.00084068"},
        {"Smithsonian Astrophysical Observation", "SAO 221404"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.34537825),
        dec: Angle.Degrees(-41.97912641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153177"},
        {"Hipparcos Number", "HIP 83161"},
        {"Geneva Identification System", "GEN# +1.00153177"},
        {"Smithsonian Astrophysical Observation", "SAO 227532"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.93176377),
        dec: Angle.Degrees(-41.97859614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163254"},
        {"Hipparcos Number", "HIP 87886"},
        {"Celescope Catalog", "CEL 4579"},
        {"Geneva Identification System", "GEN# +1.00163254"},
        {"Smithsonian Astrophysical Observation", "SAO 228569"},
        {"Wilson Evans Batten Catalogue", "WEB 14838"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.29336429),
        dec: Angle.Degrees(-41.97840494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109364"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.34892826),
        dec: Angle.Degrees(-41.97403030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24591"},
        {"Hipparcos Number", "HIP 18155"},
        {"Geneva Identification System", "GEN# +1.00024591"},
        {"Smithsonian Astrophysical Observation", "SAO 216535"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.22349654),
        dec: Angle.Degrees(-41.97386658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219899"},
        {"Hipparcos Number", "HIP 115183"},
        {"Geneva Identification System", "GEN# +1.00219899"},
        {"Smithsonian Astrophysical Observation", "SAO 231551"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.95068514),
        dec: Angle.Degrees(-41.96367319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30407"},
        {"Hipparcos Number", "HIP 22103"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.34677310),
        dec: Angle.Degrees(-41.96204724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39563"},
        {"Hipparcos Number", "HIP 27656"},
        {"Smithsonian Astrophysical Observation", "SAO 217573"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.83901671),
        dec: Angle.Degrees(-41.96170801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27577"},
        {"Hipparcos Number", "HIP 20168"},
        {"Smithsonian Astrophysical Observation", "SAO 216750"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.84075600),
        dec: Angle.Degrees(-41.96170366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26073"},
        {"Hipparcos Number", "HIP 19119"},
        {"Smithsonian Astrophysical Observation", "SAO 216641"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47873820),
        dec: Angle.Degrees(-41.96051963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27631"},
        {"Hipparcos Number", "HIP 20199"},
        {"Geneva Identification System", "GEN# +1.00027631"},
        {"Smithsonian Astrophysical Observation", "SAO 216753"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.93958945),
        dec: Angle.Degrees(-41.96004151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28552"},
        {"Hipparcos Number", "HIP 20856"},
        {"Geneva Identification System", "GEN# +1.00028552"},
        {"Smithsonian Astrophysical Observation", "SAO 216821"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.03948044),
        dec: Angle.Degrees(-41.95983905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57241"},
        {"Hipparcos Number", "HIP 35376"},
        {"Fundamental Katalog 5th Edition", "FK5 4657"},
        {"Smithsonian Astrophysical Observation", "SAO 218623"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.61908544),
        dec: Angle.Degrees(-41.95855723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170021"},
        {"Hipparcos Number", "HIP 90603"},
        {"Smithsonian Astrophysical Observation", "SAO 229057"},
        {"Smithsonian Astrophysical Observation 2", "SAO 229059"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.31511954),
        dec: Angle.Degrees(-41.95653263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39874"},
        {"Hipparcos Number", "HIP 27827"},
        {"Smithsonian Astrophysical Observation", "SAO 217597"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.32621908),
        dec: Angle.Degrees(-41.95531293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219318"},
        {"Hipparcos Number", "HIP 114793"},
        {"Smithsonian Astrophysical Observation", "SAO 231514"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.80224250),
        dec: Angle.Degrees(-41.95529473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61030"},
        {"Hipparcos Number", "HIP 36924"},
        {"Smithsonian Astrophysical Observation", "SAO 218820"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.85870320),
        dec: Angle.Degrees(-41.95337536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214580"},
        {"Hipparcos Number", "HIP 111890"},
        {"Smithsonian Astrophysical Observation", "SAO 231239"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.97620380),
        dec: Angle.Degrees(-41.95321966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90170"},
        {"Hipparcos Number", "HIP 50903"},
        {"Geneva Identification System", "GEN# +1.00090170"},
        {"Smithsonian Astrophysical Observation", "SAO 222016"},
        {"Wilson Evans Batten Catalogue", "WEB 9313"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.91963976),
        dec: Angle.Degrees(-41.95321950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128633"},
        {"Hipparcos Number", "HIP 71640"},
        {"Smithsonian Astrophysical Observation", "SAO 225090"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.80366932),
        dec: Angle.Degrees(-41.95038750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43240"},
        {"Hipparcos Number", "HIP 29517"},
        {"Geneva Identification System", "GEN# +1.00043240"},
        {"Smithsonian Astrophysical Observation", "SAO 217784"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.26910505),
        dec: Angle.Degrees(-41.94849037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75850"},
        {"Hipparcos Number", "HIP 43450"},
        {"Celescope Catalog", "CEL 2995"},
        {"Geneva Identification System", "GEN# +1.00075850"},
        {"Smithsonian Astrophysical Observation", "SAO 220569"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.75031493),
        dec: Angle.Degrees(-41.94708125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93690"},
        {"Hipparcos Number", "HIP 52848"},
        {"Smithsonian Astrophysical Observation", "SAO 222340"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.09625258),
        dec: Angle.Degrees(-41.94644448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107264"},
        {"Hipparcos Number", "HIP 60144"},
        {"Geneva Identification System", "GEN# +1.00107264"},
        {"Smithsonian Astrophysical Observation", "SAO 223358"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.01036845),
        dec: Angle.Degrees(-41.94533250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137060"},
        {"Hipparcos Number", "HIP 75507"},
        {"Geneva Identification System", "GEN# +1.00137060"},
        {"Smithsonian Astrophysical Observation", "SAO 225760"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.35745132),
        dec: Angle.Degrees(-41.94121984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36926"},
        {"Hipparcos Number", "HIP 26010"},
        {"Smithsonian Astrophysical Observation", "SAO 217393"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26368821),
        dec: Angle.Degrees(-41.93938574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100896"},
        {"Hipparcos Number", "HIP 56615"},
        {"Smithsonian Astrophysical Observation", "SAO 222904"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.12761220),
        dec: Angle.Degrees(-41.93813501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156444"},
        {"Hipparcos Number", "HIP 84766"},
        {"Smithsonian Astrophysical Observation", "SAO 227823"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.89115800),
        dec: Angle.Degrees(-41.93789757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172094"},
        {"Hipparcos Number", "HIP 91548"},
        {"Geneva Identification System", "GEN# +1.00172094"},
        {"Smithsonian Astrophysical Observation", "SAO 229180"},
        {"Wilson Evans Batten Catalogue", "WEB 15739"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.04445331),
        dec: Angle.Degrees(-41.93535678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98176"},
        {"Hipparcos Number", "HIP 55133"},
        {"Geneva Identification System", "GEN# +1.00098176"},
        {"Smithsonian Astrophysical Observation", "SAO 222695"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.30986211),
        dec: Angle.Degrees(-41.93430363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1805"},
        {"Hipparcos Number", "HIP 1758"},
        {"Smithsonian Astrophysical Observation", "SAO 215067"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.57016737),
        dec: Angle.Degrees(-41.93330028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51119"},
        {"Hipparcos Number", "HIP 33144"},
        {"Smithsonian Astrophysical Observation", "SAO 218292"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.51990403),
        dec: Angle.Degrees(-41.93212895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12961"},
        {"Hipparcos Number", "HIP 9787"},
        {"Renson", "Renson 3340"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.45534620),
        dec: Angle.Degrees(-41.92833990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158470"},
        {"Hipparcos Number", "HIP 85763"},
        {"Smithsonian Astrophysical Observation", "SAO 228065"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.86646898),
        dec: Angle.Degrees(-41.92773911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69988"},
        {"Hipparcos Number", "HIP 40647"},
        {"Smithsonian Astrophysical Observation", "SAO 219745"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.46214347),
        dec: Angle.Degrees(-41.92752149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69292"},
    },
    visualMagnitude: 12.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75057051),
        dec: Angle.Degrees(-41.92734112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135564"},
        {"Hipparcos Number", "HIP 74807"},
        {"Smithsonian Astrophysical Observation", "SAO 225619"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.32277695),
        dec: Angle.Degrees(-41.92700898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100119"},
        {"Hipparcos Number", "HIP 56180"},
        {"Geneva Identification System", "GEN# +1.00100119"},
        {"Smithsonian Astrophysical Observation", "SAO 222832"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.73525979),
        dec: Angle.Degrees(-41.92630268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142293"},
        {"Henry Draper 2", "HD 142292"},
        {"Hipparcos Number", "HIP 77972"},
        {"Smithsonian Astrophysical Observation", "SAO 226367"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.85097633),
        dec: Angle.Degrees(-41.92508748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150743"},
        {"Hipparcos Number", "HIP 81984"},
        {"Smithsonian Astrophysical Observation", "SAO 227149"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.21876219),
        dec: Angle.Degrees(-41.92434274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26539"},
        {"Hipparcos Number", "HIP 19462"},
        {"Fundamental Katalog 5th Edition", "FK5 4376"},
        {"Smithsonian Astrophysical Observation", "SAO 216676"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.51364172),
        dec: Angle.Degrees(-41.92433717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101736"},
        {"Hipparcos Number", "HIP 57095"},
        {"Smithsonian Astrophysical Observation", "SAO 222968"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.56833520),
        dec: Angle.Degrees(-41.92313286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104006"},
        {"Hipparcos Number", "HIP 58401"},
        {"Cincinnati Publication", "Ci 20 674"},
        {"Geneva Identification System", "GEN# +1.00104006A"},
        {"Smithsonian Astrophysical Observation", "SAO 223142"},
        {"Wilson Evans Batten Catalogue", "WEB 10439"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.61923380),
        dec: Angle.Degrees(-41.92136197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -769.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65332"},
        {"Hipparcos Number", "HIP 38803"},
        {"Smithsonian Astrophysical Observation", "SAO 219172"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.11839267),
        dec: Angle.Degrees(-41.91981552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137919"},
        {"Hipparcos Number", "HIP 75915"},
        {"Celescope Catalog", "CEL 4374"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.58877753),
        dec: Angle.Degrees(-41.91896389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173258"},
        {"Hipparcos Number", "HIP 92106"},
        {"Smithsonian Astrophysical Observation", "SAO 229266"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.57603554),
        dec: Angle.Degrees(-41.91791610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173080"},
        {"Hipparcos Number", "HIP 92029"},
        {"Smithsonian Astrophysical Observation", "SAO 229249"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36972769),
        dec: Angle.Degrees(-41.91777690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187519"},
        {"Hipparcos Number", "HIP 97775"},
        {"Geneva Identification System", "GEN# +1.00187519"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.02986908),
        dec: Angle.Degrees(-41.91673708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112404"},
        {"Hipparcos Number", "HIP 63197"},
        {"Geneva Identification System", "GEN# +1.00112404"},
        {"Smithsonian Astrophysical Observation", "SAO 223778"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.20931006),
        dec: Angle.Degrees(-41.91398576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170384"},
        {"Hipparcos Number", "HIP 90759"},
        {"Geneva Identification System", "GEN# +1.00170384"},
        {"Smithsonian Astrophysical Observation", "SAO 229080"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.76229716),
        dec: Angle.Degrees(-41.91375727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106572"},
        {"Hipparcos Number", "HIP 59785"},
        {"Geneva Identification System", "GEN# +1.00106572"},
        {"Smithsonian Astrophysical Observation", "SAO 223309"},
        {"Wilson Evans Batten Catalogue", "WEB 10623"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.87797443),
        dec: Angle.Degrees(-41.91283864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -337.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25965"},
        {"Hipparcos Number", "HIP 19059"},
        {"Smithsonian Astrophysical Observation", "SAO 216633"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.26463953),
        dec: Angle.Degrees(-41.91129608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54791"},
        {"Hipparcos Number", "HIP 34436"},
        {"Smithsonian Astrophysical Observation", "SAO 218478"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.08766896),
        dec: Angle.Degrees(-41.91064410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176425"},
        {"Hipparcos Number", "HIP 93470"},
        {"Geneva Identification System", "GEN# +1.00176425"},
        {"Smithsonian Astrophysical Observation", "SAO 229446"},
        {"Wilson Evans Batten Catalogue", "WEB 16220"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.53540308),
        dec: Angle.Degrees(-41.91047978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74081"},
        {"Smithsonian Astrophysical Observation", "SAO 140341"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.07883801),
        dec: Angle.Degrees(-09.82342419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82240"},
        {"Hipparcos Number", "HIP 46547"},
        {"Geneva Identification System", "GEN# +1.00082240"},
        {"Renson", "Renson 23380"},
        {"Smithsonian Astrophysical Observation", "SAO 221217"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.39140587),
        dec: Angle.Degrees(-41.91008614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166834"},
        {"Hipparcos Number", "HIP 89376"},
        {"Smithsonian Astrophysical Observation", "SAO 228834"},
    },
    visualMagnitude: 7.89,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.58715322),
        dec: Angle.Degrees(-41.90920495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4378"},
        {"Hipparcos Number", "HIP 3588"},
        {"Geneva Identification System", "GEN# +1.00004378"},
        {"Wilson Evans Batten Catalogue", "WEB 637"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.45019784),
        dec: Angle.Degrees(-41.90900883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 301.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172441"},
        {"Hipparcos Number", "HIP 91715"},
        {"Geneva Identification System", "GEN# +1.00172441"},
        {"Smithsonian Astrophysical Observation", "SAO 229210"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54322363),
        dec: Angle.Degrees(-41.90735972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96348"},
        {"Hipparcos Number", "HIP 54248"},
        {"Smithsonian Astrophysical Observation", "SAO 222563"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.46779811),
        dec: Angle.Degrees(-41.90706605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88089"},
        {"Hipparcos Number", "HIP 49681"},
        {"Geneva Identification System", "GEN# +1.00088089"},
        {"Smithsonian Astrophysical Observation", "SAO 221799"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.12586372),
        dec: Angle.Degrees(-41.90664452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223379"},
        {"Hipparcos Number", "HIP 117471"},
        {"Smithsonian Astrophysical Observation", "SAO 231791"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.29582446),
        dec: Angle.Degrees(-41.90635459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141340"},
        {"Hipparcos Number", "HIP 77571"},
        {"Smithsonian Astrophysical Observation", "SAO 226265"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.55246018),
        dec: Angle.Degrees(-41.90512546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82563"},
        {"Hipparcos Number", "HIP 46724"},
        {"Geneva Identification System", "GEN# +1.00082563"},
        {"Smithsonian Astrophysical Observation", "SAO 221247"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.86787040),
        dec: Angle.Degrees(-41.90446196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16591"},
        {"Hipparcos Number", "HIP 12281"},
        {"Geneva Identification System", "GEN# +1.00016591"},
        {"Smithsonian Astrophysical Observation", "SAO 215977"},
        {"Wilson Evans Batten Catalogue", "WEB 2518"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.55021044),
        dec: Angle.Degrees(-41.90442097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92846"},
        {"Hipparcos Number", "HIP 52396"},
        {"Smithsonian Astrophysical Observation", "SAO 222271"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.64931904),
        dec: Angle.Degrees(-41.90390544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103567"},
        {"Hipparcos Number", "HIP 58131"},
        {"Smithsonian Astrophysical Observation", "SAO 223115"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.84633989),
        dec: Angle.Degrees(-41.90354344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116385"},
        {"Hipparcos Number", "HIP 65386"},
        {"Geneva Identification System", "GEN# +1.00116385"},
        {"Smithsonian Astrophysical Observation", "SAO 224111"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.00160444),
        dec: Angle.Degrees(-41.90315827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3666"},
        {"Hipparcos Number", "HIP 3078"},
        {"Smithsonian Astrophysical Observation", "SAO 215182"},
        {"Smithsonian Astrophysical Observation 2", "SAO 215180"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.76706553),
        dec: Angle.Degrees(-41.89945200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25277"},
        {"Hipparcos Number", "HIP 18633"},
        {"Geneva Identification System", "GEN# +1.00025277"},
        {"Smithsonian Astrophysical Observation", "SAO 216587"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.82847971),
        dec: Angle.Degrees(-41.89853835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23548"},
        {"Hipparcos Number", "HIP 17447"},
        {"Smithsonian Astrophysical Observation", "SAO 216463"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.07760429),
        dec: Angle.Degrees(-41.89765877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66501"},
        {"Hipparcos Number", "HIP 39304"},
        {"Smithsonian Astrophysical Observation", "SAO 219324"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.53827503),
        dec: Angle.Degrees(-41.89618923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216693"},
        {"Hipparcos Number", "HIP 113209"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.88698580),
        dec: Angle.Degrees(-41.89592023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7498"},
        {"Hipparcos Number", "HIP 5802"},
        {"Geneva Identification System", "GEN# +1.00007498"},
        {"Smithsonian Astrophysical Observation", "SAO 215422"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.60478718),
        dec: Angle.Degrees(-41.89408551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79758"},
        {"Hipparcos Number", "HIP 45354"},
        {"Geneva Identification System", "GEN# +1.00079758"},
        {"Smithsonian Astrophysical Observation", "SAO 220983"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.64167572),
        dec: Angle.Degrees(-41.89249549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178322"},
        {"Hipparcos Number", "HIP 94157"},
        {"Geneva Identification System", "GEN# +1.00178322"},
        {"Smithsonian Astrophysical Observation", "SAO 229531"},
        {"Wilson Evans Batten Catalogue", "WEB 16402"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.49022490),
        dec: Angle.Degrees(-41.89222924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30703"},
        {"Hipparcos Number", "HIP 22286"},
        {"Geneva Identification System", "GEN# +1.00030703"},
        {"Smithsonian Astrophysical Observation", "SAO 216998"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.99947730),
        dec: Angle.Degrees(-41.89214395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121540"},
        {"Hipparcos Number", "HIP 68135"},
        {"Smithsonian Astrophysical Observation", "SAO 224567"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.24339170),
        dec: Angle.Degrees(-41.89060761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259"},
        {"Hipparcos Number", "HIP 599"},
        {"Fundamental Katalog 5th Edition", "FK5 4014"},
        {"Smithsonian Astrophysical Observation", "SAO 214969"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.81427471),
        dec: Angle.Degrees(-41.88961116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62279"},
        {"Hipparcos Number", "HIP 37460"},
        {"Geneva Identification System", "GEN# +1.00062279"},
        {"Smithsonian Astrophysical Observation", "SAO 218903"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.33795590),
        dec: Angle.Degrees(-41.88933740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124361"},
        {"Hipparcos Number", "HIP 69552"},
        {"Smithsonian Astrophysical Observation", "SAO 224783"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.56127216),
        dec: Angle.Degrees(-41.88859030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224842"},
        {"Hipparcos Number", "HIP 90"},
        {"Geneva Identification System", "GEN# +1.00224842"},
        {"Smithsonian Astrophysical Observation", "SAO 231896"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.27999988),
        dec: Angle.Degrees(-41.88742972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182328"},
        {"Hipparcos Number", "HIP 95535"},
        {"Smithsonian Astrophysical Observation", "SAO 229673"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.48906761),
        dec: Angle.Degrees(-41.88711237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 495"},
        {"Hipparcos Number", "HIP 758"},
        {"Smithsonian Astrophysical Observation", "SAO 214981"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.32966922),
        dec: Angle.Degrees(-41.88642543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2088"},
        {"Hipparcos Number", "HIP 1970"},
        {"Geneva Identification System", "GEN# +1.00002088"},
        {"Smithsonian Astrophysical Observation", "SAO 215085"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.23460790),
        dec: Angle.Degrees(-41.88603952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59677"},
        {"Hipparcos Number", "HIP 36378"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.30809052),
        dec: Angle.Degrees(-41.88453385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117224"},
        {"Hipparcos Number", "HIP 65826"},
        {"Smithsonian Astrophysical Observation", "SAO 224185"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.41173017),
        dec: Angle.Degrees(-41.88169535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2800"},
        {"Hipparcos Number", "HIP 2452"},
        {"Geneva Identification System", "GEN# +1.00002800"},
        {"Smithsonian Astrophysical Observation", "SAO 215128"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.80092777),
        dec: Angle.Degrees(-41.88160437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116624"},
        {"Hipparcos Number", "HIP 65502"},
        {"Geneva Identification System", "GEN# +1.00116624"},
        {"Smithsonian Astrophysical Observation", "SAO 224130"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.37830718),
        dec: Angle.Degrees(-41.88083042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13218"},
        {"Hipparcos Number", "HIP 9951"},
        {"Smithsonian Astrophysical Observation", "SAO 215777"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.02373939),
        dec: Angle.Degrees(-41.88039268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94641"},
        {"Hipparcos Number", "HIP 53378"},
        {"Smithsonian Astrophysical Observation", "SAO 222421"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.74717373),
        dec: Angle.Degrees(-41.88000765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72731"},
        {"Hipparcos Number", "HIP 41919"},
        {"Celescope Catalog", "CEL 2629"},
        {"Smithsonian Astrophysical Observation", "SAO 220079"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.19886922),
        dec: Angle.Degrees(-41.87920745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74900"},
        {"Hipparcos Number", "HIP 42944"},
        {"Smithsonian Astrophysical Observation", "SAO 220395"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.30502962),
        dec: Angle.Degrees(-41.87896817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81399"},
        {"Hipparcos Number", "HIP 46097"},
        {"Fundamental Katalog 5th Edition", "FK5 4837"},
        {"Smithsonian Astrophysical Observation", "SAO 221136"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.00995474),
        dec: Angle.Degrees(-41.87560101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122112"},
        {"Hipparcos Number", "HIP 68441"},
        {"Smithsonian Astrophysical Observation", "SAO 224614"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.17453706),
        dec: Angle.Degrees(-41.87554857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104043"},
        {"Hipparcos Number", "HIP 58434"},
        {"Geneva Identification System", "GEN# +1.00104043"},
        {"Smithsonian Astrophysical Observation", "SAO 223147"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.71664416),
        dec: Angle.Degrees(-41.87418093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18810"},
        {"Hipparcos Number", "HIP 13988"},
        {"Smithsonian Astrophysical Observation", "SAO 216128"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.03292983),
        dec: Angle.Degrees(-41.87397544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16104"},
        {"Hipparcos Number", "HIP 11929"},
        {"Smithsonian Astrophysical Observation", "SAO 215943"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.49183934),
        dec: Angle.Degrees(-41.87340452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29559"},
        {"Hipparcos Number", "HIP 21525"},
        {"Geneva Identification System", "GEN# +1.00029559"},
        {"Smithsonian Astrophysical Observation", "SAO 216899"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.33020095),
        dec: Angle.Degrees(-41.87306444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24732"},
        {"Hipparcos Number", "HIP 18247"},
        {"Smithsonian Astrophysical Observation", "SAO 216544"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.53315590),
        dec: Angle.Degrees(-41.87268175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7778"},
        {"Hipparcos Number", "HIP 5972"},
        {"Smithsonian Astrophysical Observation", "SAO 215436"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.19221028),
        dec: Angle.Degrees(-41.87167892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156470"},
        {"Hipparcos Number", "HIP 84771"},
        {"Smithsonian Astrophysical Observation", "SAO 227826"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.90580586),
        dec: Angle.Degrees(-41.87089929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13601"},
        {"Hipparcos Number", "HIP 10235"},
        {"Smithsonian Astrophysical Observation", "SAO 215808"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.89976643),
        dec: Angle.Degrees(-41.86956094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167183"},
        {"Hipparcos Number", "HIP 89514"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.00339915),
        dec: Angle.Degrees(-41.86910149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188114"},
        {"Hipparcos Number", "HIP 98032"},
        {"Fundamental Katalog 5th Edition", "FK5 1520"},
        {"Geneva Identification System", "GEN# +1.00188114"},
        {"Smithsonian Astrophysical Observation", "SAO 229927"},
        {"Wilson Evans Batten Catalogue", "WEB 17266"},
    },
    visualMagnitude: 4.12,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.81532954),
        dec: Angle.Degrees(-41.86841350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223107"},
        {"Hipparcos Number", "HIP 117283"},
        {"Smithsonian Astrophysical Observation", "SAO 231777"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.72096962),
        dec: Angle.Degrees(-41.86563712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49302"},
    },
    visualMagnitude: 11.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.95005542),
        dec: Angle.Degrees(-41.86438767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77475"},
        {"Hipparcos Number", "HIP 44299"},
        {"Celescope Catalog", "CEL 3147"},
        {"Geneva Identification System", "GEN# +1.00077475"},
        {"Smithsonian Astrophysical Observation", "SAO 220760"},
        {"Wilson Evans Batten Catalogue", "WEB 8495"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.33698096),
        dec: Angle.Degrees(-41.86429036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29875"},
        {"Henry Draper 2", "HD 29875A"},
        {"Hipparcos Number", "HIP 21770"},
        {"Fundamental Katalog 5th Edition", "FK5 1129"},
        {"Geneva Identification System", "GEN# +1.00029875"},
        {"Renson", "Renson 7670"},
        {"Smithsonian Astrophysical Observation", "SAO 216926"},
        {"Wilson Evans Batten Catalogue", "WEB 4189"},
    },
    visualMagnitude: 4.44,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.14092957),
        dec: Angle.Degrees(-41.86357034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -141.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130200"},
        {"Hipparcos Number", "HIP 72394"},
        {"Smithsonian Astrophysical Observation", "SAO 225197"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.02305172),
        dec: Angle.Degrees(-41.86298635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187211"},
        {"Hipparcos Number", "HIP 97639"},
        {"Smithsonian Astrophysical Observation", "SAO 229890"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.66800740),
        dec: Angle.Degrees(-41.85954456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15644"},
        {"Hipparcos Number", "HIP 11609"},
        {"Smithsonian Astrophysical Observation", "SAO 215921"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.43557908),
        dec: Angle.Degrees(-41.85789635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217025"},
        {"Hipparcos Number", "HIP 113423"},
        {"Geneva Identification System", "GEN# +1.00217025"},
        {"Smithsonian Astrophysical Observation", "SAO 231374"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.57369590),
        dec: Angle.Degrees(-41.85718223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 202.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107605"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.92343665),
        dec: Angle.Degrees(-41.85478860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151932"},
        {"Hipparcos Number", "HIP 82543"},
        {"Celescope Catalog", "CEL 4432"},
        {"Geneva Identification System", "GEN# +1.00151932"},
        {"Smithsonian Astrophysical Observation", "SAO 227328"},
        {"Wilson Evans Batten Catalogue", "WEB 13938"},
        {"New General Catalogue", "NGC 6231 305"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.08020506),
        dec: Angle.Degrees(-41.85451309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30919"},
        {"Hipparcos Number", "HIP 22437"},
        {"Smithsonian Astrophysical Observation", "SAO 217025"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.42472528),
        dec: Angle.Degrees(-41.85406899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62804"},
        {"Hipparcos Number", "HIP 37689"},
        {"Smithsonian Astrophysical Observation", "SAO 218939"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.98528794),
        dec: Angle.Degrees(-41.85352969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90325"},
        {"Hipparcos Number", "HIP 50973"},
        {"Geneva Identification System", "GEN# +1.00090325"},
        {"Smithsonian Astrophysical Observation", "SAO 222032"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.17893390),
        dec: Angle.Degrees(-41.85268514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54507"},
        {"Geneva Identification System", "GEN# -0.04106360"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.27772866),
        dec: Angle.Degrees(-41.85242183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190443"},
        {"Hipparcos Number", "HIP 99059"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.66773144),
        dec: Angle.Degrees(-41.85131296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116772"},
        {"Hipparcos Number", "HIP 65560"},
        {"Smithsonian Astrophysical Observation", "SAO 224142"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.62733141),
        dec: Angle.Degrees(-41.84995203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188813"},
        {"Hipparcos Number", "HIP 98334"},
        {"Geneva Identification System", "GEN# +1.00188813"},
        {"Smithsonian Astrophysical Observation", "SAO 229959"},
        {"Wilson Evans Batten Catalogue", "WEB 17346"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.67867085),
        dec: Angle.Degrees(-41.84928992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14509"},
        {"Hipparcos Number", "HIP 10832"},
        {"Geneva Identification System", "GEN# +1.00014509"},
        {"Smithsonian Astrophysical Observation", "SAO 215860"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.85317746),
        dec: Angle.Degrees(-41.84843472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56262"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.99741720),
        dec: Angle.Degrees(-41.84814677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107800"},
        {"Hipparcos Number", "HIP 60430"},
        {"Smithsonian Astrophysical Observation", "SAO 223400"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.85674696),
        dec: Angle.Degrees(-41.84775397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85888"},
        {"Hipparcos Number", "HIP 48522"},
        {"Geneva Identification System", "GEN# +1.00085888"},
        {"Smithsonian Astrophysical Observation", "SAO 221582"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.43425130),
        dec: Angle.Degrees(-41.84693046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191116"},
        {"Hipparcos Number", "HIP 99354"},
        {"Geneva Identification System", "GEN# +1.00191116"},
        {"Smithsonian Astrophysical Observation", "SAO 230076"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.49663635),
        dec: Angle.Degrees(-41.84634728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37892"},
        {"Hipparcos Number", "HIP 26635"},
        {"Smithsonian Astrophysical Observation", "SAO 217462"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.91926059),
        dec: Angle.Degrees(-41.84631303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4543"},
        {"Hipparcos Number", "HIP 3676"},
        {"Smithsonian Astrophysical Observation", "SAO 215236"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.75904816),
        dec: Angle.Degrees(-41.84598979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109353"},
        {"Hipparcos Number", "HIP 61357"},
        {"Geneva Identification System", "GEN# +1.00109353"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.59090207),
        dec: Angle.Degrees(-41.84575433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69367"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.98979398),
        dec: Angle.Degrees(-41.84364349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181245"},
        {"Hipparcos Number", "HIP 95150"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.37926165),
        dec: Angle.Degrees(-41.84001264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25209"},
        {"Hipparcos Number", "HIP 18563"},
        {"Smithsonian Astrophysical Observation", "SAO 216581"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.60284708),
        dec: Angle.Degrees(-41.83933425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124433"},
        {"Hipparcos Number", "HIP 69598"},
        {"Geneva Identification System", "GEN# +1.00124433"},
        {"Smithsonian Astrophysical Observation", "SAO 224791"},
        {"Wilson Evans Batten Catalogue", "WEB 12117"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67817566),
        dec: Angle.Degrees(-41.83744813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19007"},
        {"Hipparcos Number", "HIP 14115"},
        {"Smithsonian Astrophysical Observation", "SAO 216142"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.50734977),
        dec: Angle.Degrees(-41.83679407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6571"},
        {"Hipparcos Number", "HIP 5160"},
        {"Smithsonian Astrophysical Observation", "SAO 215363"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.51318333),
        dec: Angle.Degrees(-41.83631485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71896"},
        {"Hipparcos Number", "HIP 41533"},
        {"Celescope Catalog", "CEL 2545"},
        {"Geneva Identification System", "GEN# +1.00071896"},
        {"Smithsonian Astrophysical Observation", "SAO 219966"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.05181627),
        dec: Angle.Degrees(-41.83452145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139678"},
        {"Hipparcos Number", "HIP 76821"},
        {"Smithsonian Astrophysical Observation", "SAO 226063"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.27083974),
        dec: Angle.Degrees(-41.83357808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188903"},
        {"Hipparcos Number", "HIP 98373"},
        {"Geneva Identification System", "GEN# +1.00188903"},
        {"Smithsonian Astrophysical Observation", "SAO 229963"},
        {"Wilson Evans Batten Catalogue", "WEB 17360"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.79132338),
        dec: Angle.Degrees(-41.83269612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72611"},
        {"Hipparcos Number", "HIP 41874"},
        {"Celescope Catalog", "CEL 2619"},
        {"Geneva Identification System", "GEN# +1.00072611"},
        {"Renson", "Renson 20120"},
        {"Smithsonian Astrophysical Observation", "SAO 220062"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.07062387),
        dec: Angle.Degrees(-41.83244259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9144"},
        {"Hipparcos Number", "HIP 6931"},
        {"Smithsonian Astrophysical Observation", "SAO 215522"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.32674685),
        dec: Angle.Degrees(-41.83235260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122412"},
        {"Hipparcos Number", "HIP 68610"},
        {"Smithsonian Astrophysical Observation", "SAO 224631"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.67675804),
        dec: Angle.Degrees(-41.83234603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74356"},
        {"Hipparcos Number", "HIP 42687"},
        {"Geneva Identification System", "GEN# +1.00074356"},
        {"Smithsonian Astrophysical Observation", "SAO 220298"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.50395007),
        dec: Angle.Degrees(-41.82996427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216568"},
        {"Hipparcos Number", "HIP 113126"},
        {"Geneva Identification System", "GEN# +1.00216568"},
        {"Smithsonian Astrophysical Observation", "SAO 231347"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.63333617),
        dec: Angle.Degrees(-41.82891486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104472"},
        {"Hipparcos Number", "HIP 58660"},
        {"Smithsonian Astrophysical Observation", "SAO 223175"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.43420990),
        dec: Angle.Degrees(-41.82882436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76323B"},
        {"Hipparcos Number", "HIP 43680"},
        {"Smithsonian Astrophysical Observation", "SAO 220633"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48025106),
        dec: Angle.Degrees(-41.82743688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76323"},
        {"Hipparcos Number", "HIP 43688"},
        {"Celescope Catalog", "CEL 3053"},
        {"Smithsonian Astrophysical Observation", "SAO 220634"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48673371),
        dec: Angle.Degrees(-41.82704419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152248"},
        {"Hipparcos Number", "HIP 82691"},
        {"Geneva Identification System", "GEN# +2.62310291"},
        {"Smithsonian Astrophysical Observation", "SAO 227382"},
        {"Wilson Evans Batten Catalogue", "WEB 13967"},
        {"New General Catalogue", "NGC 6231 291"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.54192541),
        dec: Angle.Degrees(-41.82503271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167983"},
        {"Hipparcos Number", "HIP 89803"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.91177942),
        dec: Angle.Degrees(-41.82213694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152270"},
        {"Hipparcos Number", "HIP 82706"},
        {"Geneva Identification System", "GEN# +2.62310220"},
        {"Smithsonian Astrophysical Observation", "SAO 227390"},
        {"Wilson Evans Batten Catalogue", "WEB 13973"},
        {"New General Catalogue", "NGC 6231 220"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.58208193),
        dec: Angle.Degrees(-41.81986408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140285"},
        {"Hipparcos Number", "HIP 77086"},
        {"Celescope Catalog", "CEL 4392"},
        {"Geneva Identification System", "GEN# +1.00140285"},
        {"Wilson Evans Batten Catalogue", "WEB 13073"},
    },
    visualMagnitude: 5.93,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.09453394),
        dec: Angle.Degrees(-41.81901826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132689"},
        {"Hipparcos Number", "HIP 73534"},
        {"Smithsonian Astrophysical Observation", "SAO 225384"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.45202719),
        dec: Angle.Degrees(-41.81805524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148688"},
        {"Hipparcos Number", "HIP 80945"},
        {"Celescope Catalog", "CEL 4419"},
        {"Geneva Identification System", "GEN# +1.00148688J"},
        {"Smithsonian Astrophysical Observation", "SAO 226855"},
        {"Wilson Evans Batten Catalogue", "WEB 13691"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.92404718),
        dec: Angle.Degrees(-41.81714208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120610"},
        {"Hipparcos Number", "HIP 67625"},
        {"Smithsonian Astrophysical Observation", "SAO 224484"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.85392843),
        dec: Angle.Degrees(-41.81681577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48674"},
        {"Hipparcos Number", "HIP 32126"},
        {"Smithsonian Astrophysical Observation", "SAO 218139"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64342113),
        dec: Angle.Degrees(-41.81529818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122666"},
        {"Hipparcos Number", "HIP 68736"},
        {"Geneva Identification System", "GEN# +1.00122666"},
        {"Smithsonian Astrophysical Observation", "SAO 224651"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.05130977),
        dec: Angle.Degrees(-41.81241692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67758"},
        {"Hipparcos Number", "HIP 39776"},
        {"Celescope Catalog", "CEL 2169"},
        {"Geneva Identification System", "GEN# +1.00067758"},
        {"Smithsonian Astrophysical Observation", "SAO 219447"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.93276427),
        dec: Angle.Degrees(-41.81228963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118086"},
        {"Hipparcos Number", "HIP 66307"},
        {"Smithsonian Astrophysical Observation", "SAO 224265"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.83944078),
        dec: Angle.Degrees(-41.81194125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105399"},
        {"Hipparcos Number", "HIP 59179"},
        {"Smithsonian Astrophysical Observation", "SAO 223234"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.03888474),
        dec: Angle.Degrees(-41.80893539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201678"},
        {"Hipparcos Number", "HIP 104704"},
        {"Smithsonian Astrophysical Observation", "SAO 230577"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.13562583),
        dec: Angle.Degrees(-41.80686816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93867"},
        {"Hipparcos Number", "HIP 52928"},
        {"Smithsonian Astrophysical Observation", "SAO 222361"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.36648849),
        dec: Angle.Degrees(-41.80677045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152234"},
        {"Hipparcos Number", "HIP 82676"},
        {"Celescope Catalog", "CEL 4443"},
        {"Geneva Identification System", "GEN# +2.62310290"},
        {"Smithsonian Astrophysical Observation", "SAO 227377"},
        {"Wilson Evans Batten Catalogue", "WEB 13960"},
        {"New General Catalogue", "NGC 6231 290"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.50765901),
        dec: Angle.Degrees(-41.80638305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215454"},
        {"Hipparcos Number", "HIP 112393"},
        {"Smithsonian Astrophysical Observation", "SAO 231280"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.45869143),
        dec: Angle.Degrees(-41.80470729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184840"},
        {"Hipparcos Number", "HIP 96598"},
        {"Geneva Identification System", "GEN# +1.00184840"},
        {"Smithsonian Astrophysical Observation", "SAO 229785"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54977627),
        dec: Angle.Degrees(-41.80440746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102074"},
        {"Hipparcos Number", "HIP 57280"},
        {"Smithsonian Astrophysical Observation", "SAO 222994"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.18732982),
        dec: Angle.Degrees(-41.80271674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106200"},
        {"Hipparcos Number", "HIP 59590"},
        {"Geneva Identification System", "GEN# +1.00106200"},
        {"Smithsonian Astrophysical Observation", "SAO 223285"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.30537269),
        dec: Angle.Degrees(-41.80264680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116431"},
        {"Hipparcos Number", "HIP 65404"},
        {"Smithsonian Astrophysical Observation", "SAO 224114"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.07581541),
        dec: Angle.Degrees(-41.79922764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204422"},
        {"Hipparcos Number", "HIP 106111"},
        {"Smithsonian Astrophysical Observation", "SAO 230712"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.41060760),
        dec: Angle.Degrees(-41.79844078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142647"},
        {"Hipparcos Number", "HIP 78143"},
        {"Smithsonian Astrophysical Observation", "SAO 226399"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.34560489),
        dec: Angle.Degrees(-41.79764589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185388"},
        {"Hipparcos Number", "HIP 96802"},
        {"Smithsonian Astrophysical Observation", "SAO 229812"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.16736273),
        dec: Angle.Degrees(-41.79719763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214274"},
        {"Hipparcos Number", "HIP 111709"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.43455801),
        dec: Angle.Degrees(-41.79525858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83015"},
        {"Hipparcos Number", "HIP 46956"},
        {"Smithsonian Astrophysical Observation", "SAO 221292"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.56888393),
        dec: Angle.Degrees(-41.79469914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141166"},
        {"Hipparcos Number", "HIP 77481"},
        {"Celescope Catalog", "CEL 4395"},
        {"Geneva Identification System", "GEN# +1.00141166"},
        {"Smithsonian Astrophysical Observation", "SAO 226246"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.31203675),
        dec: Angle.Degrees(-41.79129825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68716"},
        {"Hipparcos Number", "HIP 40147"},
        {"Smithsonian Astrophysical Observation", "SAO 219577"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.97826936),
        dec: Angle.Degrees(-41.78863059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221175"},
        {"Hipparcos Number", "HIP 115989"},
        {"Smithsonian Astrophysical Observation", "SAO 231631"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.50258253),
        dec: Angle.Degrees(-41.78802463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64403"},
        {"Hipparcos Number", "HIP 38400"},
        {"Smithsonian Astrophysical Observation", "SAO 219079"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.00406884),
        dec: Angle.Degrees(-41.78681972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94166"},
        {"Hipparcos Number", "HIP 53080"},
        {"Smithsonian Astrophysical Observation", "SAO 222376"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.89121116),
        dec: Angle.Degrees(-41.78613682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219950"},
        {"Hipparcos Number", "HIP 115216"},
        {"Smithsonian Astrophysical Observation", "SAO 231554"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.05633419),
        dec: Angle.Degrees(-41.78594416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164837"},
        {"Hipparcos Number", "HIP 88557"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.23784258),
        dec: Angle.Degrees(-41.78556986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38631"},
        {"Hipparcos Number", "HIP 27121"},
        {"Geneva Identification System", "GEN# +1.00038631"},
        {"Smithsonian Astrophysical Observation", "SAO 217510"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.27011951),
        dec: Angle.Degrees(-41.78191428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103219"},
        {"Hipparcos Number", "HIP 57942"},
        {"Smithsonian Astrophysical Observation", "SAO 223084"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.23892098),
        dec: Angle.Degrees(-41.78058641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210246"},
        {"Hipparcos Number", "HIP 109409"},
        {"Smithsonian Astrophysical Observation", "SAO 231007"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.49179133),
        dec: Angle.Degrees(-41.77665984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12388"},
        {"Hipparcos Number", "HIP 9374"},
        {"Smithsonian Astrophysical Observation", "SAO 215733"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.11696752),
        dec: Angle.Degrees(-41.77571488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113583"},
        {"Hipparcos Number", "HIP 63856"},
        {"Smithsonian Astrophysical Observation", "SAO 223889"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.30007929),
        dec: Angle.Degrees(-41.77391897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149247"},
        {"Hipparcos Number", "HIP 81221"},
        {"Smithsonian Astrophysical Observation", "SAO 226936"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.84249134),
        dec: Angle.Degrees(-41.77368850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223642"},
        {"Hipparcos Number", "HIP 117638"},
        {"Geneva Identification System", "GEN# +1.00223642"},
        {"Smithsonian Astrophysical Observation", "SAO 231813"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.86219705),
        dec: Angle.Degrees(-41.77257512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33198"},
        {"Hipparcos Number", "HIP 23780"},
        {"Smithsonian Astrophysical Observation", "SAO 217178"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.65819806),
        dec: Angle.Degrees(-41.76879286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2929"},
        {"Smithsonian Astrophysical Observation", "SAO 215167"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.28658896),
        dec: Angle.Degrees(-41.76846638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200217"},
        {"Hipparcos Number", "HIP 103937"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.89718700),
        dec: Angle.Degrees(-41.76775455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27873"},
        {"Hipparcos Number", "HIP 20404"},
        {"Smithsonian Astrophysical Observation", "SAO 216767"},
    },
    visualMagnitude: 8.72,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.52694857),
        dec: Angle.Degrees(-41.76543069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133990"},
        {"Hipparcos Number", "HIP 74124"},
        {"Smithsonian Astrophysical Observation", "SAO 225489"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.22716446),
        dec: Angle.Degrees(-41.76503421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196399"},
        {"Hipparcos Number", "HIP 101876"},
        {"Smithsonian Astrophysical Observation", "SAO 230306"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.67056689),
        dec: Angle.Degrees(-41.76358957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62323"},
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.57667739),
        dec: Angle.Degrees(-41.76334687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21199"},
        {"Hipparcos Number", "HIP 15813"},
        {"Smithsonian Astrophysical Observation", "SAO 216293"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.92522093),
        dec: Angle.Degrees(-41.76230168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11022"},
        {"Hipparcos Number", "HIP 8320"},
        {"Geneva Identification System", "GEN# +1.00011022"},
        {"Smithsonian Astrophysical Observation", "SAO 215650"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.81955818),
        dec: Angle.Degrees(-41.76004487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66311"},
        {"Hipparcos Number", "HIP 39203"},
        {"Celescope Catalog", "CEL 2136"},
        {"Geneva Identification System", "GEN# +1.00066311"},
        {"Renson", "Renson 18296"},
        {"Smithsonian Astrophysical Observation", "SAO 219302"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.28833743),
        dec: Angle.Degrees(-41.75854834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102681"},
        {"Hipparcos Number", "HIP 57642"},
        {"Wilson Evans Batten Catalogue", "WEB 10353"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.29919107),
        dec: Angle.Degrees(-41.75757646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40496"},
        {"Hipparcos Number", "HIP 28165"},
        {"Smithsonian Astrophysical Observation", "SAO 217636"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.27760024),
        dec: Angle.Degrees(-41.75651389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165958"},
        {"Hipparcos Number", "HIP 89040"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.60821700),
        dec: Angle.Degrees(-41.75621506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37814"},
        {"Hipparcos Number", "HIP 26597"},
        {"Smithsonian Astrophysical Observation", "SAO 217455"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.79806254),
        dec: Angle.Degrees(-41.75372056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30194"},
        {"Hipparcos Number", "HIP 21982"},
        {"Smithsonian Astrophysical Observation", "SAO 216955"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.88131023),
        dec: Angle.Degrees(-41.75352398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23174"},
        {"Hipparcos Number", "HIP 17227"},
        {"Smithsonian Astrophysical Observation", "SAO 216441"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34706722),
        dec: Angle.Degrees(-41.75295553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105"},
        {"Hipparcos Number", "HIP 490"},
        {"Geneva Identification System", "GEN# +1.00000105"},
        {"Smithsonian Astrophysical Observation", "SAO 214961"},
        {"Wilson Evans Batten Catalogue", "WEB 81"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.46861724),
        dec: Angle.Degrees(-41.75288210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221370"},
        {"Hipparcos Number", "HIP 116131"},
        {"Smithsonian Astrophysical Observation", "SAO 231645"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.96524427),
        dec: Angle.Degrees(-41.75240017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211637"},
        {"Hipparcos Number", "HIP 110199"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.83678902),
        dec: Angle.Degrees(-41.75149495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1270"},
        {"Hipparcos Number", "HIP 1332"},
        {"Smithsonian Astrophysical Observation", "SAO 215031"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17683666),
        dec: Angle.Degrees(-41.74981169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91715"},
        {"Hipparcos Number", "HIP 51765"},
        {"Smithsonian Astrophysical Observation", "SAO 222161"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.66720463),
        dec: Angle.Degrees(-41.74959980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25402"},
        {"Henry Draper 2", "HD 25402A"},
        {"Hipparcos Number", "HIP 18714"},
        {"Geneva Identification System", "GEN# +1.00025402"},
        {"Smithsonian Astrophysical Observation", "SAO 216595"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.13304530),
        dec: Angle.Degrees(-41.74843070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222403"},
        {"Hipparcos Number", "HIP 116809"},
        {"Smithsonian Astrophysical Observation", "SAO 231729"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.11728526),
        dec: Angle.Degrees(-41.74768704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8901"},
        {"Hipparcos Number", "HIP 6760"},
        {"Smithsonian Astrophysical Observation", "SAO 215507"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.74179007),
        dec: Angle.Degrees(-41.74736876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6735"},
        {"Hipparcos Number", "HIP 5280"},
        {"Geneva Identification System", "GEN# +1.00006735"},
        {"Smithsonian Astrophysical Observation", "SAO 215372"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.88291179),
        dec: Angle.Degrees(-41.74654669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40807"},
        {"Hipparcos Number", "HIP 28331"},
        {"Smithsonian Astrophysical Observation", "SAO 217651"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.79930241),
        dec: Angle.Degrees(-41.74653960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32820"},
        {"Hipparcos Number", "HIP 23555"},
        {"Geneva Identification System", "GEN# +1.00032820"},
        {"Smithsonian Astrophysical Observation", "SAO 217153"},
        {"Wilson Evans Batten Catalogue", "WEB 4591"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.97472974),
        dec: Angle.Degrees(-41.74533727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143009"},
        {"Hipparcos Number", "HIP 78323"},
        {"Fundamental Katalog 5th Edition", "FK5 1418"},
        {"Geneva Identification System", "GEN# +1.00143009"},
        {"Smithsonian Astrophysical Observation", "SAO 226425"},
        {"Wilson Evans Batten Catalogue", "WEB 13241"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87623269),
        dec: Angle.Degrees(-41.74439602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75655"},
        {"Hipparcos Number", "HIP 43346"},
        {"Celescope Catalog", "CEL 2970"},
        {"Geneva Identification System", "GEN# +1.00075655"},
        {"Smithsonian Astrophysical Observation", "SAO 220538"},
        {"Wilson Evans Batten Catalogue", "WEB 8349"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.44783614),
        dec: Angle.Degrees(-41.74316875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123092"},
        {"Hipparcos Number", "HIP 68938"},
        {"Smithsonian Astrophysical Observation", "SAO 224684"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67459642),
        dec: Angle.Degrees(-41.74248292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169184"},
        {"Hipparcos Number", "HIP 90292"},
        {"Smithsonian Astrophysical Observation", "SAO 229005"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.34332056),
        dec: Angle.Degrees(-41.74245928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5809"},
        {"Hipparcos Number", "HIP 4611"},
        {"Smithsonian Astrophysical Observation", "SAO 215313"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.77165273),
        dec: Angle.Degrees(-41.74179904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110017"},
        {"Hipparcos Number", "HIP 61766"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.88615990),
        dec: Angle.Degrees(-41.73942609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57786"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.74395545),
        dec: Angle.Degrees(-41.73929571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51391"},
        {"Hipparcos Number", "HIP 33266"},
        {"Smithsonian Astrophysical Observation", "SAO 218310"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.80500797),
        dec: Angle.Degrees(-41.73787850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177169"},
        {"Hipparcos Number", "HIP 93752"},
        {"Smithsonian Astrophysical Observation", "SAO 229481"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.36369621),
        dec: Angle.Degrees(-41.73765942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191795"},
        {"Hipparcos Number", "HIP 99656"},
        {"Renson", "Renson 53450"},
        {"Smithsonian Astrophysical Observation", "SAO 230107"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.35073503),
        dec: Angle.Degrees(-41.73679968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67681"},
        {"Hipparcos Number", "HIP 39742"},
        {"Smithsonian Astrophysical Observation", "SAO 219443"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.84927038),
        dec: Angle.Degrees(-41.73642541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4391"},
        {"Smithsonian Astrophysical Observation", "SAO 147522"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.06349884),
        dec: Angle.Degrees(-09.80787221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75289"},
        {"Hipparcos Number", "HIP 43177"},
        {"Geneva Identification System", "GEN# +1.00075289"},
        {"Smithsonian Astrophysical Observation", "SAO 220481"},
        {"Wilson Evans Batten Catalogue", "WEB 8330"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.91835588),
        dec: Angle.Degrees(-41.73623880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140091"},
        {"Hipparcos Number", "HIP 77006"},
        {"Smithsonian Astrophysical Observation", "SAO 226115"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85265787),
        dec: Angle.Degrees(-41.73604327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108759"},
        {"Hipparcos Number", "HIP 60979"},
        {"Geneva Identification System", "GEN# +1.00108759"},
        {"Smithsonian Astrophysical Observation", "SAO 223471"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.49118040),
        dec: Angle.Degrees(-41.73586155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67655"},
        {"Hipparcos Number", "HIP 39731"},
        {"Smithsonian Astrophysical Observation", "SAO 219437"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.82127785),
        dec: Angle.Degrees(-41.73537415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159940"},
        {"Hipparcos Number", "HIP 86397"},
        {"Smithsonian Astrophysical Observation", "SAO 228237"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.81323992),
        dec: Angle.Degrees(-41.73403309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138603"},
        {"Hipparcos Number", "HIP 76264"},
        {"Geneva Identification System", "GEN# +1.00138603"},
        {"Smithsonian Astrophysical Observation", "SAO 225918"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.66386645),
        dec: Angle.Degrees(-41.73328467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36902"},
        {"Hipparcos Number", "HIP 25999"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.23584392),
        dec: Angle.Degrees(-41.73040647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30064"},
        {"Hipparcos Number", "HIP 21895"},
        {"Smithsonian Astrophysical Observation", "SAO 216945"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.59516676),
        dec: Angle.Degrees(-41.72980680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213699"},
        {"Hipparcos Number", "HIP 111395"},
        {"Smithsonian Astrophysical Observation", "SAO 231194"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.51259782),
        dec: Angle.Degrees(-41.72961227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48631"},
        {"Hipparcos Number", "HIP 32098"},
        {"Geneva Identification System", "GEN# +1.00048631"},
        {"Smithsonian Astrophysical Observation", "SAO 218137"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.58414868),
        dec: Angle.Degrees(-41.72876953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88976"},
        {"Hipparcos Number", "HIP 50196"},
        {"Geneva Identification System", "GEN# +1.00088976"},
        {"Smithsonian Astrophysical Observation", "SAO 221898"},
        {"Wilson Evans Batten Catalogue", "WEB 9222"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.70956028),
        dec: Angle.Degrees(-41.72615181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28872"},
        {"Hipparcos Number", "HIP 21081"},
        {"Geneva Identification System", "GEN# +1.00028872"},
        {"Smithsonian Astrophysical Observation", "SAO 216851"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.77544050),
        dec: Angle.Degrees(-41.72563365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88001"},
        {"Hipparcos Number", "HIP 49636"},
        {"Smithsonian Astrophysical Observation", "SAO 221794"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.96058876),
        dec: Angle.Degrees(-41.72486385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99655"},
        {"Hipparcos Number", "HIP 55918"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91483083),
        dec: Angle.Degrees(-41.72388498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185774"},
        {"Hipparcos Number", "HIP 96970"},
        {"Smithsonian Astrophysical Observation", "SAO 229824"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.65820715),
        dec: Angle.Degrees(-41.72361280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95726",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12472 B"},
        {"Hipparcos Number", "HIP 95726"},
        {"Smithsonian Astrophysical Observation", "SAO 143434"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05655212),
        dec: Angle.Degrees(-09.53949623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154590"},
        {"Hipparcos Number", "HIP 83846"},
        {"Geneva Identification System", "GEN# +1.00154590"},
        {"Smithsonian Astrophysical Observation", "SAO 227653"},
        {"Wilson Evans Batten Catalogue", "WEB 14167"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.03107443),
        dec: Angle.Degrees(-41.72319429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177566"},
        {"Hipparcos Number", "HIP 93884"},
        {"Geneva Identification System", "GEN# +1.00177566"},
        {"Wilson Evans Batten Catalogue", "WEB 16332"},
    },
    visualMagnitude: 10.18,
    bvColour: -0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78286614),
        dec: Angle.Degrees(-41.72101090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208625"},
        {"Hipparcos Number", "HIP 108479"},
        {"Geneva Identification System", "GEN# +1.00208625"},
        {"Smithsonian Astrophysical Observation", "SAO 230920"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.62555248),
        dec: Angle.Degrees(-41.72097290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55525"},
        {"Hipparcos Number", "HIP 34713"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.83137961),
        dec: Angle.Degrees(-41.71708512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86542"},
    },
    visualMagnitude: 11.00,
    bvColour: 2.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.28314682),
        dec: Angle.Degrees(-41.71695618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163376"},
        {"Hipparcos Number", "HIP 87936"},
        {"Geneva Identification System", "GEN# +1.00163376"},
        {"Smithsonian Astrophysical Observation", "SAO 228578"},
        {"Wilson Evans Batten Catalogue", "WEB 14847"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.44919385),
        dec: Angle.Degrees(-41.71625842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166427"},
        {"Hipparcos Number", "HIP 89225"},
        {"Geneva Identification System", "GEN# +1.00166427"},
        {"Renson", "Renson 46840"},
        {"Smithsonian Astrophysical Observation", "SAO 228802"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.12279376),
        dec: Angle.Degrees(-41.71598022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88399"},
        {"Hipparcos Number", "HIP 49844"},
        {"Geneva Identification System", "GEN# +1.00088399"},
        {"Smithsonian Astrophysical Observation", "SAO 221832"},
        {"Wilson Evans Batten Catalogue", "WEB 9180"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.65706616),
        dec: Angle.Degrees(-41.71493294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
