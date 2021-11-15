using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_1() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155245"},
        {"Hipparcos Number", "HIP 84941"},
        {"Geneva Identification System", "GEN# +1.00155245"},
        {"Smithsonian Astrophysical Observation", "SAO 257484"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.39580528),
        dec: Angle.Degrees(-79.06507201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119561"},
        {"Hipparcos Number", "HIP 67405"},
        {"Geneva Identification System", "GEN# +1.00119561"},
        {"Smithsonian Astrophysical Observation", "SAO 257090"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.21358503),
        dec: Angle.Degrees(-79.06460034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88278"},
        {"Hipparcos Number", "HIP 49416"},
        {"Geneva Identification System", "GEN# +1.00088278"},
        {"Smithsonian Astrophysical Observation", "SAO 256681"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.30787682),
        dec: Angle.Degrees(-79.06239600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224752"},
        {"Hipparcos Number", "HIP 38"},
        {"Geneva Identification System", "GEN# +1.00224752"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.11104694),
        dec: Angle.Degrees(-79.06183133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192316"},
        {"Hipparcos Number", "HIP 100594"},
        {"Geneva Identification System", "GEN# +5.22270008"},
        {"Smithsonian Astrophysical Observation", "SAO 257796"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.97600923),
        dec: Angle.Degrees(-79.05085237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129078"},
        {"Hipparcos Number", "HIP 72370"},
        {"Fundamental Katalog 5th Edition", "FK5 542"},
        {"Geneva Identification System", "GEN# +1.00129078"},
        {"Smithsonian Astrophysical Observation", "SAO 257193"},
        {"Wilson Evans Batten Catalogue", "WEB 12442"},
    },
    visualMagnitude: 3.83,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.96552567),
        dec: Angle.Degrees(-79.04471242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160778"},
        {"Hipparcos Number", "HIP 87550"},
        {"Geneva Identification System", "GEN# +1.00160778"},
        {"Smithsonian Astrophysical Observation", "SAO 257532"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.29508434),
        dec: Angle.Degrees(-79.04197572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9381"},
        {"Hipparcos Number", "HIP 6828"},
        {"Geneva Identification System", "GEN# +1.00009381"},
        {"Smithsonian Astrophysical Observation", "SAO 255783"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.96530756),
        dec: Angle.Degrees(-79.04058706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16667"},
        {"Hipparcos Number", "HIP 11857"},
        {"Smithsonian Astrophysical Observation", "SAO 255907"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.25837481),
        dec: Angle.Degrees(-79.03598768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143391"},
        {"Hipparcos Number", "HIP 79215"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.50442820),
        dec: Angle.Degrees(-79.03510750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177369"},
        {"Hipparcos Number", "HIP 94631"},
        {"Geneva Identification System", "GEN# +1.00177369"},
        {"Smithsonian Astrophysical Observation", "SAO 257669"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.85587759),
        dec: Angle.Degrees(-79.02832588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14717"},
        {"Hipparcos Number", "HIP 10538"},
        {"Smithsonian Astrophysical Observation", "SAO 255868"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.93833486),
        dec: Angle.Degrees(-79.02613955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149057"},
        {"Hipparcos Number", "HIP 81830"},
        {"Smithsonian Astrophysical Observation", "SAO 257420"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.72000811),
        dec: Angle.Degrees(-79.02424526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14452"},
        {"Hipparcos Number", "HIP 10363"},
        {"Geneva Identification System", "GEN# +1.00014452"},
        {"Smithsonian Astrophysical Observation", "SAO 255863"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.39239293),
        dec: Angle.Degrees(-79.02413757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27479"},
        {"Hipparcos Number", "HIP 19445"},
        {"Smithsonian Astrophysical Observation", "SAO 256071"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.46283570),
        dec: Angle.Degrees(-79.01791167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207854"},
        {"Hipparcos Number", "HIP 108449"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.54037473),
        dec: Angle.Degrees(-79.00984675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38031"},
        {"Hipparcos Number", "HIP 25864"},
        {"Smithsonian Astrophysical Observation", "SAO 256202"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.82731538),
        dec: Angle.Degrees(-79.00893359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190808"},
        {"Hipparcos Number", "HIP 99931"},
        {"Geneva Identification System", "GEN# +5.22270011"},
        {"Smithsonian Astrophysical Observation", "SAO 257783"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.12532538),
        dec: Angle.Degrees(-79.00672642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112674"},
        {"Hipparcos Number", "HIP 63535"},
        {"Geneva Identification System", "GEN# +1.00112674"},
        {"Smithsonian Astrophysical Observation", "SAO 256997"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.29838330),
        dec: Angle.Degrees(-79.00588330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89403"},
        {"Hipparcos Number", "HIP 50126"},
        {"Geneva Identification System", "GEN# +1.00089403"},
        {"Smithsonian Astrophysical Observation", "SAO 256694"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.48877459),
        dec: Angle.Degrees(-79.00405895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 610"},
        {"Hipparcos Number", "HIP 819"},
        {"Geneva Identification System", "GEN# +1.00000610"},
        {"Smithsonian Astrophysical Observation", "SAO 255639"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51839580),
        dec: Angle.Degrees(-79.00183917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20313B"},
        {"Hipparcos Number", "HIP 14515"},
        {"Geneva Identification System", "GEN# +1.00020313B"},
        {"Smithsonian Astrophysical Observation", "SAO 255961"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.86722441),
        dec: Angle.Degrees(-78.99240634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220521"},
        {"Hipparcos Number", "HIP 115683"},
        {"Smithsonian Astrophysical Observation", "SAO 258140"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.57726255),
        dec: Angle.Degrees(-78.99178617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164480"},
        {"Hipparcos Number", "HIP 89250"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.19254734),
        dec: Angle.Degrees(-78.99164770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20313"},
        {"Hipparcos Number", "HIP 14521"},
        {"Geneva Identification System", "GEN# +1.00020313A"},
        {"Smithsonian Astrophysical Observation", "SAO 255962"},
        {"Wilson Evans Batten Catalogue", "WEB 2823"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.88292015),
        dec: Angle.Degrees(-78.98942329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163963"},
        {"Hipparcos Number", "HIP 89030"},
        {"Smithsonian Astrophysical Observation", "SAO 257564"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.55749462),
        dec: Angle.Degrees(-78.98656290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35276"},
        {"Hipparcos Number", "HIP 24237"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.05884862),
        dec: Angle.Degrees(-78.98640712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109450"},
        {"Hipparcos Number", "HIP 61524"},
    },
    visualMagnitude: 9.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.07233068),
        dec: Angle.Degrees(-78.98435707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75416"},
        {"Hipparcos Number", "HIP 42637"},
        {"Fundamental Katalog 5th Edition", "FK5 331"},
        {"Geneva Identification System", "GEN# +1.00075416"},
        {"Smithsonian Astrophysical Observation", "SAO 256543"},
        {"Wilson Evans Batten Catalogue", "WEB 8235"},
    },
    visualMagnitude: 5.46,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.33167303),
        dec: Angle.Degrees(-78.96342637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192074"},
        {"Hipparcos Number", "HIP 100491"},
        {"Geneva Identification System", "GEN# +5.22270009"},
        {"Smithsonian Astrophysical Observation", "SAO 257794"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.67143945),
        dec: Angle.Degrees(-78.96080466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43641"},
        {"Hipparcos Number", "HIP 28880"},
        {"Geneva Identification System", "GEN# +1.00043641"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.46306743),
        dec: Angle.Degrees(-78.95688428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116089"},
        {"Hipparcos Number", "HIP 65470"},
        {"Geneva Identification System", "GEN# +1.00116089"},
        {"Smithsonian Astrophysical Observation", "SAO 257038"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.29199975),
        dec: Angle.Degrees(-78.95209059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196752"},
        {"Hipparcos Number", "HIP 102661"},
        {"Geneva Identification System", "GEN# +1.00196752"},
        {"Smithsonian Astrophysical Observation", "SAO 257850"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.05736580),
        dec: Angle.Degrees(-78.95100108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117042"},
        {"Hipparcos Number", "HIP 65992"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.95538574),
        dec: Angle.Degrees(-78.94402906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57244"},
        {"Hipparcos Number", "HIP 34573"},
        {"Smithsonian Astrophysical Observation", "SAO 256380"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.40818466),
        dec: Angle.Degrees(-78.94216364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221361"},
        {"Hipparcos Number", "HIP 116234"},
        {"Smithsonian Astrophysical Observation", "SAO 258153"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.25105450),
        dec: Angle.Degrees(-78.93549324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109368"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36215332),
        dec: Angle.Degrees(-78.92623820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 309.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -481.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154541"},
        {"Hipparcos Number", "HIP 84546"},
        {"Geneva Identification System", "GEN# +1.00154541"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.25368327),
        dec: Angle.Degrees(-78.92600254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193549"},
        {"Hipparcos Number", "HIP 101137"},
        {"Geneva Identification System", "GEN# +5.22270005"},
        {"Smithsonian Astrophysical Observation", "SAO 257810"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.50826779),
        dec: Angle.Degrees(-78.90637516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47674"},
        {"Hipparcos Number", "HIP 30837"},
        {"Geneva Identification System", "GEN# +1.00047674"},
        {"Smithsonian Astrophysical Observation", "SAO 256310"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.15825544),
        dec: Angle.Degrees(-78.90557133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147675"},
        {"Hipparcos Number", "HIP 81065"},
        {"Fundamental Katalog 5th Edition", "FK5 611"},
        {"Geneva Identification System", "GEN# +1.00147675"},
        {"Smithsonian Astrophysical Observation", "SAO 257407"},
        {"Wilson Evans Batten Catalogue", "WEB 13708"},
    },
    visualMagnitude: 3.86,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.36443409),
        dec: Angle.Degrees(-78.89695917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217111"},
        {"Hipparcos Number", "HIP 113682"},
        {"Smithsonian Astrophysical Observation", "SAO 258096"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.37487517),
        dec: Angle.Degrees(-78.89071953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130425"},
        {"Hipparcos Number", "HIP 73043"},
        {"Smithsonian Astrophysical Observation", "SAO 257208"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.91444057),
        dec: Angle.Degrees(-78.88301594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137852"},
        {"Hipparcos Number", "HIP 76475"},
        {"Geneva Identification System", "GEN# +1.00137852"},
        {"Smithsonian Astrophysical Observation", "SAO 257295"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.29533505),
        dec: Angle.Degrees(-78.87728209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197389"},
        {"Hipparcos Number", "HIP 102984"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.97740378),
        dec: Angle.Degrees(-78.87326009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12951"},
        {"Hipparcos Number", "HIP 9414"},
        {"Geneva Identification System", "GEN# +1.00012951"},
        {"Smithsonian Astrophysical Observation", "SAO 255839"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.23639524),
        dec: Angle.Degrees(-78.87016760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96494"},
        {"Hipparcos Number", "HIP 54114"},
        {"Geneva Identification System", "GEN# +1.00096494"},
        {"Smithsonian Astrophysical Observation", "SAO 256793"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.08938872),
        dec: Angle.Degrees(-78.86867458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188990"},
        {"Hipparcos Number", "HIP 99144"},
        {"Geneva Identification System", "GEN# +5.22270015"},
        {"Smithsonian Astrophysical Observation", "SAO 257765"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.92036458),
        dec: Angle.Degrees(-78.86596828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76144"},
        {"Hipparcos Number", "HIP 43025"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.50820320),
        dec: Angle.Degrees(-78.86014459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116852"},
        {"Hipparcos Number", "HIP 65890"},
        {"Geneva Identification System", "GEN# +1.00116852"},
        {"Wilson Evans Batten Catalogue", "WEB 11656"},
    },
    visualMagnitude: 8.49,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.59790407),
        dec: Angle.Degrees(-78.85568869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131286"},
        {"Hipparcos Number", "HIP 73421"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.07166157),
        dec: Angle.Degrees(-78.84605213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188136"},
        {"Henry Draper 2", "HD 188137"},
        {"Hipparcos Number", "HIP 98757"},
        {"Geneva Identification System", "GEN# +5.22270017"},
        {"Renson", "Renson 51950"},
        {"Smithsonian Astrophysical Observation", "SAO 257761"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.88224497),
        dec: Angle.Degrees(-78.83073241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115116"},
        {"Hipparcos Number", "HIP 64921"},
        {"Geneva Identification System", "GEN# +1.00115116"},
        {"Smithsonian Astrophysical Observation", "SAO 257025"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.60067986),
        dec: Angle.Degrees(-78.82308932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38602"},
        {"Hipparcos Number", "HIP 26264"},
        {"Geneva Identification System", "GEN# +1.00038602"},
        {"Renson", "Renson 10390"},
        {"Smithsonian Astrophysical Observation", "SAO 256214"},
        {"Wilson Evans Batten Catalogue", "WEB 5152"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.90054432),
        dec: Angle.Degrees(-78.82088325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67538"},
        {"Hipparcos Number", "HIP 38991"},
        {"Geneva Identification System", "GEN# +1.00067538"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.70778369),
        dec: Angle.Degrees(-78.81386700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178259"},
        {"Hipparcos Number", "HIP 94886"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.63973469),
        dec: Angle.Degrees(-78.81112880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30778"},
        {"Hipparcos Number", "HIP 21721"},
        {"Smithsonian Astrophysical Observation", "SAO 256119"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.95229882),
        dec: Angle.Degrees(-78.80695223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38474"},
        {"Hipparcos Number", "HIP 26172"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.69358502),
        dec: Angle.Degrees(-78.79918996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77798"},
        {"Hipparcos Number", "HIP 43912"},
        {"Smithsonian Astrophysical Observation", "SAO 256571"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.18884790),
        dec: Angle.Degrees(-78.79676416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222806"},
        {"Hipparcos Number", "HIP 117125"},
        {"Fundamental Katalog 5th Edition", "FK5 3906"},
        {"Geneva Identification System", "GEN# +1.00222806"},
        {"Smithsonian Astrophysical Observation", "SAO 258179"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.16950877),
        dec: Angle.Degrees(-78.79144467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98820"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.02701199),
        dec: Angle.Degrees(-78.78693814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82863"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.01100575),
        dec: Angle.Degrees(-78.78303983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55790"},
        {"Hipparcos Number", "HIP 34022"},
        {"Smithsonian Astrophysical Observation", "SAO 256371"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.88566639),
        dec: Angle.Degrees(-78.78251565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85782"},
        {"Hipparcos Number", "HIP 48089"},
        {"Smithsonian Astrophysical Observation", "SAO 256662"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.06295835),
        dec: Angle.Degrees(-78.78186207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105515"},
        {"Hipparcos Number", "HIP 59243"},
        {"Geneva Identification System", "GEN# +1.00105515"},
        {"Smithsonian Astrophysical Observation", "SAO 256910"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.28260647),
        dec: Angle.Degrees(-78.78129461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1324"},
        {"Hipparcos Number", "HIP 1342"},
        {"Geneva Identification System", "GEN# +1.00001324"},
        {"Smithsonian Astrophysical Observation", "SAO 255652"},
        {"Wilson Evans Batten Catalogue", "WEB 242"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.20080442),
        dec: Angle.Degrees(-78.78009243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188230"},
        {"Hipparcos Number", "HIP 98806"},
        {"Geneva Identification System", "GEN# +5.22270016"},
        {"Smithsonian Astrophysical Observation", "SAO 257762"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00283787),
        dec: Angle.Degrees(-78.77932140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19670"},
        {"Hipparcos Number", "HIP 14112"},
        {"Geneva Identification System", "GEN# +1.00019670"},
        {"Smithsonian Astrophysical Observation", "SAO 255950"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.49225532),
        dec: Angle.Degrees(-78.77810055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213402"},
        {"Hipparcos Number", "HIP 111504"},
        {"Fundamental Katalog 5th Edition", "FK5 3807"},
        {"Geneva Identification System", "GEN# +1.00213402"},
        {"Smithsonian Astrophysical Observation", "SAO 258049"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.85984361),
        dec: Angle.Degrees(-78.77156677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24225"},
        {"Hipparcos Number", "HIP 17270"},
        {"Smithsonian Astrophysical Observation", "SAO 256018"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.47928108),
        dec: Angle.Degrees(-78.76988115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34665"},
        {"Hipparcos Number", "HIP 23895"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.01865896),
        dec: Angle.Degrees(-78.76919030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218374"},
        {"Hipparcos Number", "HIP 114397"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.52561733),
        dec: Angle.Degrees(-78.76467944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12603"},
        {"Hipparcos Number", "HIP 9140"},
        {"Geneva Identification System", "GEN# +1.00012603"},
        {"Smithsonian Astrophysical Observation", "SAO 255838"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.45311408),
        dec: Angle.Degrees(-78.76365866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193049"},
        {"Hipparcos Number", "HIP 100891"},
        {"Fundamental Katalog 5th Edition", "FK5 5805"},
        {"Geneva Identification System", "GEN# +5.22270006"},
        {"Smithsonian Astrophysical Observation", "SAO 257807"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.85647454),
        dec: Angle.Degrees(-78.75570199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136813"},
        {"Hipparcos Number", "HIP 75994"},
        {"Geneva Identification System", "GEN# +1.00136813"},
        {"Smithsonian Astrophysical Observation", "SAO 257280"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.79606965),
        dec: Angle.Degrees(-78.75279839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105234"},
        {"Hipparcos Number", "HIP 59093"},
        {"Geneva Identification System", "GEN# +1.00105234"},
        {"Smithsonian Astrophysical Observation", "SAO 256904"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.77351753),
        dec: Angle.Degrees(-78.74109314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77618"},
        {"Hipparcos Number", "HIP 43839"},
        {"Smithsonian Astrophysical Observation", "SAO 256570"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.93382564),
        dec: Angle.Degrees(-78.73619216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91096"},
        {"Hipparcos Number", "HIP 51116"},
        {"Smithsonian Astrophysical Observation", "SAO 256716"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.65207788),
        dec: Angle.Degrees(-78.73596496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72406"},
        {"Hipparcos Number", "HIP 41156"},
        {"Smithsonian Astrophysical Observation", "SAO 256512"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.95746046),
        dec: Angle.Degrees(-78.71758652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46384"},
        {"Hipparcos Number", "HIP 30258"},
        {"Geneva Identification System", "GEN# +1.00046384"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.48312793),
        dec: Angle.Degrees(-78.71745004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140294"},
        {"Hipparcos Number", "HIP 77712"},
        {"Smithsonian Astrophysical Observation", "SAO 257325"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99778491),
        dec: Angle.Degrees(-78.71523320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28899"},
        {"Hipparcos Number", "HIP 20442"},
        {"Smithsonian Astrophysical Observation", "SAO 256087"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.68715161),
        dec: Angle.Degrees(-78.71446279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138851"},
        {"Hipparcos Number", "HIP 77022"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.88899944),
        dec: Angle.Degrees(-78.71311388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77709"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99346482),
        dec: Angle.Degrees(-78.71185596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142033"},
        {"Hipparcos Number", "HIP 78505"},
        {"Geneva Identification System", "GEN# +1.00142033"},
        {"Smithsonian Astrophysical Observation", "SAO 257344"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.40431833),
        dec: Angle.Degrees(-78.71174907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162750"},
        {"Hipparcos Number", "HIP 88450"},
        {"Smithsonian Astrophysical Observation", "SAO 257551"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.88217853),
        dec: Angle.Degrees(-78.70154596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13265"},
        {"Hipparcos Number", "HIP 9624"},
        {"Smithsonian Astrophysical Observation", "SAO 255846"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.92505337),
        dec: Angle.Degrees(-78.69706180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145366"},
        {"Hipparcos Number", "HIP 80047"},
        {"Fundamental Katalog 5th Edition", "FK5 1424"},
        {"Geneva Identification System", "GEN# +1.00145366"},
        {"Smithsonian Astrophysical Observation", "SAO 257380"},
        {"Wilson Evans Batten Catalogue", "WEB 13551"},
    },
    visualMagnitude: 4.68,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.08681283),
        dec: Angle.Degrees(-78.69565609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69547"},
        {"Hipparcos Number", "HIP 39818"},
        {"Fundamental Katalog 5th Edition", "FK5 2642"},
        {"Geneva Identification System", "GEN# +1.00069547"},
        {"Smithsonian Astrophysical Observation", "SAO 256482"},
        {"Wilson Evans Batten Catalogue", "WEB 7766"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.03666233),
        dec: Angle.Degrees(-78.69484528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159047"},
        {"Hipparcos Number", "HIP 86739"},
        {"Smithsonian Astrophysical Observation", "SAO 257520"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.85998580),
        dec: Angle.Degrees(-78.69285441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172164"},
        {"Hipparcos Number", "HIP 92383"},
        {"Renson", "Renson 48250"},
        {"Smithsonian Astrophysical Observation", "SAO 257628"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.39692669),
        dec: Angle.Degrees(-78.67921855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112777"},
    },
    visualMagnitude: 11.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.58935609),
        dec: Angle.Degrees(-78.67836123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215672"},
        {"Hipparcos Number", "HIP 112783"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.60213463),
        dec: Angle.Degrees(-78.67430200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72204"},
        {"Hipparcos Number", "HIP 41048"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65014721),
        dec: Angle.Degrees(-78.67353935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145388"},
        {"Hipparcos Number", "HIP 80057"},
        {"Geneva Identification System", "GEN# +1.00145388"},
        {"Smithsonian Astrophysical Observation", "SAO 257381"},
        {"Wilson Evans Batten Catalogue", "WEB 13554"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.11193231),
        dec: Angle.Degrees(-78.66742066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22142"},
        {"Hipparcos Number", "HIP 15931"},
        {"Smithsonian Astrophysical Observation", "SAO 255990"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30040053),
        dec: Angle.Degrees(-78.66621695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3160"},
        {"Hipparcos Number", "HIP 2615"},
        {"Smithsonian Astrophysical Observation", "SAO 255680"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.30016195),
        dec: Angle.Degrees(-78.66513983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14761"},
        {"Hipparcos Number", "HIP 10592"},
        {"Smithsonian Astrophysical Observation", "SAO 255870"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.09749954),
        dec: Angle.Degrees(-78.65236522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5193"},
        {"Hipparcos Number", "HIP 4003"},
        {"Geneva Identification System", "GEN# +1.00005193"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.85054069),
        dec: Angle.Degrees(-78.64368714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84373"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.74201696),
        dec: Angle.Degrees(-78.63525572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26595"},
        {"Hipparcos Number", "HIP 18847"},
        {"Smithsonian Astrophysical Observation", "SAO 256059"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.61672592),
        dec: Angle.Degrees(-78.63308014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29783"},
        {"Hipparcos Number", "HIP 21087"},
        {"Renson", "Renson 7650"},
        {"Smithsonian Astrophysical Observation", "SAO 256103"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.79103082),
        dec: Angle.Degrees(-78.63294946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32859"},
        {"Hipparcos Number", "HIP 22890"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.84943523),
        dec: Angle.Degrees(-78.63271485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39389"},
        {"Hipparcos Number", "HIP 26773"},
        {"Smithsonian Astrophysical Observation", "SAO 256227"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.31079657),
        dec: Angle.Degrees(-78.63138345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174480"},
        {"Hipparcos Number", "HIP 93416"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.38844519),
        dec: Angle.Degrees(-78.62972414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120294"},
        {"Hipparcos Number", "HIP 67807"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.36103766),
        dec: Angle.Degrees(-78.62509504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125690"},
        {"Hipparcos Number", "HIP 70671"},
        {"Smithsonian Astrophysical Observation", "SAO 257152"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.82011572),
        dec: Angle.Degrees(-78.62016381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102260"},
        {"Hipparcos Number", "HIP 57325"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.30785287),
        dec: Angle.Degrees(-78.61629367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213401"},
        {"Hipparcos Number", "HIP 111486"},
        {"Geneva Identification System", "GEN# +1.00213401"},
        {"Smithsonian Astrophysical Observation", "SAO 258048"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.81545591),
        dec: Angle.Degrees(-78.61401894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168091"},
        {"Hipparcos Number", "HIP 90583"},
        {"Smithsonian Astrophysical Observation", "SAO 257592"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.25807123),
        dec: Angle.Degrees(-78.60864743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92305"},
        {"Hipparcos Number", "HIP 51839"},
        {"Fundamental Katalog 5th Edition", "FK5 401"},
        {"Geneva Identification System", "GEN# +1.00092305"},
        {"Smithsonian Astrophysical Observation", "SAO 256731"},
        {"Wilson Evans Batten Catalogue", "WEB 9443"},
    },
    visualMagnitude: 4.11,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.86757668),
        dec: Angle.Degrees(-78.60781379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 369"},
        {"Hipparcos Number", "HIP 648"},
        {"Smithsonian Astrophysical Observation", "SAO 255636"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00147404),
        dec: Angle.Degrees(-78.59876143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90981"},
        {"Hipparcos Number", "HIP 51050"},
        {"Geneva Identification System", "GEN# +1.00090981"},
        {"Smithsonian Astrophysical Observation", "SAO 256713"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.44812129),
        dec: Angle.Degrees(-78.59793508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 581"},
        {"Hipparcos Number", "HIP 804"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.48490475),
        dec: Angle.Degrees(-78.59054090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121439"},
        {"Hipparcos Number", "HIP 68431"},
        {"Fundamental Katalog 5th Edition", "FK5 3111"},
        {"Geneva Identification System", "GEN# +1.00121439"},
        {"Smithsonian Astrophysical Observation", "SAO 257107"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.13689131),
        dec: Angle.Degrees(-78.58995932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41137"},
        {"Hipparcos Number", "HIP 27715"},
        {"Smithsonian Astrophysical Observation", "SAO 256249"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.03305403),
        dec: Angle.Degrees(-78.58778603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207180"},
        {"Hipparcos Number", "HIP 108045"},
        {"Smithsonian Astrophysical Observation", "SAO 257971"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.34120539),
        dec: Angle.Degrees(-78.57945954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110832"},
        {"Hipparcos Number", "HIP 62362"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.70061219),
        dec: Angle.Degrees(-78.57665097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81568"},
        {"Smithsonian Astrophysical Observation", "SAO 257415"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.88408624),
        dec: Angle.Degrees(-78.57556778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106248"},
        {"Hipparcos Number", "HIP 59647"},
        {"Geneva Identification System", "GEN# +1.00106248"},
        {"Smithsonian Astrophysical Observation", "SAO 256915"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.48531404),
        dec: Angle.Degrees(-78.57388687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85704"},
        {"Hipparcos Number", "HIP 48043"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.90491260),
        dec: Angle.Degrees(-78.56616827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146467"},
        {"Hipparcos Number", "HIP 80520"},
        {"Smithsonian Astrophysical Observation", "SAO 257393"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.56946314),
        dec: Angle.Degrees(-78.56523685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88676"},
        {"Hipparcos Number", "HIP 49673"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.10766096),
        dec: Angle.Degrees(-78.56068669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43330"},
        {"Hipparcos Number", "HIP 28782"},
        {"Smithsonian Astrophysical Observation", "SAO 256270"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.15799667),
        dec: Angle.Degrees(-78.55933368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26475"},
        {"Hipparcos Number", "HIP 18783"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.36388734),
        dec: Angle.Degrees(-78.54872865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204086"},
        {"Hipparcos Number", "HIP 106406"},
        {"Smithsonian Astrophysical Observation", "SAO 257932"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.27826276),
        dec: Angle.Degrees(-78.54312351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83468"},
        {"Hipparcos Number", "HIP 46785"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00837123),
        dec: Angle.Degrees(-78.54094994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86896"},
    },
    visualMagnitude: 13.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.33161611),
        dec: Angle.Degrees(-78.53581475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86895"},
    },
    visualMagnitude: 12.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.32840802),
        dec: Angle.Degrees(-78.53180035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11843"},
        {"Hipparcos Number", "HIP 8616"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.78370495),
        dec: Angle.Degrees(-78.52990162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212182"},
        {"Hipparcos Number", "HIP 110800"},
        {"Smithsonian Astrophysical Observation", "SAO 258038"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.72415454),
        dec: Angle.Degrees(-78.52689877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164713"},
        {"Hipparcos Number", "HIP 89314"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.36845775),
        dec: Angle.Degrees(-78.52297717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99806"},
        {"Hipparcos Number", "HIP 55888"},
        {"Smithsonian Astrophysical Observation", "SAO 256842"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.82068932),
        dec: Angle.Degrees(-78.52183957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131218"},
        {"Hipparcos Number", "HIP 73372"},
        {"Geneva Identification System", "GEN# +1.00131218"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.91376712),
        dec: Angle.Degrees(-78.51086760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224011"},
        {"Hipparcos Number", "HIP 117907"},
        {"Geneva Identification System", "GEN# +1.00224011"},
        {"Smithsonian Astrophysical Observation", "SAO 258199"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.73561128),
        dec: Angle.Degrees(-78.50511933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10042"},
        {"Hipparcos Number", "HIP 7271"},
        {"Fundamental Katalog 5th Edition", "FK5 53"},
        {"Geneva Identification System", "GEN# +1.00010042"},
        {"Smithsonian Astrophysical Observation", "SAO 255794"},
        {"Wilson Evans Batten Catalogue", "WEB 1568"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.41359158),
        dec: Angle.Degrees(-78.50448590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15311"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.39016146),
        dec: Angle.Degrees(-78.50022105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74603"},
        {"Hipparcos Number", "HIP 42212"},
        {"Smithsonian Astrophysical Observation", "SAO 256531"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09327030),
        dec: Angle.Degrees(-78.49584410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52254"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.14818040),
        dec: Angle.Degrees(-78.49251057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16309"},
        {"Hipparcos Number", "HIP 11641"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.54533364),
        dec: Angle.Degrees(-78.49072671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152549"},
        {"Hipparcos Number", "HIP 83537"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.10836806),
        dec: Angle.Degrees(-78.47363412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134583"},
        {"Hipparcos Number", "HIP 74917"},
        {"Fundamental Katalog 5th Edition", "FK5 3203"},
        {"Smithsonian Astrophysical Observation", "SAO 257260"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.64635138),
        dec: Angle.Degrees(-78.47219672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194717"},
        {"Hipparcos Number", "HIP 101631"},
        {"Geneva Identification System", "GEN# +1.00194717"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.98110847),
        dec: Angle.Degrees(-78.46964597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125517"},
        {"Hipparcos Number", "HIP 70547"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.47759263),
        dec: Angle.Degrees(-78.45771487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114533"},
        {"Hipparcos Number", "HIP 64587"},
        {"Fundamental Katalog 5th Edition", "FK5 3054"},
        {"Geneva Identification System", "GEN# +1.00114533"},
        {"Smithsonian Astrophysical Observation", "SAO 257019"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.57231883),
        dec: Angle.Degrees(-78.44744492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113694"},
        {"Hipparcos Number", "HIP 64108"},
        {"Geneva Identification System", "GEN# +1.00113694"},
        {"Smithsonian Astrophysical Observation", "SAO 257011"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.08550598),
        dec: Angle.Degrees(-78.44596983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49835"},
        {"Hipparcos Number", "HIP 31861"},
        {"Geneva Identification System", "GEN# +1.00049835"},
        {"Smithsonian Astrophysical Observation", "SAO 256327"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.90898531),
        dec: Angle.Degrees(-78.44049158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206505"},
        {"Hipparcos Number", "HIP 107665"},
        {"Geneva Identification System", "GEN# +1.00206505"},
        {"Smithsonian Astrophysical Observation", "SAO 257957"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.13077324),
        dec: Angle.Degrees(-78.43352819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58495"},
        {"Hipparcos Number", "HIP 35108"},
        {"Smithsonian Astrophysical Observation", "SAO 256391"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.89369257),
        dec: Angle.Degrees(-78.43116273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210786"},
        {"Hipparcos Number", "HIP 110070"},
        {"Smithsonian Astrophysical Observation", "SAO 258018"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.42646702),
        dec: Angle.Degrees(-78.43071548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81321"},
        {"Hipparcos Number", "HIP 45619"},
        {"Smithsonian Astrophysical Observation", "SAO 256602"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.47278234),
        dec: Angle.Degrees(-78.42833059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120362"},
        {"Hipparcos Number", "HIP 67837"},
        {"Geneva Identification System", "GEN# +1.00120362"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.43351155),
        dec: Angle.Degrees(-78.41348186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46175"},
        {"Hipparcos Number", "HIP 30179"},
        {"Geneva Identification System", "GEN# +1.00046175"},
        {"Smithsonian Astrophysical Observation", "SAO 256299"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.25040673),
        dec: Angle.Degrees(-78.41215925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201907"},
        {"Hipparcos Number", "HIP 105316"},
        {"Smithsonian Astrophysical Observation", "SAO 257907"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.95338363),
        dec: Angle.Degrees(-78.40682507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154343"},
        {"Hipparcos Number", "HIP 84399"},
        {"Fundamental Katalog 5th Edition", "FK5 3364"},
        {"Geneva Identification System", "GEN# +1.00154343"},
        {"Smithsonian Astrophysical Observation", "SAO 257474"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.82614266),
        dec: Angle.Degrees(-78.39895465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63670"},
        {"Hipparcos Number", "HIP 37372"},
        {"Smithsonian Astrophysical Observation", "SAO 256440"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.08128958),
        dec: Angle.Degrees(-78.38757067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7988"},
        {"Hipparcos Number", "HIP 5889"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.91654174),
        dec: Angle.Degrees(-78.38155623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162298"},
        {"Hipparcos Number", "HIP 88237"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.27687120),
        dec: Angle.Degrees(-78.38035828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17867"},
        {"Hipparcos Number", "HIP 12822"},
        {"Smithsonian Astrophysical Observation", "SAO 255920"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.20899699),
        dec: Angle.Degrees(-78.37351800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167386"},
        {"Hipparcos Number", "HIP 90318"},
        {"Smithsonian Astrophysical Observation", "SAO 257588"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.42319188),
        dec: Angle.Degrees(-78.37057486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29955"},
        {"Hipparcos Number", "HIP 21214"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.26122682),
        dec: Angle.Degrees(-78.36996488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17782"},
        {"Hipparcos Number", "HIP 12757"},
        {"Renson", "Renson 4440"},
        {"Smithsonian Astrophysical Observation", "SAO 255917"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.99101522),
        dec: Angle.Degrees(-78.36717769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16421"},
        {"Hipparcos Number", "HIP 11715"},
        {"Smithsonian Astrophysical Observation", "SAO 255897"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.80534708),
        dec: Angle.Degrees(-78.36677982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107806"},
        {"Hipparcos Number", "HIP 60505"},
        {"Geneva Identification System", "GEN# +1.00107806"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.06319977),
        dec: Angle.Degrees(-78.36672208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63122"},
        {"Hipparcos Number", "HIP 37112"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.38679491),
        dec: Angle.Degrees(-78.36515432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22676"},
        {"Hipparcos Number", "HIP 16290"},
        {"Geneva Identification System", "GEN# +1.00022676"},
        {"Smithsonian Astrophysical Observation", "SAO 255998"},
        {"Wilson Evans Batten Catalogue", "WEB 3108"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.49552432),
        dec: Angle.Degrees(-78.35178497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12363"},
        {"Hipparcos Number", "HIP 8991"},
        {"Fundamental Katalog 5th Edition", "FK5 2134"},
        {"Geneva Identification System", "GEN# +1.00012363"},
        {"Smithsonian Astrophysical Observation", "SAO 255835"},
        {"Wilson Evans Batten Catalogue", "WEB 1886"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95937790),
        dec: Angle.Degrees(-78.34867741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218827"},
        {"Hipparcos Number", "HIP 114640"},
        {"Geneva Identification System", "GEN# +1.00218827"},
        {"Smithsonian Astrophysical Observation", "SAO 258116"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.35645501),
        dec: Angle.Degrees(-78.34618230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6598"},
        {"Hipparcos Number", "HIP 4973"},
        {"Smithsonian Astrophysical Observation", "SAO 255732"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.93153015),
        dec: Angle.Degrees(-78.34511680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84075"},
        {"Hipparcos Number", "HIP 47135"},
        {"Smithsonian Astrophysical Observation", "SAO 256643"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.07514555),
        dec: Angle.Degrees(-78.34500601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168177"},
        {"Hipparcos Number", "HIP 90591"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.29037283),
        dec: Angle.Degrees(-78.34222906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132544"},
        {"Hipparcos Number", "HIP 73985"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.79267013),
        dec: Angle.Degrees(-78.33834797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210237"},
        {"Hipparcos Number", "HIP 109773"},
        {"Smithsonian Astrophysical Observation", "SAO 258010"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.51412616),
        dec: Angle.Degrees(-78.33114875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71702"},
        {"Hipparcos Number", "HIP 40830"},
        {"Geneva Identification System", "GEN# +1.00071702"},
        {"Smithsonian Astrophysical Observation", "SAO 256502"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99887376),
        dec: Angle.Degrees(-78.32857393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23474"},
        {"Hipparcos Number", "HIP 16827"},
        {"Fundamental Katalog 5th Edition", "FK5 2261"},
        {"Geneva Identification System", "GEN# +1.00023474"},
        {"Smithsonian Astrophysical Observation", "SAO 256005"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12576577),
        dec: Angle.Degrees(-78.32308914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184600"},
        {"Hipparcos Number", "HIP 97171"},
        {"Geneva Identification System", "GEN# +1.00184600"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.25716373),
        dec: Angle.Degrees(-78.32208518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58593"},
        {"Hipparcos Number", "HIP 35170"},
        {"Smithsonian Astrophysical Observation", "SAO 256392"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.03225101),
        dec: Angle.Degrees(-78.31847810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128657"},
        {"Hipparcos Number", "HIP 72092"},
        {"Smithsonian Astrophysical Observation", "SAO 257187"},
    },
    visualMagnitude: 10.00,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.22059099),
        dec: Angle.Degrees(-78.31071371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 626"},
        {"Hipparcos Number", "HIP 829"},
        {"Smithsonian Astrophysical Observation", "SAO 255640"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.53330673),
        dec: Angle.Degrees(-78.30066030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33519"},
        {"Hipparcos Number", "HIP 23251"},
        {"Geneva Identification System", "GEN# +1.00033519"},
        {"Smithsonian Astrophysical Observation", "SAO 256153"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.05536691),
        dec: Angle.Degrees(-78.30001167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24137"},
        {"Hipparcos Number", "HIP 17242"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.39200435),
        dec: Angle.Degrees(-78.29873970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6729"},
        {"Hipparcos Number", "HIP 5066"},
        {"Smithsonian Astrophysical Observation", "SAO 255737"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20452571),
        dec: Angle.Degrees(-78.29775115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89498"},
        {"Hipparcos Number", "HIP 50208"},
        {"Geneva Identification System", "GEN# +1.00089498"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.74931358),
        dec: Angle.Degrees(-78.28295396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42269"},
        {"Hipparcos Number", "HIP 28316"},
        {"Geneva Identification System", "GEN# +1.00042269"},
        {"Smithsonian Astrophysical Observation", "SAO 256259"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.74614125),
        dec: Angle.Degrees(-78.28203351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85892"},
        {"Hipparcos Number", "HIP 48174"},
        {"Geneva Identification System", "GEN# +1.00085892"},
        {"Renson", "Renson 24520"},
        {"Smithsonian Astrophysical Observation", "SAO 256664"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.28716590),
        dec: Angle.Degrees(-78.28195614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37284",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ceibo"},
        {"Henry Draper", "HD 63454"},
        {"Hipparcos Number", "HIP 37284"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.84129342),
        dec: Angle.Degrees(-78.27887587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81463"},
    },
    visualMagnitude: 12.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.57665548),
        dec: Angle.Degrees(-78.27866651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159605"},
        {"Hipparcos Number", "HIP 86973"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.61563468),
        dec: Angle.Degrees(-78.27640576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22651"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.09105066),
        dec: Angle.Degrees(-78.27144016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4805"},
        {"Hipparcos Number", "HIP 3726"},
        {"Smithsonian Astrophysical Observation", "SAO 255708"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.96146403),
        dec: Angle.Degrees(-78.26736064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188304"},
        {"Hipparcos Number", "HIP 98789"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.95682204),
        dec: Angle.Degrees(-78.26279942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2134"},
        {"Hipparcos Number", "HIP 1937"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.11086061),
        dec: Angle.Degrees(-78.25037355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10936"},
        {"Hipparcos Number", "HIP 7976"},
        {"Smithsonian Astrophysical Observation", "SAO 255808"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.61621222),
        dec: Angle.Degrees(-78.24355290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138212"},
        {"Hipparcos Number", "HIP 76637"},
        {"Smithsonian Astrophysical Observation", "SAO 257301"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.75617321),
        dec: Angle.Degrees(-78.23506044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44827"},
        {"Hipparcos Number", "HIP 29531"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.32410508),
        dec: Angle.Degrees(-78.23133496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165093"},
        {"Hipparcos Number", "HIP 89417"},
        {"Geneva Identification System", "GEN# +1.00165093"},
        {"Renson", "Renson 46620"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.70681449),
        dec: Angle.Degrees(-78.22828934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104174"},
        {"Hipparcos Number", "HIP 58484"},
        {"Geneva Identification System", "GEN# +1.00104174"},
        {"Smithsonian Astrophysical Observation", "SAO 256894"},
        {"Wilson Evans Batten Catalogue", "WEB 10445"},
    },
    visualMagnitude: 4.88,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.90704708),
        dec: Angle.Degrees(-78.22181833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206729"},
        {"Hipparcos Number", "HIP 107782"},
        {"Smithsonian Astrophysical Observation", "SAO 257961"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52703752),
        dec: Angle.Degrees(-78.22162786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180709"},
        {"Hipparcos Number", "HIP 95669"},
        {"Geneva Identification System", "GEN# +1.00180709"},
        {"Smithsonian Astrophysical Observation", "SAO 257684"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89612174),
        dec: Angle.Degrees(-78.22108802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121545"},
        {"Hipparcos Number", "HIP 68472"},
        {"Geneva Identification System", "GEN# +1.00121545"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.27628608),
        dec: Angle.Degrees(-78.21600190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212610"},
        {"Hipparcos Number", "HIP 111049"},
        {"Smithsonian Astrophysical Observation", "SAO 258042"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46214031),
        dec: Angle.Degrees(-78.21316096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120083"},
        {"Hipparcos Number", "HIP 67670"},
        {"Geneva Identification System", "GEN# +1.00120083"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.96119316),
        dec: Angle.Degrees(-78.21101878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 158.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 368"},
        {"Hipparcos Number", "HIP 647"},
        {"Smithsonian Astrophysical Observation", "SAO 255635"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.99715281),
        dec: Angle.Degrees(-78.21097486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222300"},
        {"Hipparcos Number", "HIP 116806"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.10277160),
        dec: Angle.Degrees(-78.21065128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193005"},
        {"Hipparcos Number", "HIP 100844"},
        {"Smithsonian Astrophysical Observation", "SAO 257805"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.70040508),
        dec: Angle.Degrees(-78.19462183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108927"},
        {"Hipparcos Number", "HIP 61193"},
        {"Geneva Identification System", "GEN# +1.00108927"},
        {"Smithsonian Astrophysical Observation", "SAO 256953"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.08240827),
        dec: Angle.Degrees(-78.19411338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104237"},
        {"Hipparcos Number", "HIP 58520"},
        {"Geneva Identification System", "GEN# +1.00104237"},
        {"Smithsonian Astrophysical Observation", "SAO 256895"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.02165073),
        dec: Angle.Degrees(-78.19292085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33245"},
        {"Hipparcos Number", "HIP 23118"},
        {"Geneva Identification System", "GEN# +1.00033245"},
        {"Smithsonian Astrophysical Observation", "SAO 256148"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.62747861),
        dec: Angle.Degrees(-78.18619654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52351"},
        {"Geneva Identification System", "GEN# -0.07700638"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.47689044),
        dec: Angle.Degrees(-78.18425214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33701"},
        {"Hipparcos Number", "HIP 23391"},
        {"Smithsonian Astrophysical Observation", "SAO 256157"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.42278934),
        dec: Angle.Degrees(-78.18326642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198610"},
        {"Hipparcos Number", "HIP 103587"},
        {"Smithsonian Astrophysical Observation", "SAO 257868"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.82417672),
        dec: Angle.Degrees(-78.18067402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208891"},
        {"Hipparcos Number", "HIP 108970"},
        {"Smithsonian Astrophysical Observation", "SAO 257995"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.14497045),
        dec: Angle.Degrees(-78.17894061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132252"},
        {"Hipparcos Number", "HIP 73834"},
        {"Geneva Identification System", "GEN# +1.00132252"},
        {"Smithsonian Astrophysical Observation", "SAO 257231"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.34168141),
        dec: Angle.Degrees(-78.16713319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64678"},
        {"Hipparcos Number", "HIP 37857"},
        {"Renson", "Renson 17720"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.40718651),
        dec: Angle.Degrees(-78.16702508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91682"},
        {"Hipparcos Number", "HIP 51500"},
        {"Geneva Identification System", "GEN# +1.00091682"},
        {"Smithsonian Astrophysical Observation", "SAO 256725"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.76853313),
        dec: Angle.Degrees(-78.16531998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214637"},
        {"Hipparcos Number", "HIP 112189"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.83586634),
        dec: Angle.Degrees(-78.16489169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140535"},
        {"Hipparcos Number", "HIP 77855"},
        {"Smithsonian Astrophysical Observation", "SAO 257329"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.46975310),
        dec: Angle.Degrees(-78.15867929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126154"},
        {"Hipparcos Number", "HIP 70901"},
        {"Smithsonian Astrophysical Observation", "SAO 257162"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.47387204),
        dec: Angle.Degrees(-78.15655820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221921"},
        {"Hipparcos Number", "HIP 116575"},
        {"Smithsonian Astrophysical Observation", "SAO 258162"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.35326872),
        dec: Angle.Degrees(-78.15425659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32494"},
        {"Hipparcos Number", "HIP 22723"},
        {"Geneva Identification System", "GEN# +1.00032494"},
        {"Smithsonian Astrophysical Observation", "SAO 256144"},
        {"Wilson Evans Batten Catalogue", "WEB 4397"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.31437179),
        dec: Angle.Degrees(-78.14588157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185190"},
        {"Hipparcos Number", "HIP 97385"},
        {"Smithsonian Astrophysical Observation", "SAO 257726"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.89157356),
        dec: Angle.Degrees(-78.14273095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144719"},
        {"Hipparcos Number", "HIP 79747"},
        {"Smithsonian Astrophysical Observation", "SAO 257374"},
    },
    visualMagnitude: 9.18,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.13439843),
        dec: Angle.Degrees(-78.13333689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197343"},
        {"Hipparcos Number", "HIP 102924"},
        {"Geneva Identification System", "GEN# +1.00197343"},
        {"Smithsonian Astrophysical Observation", "SAO 257857"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.78994529),
        dec: Angle.Degrees(-78.13194476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115571"},
        {"Hipparcos Number", "HIP 65174"},
        {"Geneva Identification System", "GEN# +1.00115571"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.34593758),
        dec: Angle.Degrees(-78.12875408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51748"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58419462),
        dec: Angle.Degrees(-78.12260570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222727"},
        {"Hipparcos Number", "HIP 117074"},
        {"Smithsonian Astrophysical Observation", "SAO 258176"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.00071028),
        dec: Angle.Degrees(-78.11982472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105484"},
        {"Hipparcos Number", "HIP 59227"},
        {"Geneva Identification System", "GEN# +1.00105484"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.21536741),
        dec: Angle.Degrees(-78.10010272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214070"},
        {"Hipparcos Number", "HIP 111876"},
        {"Smithsonian Astrophysical Observation", "SAO 258055"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.91904670),
        dec: Angle.Degrees(-78.09912194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78171"},
        {"Hipparcos Number", "HIP 44145"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.85254676),
        dec: Angle.Degrees(-78.09266820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52121"},
        {"Hipparcos Number", "HIP 32733"},
        {"Smithsonian Astrophysical Observation", "SAO 256345"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.41830229),
        dec: Angle.Degrees(-78.09011313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62039"},
        {"Hipparcos Number", "HIP 36658"},
        {"Geneva Identification System", "GEN# +1.00062039"},
        {"Smithsonian Astrophysical Observation", "SAO 256424"},
        {"Wilson Evans Batten Catalogue", "WEB 7289"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.10517993),
        dec: Angle.Degrees(-78.08598313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18891"},
        {"Hipparcos Number", "HIP 13562"},
        {"Smithsonian Astrophysical Observation", "SAO 255935"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.67407492),
        dec: Angle.Degrees(-78.08251855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4438"},
        {"Hipparcos Number", "HIP 3490"},
        {"Geneva Identification System", "GEN# +1.00004438"},
        {"Smithsonian Astrophysical Observation", "SAO 255701"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.14728037),
        dec: Angle.Degrees(-78.08217284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152463"},
        {"Hipparcos Number", "HIP 83464"},
        {"Smithsonian Astrophysical Observation", "SAO 257453"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.88668974),
        dec: Angle.Degrees(-78.07949981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89600"},
        {"Hipparcos Number", "HIP 50257"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.93051741),
        dec: Angle.Degrees(-78.07014242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9851"},
        {"Hipparcos Number", "HIP 7128"},
        {"Geneva Identification System", "GEN# +1.00009851"},
        {"Smithsonian Astrophysical Observation", "SAO 255791"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.95961560),
        dec: Angle.Degrees(-78.06926963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8927"},
        {"Hipparcos Number", "HIP 6532"},
        {"Smithsonian Astrophysical Observation", "SAO 255775"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.99185771),
        dec: Angle.Degrees(-78.06792059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171043"},
        {"Hipparcos Number", "HIP 91795"},
        {"Geneva Identification System", "GEN# +1.00171043"},
        {"Smithsonian Astrophysical Observation", "SAO 257615"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.76320213),
        dec: Angle.Degrees(-78.06626301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155101"},
        {"Hipparcos Number", "HIP 84779"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.93842046),
        dec: Angle.Degrees(-78.06597254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176464"},
        {"Hipparcos Number", "HIP 94191"},
        {"Geneva Identification System", "GEN# +1.00176464"},
        {"Smithsonian Astrophysical Observation", "SAO 257660"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.63914517),
        dec: Angle.Degrees(-78.05890962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76779"},
        {"Hipparcos Number", "HIP 43423"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.67114865),
        dec: Angle.Degrees(-78.04472949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28399"},
        {"Hipparcos Number", "HIP 20143"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.77492074),
        dec: Angle.Degrees(-78.03885335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111830"},
        {"Hipparcos Number", "HIP 62964"},
        {"Smithsonian Astrophysical Observation", "SAO 256987"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.54040000),
        dec: Angle.Degrees(-78.03709294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187874"},
        {"Hipparcos Number", "HIP 98592"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.39112804),
        dec: Angle.Degrees(-78.02751017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141846"},
        {"Hipparcos Number", "HIP 78360"},
        {"Smithsonian Astrophysical Observation", "SAO 257341"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97974391),
        dec: Angle.Degrees(-78.02709871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69935"},
        {"Hipparcos Number", "HIP 40021"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.60382832),
        dec: Angle.Degrees(-78.02312644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31230"},
        {"Hipparcos Number", "HIP 22015"},
        {"Smithsonian Astrophysical Observation", "SAO 256126"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.00432685),
        dec: Angle.Degrees(-78.02149341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13221"},
        {"Hipparcos Number", "HIP 9610"},
        {"Geneva Identification System", "GEN# +1.00013221"},
        {"Smithsonian Astrophysical Observation", "SAO 255845"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88820093),
        dec: Angle.Degrees(-78.01011543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1558"},
        {"Hipparcos Number", "HIP 1531"},
        {"Geneva Identification System", "GEN# +1.00001558"},
        {"Smithsonian Astrophysical Observation", "SAO 255657"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.77211767),
        dec: Angle.Degrees(-77.98897714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196267"},
        {"Hipparcos Number", "HIP 102348"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.05801652),
        dec: Angle.Degrees(-77.98788444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100868"},
        {"Hipparcos Number", "HIP 56521"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.82028411),
        dec: Angle.Degrees(-77.96995176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203452"},
        {"Hipparcos Number", "HIP 106057"},
        {"Renson", "Renson 56630"},
        {"Smithsonian Astrophysical Observation", "SAO 257924"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.22533221),
        dec: Angle.Degrees(-77.96111816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115422"},
        {"Hipparcos Number", "HIP 65073"},
        {"Smithsonian Astrophysical Observation", "SAO 257029"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.08341596),
        dec: Angle.Degrees(-77.95858768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63609"},
        {"Hipparcos Number", "HIP 37378"},
        {"Geneva Identification System", "GEN# +1.00063609"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.09061464),
        dec: Angle.Degrees(-77.95462784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109994"},
        {"Hipparcos Number", "HIP 61864"},
        {"Smithsonian Astrophysical Observation", "SAO 256970"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17830184),
        dec: Angle.Degrees(-77.94837768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55573"},
        {"Hipparcos Number", "HIP 34020"},
        {"Geneva Identification System", "GEN# +1.00055573"},
        {"Smithsonian Astrophysical Observation", "SAO 256368"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.88213846),
        dec: Angle.Degrees(-77.94317986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131380"},
        {"Hipparcos Number", "HIP 73429"},
        {"Smithsonian Astrophysical Observation", "SAO 257217"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09187272),
        dec: Angle.Degrees(-77.93469531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13641"},
        {"Hipparcos Number", "HIP 9901"},
        {"Smithsonian Astrophysical Observation", "SAO 255853"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.85679897),
        dec: Angle.Degrees(-77.92117933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24965"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.21208622),
        dec: Angle.Degrees(-77.92099356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 278.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138289"},
        {"Hipparcos Number", "HIP 76664"},
        {"Fundamental Katalog 5th Edition", "FK5 3228"},
        {"Geneva Identification System", "GEN# +1.00138289"},
        {"Smithsonian Astrophysical Observation", "SAO 257303"},
        {"Wilson Evans Batten Catalogue", "WEB 13014"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.82757495),
        dec: Angle.Degrees(-77.91768742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26644"},
        {"Hipparcos Number", "HIP 18949"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91427700),
        dec: Angle.Degrees(-77.91560881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20735"},
        {"Hipparcos Number", "HIP 14926"},
        {"Geneva Identification System", "GEN# +1.00020735"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.13009914),
        dec: Angle.Degrees(-77.91518185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171004"},
        {"Hipparcos Number", "HIP 91756"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.66013705),
        dec: Angle.Degrees(-77.91273549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58400"},
    },
    visualMagnitude: 10.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.61780260),
        dec: Angle.Degrees(-77.90822425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86692"},
        {"Hipparcos Number", "HIP 48600"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.67465942),
        dec: Angle.Degrees(-77.90098585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219124"},
        {"Hipparcos Number", "HIP 114826"},
        {"Smithsonian Astrophysical Observation", "SAO 258120"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.89922869),
        dec: Angle.Degrees(-77.89468266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82114"},
        {"Hipparcos Number", "HIP 46046"},
        {"Cincinnati Publication", "Ci 20 527"},
        {"Geneva Identification System", "GEN# +1.00082114"},
        {"Smithsonian Astrophysical Observation", "SAO 256614"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.85628183),
        dec: Angle.Degrees(-77.89137937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -250.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 353.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113513"},
        {"Hipparcos Number", "HIP 63995"},
        {"Geneva Identification System", "GEN# +1.00113513"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.71229050),
        dec: Angle.Degrees(-77.87046722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171990"},
        {"Hipparcos Number", "HIP 92233"},
        {"Geneva Identification System", "GEN# +1.00171990"},
        {"Smithsonian Astrophysical Observation", "SAO 257625"},
        {"Wilson Evans Batten Catalogue", "WEB 15914"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.95501862),
        dec: Angle.Degrees(-77.86861256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89615"},
        {"Hipparcos Number", "HIP 50274"},
        {"Geneva Identification System", "GEN# +1.00089615"},
        {"Smithsonian Astrophysical Observation", "SAO 256696"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.97787359),
        dec: Angle.Degrees(-77.86738325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119991"},
        {"Hipparcos Number", "HIP 67606"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.79054353),
        dec: Angle.Degrees(-77.86544252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177078"},
        {"Hipparcos Number", "HIP 94428"},
        {"Fundamental Katalog 5th Edition", "FK5 3527"},
        {"Smithsonian Astrophysical Observation", "SAO 257665"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.28804259),
        dec: Angle.Degrees(-77.86408697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18696"},
        {"Hipparcos Number", "HIP 13442"},
        {"Smithsonian Astrophysical Observation", "SAO 255934"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.27019297),
        dec: Angle.Degrees(-77.86328687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66196"},
        {"Smithsonian Astrophysical Observation", "SAO 257063"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.52631377),
        dec: Angle.Degrees(-77.86065737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5489"},
        {"Hipparcos Number", "HIP 4241"},
        {"Smithsonian Astrophysical Observation", "SAO 255720"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.53804942),
        dec: Angle.Degrees(-77.85833962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40988"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.47432995),
        dec: Angle.Degrees(-77.85488341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175556"},
        {"Hipparcos Number", "HIP 93774"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.45175108),
        dec: Angle.Degrees(-77.85399222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109952"},
        {"Hipparcos Number", "HIP 61792"},
        {"Cincinnati Publication", "Ci 20 725"},
        {"Geneva Identification System", "GEN# +1.00109952"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.97286016),
        dec: Angle.Degrees(-77.84412853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -853.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 356.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197767"},
        {"Hipparcos Number", "HIP 103118"},
        {"Geneva Identification System", "GEN# +1.00197767"},
        {"Smithsonian Astrophysical Observation", "SAO 257860"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.39485329),
        dec: Angle.Degrees(-77.83849564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122500"},
        {"Hipparcos Number", "HIP 68980"},
        {"Geneva Identification System", "GEN# +1.00122500"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.83130796),
        dec: Angle.Degrees(-77.83310954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157725"},
        {"Hipparcos Number", "HIP 86044"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.76533985),
        dec: Angle.Degrees(-77.83015076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104036"},
        {"Hipparcos Number", "HIP 58410"},
        {"Fundamental Katalog 5th Edition", "FK5 2957"},
        {"Geneva Identification System", "GEN# +1.00104036"},
        {"Smithsonian Astrophysical Observation", "SAO 256892"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.64731165),
        dec: Angle.Degrees(-77.82539341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162049"},
        {"Hipparcos Number", "HIP 88082"},
        {"Fundamental Katalog 5th Edition", "FK5 3421"},
        {"Smithsonian Astrophysical Observation", "SAO 257545"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.83816712),
        dec: Angle.Degrees(-77.82395329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102157"},
        {"Hipparcos Number", "HIP 57263"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.15047584),
        dec: Angle.Degrees(-77.81741253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141416"},
        {"Hipparcos Number", "HIP 78156"},
        {"Geneva Identification System", "GEN# +1.00141416"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.38801769),
        dec: Angle.Degrees(-77.80977126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207160"},
        {"Hipparcos Number", "HIP 107999"},
        {"Smithsonian Astrophysical Observation", "SAO 257968"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.20185367),
        dec: Angle.Degrees(-77.80845002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97240"},
        {"Hipparcos Number", "HIP 54521"},
        {"Geneva Identification System", "GEN# +1.00097240"},
        {"Smithsonian Astrophysical Observation", "SAO 256804"},
        {"Wilson Evans Batten Catalogue", "WEB 9841"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.32520917),
        dec: Angle.Degrees(-77.79436044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220129"},
        {"Hipparcos Number", "HIP 115449"},
        {"Geneva Identification System", "GEN# +1.00220129"},
        {"Smithsonian Astrophysical Observation", "SAO 258134"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.78552221),
        dec: Angle.Degrees(-77.78901333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53144"},
        {"Hipparcos Number", "HIP 33140"},
        {"Smithsonian Astrophysical Observation", "SAO 256352"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.51470183),
        dec: Angle.Degrees(-77.78083615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57697"},
        {"Hipparcos Number", "HIP 34844"},
        {"Geneva Identification System", "GEN# +1.00057697"},
    },
    visualMagnitude: 9.70,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.15789648),
        dec: Angle.Degrees(-77.76218947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200737"},
        {"Hipparcos Number", "HIP 104691"},
        {"Smithsonian Astrophysical Observation", "SAO 257892"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.10750631),
        dec: Angle.Degrees(-77.76127466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150778"},
        {"Hipparcos Number", "HIP 82574"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.20828716),
        dec: Angle.Degrees(-77.75883894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121951"},
        {"Hipparcos Number", "HIP 68685"},
        {"Geneva Identification System", "GEN# +1.00121951"},
        {"Smithsonian Astrophysical Observation", "SAO 257108"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.89770155),
        dec: Angle.Degrees(-77.75725944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148278"},
        {"Hipparcos Number", "HIP 81299"},
        {"Smithsonian Astrophysical Observation", "SAO 257410"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.08626208),
        dec: Angle.Degrees(-77.74444824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184736"},
        {"Hipparcos Number", "HIP 97203"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.32517032),
        dec: Angle.Degrees(-77.73965493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141059"},
        {"Hipparcos Number", "HIP 77980"},
        {"Smithsonian Astrophysical Observation", "SAO 257331"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.86996569),
        dec: Angle.Degrees(-77.73219561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72904"},
        {"Hipparcos Number", "HIP 41453"},
        {"Smithsonian Astrophysical Observation", "SAO 256517"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.82661920),
        dec: Angle.Degrees(-77.72932203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212301"},
        {"Henry Draper 2", "HD 212301A"},
        {"Hipparcos Number", "HIP 110852"},
        {"Geneva Identification System", "GEN# +1.00212301"},
        {"Smithsonian Astrophysical Observation", "SAO 258040"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.87796168),
        dec: Angle.Degrees(-77.71769963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135480"},
        {"Hipparcos Number", "HIP 75273"},
        {"Geneva Identification System", "GEN# +1.00135480"},
        {"Renson", "Renson 38480"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68873252),
        dec: Angle.Degrees(-77.70525714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61183"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.04414994),
        dec: Angle.Degrees(-77.70121931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134109"},
        {"Hipparcos Number", "HIP 74661"},
        {"Renson", "Renson 38070"},
    },
    visualMagnitude: 9.19,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.86267558),
        dec: Angle.Degrees(-77.69770556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39338"},
        {"Hipparcos Number", "HIP 26824"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.42834484),
        dec: Angle.Degrees(-77.69713031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25019"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.35460888),
        dec: Angle.Degrees(-77.69542541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48584"},
        {"Hipparcos Number", "HIP 31314"},
        {"Fundamental Katalog 5th Edition", "FK5 2514"},
        {"Geneva Identification System", "GEN# +1.00048584"},
        {"Smithsonian Astrophysical Observation", "SAO 256317"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.51056148),
        dec: Angle.Degrees(-77.68755771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29058"},
        {"Hipparcos Number", "HIP 20610"},
        {"Smithsonian Astrophysical Observation", "SAO 256092"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.21999541),
        dec: Angle.Degrees(-77.68500591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20612"},
        {"Smithsonian Astrophysical Observation", "SAO 256094"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.23242668),
        dec: Angle.Degrees(-77.68390394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124136"},
        {"Hipparcos Number", "HIP 69794"},
        {"Smithsonian Astrophysical Observation", "SAO 257132"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26702221),
        dec: Angle.Degrees(-77.68110354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180074"},
        {"Hipparcos Number", "HIP 95431"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.18445152),
        dec: Angle.Degrees(-77.67639010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52365"},
        {"Hipparcos Number", "HIP 32884"},
        {"Geneva Identification System", "GEN# +1.00052365"},
        {"Smithsonian Astrophysical Observation", "SAO 256347"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.78294905),
        dec: Angle.Degrees(-77.67452551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166329"},
        {"Hipparcos Number", "HIP 89858"},
        {"Smithsonian Astrophysical Observation", "SAO 257579"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.06805483),
        dec: Angle.Degrees(-77.67191030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124099"},
        {"Hipparcos Number", "HIP 69778"},
        {"Geneva Identification System", "GEN# +1.00124099"},
        {"Smithsonian Astrophysical Observation", "SAO 257131"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.22985498),
        dec: Angle.Degrees(-77.66421460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208500"},
        {"Hipparcos Number", "HIP 108759"},
        {"Geneva Identification System", "GEN# +1.00208500"},
        {"Smithsonian Astrophysical Observation", "SAO 257990"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.46936672),
        dec: Angle.Degrees(-77.66252854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193698"},
        {"Hipparcos Number", "HIP 101129"},
        {"Geneva Identification System", "GEN# +1.00193698"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.49311618),
        dec: Angle.Degrees(-77.65711510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18924"},
        {"Hipparcos Number", "HIP 13617"},
        {"Smithsonian Astrophysical Observation", "SAO 255937"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86408303),
        dec: Angle.Degrees(-77.65649616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30479"},
        {"Hipparcos Number", "HIP 21611"},
        {"Fundamental Katalog 5th Edition", "FK5 2350"},
        {"Geneva Identification System", "GEN# +1.00030479"},
        {"Smithsonian Astrophysical Observation", "SAO 256116"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.59060165),
        dec: Angle.Degrees(-77.65597754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54413",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "CED 111 IRS 2"},
        {"Henry Draper", "HD 97048"},
        {"Hipparcos Number", "HIP 54413"},
        {"Geneva Identification System", "GEN# +9.00110018"},
        {"Geneva Identification System 2", "GEN# +1.00097048"},
        {"Geneva Identification System 3", "GEN# +9.00110032"},
        {"Smithsonian Astrophysical Observation", "SAO 256802"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.01405010),
        dec: Angle.Degrees(-77.65486135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119560"},
        {"Hipparcos Number", "HIP 67351"},
        {"Geneva Identification System", "GEN# +1.00119560"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.05962133),
        dec: Angle.Degrees(-77.65365933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59909"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.32325911),
        dec: Angle.Degrees(-77.64687530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15249"},
        {"Hipparcos Number", "HIP 10978"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.35472349),
        dec: Angle.Degrees(-77.64551579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81485"},
        {"Hipparcos Number", "HIP 45734"},
        {"Geneva Identification System", "GEN# +1.00081485"},
        {"Smithsonian Astrophysical Observation", "SAO 256606"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.85400060),
        dec: Angle.Degrees(-77.64360316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54365",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "CED 111 IRS 1"},
        {"Hipparcos Number", "HIP 54365"},
        {"Geneva Identification System", "GEN# +9.00110013"},
        {"Geneva Identification System 2", "GEN# -0.07600652"},
    },
    visualMagnitude: 10.64,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.83661800),
        dec: Angle.Degrees(-77.63536701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62689"},
        {"Hipparcos Number", "HIP 36982"},
        {"Fundamental Katalog 5th Edition", "FK5 2596"},
        {"Geneva Identification System", "GEN# +1.00062689"},
        {"Smithsonian Astrophysical Observation", "SAO 256431"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.01745387),
        dec: Angle.Degrees(-77.63414808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80727"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.22246907),
        dec: Angle.Degrees(-77.63169902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127636"},
        {"Hipparcos Number", "HIP 71601"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.65647114),
        dec: Angle.Degrees(-77.61641921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22387"},
        {"Hipparcos Number", "HIP 16140"},
        {"Smithsonian Astrophysical Observation", "SAO 255993"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.99342467),
        dec: Angle.Degrees(-77.61330094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14444"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.60933815),
        dec: Angle.Degrees(-77.61079997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74891"},
        {"Hipparcos Number", "HIP 42416"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75009510),
        dec: Angle.Degrees(-77.61051820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99015"},
        {"Hipparcos Number", "HIP 55497"},
        {"Geneva Identification System", "GEN# +1.00099015"},
        {"Smithsonian Astrophysical Observation", "SAO 256832"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.48794976),
        dec: Angle.Degrees(-77.60834843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77375"},
        {"Hipparcos Number", "HIP 43762"},
        {"Smithsonian Astrophysical Observation", "SAO 256567"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.71789562),
        dec: Angle.Degrees(-77.60575897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93828"},
        {"Hipparcos Number", "HIP 52712"},
        {"Smithsonian Astrophysical Observation", "SAO 256757"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65825181),
        dec: Angle.Degrees(-77.60097424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42123"},
        {"Hipparcos Number", "HIP 28298"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.71331112),
        dec: Angle.Degrees(-77.60051292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6783"},
        {"Hipparcos Number", "HIP 5112"},
        {"Geneva Identification System", "GEN# +1.00006783"},
        {"Renson", "Renson 1760"},
        {"Smithsonian Astrophysical Observation", "SAO 255739"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.38035541),
        dec: Angle.Degrees(-77.58463919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85900"},
    },
    visualMagnitude: 12.32,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.30457321),
        dec: Angle.Degrees(-77.57614500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184039"},
        {"Hipparcos Number", "HIP 96892"},
        {"Fundamental Katalog 5th Edition", "FK5 5736"},
        {"Smithsonian Astrophysical Observation", "SAO 257716"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.43510723),
        dec: Angle.Degrees(-77.57468808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66125",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66125"},
        {"Geneva Identification System", "GEN# +1.00117360B"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.33191005),
        dec: Angle.Degrees(-77.57321542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -350.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222973"},
        {"Hipparcos Number", "HIP 117234"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.56513846),
        dec: Angle.Degrees(-77.56916097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117360"},
        {"Hipparcos Number", "HIP 66121"},
        {"Geneva Identification System", "GEN# +1.00117360A"},
        {"Smithsonian Astrophysical Observation", "SAO 257060"},
        {"Wilson Evans Batten Catalogue", "WEB 11684"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.31106587),
        dec: Angle.Degrees(-77.56901864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -367.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34297"},
        {"Hipparcos Number", "HIP 23776"},
        {"Geneva Identification System", "GEN# +1.00034297"},
        {"Smithsonian Astrophysical Observation", "SAO 256162"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.64710323),
        dec: Angle.Degrees(-77.56645217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174101"},
        {"Hipparcos Number", "HIP 93176"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.68810130),
        dec: Angle.Degrees(-77.56547437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161462"},
        {"Hipparcos Number", "HIP 87763"},
        {"Geneva Identification System", "GEN# +1.00161462"},
        {"Smithsonian Astrophysical Observation", "SAO 257536"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.91998679),
        dec: Angle.Degrees(-77.55814521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6446"},
        {"Hipparcos Number", "HIP 4869"},
        {"Fundamental Katalog 5th Edition", "FK5 2067"},
        {"Geneva Identification System", "GEN# +1.00006446"},
        {"Smithsonian Astrophysical Observation", "SAO 255731"},
        {"Wilson Evans Batten Catalogue", "WEB 947"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.65329989),
        dec: Angle.Degrees(-77.55090575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149197"},
        {"Hipparcos Number", "HIP 81805"},
        {"Geneva Identification System", "GEN# +1.00149197"},
        {"Smithsonian Astrophysical Observation", "SAO 257422"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.63016993),
        dec: Angle.Degrees(-77.54749861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199435"},
        {"Hipparcos Number", "HIP 104018"},
        {"Geneva Identification System", "GEN# +1.00199435"},
        {"Smithsonian Astrophysical Observation", "SAO 257878"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.09844386),
        dec: Angle.Degrees(-77.54531935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49286"},
        {"Hipparcos Number", "HIP 31678"},
        {"Smithsonian Astrophysical Observation", "SAO 256324"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42400894),
        dec: Angle.Degrees(-77.53860841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165337"},
        {"Hipparcos Number", "HIP 89462"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.86324156),
        dec: Angle.Degrees(-77.53090999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135528"},
        {"Hipparcos Number", "HIP 75289"},
        {"Geneva Identification System", "GEN# +1.00135528"},
        {"Smithsonian Astrophysical Observation", "SAO 257267"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.74092520),
        dec: Angle.Degrees(-77.52972246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119367"},
        {"Hipparcos Number", "HIP 67257"},
        {"Geneva Identification System", "GEN# +1.00119367"},
        {"Smithsonian Astrophysical Observation", "SAO 257088"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.78420965),
        dec: Angle.Degrees(-77.52566612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18006"},
        {"Hipparcos Number", "HIP 12958"},
        {"Renson", "Renson 4490"},
        {"Smithsonian Astrophysical Observation", "SAO 255922"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.66757617),
        dec: Angle.Degrees(-77.52099675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156628"},
        {"Hipparcos Number", "HIP 85511"},
        {"Smithsonian Astrophysical Observation", "SAO 257498"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.12602832),
        dec: Angle.Degrees(-77.51970841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98143"},
        {"Hipparcos Number", "HIP 54958"},
        {"Geneva Identification System", "GEN# +1.00098143"},
        {"Smithsonian Astrophysical Observation", "SAO 256818"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.82058660),
        dec: Angle.Degrees(-77.51835267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149324"},
        {"Hipparcos Number", "HIP 81852"},
        {"Cincinnati Publication", "Ci 20 1001"},
        {"Fundamental Katalog 5th Edition", "FK5 3319"},
        {"Geneva Identification System", "GEN# +1.00149324"},
        {"Smithsonian Astrophysical Observation", "SAO 257424"},
        {"Wilson Evans Batten Catalogue", "WEB 13828"},
    },
    visualMagnitude: 4.23,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77258180),
        dec: Angle.Degrees(-77.51657182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -355.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210853"},
        {"Hipparcos Number", "HIP 110078"},
        {"Fundamental Katalog 5th Edition", "FK5 3779"},
        {"Geneva Identification System", "GEN# +1.00210853"},
        {"Smithsonian Astrophysical Observation", "SAO 258020"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.46123241),
        dec: Angle.Degrees(-77.51158803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210400"},
        {"Hipparcos Number", "HIP 109848"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.71877735),
        dec: Angle.Degrees(-77.50269368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 312"},
        {"Hipparcos Number", "HIP 610"},
        {"Smithsonian Astrophysical Observation", "SAO 255633"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.85792694),
        dec: Angle.Degrees(-77.49416581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12121"},
        {"Hipparcos Number", "HIP 8866"},
        {"Smithsonian Astrophysical Observation", "SAO 255831"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.52525052),
        dec: Angle.Degrees(-77.49126185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3613"},
        {"Hipparcos Number", "HIP 2940"},
        {"Geneva Identification System", "GEN# +1.00003613"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.33113745),
        dec: Angle.Degrees(-77.48616205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71701"},
        {"Hipparcos Number", "HIP 40888"},
        {"Fundamental Katalog 5th Edition", "FK5 318"},
        {"Geneva Identification System", "GEN# +1.00071701A"},
        {"Smithsonian Astrophysical Observation", "SAO 256503"},
        {"Wilson Evans Batten Catalogue", "WEB 7930"},
    },
    visualMagnitude: 4.34,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.16203304),
        dec: Angle.Degrees(-77.48457640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 592"},
        {"Hipparcos Number", "HIP 816"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51334416),
        dec: Angle.Degrees(-77.48041239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142309"},
        {"Hipparcos Number", "HIP 78558"},
        {"Smithsonian Astrophysical Observation", "SAO 257348"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.59750553),
        dec: Angle.Degrees(-77.47807796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10622"},
    },
    visualMagnitude: 11.48,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.18821744),
        dec: Angle.Degrees(-74.07097772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29782"},
        {"Hipparcos Number", "HIP 21157"},
        {"Smithsonian Astrophysical Observation", "SAO 256104"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.03074424),
        dec: Angle.Degrees(-77.47738145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215370"},
        {"Hipparcos Number", "HIP 112570"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.99938967),
        dec: Angle.Degrees(-77.46504308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146263"},
        {"Hipparcos Number", "HIP 80368"},
        {"Geneva Identification System", "GEN# +1.00146263"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.08492781),
        dec: Angle.Degrees(-77.46327686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139659"},
        {"Hipparcos Number", "HIP 77361"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.88104509),
        dec: Angle.Degrees(-77.46048493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114503"},
        {"Hipparcos Number", "HIP 64554"},
        {"Geneva Identification System", "GEN# +1.00114503"},
        {"Smithsonian Astrophysical Observation", "SAO 257017"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.47640780),
        dec: Angle.Degrees(-77.45918096)
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
    primaryId: "HIP 26901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39465"},
        {"Hipparcos Number", "HIP 26901"},
        {"Smithsonian Astrophysical Observation", "SAO 256231"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.66397972),
        dec: Angle.Degrees(-77.45213067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60455"},
        {"Hipparcos Number", "HIP 36008"},
        {"Renson", "Renson 16530"},
        {"Smithsonian Astrophysical Observation", "SAO 256412"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.31783286),
        dec: Angle.Degrees(-77.44807602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126810"},
        {"Hipparcos Number", "HIP 71197"},
        {"Geneva Identification System", "GEN# +1.00126810"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.41133268),
        dec: Angle.Degrees(-77.44485762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187916"},
        {"Hipparcos Number", "HIP 98561"},
        {"Smithsonian Astrophysical Observation", "SAO 257753"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31114273),
        dec: Angle.Degrees(-77.43693701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139475"},
        {"Hipparcos Number", "HIP 77251"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.60176022),
        dec: Angle.Degrees(-77.43424514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1801"},
        {"Hipparcos Number", "HIP 1706"},
        {"Geneva Identification System", "GEN# +1.00001801"},
        {"Smithsonian Astrophysical Observation", "SAO 255663"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.36976160),
        dec: Angle.Degrees(-77.42685699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15961"},
        {"Hipparcos Number", "HIP 11464"},
        {"Geneva Identification System", "GEN# +1.00015961"},
        {"Smithsonian Astrophysical Observation", "SAO 255891"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.96262657),
        dec: Angle.Degrees(-77.41856730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205478"},
        {"Hipparcos Number", "HIP 107089"},
        {"Fundamental Katalog 5th Edition", "FK5 810"},
        {"Geneva Identification System", "GEN# +1.00205478"},
        {"Smithsonian Astrophysical Observation", "SAO 257948"},
        {"Wilson Evans Batten Catalogue", "WEB 19344"},
    },
    visualMagnitude: 3.73,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.36863801),
        dec: Angle.Degrees(-77.38946215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -240.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21024"},
        {"Hipparcos Number", "HIP 15201"},
        {"Fundamental Katalog 5th Edition", "FK5 1095"},
        {"Geneva Identification System", "GEN# +1.00021024"},
        {"Smithsonian Astrophysical Observation", "SAO 255973"},
        {"Wilson Evans Batten Catalogue", "WEB 2926"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.98899185),
        dec: Angle.Degrees(-77.38860498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221420"},
        {"Hipparcos Number", "HIP 116250"},
        {"Fundamental Katalog 5th Edition", "FK5 3887"},
        {"Geneva Identification System", "GEN# +1.00221420"},
        {"Smithsonian Astrophysical Observation", "SAO 258154"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.33143988),
        dec: Angle.Degrees(-77.38533173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37288"},
        {"Hipparcos Number", "HIP 25526"},
        {"Smithsonian Astrophysical Observation", "SAO 256197"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.87630037),
        dec: Angle.Degrees(-77.38192573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168241"},
        {"Hipparcos Number", "HIP 90549"},
        {"Fundamental Katalog 5th Edition", "FK5 3462"},
        {"Smithsonian Astrophysical Observation", "SAO 257593"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.14534884),
        dec: Angle.Degrees(-77.36607427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11185"},
        {"Hipparcos Number", "HIP 8199"},
        {"Smithsonian Astrophysical Observation", "SAO 255814"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.34940940),
        dec: Angle.Degrees(-77.35691787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134333"},
        {"Hipparcos Number", "HIP 74733"},
        {"Smithsonian Astrophysical Observation", "SAO 257255"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.09984491),
        dec: Angle.Degrees(-77.35415871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159496"},
        {"Hipparcos Number", "HIP 86867"},
        {"Smithsonian Astrophysical Observation", "SAO 257523"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.22966215),
        dec: Angle.Degrees(-77.35350046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110336"},
        {"Hipparcos Number", "HIP 62050"},
        {"Geneva Identification System", "GEN# +1.00110336"},
        {"Smithsonian Astrophysical Observation", "SAO 256974"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.77237731),
        dec: Angle.Degrees(-77.35104741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148385"},
        {"Hipparcos Number", "HIP 81333"},
        {"Geneva Identification System", "GEN# +1.00148385"},
        {"Renson", "Renson 41950"},
        {"Smithsonian Astrophysical Observation", "SAO 257411"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.16577462),
        dec: Angle.Degrees(-77.34533249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207496"},
        {"Hipparcos Number", "HIP 108162"},
        {"Geneva Identification System", "GEN# +1.00207496"},
        {"Smithsonian Astrophysical Observation", "SAO 257976"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.71125142),
        dec: Angle.Degrees(-77.33754250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17808"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.16696882),
        dec: Angle.Degrees(-77.33686375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86077"},
        {"Hipparcos Number", "HIP 48308"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.72709837),
        dec: Angle.Degrees(-77.32375253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108799"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.61379282),
        dec: Angle.Degrees(-77.31390670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208604"},
        {"Hipparcos Number", "HIP 108801"},
        {"Smithsonian Astrophysical Observation", "SAO 257992"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.61877631),
        dec: Angle.Degrees(-77.31121505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113693"},
        {"Hipparcos Number", "HIP 64091"},
        {"Geneva Identification System", "GEN# +1.00113693"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.01195059),
        dec: Angle.Degrees(-77.30981360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106649"},
    },
    visualMagnitude: 12.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.03907017),
        dec: Angle.Degrees(-77.30369094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187338"},
        {"Hipparcos Number", "HIP 98293"},
        {"Geneva Identification System", "GEN# +1.00187338"},
        {"Smithsonian Astrophysical Observation", "SAO 257749"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.56106261),
        dec: Angle.Degrees(-77.30252751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9406"},
        {"Hipparcos Number", "HIP 6879"},
        {"Smithsonian Astrophysical Observation", "SAO 255785"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.14877705),
        dec: Angle.Degrees(-77.29676392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194238"},
        {"Hipparcos Number", "HIP 101358"},
        {"Smithsonian Astrophysical Observation", "SAO 257816"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.13197392),
        dec: Angle.Degrees(-77.29456648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47332"},
        {"Hipparcos Number", "HIP 30795"},
        {"Smithsonian Astrophysical Observation", "SAO 256308"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.06102120),
        dec: Angle.Degrees(-77.29093524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143326"},
        {"Hipparcos Number", "HIP 79056"},
        {"Smithsonian Astrophysical Observation", "SAO 257359"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.04890718),
        dec: Angle.Degrees(-77.28892844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42867"},
        {"Hipparcos Number", "HIP 28680"},
        {"Smithsonian Astrophysical Observation", "SAO 256266"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.82907378),
        dec: Angle.Degrees(-77.27755968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171425"},
        {"Hipparcos Number", "HIP 91932"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.11626955),
        dec: Angle.Degrees(-77.27501106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63585"},
        {"Hipparcos Number", "HIP 37411"},
        {"Smithsonian Astrophysical Observation", "SAO 256442"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.21185584),
        dec: Angle.Degrees(-77.27127155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162969"},
        {"Hipparcos Number", "HIP 88453"},
        {"Smithsonian Astrophysical Observation", "SAO 257553"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.88427691),
        dec: Angle.Degrees(-77.27053784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223013"},
        {"Hipparcos Number", "HIP 117252"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.63231645),
        dec: Angle.Degrees(-77.26227349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202290"},
        {"Hipparcos Number", "HIP 105426"},
        {"Geneva Identification System", "GEN# +1.00202290"},
        {"Smithsonian Astrophysical Observation", "SAO 257910"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.32458757),
        dec: Angle.Degrees(-77.26076059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2151"},
        {"Hipparcos Number", "HIP 2021"},
        {"Cincinnati Publication", "Ci 20 31"},
        {"Fundamental Katalog 5th Edition", "FK5 11"},
        {"Geneva Identification System", "GEN# +1.00002151"},
        {"Smithsonian Astrophysical Observation", "SAO 255670"},
        {"Wilson Evans Batten Catalogue", "WEB 376"},
    },
    visualMagnitude: 2.82,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.41334183),
        dec: Angle.Degrees(-77.25503511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2220.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 324.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82303"},
        {"Hipparcos Number", "HIP 46185"},
        {"Geneva Identification System", "GEN# +1.00082303"},
        {"Smithsonian Astrophysical Observation", "SAO 256618"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25299821),
        dec: Angle.Degrees(-77.25238561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93601"},
        {"Hipparcos Number", "HIP 52573"},
        {"Smithsonian Astrophysical Observation", "SAO 256753"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.25697382),
        dec: Angle.Degrees(-77.24631385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50626"},
        {"Hipparcos Number", "HIP 32289"},
        {"Smithsonian Astrophysical Observation", "SAO 256336"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.10868815),
        dec: Angle.Degrees(-77.24598434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12149"},
        {"Hipparcos Number", "HIP 8884"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.59754895),
        dec: Angle.Degrees(-77.24177659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143389"},
        {"Hipparcos Number", "HIP 79070"},
        {"Smithsonian Astrophysical Observation", "SAO 257360"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.11264975),
        dec: Angle.Degrees(-77.23880812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160436"},
        {"Hipparcos Number", "HIP 87248"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.41343556),
        dec: Angle.Degrees(-77.23779615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120845"},
        {"Hipparcos Number", "HIP 68100"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.13018781),
        dec: Angle.Degrees(-77.23748716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142878"},
        {"Hipparcos Number", "HIP 78815"},
        {"Smithsonian Astrophysical Observation", "SAO 257354"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.34268484),
        dec: Angle.Degrees(-77.23679134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223102"},
        {"Hipparcos Number", "HIP 117313"},
        {"Geneva Identification System", "GEN# +1.00223102"},
        {"Smithsonian Astrophysical Observation", "SAO 258185"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.81509229),
        dec: Angle.Degrees(-77.23515627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1686"},
        {"Hipparcos Number", "HIP 1623"},
        {"Geneva Identification System", "GEN# +1.00001686"},
        {"Smithsonian Astrophysical Observation", "SAO 255659"},
        {"Wilson Evans Batten Catalogue", "WEB 294"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.07095779),
        dec: Angle.Degrees(-77.22264886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34802"},
        {"Hipparcos Number", "HIP 24085"},
        {"Geneva Identification System", "GEN# +1.00034802"},
        {"Smithsonian Astrophysical Observation", "SAO 256167"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.61168145),
        dec: Angle.Degrees(-77.21708105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107863"},
        {"Hipparcos Number", "HIP 60526"},
        {"Geneva Identification System", "GEN# +1.00107863"},
        {"Smithsonian Astrophysical Observation", "SAO 256938"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.11741556),
        dec: Angle.Degrees(-77.21470031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7294"},
        {"Hipparcos Number", "HIP 5479"},
        {"Smithsonian Astrophysical Observation", "SAO 255749"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.53187918),
        dec: Angle.Degrees(-77.20650911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194148"},
        {"Henry Draper 2", "HD 194148A"},
        {"Hipparcos Number", "HIP 101291"},
        {"Smithsonian Astrophysical Observation", "SAO 257814"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.96774905),
        dec: Angle.Degrees(-77.19994830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81056"},
        {"Hipparcos Number", "HIP 45546"},
        {"Geneva Identification System", "GEN# +1.00081056"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.24208852),
        dec: Angle.Degrees(-77.19645467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220731"},
        {"Hipparcos Number", "HIP 115814"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.93492163),
        dec: Angle.Degrees(-77.19477104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155557"},
        {"Hipparcos Number", "HIP 84959"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.46644791),
        dec: Angle.Degrees(-77.19324299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183582"},
        {"Hipparcos Number", "HIP 96681"},
        {"Smithsonian Astrophysical Observation", "SAO 257711"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.83091250),
        dec: Angle.Degrees(-77.19262617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60484"},
        {"Hipparcos Number", "HIP 36033"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.37902884),
        dec: Angle.Degrees(-77.18649291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70656"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.77066655),
        dec: Angle.Degrees(-77.18284809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129899"},
        {"Hipparcos Number", "HIP 72670"},
        {"Geneva Identification System", "GEN# +1.00129899"},
        {"Renson", "Renson 37030"},
        {"Smithsonian Astrophysical Observation", "SAO 257202"},
    },
    visualMagnitude: 6.44,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.87530330),
        dec: Angle.Degrees(-77.17594571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11301"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.37115027),
        dec: Angle.Degrees(-77.17297519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126123"},
        {"Hipparcos Number", "HIP 70837"},
        {"Smithsonian Astrophysical Observation", "SAO 257160"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.28994403),
        dec: Angle.Degrees(-77.16703341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19880"},
        {"Hipparcos Number", "HIP 14311"},
        {"Geneva Identification System", "GEN# +1.00019880"},
        {"Smithsonian Astrophysical Observation", "SAO 255954"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.14978312),
        dec: Angle.Degrees(-77.16588707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116440"},
        {"Hipparcos Number", "HIP 65600"},
        {"Smithsonian Astrophysical Observation", "SAO 257044"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.74834411),
        dec: Angle.Degrees(-77.16569163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131425"},
        {"Hipparcos Number", "HIP 73415"},
        {"Geneva Identification System", "GEN# +1.00131425"},
        {"Smithsonian Astrophysical Observation", "SAO 257218"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.04724166),
        dec: Angle.Degrees(-77.16052523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209539"},
        {"Hipparcos Number", "HIP 109323"},
        {"Smithsonian Astrophysical Observation", "SAO 258001"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23046828),
        dec: Angle.Degrees(-77.16017735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145308"},
        {"Hipparcos Number", "HIP 79933"},
        {"Smithsonian Astrophysical Observation", "SAO 257377"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.71787378),
        dec: Angle.Degrees(-77.14470272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213223"},
        {"Hipparcos Number", "HIP 111367"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.42447532),
        dec: Angle.Degrees(-77.14426064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94414"},
        {"Hipparcos Number", "HIP 53024"},
        {"Geneva Identification System", "GEN# +1.00094414"},
        {"Smithsonian Astrophysical Observation", "SAO 256763"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.73331256),
        dec: Angle.Degrees(-77.12460185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80011"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.99367418),
        dec: Angle.Degrees(-77.12335425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131060"},
        {"Hipparcos Number", "HIP 73231"},
        {"Smithsonian Astrophysical Observation", "SAO 257211"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.50133208),
        dec: Angle.Degrees(-77.12311760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75485"},
        {"Hipparcos Number", "HIP 42774"},
        {"Smithsonian Astrophysical Observation", "SAO 256546"},
        {"Wilson Evans Batten Catalogue", "WEB 8262"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.73607281),
        dec: Angle.Degrees(-77.11781151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23346"},
        {"Hipparcos Number", "HIP 16821"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.11129604),
        dec: Angle.Degrees(-77.11624613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8441"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.21141991),
        dec: Angle.Degrees(-77.10851644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 259.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44148"},
        {"Hipparcos Number", "HIP 29284"},
        {"Fundamental Katalog 5th Edition", "FK5 2476"},
        {"Geneva Identification System", "GEN# +1.00044148"},
        {"Smithsonian Astrophysical Observation", "SAO 256277"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.61047229),
        dec: Angle.Degrees(-77.10563282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69958"},
        {"Hipparcos Number", "HIP 40081"},
        {"Smithsonian Astrophysical Observation", "SAO 256487"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.81096045),
        dec: Angle.Degrees(-77.09751487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189450"},
        {"Hipparcos Number", "HIP 99214"},
        {"Smithsonian Astrophysical Observation", "SAO 257770"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12022714),
        dec: Angle.Degrees(-77.09211460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123363"},
        {"Hipparcos Number", "HIP 69380"},
        {"Smithsonian Astrophysical Observation", "SAO 257121"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.04144286),
        dec: Angle.Degrees(-77.09178832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23400"},
        {"Hipparcos Number", "HIP 16850"},
        {"Smithsonian Astrophysical Observation", "SAO 256004"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.20962971),
        dec: Angle.Degrees(-77.08998348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89480"},
        {"Hipparcos Number", "HIP 50236"},
        {"Geneva Identification System", "GEN# +1.00089480"},
        {"Smithsonian Astrophysical Observation", "SAO 256695"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.85378643),
        dec: Angle.Degrees(-77.08806655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62093"},
        {"Hipparcos Number", "HIP 36744"},
        {"Smithsonian Astrophysical Observation", "SAO 256426"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.36302903),
        dec: Angle.Degrees(-77.08291553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87015"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.70929541),
        dec: Angle.Degrees(-77.08180678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75893"},
        {"Hipparcos Number", "HIP 42984"},
        {"Geneva Identification System", "GEN# +1.00075893"},
        {"Smithsonian Astrophysical Observation", "SAO 256551"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.40889463),
        dec: Angle.Degrees(-77.07527665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165416"},
        {"Hipparcos Number", "HIP 89479"},
        {"Smithsonian Astrophysical Observation", "SAO 257574"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.89748690),
        dec: Angle.Degrees(-77.07348949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224889"},
        {"Hipparcos Number", "HIP 122"},
        {"Fundamental Katalog 5th Edition", "FK5 904"},
        {"Geneva Identification System", "GEN# +1.00224889"},
        {"Smithsonian Astrophysical Observation", "SAO 258207"},
        {"Wilson Evans Batten Catalogue", "WEB 16"},
    },
    visualMagnitude: 4.78,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.39937928),
        dec: Angle.Degrees(-77.06529438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90458"},
        {"Hipparcos Number", "HIP 50820"},
        {"Smithsonian Astrophysical Observation", "SAO 256706"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.64650519),
        dec: Angle.Degrees(-77.06397530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173083"},
        {"Hipparcos Number", "HIP 92681"},
        {"Smithsonian Astrophysical Observation", "SAO 257632"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.27454009),
        dec: Angle.Degrees(-77.05647626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28267"},
        {"Hipparcos Number", "HIP 20110"},
        {"Smithsonian Astrophysical Observation", "SAO 256080"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.67279946),
        dec: Angle.Degrees(-77.05622005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74903"},
        {"Hipparcos Number", "HIP 42460"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.84937891),
        dec: Angle.Degrees(-77.05529630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101727"},
        {"Hipparcos Number", "HIP 57027"},
        {"Geneva Identification System", "GEN# +1.00101727"},
        {"Smithsonian Astrophysical Observation", "SAO 256862"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.38547291),
        dec: Angle.Degrees(-77.05465495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44981"},
        {"Hipparcos Number", "HIP 29684"},
        {"Geneva Identification System", "GEN# +1.00044981"},
        {"Smithsonian Astrophysical Observation", "SAO 256288"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.80250012),
        dec: Angle.Degrees(-77.05240543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215631"},
        {"Hipparcos Number", "HIP 112725"},
        {"Geneva Identification System", "GEN# +1.00215631"},
        {"Smithsonian Astrophysical Observation", "SAO 258069"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.42040879),
        dec: Angle.Degrees(-77.05104599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128561"},
        {"Hipparcos Number", "HIP 72005"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.89295779),
        dec: Angle.Degrees(-77.05073842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27222"},
        {"Hipparcos Number", "HIP 19393"},
        {"Smithsonian Astrophysical Observation", "SAO 256067"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.30664526),
        dec: Angle.Degrees(-77.05057768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75591"},
        {"Hipparcos Number", "HIP 42830"},
        {"Smithsonian Astrophysical Observation", "SAO 256548"},
        {"Wilson Evans Batten Catalogue", "WEB 8276"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.90167781),
        dec: Angle.Degrees(-77.04954232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177525"},
        {"Hipparcos Number", "HIP 94532"},
        {"Fundamental Katalog 5th Edition", "FK5 5692"},
        {"Smithsonian Astrophysical Observation", "SAO 257667"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58961002),
        dec: Angle.Degrees(-77.04792299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11972"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.61167256),
        dec: Angle.Degrees(-77.04608846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139537"},
        {"Hipparcos Number", "HIP 77271"},
        {"Smithsonian Astrophysical Observation", "SAO 257316"},
    },
    visualMagnitude: 9.42,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.64107450),
        dec: Angle.Degrees(-77.04505997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83735"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.70626559),
        dec: Angle.Degrees(-77.03342373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113074"},
        {"Hipparcos Number", "HIP 63722"},
        {"Smithsonian Astrophysical Observation", "SAO 257004"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.87903915),
        dec: Angle.Degrees(-77.03159939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8306"},
        {"Hipparcos Number", "HIP 6161"},
        {"Geneva Identification System", "GEN# +1.00008306"},
        {"Smithsonian Astrophysical Observation", "SAO 255762"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.75570086),
        dec: Angle.Degrees(-77.03082906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58160"},
        {"Hipparcos Number", "HIP 35091"},
        {"Geneva Identification System", "GEN# +1.00058160"},
        {"Smithsonian Astrophysical Observation", "SAO 256389"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.85071638),
        dec: Angle.Degrees(-77.02927311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20740"},
        {"Hipparcos Number", "HIP 14978"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.26777830),
        dec: Angle.Degrees(-77.02868133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57043"},
        {"Hipparcos Number", "HIP 34636"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.61054634),
        dec: Angle.Degrees(-77.02801819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53691"},
        {"Geneva Identification System", "GEN# +9.00110004"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.77929475),
        dec: Angle.Degrees(-77.02786918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199532"},
        {"Hipparcos Number", "HIP 104043"},
        {"Fundamental Katalog 5th Edition", "FK5 787"},
        {"Geneva Identification System", "GEN# +1.00199532"},
        {"Renson", "Renson 55600"},
        {"Smithsonian Astrophysical Observation", "SAO 257879"},
        {"Wilson Evans Batten Catalogue", "WEB 18952"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.17928592),
        dec: Angle.Degrees(-77.02286938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -369.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31378"},
        {"Hipparcos Number", "HIP 22165"},
        {"Smithsonian Astrophysical Observation", "SAO 256131"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.52885917),
        dec: Angle.Degrees(-77.02101456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224767"},
        {"Hipparcos Number", "HIP 52"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.14665879),
        dec: Angle.Degrees(-77.02014050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205394"},
        {"Hipparcos Number", "HIP 107045"},
        {"Smithsonian Astrophysical Observation", "SAO 257943"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.19596030),
        dec: Angle.Degrees(-77.01554425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85793"},
        {"Hipparcos Number", "HIP 48175"},
        {"Geneva Identification System", "GEN# +1.00085793"},
        {"Smithsonian Astrophysical Observation", "SAO 256663"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.28884438),
        dec: Angle.Degrees(-77.01384295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128294"},
        {"Hipparcos Number", "HIP 71870"},
        {"Smithsonian Astrophysical Observation", "SAO 257182"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.49900623),
        dec: Angle.Degrees(-77.01142210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103673"},
        {"Hipparcos Number", "HIP 58180"},
        {"Geneva Identification System", "GEN# +1.00103673"},
        {"Smithsonian Astrophysical Observation", "SAO 256885"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.98832926),
        dec: Angle.Degrees(-77.00841277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190207"},
        {"Hipparcos Number", "HIP 99551"},
        {"Geneva Identification System", "GEN# +1.00190207"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.04034319),
        dec: Angle.Degrees(-77.00168727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155725"},
        {"Hipparcos Number", "HIP 85032"},
        {"Smithsonian Astrophysical Observation", "SAO 257487"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.68952802),
        dec: Angle.Degrees(-76.99322505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137239"},
        {"Hipparcos Number", "HIP 76083"},
        {"Renson", "Renson 38990"},
        {"Smithsonian Astrophysical Observation", "SAO 257288"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.08314058),
        dec: Angle.Degrees(-76.98702554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162158"},
        {"Hipparcos Number", "HIP 88059"},
        {"Smithsonian Astrophysical Observation", "SAO 257546"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76965217),
        dec: Angle.Degrees(-76.98068712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79422"},
        {"Hipparcos Number", "HIP 44772"},
        {"Smithsonian Astrophysical Observation", "SAO 256588"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.87377843),
        dec: Angle.Degrees(-76.97888578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220791"},
        {"Hipparcos Number", "HIP 115840"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.02276548),
        dec: Angle.Degrees(-76.96538941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61563",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61563"},
        {"Cincinnati Publication", "Ci 20 722"},
        {"Geneva Identification System", "GEN# +6.10010478"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.21260202),
        dec: Angle.Degrees(-76.95468544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -873.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133428"},
        {"Hipparcos Number", "HIP 74294"},
        {"Renson", "Renson 37860"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.78609273),
        dec: Angle.Degrees(-76.94979354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210385"},
        {"Hipparcos Number", "HIP 109814"},
        {"Geneva Identification System", "GEN# +1.00210385"},
        {"Smithsonian Astrophysical Observation", "SAO 258012"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.63514359),
        dec: Angle.Degrees(-76.94243037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207576"},
        {"Hipparcos Number", "HIP 108192"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.79450035),
        dec: Angle.Degrees(-76.94066974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194705"},
        {"Hipparcos Number", "HIP 101548"},
        {"Smithsonian Astrophysical Observation", "SAO 257822"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.69093554),
        dec: Angle.Degrees(-76.93590217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200815"},
        {"Hipparcos Number", "HIP 104690"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.10510173),
        dec: Angle.Degrees(-76.93411499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73744"},
        {"Hipparcos Number", "HIP 41871"},
        {"Geneva Identification System", "GEN# +1.00073744"},
        {"Smithsonian Astrophysical Observation", "SAO 256525"},
        {"Wilson Evans Batten Catalogue", "WEB 8060"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.06682906),
        dec: Angle.Degrees(-76.92917790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217689"},
        {"Hipparcos Number", "HIP 113971"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.22467061),
        dec: Angle.Degrees(-76.92861722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4645"},
        {"Hipparcos Number", "HIP 3624"},
        {"Smithsonian Astrophysical Observation", "SAO 255705"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.61825615),
        dec: Angle.Degrees(-76.92172895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152744"},
        {"Hipparcos Number", "HIP 83533"},
        {"Smithsonian Astrophysical Observation", "SAO 257457"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.08213069),
        dec: Angle.Degrees(-76.92062478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71243"},
        {"Hipparcos Number", "HIP 40702"},
        {"Geneva Identification System", "GEN# +1.00071243"},
        {"Smithsonian Astrophysical Observation", "SAO 256496"},
        {"Wilson Evans Batten Catalogue", "WEB 7907"},
    },
    visualMagnitude: 4.05,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.63027850),
        dec: Angle.Degrees(-76.91998251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218948"},
        {"Hipparcos Number", "HIP 114713"},
        {"Smithsonian Astrophysical Observation", "SAO 258117"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.54469722),
        dec: Angle.Degrees(-76.91693956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9799"},
        {"Hipparcos Number", "HIP 7129"},
        {"Smithsonian Astrophysical Observation", "SAO 255790"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.96760871),
        dec: Angle.Degrees(-76.91388780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185712"},
        {"Hipparcos Number", "HIP 97511"},
        {"Fundamental Katalog 5th Edition", "FK5 3578"},
        {"Geneva Identification System", "GEN# +1.00185712"},
        {"Smithsonian Astrophysical Observation", "SAO 257731"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.29202501),
        dec: Angle.Degrees(-76.90849792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35828"},
        {"Hipparcos Number", "HIP 24722"},
        {"Geneva Identification System", "GEN# +1.00035828"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.53362111),
        dec: Angle.Degrees(-76.90435447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106391"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.22594895),
        dec: Angle.Degrees(-76.89823685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170692"},
        {"Hipparcos Number", "HIP 91549"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.04445627),
        dec: Angle.Degrees(-76.89512745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78509"},
        {"Hipparcos Number", "HIP 44355"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48955631),
        dec: Angle.Degrees(-76.89461560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195320"},
        {"Hipparcos Number", "HIP 101828"},
        {"Geneva Identification System", "GEN# +1.00195320"},
        {"Smithsonian Astrophysical Observation", "SAO 257830"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.53654091),
        dec: Angle.Degrees(-76.89265474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108089"},
        {"Hipparcos Number", "HIP 60650"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.46939892),
        dec: Angle.Degrees(-76.88371862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158011"},
        {"Hipparcos Number", "HIP 86129"},
        {"Smithsonian Astrophysical Observation", "SAO 257510"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.03331305),
        dec: Angle.Degrees(-76.87564549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225236"},
        {"Hipparcos Number", "HIP 359"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.14426919),
        dec: Angle.Degrees(-76.87353696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167891"},
        {"Hipparcos Number", "HIP 90403"},
        {"Geneva Identification System", "GEN# +1.00167891"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.68825773),
        dec: Angle.Degrees(-76.87332909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222060"},
        {"Hipparcos Number", "HIP 116653"},
        {"Geneva Identification System", "GEN# +1.00222060"},
        {"Smithsonian Astrophysical Observation", "SAO 258166"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.59870499),
        dec: Angle.Degrees(-76.86950742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102293"},
        {"Hipparcos Number", "HIP 57374"},
        {"Geneva Identification System", "GEN# +1.00102293"},
        {"Smithsonian Astrophysical Observation", "SAO 256871"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.43630580),
        dec: Angle.Degrees(-76.86017780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211809"},
        {"Hipparcos Number", "HIP 110568"},
        {"Geneva Identification System", "GEN# +1.00211809"},
        {"Smithsonian Astrophysical Observation", "SAO 258029"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.98199931),
        dec: Angle.Degrees(-76.85314082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51320"},
        {"Hipparcos Number", "HIP 32548"},
        {"Smithsonian Astrophysical Observation", "SAO 256339"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.87018732),
        dec: Angle.Degrees(-76.85147689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25864"},
        {"Hipparcos Number", "HIP 18515"},
        {"Smithsonian Astrophysical Observation", "SAO 256051"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.38179465),
        dec: Angle.Degrees(-76.83314310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75838"},
        {"Hipparcos Number", "HIP 42948"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.32180356),
        dec: Angle.Degrees(-76.82689769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68238"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.53956787),
        dec: Angle.Degrees(-76.81603357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41300"},
        {"Hipparcos Number", "HIP 27943"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.69436179),
        dec: Angle.Degrees(-76.80748909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107145"},
        {"Hipparcos Number", "HIP 60119"},
        {"Geneva Identification System", "GEN# +1.00107145"},
        {"Smithsonian Astrophysical Observation", "SAO 256927"},
        {"Wilson Evans Batten Catalogue", "WEB 10687"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.94087542),
        dec: Angle.Degrees(-76.80088463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79245"},
        {"Hipparcos Number", "HIP 44689"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.60678400),
        dec: Angle.Degrees(-76.80045709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216558"},
        {"Hipparcos Number", "HIP 113293"},
        {"Smithsonian Astrophysical Observation", "SAO 258086"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.12962379),
        dec: Angle.Degrees(-76.79791312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122250"},
        {"Hipparcos Number", "HIP 68815"},
        {"Fundamental Katalog 5th Edition", "FK5 1363"},
        {"Geneva Identification System", "GEN# +1.00122250"},
        {"Smithsonian Astrophysical Observation", "SAO 257112"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.33375541),
        dec: Angle.Degrees(-76.79667632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118774"},
        {"Hipparcos Number", "HIP 66911"},
        {"Smithsonian Astrophysical Observation", "SAO 257079"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.69132174),
        dec: Angle.Degrees(-76.79181008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215832"},
        {"Hipparcos Number", "HIP 112828"},
        {"Smithsonian Astrophysical Observation", "SAO 258074"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.74537228),
        dec: Angle.Degrees(-76.78983154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170325"},
        {"Hipparcos Number", "HIP 91372"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.52723884),
        dec: Angle.Degrees(-76.78295330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137469"},
        {"Hipparcos Number", "HIP 76181"},
        {"Geneva Identification System", "GEN# +1.00137469"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.40489048),
        dec: Angle.Degrees(-76.78184581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11407"},
        {"Hipparcos Number", "HIP 8351"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91727263),
        dec: Angle.Degrees(-76.78018470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85396"},
        {"Hipparcos Number", "HIP 47956"},
        {"Fundamental Katalog 5th Edition", "FK5 2784"},
        {"Geneva Identification System", "GEN# +1.00085396"},
        {"Smithsonian Astrophysical Observation", "SAO 256658"},
        {"Wilson Evans Batten Catalogue", "WEB 8968"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.58507788),
        dec: Angle.Degrees(-76.77598144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65118"},
        {"Hipparcos Number", "HIP 38132"},
        {"Renson", "Renson 17850"},
        {"Smithsonian Astrophysical Observation", "SAO 256452"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.20924494),
        dec: Angle.Degrees(-76.77317626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39490"},
        {"Hipparcos Number", "HIP 26985"},
        {"Geneva Identification System", "GEN# +1.00039490"},
        {"Smithsonian Astrophysical Observation", "SAO 256233"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.88594923),
        dec: Angle.Degrees(-76.76846241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 229.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84997"},
        {"Hipparcos Number", "HIP 47728"},
        {"Smithsonian Astrophysical Observation", "SAO 256650"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93972501),
        dec: Angle.Degrees(-76.76724952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87268"},
        {"Hipparcos Number", "HIP 48951"},
        {"Smithsonian Astrophysical Observation", "SAO 256675"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.79500078),
        dec: Angle.Degrees(-76.75763179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108282"},
        {"Hipparcos Number", "HIP 60770"},
        {"Geneva Identification System", "GEN# +1.00108282"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.85198073),
        dec: Angle.Degrees(-76.75549394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21940"},
        {"Hipparcos Number", "HIP 15886"},
        {"Geneva Identification System", "GEN# +1.00021940"},
        {"Renson", "Renson 5530"},
        {"Smithsonian Astrophysical Observation", "SAO 255988"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.15411329),
        dec: Angle.Degrees(-76.74611800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54744",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "CED 112 IRS 8"},
        {"Hipparcos Number", "HIP 54744"},
        {"Geneva Identification System", "GEN# +6.20078247"},
        {"Geneva Identification System 2", "GEN# +9.00110030"},
    },
    visualMagnitude: 11.06,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.11566313),
        dec: Angle.Degrees(-76.73951925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54738"},
        {"Geneva Identification System", "GEN# +9.00110031"},
    },
    visualMagnitude: 13.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.10543613),
        dec: Angle.Degrees(-76.73931363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45591"},
        {"Hipparcos Number", "HIP 30008"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74319957),
        dec: Angle.Degrees(-76.73272709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 276"},
        {"Hipparcos Number", "HIP 596"},
        {"Geneva Identification System", "GEN# +1.00000276"},
        {"Smithsonian Astrophysical Observation", "SAO 255632"},
        {"Wilson Evans Batten Catalogue", "WEB 104"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.80537479),
        dec: Angle.Degrees(-76.73091557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126209"},
        {"Hipparcos Number", "HIP 70874"},
        {"Geneva Identification System", "GEN# +1.00126209"},
        {"Smithsonian Astrophysical Observation", "SAO 257163"},
    },
    visualMagnitude: 6.06,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.40447558),
        dec: Angle.Degrees(-76.72901396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82188"},
        {"Hipparcos Number", "HIP 46138"},
        {"Smithsonian Astrophysical Observation", "SAO 256617"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.13040169),
        dec: Angle.Degrees(-76.72614665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2002"},
        {"Hipparcos Number", "HIP 1838"},
        {"Smithsonian Astrophysical Observation", "SAO 255667"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.81710422),
        dec: Angle.Degrees(-76.72427638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193733"},
        {"Hipparcos Number", "HIP 101099"},
        {"Smithsonian Astrophysical Observation", "SAO 257811"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.40432843),
        dec: Angle.Degrees(-76.72257728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24579"},
        {"Hipparcos Number", "HIP 17624"},
        {"Smithsonian Astrophysical Observation", "SAO 256028"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.63966719),
        dec: Angle.Degrees(-76.71594956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124844"},
        {"Hipparcos Number", "HIP 70128"},
        {"Smithsonian Astrophysical Observation", "SAO 257141"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.24662255),
        dec: Angle.Degrees(-76.69949658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136273"},
        {"Hipparcos Number", "HIP 75603"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.69667972),
        dec: Angle.Degrees(-76.69059014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212748"},
        {"Hipparcos Number", "HIP 111096"},
        {"Geneva Identification System", "GEN# +1.00212748"},
        {"Smithsonian Astrophysical Observation", "SAO 258044"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.60296648),
        dec: Angle.Degrees(-76.68282721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168636"},
        {"Hipparcos Number", "HIP 90686"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.54801779),
        dec: Angle.Degrees(-76.67940734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38569"},
        {"Hipparcos Number", "HIP 26422"},
        {"Smithsonian Astrophysical Observation", "SAO 256218"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.35200662),
        dec: Angle.Degrees(-76.67582894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6971"},
        {"Hipparcos Number", "HIP 5274"},
        {"Geneva Identification System", "GEN# +1.00006971"},
        {"Smithsonian Astrophysical Observation", "SAO 255744"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.85460592),
        dec: Angle.Degrees(-76.67374483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88626"},
        {"Hipparcos Number", "HIP 49705"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.20643330),
        dec: Angle.Degrees(-76.67058136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60543"},
        {"Hipparcos Number", "HIP 36094"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.54119649),
        dec: Angle.Degrees(-76.66974992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165458"},
        {"Hipparcos Number", "HIP 89459"},
        {"Smithsonian Astrophysical Observation", "SAO 257573"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.85582696),
        dec: Angle.Degrees(-76.66677972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108297"},
        {"Hipparcos Number", "HIP 60782"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.87577263),
        dec: Angle.Degrees(-76.66516752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80194"},
        {"Hipparcos Number", "HIP 45166"},
        {"Fundamental Katalog 5th Edition", "FK5 2735"},
        {"Geneva Identification System", "GEN# +1.00080194"},
        {"Smithsonian Astrophysical Observation", "SAO 256594"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.05110817),
        dec: Angle.Degrees(-76.66292167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131109"},
        {"Hipparcos Number", "HIP 73223"},
        {"Fundamental Katalog 5th Edition", "FK5 3175"},
        {"Geneva Identification System", "GEN# +1.00131109"},
        {"Smithsonian Astrophysical Observation", "SAO 257212"},
        {"Wilson Evans Batten Catalogue", "WEB 12550"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.47148916),
        dec: Angle.Degrees(-76.66261622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113263"},
        {"Hipparcos Number", "HIP 63828"},
        {"Geneva Identification System", "GEN# +1.00113263"},
        {"Smithsonian Astrophysical Observation", "SAO 257007"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.22889679),
        dec: Angle.Degrees(-76.64940246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53710"},
        {"Hipparcos Number", "HIP 33418"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.24678733),
        dec: Angle.Degrees(-76.64323002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78552"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.56608928),
        dec: Angle.Degrees(-70.81245112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187998"},
        {"Hipparcos Number", "HIP 98568"},
        {"Smithsonian Astrophysical Observation", "SAO 257756"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.32016998),
        dec: Angle.Degrees(-76.64311793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69363"},
        {"Hipparcos Number", "HIP 39887"},
        {"Smithsonian Astrophysical Observation", "SAO 256481"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20558180),
        dec: Angle.Degrees(-76.63769578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105524"},
        {"Hipparcos Number", "HIP 59245"},
        {"Geneva Identification System", "GEN# +1.00105524"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.29675730),
        dec: Angle.Degrees(-76.63754124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94513"},
        {"Geneva Identification System", "GEN# -0.07601313"},
    },
    visualMagnitude: 10.22,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.54450847),
        dec: Angle.Degrees(-76.63723138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207814"},
        {"Hipparcos Number", "HIP 108323"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.17744521),
        dec: Angle.Degrees(-76.63137471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33563"},
        {"Hipparcos Number", "HIP 23413"},
        {"Geneva Identification System", "GEN# +1.00033563J"},
        {"Smithsonian Astrophysical Observation", "SAO 256155"},
        {"Wilson Evans Batten Catalogue", "WEB 4547"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.48467796),
        dec: Angle.Degrees(-76.62814281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13928"},
        {"Hipparcos Number", "HIP 10137"},
        {"Fundamental Katalog 5th Edition", "FK5 2154"},
        {"Geneva Identification System", "GEN# +1.00013928"},
        {"Smithsonian Astrophysical Observation", "SAO 255857"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.59972155),
        dec: Angle.Degrees(-76.62373019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10017"},
        {"Smithsonian Astrophysical Observation", "SAO 255854"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.24623120),
        dec: Angle.Degrees(-76.62100486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102506"},
        {"Hipparcos Number", "HIP 57505"},
        {"Geneva Identification System", "GEN# +1.00102506"},
        {"Smithsonian Astrophysical Observation", "SAO 256874"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.80962823),
        dec: Angle.Degrees(-76.61789661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141864"},
        {"Hipparcos Number", "HIP 78289"},
        {"Geneva Identification System", "GEN# +1.00141864"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.77508896),
        dec: Angle.Degrees(-76.61777392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15994"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.50698090),
        dec: Angle.Degrees(-76.61621408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190086"},
        {"Hipparcos Number", "HIP 99466"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.81758886),
        dec: Angle.Degrees(-76.61499951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36480"},
        {"Hipparcos Number", "HIP 25130"},
        {"Geneva Identification System", "GEN# +1.00036480"},
        {"Smithsonian Astrophysical Observation", "SAO 256185"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68133296),
        dec: Angle.Degrees(-76.61457889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65910"},
        {"Hipparcos Number", "HIP 38478"},
        {"Smithsonian Astrophysical Observation", "SAO 256457"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.21208589),
        dec: Angle.Degrees(-76.61377522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54557",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "CED 112 IRS 3"},
        {"Henry Draper", "HD 97300"},
        {"Hipparcos Number", "HIP 54557"},
        {"Geneva Identification System", "GEN# +1.00097300"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.45863838),
        dec: Angle.Degrees(-76.61325392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99418"},
        {"Hipparcos Number", "HIP 55704"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.21520690),
        dec: Angle.Degrees(-76.61183051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8813"},
        {"Hipparcos Number", "HIP 6494"},
        {"Geneva Identification System", "GEN# +1.00008813"},
        {"Smithsonian Astrophysical Observation", "SAO 255772"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.85673686),
        dec: Angle.Degrees(-76.61173200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19350",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19350"},
        {"Geneva Identification System", "GEN# -0.07600264"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.18021339),
        dec: Angle.Degrees(-76.60761940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72581"},
        {"Hipparcos Number", "HIP 41350"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.54693823),
        dec: Angle.Degrees(-76.60222440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160603"},
        {"Hipparcos Number", "HIP 87283"},
        {"Geneva Identification System", "GEN# +1.00160603"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.52257033),
        dec: Angle.Degrees(-76.60037504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174929"},
        {"Hipparcos Number", "HIP 93475"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.54402973),
        dec: Angle.Degrees(-76.59466586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4599"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.73132525),
        dec: Angle.Degrees(-76.58958196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165844"},
        {"Hipparcos Number", "HIP 89615"},
        {"Smithsonian Astrophysical Observation", "SAO 257576"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.31375585),
        dec: Angle.Degrees(-76.58365536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70974"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75515815),
        dec: Angle.Degrees(-76.58159506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93326"},
        {"Hipparcos Number", "HIP 52461"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.86656697),
        dec: Angle.Degrees(-76.58072578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116891"},
        {"Hipparcos Number", "HIP 65865"},
        {"Geneva Identification System", "GEN# +1.00116891"},
        {"Smithsonian Astrophysical Observation", "SAO 257053"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.50282690),
        dec: Angle.Degrees(-76.57323354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65873"},
    },
    visualMagnitude: 9.14,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.53156397),
        dec: Angle.Degrees(-76.56693194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79175"},
        {"Hipparcos Number", "HIP 44669"},
        {"Smithsonian Astrophysical Observation", "SAO 256587"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.54414681),
        dec: Angle.Degrees(-76.56657049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5811"},
        {"Hipparcos Number", "HIP 4479"},
        {"Fundamental Katalog 5th Edition", "FK5 4086"},
        {"Geneva Identification System", "GEN# +1.00005811"},
        {"Smithsonian Astrophysical Observation", "SAO 255724"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.33937415),
        dec: Angle.Degrees(-76.55397974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196227"},
        {"Hipparcos Number", "HIP 102259"},
        {"Geneva Identification System", "GEN# +1.00196227"},
        {"Smithsonian Astrophysical Observation", "SAO 257842"},
        {"Wilson Evans Batten Catalogue", "WEB 18503"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.80724910),
        dec: Angle.Degrees(-76.54706336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40296"},
        {"Hipparcos Number", "HIP 27430"},
        {"Smithsonian Astrophysical Observation", "SAO 256243"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.12654721),
        dec: Angle.Degrees(-76.54335447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132812"},
        {"Hipparcos Number", "HIP 74021"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.90915671),
        dec: Angle.Degrees(-76.54285008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29155"},
        {"Hipparcos Number", "HIP 20755"},
        {"Geneva Identification System", "GEN# +1.00029155"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.71122566),
        dec: Angle.Degrees(-76.53456876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202919"},
        {"Hipparcos Number", "HIP 105746"},
        {"Geneva Identification System", "GEN# +1.00202919"},
        {"Smithsonian Astrophysical Observation", "SAO 257917"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27039914),
        dec: Angle.Degrees(-76.52580621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135961"},
        {"Hipparcos Number", "HIP 75467"},
        {"Smithsonian Astrophysical Observation", "SAO 257271"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.25017809),
        dec: Angle.Degrees(-76.52457856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125782"},
        {"Hipparcos Number", "HIP 70637"},
        {"Geneva Identification System", "GEN# +1.00125782"},
        {"Smithsonian Astrophysical Observation", "SAO 257154"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.73214093),
        dec: Angle.Degrees(-76.51939462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104902"},
        {"Hipparcos Number", "HIP 58905"},
        {"Geneva Identification System", "GEN# +1.00104902"},
        {"Smithsonian Astrophysical Observation", "SAO 256899"},
        {"Wilson Evans Batten Catalogue", "WEB 10490"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19443206),
        dec: Angle.Degrees(-76.51917475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204888"},
        {"Hipparcos Number", "HIP 106734"},
        {"Smithsonian Astrophysical Observation", "SAO 257939"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.31910430),
        dec: Angle.Degrees(-76.51622763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49321"},
        {"Hipparcos Number", "HIP 31779"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.67398509),
        dec: Angle.Degrees(-76.51412810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25797"},
        {"Hipparcos Number", "HIP 18493"},
        {"Geneva Identification System", "GEN# +1.00025797"},
        {"Smithsonian Astrophysical Observation", "SAO 256050"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.30184606),
        dec: Angle.Degrees(-76.51090382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147802"},
        {"Hipparcos Number", "HIP 80984"},
        {"Geneva Identification System", "GEN# +1.00147802"},
        {"Smithsonian Astrophysical Observation", "SAO 257406"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.07703479),
        dec: Angle.Degrees(-76.51017438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79623"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72333503),
        dec: Angle.Degrees(-76.50900905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117910"},
        {"Hipparcos Number", "HIP 66416"},
        {"Geneva Identification System", "GEN# +1.00117910"},
        {"Smithsonian Astrophysical Observation", "SAO 257067"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.24327683),
        dec: Angle.Degrees(-76.50844774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170506"},
        {"Hipparcos Number", "HIP 91439"},
        {"Geneva Identification System", "GEN# +1.00170506"},
        {"Smithsonian Astrophysical Observation", "SAO 257609"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.72249876),
        dec: Angle.Degrees(-76.49922613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211225"},
        {"Hipparcos Number", "HIP 110248"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.97549184),
        dec: Angle.Degrees(-76.49482129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140589"},
        {"Hipparcos Number", "HIP 77717"},
        {"Renson", "Renson 39950"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.00116410),
        dec: Angle.Degrees(-76.49342794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146042"},
        {"Hipparcos Number", "HIP 80201"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.59324196),
        dec: Angle.Degrees(-76.47608466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24687"},
        {"Hipparcos Number", "HIP 17711"},
        {"Smithsonian Astrophysical Observation", "SAO 256033"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.90391198),
        dec: Angle.Degrees(-76.47095288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17654"},
        {"Hipparcos Number", "HIP 12747"},
        {"Smithsonian Astrophysical Observation", "SAO 255916"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.96679501),
        dec: Angle.Degrees(-76.46983078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218524"},
        {"Hipparcos Number", "HIP 114451"},
        {"Smithsonian Astrophysical Observation", "SAO 258110"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.69102265),
        dec: Angle.Degrees(-76.46324550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123781"},
        {"Hipparcos Number", "HIP 69576"},
        {"Smithsonian Astrophysical Observation", "SAO 257126"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62665220),
        dec: Angle.Degrees(-76.45773849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90926"},
        {"Hipparcos Number", "HIP 51074"},
        {"Geneva Identification System", "GEN# +1.00090926"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.53630767),
        dec: Angle.Degrees(-76.45225029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130172"},
        {"Hipparcos Number", "HIP 72786"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16685042),
        dec: Angle.Degrees(-76.45202140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34378"},
        {"Hipparcos Number", "HIP 23876"},
        {"Smithsonian Astrophysical Observation", "SAO 256163"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.96527289),
        dec: Angle.Degrees(-76.43996053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42348"},
        {"Hipparcos Number", "HIP 28490"},
        {"Smithsonian Astrophysical Observation", "SAO 256262"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.21366365),
        dec: Angle.Degrees(-76.43636123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71985"},
        {"Hipparcos Number", "HIP 41079"},
        {"Smithsonian Astrophysical Observation", "SAO 256508"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.72445678),
        dec: Angle.Degrees(-76.43547390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71972"},
        {"Hipparcos Number", "HIP 41070"},
        {"Smithsonian Astrophysical Observation", "SAO 256507"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.70072407),
        dec: Angle.Degrees(-76.43086861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70896"},
        {"Hipparcos Number", "HIP 40555"},
        {"Geneva Identification System", "GEN# +1.00070896"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.21994975),
        dec: Angle.Degrees(-76.42675837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24651"},
        {"Hipparcos Number", "HIP 17690"},
        {"Geneva Identification System", "GEN# +1.00024651"},
        {"Smithsonian Astrophysical Observation", "SAO 256031"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.83559617),
        dec: Angle.Degrees(-76.42172663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115440"},
        {"Hipparcos Number", "HIP 65053"},
        {"Geneva Identification System", "GEN# +1.00115440"},
        {"Renson", "Renson 33340"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.01889398),
        dec: Angle.Degrees(-76.41919058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151665"},
        {"Hipparcos Number", "HIP 82982"},
        {"Renson", "Renson 42926"},
        {"Smithsonian Astrophysical Observation", "SAO 257445"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.36654871),
        dec: Angle.Degrees(-76.41823132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58943"},
        {"Hipparcos Number", "HIP 35445"},
        {"Geneva Identification System", "GEN# +1.00058943"},
        {"Smithsonian Astrophysical Observation", "SAO 256398"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.77006670),
        dec: Angle.Degrees(-76.41724171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 142.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185853"},
        {"Hipparcos Number", "HIP 97544"},
        {"Smithsonian Astrophysical Observation", "SAO 257732"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.38768482),
        dec: Angle.Degrees(-76.40473849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176794"},
        {"Hipparcos Number", "HIP 94208"},
        {"Smithsonian Astrophysical Observation", "SAO 257661"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.68658673),
        dec: Angle.Degrees(-76.40436836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77513"},
        {"Hipparcos Number", "HIP 43888"},
        {"Geneva Identification System", "GEN# +1.00077513"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10385073),
        dec: Angle.Degrees(-76.39078241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152261"},
        {"Hipparcos Number", "HIP 83273"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.28259122),
        dec: Angle.Degrees(-76.38922409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10272"},
        {"Hipparcos Number", "HIP 7496"},
        {"Smithsonian Astrophysical Observation", "SAO 255797"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.14068586),
        dec: Angle.Degrees(-76.37198231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180737"},
        {"Hipparcos Number", "HIP 95569"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.59249433),
        dec: Angle.Degrees(-76.36713683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43313"},
        {"Hipparcos Number", "HIP 28927"},
        {"Smithsonian Astrophysical Observation", "SAO 256271"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.58755756),
        dec: Angle.Degrees(-76.36045600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14401"},
        {"Hipparcos Number", "HIP 10422"},
        {"Geneva Identification System", "GEN# +1.00014401"},
        {"Smithsonian Astrophysical Observation", "SAO 255864"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.57885564),
        dec: Angle.Degrees(-76.35758436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147696"},
        {"Hipparcos Number", "HIP 80944"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.91763258),
        dec: Angle.Degrees(-76.35546678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223614"},
        {"Hipparcos Number", "HIP 117642"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.87980129),
        dec: Angle.Degrees(-76.35289554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155858"},
        {"Hipparcos Number", "HIP 85067"},
        {"Smithsonian Astrophysical Observation", "SAO 257490"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.77592585),
        dec: Angle.Degrees(-76.35138202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215671"},
        {"Hipparcos Number", "HIP 112732"},
        {"Smithsonian Astrophysical Observation", "SAO 258071"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.44643676),
        dec: Angle.Degrees(-76.34982342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225235"},
        {"Hipparcos Number", "HIP 358"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.13935928),
        dec: Angle.Degrees(-76.34653399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37763"},
        {"Hipparcos Number", "HIP 25918"},
        {"Fundamental Katalog 5th Edition", "FK5 214"},
        {"Geneva Identification System", "GEN# +1.00037763"},
        {"Smithsonian Astrophysical Observation", "SAO 256201"},
        {"Wilson Evans Batten Catalogue", "WEB 5038"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.96942437),
        dec: Angle.Degrees(-76.34166340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 287.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9200"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60329285),
        dec: Angle.Degrees(-76.33981418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19099"},
        {"Hipparcos Number", "HIP 13808"},
        {"Geneva Identification System", "GEN# +1.00019099"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.44496553),
        dec: Angle.Degrees(-76.33016793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221007"},
        {"Hipparcos Number", "HIP 115967"},
        {"Smithsonian Astrophysical Observation", "SAO 258148"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.43734565),
        dec: Angle.Degrees(-76.32503070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200176"},
        {"Hipparcos Number", "HIP 104346"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.08235275),
        dec: Angle.Degrees(-76.31728239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2420"},
        {"Hipparcos Number", "HIP 2126"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.73967133),
        dec: Angle.Degrees(-76.31520622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3528"},
        {"Hipparcos Number", "HIP 2907"},
        {"Geneva Identification System", "GEN# +1.00003528"},
        {"Smithsonian Astrophysical Observation", "SAO 255687"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.20682003),
        dec: Angle.Degrees(-76.30957103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92209"},
        {"Hipparcos Number", "HIP 51835"},
        {"Fundamental Katalog 5th Edition", "FK5 2847"},
        {"Geneva Identification System", "GEN# +1.00092209"},
        {"Smithsonian Astrophysical Observation", "SAO 256730"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.85334697),
        dec: Angle.Degrees(-76.30900474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31081"},
        {"Hipparcos Number", "HIP 22022"},
        {"Geneva Identification System", "GEN# +1.00031081"},
        {"Smithsonian Astrophysical Observation", "SAO 256124"},
        {"Wilson Evans Batten Catalogue", "WEB 4232"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.01969616),
        dec: Angle.Degrees(-76.30574677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31290"},
        {"Hipparcos Number", "HIP 22126"},
        {"Geneva Identification System", "GEN# +1.00031290"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.42239525),
        dec: Angle.Degrees(-76.30460630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100401"},
        {"Hipparcos Number", "HIP 56258"},
        {"Geneva Identification System", "GEN# +1.00100401"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.98032725),
        dec: Angle.Degrees(-76.30313999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72999"},
        {"Hipparcos Number", "HIP 41580"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.16860111),
        dec: Angle.Degrees(-76.29570789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62828"},
        {"Hipparcos Number", "HIP 37114"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.39061711),
        dec: Angle.Degrees(-76.29407599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133838"},
        {"Hipparcos Number", "HIP 74476"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.27266351),
        dec: Angle.Degrees(-76.28891884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62007"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.63016813),
        dec: Angle.Degrees(-76.28340477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80886"},
        {"Hipparcos Number", "HIP 45499"},
        {"Renson", "Renson 22950"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.07028803),
        dec: Angle.Degrees(-76.27769126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126595"},
        {"Hipparcos Number", "HIP 71055"},
        {"Smithsonian Astrophysical Observation", "SAO 257167"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.95882480),
        dec: Angle.Degrees(-76.27394773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120744"},
        {"Hipparcos Number", "HIP 67986"},
        {"Geneva Identification System", "GEN# +1.00120744"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.83852359),
        dec: Angle.Degrees(-76.27065822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143265"},
        {"Hipparcos Number", "HIP 78962"},
        {"Smithsonian Astrophysical Observation", "SAO 257358"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.80085770),
        dec: Angle.Degrees(-76.25589670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43958"},
        {"Hipparcos Number", "HIP 29245"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.48995477),
        dec: Angle.Degrees(-76.25562762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57787"},
        {"Geneva Identification System", "GEN# -0.07001436"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.74901506),
        dec: Angle.Degrees(-70.81224832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37513"},
        {"Hipparcos Number", "HIP 25760"},
        {"Geneva Identification System", "GEN# +1.00037513"},
        {"Wilson Evans Batten Catalogue", "WEB 5002"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51291305),
        dec: Angle.Degrees(-76.24872709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77425"},
        {"Hipparcos Number", "HIP 43845"},
        {"Geneva Identification System", "GEN# +1.00077425"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.96063025),
        dec: Angle.Degrees(-76.24854440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10739"},
        {"Hipparcos Number", "HIP 7853"},
        {"Smithsonian Astrophysical Observation", "SAO 255803"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.24748649),
        dec: Angle.Degrees(-76.24292264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195086"},
        {"Hipparcos Number", "HIP 101662"},
        {"Smithsonian Astrophysical Observation", "SAO 257824"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10511972),
        dec: Angle.Degrees(-76.23839252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94146"},
        {"Hipparcos Number", "HIP 52901"},
        {"Geneva Identification System", "GEN# +1.00094146"},
        {"Smithsonian Astrophysical Observation", "SAO 256758"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.29229777),
        dec: Angle.Degrees(-76.23729154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188012"},
        {"Hipparcos Number", "HIP 98540"},
        {"Smithsonian Astrophysical Observation", "SAO 257755"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.27071425),
        dec: Angle.Degrees(-76.23218097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153298"},
        {"Hipparcos Number", "HIP 83774"},
        {"Smithsonian Astrophysical Observation", "SAO 257460"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.82815044),
        dec: Angle.Degrees(-76.22379359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152260"},
        {"Hipparcos Number", "HIP 83247"},
        {"Fundamental Katalog 5th Edition", "FK5 1443"},
        {"Geneva Identification System", "GEN# +1.00152260"},
        {"Smithsonian Astrophysical Observation", "SAO 257449"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.22803798),
        dec: Angle.Degrees(-76.21833458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67537"},
        {"Hipparcos Number", "HIP 39163"},
        {"Smithsonian Astrophysical Observation", "SAO 256465"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.14745800),
        dec: Angle.Degrees(-76.21367176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200266"},
        {"Hipparcos Number", "HIP 104385"},
        {"Geneva Identification System", "GEN# +1.00200266"},
        {"Smithsonian Astrophysical Observation", "SAO 257887"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.19869846),
        dec: Angle.Degrees(-76.21242690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207883"},
        {"Hipparcos Number", "HIP 108354"},
        {"Smithsonian Astrophysical Observation", "SAO 257983"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.27115112),
        dec: Angle.Degrees(-76.21137258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207000"},
        {"Hipparcos Number", "HIP 107847"},
        {"Smithsonian Astrophysical Observation", "SAO 257964"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.75197415),
        dec: Angle.Degrees(-76.20648962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160580"},
        {"Hipparcos Number", "HIP 87258"},
        {"Fundamental Katalog 5th Edition", "FK5 5567"},
        {"Smithsonian Astrophysical Observation", "SAO 257527"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.44979075),
        dec: Angle.Degrees(-76.20185382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47646"},
        {"Hipparcos Number", "HIP 31025"},
        {"Smithsonian Astrophysical Observation", "SAO 256313"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.65268295),
        dec: Angle.Degrees(-76.20126809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44899"},
        {"Hipparcos Number", "HIP 29695"},
        {"Geneva Identification System", "GEN# +1.00044899"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.84324872),
        dec: Angle.Degrees(-76.20054202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9595"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85657940),
        dec: Angle.Degrees(-76.19871057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17915"},
        {"Hipparcos Number", "HIP 12949"},
        {"Smithsonian Astrophysical Observation", "SAO 255921"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.63371279),
        dec: Angle.Degrees(-76.19360020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57224"},
        {"Hipparcos Number", "HIP 34748"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.90947373),
        dec: Angle.Degrees(-76.19153169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156125"},
        {"Hipparcos Number", "HIP 85184"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.12163396),
        dec: Angle.Degrees(-76.18513286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113692"},
        {"Hipparcos Number", "HIP 64080"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.97820188),
        dec: Angle.Degrees(-76.18266751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196051"},
        {"Hipparcos Number", "HIP 102162"},
        {"Fundamental Katalog 5th Edition", "FK5 3650"},
        {"Geneva Identification System", "GEN# +1.00196051"},
        {"Smithsonian Astrophysical Observation", "SAO 257838"},
        {"Wilson Evans Batten Catalogue", "WEB 18483"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.51050472),
        dec: Angle.Degrees(-76.18056892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186503"},
        {"Hipparcos Number", "HIP 97838"},
        {"Geneva Identification System", "GEN# +1.00186503"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.22115609),
        dec: Angle.Degrees(-76.17939110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161988"},
        {"Hipparcos Number", "HIP 87926"},
        {"Geneva Identification System", "GEN# +1.00161988"},
        {"Smithsonian Astrophysical Observation", "SAO 257542"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.42367575),
        dec: Angle.Degrees(-76.17794609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19473"},
        {"Hipparcos Number", "HIP 14059"},
        {"Smithsonian Astrophysical Observation", "SAO 255944"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.28543242),
        dec: Angle.Degrees(-76.16885685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70310"},
        {"Hipparcos Number", "HIP 40292"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.42273103),
        dec: Angle.Degrees(-76.16693956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74439"},
        {"Hipparcos Number", "HIP 42270"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.28701601),
        dec: Angle.Degrees(-76.16401822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85687"},
        {"Hipparcos Number", "HIP 48114"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14703978),
        dec: Angle.Degrees(-76.16249241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102797"},
        {"Hipparcos Number", "HIP 57661"},
        {"Geneva Identification System", "GEN# +1.00102797"},
        {"Renson", "Renson 29660"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.37751800),
        dec: Angle.Degrees(-76.15875088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171796"},
        {"Hipparcos Number", "HIP 92045"},
        {"Renson", "Renson 48140"},
        {"Smithsonian Astrophysical Observation", "SAO 257623"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.41980381),
        dec: Angle.Degrees(-76.15422311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140765"},
        {"Hipparcos Number", "HIP 77776"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.22328513),
        dec: Angle.Degrees(-76.14914731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8316"},
        {"Hipparcos Number", "HIP 6184"},
        {"Geneva Identification System", "GEN# +1.00008316"},
        {"Smithsonian Astrophysical Observation", "SAO 255764"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.83675088),
        dec: Angle.Degrees(-76.14903071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180121"},
        {"Hipparcos Number", "HIP 95338"},
        {"Smithsonian Astrophysical Observation", "SAO 257681"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.94121586),
        dec: Angle.Degrees(-76.14854469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34633"},
        {"Hipparcos Number", "HIP 24054"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53546803),
        dec: Angle.Degrees(-76.13959546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98713"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)02, 59.8900),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)07, 59.100)
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
    primaryId: "HIP 54257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96675"},
        {"Hipparcos Number", "HIP 54257"},
        {"Geneva Identification System", "GEN# +1.00096675"},
        {"Smithsonian Astrophysical Observation", "SAO 256798"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.49110316),
        dec: Angle.Degrees(-76.13024802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82700"},
        {"Hipparcos Number", "HIP 46414"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.97797285),
        dec: Angle.Degrees(-76.12917617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -300.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191803"},
        {"Hipparcos Number", "HIP 100187"},
        {"Geneva Identification System", "GEN# +1.00191803"},
        {"Smithsonian Astrophysical Observation", "SAO 257790"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.82993187),
        dec: Angle.Degrees(-76.12645968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211241"},
        {"Hipparcos Number", "HIP 110237"},
        {"Smithsonian Astrophysical Observation", "SAO 258023"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.95049682),
        dec: Angle.Degrees(-76.12210299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208741"},
        {"Hipparcos Number", "HIP 108849"},
        {"Fundamental Katalog 5th Edition", "FK5 3760"},
        {"Geneva Identification System", "GEN# +1.00208741"},
        {"Smithsonian Astrophysical Observation", "SAO 257993"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.76559241),
        dec: Angle.Degrees(-76.11826634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210056"},
        {"Hipparcos Number", "HIP 109584"},
        {"Geneva Identification System", "GEN# +1.00210056"},
        {"Smithsonian Astrophysical Observation", "SAO 258006"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.97970309),
        dec: Angle.Degrees(-76.11592445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175304"},
        {"Hipparcos Number", "HIP 93572"},
        {"Smithsonian Astrophysical Observation", "SAO 257648"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.87132213),
        dec: Angle.Degrees(-76.11523155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163786"},
        {"Hipparcos Number", "HIP 88742"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.74680237),
        dec: Angle.Degrees(-76.11245707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29947"},
        {"Hipparcos Number", "HIP 21331"},
        {"Smithsonian Astrophysical Observation", "SAO 256108"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.67349990),
        dec: Angle.Degrees(-76.11192305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222261"},
        {"Hipparcos Number", "HIP 116769"},
        {"Smithsonian Astrophysical Observation", "SAO 258168"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.98057796),
        dec: Angle.Degrees(-76.11190544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97474"},
        {"Hipparcos Number", "HIP 54627"},
        {"Smithsonian Astrophysical Observation", "SAO 256806"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.71812527),
        dec: Angle.Degrees(-76.11092202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14049"},
        {"Hipparcos Number", "HIP 10229"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.88220235),
        dec: Angle.Degrees(-76.10765532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220431"},
        {"Hipparcos Number", "HIP 115609"},
        {"Smithsonian Astrophysical Observation", "SAO 258137"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.29574007),
        dec: Angle.Degrees(-76.10478663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84155"},
        {"Smithsonian Astrophysical Observation", "SAO 257471"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08187024),
        dec: Angle.Degrees(-76.10357550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40157"},
        {"Hipparcos Number", "HIP 27403"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04613170),
        dec: Angle.Degrees(-76.10298188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11646"},
        {"Hipparcos Number", "HIP 8530"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.50082643),
        dec: Angle.Degrees(-76.09096455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41427"},
        {"Hipparcos Number", "HIP 28070"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.02207835),
        dec: Angle.Degrees(-76.08878006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 189.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124317"},
        {"Hipparcos Number", "HIP 69850"},
        {"Fundamental Katalog 5th Edition", "FK5 5264"},
        {"Geneva Identification System", "GEN# +1.00124317"},
        {"Smithsonian Astrophysical Observation", "SAO 257133"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.43033626),
        dec: Angle.Degrees(-76.08828110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183701"},
        {"Hipparcos Number", "HIP 96658"},
        {"Smithsonian Astrophysical Observation", "SAO 257712"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.77588156),
        dec: Angle.Degrees(-76.08476330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138867"},
        {"Hipparcos Number", "HIP 76877"},
        {"Fundamental Katalog 5th Edition", "FK5 3235"},
        {"Geneva Identification System", "GEN# +1.00138867"},
        {"Smithsonian Astrophysical Observation", "SAO 257310"},
    },
    visualMagnitude: 5.95,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.47793121),
        dec: Angle.Degrees(-76.08186451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89081"},
        {"Hipparcos Number", "HIP 50002"},
        {"Geneva Identification System", "GEN# +1.00089081"},
        {"Renson", "Renson 25520"},
        {"Smithsonian Astrophysical Observation", "SAO 256689"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11911828),
        dec: Angle.Degrees(-76.07746582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39150"},
        {"Hipparcos Number", "HIP 26813"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.40211351),
        dec: Angle.Degrees(-76.07305701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122528"},
        {"Hipparcos Number", "HIP 68954"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.72733827),
        dec: Angle.Degrees(-76.07210961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165757"},
        {"Hipparcos Number", "HIP 89559"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.12049268),
        dec: Angle.Degrees(-76.07152165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87954"},
        {"Hipparcos Number", "HIP 49325"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.02874957),
        dec: Angle.Degrees(-76.07148658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87923"},
        {"Hipparcos Number", "HIP 49313"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.98473998),
        dec: Angle.Degrees(-76.06808385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109813"},
        {"Hipparcos Number", "HIP 61709"},
        {"Fundamental Katalog 5th Edition", "FK5 3008"},
        {"Smithsonian Astrophysical Observation", "SAO 256965"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.72814009),
        dec: Angle.Degrees(-76.06591273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83869"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.11116407),
        dec: Angle.Degrees(-76.05936509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160819"},
        {"Hipparcos Number", "HIP 87350"},
        {"Smithsonian Astrophysical Observation", "SAO 257531"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.73119845),
        dec: Angle.Degrees(-76.05825482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56241"},
        {"Hipparcos Number", "HIP 34381"},
        {"Fundamental Katalog 5th Edition", "FK5 4644"},
        {"Smithsonian Astrophysical Observation", "SAO 256375"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.92776810),
        dec: Angle.Degrees(-76.04916169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209988"},
        {"Hipparcos Number", "HIP 109559"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.88196337),
        dec: Angle.Degrees(-76.04607492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108039"},
        {"Hipparcos Number", "HIP 60624"},
        {"Geneva Identification System", "GEN# +1.00108039"},
        {"Smithsonian Astrophysical Observation", "SAO 256941"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.37283849),
        dec: Angle.Degrees(-76.04161131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91873"},
        {"Hipparcos Number", "HIP 51640"},
        {"Fundamental Katalog 5th Edition", "FK5 4935"},
        {"Smithsonian Astrophysical Observation", "SAO 256728"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.26777049),
        dec: Angle.Degrees(-76.03903121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213386"},
        {"Hipparcos Number", "HIP 111427"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.61875544),
        dec: Angle.Degrees(-76.03867133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111432",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 9.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34, 30.9200),
        dec: Angle.DegreesMinutesSeconds((int)-76, (int)02, 13.100)
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
    primaryId: "HIP 58490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58490"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.92653982),
        dec: Angle.Degrees(-76.02392376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106247"},
        {"Hipparcos Number", "HIP 59645"},
        {"Geneva Identification System", "GEN# +1.00106247"},
        {"Smithsonian Astrophysical Observation", "SAO 256916"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.47619139),
        dec: Angle.Degrees(-76.02195539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10581"},
        {"Hipparcos Number", "HIP 7717"},
        {"Smithsonian Astrophysical Observation", "SAO 255799"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.83591022),
        dec: Angle.Degrees(-76.02079608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198653"},
        {"Hipparcos Number", "HIP 103518"},
        {"Smithsonian Astrophysical Observation", "SAO 257867"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.58075421),
        dec: Angle.Degrees(-76.01906111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38180"},
    },
    visualMagnitude: 11.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.36222436),
        dec: Angle.Degrees(-76.01168198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99161"},
        {"Hipparcos Number", "HIP 55578"},
        {"Geneva Identification System", "GEN# +1.00099161"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.77885584),
        dec: Angle.Degrees(-76.00751275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1992"},
        {"Hipparcos Number", "HIP 1835"},
        {"Smithsonian Astrophysical Observation", "SAO 255666"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.81060220),
        dec: Angle.Degrees(-76.00460522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11823"},
        {"Hipparcos Number", "HIP 8686"},
        {"Smithsonian Astrophysical Observation", "SAO 255826"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.93749644),
        dec: Angle.Degrees(-75.99177045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152444"},
        {"Hipparcos Number", "HIP 83324"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.44796955),
        dec: Angle.Degrees(-75.99078765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72344",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72344"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.90161085),
        dec: Angle.Degrees(-75.98384222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129306"},
        {"Hipparcos Number", "HIP 72341"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88954133),
        dec: Angle.Degrees(-75.98227370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200220"},
        {"Hipparcos Number", "HIP 104349"},
        {"Smithsonian Astrophysical Observation", "SAO 257885"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.09944224),
        dec: Angle.Degrees(-75.98006326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146190"},
        {"Hipparcos Number", "HIP 80241"},
        {"Smithsonian Astrophysical Observation", "SAO 257390"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.72568178),
        dec: Angle.Degrees(-75.97464258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7938"},
        {"Hipparcos Number", "HIP 5910"},
        {"Smithsonian Astrophysical Observation", "SAO 255757"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.99841286),
        dec: Angle.Degrees(-75.96417412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13951"},
        {"Hipparcos Number", "HIP 10179"},
        {"Geneva Identification System", "GEN# +1.00013951"},
        {"Smithsonian Astrophysical Observation", "SAO 255858"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72250726),
        dec: Angle.Degrees(-75.95883110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147979"},
        {"Hipparcos Number", "HIP 81042"},
        {"Renson", "Renson 41780"},
        {"Smithsonian Astrophysical Observation", "SAO 257408"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.28582588),
        dec: Angle.Degrees(-75.94993409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136215"},
        {"Hipparcos Number", "HIP 75551"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.51824471),
        dec: Angle.Degrees(-75.94647043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99759"},
        {"Hipparcos Number", "HIP 55886"},
        {"Geneva Identification System", "GEN# +1.00099759"},
        {"Smithsonian Astrophysical Observation", "SAO 256841"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.81741936),
        dec: Angle.Degrees(-75.93395866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116009"},
        {"Hipparcos Number", "HIP 65374"},
        {"Geneva Identification System", "GEN# +1.00116009"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.97016479),
        dec: Angle.Degrees(-75.93038969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136543"},
        {"Hipparcos Number", "HIP 75707"},
        {"Geneva Identification System", "GEN# +1.00136543"},
    },
    visualMagnitude: 8.39,
    bvColour: 3.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00425364),
        dec: Angle.Degrees(-75.92959652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84799"},
        {"Hipparcos Number", "HIP 47615"},
        {"Smithsonian Astrophysical Observation", "SAO 256648"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.64061448),
        dec: Angle.Degrees(-75.92596172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59154"},
    },
    visualMagnitude: 10.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)07, 52.3000),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)55, 15.500)
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
    primaryId: "HIP 3561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4533"},
        {"Hipparcos Number", "HIP 3561"},
        {"Geneva Identification System", "GEN# +1.00004533"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.38428945),
        dec: Angle.Degrees(-75.91851260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36192"},
        {"Hipparcos Number", "HIP 25003"},
        {"Fundamental Katalog 5th Edition", "FK5 4488"},
        {"Geneva Identification System", "GEN# +1.00036192"},
        {"Smithsonian Astrophysical Observation", "SAO 256179"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.30483874),
        dec: Angle.Degrees(-75.91733968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1221"},
        {"Hipparcos Number", "HIP 1268"},
        {"Geneva Identification System", "GEN# +1.00001221"},
        {"Smithsonian Astrophysical Observation", "SAO 255650"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.97890167),
        dec: Angle.Degrees(-75.91160944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197388"},
        {"Hipparcos Number", "HIP 102842"},
        {"Smithsonian Astrophysical Observation", "SAO 257855"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.51802514),
        dec: Angle.Degrees(-75.91013404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85127"},
        {"Hipparcos Number", "HIP 47810"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.19412454),
        dec: Angle.Degrees(-75.89922186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218341"},
        {"Hipparcos Number", "HIP 114324"},
        {"Smithsonian Astrophysical Observation", "SAO 258108"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.30011095),
        dec: Angle.Degrees(-75.89787937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125903"},
        {"Hipparcos Number", "HIP 70679"},
        {"Renson", "Renson 35930"},
        {"Smithsonian Astrophysical Observation", "SAO 257156"},
    },
    visualMagnitude: 9.42,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.85174461),
        dec: Angle.Degrees(-75.89675665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101132"},
        {"Hipparcos Number", "HIP 56675"},
        {"Fundamental Katalog 5th Edition", "FK5 438"},
        {"Geneva Identification System", "GEN# +1.00101132"},
        {"Smithsonian Astrophysical Observation", "SAO 256857"},
        {"Wilson Evans Batten Catalogue", "WEB 10189"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.31642653),
        dec: Angle.Degrees(-75.89654092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75854"},
        {"Hipparcos Number", "HIP 43008"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.47303179),
        dec: Angle.Degrees(-75.89610020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24940"},
        {"Hipparcos Number", "HIP 17955"},
        {"Geneva Identification System", "GEN# +1.00024940"},
        {"Smithsonian Astrophysical Observation", "SAO 256038"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.57908812),
        dec: Angle.Degrees(-75.89561098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16493"},
        {"Hipparcos Number", "HIP 11886"},
        {"Geneva Identification System", "GEN# +1.00016493"},
        {"Smithsonian Astrophysical Observation", "SAO 255904"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.31800133),
        dec: Angle.Degrees(-75.89357401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164712"},
        {"Hipparcos Number", "HIP 89115"},
        {"Fundamental Katalog 5th Edition", "FK5 678"},
        {"Geneva Identification System", "GEN# +1.00164712"},
        {"Smithsonian Astrophysical Observation", "SAO 257569"},
        {"Wilson Evans Batten Catalogue", "WEB 15132"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.81567436),
        dec: Angle.Degrees(-75.89079431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171885"},
        {"Hipparcos Number", "HIP 92065"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.47124042),
        dec: Angle.Degrees(-75.88740537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94454"},
        {"Hipparcos Number", "HIP 53074"},
        {"Geneva Identification System", "GEN# +1.00094454"},
        {"Smithsonian Astrophysical Observation", "SAO 256765"},
        {"Wilson Evans Batten Catalogue", "WEB 9646"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.87625862),
        dec: Angle.Degrees(-75.88276828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209855"},
        {"Hipparcos Number", "HIP 109477"},
        {"Geneva Identification System", "GEN# +1.00209855"},
        {"Smithsonian Astrophysical Observation", "SAO 258003"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.67638566),
        dec: Angle.Degrees(-75.88135084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125621"},
        {"Hipparcos Number", "HIP 70524"},
        {"Smithsonian Astrophysical Observation", "SAO 257150"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.38986602),
        dec: Angle.Degrees(-75.88096704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190766"},
        {"Hipparcos Number", "HIP 99716"},
        {"Geneva Identification System", "GEN# +1.00190766"},
        {"Renson", "Renson 53050"},
        {"Smithsonian Astrophysical Observation", "SAO 257782"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.51278312),
        dec: Angle.Degrees(-75.86786596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58046"},
        {"Hipparcos Number", "HIP 35102"},
        {"Smithsonian Astrophysical Observation", "SAO 256388"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87838949),
        dec: Angle.Degrees(-75.86509595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26951"},
        {"Hipparcos Number", "HIP 19258"},
        {"Geneva Identification System", "GEN# +1.00026951"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.92034945),
        dec: Angle.Degrees(-75.86208310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10478"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.77927063),
        dec: Angle.Degrees(-75.86083415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173905"},
        {"Hipparcos Number", "HIP 92970"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.10784154),
        dec: Angle.Degrees(-75.84825608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202141"},
        {"Hipparcos Number", "HIP 105313"},
        {"Smithsonian Astrophysical Observation", "SAO 257909"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.94518011),
        dec: Angle.Degrees(-75.84598265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197325"},
        {"Hipparcos Number", "HIP 102808"},
        {"Smithsonian Astrophysical Observation", "SAO 257853"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.41480814),
        dec: Angle.Degrees(-75.83336511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39248"},
        {"Hipparcos Number", "HIP 26869"},
        {"Geneva Identification System", "GEN# +1.00039248"},
        {"Smithsonian Astrophysical Observation", "SAO 256226"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.56610660),
        dec: Angle.Degrees(-75.83123263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179214"},
        {"Hipparcos Number", "HIP 95023"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.01590338),
        dec: Angle.Degrees(-75.82947767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98627"},
        {"Hipparcos Number", "HIP 55257"},
        {"Smithsonian Astrophysical Observation", "SAO 256824"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.76587526),
        dec: Angle.Degrees(-75.82488022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128544"},
        {"Hipparcos Number", "HIP 71944"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.71811422),
        dec: Angle.Degrees(-75.82452984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173509"},
        {"Hipparcos Number", "HIP 92773"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.56546931),
        dec: Angle.Degrees(-75.81741557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11601"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.39371505),
        dec: Angle.Degrees(-75.81643149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6058"},
        {"Hipparcos Number", "HIP 4638"},
        {"Smithsonian Astrophysical Observation", "SAO 255726"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.89143888),
        dec: Angle.Degrees(-75.81460259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6072"},
        {"Hipparcos Number", "HIP 4646"},
        {"Smithsonian Astrophysical Observation", "SAO 255727"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.92125454),
        dec: Angle.Degrees(-75.81378301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4040"},
        {"Hipparcos Number", "HIP 3247"},
        {"Geneva Identification System", "GEN# +1.00004040"},
        {"Smithsonian Astrophysical Observation", "SAO 255696"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.33980241),
        dec: Angle.Degrees(-75.81282791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20506"},
        {"Hipparcos Number", "HIP 14815"},
        {"Geneva Identification System", "GEN# +1.00020506"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.82009476),
        dec: Angle.Degrees(-75.81184921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27728"},
        {"Hipparcos Number", "HIP 19790"},
        {"Fundamental Katalog 5th Edition", "FK5 2314"},
        {"Geneva Identification System", "GEN# +1.00027728"},
        {"Smithsonian Astrophysical Observation", "SAO 256076"},
        {"Wilson Evans Batten Catalogue", "WEB 3778"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.62849255),
        dec: Angle.Degrees(-75.80810816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139265"},
        {"Hipparcos Number", "HIP 77069"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.04861714),
        dec: Angle.Degrees(-75.80431760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178274"},
        {"Hipparcos Number", "HIP 94714"},
        {"Fundamental Katalog 5th Edition", "FK5 1499"},
        {"Geneva Identification System", "GEN# +1.00178274"},
        {"Smithsonian Astrophysical Observation", "SAO 257671"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.09331078),
        dec: Angle.Degrees(-75.80005223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119701"},
        {"Hipparcos Number", "HIP 67361"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.09784025),
        dec: Angle.Degrees(-75.79502540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92253"},
        {"Hipparcos Number", "HIP 51873"},
        {"Smithsonian Astrophysical Observation", "SAO 256732"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.97511404),
        dec: Angle.Degrees(-75.79322901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97901"},
        {"Hipparcos Number", "HIP 54852"},
        {"Geneva Identification System", "GEN# +1.00097901"},
        {"Renson", "Renson 28220"},
        {"Smithsonian Astrophysical Observation", "SAO 256813"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.45179157),
        dec: Angle.Degrees(-75.79048133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63998"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.71812326),
        dec: Angle.Degrees(-75.78489858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16148"},
        {"Hipparcos Number", "HIP 11629"},
        {"Geneva Identification System", "GEN# +1.00016148"},
        {"Smithsonian Astrophysical Observation", "SAO 255895"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.51984566),
        dec: Angle.Degrees(-75.78467179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2432"},
        {"Hipparcos Number", "HIP 2127"},
        {"Smithsonian Astrophysical Observation", "SAO 255672"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.74449377),
        dec: Angle.Degrees(-75.78382823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122713"},
        {"Hipparcos Number", "HIP 69027"},
        {"Renson", "Renson 35190"},
        {"Smithsonian Astrophysical Observation", "SAO 257115"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.96653368),
        dec: Angle.Degrees(-75.78276397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85643"},
        {"Hipparcos Number", "HIP 48095"},
        {"Geneva Identification System", "GEN# +1.00085643"},
        {"Smithsonian Astrophysical Observation", "SAO 256660"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.08970292),
        dec: Angle.Degrees(-75.77808685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 91.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82259"},
        {"Hipparcos Number", "HIP 46229"},
        {"Fundamental Katalog 5th Edition", "FK5 4840"},
        {"Geneva Identification System", "GEN# +1.00082259"},
        {"Smithsonian Astrophysical Observation", "SAO 256619"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.37976513),
        dec: Angle.Degrees(-75.77313038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38534",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38534"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.36492094),
        dec: Angle.Degrees(-75.76769307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23521"},
        {"Hipparcos Number", "HIP 16999"},
        {"Geneva Identification System", "GEN# +1.00023521"},
        {"Smithsonian Astrophysical Observation", "SAO 256008"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.66390232),
        dec: Angle.Degrees(-75.76288055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123842"},
        {"Hipparcos Number", "HIP 69575"},
        {"Geneva Identification System", "GEN# +1.00123842"},
        {"Smithsonian Astrophysical Observation", "SAO 257128"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.62183398),
        dec: Angle.Degrees(-75.76195503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15841"},
        {"Hipparcos Number", "HIP 11434"},
        {"Fundamental Katalog 5th Edition", "FK5 4228"},
        {"Smithsonian Astrophysical Observation", "SAO 255890"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.86857056),
        dec: Angle.Degrees(-75.74043145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216669"},
        {"Hipparcos Number", "HIP 113344"},
        {"Smithsonian Astrophysical Observation", "SAO 258088"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.31922687),
        dec: Angle.Degrees(-75.73996886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122469"},
        {"Hipparcos Number", "HIP 68894"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.59116472),
        dec: Angle.Degrees(-75.72985435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78086"},
        {"Hipparcos Number", "HIP 44189"},
        {"Smithsonian Astrophysical Observation", "SAO 256574"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.02122724),
        dec: Angle.Degrees(-75.72563295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74808"},
        {"Hipparcos Number", "HIP 42463"},
        {"Smithsonian Astrophysical Observation", "SAO 256537"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.85463352),
        dec: Angle.Degrees(-75.72112098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51907"},
        {"Hipparcos Number", "HIP 32828"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.65535096),
        dec: Angle.Degrees(-75.72051657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28203"},
        {"Hipparcos Number", "HIP 20132"},
        {"Geneva Identification System", "GEN# +1.00028203"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.75260058),
        dec: Angle.Degrees(-75.71807888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81504"},
        {"Hipparcos Number", "HIP 45803"},
        {"Geneva Identification System", "GEN# +1.00081504"},
        {"Smithsonian Astrophysical Observation", "SAO 256608"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.10563858),
        dec: Angle.Degrees(-75.71345626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90051"},
        {"Hipparcos Number", "HIP 50569"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.95335816),
        dec: Angle.Degrees(-75.71056236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45538"},
        {"Hipparcos Number", "HIP 30048"},
        {"Smithsonian Astrophysical Observation", "SAO 256294"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.84214768),
        dec: Angle.Degrees(-75.70008799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10041"},
        {"Hipparcos Number", "HIP 7342"},
        {"Smithsonian Astrophysical Observation", "SAO 255795"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.65005324),
        dec: Angle.Degrees(-75.69674839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19879"},
        {"Hipparcos Number", "HIP 14368"},
        {"Geneva Identification System", "GEN# +1.00019879"},
        {"Smithsonian Astrophysical Observation", "SAO 255956"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34241193),
        dec: Angle.Degrees(-75.69538846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36767"},
        {"Hipparcos Number", "HIP 25351"},
        {"Geneva Identification System", "GEN# +1.00036767"},
        {"Smithsonian Astrophysical Observation", "SAO 256188"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.33032710),
        dec: Angle.Degrees(-75.69165030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -308.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163126"},
        {"Hipparcos Number", "HIP 88423"},
        {"Smithsonian Astrophysical Observation", "SAO 257554"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79942913),
        dec: Angle.Degrees(-75.68926976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104938"},
        {"Hipparcos Number", "HIP 58933"},
        {"Geneva Identification System", "GEN# +1.00104938"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25707810),
        dec: Angle.Degrees(-75.68704610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118285"},
        {"Hipparcos Number", "HIP 66607"},
        {"Fundamental Katalog 5th Edition", "FK5 503"},
        {"Geneva Identification System", "GEN# +1.00118285"},
        {"Smithsonian Astrophysical Observation", "SAO 257069"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.80016438),
        dec: Angle.Degrees(-75.68377048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159538"},
        {"Hipparcos Number", "HIP 86787"},
        {"Smithsonian Astrophysical Observation", "SAO 257522"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.00917471),
        dec: Angle.Degrees(-75.68196361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29658"},
        {"Hipparcos Number", "HIP 21141"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.98298987),
        dec: Angle.Degrees(-75.68109423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58449"},
        {"Hipparcos Number", "HIP 35294"},
        {"Smithsonian Astrophysical Observation", "SAO 256394"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36721483),
        dec: Angle.Degrees(-75.68066926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146152"},
        {"Hipparcos Number", "HIP 80210"},
        {"Fundamental Katalog 5th Edition", "FK5 5443"},
        {"Geneva Identification System", "GEN# +1.00146152"},
        {"Smithsonian Astrophysical Observation", "SAO 257388"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.61916911),
        dec: Angle.Degrees(-75.67923738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2090"},
        {"Hipparcos Number", "HIP 1914"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.05560073),
        dec: Angle.Degrees(-75.67920933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208638"},
        {"Hipparcos Number", "HIP 108779"},
        {"Geneva Identification System", "GEN# +1.00208638"},
        {"Smithsonian Astrophysical Observation", "SAO 257991"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.53054640),
        dec: Angle.Degrees(-75.67899232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176892"},
        {"Hipparcos Number", "HIP 94206"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.68542510),
        dec: Angle.Degrees(-75.67510281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191802"},
        {"Hipparcos Number", "HIP 100167"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.76938297),
        dec: Angle.Degrees(-75.67205991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83660"},
        {"Hipparcos Number", "HIP 47019"},
        {"Smithsonian Astrophysical Observation", "SAO 256640"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.73578969),
        dec: Angle.Degrees(-75.66980428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76285"},
        {"Geneva Identification System", "GEN# -0.07501197"},
    },
    visualMagnitude: 9.52,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.72429780),
        dec: Angle.Degrees(-75.66829725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10747"},
        {"Hipparcos Number", "HIP 7873"},
        {"Geneva Identification System", "GEN# +1.00010747"},
        {"Smithsonian Astrophysical Observation", "SAO 255804"},
        {"Wilson Evans Batten Catalogue", "WEB 1681"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.32448146),
        dec: Angle.Degrees(-75.66367901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1485"},
        {"Hipparcos Number", "HIP 1462"},
        {"Geneva Identification System", "GEN# +1.00001485"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.56913714),
        dec: Angle.Degrees(-75.66328425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18649"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.87816450),
        dec: Angle.Degrees(-75.66075728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76504"},
        {"Hipparcos Number", "HIP 43386"},
        {"Smithsonian Astrophysical Observation", "SAO 256558"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.56674825),
        dec: Angle.Degrees(-75.65865598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169838"},
        {"Hipparcos Number", "HIP 91114"},
        {"Smithsonian Astrophysical Observation", "SAO 257604"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.78677379),
        dec: Angle.Degrees(-75.65358748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112255"},
        {"Hipparcos Number", "HIP 63226"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.32979888),
        dec: Angle.Degrees(-75.64036810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83744"},
        {"Hipparcos Number", "HIP 47069"},
        {"Renson", "Renson 23870"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.88303005),
        dec: Angle.Degrees(-75.64008620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102879"},
        {"Hipparcos Number", "HIP 57715"},
        {"Geneva Identification System", "GEN# +1.00102879"},
        {"Smithsonian Astrophysical Observation", "SAO 256878"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.54455387),
        dec: Angle.Degrees(-75.63867590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150761"},
        {"Hipparcos Number", "HIP 82466"},
        {"Geneva Identification System", "GEN# +1.00150761"},
        {"Smithsonian Astrophysical Observation", "SAO 257435"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.79469206),
        dec: Angle.Degrees(-75.63400696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219853"},
        {"Hipparcos Number", "HIP 115247"},
        {"Fundamental Katalog 5th Edition", "FK5 3869"},
        {"Geneva Identification System", "GEN# +1.00219853"},
        {"Smithsonian Astrophysical Observation", "SAO 258130"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.15642988),
        dec: Angle.Degrees(-75.63286226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92727"},
        {"Hipparcos Number", "HIP 52172"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.88217081),
        dec: Angle.Degrees(-75.63233761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223889"},
        {"Hipparcos Number", "HIP 117828"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.45641120),
        dec: Angle.Degrees(-75.63161024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -378.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31293"},
    },
    visualMagnitude: 10.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.43325369),
        dec: Angle.Degrees(-75.63066752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -290.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 278.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31292"},
    },
    visualMagnitude: 11.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.44808629),
        dec: Angle.Degrees(-75.62561416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -308.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 256.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54683"},
        {"Hipparcos Number", "HIP 33830"},
        {"Smithsonian Astrophysical Observation", "SAO 256365"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.34846527),
        dec: Angle.Degrees(-75.62095419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36623"},
        {"Hipparcos Number", "HIP 25277"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.09484448),
        dec: Angle.Degrees(-75.62062217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142308"},
        {"Hipparcos Number", "HIP 78477"},
        {"Smithsonian Astrophysical Observation", "SAO 257345"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.29563313),
        dec: Angle.Degrees(-75.61945350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108558"},
        {"Hipparcos Number", "HIP 60921"},
        {"Geneva Identification System", "GEN# +1.00108558"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.28278983),
        dec: Angle.Degrees(-75.61901168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2496"},
        {"Hipparcos Number", "HIP 2182"},
        {"Geneva Identification System", "GEN# +1.00002496"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.89524354),
        dec: Angle.Degrees(-75.61359603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3601"},
        {"Hipparcos Number", "HIP 2947"},
        {"Geneva Identification System", "GEN# +1.00003601"},
        {"Renson", "Renson 980"},
        {"Smithsonian Astrophysical Observation", "SAO 255688"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.34741761),
        dec: Angle.Degrees(-75.60684103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28778"},
        {"Hipparcos Number", "HIP 20537"},
        {"Geneva Identification System", "GEN# +1.00028778"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.01434278),
        dec: Angle.Degrees(-75.60482780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26169"},
        {"Hipparcos Number", "HIP 18742"},
        {"Geneva Identification System", "GEN# +1.00026169"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.21714614),
        dec: Angle.Degrees(-75.60336204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130580"},
        {"Hipparcos Number", "HIP 72961"},
        {"Smithsonian Astrophysical Observation", "SAO 257207"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.66689992),
        dec: Angle.Degrees(-75.60182322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95326"},
        {"Hipparcos Number", "HIP 53607"},
        {"Geneva Identification System", "GEN# +1.00095326"},
        {"Smithsonian Astrophysical Observation", "SAO 256777"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.50269038),
        dec: Angle.Degrees(-75.60120558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221524"},
        {"Hipparcos Number", "HIP 116309"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.48442186),
        dec: Angle.Degrees(-75.59804818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96092"},
        {"Hipparcos Number", "HIP 53999"},
        {"Geneva Identification System", "GEN# +1.00096092"},
        {"Smithsonian Astrophysical Observation", "SAO 256789"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.69450738),
        dec: Angle.Degrees(-75.59424897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80364"},
        {"Hipparcos Number", "HIP 45271"},
        {"Smithsonian Astrophysical Observation", "SAO 256596"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.40464692),
        dec: Angle.Degrees(-75.59033685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60378"},
        {"Hipparcos Number", "HIP 36097"},
        {"Smithsonian Astrophysical Observation", "SAO 256413"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.54804682),
        dec: Angle.Degrees(-75.59022704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192117"},
        {"Hipparcos Number", "HIP 100280"},
        {"Geneva Identification System", "GEN# +1.00192117"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.10241180),
        dec: Angle.Degrees(-75.57823647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135219"},
        {"Hipparcos Number", "HIP 75063"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.08839155),
        dec: Angle.Degrees(-75.56402772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192655"},
        {"Hipparcos Number", "HIP 100539"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.79268978),
        dec: Angle.Degrees(-75.55171226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165277"},
        {"Hipparcos Number", "HIP 89338"},
        {"Smithsonian Astrophysical Observation", "SAO 257572"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.42883659),
        dec: Angle.Degrees(-75.55067126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134189"},
        {"Hipparcos Number", "HIP 74615"},
        {"Smithsonian Astrophysical Observation", "SAO 257253"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.68193753),
        dec: Angle.Degrees(-75.54967273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131329"},
        {"Hipparcos Number", "HIP 73293"},
        {"Geneva Identification System", "GEN# +1.00131329"},
        {"Smithsonian Astrophysical Observation", "SAO 257214"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.68330603),
        dec: Angle.Degrees(-75.54756985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62364"},
        {"Hipparcos Number", "HIP 36941"},
        {"Geneva Identification System", "GEN# +1.00062364"},
        {"Smithsonian Astrophysical Observation", "SAO 256429"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.90861163),
        dec: Angle.Degrees(-75.54420870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219331"},
        {"Hipparcos Number", "HIP 114925"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.18142394),
        dec: Angle.Degrees(-75.53435273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129969"},
        {"Hipparcos Number", "HIP 72647"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.79444946),
        dec: Angle.Degrees(-75.52870665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61520"},
        {"Hipparcos Number", "HIP 36612"},
        {"Smithsonian Astrophysical Observation", "SAO 256421"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.94193735),
        dec: Angle.Degrees(-75.52736209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88848"},
        {"Hipparcos Number", "HIP 49860"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.72618621),
        dec: Angle.Degrees(-75.52655981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202732"},
        {"Hipparcos Number", "HIP 105612"},
        {"Geneva Identification System", "GEN# +1.00202732"},
        {"Smithsonian Astrophysical Observation", "SAO 257916"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.86277076),
        dec: Angle.Degrees(-75.49407487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89793"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.87320604),
        dec: Angle.Degrees(-75.49029474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -324.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107597"},
    },
    visualMagnitude: 9.89,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.90903305),
        dec: Angle.Degrees(-75.48909637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148891"},
        {"Hipparcos Number", "HIP 81530"},
        {"Smithsonian Astrophysical Observation", "SAO 257417"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.78890482),
        dec: Angle.Degrees(-75.48863254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141203"},
        {"Hipparcos Number", "HIP 77941"},
        {"Geneva Identification System", "GEN# +1.00141203"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.75273737),
        dec: Angle.Degrees(-75.48575021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154747"},
        {"Hipparcos Number", "HIP 84421"},
        {"Geneva Identification System", "GEN# +1.00154747"},
        {"Smithsonian Astrophysical Observation", "SAO 257476"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.89138725),
        dec: Angle.Degrees(-75.48198156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205983"},
        {"Hipparcos Number", "HIP 107309"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.01378193),
        dec: Angle.Degrees(-75.48117467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 793"},
        {"Hipparcos Number", "HIP 965"},
        {"Smithsonian Astrophysical Observation", "SAO 255644"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.98072156),
        dec: Angle.Degrees(-75.47684086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149842"},
        {"Hipparcos Number", "HIP 82016"},
        {"Geneva Identification System", "GEN# +1.00149842"},
        {"Smithsonian Astrophysical Observation", "SAO 257428"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.31297693),
        dec: Angle.Degrees(-75.47677639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93165"},
        {"Hipparcos Number", "HIP 52397"},
        {"Geneva Identification System", "GEN# +1.00093165"},
        {"Smithsonian Astrophysical Observation", "SAO 256747"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.65010793),
        dec: Angle.Degrees(-75.46376559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133369"},
        {"Hipparcos Number", "HIP 74227"},
        {"Smithsonian Astrophysical Observation", "SAO 257243"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.53830702),
        dec: Angle.Degrees(-75.46175834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41188"},
        {"Hipparcos Number", "HIP 27957"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.72482663),
        dec: Angle.Degrees(-75.45915067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113229"},
        {"Cincinnati Publication", "Ci 20 1389"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.94957092),
        dec: Angle.Degrees(-75.45609056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1027.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1061.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120244"},
        {"Hipparcos Number", "HIP 67698"},
        {"Smithsonian Astrophysical Observation", "SAO 257093"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.00807652),
        dec: Angle.Degrees(-75.45308848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38473"},
        {"Hipparcos Number", "HIP 26425"},
        {"Smithsonian Astrophysical Observation", "SAO 256216"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.36036550),
        dec: Angle.Degrees(-75.45039282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98913"},
        {"Hipparcos Number", "HIP 55458"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.36460079),
        dec: Angle.Degrees(-75.44516337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188749"},
        {"Hipparcos Number", "HIP 98832"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.05546400),
        dec: Angle.Degrees(-75.43932143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109067"},
        {"Hipparcos Number", "HIP 61233"},
        {"Geneva Identification System", "GEN# +1.00109067"},
        {"Smithsonian Astrophysical Observation", "SAO 256958"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.20991770),
        dec: Angle.Degrees(-75.43462198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18625"},
        {"Hipparcos Number", "HIP 13480"},
        {"Geneva Identification System", "GEN# +1.00018625"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.39914321),
        dec: Angle.Degrees(-75.43406188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158247"},
        {"Hipparcos Number", "HIP 86175"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.14911356),
        dec: Angle.Degrees(-75.43217104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10373"},
        {"Hipparcos Number", "HIP 7581"},
        {"Smithsonian Astrophysical Observation", "SAO 255798"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.40933334),
        dec: Angle.Degrees(-75.42955811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103747"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.35385698),
        dec: Angle.Degrees(-75.42898294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199133"},
        {"Hipparcos Number", "HIP 103745"},
        {"Smithsonian Astrophysical Observation", "SAO 257873"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.34876016),
        dec: Angle.Degrees(-75.42486598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49139"},
    },
    visualMagnitude: 12.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.42813593),
        dec: Angle.Degrees(-75.42392873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215208"},
        {"Hipparcos Number", "HIP 112429"},
        {"Fundamental Katalog 5th Edition", "FK5 3820"},
        {"Smithsonian Astrophysical Observation", "SAO 258066"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.59703395),
        dec: Angle.Degrees(-75.42216614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62784"},
        {"Hipparcos Number", "HIP 37139"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.47296896),
        dec: Angle.Degrees(-75.42076721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220746"},
        {"Hipparcos Number", "HIP 115801"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.90203708),
        dec: Angle.Degrees(-75.41892013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204399"},
        {"Hipparcos Number", "HIP 106442"},
        {"Geneva Identification System", "GEN# +1.00204399"},
        {"Smithsonian Astrophysical Observation", "SAO 257934"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.39432692),
        dec: Angle.Degrees(-75.41270825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183506"},
        {"Hipparcos Number", "HIP 96564"},
        {"Smithsonian Astrophysical Observation", "SAO 257710"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.46712564),
        dec: Angle.Degrees(-75.40697999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5713"},
        {"Hipparcos Number", "HIP 4415"},
        {"Wilson Evans Batten Catalogue", "WEB 790"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.13899212),
        dec: Angle.Degrees(-75.40658318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141058"},
        {"Hipparcos Number", "HIP 77866"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.50017565),
        dec: Angle.Degrees(-75.40520792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108792"},
        {"Hipparcos Number", "HIP 61066"},
        {"Geneva Identification System", "GEN# +1.00108792"},
        {"Smithsonian Astrophysical Observation", "SAO 256951"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.73380575),
        dec: Angle.Degrees(-75.40075993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184588"},
        {"Hipparcos Number", "HIP 97008"},
        {"Geneva Identification System", "GEN# +1.00184588"},
        {"Smithsonian Astrophysical Observation", "SAO 257718"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.75062918),
        dec: Angle.Degrees(-75.39780573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85297"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.44845797),
        dec: Angle.Degrees(-75.39714338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174584"},
        {"Hipparcos Number", "HIP 93233"},
        {"Smithsonian Astrophysical Observation", "SAO 257643"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.86163132),
        dec: Angle.Degrees(-75.39006541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109138"},
        {"Hipparcos Number", "HIP 61284"},
        {"Geneva Identification System", "GEN# +1.00109138"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.37500739),
        dec: Angle.Degrees(-75.38649443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94716"},
        {"Hipparcos Number", "HIP 53239"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35248945),
        dec: Angle.Degrees(-75.38517980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86405"},
        {"Hipparcos Number", "HIP 48530"},
        {"Renson", "Renson 24720"},
        {"Smithsonian Astrophysical Observation", "SAO 256668"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.46138155),
        dec: Angle.Degrees(-75.38037744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14368"},
        {"Hipparcos Number", "HIP 10428"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.58719018),
        dec: Angle.Degrees(-75.37840607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103925"},
        {"Hipparcos Number", "HIP 58339"},
        {"Fundamental Katalog 5th Edition", "FK5 5051"},
        {"Geneva Identification System", "GEN# +1.00103925"},
        {"Smithsonian Astrophysical Observation", "SAO 256889"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.45480228),
        dec: Angle.Degrees(-75.37708467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153880"},
        {"Hipparcos Number", "HIP 84001"},
        {"Smithsonian Astrophysical Observation", "SAO 257465"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.56812203),
        dec: Angle.Degrees(-75.37659692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200558"},
        {"Hipparcos Number", "HIP 104500"},
        {"Geneva Identification System", "GEN# +1.00200558"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53115807),
        dec: Angle.Degrees(-75.37468585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109857"},
        {"Hipparcos Number", "HIP 61738"},
        {"Geneva Identification System", "GEN# +1.00109857J"},
        {"Smithsonian Astrophysical Observation", "SAO 256967"},
        {"Wilson Evans Batten Catalogue", "WEB 10982"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81098559),
        dec: Angle.Degrees(-75.37056959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11476"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.00735204),
        dec: Angle.Degrees(-75.37000877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105340"},
        {"Hipparcos Number", "HIP 59151"},
        {"Fundamental Katalog 5th Edition", "FK5 2971"},
        {"Geneva Identification System", "GEN# +1.00105340"},
        {"Smithsonian Astrophysical Observation", "SAO 256905"},
        {"Wilson Evans Batten Catalogue", "WEB 10523"},
    },
    visualMagnitude: 5.17,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.95870080),
        dec: Angle.Degrees(-75.36706513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12362"},
        {"Hipparcos Number", "HIP 9078"},
        {"Smithsonian Astrophysical Observation", "SAO 255836"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.22415979),
        dec: Angle.Degrees(-75.36577207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34851"},
        {"Hipparcos Number", "HIP 24219"},
        {"Geneva Identification System", "GEN# +1.00034851"},
        {"Smithsonian Astrophysical Observation", "SAO 256168"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.00921278),
        dec: Angle.Degrees(-75.36043752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72719"},
        {"Hipparcos Number", "HIP 41478"},
        {"Smithsonian Astrophysical Observation", "SAO 256516"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.89117371),
        dec: Angle.Degrees(-75.35884022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196067"},
        {"Hipparcos Number", "HIP 102125"},
        {"Geneva Identification System", "GEN# +1.00196067A"},
        {"Smithsonian Astrophysical Observation", "SAO 257836"},
        {"Wilson Evans Batten Catalogue", "WEB 18469"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43225974),
        dec: Angle.Degrees(-75.35041089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188480"},
        {"Hipparcos Number", "HIP 98704"},
        {"Geneva Identification System", "GEN# +1.00188480"},
        {"Smithsonian Astrophysical Observation", "SAO 257763"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.70918067),
        dec: Angle.Degrees(-75.34933860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155918"},
        {"Hipparcos Number", "HIP 84988"},
        {"Cincinnati Publication", "Ci 20 1028"},
        {"Geneva Identification System", "GEN# +1.00155918"},
        {"Smithsonian Astrophysical Observation", "SAO 257489"},
        {"Wilson Evans Batten Catalogue", "WEB 14355"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.56190159),
        dec: Angle.Degrees(-75.34753364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -957.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201906"},
        {"Hipparcos Number", "HIP 105169"},
        {"Fundamental Katalog 5th Edition", "FK5 3697"},
        {"Geneva Identification System", "GEN# +1.00201906"},
        {"Smithsonian Astrophysical Observation", "SAO 257904"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.56750735),
        dec: Angle.Degrees(-75.34666642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196068"},
        {"Hipparcos Number", "HIP 102128"},
        {"Geneva Identification System", "GEN# +1.00196068"},
        {"Smithsonian Astrophysical Observation", "SAO 257837"},
        {"Wilson Evans Batten Catalogue", "WEB 18470"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.43808085),
        dec: Angle.Degrees(-75.34598534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9086"},
        {"Hipparcos Number", "HIP 6708"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.56948273),
        dec: Angle.Degrees(-75.34581826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27883"},
        {"Hipparcos Number", "HIP 19909"},
        {"Geneva Identification System", "GEN# +1.00027883"},
        {"Renson", "Renson 7140"},
        {"Smithsonian Astrophysical Observation", "SAO 256078"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.06093158),
        dec: Angle.Degrees(-75.34426338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40941"},
        {"Hipparcos Number", "HIP 27852"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.39121206),
        dec: Angle.Degrees(-75.34405704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135161"},
        {"Hipparcos Number", "HIP 75029"},
        {"Geneva Identification System", "GEN# +1.00135161"},
        {"Smithsonian Astrophysical Observation", "SAO 257263"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.96838669),
        dec: Angle.Degrees(-75.32875800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137943"},
        {"Hipparcos Number", "HIP 76340"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.89501547),
        dec: Angle.Degrees(-75.32585538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111152"},
        {"Hipparcos Number", "HIP 62539"},
        {"Geneva Identification System", "GEN# +1.00111152"},
        {"Smithsonian Astrophysical Observation", "SAO 256981"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.22294896),
        dec: Angle.Degrees(-75.32271770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73122"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.17417457),
        dec: Angle.Degrees(-75.31781030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6145"},
        {"Hipparcos Number", "HIP 4698"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.09180379),
        dec: Angle.Degrees(-75.31743583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114444"},
        {"Hipparcos Number", "HIP 64485"},
        {"Geneva Identification System", "GEN# +1.00114444"},
        {"Wilson Evans Batten Catalogue", "WEB 11399"},
    },
    visualMagnitude: 10.31,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.26737205),
        dec: Angle.Degrees(-75.31383437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25269"},
        {"Hipparcos Number", "HIP 18198"},
        {"Geneva Identification System", "GEN# +1.00025269"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.38814734),
        dec: Angle.Degrees(-75.31017253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56321"},
        {"Hipparcos Number", "HIP 34449"},
        {"Smithsonian Astrophysical Observation", "SAO 256376"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.11693568),
        dec: Angle.Degrees(-75.30227912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81546"},
        {"Hipparcos Number", "HIP 45850"},
        {"Geneva Identification System", "GEN# +1.00081546"},
        {"Smithsonian Astrophysical Observation", "SAO 256609"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.21655332),
        dec: Angle.Degrees(-75.29806571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207016"},
        {"Hipparcos Number", "HIP 107829"},
        {"Smithsonian Astrophysical Observation", "SAO 257963"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.67700719),
        dec: Angle.Degrees(-75.29788033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80490"},
        {"Hipparcos Number", "HIP 45356"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.64493816),
        dec: Angle.Degrees(-75.29512024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144300"},
        {"Hipparcos Number", "HIP 79415"},
        {"Geneva Identification System", "GEN# +1.00144300"},
        {"Smithsonian Astrophysical Observation", "SAO 257368"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.11485151),
        dec: Angle.Degrees(-75.29279184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19455"},
        {"Hipparcos Number", "HIP 14082"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.39312346),
        dec: Angle.Degrees(-75.28798784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21694"},
        {"Hipparcos Number", "HIP 15782"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.85024903),
        dec: Angle.Degrees(-75.28295369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154540"},
        {"Hipparcos Number", "HIP 84315"},
        {"Geneva Identification System", "GEN# +1.00154540"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.56088951),
        dec: Angle.Degrees(-75.27983300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32918"},
        {"Hipparcos Number", "HIP 23106"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.57477529),
        dec: Angle.Degrees(-75.27721101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204112"},
        {"Hipparcos Number", "HIP 106311"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.97552260),
        dec: Angle.Degrees(-75.26330179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120313"},
        {"Hipparcos Number", "HIP 67731"},
        {"Smithsonian Astrophysical Observation", "SAO 257095"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.12223797),
        dec: Angle.Degrees(-75.25875833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133813"},
        {"Hipparcos Number", "HIP 74405"},
        {"Geneva Identification System", "GEN# +1.00133813"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.09836022),
        dec: Angle.Degrees(-75.25416442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90471",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90471"},
    },
    visualMagnitude: 12.47,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.91146876),
        dec: Angle.Degrees(-75.24520492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17410"},
        {"Hipparcos Number", "HIP 12588"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.47422102),
        dec: Angle.Degrees(-75.23808787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161476"},
        {"Hipparcos Number", "HIP 87638"},
        {"Geneva Identification System", "GEN# +1.00161476"},
        {"Smithsonian Astrophysical Observation", "SAO 257535"},
        {"Wilson Evans Batten Catalogue", "WEB 14790"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.52340190),
        dec: Angle.Degrees(-75.23739440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37854"},
        {"Hipparcos Number", "HIP 26002"},
        {"Smithsonian Astrophysical Observation", "SAO 256203"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.24845614),
        dec: Angle.Degrees(-75.23682160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58776"},
        {"Hipparcos Number", "HIP 35448"},
        {"Smithsonian Astrophysical Observation", "SAO 256397"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.78495146),
        dec: Angle.Degrees(-75.23651815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106183"},
        {"Hipparcos Number", "HIP 59605"},
        {"Geneva Identification System", "GEN# +1.00106183"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.35143666),
        dec: Angle.Degrees(-75.23624341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9569"},
        {"Hipparcos Number", "HIP 7027"},
        {"Geneva Identification System", "GEN# +1.00009569"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.63895255),
        dec: Angle.Degrees(-75.23212242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55353"},
        {"Hipparcos Number", "HIP 34119"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.11642723),
        dec: Angle.Degrees(-75.23133014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107721"},
        {"Hipparcos Number", "HIP 60424"},
        {"Smithsonian Astrophysical Observation", "SAO 256936"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.83903562),
        dec: Angle.Degrees(-75.23093477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101805"},
        {"Hipparcos Number", "HIP 57092"},
        {"Geneva Identification System", "GEN# +1.00101805"},
        {"Smithsonian Astrophysical Observation", "SAO 256864"},
        {"Wilson Evans Batten Catalogue", "WEB 10277"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.56175020),
        dec: Angle.Degrees(-75.22730303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178000"},
        {"Hipparcos Number", "HIP 94589"},
        {"Renson", "Renson 49590"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74317799),
        dec: Angle.Degrees(-75.22396417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98294"},
        {"Hipparcos Number", "HIP 55083"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.16182613),
        dec: Angle.Degrees(-75.22201668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48386"},
        {"Hipparcos Number", "HIP 31390"},
        {"Renson", "Renson 12950"},
        {"Smithsonian Astrophysical Observation", "SAO 256316"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.70996010),
        dec: Angle.Degrees(-75.21887509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135924"},
        {"Hipparcos Number", "HIP 75362"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.00120117),
        dec: Angle.Degrees(-75.21182709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182654"},
        {"Hipparcos Number", "HIP 96186"},
        {"Smithsonian Astrophysical Observation", "SAO 257702"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.36557676),
        dec: Angle.Degrees(-75.21153285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147482"},
        {"Hipparcos Number", "HIP 80800"},
        {"Smithsonian Astrophysical Observation", "SAO 257402"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.48073115),
        dec: Angle.Degrees(-75.20607268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123641"},
        {"Hipparcos Number", "HIP 69457"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30509025),
        dec: Angle.Degrees(-75.20279197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203971"},
        {"Hipparcos Number", "HIP 106209"},
        {"Fundamental Katalog 5th Edition", "FK5 5900"},
        {"Geneva Identification System", "GEN# +1.00203971"},
        {"Smithsonian Astrophysical Observation", "SAO 257930"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.68865802),
        dec: Angle.Degrees(-75.20255303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54263"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.52142815),
        dec: Angle.Degrees(-75.19593193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94964"},
        {"Hipparcos Number", "HIP 53401"},
        {"Geneva Identification System", "GEN# +1.00094964"},
        {"Smithsonian Astrophysical Observation", "SAO 256773"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.83403083),
        dec: Angle.Degrees(-75.19178353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164644"},
        {"Hipparcos Number", "HIP 89051"},
        {"Smithsonian Astrophysical Observation", "SAO 257567"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.64354376),
        dec: Angle.Degrees(-75.19167711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164643"},
        {"Henry Draper 2", "HD 164643J"},
        {"Hipparcos Number", "HIP 89050"},
        {"Geneva Identification System", "GEN# +1.00164643"},
        {"Smithsonian Astrophysical Observation", "SAO 257566"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.64144538),
        dec: Angle.Degrees(-75.18806060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110775"},
        {"Hipparcos Number", "HIP 62289"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.47333755),
        dec: Angle.Degrees(-75.18425833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97623"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.62750417),
        dec: Angle.Degrees(-75.18112508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21583"},
        {"Hipparcos Number", "HIP 15705"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.57748193),
        dec: Angle.Degrees(-75.18070646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124654"},
        {"Hipparcos Number", "HIP 70001"},
        {"Geneva Identification System", "GEN# +1.00124654"},
        {"Smithsonian Astrophysical Observation", "SAO 257136"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.86045097),
        dec: Angle.Degrees(-75.17925165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17894"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.41023078),
        dec: Angle.Degrees(-75.17881788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117401"},
        {"Hipparcos Number", "HIP 66111"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.28406315),
        dec: Angle.Degrees(-75.17414186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181465"},
        {"Hipparcos Number", "HIP 95751"},
        {"Geneva Identification System", "GEN# +1.00181465"},
        {"Smithsonian Astrophysical Observation", "SAO 257689"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.12028684),
        dec: Angle.Degrees(-75.17387773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114657"},
        {"Hipparcos Number", "HIP 64598"},
        {"Smithsonian Astrophysical Observation", "SAO 257021"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.60626911),
        dec: Angle.Degrees(-75.17115051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194973"},
        {"Hipparcos Number", "HIP 101572"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.77733959),
        dec: Angle.Degrees(-75.16652468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26414"},
        {"Hipparcos Number", "HIP 18910"},
        {"Geneva Identification System", "GEN# +1.00026414"},
        {"Smithsonian Astrophysical Observation", "SAO 256057"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.79318512),
        dec: Angle.Degrees(-75.16002324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41825"},
        {"Hipparcos Number", "HIP 28306"},
        {"Smithsonian Astrophysical Observation", "SAO 256258"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72502294),
        dec: Angle.Degrees(-75.15976022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92665"},
        {"Hipparcos Number", "HIP 52131"},
        {"Geneva Identification System", "GEN# +1.00092665"},
        {"Smithsonian Astrophysical Observation", "SAO 256739"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.75761600),
        dec: Angle.Degrees(-75.15749677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96451"},
        {"Hipparcos Number", "HIP 54166"},
        {"Geneva Identification System", "GEN# +1.00096451"},
        {"Renson", "Renson 27800"},
        {"Smithsonian Astrophysical Observation", "SAO 256794"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.20284661),
        dec: Angle.Degrees(-75.15516785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78693"},
        {"Hipparcos Number", "HIP 44473"},
        {"Smithsonian Astrophysical Observation", "SAO 256581"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.91894450),
        dec: Angle.Degrees(-75.15445879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90967"},
        {"Hipparcos Number", "HIP 51121"},
        {"Geneva Identification System", "GEN# +1.00090967"},
        {"Renson", "Renson 26140"},
        {"Smithsonian Astrophysical Observation", "SAO 256715"},
        {"Wilson Evans Batten Catalogue", "WEB 9345"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.66433679),
        dec: Angle.Degrees(-75.14945319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34901"},
        {"Hipparcos Number", "HIP 24262"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.11383469),
        dec: Angle.Degrees(-75.14473375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82837"},
        {"Hipparcos Number", "HIP 46534"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.36387279),
        dec: Angle.Degrees(-75.14307313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98672"},
        {"Hipparcos Number", "HIP 55308"},
        {"Geneva Identification System", "GEN# +1.00098672"},
        {"Smithsonian Astrophysical Observation", "SAO 256826"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.90242028),
        dec: Angle.Degrees(-75.14244982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128400"},
        {"Hipparcos Number", "HIP 71855"},
        {"Geneva Identification System", "GEN# +1.00128400"},
        {"Smithsonian Astrophysical Observation", "SAO 257183"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.46744227),
        dec: Angle.Degrees(-75.13943205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22794"},
        {"Hipparcos Number", "HIP 16539"},
        {"Geneva Identification System", "GEN# +1.00022794"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.24693998),
        dec: Angle.Degrees(-75.13286713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 102.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45820"},
        {"Hipparcos Number", "HIP 30209"},
        {"Smithsonian Astrophysical Observation", "SAO 256297"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.33272339),
        dec: Angle.Degrees(-75.12804096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163282"},
        {"Hipparcos Number", "HIP 88461"},
        {"Geneva Identification System", "GEN# +1.00163282"},
        {"Smithsonian Astrophysical Observation", "SAO 257555"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.92353235),
        dec: Angle.Degrees(-75.12599755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149377"},
        {"Hipparcos Number", "HIP 81756"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.48162523),
        dec: Angle.Degrees(-75.11986236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101766"},
        {"Hipparcos Number", "HIP 57065"},
        {"Geneva Identification System", "GEN# +1.00101766"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.47746436),
        dec: Angle.Degrees(-75.11797454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118667"},
        {"Hipparcos Number", "HIP 66806"},
        {"Geneva Identification System", "GEN# +1.00118667"},
        {"Smithsonian Astrophysical Observation", "SAO 257078"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41458790),
        dec: Angle.Degrees(-75.11536250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311465"},
        {"Hipparcos Number", "HIP 42168"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.94942277),
        dec: Angle.Degrees(-75.10788036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 192.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164250"},
        {"Hipparcos Number", "HIP 88865"},
        {"Smithsonian Astrophysical Observation", "SAO 257563"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14455415),
        dec: Angle.Degrees(-75.10528252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7584"},
        {"Hipparcos Number", "HIP 5691"},
        {"Smithsonian Astrophysical Observation", "SAO 255754"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.30426165),
        dec: Angle.Degrees(-75.10413114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95208"},
        {"Hipparcos Number", "HIP 53546"},
        {"Fundamental Katalog 5th Edition", "FK5 2875"},
        {"Geneva Identification System", "GEN# +1.00095208"},
        {"Smithsonian Astrophysical Observation", "SAO 256775"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.31585745),
        dec: Angle.Degrees(-75.09977108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311466"},
        {"Hipparcos Number", "HIP 42369"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.58383266),
        dec: Angle.Degrees(-75.09646074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214368"},
        {"Hipparcos Number", "HIP 111955"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.16509397),
        dec: Angle.Degrees(-75.09028064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44165"},
        {"Hipparcos Number", "HIP 29427"},
        {"Geneva Identification System", "GEN# +1.00044165"},
        {"Smithsonian Astrophysical Observation", "SAO 256278"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.99146802),
        dec: Angle.Degrees(-75.08393897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86405"},
    },
    visualMagnitude: 12.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)39, 20.4700),
        dec: Angle.DegreesMinutesSeconds((int)-75, (int)04, 40.800)
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
    primaryId: "HIP 22259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31408"},
        {"Hipparcos Number", "HIP 22259"},
        {"Smithsonian Astrophysical Observation", "SAO 256133"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.88344201),
        dec: Angle.Degrees(-75.07535878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92157"},
        {"Hipparcos Number", "HIP 51828"},
        {"Geneva Identification System", "GEN# +1.00092157"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.82762885),
        dec: Angle.Degrees(-75.07008728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18293"},
        {"Hipparcos Number", "HIP 13244"},
        {"Fundamental Katalog 5th Edition", "FK5 2199"},
        {"Geneva Identification System", "GEN# +1.00018293"},
        {"Smithsonian Astrophysical Observation", "SAO 255929"},
        {"Wilson Evans Batten Catalogue", "WEB 2657"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.61890350),
        dec: Angle.Degrees(-75.06688108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153793"},
        {"Hipparcos Number", "HIP 83940"},
        {"Smithsonian Astrophysical Observation", "SAO 257464"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.36027103),
        dec: Angle.Degrees(-75.06384924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144235"},
        {"Hipparcos Number", "HIP 79380"},
        {"Geneva Identification System", "GEN# +1.00144235"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.01180257),
        dec: Angle.Degrees(-75.06170685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76288"},
        {"Hipparcos Number", "HIP 43277"},
        {"Smithsonian Astrophysical Observation", "SAO 256555"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.24704913),
        dec: Angle.Degrees(-75.05881592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196175"},
        {"Hipparcos Number", "HIP 102176"},
        {"Smithsonian Astrophysical Observation", "SAO 257840"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.54866559),
        dec: Angle.Degrees(-75.05588114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60553"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.19921837),
        dec: Angle.Degrees(-75.05261736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167468"},
        {"Hipparcos Number", "HIP 90133"},
        {"Geneva Identification System", "GEN# +1.00167468"},
        {"Smithsonian Astrophysical Observation", "SAO 257584"},
        {"Wilson Evans Batten Catalogue", "WEB 15409"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.90182621),
        dec: Angle.Degrees(-75.04432557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9248"},
        {"Hipparcos Number", "HIP 6821"},
        {"Smithsonian Astrophysical Observation", "SAO 255781"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.93712669),
        dec: Angle.Degrees(-75.04353008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156262"},
        {"Hipparcos Number", "HIP 85212"},
        {"Smithsonian Astrophysical Observation", "SAO 257493"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17994450),
        dec: Angle.Degrees(-75.04237122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197324"},
        {"Hipparcos Number", "HIP 102855"},
        {"Geneva Identification System", "GEN# +1.00197324"},
        {"Smithsonian Astrophysical Observation", "SAO 257856"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.56646140),
        dec: Angle.Degrees(-75.03768980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125555"},
        {"Hipparcos Number", "HIP 70460"},
        {"Renson", "Renson 35860"},
        {"Smithsonian Astrophysical Observation", "SAO 257148"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19391176),
        dec: Angle.Degrees(-75.03543610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131551"},
        {"Hipparcos Number", "HIP 73394"},
        {"Geneva Identification System", "GEN# +1.00131551"},
        {"Smithsonian Astrophysical Observation", "SAO 257219"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.98238440),
        dec: Angle.Degrees(-75.03261964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201774"},
        {"Hipparcos Number", "HIP 105100"},
        {"Smithsonian Astrophysical Observation", "SAO 257903"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.34565131),
        dec: Angle.Degrees(-75.03228612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90290"},
        {"Hipparcos Number", "HIP 50763"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.48988804),
        dec: Angle.Degrees(-75.03009687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90426"},
        {"Hipparcos Number", "HIP 50844"},
        {"Renson", "Renson 25990"},
        {"Smithsonian Astrophysical Observation", "SAO 256707"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.73010888),
        dec: Angle.Degrees(-75.02610322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144001"},
        {"Hipparcos Number", "HIP 79274"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.69223279),
        dec: Angle.Degrees(-75.02609002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161297"},
        {"Hipparcos Number", "HIP 87539"},
        {"Geneva Identification System", "GEN# +1.00161297"},
        {"Smithsonian Astrophysical Observation", "SAO 257534"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.26399597),
        dec: Angle.Degrees(-75.01944815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -340.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
