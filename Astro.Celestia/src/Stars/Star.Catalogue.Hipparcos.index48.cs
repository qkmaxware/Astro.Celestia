using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_48() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33677"},
        {"Hipparcos Number", "HIP 24161"},
        {"Smithsonian Astrophysical Observation", "SAO 150207"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.82626336),
        dec: Angle.Degrees(-15.73045299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92246"},
        {"Hipparcos Number", "HIP 52111"},
        {"Smithsonian Astrophysical Observation", "SAO 156125"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.70943950),
        dec: Angle.Degrees(-15.72979660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9158"},
        {"Hipparcos Number", "HIP 6989"},
        {"Smithsonian Astrophysical Observation", "SAO 147844"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.49324257),
        dec: Angle.Degrees(-15.72887627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191069"},
        {"Hipparcos Number", "HIP 99224"},
        {"Cincinnati Publication", "Ci 20 1193"},
        {"Geneva Identification System", "GEN# +1.00191069"},
        {"Smithsonian Astrophysical Observation", "SAO 163287"},
        {"Wilson Evans Batten Catalogue", "WEB 17677"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14089542),
        dec: Angle.Degrees(-15.72879274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -394.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84012",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sabik"},
        {"Aitken", "ADS 10374 AB"},
        {"Henry Draper", "HD 155125"},
        {"Hipparcos Number", "HIP 84012"},
        {"Geneva Identification System", "GEN# +1.00155125J"},
        {"Smithsonian Astrophysical Observation", "SAO 160332"},
        {"Wilson Evans Batten Catalogue", "WEB 14194"},
    },
    visualMagnitude: 2.43,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.59442659),
        dec: Angle.Degrees(-15.72514757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25725"},
        {"Hipparcos Number", "HIP 19004"},
        {"Smithsonian Astrophysical Observation", "SAO 149350"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.07834250),
        dec: Angle.Degrees(-15.72510364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75525",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9627 AB"},
        {"Henry Draper", "HD 137301"},
        {"Hipparcos Number", "HIP 75525"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.43952186),
        dec: Angle.Degrees(-15.72412470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214209"},
        {"Hipparcos Number", "HIP 111642"},
        {"Smithsonian Astrophysical Observation", "SAO 165195"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.24468329),
        dec: Angle.Degrees(-15.72380923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45979"},
        {"Hipparcos Number", "HIP 30968"},
        {"Smithsonian Astrophysical Observation", "SAO 151570"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.50295175),
        dec: Angle.Degrees(-15.72379431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11683"},
        {"Hipparcos Number", "HIP 8881"},
        {"Geneva Identification System", "GEN# +1.00011683"},
        {"Smithsonian Astrophysical Observation", "SAO 148096"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.59170233),
        dec: Angle.Degrees(-15.72364391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104161"},
    },
    visualMagnitude: 11.63,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.55637851),
        dec: Angle.Degrees(-15.72265128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53062"},
        {"Hipparcos Number", "HIP 33980"},
        {"Renson", "Renson 14580"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.76299057),
        dec: Angle.Degrees(-15.71979979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111312"},
        {"Henry Draper 2", "HD 111312A"},
        {"Hipparcos Number", "HIP 62505"},
        {"Geneva Identification System", "GEN# +1.00111312"},
        {"Smithsonian Astrophysical Observation", "SAO 157520"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.13441477),
        dec: Angle.Degrees(-15.71958151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30691"},
        {"Hipparcos Number", "HIP 22398"},
        {"Smithsonian Astrophysical Observation", "SAO 149910"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30955192),
        dec: Angle.Degrees(-15.71807338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109034"},
        {"Hipparcos Number", "HIP 61145"},
        {"Geneva Identification System", "GEN# +1.00109034"},
        {"Smithsonian Astrophysical Observation", "SAO 157341"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.95463542),
        dec: Angle.Degrees(-15.71550390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139270"},
        {"Hipparcos Number", "HIP 76527"},
        {"Smithsonian Astrophysical Observation", "SAO 159396"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.43594897),
        dec: Angle.Degrees(-15.71546134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134830"},
        {"Hipparcos Number", "HIP 74413"},
        {"Smithsonian Astrophysical Observation", "SAO 159096"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.10999455),
        dec: Angle.Degrees(-15.71506455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15760"},
        {"Hipparcos Number", "HIP 11747"},
        {"Smithsonian Astrophysical Observation", "SAO 148442"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.89635068),
        dec: Angle.Degrees(-15.71318123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19081"},
        {"Smithsonian Astrophysical Observation", "SAO 149364"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.35499398),
        dec: Angle.Degrees(-15.70937183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204957"},
        {"Hipparcos Number", "HIP 106354"},
        {"Geneva Identification System", "GEN# +1.00204957"},
        {"Smithsonian Astrophysical Observation", "SAO 164463"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.10554693),
        dec: Angle.Degrees(-15.70926151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88346"},
        {"Hipparcos Number", "HIP 49858"},
        {"Smithsonian Astrophysical Observation", "SAO 155791"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.71775846),
        dec: Angle.Degrees(-15.70919817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58686"},
        {"Smithsonian Astrophysical Observation", "SAO 157050"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.53752755),
        dec: Angle.Degrees(-15.70806682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55805"},
        {"Geneva Identification System", "GEN# -0.01403322"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.51968055),
        dec: Angle.Degrees(-15.70795219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32423"},
        {"Hipparcos Number", "HIP 23458"},
        {"Smithsonian Astrophysical Observation", "SAO 150094"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.63173856),
        dec: Angle.Degrees(-15.70770394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32602"},
        {"Hipparcos Number", "HIP 23541"},
        {"Geneva Identification System", "GEN# +1.00032602"},
        {"Smithsonian Astrophysical Observation", "SAO 150106"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.93071979),
        dec: Angle.Degrees(-15.70706658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134360"},
        {"Hipparcos Number", "HIP 74209"},
        {"Geneva Identification System", "GEN# +1.00134360"},
        {"Smithsonian Astrophysical Observation", "SAO 159059"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.47050418),
        dec: Angle.Degrees(-15.70645417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13003"},
        {"Hipparcos Number", "HIP 9869"},
        {"Smithsonian Astrophysical Observation", "SAO 148211"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.73884330),
        dec: Angle.Degrees(-15.70566088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188617"},
        {"Hipparcos Number", "HIP 98125"},
        {"Geneva Identification System", "GEN# +1.00188617"},
        {"Smithsonian Astrophysical Observation", "SAO 163122"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.14279284),
        dec: Angle.Degrees(-15.70380567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7091"},
        {"Hipparcos Number", "HIP 5540"},
        {"Smithsonian Astrophysical Observation", "SAO 147653"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.76036427),
        dec: Angle.Degrees(-15.70370174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201462"},
        {"Hipparcos Number", "HIP 104505"},
        {"Geneva Identification System", "GEN# +1.00201462"},
        {"Smithsonian Astrophysical Observation", "SAO 164187"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53358291),
        dec: Angle.Degrees(-15.70349975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51054"},
        {"Hipparcos Number", "HIP 33263"},
        {"Smithsonian Astrophysical Observation", "SAO 152100"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.80012738),
        dec: Angle.Degrees(-15.70344741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42263"},
        {"Hipparcos Number", "HIP 29165"},
        {"Smithsonian Astrophysical Observation", "SAO 151166"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.27993791),
        dec: Angle.Degrees(-15.70164934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170938"},
        {"Hipparcos Number", "HIP 90907"},
        {"Geneva Identification System", "GEN# +1.00170938"},
        {"Smithsonian Astrophysical Observation", "SAO 161585"},
        {"Wilson Evans Batten Catalogue", "WEB 15589"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.15747408),
        dec: Angle.Degrees(-15.70163065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211037"},
        {"Hipparcos Number", "HIP 109832"},
        {"Smithsonian Astrophysical Observation", "SAO 164952"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.68485601),
        dec: Angle.Degrees(-15.70150825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137812"},
        {"Hipparcos Number", "HIP 75762"},
        {"Geneva Identification System", "GEN# +1.00137812"},
        {"Smithsonian Astrophysical Observation", "SAO 159285"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.15996283),
        dec: Angle.Degrees(-15.70072288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5814 AB"},
        {"Henry Draper", "HD 54336"},
        {"Hipparcos Number", "HIP 34393"},
        {"Smithsonian Astrophysical Observation", "SAO 152425"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.96857625),
        dec: Angle.Degrees(-15.70052036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83375"},
        {"Hipparcos Number", "HIP 47240"},
        {"Smithsonian Astrophysical Observation", "SAO 155350"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.42539826),
        dec: Angle.Degrees(-15.69993280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29407"},
        {"Hipparcos Number", "HIP 21521"},
        {"Smithsonian Astrophysical Observation", "SAO 149769"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.31874081),
        dec: Angle.Degrees(-15.69969212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127827"},
        {"Hipparcos Number", "HIP 71220"},
        {"Smithsonian Astrophysical Observation", "SAO 158641"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46559753),
        dec: Angle.Degrees(-15.69691204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205470"},
        {"Hipparcos Number", "HIP 106631"},
        {"Smithsonian Astrophysical Observation", "SAO 164506"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.96941821),
        dec: Angle.Degrees(-15.69626652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88683"},
        {"Hipparcos Number", "HIP 50065"},
        {"Smithsonian Astrophysical Observation", "SAO 155828"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.32771342),
        dec: Angle.Degrees(-15.69473700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53928",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8025 AB"},
        {"Henry Draper", "HD 95626"},
        {"Hipparcos Number", "HIP 53928"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.52402929),
        dec: Angle.Degrees(-15.69248749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111769"},
        {"Hipparcos Number", "HIP 62768"},
        {"Smithsonian Astrophysical Observation", "SAO 157555"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.93669230),
        dec: Angle.Degrees(-15.69227963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5614"},
        {"Smithsonian Astrophysical Observation", "SAO 147667"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.01058006),
        dec: Angle.Degrees(-15.69082160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138077"},
        {"Hipparcos Number", "HIP 75905"},
        {"Smithsonian Astrophysical Observation", "SAO 159300"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.55751511),
        dec: Angle.Degrees(-15.68948490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76050"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.96568761),
        dec: Angle.Degrees(-15.68616041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69371"},
        {"Hipparcos Number", "HIP 40505"},
        {"Geneva Identification System", "GEN# +1.00069371"},
        {"Smithsonian Astrophysical Observation", "SAO 154048"},
        {"Wilson Evans Batten Catalogue", "WEB 7883"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.05033276),
        dec: Angle.Degrees(-15.68602069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54911"},
        {"Hipparcos Number", "HIP 34616"},
        {"Celescope Catalog", "CEL 1636"},
        {"Geneva Identification System", "GEN# +1.00054911"},
        {"Smithsonian Astrophysical Observation", "SAO 152493"},
        {"Wilson Evans Batten Catalogue", "WEB 6928"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53694847),
        dec: Angle.Degrees(-15.68473852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82806"},
        {"Hipparcos Number", "HIP 46946"},
        {"Smithsonian Astrophysical Observation", "SAO 155299"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.51732239),
        dec: Angle.Degrees(-15.68421488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163449"},
        {"Hipparcos Number", "HIP 87849"},
        {"Fundamental Katalog 5th Edition", "FK5 5580"},
        {"Smithsonian Astrophysical Observation", "SAO 160925"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.20017611),
        dec: Angle.Degrees(-15.68390939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4540",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 806 AB"},
        {"Henry Draper", "HD 5659"},
        {"Hipparcos Number", "HIP 4540"},
        {"Geneva Identification System", "GEN# +1.00005659"},
        {"Wilson Evans Batten Catalogue", "WEB 825"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54055021),
        dec: Angle.Degrees(-15.68279377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214027"},
        {"Hipparcos Number", "HIP 111533"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94927701),
        dec: Angle.Degrees(-15.68198121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41367"},
        {"Hipparcos Number", "HIP 28730"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.02543054),
        dec: Angle.Degrees(-15.68143960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61207"},
        {"Hipparcos Number", "HIP 37113"},
        {"Celescope Catalog", "CEL 1954"},
        {"Geneva Identification System", "GEN# +1.00061207"},
        {"Smithsonian Astrophysical Observation", "SAO 153167"},
        {"Wilson Evans Batten Catalogue", "WEB 7359"},
    },
    visualMagnitude: 8.12,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.38829331),
        dec: Angle.Degrees(-15.68143392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11140 AB"},
        {"Henry Draper", "HD 166566"},
        {"Hipparcos Number", "HIP 89170"},
        {"Geneva Identification System", "GEN# +1.00166566J"},
        {"Smithsonian Astrophysical Observation", "SAO 161166"},
        {"Wilson Evans Batten Catalogue", "WEB 15144"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.96212417),
        dec: Angle.Degrees(-15.67985588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153543"},
        {"Hipparcos Number", "HIP 83242"},
        {"Smithsonian Astrophysical Observation", "SAO 160224"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.19276265),
        dec: Angle.Degrees(-15.67973708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12786"},
        {"Hipparcos Number", "HIP 9716"},
        {"Geneva Identification System", "GEN# +1.00012786"},
        {"Smithsonian Astrophysical Observation", "SAO 148190"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.24714248),
        dec: Angle.Degrees(-15.67799402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9672"},
        {"Hipparcos Number", "HIP 7345"},
        {"Geneva Identification System", "GEN# +1.00009672"},
        {"Smithsonian Astrophysical Observation", "SAO 147886"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.65717247),
        dec: Angle.Degrees(-15.67635270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66669"},
        {"Hipparcos Number", "HIP 39467"},
        {"Smithsonian Astrophysical Observation", "SAO 153776"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.00473115),
        dec: Angle.Degrees(-15.67389299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57955",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8332 AB"},
        {"Henry Draper", "HD 103228"},
        {"Hipparcos Number", "HIP 57955"},
        {"Geneva Identification System", "GEN# +1.00103228J"},
        {"Smithsonian Astrophysical Observation", "SAO 156961"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.30262174),
        dec: Angle.Degrees(-15.67375461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140417"},
        {"Hipparcos Number", "HIP 77060"},
        {"Fundamental Katalog 5th Edition", "FK5 3246"},
        {"Geneva Identification System", "GEN# +1.00140417"},
        {"Renson", "Renson 39910"},
        {"Smithsonian Astrophysical Observation", "SAO 159466"},
        {"Wilson Evans Batten Catalogue", "WEB 13070"},
    },
    visualMagnitude: 5.41,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.01841829),
        dec: Angle.Degrees(-15.67267949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197185"},
        {"Hipparcos Number", "HIP 102213"},
        {"Geneva Identification System", "GEN# +1.00197185"},
        {"Smithsonian Astrophysical Observation", "SAO 163812"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.66199576),
        dec: Angle.Degrees(-15.67103016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151676"},
        {"Hipparcos Number", "HIP 82339"},
        {"Geneva Identification System", "GEN# +1.00151676"},
        {"Smithsonian Astrophysical Observation", "SAO 160116"},
        {"Wilson Evans Batten Catalogue", "WEB 13899"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.36528942),
        dec: Angle.Degrees(-15.66800077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58696"},
        {"Hipparcos Number", "HIP 36081"},
        {"Geneva Identification System", "GEN# +1.00058696"},
        {"Smithsonian Astrophysical Observation", "SAO 152865"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.51521081),
        dec: Angle.Degrees(-15.66566543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142273"},
        {"Hipparcos Number", "HIP 77874"},
        {"Smithsonian Astrophysical Observation", "SAO 159569"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.54268799),
        dec: Angle.Degrees(-15.66454575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3594"},
        {"Hipparcos Number", "HIP 3047"},
        {"Geneva Identification System", "GEN# +1.00003594"},
        {"Smithsonian Astrophysical Observation", "SAO 147379"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.68100604),
        dec: Angle.Degrees(-15.66381833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33406"},
        {"Hipparcos Number", "HIP 23988"},
        {"Geneva Identification System", "GEN# +1.00033406"},
        {"Smithsonian Astrophysical Observation", "SAO 150184"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.35306973),
        dec: Angle.Degrees(-15.66358837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44621"},
        {"Hipparcos Number", "HIP 30276"},
        {"Geneva Identification System", "GEN# +1.00044621"},
        {"Smithsonian Astrophysical Observation", "SAO 151419"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.52560982),
        dec: Angle.Degrees(-15.66331777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8589"},
        {"Hipparcos Number", "HIP 6589"},
        {"Geneva Identification System", "GEN# +1.00008589"},
        {"Smithsonian Astrophysical Observation", "SAO 147793"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.16631123),
        dec: Angle.Degrees(-15.66041899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177517"},
        {"Hipparcos Number", "HIP 93763"},
        {"Fundamental Katalog 5th Edition", "FK5 3522"},
        {"Geneva Identification System", "GEN# +1.00177517"},
        {"Renson", "Renson 49500"},
        {"Smithsonian Astrophysical Observation", "SAO 162177"},
        {"Wilson Evans Batten Catalogue", "WEB 16295"},
    },
    visualMagnitude: 5.93,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.42158090),
        dec: Angle.Degrees(-15.66039343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28141"},
        {"Hipparcos Number", "HIP 20682"},
        {"Smithsonian Astrophysical Observation", "SAO 149624"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.45757169),
        dec: Angle.Degrees(-15.65990386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190441"},
        {"Hipparcos Number", "HIP 98949"},
        {"Smithsonian Astrophysical Observation", "SAO 163251"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.35270290),
        dec: Angle.Degrees(-15.65960892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162798"},
        {"Hipparcos Number", "HIP 87574"},
        {"Smithsonian Astrophysical Observation", "SAO 160890"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.36119493),
        dec: Angle.Degrees(-15.65704780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53778"},
        {"Hipparcos Number", "HIP 34306"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.68840339),
        dec: Angle.Degrees(-15.65701670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131790"},
        {"Hipparcos Number", "HIP 73074"},
        {"Geneva Identification System", "GEN# +1.00131790"},
        {"Smithsonian Astrophysical Observation", "SAO 158903"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.01059165),
        dec: Angle.Degrees(-15.65654953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150284"},
        {"Hipparcos Number", "HIP 81631"},
        {"Geneva Identification System", "GEN# +1.00150284"},
        {"Smithsonian Astrophysical Observation", "SAO 160035"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.13413371),
        dec: Angle.Degrees(-15.65637910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15868",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2524 AB"},
        {"Henry Draper", "HD 21161"},
        {"Hipparcos Number", "HIP 15868"},
        {"Geneva Identification System", "GEN# +1.00021161J"},
        {"Smithsonian Astrophysical Observation", "SAO 148944"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.10250510),
        dec: Angle.Degrees(-15.65359309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108523"},
        {"Hipparcos Number", "HIP 60829"},
        {"Cincinnati Publication", "Ci 18 1576"},
        {"Geneva Identification System", "GEN# +1.00108523"},
        {"Smithsonian Astrophysical Observation", "SAO 157304"},
        {"Wilson Evans Batten Catalogue", "WEB 10823"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.01760480),
        dec: Angle.Degrees(-15.65178946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -271.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49322"},
        {"Smithsonian Astrophysical Observation", "SAO 155703"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.01777726),
        dec: Angle.Degrees(-15.64858416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8166 AB"},
        {"Henry Draper", "HD 99565"},
        {"Hipparcos Number", "HIP 55875"},
        {"Geneva Identification System", "GEN# +1.00099565J"},
        {"Smithsonian Astrophysical Observation", "SAO 156686"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.79490639),
        dec: Angle.Degrees(-15.64813453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11396"},
        {"Hipparcos Number", "HIP 8688"},
        {"Smithsonian Astrophysical Observation", "SAO 148069"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.94204315),
        dec: Angle.Degrees(-15.64748397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34069"},
        {"Hipparcos Number", "HIP 24409"},
        {"Smithsonian Astrophysical Observation", "SAO 150261"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.54672558),
        dec: Angle.Degrees(-15.64595121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209879"},
        {"Hipparcos Number", "HIP 109165"},
        {"Wilson Evans Batten Catalogue", "WEB 19624"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.68741199),
        dec: Angle.Degrees(-15.64444426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35305"},
        {"Geneva Identification System", "GEN# +2.23600086"},
        {"New General Catalogue", "NGC 2360 86"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.39612755),
        dec: Angle.Degrees(-15.64318864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71465"},
        {"Hipparcos Number", "HIP 41441"},
        {"Smithsonian Astrophysical Observation", "SAO 154270"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.77252777),
        dec: Angle.Degrees(-15.64266868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15116"},
        {"Smithsonian Astrophysical Observation", "SAO 148856"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73207050),
        dec: Angle.Degrees(-15.64082925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144688"},
        {"Hipparcos Number", "HIP 79013"},
        {"Geneva Identification System", "GEN# +1.00144688"},
        {"Smithsonian Astrophysical Observation", "SAO 159716"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.91877421),
        dec: Angle.Degrees(-15.63994738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117859"},
        {"Smithsonian Astrophysical Observation", "SAO 165949"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.58145200),
        dec: Angle.Degrees(-15.63871260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81377"},
        {"Hipparcos Number", "HIP 46162"},
        {"Smithsonian Astrophysical Observation", "SAO 155158"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.21595345),
        dec: Angle.Degrees(-15.63848550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94656"},
        {"Hipparcos Number", "HIP 53410"},
        {"Smithsonian Astrophysical Observation", "SAO 156329"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.86267955),
        dec: Angle.Degrees(-15.63807772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9291 AB"},
        {"Henry Draper", "HD 127356"},
        {"Hipparcos Number", "HIP 71006"},
        {"Cincinnati Publication", "Ci 20 867"},
        {"Geneva Identification System", "GEN# +1.00127356"},
        {"Smithsonian Astrophysical Observation", "SAO 158612"},
        {"Wilson Evans Batten Catalogue", "WEB 12284"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.83174788),
        dec: Angle.Degrees(-15.63791312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -375.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42746"},
        {"Hipparcos Number", "HIP 29414"},
        {"Smithsonian Astrophysical Observation", "SAO 151212"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.96381418),
        dec: Angle.Degrees(-15.63664941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34045",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Muliphein"},
        {"Henry Draper", "HD 53244"},
        {"Hipparcos Number", "HIP 34045"},
        {"Celescope Catalog", "CEL 1539"},
        {"Fundamental Katalog 5th Edition", "FK5 271"},
        {"Geneva Identification System", "GEN# +5.11210030"},
        {"Renson", "Renson 14650"},
        {"Smithsonian Astrophysical Observation", "SAO 152303"},
        {"Wilson Evans Batten Catalogue", "WEB 6825"},
    },
    visualMagnitude: 4.11,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.93955493),
        dec: Angle.Degrees(-15.63325876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65463",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8893 AB"},
        {"Henry Draper", "HD 116622"},
        {"Hipparcos Number", "HIP 65463"},
        {"Smithsonian Astrophysical Observation", "SAO 157920"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.26564640),
        dec: Angle.Degrees(-15.63232418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37986"},
        {"Hipparcos Number", "HIP 26834"},
        {"Geneva Identification System", "GEN# +1.00037986"},
        {"Smithsonian Astrophysical Observation", "SAO 150708"},
        {"Wilson Evans Batten Catalogue", "WEB 5289"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.47307898),
        dec: Angle.Degrees(-15.63025585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169673"},
        {"Hipparcos Number", "HIP 90369"},
        {"Geneva Identification System", "GEN# +1.00169673"},
        {"Smithsonian Astrophysical Observation", "SAO 161469"},
        {"Wilson Evans Batten Catalogue", "WEB 15469"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.59870745),
        dec: Angle.Degrees(-15.63019124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56847"},
        {"Hipparcos Number", "HIP 35355"},
        {"Geneva Identification System", "GEN# +1.00056847"},
        {"Geneva Identification System 2", "GEN# +2.23600001"},
        {"Smithsonian Astrophysical Observation", "SAO 152691"},
        {"Wilson Evans Batten Catalogue", "WEB 7057"},
        {"New General Catalogue", "NGC 2360 1"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.54016166),
        dec: Angle.Degrees(-15.62832784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7783"},
        {"Hipparcos Number", "HIP 6012"},
        {"Geneva Identification System", "GEN# +1.00007783"},
        {"Smithsonian Astrophysical Observation", "SAO 147717"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33083158),
        dec: Angle.Degrees(-15.62789567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93527"},
        {"Hipparcos Number", "HIP 52792"},
        {"Geneva Identification System", "GEN# +1.00093527A"},
        {"Smithsonian Astrophysical Observation", "SAO 156233"},
        {"Wilson Evans Batten Catalogue", "WEB 9610"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.90228087),
        dec: Angle.Degrees(-15.62668398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216516"},
        {"Hipparcos Number", "HIP 113050"},
        {"Geneva Identification System", "GEN# +1.00216516"},
        {"Smithsonian Astrophysical Observation", "SAO 165361"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.42021651),
        dec: Angle.Degrees(-15.62597951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193689"},
        {"Hipparcos Number", "HIP 100448"},
        {"Smithsonian Astrophysical Observation", "SAO 163499"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55334040),
        dec: Angle.Degrees(-15.62561960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88285"},
        {"Hipparcos Number", "HIP 49837"},
        {"Smithsonian Astrophysical Observation", "SAO 155783"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.63064012),
        dec: Angle.Degrees(-15.62490333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124305"},
        {"Hipparcos Number", "HIP 69455"},
        {"Geneva Identification System", "GEN# +1.00124305"},
        {"Smithsonian Astrophysical Observation", "SAO 158432"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30285280),
        dec: Angle.Degrees(-15.62455258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201104"},
        {"Hipparcos Number", "HIP 104321"},
        {"Smithsonian Astrophysical Observation", "SAO 164158"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.99284813),
        dec: Angle.Degrees(-15.62370555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30001"},
        {"Hipparcos Number", "HIP 21959"},
        {"Smithsonian Astrophysical Observation", "SAO 149843"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.79299533),
        dec: Angle.Degrees(-15.62081809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107108"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.43659196),
        dec: Angle.Degrees(-15.61947282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52793"},
        {"Geneva Identification System", "GEN# +1.00093527B"},
        {"Smithsonian Astrophysical Observation", "SAO 156234"},
        {"Wilson Evans Batten Catalogue", "WEB 9611"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.90380265),
        dec: Angle.Degrees(-15.61833988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80719"},
        {"Hipparcos Number", "HIP 45854"},
        {"Fundamental Katalog 5th Edition", "FK5 2744"},
        {"Geneva Identification System", "GEN# +1.00080719"},
        {"Smithsonian Astrophysical Observation", "SAO 155114"},
        {"Wilson Evans Batten Catalogue", "WEB 8693"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.23106538),
        dec: Angle.Degrees(-15.61756661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118826"},
        {"Hipparcos Number", "HIP 66636"},
        {"Geneva Identification System", "GEN# +1.00118826"},
        {"Smithsonian Astrophysical Observation", "SAO 158072"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.89194605),
        dec: Angle.Degrees(-15.61601423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24218"},
        {"Hipparcos Number", "HIP 17994"},
        {"Smithsonian Astrophysical Observation", "SAO 149206"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.68752072),
        dec: Angle.Degrees(-15.61579849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197944"},
        {"Hipparcos Number", "HIP 102591"},
        {"Smithsonian Astrophysical Observation", "SAO 163879"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.86305026),
        dec: Angle.Degrees(-15.61522211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12539"},
        {"Hipparcos Number", "HIP 9529"},
        {"Smithsonian Astrophysical Observation", "SAO 148166"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.63884356),
        dec: Angle.Degrees(-15.61378379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168227"},
        {"Hipparcos Number", "HIP 89783"},
        {"Geneva Identification System", "GEN# +1.00168227"},
        {"Smithsonian Astrophysical Observation", "SAO 161327"},
        {"Wilson Evans Batten Catalogue", "WEB 15318"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.84089151),
        dec: Angle.Degrees(-15.61279320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15546 A"},
        {"Henry Draper", "HD 209154"},
        {"Hipparcos Number", "HIP 108732"},
        {"Geneva Identification System", "GEN# +1.00209154"},
        {"Smithsonian Astrophysical Observation", "SAO 164819"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.38681984),
        dec: Angle.Degrees(-15.61200786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88025"},
        {"Hipparcos Number", "HIP 49689"},
        {"Geneva Identification System", "GEN# +9.00050012"},
        {"Geneva Identification System 2", "GEN# +9.05000330"},
        {"Smithsonian Astrophysical Observation", "SAO 155763"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.14769563),
        dec: Angle.Degrees(-15.61194678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81373"},
        {"Smithsonian Astrophysical Observation", "SAO 160005"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.28176224),
        dec: Angle.Degrees(-15.61098141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103291"},
        {"Hipparcos Number", "HIP 57991"},
        {"Smithsonian Astrophysical Observation", "SAO 156967"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.42057992),
        dec: Angle.Degrees(-15.60492102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9766"},
        {"Smithsonian Astrophysical Observation", "SAO 148193"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.39022605),
        dec: Angle.Degrees(-15.60424421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175156"},
        {"Hipparcos Number", "HIP 92814"},
        {"Geneva Identification System", "GEN# +1.00175156"},
        {"Renson", "Renson 49010"},
        {"Smithsonian Astrophysical Observation", "SAO 161964"},
        {"Wilson Evans Batten Catalogue", "WEB 16060"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.67964704),
        dec: Angle.Degrees(-15.60302217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212560"},
        {"Hipparcos Number", "HIP 110689"},
        {"Geneva Identification System", "GEN# +1.00212560"},
        {"Smithsonian Astrophysical Observation", "SAO 165062"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.38006366),
        dec: Angle.Degrees(-15.59887225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107001"},
        {"Hipparcos Number", "HIP 60002"},
        {"Geneva Identification System", "GEN# +1.00107001"},
        {"Smithsonian Astrophysical Observation", "SAO 157200"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.59223665),
        dec: Angle.Degrees(-15.59422461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146234"},
        {"Hipparcos Number", "HIP 79687"},
        {"Geneva Identification System", "GEN# +1.00146234"},
        {"Smithsonian Astrophysical Observation", "SAO 159819"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.94799485),
        dec: Angle.Degrees(-15.59394486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49089"},
        {"Hipparcos Number", "HIP 32425"},
        {"Celescope Catalog", "CEL 1379"},
        {"Geneva Identification System", "GEN# +1.00049089"},
        {"Smithsonian Astrophysical Observation", "SAO 151900"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.52953952),
        dec: Angle.Degrees(-15.59138373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40969"},
        {"Hipparcos Number", "HIP 28553"},
        {"Fundamental Katalog 5th Edition", "FK5 4548"},
        {"Smithsonian Astrophysical Observation", "SAO 151033"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.41343841),
        dec: Angle.Degrees(-15.58925302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56405"},
        {"Hipparcos Number", "HIP 35180"},
        {"Celescope Catalog", "CEL 1729"},
        {"Fundamental Katalog 5th Edition", "FK5 2561"},
        {"Geneva Identification System", "GEN# +1.00056405"},
        {"Smithsonian Astrophysical Observation", "SAO 152641"},
        {"Wilson Evans Batten Catalogue", "WEB 7027"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.06075146),
        dec: Angle.Degrees(-15.58565483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116218"},
        {"Smithsonian Astrophysical Observation", "SAO 165757"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.21488858),
        dec: Angle.Degrees(-15.58524854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215451"},
        {"Hipparcos Number", "HIP 112356"},
        {"Smithsonian Astrophysical Observation", "SAO 165275"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.36661832),
        dec: Angle.Degrees(-15.58330577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12026",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1966 AB"},
        {"Henry Draper", "HD 16132"},
        {"Hipparcos Number", "HIP 12026"},
        {"Smithsonian Astrophysical Observation", "SAO 148480"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.77136018),
        dec: Angle.Degrees(-15.58316626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11122"},
        {"Hipparcos Number", "HIP 8459"},
        {"Smithsonian Astrophysical Observation", "SAO 148029"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.27118598),
        dec: Angle.Degrees(-15.58184870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64921"},
        {"Hipparcos Number", "HIP 38718"},
        {"Smithsonian Astrophysical Observation", "SAO 153593"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.89931633),
        dec: Angle.Degrees(-15.57873027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9565 A"},
        {"Henry Draper", "HD 135703"},
        {"Hipparcos Number", "HIP 74786"},
        {"Smithsonian Astrophysical Observation", "SAO 159151"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.25654262),
        dec: Angle.Degrees(-15.57737728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82232"},
        {"Hipparcos Number", "HIP 46618"},
        {"Geneva Identification System", "GEN# +1.00082232"},
        {"Smithsonian Astrophysical Observation", "SAO 155246"},
        {"Wilson Evans Batten Catalogue", "WEB 8795"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.59391346),
        dec: Angle.Degrees(-15.57719292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109709"},
        {"Hipparcos Number", "HIP 61562"},
        {"Smithsonian Astrophysical Observation", "SAO 157397"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.21175092),
        dec: Angle.Degrees(-15.57238768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159877"},
        {"Hipparcos Number", "HIP 86266"},
        {"Geneva Identification System", "GEN# +1.00159877"},
        {"Renson", "Renson 45002"},
        {"Smithsonian Astrophysical Observation", "SAO 160701"},
        {"Wilson Evans Batten Catalogue", "WEB 14550"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.40085142),
        dec: Angle.Degrees(-15.57103656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67835"},
        {"Hipparcos Number", "HIP 39928"},
        {"Geneva Identification System", "GEN# +1.00067835"},
        {"Renson", "Renson 18700"},
        {"Smithsonian Astrophysical Observation", "SAO 153895"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.31922725),
        dec: Angle.Degrees(-15.57016582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36579"},
        {"Hipparcos Number", "HIP 25939"},
        {"Smithsonian Astrophysical Observation", "SAO 150539"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.03324531),
        dec: Angle.Degrees(-15.56952302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181614"},
        {"Hipparcos Number", "HIP 95175"},
        {"Smithsonian Astrophysical Observation", "SAO 162519"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.43050087),
        dec: Angle.Degrees(-15.56868861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115739"},
        {"Hipparcos Number", "HIP 64993"},
        {"Smithsonian Astrophysical Observation", "SAO 157854"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.82350486),
        dec: Angle.Degrees(-15.56734289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140032"},
        {"Hipparcos Number", "HIP 76895"},
        {"Smithsonian Astrophysical Observation", "SAO 159444"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.50812614),
        dec: Angle.Degrees(-15.56671310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75393"},
        {"Hipparcos Number", "HIP 43299"},
        {"Geneva Identification System", "GEN# +1.00075393"},
        {"Smithsonian Astrophysical Observation", "SAO 154658"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.31389314),
        dec: Angle.Degrees(-15.56467840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27722"},
        {"Hipparcos Number", "HIP 20394"},
        {"Smithsonian Astrophysical Observation", "SAO 149584"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.50070402),
        dec: Angle.Degrees(-15.56334482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16643 AB"},
        {"Henry Draper", "HD 219544"},
        {"Hipparcos Number", "HIP 114919"},
        {"Smithsonian Astrophysical Observation", "SAO 165599"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.16344800),
        dec: Angle.Degrees(-15.56184962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96765"},
        {"Hipparcos Number", "HIP 54462"},
        {"Smithsonian Astrophysical Observation", "SAO 156485"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.14410339),
        dec: Angle.Degrees(-15.56133404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155663"},
        {"Hipparcos Number", "HIP 84269"},
        {"Geneva Identification System", "GEN# +1.00155663"},
        {"Smithsonian Astrophysical Observation", "SAO 160380"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.40304282),
        dec: Angle.Degrees(-15.56028752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184616"},
        {"Hipparcos Number", "HIP 96389"},
        {"Smithsonian Astrophysical Observation", "SAO 162801"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.95604787),
        dec: Angle.Degrees(-15.55957762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139954"},
        {"Hipparcos Number", "HIP 76857"},
        {"Smithsonian Astrophysical Observation", "SAO 159439"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.41820646),
        dec: Angle.Degrees(-15.55934236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160825"},
        {"Hipparcos Number", "HIP 86683"},
        {"Smithsonian Astrophysical Observation", "SAO 160769"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.66761325),
        dec: Angle.Degrees(-15.55921921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107642"},
        {"Hipparcos Number", "HIP 60338"},
        {"Smithsonian Astrophysical Observation", "SAO 157240"},
        {"Wilson Evans Batten Catalogue", "WEB 10730"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.57696827),
        dec: Angle.Degrees(-15.55535220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20637"},
        {"Hipparcos Number", "HIP 15425"},
        {"Smithsonian Astrophysical Observation", "SAO 148898"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.70624589),
        dec: Angle.Degrees(-15.55135625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166126"},
        {"Hipparcos Number", "HIP 88994"},
        {"Geneva Identification System", "GEN# +1.00166126"},
        {"Smithsonian Astrophysical Observation", "SAO 161128"},
        {"Wilson Evans Batten Catalogue", "WEB 15097"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.46102555),
        dec: Angle.Degrees(-15.55007988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136407"},
        {"Hipparcos Number", "HIP 75118"},
        {"Geneva Identification System", "GEN# +1.00136407"},
        {"Smithsonian Astrophysical Observation", "SAO 159191"},
        {"Wilson Evans Batten Catalogue", "WEB 12812"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.25566834),
        dec: Angle.Degrees(-15.54838584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22111"},
        {"Hipparcos Number", "HIP 16559"},
        {"Smithsonian Astrophysical Observation", "SAO 149033"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30384745),
        dec: Angle.Degrees(-15.54824746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115467"},
        {"Hipparcos Number", "HIP 64843"},
        {"Smithsonian Astrophysical Observation", "SAO 157838"},
        {"Wilson Evans Batten Catalogue", "WEB 11460"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.38241225),
        dec: Angle.Degrees(-15.54792587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146935"},
        {"Hipparcos Number", "HIP 79972"},
        {"Fundamental Katalog 5th Edition", "FK5 5440"},
        {"Geneva Identification System", "GEN# +1.00146935"},
        {"Smithsonian Astrophysical Observation", "SAO 159848"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.85446420),
        dec: Angle.Degrees(-15.54603420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137974"},
        {"Hipparcos Number", "HIP 75851"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.40334591),
        dec: Angle.Degrees(-15.53749824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110980"},
        {"Hipparcos Number", "HIP 62302"},
        {"Smithsonian Astrophysical Observation", "SAO 157495"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50261092),
        dec: Angle.Degrees(-15.53606407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180928"},
        {"Hipparcos Number", "HIP 94929"},
        {"Geneva Identification System", "GEN# +1.00180928"},
        {"Smithsonian Astrophysical Observation", "SAO 162462"},
        {"Wilson Evans Batten Catalogue", "WEB 16571"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.75062622),
        dec: Angle.Degrees(-15.53588580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141324"},
        {"Hipparcos Number", "HIP 77471"},
        {"Wilson Evans Batten Catalogue", "WEB 13119"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.27109417),
        dec: Angle.Degrees(-15.53573282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160440"},
        {"Hipparcos Number", "HIP 86496"},
        {"Smithsonian Astrophysical Observation", "SAO 160735"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.13579716),
        dec: Angle.Degrees(-15.53081499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149244"},
        {"Hipparcos Number", "HIP 81117"},
        {"Smithsonian Astrophysical Observation", "SAO 159980"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.50931454),
        dec: Angle.Degrees(-15.52707928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53228"},
    },
    visualMagnitude: 11.45,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.31402211),
        dec: Angle.Degrees(-15.52482689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65098"},
        {"Hipparcos Number", "HIP 38808"},
        {"Smithsonian Astrophysical Observation", "SAO 153611"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.13371468),
        dec: Angle.Degrees(-15.52437162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121301"},
        {"Hipparcos Number", "HIP 67961"},
        {"Smithsonian Astrophysical Observation", "SAO 158232"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.76629308),
        dec: Angle.Degrees(-15.52424357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -173.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40089"},
        {"Hipparcos Number", "HIP 28080"},
        {"Geneva Identification System", "GEN# +1.00040089"},
        {"Smithsonian Astrophysical Observation", "SAO 150953"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.03978548),
        dec: Angle.Degrees(-15.52225306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172772"},
        {"Hipparcos Number", "HIP 91758"},
        {"Geneva Identification System", "GEN# +1.00172772"},
        {"Smithsonian Astrophysical Observation", "SAO 161751"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.66586922),
        dec: Angle.Degrees(-15.52187083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45421"},
        {"Hipparcos Number", "HIP 30662"},
        {"Smithsonian Astrophysical Observation", "SAO 151510"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.65354486),
        dec: Angle.Degrees(-15.51736111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139118"},
        {"Hipparcos Number", "HIP 76458"},
        {"Smithsonian Astrophysical Observation", "SAO 159382"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.22607599),
        dec: Angle.Degrees(-15.51398497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100566"},
        {"Hipparcos Number", "HIP 56441"},
        {"Geneva Identification System", "GEN# +1.00100566"},
        {"Smithsonian Astrophysical Observation", "SAO 156758"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.57998005),
        dec: Angle.Degrees(-15.51208709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198407"},
        {"Hipparcos Number", "HIP 102875"},
        {"Geneva Identification System", "GEN# +1.00198407"},
        {"Smithsonian Astrophysical Observation", "SAO 163921"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.64937778),
        dec: Angle.Degrees(-15.51089687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6616"},
        {"Hipparcos Number", "HIP 5219"},
        {"Fundamental Katalog 5th Edition", "FK5 2070"},
        {"Geneva Identification System", "GEN# +1.00006616"},
        {"Smithsonian Astrophysical Observation", "SAO 147612"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.68482196),
        dec: Angle.Degrees(-15.51024951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20561"},
        {"Hipparcos Number", "HIP 15349"},
        {"Smithsonian Astrophysical Observation", "SAO 148891"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.48426727),
        dec: Angle.Degrees(-15.50876658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110887"},
        {"Hipparcos Number", "HIP 62258"},
        {"Geneva Identification System", "GEN# +1.00110887"},
        {"Smithsonian Astrophysical Observation", "SAO 157491"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.37742332),
        dec: Angle.Degrees(-15.50835758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80030"},
        {"Hipparcos Number", "HIP 45552"},
        {"Smithsonian Astrophysical Observation", "SAO 155059"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.26054226),
        dec: Angle.Degrees(-15.50748072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52717"},
        {"Smithsonian Astrophysical Observation", "SAO 156218"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.67155909),
        dec: Angle.Degrees(-15.50686810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39441"},
        {"Hipparcos Number", "HIP 27707"},
        {"Smithsonian Astrophysical Observation", "SAO 150884"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.00606455),
        dec: Angle.Degrees(-15.50617264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7808"},
        {"Hipparcos Number", "HIP 6037"},
        {"Cincinnati Publication", "Ci 20 92"},
        {"Geneva Identification System", "GEN# +1.00007808"},
        {"Smithsonian Astrophysical Observation", "SAO 147721"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.39106895),
        dec: Angle.Degrees(-15.50216373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -475.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13286"},
        {"Smithsonian Astrophysical Observation", "SAO 148639"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.75296796),
        dec: Angle.Degrees(-15.50213222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55538"},
        {"Hipparcos Number", "HIP 34852"},
        {"Celescope Catalog", "CEL 1674"},
        {"Geneva Identification System", "GEN# +1.00055538"},
        {"Smithsonian Astrophysical Observation", "SAO 152558"},
        {"Wilson Evans Batten Catalogue", "WEB 6970"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.18949481),
        dec: Angle.Degrees(-15.50179071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38702"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.84952869),
        dec: Angle.Degrees(-15.49837006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133316"},
        {"Hipparcos Number", "HIP 73724"},
        {"Smithsonian Astrophysical Observation", "SAO 159001"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.05932857),
        dec: Angle.Degrees(-15.49760444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191622"},
        {"Hipparcos Number", "HIP 99474"},
        {"Smithsonian Astrophysical Observation", "SAO 163322"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82605660),
        dec: Angle.Degrees(-15.49702018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81043"},
        {"Hipparcos Number", "HIP 46002"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.73590897),
        dec: Angle.Degrees(-15.49566553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81980"},
        {"Geneva Identification System", "GEN# -0.01504383"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.20606630),
        dec: Angle.Degrees(-15.49534755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88084"},
        {"Hipparcos Number", "HIP 49728"},
        {"Smithsonian Astrophysical Observation", "SAO 155769"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28459471),
        dec: Angle.Degrees(-15.49401639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42966"},
        {"Hipparcos Number", "HIP 29520"},
        {"Smithsonian Astrophysical Observation", "SAO 151232"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.28084330),
        dec: Angle.Degrees(-15.49339755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188899"},
        {"Hipparcos Number", "HIP 98258"},
        {"Fundamental Katalog 5th Edition", "FK5 1522"},
        {"Geneva Identification System", "GEN# +1.00188899"},
        {"Smithsonian Astrophysical Observation", "SAO 163141"},
        {"Wilson Evans Batten Catalogue", "WEB 17332"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.48758471),
        dec: Angle.Degrees(-15.49126255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33290"},
        {"Hipparcos Number", "HIP 23936"},
        {"Smithsonian Astrophysical Observation", "SAO 150174"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.16034047),
        dec: Angle.Degrees(-15.49072774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2655"},
        {"Geneva Identification System", "GEN# -0.01600090"},
        {"Wilson Evans Batten Catalogue", "WEB 484"},
    },
    visualMagnitude: 11.42,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.40956800),
        dec: Angle.Degrees(-15.48730165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122772"},
        {"Hipparcos Number", "HIP 68729"},
        {"Smithsonian Astrophysical Observation", "SAO 158321"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.03161814),
        dec: Angle.Degrees(-15.48608347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22619"},
        {"Hipparcos Number", "HIP 16921"},
        {"Geneva Identification System", "GEN# +1.00022619"},
        {"Smithsonian Astrophysical Observation", "SAO 149071"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.43932029),
        dec: Angle.Degrees(-15.48486589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89707"},
        {"Hipparcos Number", "HIP 50671"},
        {"Geneva Identification System", "GEN# +9.00050019"},
        {"Smithsonian Astrophysical Observation", "SAO 155919"},
        {"Wilson Evans Batten Catalogue", "WEB 9286"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20881114),
        dec: Angle.Degrees(-15.48063354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 296.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142803"},
        {"Hipparcos Number", "HIP 78115"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.26173307),
        dec: Angle.Degrees(-15.47852399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142984"},
        {"Hipparcos Number", "HIP 78211"},
        {"Smithsonian Astrophysical Observation", "SAO 159608"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.56294018),
        dec: Angle.Degrees(-15.47784955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92090",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11647 AB"},
        {"Henry Draper", "HD 173479"},
        {"Hipparcos Number", "HIP 92090"},
        {"Smithsonian Astrophysical Observation", "SAO 161807"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.52407516),
        dec: Angle.Degrees(-15.47607885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35035",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5925 AB"},
        {"Henry Draper", "HD 56012"},
        {"Hipparcos Number", "HIP 35035"},
        {"Geneva Identification System", "GEN# +1.00056012J"},
        {"Smithsonian Astrophysical Observation", "SAO 152609"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70107529),
        dec: Angle.Degrees(-15.47597692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1269"},
        {"Hipparcos Number", "HIP 1351"},
        {"Smithsonian Astrophysical Observation", "SAO 147197"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.22489310),
        dec: Angle.Degrees(-15.47419000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200213"},
        {"Hipparcos Number", "HIP 103847"},
        {"Geneva Identification System", "GEN# +1.00200213"},
        {"Smithsonian Astrophysical Observation", "SAO 164082"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.64286850),
        dec: Angle.Degrees(-15.47387827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8438"},
        {"Smithsonian Astrophysical Observation", "SAO 148023"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.19480460),
        dec: Angle.Degrees(-15.47285748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33071"},
        {"Smithsonian Astrophysical Observation", "SAO 152053"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.31581853),
        dec: Angle.Degrees(-15.47263496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35034",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5925 C"},
        {"Hipparcos Number", "HIP 35034"},
        {"Geneva Identification System", "GEN# +1.00056012C"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70126733),
        dec: Angle.Degrees(-15.47163426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186185"},
        {"Hipparcos Number", "HIP 97063"},
        {"Geneva Identification System", "GEN# +1.00186185"},
        {"Smithsonian Astrophysical Observation", "SAO 162931"},
        {"Wilson Evans Batten Catalogue", "WEB 17032"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.88936752),
        dec: Angle.Degrees(-15.46965541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35720"},
        {"Hipparcos Number", "HIP 25415"},
        {"Geneva Identification System", "GEN# +1.00035720"},
        {"Smithsonian Astrophysical Observation", "SAO 150444"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.54084575),
        dec: Angle.Degrees(-15.46872436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144364"},
        {"Hipparcos Number", "HIP 78879"},
        {"Smithsonian Astrophysical Observation", "SAO 159687"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.52778564),
        dec: Angle.Degrees(-15.46858888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 693"},
        {"Hipparcos Number", "HIP 910"},
        {"Geneva Identification System", "GEN# +1.00000693"},
        {"Smithsonian Astrophysical Observation", "SAO 147133"},
        {"Wilson Evans Batten Catalogue", "WEB 158"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.81628415),
        dec: Angle.Degrees(-15.46732287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42174"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96397529),
        dec: Angle.Degrees(-15.46725751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 214.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144909"},
        {"Hipparcos Number", "HIP 79107"},
        {"Geneva Identification System", "GEN# +1.00144909"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20234203),
        dec: Angle.Degrees(-15.46576083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110502"},
        {"Hipparcos Number", "HIP 62024"},
        {"Smithsonian Astrophysical Observation", "SAO 157461"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.70495020),
        dec: Angle.Degrees(-15.46415879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222592"},
        {"Hipparcos Number", "HIP 116922"},
        {"Geneva Identification System", "GEN# +1.00222592"},
        {"Smithsonian Astrophysical Observation", "SAO 165839"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.49230872),
        dec: Angle.Degrees(-15.46329787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10099"},
        {"Hipparcos Number", "HIP 7642"},
        {"Geneva Identification System", "GEN# +1.00010099"},
        {"Smithsonian Astrophysical Observation", "SAO 147922"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.61167233),
        dec: Angle.Degrees(-15.46240628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57559",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8309 AB"},
        {"Henry Draper", "HD 102513"},
        {"Hipparcos Number", "HIP 57559"},
        {"Smithsonian Astrophysical Observation", "SAO 156893"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.97143579),
        dec: Angle.Degrees(-15.46183464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133294"},
        {"Hipparcos Number", "HIP 73720"},
        {"Geneva Identification System", "GEN# +1.00133294"},
        {"Smithsonian Astrophysical Observation", "SAO 159000"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.03729327),
        dec: Angle.Degrees(-15.46142910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64504",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8822 AB"},
        {"Henry Draper", "HD 114827"},
        {"Hipparcos Number", "HIP 64504"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.31477937),
        dec: Angle.Degrees(-15.46046828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72194",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9376 A"},
        {"Henry Draper", "HD 129978"},
        {"Hipparcos Number", "HIP 72194"},
        {"Fundamental Katalog 5th Edition", "FK5 5308"},
        {"Geneva Identification System", "GEN# +1.00129978"},
        {"Smithsonian Astrophysical Observation", "SAO 158788"},
        {"Wilson Evans Batten Catalogue", "WEB 12420"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.49074975),
        dec: Angle.Degrees(-15.45954466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78997"},
        {"Hipparcos Number", "HIP 45076"},
        {"Smithsonian Astrophysical Observation", "SAO 154978"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.72933576),
        dec: Angle.Degrees(-15.45940743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20924"},
        {"Hipparcos Number", "HIP 15677"},
        {"Smithsonian Astrophysical Observation", "SAO 148921"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.49496732),
        dec: Angle.Degrees(-15.45871479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106094"},
        {"Hipparcos Number", "HIP 59537"},
        {"Geneva Identification System", "GEN# +1.00106094"},
        {"Smithsonian Astrophysical Observation", "SAO 157148"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12515616),
        dec: Angle.Degrees(-15.45770495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101971"},
        {"Hipparcos Number", "HIP 57231"},
        {"Smithsonian Astrophysical Observation", "SAO 156862"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.01702432),
        dec: Angle.Degrees(-15.45580252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110328"},
        {"Hipparcos Number", "HIP 61922"},
        {"Smithsonian Astrophysical Observation", "SAO 157449"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.35869616),
        dec: Angle.Degrees(-15.45534654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87827"},
        {"Hipparcos Number", "HIP 49582"},
        {"Geneva Identification System", "GEN# +1.00087827"},
        {"Smithsonian Astrophysical Observation", "SAO 155743"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.83283605),
        dec: Angle.Degrees(-15.45529858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8646"},
        {"Smithsonian Astrophysical Observation", "SAO 148061"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86786191),
        dec: Angle.Degrees(-15.45514859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84854"},
        {"Smithsonian Astrophysical Observation", "SAO 160477"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.13749149),
        dec: Angle.Degrees(-15.45478695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2393"},
        {"Hipparcos Number", "HIP 2183"},
        {"Geneva Identification System", "GEN# +1.00002393"},
        {"Smithsonian Astrophysical Observation", "SAO 147285"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.89685525),
        dec: Angle.Degrees(-15.45438007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188827"},
        {"Hipparcos Number", "HIP 98219"},
        {"Geneva Identification System", "GEN# +1.00188827"},
        {"Smithsonian Astrophysical Observation", "SAO 163137"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.39401352),
        dec: Angle.Degrees(-15.45423604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86913"},
        {"Hipparcos Number", "HIP 49110"},
        {"Smithsonian Astrophysical Observation", "SAO 155661"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.34245634),
        dec: Angle.Degrees(-15.45407119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60308"},
        {"Hipparcos Number", "HIP 36727"},
        {"Geneva Identification System", "GEN# +1.00060308"},
        {"Geneva Identification System 2", "GEN# +2.24140001"},
        {"Smithsonian Astrophysical Observation", "SAO 153056"},
        {"Wilson Evans Batten Catalogue", "WEB 7300"},
        {"New General Catalogue", "NGC 2414 1"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.30401201),
        dec: Angle.Degrees(-15.45361440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43068"},
        {"Hipparcos Number", "HIP 29557"},
        {"Geneva Identification System", "GEN# +1.00043068"},
        {"Smithsonian Astrophysical Observation", "SAO 151246"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.41888638),
        dec: Angle.Degrees(-15.45271572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218159"},
        {"Hipparcos Number", "HIP 114055"},
        {"Smithsonian Astrophysical Observation", "SAO 165488"},
        {"Wilson Evans Batten Catalogue", "WEB 20254"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.47033225),
        dec: Angle.Degrees(-15.45261064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212142"},
        {"Hipparcos Number", "HIP 110454"},
        {"Geneva Identification System", "GEN# +1.00212142"},
        {"Smithsonian Astrophysical Observation", "SAO 165027"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.59361882),
        dec: Angle.Degrees(-15.45107246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9434"},
        {"Hipparcos Number", "HIP 7181"},
        {"Smithsonian Astrophysical Observation", "SAO 147873"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.13177836),
        dec: Angle.Degrees(-15.45083100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222643"},
        {"Hipparcos Number", "HIP 116957"},
        {"Geneva Identification System", "GEN# +1.00222643"},
        {"Smithsonian Astrophysical Observation", "SAO 165841"},
        {"Wilson Evans Batten Catalogue", "WEB 20630"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.61588872),
        dec: Angle.Degrees(-15.44797581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146215"},
        {"Hipparcos Number", "HIP 79679"},
        {"Geneva Identification System", "GEN# +1.00146215"},
        {"Smithsonian Astrophysical Observation", "SAO 159817"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.93021120),
        dec: Angle.Degrees(-15.44656361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12944"},
        {"Hipparcos Number", "HIP 9819"},
        {"Smithsonian Astrophysical Observation", "SAO 148201"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.58405832),
        dec: Angle.Degrees(-15.44618935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94386"},
        {"Hipparcos Number", "HIP 53259"},
        {"Geneva Identification System", "GEN# +1.00094386"},
        {"Smithsonian Astrophysical Observation", "SAO 156302"},
        {"Wilson Evans Batten Catalogue", "WEB 9666"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.38693326),
        dec: Angle.Degrees(-15.44568573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137274"},
        {"Hipparcos Number", "HIP 75514"},
        {"Geneva Identification System", "GEN# +1.00137274"},
        {"Smithsonian Astrophysical Observation", "SAO 159250"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.40536399),
        dec: Angle.Degrees(-15.44550418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6253"},
        {"Hipparcos Number", "HIP 4937"},
        {"Geneva Identification System", "GEN# +1.00006253"},
        {"Smithsonian Astrophysical Observation", "SAO 147584"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.84277348),
        dec: Angle.Degrees(-15.44330755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62884"},
        {"Hipparcos Number", "HIP 37849"},
        {"Smithsonian Astrophysical Observation", "SAO 153365"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.38814803),
        dec: Angle.Degrees(-15.44290447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13329"},
        {"Smithsonian Astrophysical Observation", "SAO 148641"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.87880807),
        dec: Angle.Degrees(-15.44275599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111016"},
        {"Hipparcos Number", "HIP 62343"},
        {"Smithsonian Astrophysical Observation", "SAO 157501"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.62606637),
        dec: Angle.Degrees(-15.44054879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154497"},
        {"Hipparcos Number", "HIP 83695"},
        {"Smithsonian Astrophysical Observation", "SAO 160277"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.58840408),
        dec: Angle.Degrees(-15.44034321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26119"},
        {"Hipparcos Number", "HIP 19251"},
        {"Smithsonian Astrophysical Observation", "SAO 149387"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.87557312),
        dec: Angle.Degrees(-15.44023678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76478"},
        {"Hipparcos Number", "HIP 43850"},
        {"Smithsonian Astrophysical Observation", "SAO 154760"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.97702167),
        dec: Angle.Degrees(-15.43943077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84025"},
        {"Hipparcos Number", "HIP 47567"},
        {"Smithsonian Astrophysical Observation", "SAO 155411"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.48504793),
        dec: Angle.Degrees(-15.43798895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49648"},
        {"Hipparcos Number", "HIP 32670"},
        {"Smithsonian Astrophysical Observation", "SAO 151959"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.21070133),
        dec: Angle.Degrees(-15.43653379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132310"},
        {"Hipparcos Number", "HIP 73308"},
        {"Smithsonian Astrophysical Observation", "SAO 158944"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.71982086),
        dec: Angle.Degrees(-15.43631212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19803"},
        {"Hipparcos Number", "HIP 14772"},
        {"Smithsonian Astrophysical Observation", "SAO 148809"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.67385031),
        dec: Angle.Degrees(-15.43617493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8096 AB"},
        {"Henry Draper", "HD 97635"},
        {"Hipparcos Number", "HIP 54866"},
        {"Smithsonian Astrophysical Observation", "SAO 156552"},
        {"Wilson Evans Batten Catalogue", "WEB 9903"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.51524460),
        dec: Angle.Degrees(-15.43531045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40710"},
        {"Smithsonian Astrophysical Observation", "SAO 154095"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.64569643),
        dec: Angle.Degrees(-15.43242872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85674"},
        {"Smithsonian Astrophysical Observation", "SAO 160592"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.62145551),
        dec: Angle.Degrees(-15.43235654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192031"},
        {"Hipparcos Number", "HIP 99651"},
        {"Cincinnati Publication", "Ci 18 2637"},
        {"Cincinnati Publication 2", "Ci 20 1197"},
        {"Geneva Identification System", "GEN# +1.00192031J"},
        {"Smithsonian Astrophysical Observation", "SAO 163356"},
        {"Wilson Evans Batten Catalogue", "WEB 17862"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.34491602),
        dec: Angle.Degrees(-15.43146074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -322.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -266.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218105"},
        {"Hipparcos Number", "HIP 114016"},
        {"Geneva Identification System", "GEN# +1.00218105"},
        {"Smithsonian Astrophysical Observation", "SAO 165483"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.35141595),
        dec: Angle.Degrees(-15.43115646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167838"},
        {"Hipparcos Number", "HIP 89641"},
        {"Geneva Identification System", "GEN# +1.00167838"},
        {"Smithsonian Astrophysical Observation", "SAO 161275"},
        {"Wilson Evans Batten Catalogue", "WEB 15270"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.40712962),
        dec: Angle.Degrees(-15.43070964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71254"},
        {"Hipparcos Number", "HIP 41314"},
        {"Smithsonian Astrophysical Observation", "SAO 154243"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.44883457),
        dec: Angle.Degrees(-15.43020201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95271"},
        {"Hipparcos Number", "HIP 53758"},
        {"Smithsonian Astrophysical Observation", "SAO 156376"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.97726074),
        dec: Angle.Degrees(-15.42983540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193477"},
        {"Hipparcos Number", "HIP 100342"},
        {"Smithsonian Astrophysical Observation", "SAO 163480"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.24720185),
        dec: Angle.Degrees(-15.42858812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64294"},
        {"Hipparcos Number", "HIP 38453"},
        {"Smithsonian Astrophysical Observation", "SAO 153527"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.15804157),
        dec: Angle.Degrees(-15.42795427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17205"},
        {"Hipparcos Number", "HIP 12850"},
        {"Geneva Identification System", "GEN# +1.00017205"},
        {"Smithsonian Astrophysical Observation", "SAO 148586"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.30200564),
        dec: Angle.Degrees(-15.42675070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208045"},
        {"Hipparcos Number", "HIP 108078"},
        {"Smithsonian Astrophysical Observation", "SAO 164723"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.46564815),
        dec: Angle.Degrees(-15.42644944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151786"},
        {"Hipparcos Number", "HIP 82384"},
        {"Geneva Identification System", "GEN# +1.00151786"},
        {"Smithsonian Astrophysical Observation", "SAO 160120"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51525946),
        dec: Angle.Degrees(-15.42629419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102734"},
        {"Hipparcos Number", "HIP 57668"},
        {"Smithsonian Astrophysical Observation", "SAO 156917"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.41616015),
        dec: Angle.Degrees(-15.42495195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86972"},
        {"Hipparcos Number", "HIP 49127"},
        {"Geneva Identification System", "GEN# +1.00086972"},
        {"Smithsonian Astrophysical Observation", "SAO 155666"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.40602848),
        dec: Angle.Degrees(-15.42485736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -252.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74704"},
        {"Hipparcos Number", "HIP 42935"},
        {"Geneva Identification System", "GEN# +1.00074704"},
        {"Smithsonian Astrophysical Observation", "SAO 154603"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.26974593),
        dec: Angle.Degrees(-15.42464798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12103"},
        {"Hipparcos Number", "HIP 9216"},
        {"Geneva Identification System", "GEN# +1.00012103"},
        {"Smithsonian Astrophysical Observation", "SAO 148137"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.62471524),
        dec: Angle.Degrees(-15.42374181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190501"},
        {"Hipparcos Number", "HIP 98986"},
        {"Smithsonian Astrophysical Observation", "SAO 163255"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.43026781),
        dec: Angle.Degrees(-15.42324962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187440"},
        {"Hipparcos Number", "HIP 97620"},
        {"Smithsonian Astrophysical Observation", "SAO 163029"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.61374742),
        dec: Angle.Degrees(-15.42283529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222394"},
        {"Hipparcos Number", "HIP 116792"},
        {"Smithsonian Astrophysical Observation", "SAO 165822"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.05781940),
        dec: Angle.Degrees(-15.42115687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105729"},
        {"Hipparcos Number", "HIP 59326"},
        {"Smithsonian Astrophysical Observation", "SAO 157122"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.55666954),
        dec: Angle.Degrees(-15.42073766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79308"},
        {"Hipparcos Number", "HIP 45223"},
        {"Geneva Identification System", "GEN# +1.00079308"},
        {"Smithsonian Astrophysical Observation", "SAO 155003"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.23868203),
        dec: Angle.Degrees(-15.41934647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133913"},
        {"Hipparcos Number", "HIP 74007"},
        {"Geneva Identification System", "GEN# +1.00133913"},
        {"Smithsonian Astrophysical Observation", "SAO 159034"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.85832603),
        dec: Angle.Degrees(-15.41668527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137651"},
        {"Hipparcos Number", "HIP 75684"},
        {"Smithsonian Astrophysical Observation", "SAO 159276"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92655461),
        dec: Angle.Degrees(-15.41585473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61533"},
        {"Smithsonian Astrophysical Observation", "SAO 157392"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.09931095),
        dec: Angle.Degrees(-15.41478836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116332"},
        {"Hipparcos Number", "HIP 65313"},
        {"Smithsonian Astrophysical Observation", "SAO 157904"},
        {"Wilson Evans Batten Catalogue", "WEB 11530"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.79144429),
        dec: Angle.Degrees(-15.41448471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190033"},
        {"Hipparcos Number", "HIP 98760"},
        {"Geneva Identification System", "GEN# +1.00190033"},
        {"Smithsonian Astrophysical Observation", "SAO 163213"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.88907774),
        dec: Angle.Degrees(-15.41333753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143424"},
        {"Hipparcos Number", "HIP 78430"},
        {"Geneva Identification System", "GEN# +1.00143424"},
        {"Smithsonian Astrophysical Observation", "SAO 159630"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.17856100),
        dec: Angle.Degrees(-15.41229651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191130"},
        {"Hipparcos Number", "HIP 99249"},
        {"Smithsonian Astrophysical Observation", "SAO 163293"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.20639935),
        dec: Angle.Degrees(-15.41213554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38239"},
        {"Smithsonian Astrophysical Observation", "SAO 153465"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.50617462),
        dec: Angle.Degrees(-15.41181446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114252"},
        {"Geneva Identification System", "GEN# -0.01606218"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.08119329),
        dec: Angle.Degrees(-15.40988872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40355"},
        {"Hipparcos Number", "HIP 28211"},
        {"Smithsonian Astrophysical Observation", "SAO 150973"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.41492269),
        dec: Angle.Degrees(-15.40613640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188489"},
        {"Hipparcos Number", "HIP 98075"},
        {"Smithsonian Astrophysical Observation", "SAO 163113"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98387557),
        dec: Angle.Degrees(-15.40476858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44040"},
        {"Hipparcos Number", "HIP 30016"},
        {"Smithsonian Astrophysical Observation", "SAO 151348"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74975473),
        dec: Angle.Degrees(-15.40365281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9856"},
        {"Hipparcos Number", "HIP 7450"},
        {"Fundamental Katalog 5th Edition", "FK5 2104"},
        {"Geneva Identification System", "GEN# +1.00009856"},
        {"Smithsonian Astrophysical Observation", "SAO 147901"},
        {"Wilson Evans Batten Catalogue", "WEB 1595"},
    },
    visualMagnitude: 5.41,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.99565496),
        dec: Angle.Degrees(-15.40021584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52436"},
        {"Hipparcos Number", "HIP 33750"},
        {"Smithsonian Astrophysical Observation", "SAO 152235"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.16084908),
        dec: Angle.Degrees(-15.39869159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159876"},
        {"Hipparcos Number", "HIP 86263"},
        {"Fundamental Katalog 5th Edition", "FK5 658"},
        {"Geneva Identification System", "GEN# +1.00159876"},
        {"Renson", "Renson 45000"},
        {"Smithsonian Astrophysical Observation", "SAO 160700"},
        {"Wilson Evans Batten Catalogue", "WEB 14549"},
    },
    visualMagnitude: 3.54,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.39677181),
        dec: Angle.Degrees(-15.39840835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205636"},
        {"Hipparcos Number", "HIP 106710"},
        {"Smithsonian Astrophysical Observation", "SAO 164517"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.23528371),
        dec: Angle.Degrees(-15.39725858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4782"},
        {"Hipparcos Number", "HIP 3866"},
        {"Geneva Identification System", "GEN# +1.00004782"},
        {"Smithsonian Astrophysical Observation", "SAO 147467"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.41225482),
        dec: Angle.Degrees(-15.39595889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55885"},
        {"Hipparcos Number", "HIP 34986"},
        {"Celescope Catalog", "CEL 1694"},
        {"Wilson Evans Batten Catalogue", "WEB 6995"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.58277657),
        dec: Angle.Degrees(-15.39545386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169291"},
        {"Hipparcos Number", "HIP 90232"},
        {"Smithsonian Astrophysical Observation", "SAO 161441"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.16377879),
        dec: Angle.Degrees(-15.39236128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84610"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.42932413),
        dec: Angle.Degrees(-15.39210106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77268"},
        {"Hipparcos Number", "HIP 44284"},
        {"Smithsonian Astrophysical Observation", "SAO 154839"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.28776373),
        dec: Angle.Degrees(-15.39136984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102911"},
        {"Hipparcos Number", "HIP 57775"},
        {"Smithsonian Astrophysical Observation", "SAO 156932"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.71087434),
        dec: Angle.Degrees(-15.38893339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131196"},
        {"Hipparcos Number", "HIP 72769"},
        {"Geneva Identification System", "GEN# +1.00131196"},
        {"Smithsonian Astrophysical Observation", "SAO 158870"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.13245224),
        dec: Angle.Degrees(-15.38769084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4234"},
        {"Hipparcos Number", "HIP 3503"},
        {"Smithsonian Astrophysical Observation", "SAO 147426"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.17792723),
        dec: Angle.Degrees(-15.38647100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76054"},
        {"Hipparcos Number", "HIP 43647"},
        {"Smithsonian Astrophysical Observation", "SAO 154718"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.34696647),
        dec: Angle.Degrees(-15.38550126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52749"},
        {"Hipparcos Number", "HIP 33872"},
        {"Smithsonian Astrophysical Observation", "SAO 152258"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.46909561),
        dec: Angle.Degrees(-15.38473861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167246"},
        {"Hipparcos Number", "HIP 89422"},
        {"Smithsonian Astrophysical Observation", "SAO 161212"},
        {"Wilson Evans Batten Catalogue", "WEB 15212"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.74064622),
        dec: Angle.Degrees(-15.38473618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43028"},
        {"Hipparcos Number", "HIP 29536"},
        {"Smithsonian Astrophysical Observation", "SAO 151241"},
        {"Wilson Evans Batten Catalogue", "WEB 5805"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.35283414),
        dec: Angle.Degrees(-15.38412152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85462"},
        {"Hipparcos Number", "HIP 48360"},
        {"Smithsonian Astrophysical Observation", "SAO 155543"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.88840595),
        dec: Angle.Degrees(-15.38405285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60742"},
        {"Hipparcos Number", "HIP 36918"},
        {"Smithsonian Astrophysical Observation", "SAO 153104"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.84816934),
        dec: Angle.Degrees(-15.38251153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26302"},
        {"Smithsonian Astrophysical Observation", "SAO 150598"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.01624694),
        dec: Angle.Degrees(-15.38151476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31585"},
        {"Hipparcos Number", "HIP 22962"},
        {"Geneva Identification System", "GEN# +1.00031585"},
        {"Smithsonian Astrophysical Observation", "SAO 150008"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.10945711),
        dec: Angle.Degrees(-15.38078161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13002",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2129 AB"},
        {"Henry Draper", "HD 17404"},
        {"Henry Draper 2", "HD 17405"},
        {"Hipparcos Number", "HIP 13002"},
        {"Smithsonian Astrophysical Observation", "SAO 148603"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.78856104),
        dec: Angle.Degrees(-15.37721579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101999"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.05217061),
        dec: Angle.Degrees(-15.37493028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217534"},
        {"Hipparcos Number", "HIP 113685"},
        {"Smithsonian Astrophysical Observation", "SAO 165444"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.38145060),
        dec: Angle.Degrees(-15.37431652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136406"},
        {"Hipparcos Number", "HIP 75112"},
        {"Smithsonian Astrophysical Observation", "SAO 159188"},
        {"Wilson Evans Batten Catalogue", "WEB 12811"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.23824703),
        dec: Angle.Degrees(-15.37372155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169915"},
        {"Hipparcos Number", "HIP 90459"},
        {"Geneva Identification System", "GEN# +1.00169915"},
        {"Smithsonian Astrophysical Observation", "SAO 161490"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.88036665),
        dec: Angle.Degrees(-15.37370215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11146 AB"},
        {"Henry Draper", "HD 166716"},
        {"Hipparcos Number", "HIP 89223"},
        {"Geneva Identification System", "GEN# +1.00166716"},
        {"Smithsonian Astrophysical Observation", "SAO 161181"},
        {"Wilson Evans Batten Catalogue", "WEB 15165"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.11875770),
        dec: Angle.Degrees(-15.37324297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23541"},
        {"Hipparcos Number", "HIP 17550"},
        {"Smithsonian Astrophysical Observation", "SAO 149150"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.38048878),
        dec: Angle.Degrees(-15.37314289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92707"},
        {"Hipparcos Number", "HIP 52361"},
        {"Smithsonian Astrophysical Observation", "SAO 156165"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.52193167),
        dec: Angle.Degrees(-15.37070748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72079"},
        {"Hipparcos Number", "HIP 41711"},
        {"Smithsonian Astrophysical Observation", "SAO 154325"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.59456634),
        dec: Angle.Degrees(-15.36733447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88"},
        {"Hipparcos Number", "HIP 480"},
        {"Smithsonian Astrophysical Observation", "SAO 147076"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.43016919),
        dec: Angle.Degrees(-15.36550173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21383"},
        {"Hipparcos Number", "HIP 16030"},
        {"Smithsonian Astrophysical Observation", "SAO 148959"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.60059945),
        dec: Angle.Degrees(-15.36321086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117789"},
        {"Hipparcos Number", "HIP 66091"},
        {"Geneva Identification System", "GEN# +1.00117789"},
        {"Smithsonian Astrophysical Observation", "SAO 157998"},
        {"Wilson Evans Batten Catalogue", "WEB 11679"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.21536872),
        dec: Angle.Degrees(-15.36301232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165049"},
        {"Hipparcos Number", "HIP 88532"},
        {"Geneva Identification System", "GEN# +1.00165049"},
        {"Smithsonian Astrophysical Observation", "SAO 161042"},
        {"Wilson Evans Batten Catalogue", "WEB 14988"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.17874243),
        dec: Angle.Degrees(-15.36232443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96553"},
        {"Hipparcos Number", "HIP 54366"},
        {"Geneva Identification System", "GEN# +1.00096553"},
        {"Smithsonian Astrophysical Observation", "SAO 156473"},
        {"Wilson Evans Batten Catalogue", "WEB 9819"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.83846295),
        dec: Angle.Degrees(-15.36074220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 132.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3305"},
        {"Geneva Identification System", "GEN# -0.01600117"},
        {"Renson", "Renson 1070"},
        {"Smithsonian Astrophysical Observation", "SAO 147406"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53417811),
        dec: Angle.Degrees(-15.36053811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183306"},
        {"Hipparcos Number", "HIP 95842"},
        {"Smithsonian Astrophysical Observation", "SAO 162669"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.39089783),
        dec: Angle.Degrees(-15.35873373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114382"},
        {"Hipparcos Number", "HIP 64268"},
        {"Smithsonian Astrophysical Observation", "SAO 157765"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58608131),
        dec: Angle.Degrees(-15.35806683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152817"},
        {"Hipparcos Number", "HIP 82877"},
        {"Smithsonian Astrophysical Observation", "SAO 160172"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.06692739),
        dec: Angle.Degrees(-15.35754406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35633"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.30028356),
        dec: Angle.Degrees(-15.35739878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 336.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212587"},
        {"Hipparcos Number", "HIP 110701"},
        {"Geneva Identification System", "GEN# +1.00212587"},
        {"Smithsonian Astrophysical Observation", "SAO 165065"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.43409279),
        dec: Angle.Degrees(-15.35719300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150344"},
        {"Hipparcos Number", "HIP 81671"},
        {"Fundamental Katalog 5th Edition", "FK5 5474"},
        {"Geneva Identification System", "GEN# +1.00150344"},
        {"Smithsonian Astrophysical Observation", "SAO 160040"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.26270861),
        dec: Angle.Degrees(-15.35700115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124498"},
        {"Hipparcos Number", "HIP 69562"},
        {"Geneva Identification System", "GEN# +1.00124498J"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58950988),
        dec: Angle.Degrees(-15.35562260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85232"},
        {"Smithsonian Astrophysical Observation", "SAO 160530"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.24397489),
        dec: Angle.Degrees(-15.35271122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8211"},
        {"Hipparcos Number", "HIP 6330"},
        {"Smithsonian Astrophysical Observation", "SAO 147755"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.32260455),
        dec: Angle.Degrees(-15.34702872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13093"},
        {"Hipparcos Number", "HIP 9925"},
        {"Smithsonian Astrophysical Observation", "SAO 148221"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.94628190),
        dec: Angle.Degrees(-15.34610089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63656"},
        {"Hipparcos Number", "HIP 38185"},
        {"Smithsonian Astrophysical Observation", "SAO 153450"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37013109),
        dec: Angle.Degrees(-15.34540738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1849 A"},
        {"Henry Draper", "HD 15144"},
        {"Hipparcos Number", "HIP 11348"},
        {"Renson", "Renson 3770"},
        {"Smithsonian Astrophysical Observation", "SAO 148386"},
        {"Wilson Evans Batten Catalogue", "WEB 2371"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.50156687),
        dec: Angle.Degrees(-15.34111517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131696"},
        {"Hipparcos Number", "HIP 73032"},
        {"Smithsonian Astrophysical Observation", "SAO 158894"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.88699362),
        dec: Angle.Degrees(-15.34028319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37946"},
        {"Hipparcos Number", "HIP 26808"},
        {"Geneva Identification System", "GEN# +1.00037946"},
        {"Smithsonian Astrophysical Observation", "SAO 150700"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.39644267),
        dec: Angle.Degrees(-15.33751899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192266"},
        {"Hipparcos Number", "HIP 99773"},
        {"Geneva Identification System", "GEN# +1.00192266"},
        {"Smithsonian Astrophysical Observation", "SAO 163371"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.64505437),
        dec: Angle.Degrees(-15.33485275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186646"},
        {"Hipparcos Number", "HIP 97273"},
        {"Smithsonian Astrophysical Observation", "SAO 162960"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.53827896),
        dec: Angle.Degrees(-15.33334680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110514"},
        {"Geneva Identification System", "GEN# -0.01606074"},
        {"Wilson Evans Batten Catalogue", "WEB 19809"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.81641437),
        dec: Angle.Degrees(-15.33224250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32628",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5473 A"},
        {"Henry Draper", "HD 49548"},
        {"Hipparcos Number", "HIP 32628"},
        {"Celescope Catalog", "CEL 1389"},
        {"Geneva Identification System", "GEN# +1.00049548"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.09229738),
        dec: Angle.Degrees(-15.32980187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174800"},
        {"Hipparcos Number", "HIP 92660"},
        {"Geneva Identification System", "GEN# +1.00174800"},
        {"Smithsonian Astrophysical Observation", "SAO 161932"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.23148314),
        dec: Angle.Degrees(-15.32942616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46829"},
        {"Hipparcos Number", "HIP 31401"},
        {"Smithsonian Astrophysical Observation", "SAO 151662"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.73178296),
        dec: Angle.Degrees(-15.32879143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146543"},
        {"Hipparcos Number", "HIP 79813"},
        {"Geneva Identification System", "GEN# +1.00146543"},
        {"Smithsonian Astrophysical Observation", "SAO 159831"},
        {"Wilson Evans Batten Catalogue", "WEB 13509"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.33716619),
        dec: Angle.Degrees(-15.32796513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112304"},
        {"Hipparcos Number", "HIP 63109"},
        {"Fundamental Katalog 5th Edition", "FK5 3033"},
        {"Geneva Identification System", "GEN# +1.00112304"},
        {"Smithsonian Astrophysical Observation", "SAO 157599"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.97189424),
        dec: Angle.Degrees(-15.32702221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53340"},
        {"Hipparcos Number", "HIP 34097"},
        {"Celescope Catalog", "CEL 1548"},
        {"Geneva Identification System", "GEN# +1.00053340"},
        {"Smithsonian Astrophysical Observation", "SAO 152318"},
        {"Wilson Evans Batten Catalogue", "WEB 6838"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.05050122),
        dec: Angle.Degrees(-15.32684718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138547"},
        {"Hipparcos Number", "HIP 76152"},
        {"Wilson Evans Batten Catalogue", "WEB 12936"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.31879800),
        dec: Angle.Degrees(-15.32638773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89456"},
        {"Hipparcos Number", "HIP 50521"},
        {"Geneva Identification System", "GEN# +9.00050013"},
        {"Smithsonian Astrophysical Observation", "SAO 155891"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.77856946),
        dec: Angle.Degrees(-15.32594956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3192"},
        {"Smithsonian Astrophysical Observation", "SAO 147398"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.16994038),
        dec: Angle.Degrees(-15.32576923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184016"},
        {"Hipparcos Number", "HIP 96134"},
        {"Smithsonian Astrophysical Observation", "SAO 162744"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.20685343),
        dec: Angle.Degrees(-15.32312612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100022"},
        {"Hipparcos Number", "HIP 56139"},
        {"Smithsonian Astrophysical Observation", "SAO 156720"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60887118),
        dec: Angle.Degrees(-15.32220747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129064"},
        {"Hipparcos Number", "HIP 71773"},
        {"Smithsonian Astrophysical Observation", "SAO 158725"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.22538387),
        dec: Angle.Degrees(-15.32024705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45522"},
        {"Hipparcos Number", "HIP 30730"},
        {"Smithsonian Astrophysical Observation", "SAO 151523"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.84002762),
        dec: Angle.Degrees(-15.31598484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13433"},
        {"Hipparcos Number", "HIP 10185"},
        {"Geneva Identification System", "GEN# +1.00013433"},
        {"Smithsonian Astrophysical Observation", "SAO 148254"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.73523402),
        dec: Angle.Degrees(-15.31475297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176202"},
        {"Hipparcos Number", "HIP 93254"},
        {"Smithsonian Astrophysical Observation", "SAO 162060"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.93240562),
        dec: Angle.Degrees(-15.31275210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101649",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14044 AB"},
        {"Henry Draper", "HD 196204"},
        {"Hipparcos Number", "HIP 101649"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.07663731),
        dec: Angle.Degrees(-15.31127865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183447"},
        {"Hipparcos Number", "HIP 95892"},
        {"Renson", "Renson 50656"},
        {"Smithsonian Astrophysical Observation", "SAO 162691"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.53545465),
        dec: Angle.Degrees(-15.30802606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81917"},
        {"Smithsonian Astrophysical Observation", "SAO 160068"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.98356743),
        dec: Angle.Degrees(-15.30755665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5087 A"},
        {"Henry Draper", "HD 45566"},
        {"Hipparcos Number", "HIP 30743"},
        {"Smithsonian Astrophysical Observation", "SAO 151525"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.90358330),
        dec: Angle.Degrees(-15.30617302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12583"},
        {"Hipparcos Number", "HIP 9572"},
        {"Fundamental Katalog 5th Edition", "FK5 2141"},
        {"Geneva Identification System", "GEN# +1.00012583"},
        {"Smithsonian Astrophysical Observation", "SAO 148170"},
        {"Wilson Evans Batten Catalogue", "WEB 2011"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.74397324),
        dec: Angle.Degrees(-15.30594985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216374"},
        {"Hipparcos Number", "HIP 112959"},
        {"Smithsonian Astrophysical Observation", "SAO 165352"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14991851),
        dec: Angle.Degrees(-15.30571228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118560"},
        {"Hipparcos Number", "HIP 66504"},
        {"Smithsonian Astrophysical Observation", "SAO 158051"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.49199817),
        dec: Angle.Degrees(-15.30457925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199183"},
        {"Hipparcos Number", "HIP 103326"},
        {"Smithsonian Astrophysical Observation", "SAO 163992"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.99903975),
        dec: Angle.Degrees(-15.30386082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15444"},
        {"Hipparcos Number", "HIP 11546"},
        {"Smithsonian Astrophysical Observation", "SAO 148409"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.19718311),
        dec: Angle.Degrees(-15.29942824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220935"},
        {"Hipparcos Number", "HIP 115827"},
        {"Smithsonian Astrophysical Observation", "SAO 165707"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.98523843),
        dec: Angle.Degrees(-15.29919250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221856"},
        {"Hipparcos Number", "HIP 116438"},
        {"Smithsonian Astrophysical Observation", "SAO 165787"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.92446034),
        dec: Angle.Degrees(-15.29897201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173926"},
        {"Hipparcos Number", "HIP 92292"},
        {"Smithsonian Astrophysical Observation", "SAO 161846"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.15458734),
        dec: Angle.Degrees(-15.29533071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71099"},
        {"Hipparcos Number", "HIP 41252"},
        {"Geneva Identification System", "GEN# +1.00071099"},
        {"Smithsonian Astrophysical Observation", "SAO 154231"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.24322474),
        dec: Angle.Degrees(-15.29420029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220543"},
        {"Hipparcos Number", "HIP 115570"},
        {"Smithsonian Astrophysical Observation", "SAO 165678"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.15615320),
        dec: Angle.Degrees(-15.29266514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165098"},
        {"Hipparcos Number", "HIP 88558"},
        {"Geneva Identification System", "GEN# +1.00165098"},
        {"Smithsonian Astrophysical Observation", "SAO 161048"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.23932693),
        dec: Angle.Degrees(-15.28861254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17371"},
        {"Hipparcos Number", "HIP 12974"},
        {"Smithsonian Astrophysical Observation", "SAO 148597"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.71925844),
        dec: Angle.Degrees(-15.28695876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222800"},
        {"Hipparcos Number", "HIP 117054"},
        {"Geneva Identification System", "GEN# +1.00222800"},
        {"Smithsonian Astrophysical Observation", "SAO 165849"},
        {"Wilson Evans Batten Catalogue", "WEB 20637"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.95600683),
        dec: Angle.Degrees(-15.28442126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199047"},
        {"Hipparcos Number", "HIP 103240"},
        {"Geneva Identification System", "GEN# +1.00199047"},
        {"Smithsonian Astrophysical Observation", "SAO 163976"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.73348015),
        dec: Angle.Degrees(-15.28308697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104801"},
        {"Hipparcos Number", "HIP 58841"},
        {"Smithsonian Astrophysical Observation", "SAO 157071"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02252113),
        dec: Angle.Degrees(-15.28292338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176593"},
        {"Hipparcos Number", "HIP 93418"},
        {"Geneva Identification System", "GEN# +1.00176593"},
        {"Smithsonian Astrophysical Observation", "SAO 162097"},
        {"Wilson Evans Batten Catalogue", "WEB 16211"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.38966244),
        dec: Angle.Degrees(-15.28261438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117593"},
        {"Hipparcos Number", "HIP 65983"},
        {"Smithsonian Astrophysical Observation", "SAO 157983"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.91974379),
        dec: Angle.Degrees(-15.27786142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66353"},
        {"Hipparcos Number", "HIP 39347"},
        {"Smithsonian Astrophysical Observation", "SAO 153749"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.64878277),
        dec: Angle.Degrees(-15.27396327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173012"},
        {"Hipparcos Number", "HIP 91871"},
        {"Smithsonian Astrophysical Observation", "SAO 161770"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.93984193),
        dec: Angle.Degrees(-15.27370509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15767"},
        {"Hipparcos Number", "HIP 11759"},
        {"Geneva Identification System", "GEN# +1.00015767"},
        {"Smithsonian Astrophysical Observation", "SAO 148443"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.92715509),
        dec: Angle.Degrees(-15.27316563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18955"},
        {"Hipparcos Number", "HIP 14157"},
        {"Geneva Identification System", "GEN# +1.00018955"},
        {"Smithsonian Astrophysical Observation", "SAO 148731"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.63592436),
        dec: Angle.Degrees(-15.27273494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85336"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.58193281),
        dec: Angle.Degrees(-15.27157935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14563"},
        {"Hipparcos Number", "HIP 10931"},
        {"Smithsonian Astrophysical Observation", "SAO 148341"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.19770305),
        dec: Angle.Degrees(-15.26989406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214687"},
        {"Hipparcos Number", "HIP 111913"},
        {"Smithsonian Astrophysical Observation", "SAO 165226"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.03874388),
        dec: Angle.Degrees(-15.26976501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128944"},
        {"Hipparcos Number", "HIP 71715"},
        {"Smithsonian Astrophysical Observation", "SAO 158716"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.04119493),
        dec: Angle.Degrees(-15.26854803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154280"},
        {"Hipparcos Number", "HIP 83588"},
        {"Smithsonian Astrophysical Observation", "SAO 160267"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.26308032),
        dec: Angle.Degrees(-15.26697667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61772"},
        {"Hipparcos Number", "HIP 37379"},
        {"Geneva Identification System", "GEN# +1.00061772"},
        {"Smithsonian Astrophysical Observation", "SAO 153227"},
        {"Wilson Evans Batten Catalogue", "WEB 7397"},
    },
    visualMagnitude: 4.98,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.09671685),
        dec: Angle.Degrees(-15.26385208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41952"},
        {"Hipparcos Number", "HIP 29028"},
        {"Smithsonian Astrophysical Observation", "SAO 151138"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.86648790),
        dec: Angle.Degrees(-15.26221269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52795",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7930 A"},
        {"Henry Draper", "HD 93526"},
        {"Hipparcos Number", "HIP 52795"},
        {"Geneva Identification System", "GEN# +1.00093526A"},
        {"Renson", "Renson 27040"},
        {"Smithsonian Astrophysical Observation", "SAO 156235"},
        {"Wilson Evans Batten Catalogue", "WEB 9609"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.90805587),
        dec: Angle.Degrees(-15.26192754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57234"},
        {"Hipparcos Number", "HIP 35507"},
        {"Fundamental Katalog 5th Edition", "FK5 4660"},
        {"Geneva Identification System", "GEN# +1.00057234"},
        {"Smithsonian Astrophysical Observation", "SAO 152728"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.94018086),
        dec: Angle.Degrees(-15.26056417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157745"},
        {"Hipparcos Number", "HIP 85288"},
        {"Smithsonian Astrophysical Observation", "SAO 160538"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.42015964),
        dec: Angle.Degrees(-15.26025038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52347"},
        {"Hipparcos Number", "HIP 33727"},
        {"Celescope Catalog", "CEL 1494"},
        {"Geneva Identification System", "GEN# +1.00052347"},
        {"Smithsonian Astrophysical Observation", "SAO 152229"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.09757517),
        dec: Angle.Degrees(-15.25886610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208209"},
        {"Hipparcos Number", "HIP 108176"},
        {"Smithsonian Astrophysical Observation", "SAO 164737"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.75121559),
        dec: Angle.Degrees(-15.25801118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66126"},
        {"Hipparcos Number", "HIP 39245"},
        {"Smithsonian Astrophysical Observation", "SAO 153729"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.39535939),
        dec: Angle.Degrees(-15.25547205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38757"},
        {"Hipparcos Number", "HIP 27342"},
        {"Smithsonian Astrophysical Observation", "SAO 150817"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.86416995),
        dec: Angle.Degrees(-15.25223306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38233"},
        {"Smithsonian Astrophysical Observation", "SAO 153463"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.49230789),
        dec: Angle.Degrees(-15.25018967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23683"},
        {"Hipparcos Number", "HIP 17623"},
        {"Smithsonian Astrophysical Observation", "SAO 149163"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.63197852),
        dec: Angle.Degrees(-15.24889040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35931"},
        {"Hipparcos Number", "HIP 25529"},
        {"Smithsonian Astrophysical Observation", "SAO 150470"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.88614667),
        dec: Angle.Degrees(-15.24882480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127170"},
        {"Hipparcos Number", "HIP 70923"},
        {"Geneva Identification System", "GEN# +1.00127170"},
        {"Smithsonian Astrophysical Observation", "SAO 158603"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.55829081),
        dec: Angle.Degrees(-15.24857130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115742",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16758 AB"},
        {"Henry Draper", "HD 220811"},
        {"Hipparcos Number", "HIP 115742"},
        {"Smithsonian Astrophysical Observation", "SAO 165698"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.73767994),
        dec: Angle.Degrees(-15.24769754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221745"},
        {"Hipparcos Number", "HIP 116368"},
        {"Geneva Identification System", "GEN# +1.00221745"},
        {"Smithsonian Astrophysical Observation", "SAO 165780"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.70554420),
        dec: Angle.Degrees(-15.24579181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204057"},
        {"Hipparcos Number", "HIP 105861"},
        {"Fundamental Katalog 5th Edition", "FK5 5890"},
        {"Smithsonian Astrophysical Observation", "SAO 164387"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61277059),
        dec: Angle.Degrees(-15.24524359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15798"},
        {"Hipparcos Number", "HIP 11783"},
        {"Fundamental Katalog 5th Edition", "FK5 1071"},
        {"Geneva Identification System", "GEN# +1.00015798"},
        {"Smithsonian Astrophysical Observation", "SAO 148445"},
        {"Wilson Evans Batten Catalogue", "WEB 2444"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.02198846),
        dec: Angle.Degrees(-15.24431990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206983"},
        {"Hipparcos Number", "HIP 107478"},
        {"Geneva Identification System", "GEN# +1.00206983"},
        {"Smithsonian Astrophysical Observation", "SAO 164633"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.53894326),
        dec: Angle.Degrees(-15.24423163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52800",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 6.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)47, 39.9900),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)14, 38.300)
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
    primaryId: "HIP 81892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150766"},
        {"Hipparcos Number", "HIP 81892"},
        {"Geneva Identification System", "GEN# +1.00150766"},
        {"Smithsonian Astrophysical Observation", "SAO 160062"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.91235546),
        dec: Angle.Degrees(-15.24373889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54763"},
        {"Hipparcos Number", "HIP 34568"},
        {"Geneva Identification System", "GEN# +1.00054763"},
        {"Smithsonian Astrophysical Observation", "SAO 152478"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.39898369),
        dec: Angle.Degrees(-15.24317465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12095",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1975 AB"},
        {"Henry Draper", "HD 16224"},
        {"Hipparcos Number", "HIP 12095"},
        {"Smithsonian Astrophysical Observation", "SAO 148490"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97056896),
        dec: Angle.Degrees(-15.24170250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143034"},
        {"Hipparcos Number", "HIP 78239"},
        {"Geneva Identification System", "GEN# +1.00143034"},
        {"Smithsonian Astrophysical Observation", "SAO 159613"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63406548),
        dec: Angle.Degrees(-15.23906874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110453"},
        {"Hipparcos Number", "HIP 62001"},
        {"Smithsonian Astrophysical Observation", "SAO 157455"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.60247978),
        dec: Angle.Degrees(-15.23784681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125338"},
        {"Hipparcos Number", "HIP 69984"},
        {"Smithsonian Astrophysical Observation", "SAO 158491"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.80352646),
        dec: Angle.Degrees(-15.23713146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14756"},
        {"Hipparcos Number", "HIP 11066"},
        {"Geneva Identification System", "GEN# +1.00014756"},
        {"Smithsonian Astrophysical Observation", "SAO 148359"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.61099708),
        dec: Angle.Degrees(-15.23659985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140987"},
        {"Hipparcos Number", "HIP 77318"},
        {"Geneva Identification System", "GEN# +1.00140987"},
        {"Smithsonian Astrophysical Observation", "SAO 159490"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.77626262),
        dec: Angle.Degrees(-15.23659546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106834"},
        {"Hipparcos Number", "HIP 59903"},
        {"Geneva Identification System", "GEN# +1.00106834"},
        {"Smithsonian Astrophysical Observation", "SAO 157185"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.30308033),
        dec: Angle.Degrees(-15.23590471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80970"},
        {"Hipparcos Number", "HIP 45975"},
        {"Smithsonian Astrophysical Observation", "SAO 155130"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.63429550),
        dec: Angle.Degrees(-15.23478898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178140"},
        {"Hipparcos Number", "HIP 93967"},
        {"Cincinnati Publication", "Ci 18 2493"},
        {"Geneva Identification System", "GEN# +1.00178140"},
        {"Smithsonian Astrophysical Observation", "SAO 162221"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.99158015),
        dec: Angle.Degrees(-15.23356273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134699"},
        {"Hipparcos Number", "HIP 74361"},
        {"Fundamental Katalog 5th Edition", "FK5 5351"},
        {"Smithsonian Astrophysical Observation", "SAO 159084"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95122232),
        dec: Angle.Degrees(-15.23141197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7891"},
        {"Smithsonian Astrophysical Observation", "SAO 147960"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.38155439),
        dec: Angle.Degrees(-15.23076184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168567"},
        {"Hipparcos Number", "HIP 89938"},
        {"Geneva Identification System", "GEN# +1.00168567"},
        {"Smithsonian Astrophysical Observation", "SAO 161370"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.25950656),
        dec: Angle.Degrees(-15.23067034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103755"},
        {"Wilson Evans Batten Catalogue", "WEB 18883"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.37023808),
        dec: Angle.Degrees(-15.22920938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30620"},
        {"Hipparcos Number", "HIP 22344"},
        {"Geneva Identification System", "GEN# +1.00030620"},
        {"Smithsonian Astrophysical Observation", "SAO 149903"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16824192),
        dec: Angle.Degrees(-15.22766679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130398"},
        {"Hipparcos Number", "HIP 72417"},
        {"Smithsonian Astrophysical Observation", "SAO 158811"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.10578254),
        dec: Angle.Degrees(-15.22674575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220714"},
        {"Hipparcos Number", "HIP 115673"},
        {"Smithsonian Astrophysical Observation", "SAO 165688"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.53146785),
        dec: Angle.Degrees(-15.22669818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22905"},
        {"Hipparcos Number", "HIP 17136"},
        {"Fundamental Katalog 5th Edition", "FK5 2259"},
        {"Geneva Identification System", "GEN# +1.00022905"},
        {"Smithsonian Astrophysical Observation", "SAO 149094"},
        {"Wilson Evans Batten Catalogue", "WEB 3248"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.04766529),
        dec: Angle.Degrees(-15.22649985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104264"},
        {"Hipparcos Number", "HIP 58549"},
        {"Smithsonian Astrophysical Observation", "SAO 157036"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.09224482),
        dec: Angle.Degrees(-15.22487117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156115"},
        {"Hipparcos Number", "HIP 84481"},
        {"Geneva Identification System", "GEN# +1.00156115"},
        {"Smithsonian Astrophysical Observation", "SAO 160413"},
        {"Wilson Evans Batten Catalogue", "WEB 14260"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.06622498),
        dec: Angle.Degrees(-15.22374114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143556"},
        {"Hipparcos Number", "HIP 78503"},
        {"Smithsonian Astrophysical Observation", "SAO 159639"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.40068138),
        dec: Angle.Degrees(-15.22195278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156586"},
        {"Hipparcos Number", "HIP 84712"},
        {"Fundamental Katalog 5th Edition", "FK5 5528"},
        {"Geneva Identification System", "GEN# +1.00156586"},
        {"Smithsonian Astrophysical Observation", "SAO 160451"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.74129315),
        dec: Angle.Degrees(-15.22005192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24670",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3883 A"},
        {"Henry Draper", "HD 34527"},
        {"Hipparcos Number", "HIP 24670"},
        {"Smithsonian Astrophysical Observation", "SAO 150303"},
        {"Wilson Evans Batten Catalogue", "WEB 4777"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.39791697),
        dec: Angle.Degrees(-15.21957290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155265"},
        {"Hipparcos Number", "HIP 84058"},
        {"Smithsonian Astrophysical Observation", "SAO 160342"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.77572499),
        dec: Angle.Degrees(-15.21801542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5629"},
        {"Hipparcos Number", "HIP 4521"},
        {"Smithsonian Astrophysical Observation", "SAO 147539"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47926562),
        dec: Angle.Degrees(-15.21635000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21668"},
        {"Smithsonian Astrophysical Observation", "SAO 149794"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.77209915),
        dec: Angle.Degrees(-15.21621310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3883 B"},
        {"Henry Draper", "HD 34527B"},
        {"Hipparcos Number", "HIP 24669"},
        {"Smithsonian Astrophysical Observation", "SAO 150302"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.39313812),
        dec: Angle.Degrees(-15.21618431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48286"},
        {"Hipparcos Number", "HIP 32076"},
        {"Geneva Identification System", "GEN# +1.00048286"},
        {"Smithsonian Astrophysical Observation", "SAO 151809"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.52211785),
        dec: Angle.Degrees(-15.21493958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222079"},
        {"Hipparcos Number", "HIP 116590"},
        {"Smithsonian Astrophysical Observation", "SAO 165803"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.40881683),
        dec: Angle.Degrees(-15.21464754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58128"},
        {"Hipparcos Number", "HIP 35862"},
        {"Smithsonian Astrophysical Observation", "SAO 152811"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.90531051),
        dec: Angle.Degrees(-15.21343340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21499"},
        {"Hipparcos Number", "HIP 16111"},
        {"Smithsonian Astrophysical Observation", "SAO 148968"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.88849221),
        dec: Angle.Degrees(-15.21040969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223315"},
        {"Hipparcos Number", "HIP 117427"},
        {"Geneva Identification System", "GEN# +1.00223315"},
        {"Smithsonian Astrophysical Observation", "SAO 165895"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.15333363),
        dec: Angle.Degrees(-15.21039345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123985"},
        {"Hipparcos Number", "HIP 69312"},
        {"Smithsonian Astrophysical Observation", "SAO 158410"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.80692935),
        dec: Angle.Degrees(-15.21037625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50326"},
        {"Hipparcos Number", "HIP 32981"},
        {"Smithsonian Astrophysical Observation", "SAO 152032"},
        {"Wilson Evans Batten Catalogue", "WEB 6639"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.05625972),
        dec: Angle.Degrees(-15.20884197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118778"},
        {"Hipparcos Number", "HIP 66619"},
        {"Geneva Identification System", "GEN# +1.00118778"},
        {"Smithsonian Astrophysical Observation", "SAO 158070"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.83368303),
        dec: Angle.Degrees(-15.20859871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92527"},
        {"Hipparcos Number", "HIP 52272"},
        {"Smithsonian Astrophysical Observation", "SAO 156155"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.21011866),
        dec: Angle.Degrees(-15.20798300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36514"},
        {"Hipparcos Number", "HIP 25895"},
        {"Smithsonian Astrophysical Observation", "SAO 150529"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.91907240),
        dec: Angle.Degrees(-15.20382623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72638"},
        {"Hipparcos Number", "HIP 41987"},
        {"Smithsonian Astrophysical Observation", "SAO 154393"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.37652949),
        dec: Angle.Degrees(-15.20363336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40724"},
        {"Geneva Identification System", "GEN# -0.01402469"},
        {"Wilson Evans Batten Catalogue", "WEB 7909"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68494504),
        dec: Angle.Degrees(-15.20225211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83930"},
        {"Smithsonian Astrophysical Observation", "SAO 160321"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.33296943),
        dec: Angle.Degrees(-15.20216393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145777"},
        {"Hipparcos Number", "HIP 79484"},
        {"Wilson Evans Batten Catalogue", "WEB 13446"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30781761),
        dec: Angle.Degrees(-15.20032743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89826"},
        {"Hipparcos Number", "HIP 50745"},
        {"Smithsonian Astrophysical Observation", "SAO 155929"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.42894483),
        dec: Angle.Degrees(-15.20004915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123933"},
        {"Hipparcos Number", "HIP 69273"},
        {"Smithsonian Astrophysical Observation", "SAO 158403"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.71759171),
        dec: Angle.Degrees(-15.19435652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166803"},
        {"Hipparcos Number", "HIP 89263"},
        {"Geneva Identification System", "GEN# +1.00166803"},
        {"Smithsonian Astrophysical Observation", "SAO 161191"},
        {"Wilson Evans Batten Catalogue", "WEB 15173"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.23394551),
        dec: Angle.Degrees(-15.19237001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197353"},
        {"Hipparcos Number", "HIP 102289"},
        {"Geneva Identification System", "GEN# +1.00197353"},
        {"Smithsonian Astrophysical Observation", "SAO 163828"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.89189700),
        dec: Angle.Degrees(-15.18730386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72192"},
        {"Hipparcos Number", "HIP 41767"},
        {"Geneva Identification System", "GEN# +1.00072192"},
        {"Smithsonian Astrophysical Observation", "SAO 154344"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76435950),
        dec: Angle.Degrees(-15.18466783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218836"},
        {"Hipparcos Number", "HIP 114491"},
        {"Smithsonian Astrophysical Observation", "SAO 165541"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.81273787),
        dec: Angle.Degrees(-15.18423555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170787"},
        {"Hipparcos Number", "HIP 90834"},
        {"Geneva Identification System", "GEN# +1.00170787"},
        {"Smithsonian Astrophysical Observation", "SAO 161572"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.95989769),
        dec: Angle.Degrees(-15.18266404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192700"},
        {"Hipparcos Number", "HIP 99947"},
        {"Smithsonian Astrophysical Observation", "SAO 163408"},
        {"Wilson Evans Batten Catalogue", "WEB 17984"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.19138980),
        dec: Angle.Degrees(-15.18134994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28386"},
        {"Hipparcos Number", "HIP 20854"},
        {"Geneva Identification System", "GEN# +1.00028386"},
        {"Smithsonian Astrophysical Observation", "SAO 149661"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.02991087),
        dec: Angle.Degrees(-15.18041117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8208"},
        {"Smithsonian Astrophysical Observation", "SAO 148001"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.39078458),
        dec: Angle.Degrees(-15.17958751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60279"},
        {"Hipparcos Number", "HIP 36717"},
        {"Celescope Catalog", "CEL 1921"},
        {"Smithsonian Astrophysical Observation", "SAO 153053"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.28285222),
        dec: Angle.Degrees(-15.17839285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6789"},
        {"Hipparcos Number", "HIP 5352"},
        {"Smithsonian Astrophysical Observation", "SAO 147630"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.10356854),
        dec: Angle.Degrees(-15.17810799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 568"},
        {"Hipparcos Number", "HIP 830"},
        {"Smithsonian Astrophysical Observation", "SAO 147118"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.53282312),
        dec: Angle.Degrees(-15.17703288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77139",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9768 AB"},
        {"Henry Draper", "HD 140596"},
        {"Hipparcos Number", "HIP 77139"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.24862264),
        dec: Angle.Degrees(-15.17497029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21129"},
        {"Hipparcos Number", "HIP 15848"},
        {"Smithsonian Astrophysical Observation", "SAO 148942"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.03969238),
        dec: Angle.Degrees(-15.17167419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202369"},
        {"Hipparcos Number", "HIP 104974"},
        {"Geneva Identification System", "GEN# +1.00202369"},
        {"Smithsonian Astrophysical Observation", "SAO 164263"},
        {"Wilson Evans Batten Catalogue", "WEB 19077"},
    },
    visualMagnitude: 5.31,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.93678169),
        dec: Angle.Degrees(-15.17151251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20183",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3138 AB"},
        {"Henry Draper", "HD 27467"},
        {"Hipparcos Number", "HIP 20183"},
        {"Smithsonian Astrophysical Observation", "SAO 149540"},
        {"Wilson Evans Batten Catalogue", "WEB 3849"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.89198404),
        dec: Angle.Degrees(-15.16993355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81294"},
        {"Geneva Identification System", "GEN# -0.01404454"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.06010720),
        dec: Angle.Degrees(-15.16957170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -570.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185487"},
        {"Hipparcos Number", "HIP 96736"},
        {"Smithsonian Astrophysical Observation", "SAO 162862"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.96783571),
        dec: Angle.Degrees(-15.16737540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 786"},
        {"Hipparcos Number", "HIP 987"},
        {"Smithsonian Astrophysical Observation", "SAO 147145"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.05806888),
        dec: Angle.Degrees(-15.16459597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155503"},
        {"Hipparcos Number", "HIP 84190"},
        {"Geneva Identification System", "GEN# +1.00155503"},
        {"Smithsonian Astrophysical Observation", "SAO 160362"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.14599154),
        dec: Angle.Degrees(-15.16353194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67631"},
        {"Hipparcos Number", "HIP 39838"},
        {"Smithsonian Astrophysical Observation", "SAO 153877"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.09668958),
        dec: Angle.Degrees(-15.16224512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199505"},
        {"Hipparcos Number", "HIP 103491"},
        {"Geneva Identification System", "GEN# +1.00199505"},
        {"Smithsonian Astrophysical Observation", "SAO 164016"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.51799373),
        dec: Angle.Degrees(-15.16181642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6944"},
        {"Smithsonian Astrophysical Observation", "SAO 147838"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.35998162),
        dec: Angle.Degrees(-15.16131167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178020"},
        {"Hipparcos Number", "HIP 93930"},
        {"Geneva Identification System", "GEN# +1.00178020"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.89417677),
        dec: Angle.Degrees(-15.16109172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75176"},
    },
    visualMagnitude: 10.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.44460289),
        dec: Angle.Degrees(-15.16098059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136567"},
        {"Hipparcos Number", "HIP 75179"},
        {"Geneva Identification System", "GEN# +1.00136567"},
        {"Smithsonian Astrophysical Observation", "SAO 159199"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.45417879),
        dec: Angle.Degrees(-15.16097103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203349"},
        {"Hipparcos Number", "HIP 105498"},
        {"Smithsonian Astrophysical Observation", "SAO 164343"},
        {"Wilson Evans Batten Catalogue", "WEB 19154"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.50342296),
        dec: Angle.Degrees(-15.15916417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142556"},
        {"Hipparcos Number", "HIP 78010"},
        {"Geneva Identification System", "GEN# +1.00142556"},
        {"Smithsonian Astrophysical Observation", "SAO 159579"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.94220744),
        dec: Angle.Degrees(-15.15915664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81686"},
        {"Smithsonian Astrophysical Observation", "SAO 160042"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.29275289),
        dec: Angle.Degrees(-15.15827862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120851"},
        {"Hipparcos Number", "HIP 67713"},
        {"Smithsonian Astrophysical Observation", "SAO 158208"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.07464570),
        dec: Angle.Degrees(-15.15770831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5734"},
        {"Hipparcos Number", "HIP 4597"},
        {"Smithsonian Astrophysical Observation", "SAO 147554"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.71305223),
        dec: Angle.Degrees(-15.15747092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204589"},
        {"Hipparcos Number", "HIP 106139"},
        {"Smithsonian Astrophysical Observation", "SAO 164434"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.48658797),
        dec: Angle.Degrees(-15.15734933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11390"},
        {"Hipparcos Number", "HIP 8666"},
        {"Smithsonian Astrophysical Observation", "SAO 148065"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90929373),
        dec: Angle.Degrees(-15.15374768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135368"},
        {"Hipparcos Number", "HIP 74646"},
        {"Smithsonian Astrophysical Observation", "SAO 159125"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.78196060),
        dec: Angle.Degrees(-15.15327160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169516"},
        {"Hipparcos Number", "HIP 90311"},
        {"Smithsonian Astrophysical Observation", "SAO 161459"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.40669025),
        dec: Angle.Degrees(-15.15277860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18899"},
    },
    visualMagnitude: 10.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.76643041),
        dec: Angle.Degrees(-15.15209680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69530"},
        {"Hipparcos Number", "HIP 40552"},
        {"Geneva Identification System", "GEN# +1.00069530"},
        {"Smithsonian Astrophysical Observation", "SAO 154061"},
        {"Wilson Evans Batten Catalogue", "WEB 7891"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.21705971),
        dec: Angle.Degrees(-15.15197973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35043"},
        {"Hipparcos Number", "HIP 25010"},
        {"Geneva Identification System", "GEN# +1.00035043"},
        {"Smithsonian Astrophysical Observation", "SAO 150368"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.32598982),
        dec: Angle.Degrees(-15.15096698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7524"},
        {"Hipparcos Number", "HIP 5859"},
        {"Smithsonian Astrophysical Observation", "SAO 147695"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.79192911),
        dec: Angle.Degrees(-15.15015519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43008"},
        {"Hipparcos Number", "HIP 29535"},
        {"Smithsonian Astrophysical Observation", "SAO 151240"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.35127670),
        dec: Angle.Degrees(-15.14785748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196348"},
        {"Hipparcos Number", "HIP 101751"},
        {"Geneva Identification System", "GEN# +1.00196348"},
        {"Smithsonian Astrophysical Observation", "SAO 163740"},
        {"Wilson Evans Batten Catalogue", "WEB 18374"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.33816876),
        dec: Angle.Degrees(-15.14722443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25573"},
        {"Hipparcos Number", "HIP 18897"},
        {"Smithsonian Astrophysical Observation", "SAO 149336"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.76380469),
        dec: Angle.Degrees(-15.14559005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32677",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5487 AB"},
        {"Henry Draper", "HD 49662"},
        {"Hipparcos Number", "HIP 32677"},
        {"Celescope Catalog", "CEL 1392"},
        {"Geneva Identification System", "GEN# +1.00049662J"},
        {"Smithsonian Astrophysical Observation", "SAO 151962"},
        {"Wilson Evans Batten Catalogue", "WEB 6585"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.24057628),
        dec: Angle.Degrees(-15.14471091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78558"},
        {"Hipparcos Number", "HIP 44860"},
        {"Cincinnati Publication", "Ci 20 512"},
        {"Geneva Identification System", "GEN# +1.00078558"},
        {"Smithsonian Astrophysical Observation", "SAO 154939"},
        {"Wilson Evans Batten Catalogue", "WEB 8572"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.10650114),
        dec: Angle.Degrees(-15.14429977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -534.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219328"},
        {"Hipparcos Number", "HIP 114780"},
        {"Smithsonian Astrophysical Observation", "SAO 165582"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.75247766),
        dec: Angle.Degrees(-15.14422835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208804"},
        {"Hipparcos Number", "HIP 108522"},
        {"Smithsonian Astrophysical Observation", "SAO 164787"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.78082957),
        dec: Angle.Degrees(-15.14360785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26203"},
        {"Smithsonian Astrophysical Observation", "SAO 150583"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.77260095),
        dec: Angle.Degrees(-15.14198761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45143"},
        {"Hipparcos Number", "HIP 30534"},
        {"Smithsonian Astrophysical Observation", "SAO 151477"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.27901406),
        dec: Angle.Degrees(-15.13978578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25166"},
        {"Hipparcos Number", "HIP 18639"},
        {"Geneva Identification System", "GEN# +1.00025166"},
        {"Smithsonian Astrophysical Observation", "SAO 149298"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.84058332),
        dec: Angle.Degrees(-15.13928087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223023"},
        {"Hipparcos Number", "HIP 117222"},
        {"Geneva Identification System", "GEN# +1.00223023J"},
        {"Smithsonian Astrophysical Observation", "SAO 165869"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.51099422),
        dec: Angle.Degrees(-15.13411786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136801"},
        {"Hipparcos Number", "HIP 75294"},
        {"Fundamental Katalog 5th Edition", "FK5 1405"},
        {"Geneva Identification System", "GEN# +1.00136801"},
        {"Smithsonian Astrophysical Observation", "SAO 159212"},
        {"Wilson Evans Batten Catalogue", "WEB 12843"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.75743362),
        dec: Angle.Degrees(-15.13407614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206944"},
        {"Hipparcos Number", "HIP 107450"},
        {"Smithsonian Astrophysical Observation", "SAO 164631"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.45148071),
        dec: Angle.Degrees(-15.13335676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17275"},
    },
    visualMagnitude: 11.08,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.49462446),
        dec: Angle.Degrees(-15.13332504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 176.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215734"},
        {"Hipparcos Number", "HIP 112526"},
        {"Geneva Identification System", "GEN# +1.00215734"},
        {"Smithsonian Astrophysical Observation", "SAO 165294"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88504045),
        dec: Angle.Degrees(-15.13263281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87097"},
        {"Hipparcos Number", "HIP 49196"},
        {"Geneva Identification System", "GEN# +1.00087097"},
        {"Smithsonian Astrophysical Observation", "SAO 155678"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.61781644),
        dec: Angle.Degrees(-15.13229222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22173"},
        {"Hipparcos Number", "HIP 16607"},
        {"Geneva Identification System", "GEN# +1.00022173"},
        {"Smithsonian Astrophysical Observation", "SAO 149040"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.43857096),
        dec: Angle.Degrees(-15.12758867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54691"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.94929647),
        dec: Angle.Degrees(-15.12747983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -295.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43670"},
        {"Hipparcos Number", "HIP 29822"},
        {"Geneva Identification System", "GEN# +1.00043670"},
        {"Smithsonian Astrophysical Observation", "SAO 151307"},
        {"Wilson Evans Batten Catalogue", "WEB 5895"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.20912805),
        dec: Angle.Degrees(-15.12570699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202291"},
        {"Hipparcos Number", "HIP 104918"},
        {"Smithsonian Astrophysical Observation", "SAO 164251"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79187561),
        dec: Angle.Degrees(-15.12553311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2693"},
        {"Hipparcos Number", "HIP 2389"},
        {"Smithsonian Astrophysical Observation", "SAO 147313"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.61604813),
        dec: Angle.Degrees(-15.12390459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15489 A"},
        {"Henry Draper", "HD 208621"},
        {"Hipparcos Number", "HIP 108414"},
        {"Smithsonian Astrophysical Observation", "SAO 164768"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.44765274),
        dec: Angle.Degrees(-15.12327051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12178"},
        {"Hipparcos Number", "HIP 9277"},
        {"Geneva Identification System", "GEN# +1.00012178"},
        {"Smithsonian Astrophysical Observation", "SAO 148142"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.80604741),
        dec: Angle.Degrees(-15.12218640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178070"},
        {"Hipparcos Number", "HIP 93952"},
        {"Geneva Identification System", "GEN# +1.00178070"},
        {"Smithsonian Astrophysical Observation", "SAO 162217"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.94730064),
        dec: Angle.Degrees(-15.12197852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207438"},
        {"Hipparcos Number", "HIP 107714"},
        {"Fundamental Katalog 5th Edition", "FK5 5926"},
        {"Smithsonian Astrophysical Observation", "SAO 164673"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.30260357),
        dec: Angle.Degrees(-15.12059269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45324"},
        {"Hipparcos Number", "HIP 30625"},
        {"Smithsonian Astrophysical Observation", "SAO 151497"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.53901255),
        dec: Angle.Degrees(-15.12012340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217761"},
        {"Hipparcos Number", "HIP 113827"},
        {"Smithsonian Astrophysical Observation", "SAO 165463"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.76213498),
        dec: Angle.Degrees(-15.11832495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213819"},
        {"Hipparcos Number", "HIP 111424"},
        {"Smithsonian Astrophysical Observation", "SAO 165167"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.61191098),
        dec: Angle.Degrees(-15.11813971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116410"},
        {"Hipparcos Number", "HIP 65356"},
        {"Geneva Identification System", "GEN# +1.00116410"},
        {"Smithsonian Astrophysical Observation", "SAO 157908"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.92160704),
        dec: Angle.Degrees(-15.11785571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 358431"},
        {"Hipparcos Number", "HIP 105285"},
        {"Wilson Evans Batten Catalogue", "WEB 19123"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.88509217),
        dec: Angle.Degrees(-15.11693759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145748"},
        {"Hipparcos Number", "HIP 79475"},
        {"Smithsonian Astrophysical Observation", "SAO 159784"},
        {"Wilson Evans Batten Catalogue", "WEB 13445"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.29643930),
        dec: Angle.Degrees(-15.11691707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104003"},
        {"Hipparcos Number", "HIP 58408"},
        {"Geneva Identification System", "GEN# +1.00104003"},
        {"Smithsonian Astrophysical Observation", "SAO 157023"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.63986903),
        dec: Angle.Degrees(-15.11686966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143954"},
        {"Hipparcos Number", "HIP 78687"},
        {"Geneva Identification System", "GEN# +1.00143954"},
        {"Smithsonian Astrophysical Observation", "SAO 159661"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.95467790),
        dec: Angle.Degrees(-15.11682106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42323"},
        {"Hipparcos Number", "HIP 29192"},
        {"Smithsonian Astrophysical Observation", "SAO 151177"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.36544990),
        dec: Angle.Degrees(-15.11444587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199854"},
        {"Hipparcos Number", "HIP 103663"},
        {"Geneva Identification System", "GEN# +1.00199854"},
        {"Smithsonian Astrophysical Observation", "SAO 164051"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.05687869),
        dec: Angle.Degrees(-15.11443630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76314"},
        {"Hipparcos Number", "HIP 43765"},
        {"Smithsonian Astrophysical Observation", "SAO 154734"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.72935873),
        dec: Angle.Degrees(-15.11342362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186499"},
        {"Hipparcos Number", "HIP 97190"},
        {"Smithsonian Astrophysical Observation", "SAO 162949"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.30391840),
        dec: Angle.Degrees(-15.11013755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93524"},
        {"Hipparcos Number", "HIP 52804"},
        {"Smithsonian Astrophysical Observation", "SAO 156238"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.92852714),
        dec: Angle.Degrees(-15.10981485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124758"},
        {"Hipparcos Number", "HIP 69681"},
        {"Geneva Identification System", "GEN# +1.00124758"},
        {"Smithsonian Astrophysical Observation", "SAO 158452"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.95576365),
        dec: Angle.Degrees(-15.10953268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112450"},
        {"Hipparcos Number", "HIP 63196"},
        {"Smithsonian Astrophysical Observation", "SAO 157614"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.20296581),
        dec: Angle.Degrees(-15.10926025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30251",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30251"},
        {"Smithsonian Astrophysical Observation", "SAO 151413"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.45229066),
        dec: Angle.Degrees(-15.10869418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23868"},
        {"Hipparcos Number", "HIP 17737"},
        {"Smithsonian Astrophysical Observation", "SAO 149174"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.98264840),
        dec: Angle.Degrees(-15.10476659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93932"},
        {"Hipparcos Number", "HIP 52990"},
        {"Cincinnati Publication", "Ci 18 1304"},
        {"Geneva Identification System", "GEN# +1.00093932"},
        {"Smithsonian Astrophysical Observation", "SAO 156264"},
        {"Wilson Evans Batten Catalogue", "WEB 9638"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.60696114),
        dec: Angle.Degrees(-15.10397407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183133"},
        {"Hipparcos Number", "HIP 95755"},
        {"Geneva Identification System", "GEN# +1.00183133"},
        {"Smithsonian Astrophysical Observation", "SAO 162651"},
        {"Wilson Evans Batten Catalogue", "WEB 16754"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.14721549),
        dec: Angle.Degrees(-15.10229301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46036"},
        {"Hipparcos Number", "HIP 31008"},
        {"Smithsonian Astrophysical Observation", "SAO 151581"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.61090543),
        dec: Angle.Degrees(-15.10215620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211022"},
        {"Hipparcos Number", "HIP 109820"},
        {"Geneva Identification System", "GEN# +1.00211022"},
        {"Smithsonian Astrophysical Observation", "SAO 164948"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.65501470),
        dec: Angle.Degrees(-15.10150600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16826"},
        {"Hipparcos Number", "HIP 12554"},
        {"Geneva Identification System", "GEN# +1.00016826"},
        {"Smithsonian Astrophysical Observation", "SAO 148549"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.37548948),
        dec: Angle.Degrees(-15.10054154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25070"},
        {"Hipparcos Number", "HIP 18569"},
        {"Smithsonian Astrophysical Observation", "SAO 149289"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.63362525),
        dec: Angle.Degrees(-15.09999761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208029"},
        {"Hipparcos Number", "HIP 108068"},
        {"Geneva Identification System", "GEN# +1.00208029"},
        {"Smithsonian Astrophysical Observation", "SAO 164720"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.42795323),
        dec: Angle.Degrees(-15.09896784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33238"},
        {"Hipparcos Number", "HIP 23908"},
        {"Geneva Identification System", "GEN# +1.00033238"},
        {"Smithsonian Astrophysical Observation", "SAO 150170"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.05524386),
        dec: Angle.Degrees(-15.09535837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222125"},
        {"Hipparcos Number", "HIP 116624"},
        {"Fundamental Katalog 5th Edition", "FK5 6094"},
        {"Geneva Identification System", "GEN# +1.00222125"},
        {"Smithsonian Astrophysical Observation", "SAO 165808"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.51242043),
        dec: Angle.Degrees(-15.09483723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208673"},
        {"Hipparcos Number", "HIP 108452"},
        {"Smithsonian Astrophysical Observation", "SAO 164774"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.54949403),
        dec: Angle.Degrees(-15.09096492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21028"},
        {"Smithsonian Astrophysical Observation", "SAO 149688"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.63349821),
        dec: Angle.Degrees(-15.08890867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90032",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11282 A"},
        {"Henry Draper", "HD 168815"},
        {"Henry Draper 2", "HD 168815A"},
        {"Hipparcos Number", "HIP 90032"},
        {"Geneva Identification System", "GEN# +1.00168815"},
        {"Smithsonian Astrophysical Observation", "SAO 161390"},
        {"Wilson Evans Batten Catalogue", "WEB 15381"},
    },
    visualMagnitude: 7.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.55786453),
        dec: Angle.Degrees(-15.08828510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117334"},
        {"Hipparcos Number", "HIP 65845"},
        {"Smithsonian Astrophysical Observation", "SAO 157965"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.46274737),
        dec: Angle.Degrees(-15.08682554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62728"},
        {"Hipparcos Number", "HIP 37782"},
        {"Geneva Identification System", "GEN# +1.00062728"},
        {"Smithsonian Astrophysical Observation", "SAO 153338"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19953640),
        dec: Angle.Degrees(-15.08509202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61465"},
        {"Hipparcos Number", "HIP 37230"},
        {"Smithsonian Astrophysical Observation", "SAO 153188"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.70641156),
        dec: Angle.Degrees(-15.08393004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110442"},
        {"Hipparcos Number", "HIP 61993"},
        {"Smithsonian Astrophysical Observation", "SAO 157454"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.57334447),
        dec: Angle.Degrees(-15.08352228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131009"},
        {"Hipparcos Number", "HIP 72676"},
        {"Smithsonian Astrophysical Observation", "SAO 158856"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.89217342),
        dec: Angle.Degrees(-15.08181113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14296"},
        {"Smithsonian Astrophysical Observation", "SAO 148745"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.07136204),
        dec: Angle.Degrees(-15.07998887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111499"},
        {"Hipparcos Number", "HIP 62611"},
        {"Geneva Identification System", "GEN# +1.00111499"},
        {"Smithsonian Astrophysical Observation", "SAO 157536"},
        {"Wilson Evans Batten Catalogue", "WEB 11110"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.44598966),
        dec: Angle.Degrees(-15.07890970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178882"},
        {"Hipparcos Number", "HIP 94224"},
        {"Smithsonian Astrophysical Observation", "SAO 162278"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.71479646),
        dec: Angle.Degrees(-15.07781628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219742"},
        {"Hipparcos Number", "HIP 115060"},
        {"Smithsonian Astrophysical Observation", "SAO 165615"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.57793206),
        dec: Angle.Degrees(-15.07146486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44891"},
        {"Hipparcos Number", "HIP 30420"},
        {"Geneva Identification System", "GEN# +1.00044891"},
        {"Smithsonian Astrophysical Observation", "SAO 151450"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94226257),
        dec: Angle.Degrees(-15.07126137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13442"},
        {"Hipparcos Number", "HIP 10194"},
        {"Geneva Identification System", "GEN# +1.00013442"},
        {"Smithsonian Astrophysical Observation", "SAO 148257"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.76702675),
        dec: Angle.Degrees(-15.07077680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101210"},
        {"Hipparcos Number", "HIP 56811"},
        {"Geneva Identification System", "GEN# +1.00101210"},
        {"Smithsonian Astrophysical Observation", "SAO 156805"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.69138538),
        dec: Angle.Degrees(-15.06991865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147777"},
        {"Hipparcos Number", "HIP 80369"},
        {"Smithsonian Astrophysical Observation", "SAO 159898"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.08642200),
        dec: Angle.Degrees(-15.06819855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88549"},
        {"Hipparcos Number", "HIP 49995"},
        {"Smithsonian Astrophysical Observation", "SAO 155813"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.09976347),
        dec: Angle.Degrees(-15.06801731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2570"},
        {"Hipparcos Number", "HIP 2290"},
        {"Smithsonian Astrophysical Observation", "SAO 147302"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.30969076),
        dec: Angle.Degrees(-15.06530578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164223"},
        {"Hipparcos Number", "HIP 88197"},
        {"Smithsonian Astrophysical Observation", "SAO 160988"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.17143575),
        dec: Angle.Degrees(-15.06396985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218121"},
        {"Hipparcos Number", "HIP 114030"},
        {"Smithsonian Astrophysical Observation", "SAO 165484"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.38725049),
        dec: Angle.Degrees(-15.06348402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74490"},
        {"Hipparcos Number", "HIP 42846"},
        {"Smithsonian Astrophysical Observation", "SAO 154583"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.96952354),
        dec: Angle.Degrees(-15.06292857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107260"},
        {"Hipparcos Number", "HIP 60136"},
        {"Smithsonian Astrophysical Observation", "SAO 157215"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.98854025),
        dec: Angle.Degrees(-15.06268832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93278"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00102173),
        dec: Angle.Degrees(-15.06090133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194979"},
        {"Hipparcos Number", "HIP 101045"},
        {"Smithsonian Astrophysical Observation", "SAO 163618"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.26095372),
        dec: Angle.Degrees(-15.06035764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42459"},
        {"Hipparcos Number", "HIP 29275"},
        {"Geneva Identification System", "GEN# +1.00042459"},
        {"Smithsonian Astrophysical Observation", "SAO 151187"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.56928282),
        dec: Angle.Degrees(-15.05942431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165994"},
        {"Hipparcos Number", "HIP 88928"},
        {"Smithsonian Astrophysical Observation", "SAO 161115"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.28871406),
        dec: Angle.Degrees(-15.05906091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83131"},
        {"Hipparcos Number", "HIP 47105"},
        {"Smithsonian Astrophysical Observation", "SAO 155326"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01015212),
        dec: Angle.Degrees(-15.05883926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195330"},
        {"Hipparcos Number", "HIP 101221"},
        {"Geneva Identification System", "GEN# +1.00195330"},
        {"Smithsonian Astrophysical Observation", "SAO 163645"},
        {"Wilson Evans Batten Catalogue", "WEB 18285"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.76804610),
        dec: Angle.Degrees(-15.05605156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88437"},
        {"Hipparcos Number", "HIP 49922"},
        {"Geneva Identification System", "GEN# +9.00050009"},
        {"Geneva Identification System 2", "GEN# +9.00050014"},
        {"Smithsonian Astrophysical Observation", "SAO 155804"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.89328316),
        dec: Angle.Degrees(-15.05485145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182645"},
        {"Hipparcos Number", "HIP 95557"},
        {"Geneva Identification System", "GEN# +1.00182645"},
        {"Smithsonian Astrophysical Observation", "SAO 162609"},
        {"Wilson Evans Batten Catalogue", "WEB 16707"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.54596470),
        dec: Angle.Degrees(-15.05325005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31043"},
        {"Hipparcos Number", "HIP 22625"},
        {"Smithsonian Astrophysical Observation", "SAO 149948"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.01857782),
        dec: Angle.Degrees(-15.05273395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218502"},
        {"Hipparcos Number", "HIP 114271"},
        {"Cincinnati Publication", "Ci 18 3026"},
        {"Geneva Identification System", "GEN# +1.00218502"},
        {"Smithsonian Astrophysical Observation", "SAO 165510"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.16378744),
        dec: Angle.Degrees(-15.05262187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -285.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26681"},
        {"Smithsonian Astrophysical Observation", "SAO 150667"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.05524857),
        dec: Angle.Degrees(-15.05061946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133035"},
        {"Hipparcos Number", "HIP 73613"},
        {"Smithsonian Astrophysical Observation", "SAO 158989"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.69486141),
        dec: Angle.Degrees(-15.05008516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49812"},
        {"Hipparcos Number", "HIP 32731"},
        {"Celescope Catalog", "CEL 1396"},
        {"Geneva Identification System", "GEN# +1.00049812"},
        {"Smithsonian Astrophysical Observation", "SAO 151975"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.41713488),
        dec: Angle.Degrees(-15.04456010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140301"},
        {"Hipparcos Number", "HIP 77007"},
        {"Fundamental Katalog 5th Edition", "FK5 5393"},
        {"Geneva Identification System", "GEN# +1.00140301"},
        {"Smithsonian Astrophysical Observation", "SAO 159461"},
        {"Wilson Evans Batten Catalogue", "WEB 13060"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85358992),
        dec: Angle.Degrees(-15.04299844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101897"},
        {"Hipparcos Number", "HIP 57173"},
        {"Geneva Identification System", "GEN# +1.00101897"},
        {"Smithsonian Astrophysical Observation", "SAO 156853"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.87793855),
        dec: Angle.Degrees(-15.04282730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18606"},
        {"Hipparcos Number", "HIP 13906"},
        {"Smithsonian Astrophysical Observation", "SAO 148697"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.77499617),
        dec: Angle.Degrees(-15.04170767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88912"},
        {"Hipparcos Number", "HIP 50211"},
        {"Smithsonian Astrophysical Observation", "SAO 155847"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.75477471),
        dec: Angle.Degrees(-15.04166300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225039"},
        {"Hipparcos Number", "HIP 225"},
        {"Smithsonian Astrophysical Observation", "SAO 147053"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.70006380),
        dec: Angle.Degrees(-15.04053128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16708 AB"},
        {"Henry Draper", "HD 220278"},
        {"Hipparcos Number", "HIP 115404"},
        {"Geneva Identification System", "GEN# +1.00220278"},
        {"Smithsonian Astrophysical Observation", "SAO 165658"},
        {"Wilson Evans Batten Catalogue", "WEB 20435"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.66291976),
        dec: Angle.Degrees(-15.03938012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12400"},
        {"Smithsonian Astrophysical Observation", "SAO 148530"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.91482584),
        dec: Angle.Degrees(-15.03932527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172137"},
        {"Hipparcos Number", "HIP 91448"},
        {"Smithsonian Astrophysical Observation", "SAO 161694"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.76053722),
        dec: Angle.Degrees(-15.03926357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21252"},
        {"Hipparcos Number", "HIP 15940"},
        {"Geneva Identification System", "GEN# +1.00021252"},
        {"Smithsonian Astrophysical Observation", "SAO 148954"},
        {"Wilson Evans Batten Catalogue", "WEB 3045"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.31305072),
        dec: Angle.Degrees(-15.03856398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -275.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43592"},
        {"Hipparcos Number", "HIP 29799"},
        {"Geneva Identification System", "GEN# +1.00043592"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.10915608),
        dec: Angle.Degrees(-15.03695464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119317"},
        {"Hipparcos Number", "HIP 66920"},
        {"Smithsonian Astrophysical Observation", "SAO 158108"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.72343365),
        dec: Angle.Degrees(-15.03517972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94739"},
        {"Hipparcos Number", "HIP 53450"},
        {"Smithsonian Astrophysical Observation", "SAO 156334"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.01085511),
        dec: Angle.Degrees(-15.03506594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197626"},
        {"Hipparcos Number", "HIP 102433"},
        {"Geneva Identification System", "GEN# +1.00197626"},
        {"Smithsonian Astrophysical Observation", "SAO 163851"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.34592025),
        dec: Angle.Degrees(-15.03474068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93346"},
        {"Hipparcos Number", "HIP 52693"},
        {"Smithsonian Astrophysical Observation", "SAO 156212"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.61129673),
        dec: Angle.Degrees(-15.03411797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101257"},
        {"Hipparcos Number", "HIP 56831"},
        {"Smithsonian Astrophysical Observation", "SAO 156807"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.75256638),
        dec: Angle.Degrees(-15.03216527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191049"},
        {"Hipparcos Number", "HIP 99216"},
        {"Smithsonian Astrophysical Observation", "SAO 163286"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12161706),
        dec: Angle.Degrees(-15.03165798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26828"},
        {"Hipparcos Number", "HIP 19753"},
        {"Smithsonian Astrophysical Observation", "SAO 149471"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.51484439),
        dec: Angle.Degrees(-15.03104668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142538"},
        {"Hipparcos Number", "HIP 77999"},
        {"Geneva Identification System", "GEN# +1.00142538"},
        {"Smithsonian Astrophysical Observation", "SAO 159578"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92088082),
        dec: Angle.Degrees(-15.03058952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72462"},
        {"Hipparcos Number", "HIP 41893"},
        {"Geneva Identification System", "GEN# +1.00072462J"},
        {"Smithsonian Astrophysical Observation", "SAO 154373"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.13912451),
        dec: Angle.Degrees(-15.03019733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49169",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7615 AB"},
        {"Henry Draper", "HD 87036"},
        {"Hipparcos Number", "HIP 49169"},
        {"Smithsonian Astrophysical Observation", "SAO 155672"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.52110349),
        dec: Angle.Degrees(-15.02905526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26450"},
        {"Hipparcos Number", "HIP 19489"},
        {"Geneva Identification System", "GEN# +1.00026450"},
        {"Smithsonian Astrophysical Observation", "SAO 149429"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.61991990),
        dec: Angle.Degrees(-15.02896867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130900"},
        {"Hipparcos Number", "HIP 72640"},
        {"Geneva Identification System", "GEN# +1.00130900"},
        {"Smithsonian Astrophysical Observation", "SAO 158842"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76533108),
        dec: Angle.Degrees(-15.02747355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90322"},
        {"Hipparcos Number", "HIP 51018"},
        {"Geneva Identification System", "GEN# +1.00090322"},
        {"Smithsonian Astrophysical Observation", "SAO 155968"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.34029939),
        dec: Angle.Degrees(-15.02670304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34542",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34542"},
        {"Smithsonian Astrophysical Observation", "SAO 152473"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.34692739),
        dec: Angle.Degrees(-15.02644959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171770"},
        {"Hipparcos Number", "HIP 91280"},
        {"Geneva Identification System", "GEN# +1.00171770"},
        {"Smithsonian Astrophysical Observation", "SAO 161668"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.28772775),
        dec: Angle.Degrees(-15.02619482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162535"},
        {"Hipparcos Number", "HIP 87444"},
        {"Geneva Identification System", "GEN# +1.00162535"},
        {"Smithsonian Astrophysical Observation", "SAO 160873"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01758725),
        dec: Angle.Degrees(-15.02614692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44021"},
        {"Hipparcos Number", "HIP 29993"},
        {"Geneva Identification System", "GEN# +1.00044021"},
        {"Smithsonian Astrophysical Observation", "SAO 151346"},
        {"Wilson Evans Batten Catalogue", "WEB 5954"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.70329320),
        dec: Angle.Degrees(-15.02499416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79752"},
        {"Hipparcos Number", "HIP 45424"},
        {"Geneva Identification System", "GEN# +1.00079752"},
        {"Renson", "Renson 22670"},
        {"Smithsonian Astrophysical Observation", "SAO 155032"},
        {"Wilson Evans Batten Catalogue", "WEB 8643"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.85397891),
        dec: Angle.Degrees(-15.02486672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52242"},
        {"Hipparcos Number", "HIP 33685"},
        {"Celescope Catalog", "CEL 1486"},
        {"Geneva Identification System", "GEN# +1.00052242"},
        {"Smithsonian Astrophysical Observation", "SAO 152218"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.96842746),
        dec: Angle.Degrees(-15.02170999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38969"},
        {"Smithsonian Astrophysical Observation", "SAO 153649"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.60660837),
        dec: Angle.Degrees(-15.01975764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18346"},
        {"Hipparcos Number", "HIP 13705"},
        {"Renson", "Renson 4566"},
        {"Smithsonian Astrophysical Observation", "SAO 148677"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.11978615),
        dec: Angle.Degrees(-15.01947148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7423"},
        {"Hipparcos Number", "HIP 5781"},
        {"Smithsonian Astrophysical Observation", "SAO 147687"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.53960567),
        dec: Angle.Degrees(-15.01820456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115047"},
        {"Hipparcos Number", "HIP 64628"},
        {"Smithsonian Astrophysical Observation", "SAO 157812"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.70285883),
        dec: Angle.Degrees(-15.01803326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193255"},
        {"Hipparcos Number", "HIP 100244"},
        {"Geneva Identification System", "GEN# +1.00193255"},
        {"Smithsonian Astrophysical Observation", "SAO 163453"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.96696689),
        dec: Angle.Degrees(-15.01775167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25865",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25865"},
        {"Smithsonian Astrophysical Observation", "SAO 150524"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.82883861),
        dec: Angle.Degrees(-15.01632931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211595"},
        {"Hipparcos Number", "HIP 110131"},
        {"Smithsonian Astrophysical Observation", "SAO 164990"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.62806118),
        dec: Angle.Degrees(-15.01303719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216601"},
        {"Hipparcos Number", "HIP 113117"},
        {"Smithsonian Astrophysical Observation", "SAO 165370"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.60443284),
        dec: Angle.Degrees(-15.00992987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184075"},
        {"Hipparcos Number", "HIP 96169"},
        {"Geneva Identification System", "GEN# +1.00184075"},
        {"Smithsonian Astrophysical Observation", "SAO 162747"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.31365657),
        dec: Angle.Degrees(-15.00769725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127744"},
        {"Hipparcos Number", "HIP 71180"},
        {"Smithsonian Astrophysical Observation", "SAO 158633"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.36973364),
        dec: Angle.Degrees(-15.00460750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40821"},
        {"Hipparcos Number", "HIP 28481"},
        {"Geneva Identification System", "GEN# +1.00040821"},
        {"Smithsonian Astrophysical Observation", "SAO 151019"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.19922407),
        dec: Angle.Degrees(-15.00296231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210357"},
        {"Hipparcos Number", "HIP 109430"},
        {"Smithsonian Astrophysical Observation", "SAO 164902"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.55336475),
        dec: Angle.Degrees(-15.00115317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104687",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14736"},
        {"Aitken 2", "ADS 14736 AB"},
        {"Henry Draper", "HD 201796"},
        {"Hipparcos Number", "HIP 104687"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.09400019),
        dec: Angle.Degrees(-15.00000422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3013"},
        {"Geneva Identification System", "GEN# -0.01500115"},
        {"Renson", "Renson 950"},
    },
    visualMagnitude: 10.88,
    bvColour: -0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.58440437),
        dec: Angle.Degrees(-14.99837706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36395",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6126 AB"},
        {"Henry Draper", "HD 59438"},
        {"Hipparcos Number", "HIP 36395"},
        {"Geneva Identification System", "GEN# +1.00059438"},
        {"Smithsonian Astrophysical Observation", "SAO 152943"},
        {"Wilson Evans Batten Catalogue", "WEB 7247"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.34156903),
        dec: Angle.Degrees(-14.99809455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133411"},
        {"Hipparcos Number", "HIP 73766"},
        {"Geneva Identification System", "GEN# +1.00133411"},
        {"Smithsonian Astrophysical Observation", "SAO 159008"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.18516854),
        dec: Angle.Degrees(-14.99729009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74365"},
        {"Hipparcos Number", "HIP 42793"},
        {"Smithsonian Astrophysical Observation", "SAO 154571"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.78890501),
        dec: Angle.Degrees(-14.99638081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8676"},
        {"Hipparcos Number", "HIP 6647"},
        {"Geneva Identification System", "GEN# +1.00008676"},
        {"Smithsonian Astrophysical Observation", "SAO 147798"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.32591863),
        dec: Angle.Degrees(-14.99411798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16585"},
        {"Hipparcos Number", "HIP 12365"},
        {"Smithsonian Astrophysical Observation", "SAO 148524"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.78997029),
        dec: Angle.Degrees(-14.99304346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129957"},
        {"Hipparcos Number", "HIP 72182"},
        {"Smithsonian Astrophysical Observation", "SAO 158785"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.46366515),
        dec: Angle.Degrees(-14.99134535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97588"},
        {"Hipparcos Number", "HIP 54848"},
        {"Smithsonian Astrophysical Observation", "SAO 156549"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.43663949),
        dec: Angle.Degrees(-14.99061916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97233"},
        {"Hipparcos Number", "HIP 54677"},
        {"Cincinnati Publication", "Ci 18 1364"},
        {"Cincinnati Publication 2", "Ci 20 616"},
        {"Geneva Identification System", "GEN# +1.00097233"},
        {"Smithsonian Astrophysical Observation", "SAO 156518"},
        {"Wilson Evans Batten Catalogue", "WEB 9869"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.88625239),
        dec: Angle.Degrees(-14.98993453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 698.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -597.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216845"},
        {"Hipparcos Number", "HIP 113292"},
        {"Fundamental Katalog 5th Edition", "FK5 6030"},
        {"Smithsonian Astrophysical Observation", "SAO 165394"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.12555564),
        dec: Angle.Degrees(-14.98954755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84130"},
        {"Hipparcos Number", "HIP 47610"},
        {"Smithsonian Astrophysical Observation", "SAO 155420"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.62103490),
        dec: Angle.Degrees(-14.98820829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108290"},
        {"Hipparcos Number", "HIP 60715"},
        {"Smithsonian Astrophysical Observation", "SAO 157288"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.64342690),
        dec: Angle.Degrees(-14.98729044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112613"},
        {"Hipparcos Number", "HIP 63281"},
        {"Geneva Identification System", "GEN# +1.00112613"},
        {"Smithsonian Astrophysical Observation", "SAO 157627"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.51524675),
        dec: Angle.Degrees(-14.98561210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71734"},
        {"Hipparcos Number", "HIP 41562"},
        {"Smithsonian Astrophysical Observation", "SAO 154293"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.11333257),
        dec: Angle.Degrees(-14.98439942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118235"},
        {"Hipparcos Number", "HIP 66338"},
        {"Smithsonian Astrophysical Observation", "SAO 158029"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.92936865),
        dec: Angle.Degrees(-14.98379589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223543"},
        {"Hipparcos Number", "HIP 117558"},
        {"Geneva Identification System", "GEN# +1.00223543"},
        {"Renson", "Renson 61260"},
        {"Smithsonian Astrophysical Observation", "SAO 165913"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.61528697),
        dec: Angle.Degrees(-14.98369172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194458"},
        {"Hipparcos Number", "HIP 100785"},
        {"Smithsonian Astrophysical Observation", "SAO 163564"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.51851355),
        dec: Angle.Degrees(-14.98017543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27255"},
        {"Smithsonian Astrophysical Observation", "SAO 150798"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.66072328),
        dec: Angle.Degrees(-14.97979121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28478"},
        {"Hipparcos Number", "HIP 20903"},
        {"Smithsonian Astrophysical Observation", "SAO 149671"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.21070144),
        dec: Angle.Degrees(-14.97932441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188917"},
        {"Hipparcos Number", "HIP 98281"},
        {"Smithsonian Astrophysical Observation", "SAO 163144"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.53904031),
        dec: Angle.Degrees(-14.97699906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11619"},
        {"Hipparcos Number", "HIP 8845"},
        {"Smithsonian Astrophysical Observation", "SAO 148088"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.44262416),
        dec: Angle.Degrees(-14.97650429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217627"},
        {"Hipparcos Number", "HIP 113746"},
        {"Smithsonian Astrophysical Observation", "SAO 165450"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.54097587),
        dec: Angle.Degrees(-14.97612413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70409"},
        {"Hipparcos Number", "HIP 40940"},
        {"Smithsonian Astrophysical Observation", "SAO 154145"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.32832404),
        dec: Angle.Degrees(-14.97585176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69772"},
        {"Hipparcos Number", "HIP 40661"},
        {"Smithsonian Astrophysical Observation", "SAO 154083"},
        {"Wilson Evans Batten Catalogue", "WEB 7901"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.50475636),
        dec: Angle.Degrees(-14.97492093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196693"},
        {"Hipparcos Number", "HIP 101947"},
        {"Smithsonian Astrophysical Observation", "SAO 163775"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.88673267),
        dec: Angle.Degrees(-14.97475978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214271"},
        {"Hipparcos Number", "HIP 111665"},
        {"Smithsonian Astrophysical Observation", "SAO 165200"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.31593122),
        dec: Angle.Degrees(-14.97336422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165442"},
        {"Hipparcos Number", "HIP 88706"},
        {"Geneva Identification System", "GEN# +1.00165442"},
        {"Smithsonian Astrophysical Observation", "SAO 161074"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.64264947),
        dec: Angle.Degrees(-14.97292600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3325"},
        {"Hipparcos Number", "HIP 2846"},
        {"Geneva Identification System", "GEN# +1.00003325"},
        {"Smithsonian Astrophysical Observation", "SAO 147360"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.01331466),
        dec: Angle.Degrees(-14.97289122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122837"},
        {"Hipparcos Number", "HIP 68763"},
        {"Fundamental Katalog 5th Edition", "FK5 1365"},
        {"Geneva Identification System", "GEN# +1.00122837"},
        {"Smithsonian Astrophysical Observation", "SAO 158325"},
        {"Wilson Evans Batten Catalogue", "WEB 12029"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11250791),
        dec: Angle.Degrees(-14.97165584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24522"},
        {"Hipparcos Number", "HIP 18192"},
        {"Smithsonian Astrophysical Observation", "SAO 149232"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.37730102),
        dec: Angle.Degrees(-14.97054237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15212"},
        {"Hipparcos Number", "HIP 11386"},
        {"Geneva Identification System", "GEN# +1.00015212"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.68500082),
        dec: Angle.Degrees(-14.96931115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90431"},
        {"Hipparcos Number", "HIP 51076"},
        {"Smithsonian Astrophysical Observation", "SAO 155981"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.53982121),
        dec: Angle.Degrees(-14.96819248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111962"},
        {"Hipparcos Number", "HIP 62872"},
        {"Geneva Identification System", "GEN# +1.00111962"},
        {"Smithsonian Astrophysical Observation", "SAO 157569"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.28971769),
        dec: Angle.Degrees(-14.96566082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59856"},
        {"Hipparcos Number", "HIP 36569"},
        {"Smithsonian Astrophysical Observation", "SAO 153001"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.83300253),
        dec: Angle.Degrees(-14.96557749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6066"},
        {"Hipparcos Number", "HIP 4814"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.44565323),
        dec: Angle.Degrees(-14.96475614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211344"},
        {"Hipparcos Number", "HIP 109997"},
        {"Geneva Identification System", "GEN# +1.00211344"},
        {"Smithsonian Astrophysical Observation", "SAO 164972"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.18898160),
        dec: Angle.Degrees(-14.96322734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85026"},
        {"Wilson Evans Batten Catalogue", "WEB 14360"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.67933648),
        dec: Angle.Degrees(-14.95980533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15651"},
        {"Hipparcos Number", "HIP 11681"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.66743555),
        dec: Angle.Degrees(-14.95806353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48937"},
        {"Hipparcos Number", "HIP 32386"},
        {"Smithsonian Astrophysical Observation", "SAO 151888"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.38457403),
        dec: Angle.Degrees(-14.95737337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24630"},
        {"Smithsonian Astrophysical Observation", "SAO 150297"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.25503413),
        dec: Angle.Degrees(-14.95567218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128598"},
        {"Hipparcos Number", "HIP 71567"},
        {"Smithsonian Astrophysical Observation", "SAO 158687"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.54921286),
        dec: Angle.Degrees(-14.95473933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14099 AB"},
        {"Henry Draper", "HD 196662"},
        {"Hipparcos Number", "HIP 101923"},
        {"Geneva Identification System", "GEN# +1.00196662"},
        {"Smithsonian Astrophysical Observation", "SAO 163771"},
        {"Wilson Evans Batten Catalogue", "WEB 18419"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.81798449),
        dec: Angle.Degrees(-14.95471233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5144 A"},
        {"Henry Draper", "HD 46035"},
        {"Hipparcos Number", "HIP 31017"},
        {"Smithsonian Astrophysical Observation", "SAO 151583"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.62411952),
        dec: Angle.Degrees(-14.95436772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137650"},
        {"Hipparcos Number", "HIP 75680"},
        {"Smithsonian Astrophysical Observation", "SAO 159275"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92415084),
        dec: Angle.Degrees(-14.95420172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40229"},
        {"Smithsonian Astrophysical Observation", "SAO 153985"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.24518475),
        dec: Angle.Degrees(-14.95219661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122171"},
        {"Hipparcos Number", "HIP 68425"},
        {"Fundamental Katalog 5th Edition", "FK5 5241"},
        {"Smithsonian Astrophysical Observation", "SAO 158285"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.11765399),
        dec: Angle.Degrees(-14.95206920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209383"},
        {"Hipparcos Number", "HIP 108882"},
        {"Smithsonian Astrophysical Observation", "SAO 164837"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.84594921),
        dec: Angle.Degrees(-14.95173814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212627"},
        {"Hipparcos Number", "HIP 110723"},
        {"Geneva Identification System", "GEN# +1.00212627"},
        {"Smithsonian Astrophysical Observation", "SAO 165066"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.49938924),
        dec: Angle.Degrees(-14.95169794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33844"},
        {"Hipparcos Number", "HIP 24275"},
        {"Geneva Identification System", "GEN# +1.00033844"},
        {"Smithsonian Astrophysical Observation", "SAO 150228"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.15033563),
        dec: Angle.Degrees(-14.95118636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212270"},
        {"Hipparcos Number", "HIP 110518"},
        {"Geneva Identification System", "GEN# +1.00212270"},
        {"Smithsonian Astrophysical Observation", "SAO 165032"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.83524700),
        dec: Angle.Degrees(-14.95085520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112385"},
        {"Hipparcos Number", "HIP 63151"},
        {"Geneva Identification System", "GEN# +1.00112385"},
        {"Smithsonian Astrophysical Observation", "SAO 157609"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.10780884),
        dec: Angle.Degrees(-14.94958277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8547 AB"},
        {"Henry Draper", "HD 108215"},
        {"Hipparcos Number", "HIP 60665"},
        {"Smithsonian Astrophysical Observation", "SAO 157283"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.49870483),
        dec: Angle.Degrees(-14.94771989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32707"},
        {"Hipparcos Number", "HIP 23610"},
        {"Smithsonian Astrophysical Observation", "SAO 150121"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.15191444),
        dec: Angle.Degrees(-14.94742579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79047"},
        {"Hipparcos Number", "HIP 45102"},
        {"Smithsonian Astrophysical Observation", "SAO 154982"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.82413047),
        dec: Angle.Degrees(-14.94740097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16202"},
        {"Hipparcos Number", "HIP 12070"},
        {"Smithsonian Astrophysical Observation", "SAO 148487"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.91014955),
        dec: Angle.Degrees(-14.94496334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31321"},
        {"Hipparcos Number", "HIP 22790"},
        {"Renson", "Renson 8027"},
        {"Smithsonian Astrophysical Observation", "SAO 149975"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.54814570),
        dec: Angle.Degrees(-14.94336020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13279",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13279"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.72584335),
        dec: Angle.Degrees(-14.93988935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10035"},
        {"Hipparcos Number", "HIP 7595"},
        {"Smithsonian Astrophysical Observation", "SAO 147919"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.46076068),
        dec: Angle.Degrees(-14.93918723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106953"},
        {"Hipparcos Number", "HIP 59974"},
        {"Smithsonian Astrophysical Observation", "SAO 157196"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.50074060),
        dec: Angle.Degrees(-14.93822508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19179"},
        {"Hipparcos Number", "HIP 14320"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.17387835),
        dec: Angle.Degrees(-14.93670788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221399"},
        {"Hipparcos Number", "HIP 116142"},
        {"Smithsonian Astrophysical Observation", "SAO 165741"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98425509),
        dec: Angle.Degrees(-14.93669469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187411"},
        {"Hipparcos Number", "HIP 97614"},
        {"Geneva Identification System", "GEN# +1.00187411"},
        {"Smithsonian Astrophysical Observation", "SAO 163027"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.59412270),
        dec: Angle.Degrees(-14.93669224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41695"},
        {"Hipparcos Number", "HIP 28910"},
        {"Fundamental Katalog 5th Edition", "FK5 2466"},
        {"Geneva Identification System", "GEN# +1.00041695"},
        {"Smithsonian Astrophysical Observation", "SAO 151110"},
        {"Wilson Evans Batten Catalogue", "WEB 5659"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.53889172),
        dec: Angle.Degrees(-14.93528629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71518"},
        {"Hipparcos Number", "HIP 41463"},
        {"Geneva Identification System", "GEN# +1.00071518"},
        {"Smithsonian Astrophysical Observation", "SAO 154273"},
        {"Wilson Evans Batten Catalogue", "WEB 8016"},
    },
    visualMagnitude: 6.68,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.86198246),
        dec: Angle.Degrees(-14.93521548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84886"},
        {"Hipparcos Number", "HIP 48067"},
        {"Smithsonian Astrophysical Observation", "SAO 155484"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.98211292),
        dec: Angle.Degrees(-14.93455052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27064"},
        {"Hipparcos Number", "HIP 19897"},
        {"Smithsonian Astrophysical Observation", "SAO 149496"},
        {"Wilson Evans Batten Catalogue", "WEB 3803"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.01614493),
        dec: Angle.Degrees(-14.93025087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183944"},
        {"Hipparcos Number", "HIP 96105"},
        {"Smithsonian Astrophysical Observation", "SAO 162736"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.09721856),
        dec: Angle.Degrees(-14.92996894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71267"},
        {"Hipparcos Number", "HIP 41328"},
        {"Fundamental Katalog 5th Edition", "FK5 2657"},
        {"Geneva Identification System", "GEN# +1.00071267"},
        {"Renson", "Renson 19690"},
        {"Smithsonian Astrophysical Observation", "SAO 154244"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.48165253),
        dec: Angle.Degrees(-14.92975540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65319",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8881 AB"},
        {"Henry Draper", "HD 116331"},
        {"Hipparcos Number", "HIP 65319"},
        {"Smithsonian Astrophysical Observation", "SAO 157905"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.81450835),
        dec: Angle.Degrees(-14.92675209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19934"},
        {"Hipparcos Number", "HIP 14849"},
        {"Smithsonian Astrophysical Observation", "SAO 148824"},
        {"Wilson Evans Batten Catalogue", "WEB 2868"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.94442377),
        dec: Angle.Degrees(-14.92584307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30303"},
        {"Hipparcos Number", "HIP 22132"},
        {"Smithsonian Astrophysical Observation", "SAO 149866"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.44494777),
        dec: Angle.Degrees(-14.92580185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3340 AB"},
        {"Henry Draper", "HD 29368"},
        {"Hipparcos Number", "HIP 21488"},
        {"Smithsonian Astrophysical Observation", "SAO 149763"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.22454508),
        dec: Angle.Degrees(-14.92577760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167498"},
        {"Hipparcos Number", "HIP 89518"},
        {"Smithsonian Astrophysical Observation", "SAO 161237"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.00891879),
        dec: Angle.Degrees(-14.92417548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14699"},
        {"Hipparcos Number", "HIP 11025"},
        {"Smithsonian Astrophysical Observation", "SAO 148355"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.49642909),
        dec: Angle.Degrees(-14.92298336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14906 AB"},
        {"Henry Draper", "HD 203407"},
        {"Hipparcos Number", "HIP 105519"},
        {"Geneva Identification System", "GEN# +1.00203407J"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.56862773),
        dec: Angle.Degrees(-14.91960087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211937"},
        {"Hipparcos Number", "HIP 110350"},
        {"Geneva Identification System", "GEN# +1.00211937"},
        {"Smithsonian Astrophysical Observation", "SAO 165016"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25432615),
        dec: Angle.Degrees(-14.91865812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113817"},
        {"Hipparcos Number", "HIP 63960"},
        {"Smithsonian Astrophysical Observation", "SAO 157723"},
        {"Wilson Evans Batten Catalogue", "WEB 11307"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.61254797),
        dec: Angle.Degrees(-14.91606873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8059"},
        {"Hipparcos Number", "HIP 6228"},
        {"Geneva Identification System", "GEN# +1.00008059"},
        {"Smithsonian Astrophysical Observation", "SAO 147739"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.95761952),
        dec: Angle.Degrees(-14.91378055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125166"},
        {"Hipparcos Number", "HIP 69882"},
        {"Geneva Identification System", "GEN# +1.00125166"},
        {"Smithsonian Astrophysical Observation", "SAO 158476"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.52185469),
        dec: Angle.Degrees(-14.91199306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190613"},
        {"Hipparcos Number", "HIP 99034"},
        {"Geneva Identification System", "GEN# +1.00190613"},
        {"Smithsonian Astrophysical Observation", "SAO 163263"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.59965904),
        dec: Angle.Degrees(-14.91182054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144091"},
        {"Hipparcos Number", "HIP 78753"},
        {"Smithsonian Astrophysical Observation", "SAO 159674"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.17581803),
        dec: Angle.Degrees(-14.91019179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205829"},
        {"Hipparcos Number", "HIP 106829"},
        {"Geneva Identification System", "GEN# +1.00205829"},
        {"Smithsonian Astrophysical Observation", "SAO 164538"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.55809702),
        dec: Angle.Degrees(-14.91006013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151527"},
        {"Hipparcos Number", "HIP 82259"},
        {"Fundamental Katalog 5th Edition", "FK5 3335"},
        {"Geneva Identification System", "GEN# +1.00151527"},
        {"Smithsonian Astrophysical Observation", "SAO 160104"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.11243757),
        dec: Angle.Degrees(-14.90939987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132053"},
        {"Hipparcos Number", "HIP 73187"},
        {"Smithsonian Astrophysical Observation", "SAO 158923"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.37029411),
        dec: Angle.Degrees(-14.90930590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162919"},
        {"Hipparcos Number", "HIP 87640"},
        {"Geneva Identification System", "GEN# +1.00162919"},
        {"Smithsonian Astrophysical Observation", "SAO 160894"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.52644733),
        dec: Angle.Degrees(-14.90788034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13722"},
        {"Hipparcos Number", "HIP 10348"},
        {"Geneva Identification System", "GEN# +1.00013722"},
        {"Smithsonian Astrophysical Observation", "SAO 148274"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.32962667),
        dec: Angle.Degrees(-14.90755535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198096"},
        {"Hipparcos Number", "HIP 102691"},
        {"Smithsonian Astrophysical Observation", "SAO 163898"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.11632305),
        dec: Angle.Degrees(-14.90620715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24693"},
        {"Hipparcos Number", "HIP 18318"},
        {"Fundamental Katalog 5th Edition", "FK5 4354"},
        {"Smithsonian Astrophysical Observation", "SAO 149250"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.74423461),
        dec: Angle.Degrees(-14.90588983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6443"},
        {"Hipparcos Number", "HIP 5087"},
        {"Smithsonian Astrophysical Observation", "SAO 147598"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.29325872),
        dec: Angle.Degrees(-14.90568317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200729"},
        {"Hipparcos Number", "HIP 104121"},
        {"Smithsonian Astrophysical Observation", "SAO 164131"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.41051742),
        dec: Angle.Degrees(-14.90485373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201202"},
        {"Hipparcos Number", "HIP 104353"},
        {"Smithsonian Astrophysical Observation", "SAO 164167"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.10947860),
        dec: Angle.Degrees(-14.90431964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14788"},
        {"Hipparcos Number", "HIP 11088"},
        {"Geneva Identification System", "GEN# +1.00014788"},
        {"Smithsonian Astrophysical Observation", "SAO 148362"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.68973403),
        dec: Angle.Degrees(-14.90123450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2571"},
        {"Smithsonian Astrophysical Observation", "SAO 147328"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.15937110),
        dec: Angle.Degrees(-14.90059041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78920"},
        {"Hipparcos Number", "HIP 45039"},
        {"Geneva Identification System", "GEN# +1.00078920"},
        {"Smithsonian Astrophysical Observation", "SAO 154973"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.60336575),
        dec: Angle.Degrees(-14.90016932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94837"},
        {"Hipparcos Number", "HIP 53511"},
        {"Smithsonian Astrophysical Observation", "SAO 156345"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.20530261),
        dec: Angle.Degrees(-14.89924349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110847"},
        {"Hipparcos Number", "HIP 62222"},
        {"Geneva Identification System", "GEN# +1.00110847"},
        {"Smithsonian Astrophysical Observation", "SAO 157489"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.28251722),
        dec: Angle.Degrees(-14.89785926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209767"},
        {"Hipparcos Number", "HIP 109122"},
        {"Geneva Identification System", "GEN# +1.00209767"},
        {"Smithsonian Astrophysical Observation", "SAO 164860"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55435503),
        dec: Angle.Degrees(-14.89599202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10341"},
        {"Hipparcos Number", "HIP 7835"},
        {"Smithsonian Astrophysical Observation", "SAO 147956"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.20272163),
        dec: Angle.Degrees(-14.89206286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94016"},
        {"Hipparcos Number", "HIP 53022"},
        {"Fundamental Katalog 5th Edition", "FK5 4958"},
        {"Geneva Identification System", "GEN# +1.00094016"},
        {"Smithsonian Astrophysical Observation", "SAO 156269"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.72664951),
        dec: Angle.Degrees(-14.89140771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4972"},
        {"Hipparcos Number", "HIP 4024"},
        {"Geneva Identification System", "GEN# +1.00004972"},
        {"Smithsonian Astrophysical Observation", "SAO 147481"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.89365663),
        dec: Angle.Degrees(-14.89000959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -278.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20636"},
        {"Hipparcos Number", "HIP 15431"},
        {"Geneva Identification System", "GEN# +1.00020636"},
        {"Smithsonian Astrophysical Observation", "SAO 148899"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.71998864),
        dec: Angle.Degrees(-14.88677026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21489"},
        {"Smithsonian Astrophysical Observation", "SAO 149764"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.22657739),
        dec: Angle.Degrees(-14.88632470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91207"},
        {"Hipparcos Number", "HIP 51542"},
        {"Smithsonian Astrophysical Observation", "SAO 156037"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.90788071),
        dec: Angle.Degrees(-14.88508936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6490"},
        {"Hipparcos Number", "HIP 5136"},
        {"Geneva Identification System", "GEN# +1.00006490"},
        {"Smithsonian Astrophysical Observation", "SAO 147604"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.44639233),
        dec: Angle.Degrees(-14.88463891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13315"},
        {"Hipparcos Number", "HIP 10095"},
        {"Smithsonian Astrophysical Observation", "SAO 148247"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.44419988),
        dec: Angle.Degrees(-14.88452866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58462"},
        {"Hipparcos Number", "HIP 35995"},
        {"Celescope Catalog", "CEL 1835"},
        {"Geneva Identification System", "GEN# +1.00058462"},
        {"Smithsonian Astrophysical Observation", "SAO 152839"},
        {"Wilson Evans Batten Catalogue", "WEB 7169"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.27835392),
        dec: Angle.Degrees(-14.88323228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176923"},
        {"Hipparcos Number", "HIP 93536"},
        {"Smithsonian Astrophysical Observation", "SAO 162134"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.76304858),
        dec: Angle.Degrees(-14.88025082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195881"},
        {"Hipparcos Number", "HIP 101523"},
        {"Smithsonian Astrophysical Observation", "SAO 163695"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.61018010),
        dec: Angle.Degrees(-14.87929855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136699"},
        {"Hipparcos Number", "HIP 75254"},
        {"Smithsonian Astrophysical Observation", "SAO 159205"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65307166),
        dec: Angle.Degrees(-14.87874176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146281"},
        {"Hipparcos Number", "HIP 79711"},
        {"Geneva Identification System", "GEN# +1.00146281"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01713142),
        dec: Angle.Degrees(-14.87771215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21064"},
        {"Hipparcos Number", "HIP 15784"},
        {"Geneva Identification System", "GEN# +1.00021064"},
        {"Smithsonian Astrophysical Observation", "SAO 148934"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.85436010),
        dec: Angle.Degrees(-14.87616888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19393"},
        {"Hipparcos Number", "HIP 14465"},
        {"Smithsonian Astrophysical Observation", "SAO 148774"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.67334270),
        dec: Angle.Degrees(-14.87615346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5589"},
        {"Hipparcos Number", "HIP 4489"},
        {"Smithsonian Astrophysical Observation", "SAO 147535"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.38717047),
        dec: Angle.Degrees(-14.87556978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31516"},
        {"Hipparcos Number", "HIP 22924"},
        {"Smithsonian Astrophysical Observation", "SAO 150000"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.99397213),
        dec: Angle.Degrees(-14.87409054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146850"},
        {"Hipparcos Number", "HIP 79938"},
        {"Geneva Identification System", "GEN# +1.00146850"},
        {"Smithsonian Astrophysical Observation", "SAO 159846"},
        {"Wilson Evans Batten Catalogue", "WEB 13530"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.75180357),
        dec: Angle.Degrees(-14.87282262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114110"},
    },
    visualMagnitude: 12.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66203219),
        dec: Angle.Degrees(-14.87239655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53693"},
        {"Hipparcos Number", "HIP 34204"},
        {"Fundamental Katalog 5th Edition", "FK5 4638"},
        {"Smithsonian Astrophysical Observation", "SAO 152357"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.38828380),
        dec: Angle.Degrees(-14.87203180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57435"},
        {"Hipparcos Number", "HIP 35586"},
        {"Geneva Identification System", "GEN# +1.00057435"},
        {"Smithsonian Astrophysical Observation", "SAO 152744"},
        {"Wilson Evans Batten Catalogue", "WEB 7088"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.15438154),
        dec: Angle.Degrees(-14.87106755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210897"},
        {"Hipparcos Number", "HIP 109751"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.46499569),
        dec: Angle.Degrees(-14.86967011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153229"},
        {"Hipparcos Number", "HIP 83090"},
        {"Fundamental Katalog 5th Edition", "FK5 3348"},
        {"Geneva Identification System", "GEN# +1.00153229"},
        {"Smithsonian Astrophysical Observation", "SAO 160205"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.67317572),
        dec: Angle.Degrees(-14.86961006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138687"},
        {"Hipparcos Number", "HIP 76211"},
        {"Smithsonian Astrophysical Observation", "SAO 159352"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.52309533),
        dec: Angle.Degrees(-14.86853280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81863"},
        {"Hipparcos Number", "HIP 46413"},
        {"Geneva Identification System", "GEN# +1.00081863"},
        {"Smithsonian Astrophysical Observation", "SAO 155213"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.97471138),
        dec: Angle.Degrees(-14.86806801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170975"},
        {"Hipparcos Number", "HIP 90913"},
        {"Geneva Identification System", "GEN# +1.00170975"},
        {"Smithsonian Astrophysical Observation", "SAO 161587"},
        {"Wilson Evans Batten Catalogue", "WEB 15593"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.18050927),
        dec: Angle.Degrees(-14.86565430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141830"},
        {"Hipparcos Number", "HIP 77686"},
        {"Geneva Identification System", "GEN# +1.00141830"},
        {"Smithsonian Astrophysical Observation", "SAO 159543"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.90724008),
        dec: Angle.Degrees(-14.86563320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104026"},
        {"Hipparcos Number", "HIP 58424"},
        {"Smithsonian Astrophysical Observation", "SAO 157026"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.69582437),
        dec: Angle.Degrees(-14.86561957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2630"},
        {"Hipparcos Number", "HIP 2337"},
        {"Fundamental Katalog 5th Edition", "FK5 2030"},
        {"Geneva Identification System", "GEN# +1.00002630"},
        {"Smithsonian Astrophysical Observation", "SAO 147307"},
        {"Wilson Evans Batten Catalogue", "WEB 427"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46586901),
        dec: Angle.Degrees(-14.86402653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218251"},
        {"Hipparcos Number", "HIP 114113"},
        {"Geneva Identification System", "GEN# +1.00218251"},
        {"Smithsonian Astrophysical Observation", "SAO 165499"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66310438),
        dec: Angle.Degrees(-14.86389836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95696"},
        {"Hipparcos Number", "HIP 53988"},
        {"Smithsonian Astrophysical Observation", "SAO 156419"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.66393237),
        dec: Angle.Degrees(-14.86370375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50959"},
        {"Hipparcos Number", "HIP 33232"},
        {"Geneva Identification System", "GEN# +1.00050959"},
        {"Smithsonian Astrophysical Observation", "SAO 152090"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.72151467),
        dec: Angle.Degrees(-14.86258992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7386"},
        {"Hipparcos Number", "HIP 5756"},
        {"Smithsonian Astrophysical Observation", "SAO 147681"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.46985232),
        dec: Angle.Degrees(-14.86218189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19954"},
        {"Smithsonian Astrophysical Observation", "SAO 149506"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.18926654),
        dec: Angle.Degrees(-14.85970389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105326"},
        {"Hipparcos Number", "HIP 59139"},
        {"Smithsonian Astrophysical Observation", "SAO 157093"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.90120099),
        dec: Angle.Degrees(-14.85954802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223314"},
        {"Hipparcos Number", "HIP 117425"},
        {"Smithsonian Astrophysical Observation", "SAO 165894"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.14733625),
        dec: Angle.Degrees(-14.85845973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122270"},
        {"Hipparcos Number", "HIP 68480"},
        {"Smithsonian Astrophysical Observation", "SAO 158292"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.29759674),
        dec: Angle.Degrees(-14.85844374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175623"},
        {"Hipparcos Number", "HIP 93000"},
        {"Geneva Identification System", "GEN# +1.00175623"},
        {"Smithsonian Astrophysical Observation", "SAO 162012"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19205885),
        dec: Angle.Degrees(-14.85767804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122956"},
        {"Hipparcos Number", "HIP 68807"},
        {"Geneva Identification System", "GEN# +1.00122956"},
        {"Smithsonian Astrophysical Observation", "SAO 158333"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.30450493),
        dec: Angle.Degrees(-14.85696393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37507"},
        {"New General Catalogue", "NGC 2437 104"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.45774382),
        dec: Angle.Degrees(-14.85420638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171130"},
        {"Hipparcos Number", "HIP 90991"},
        {"Geneva Identification System", "GEN# +1.00171130"},
        {"Smithsonian Astrophysical Observation", "SAO 161605"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.41251698),
        dec: Angle.Degrees(-14.85359142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5167"},
        {"Hipparcos Number", "HIP 4188"},
        {"Smithsonian Astrophysical Observation", "SAO 147497"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.37066380),
        dec: Angle.Degrees(-14.85185277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83344"},
        {"Hipparcos Number", "HIP 47213"},
        {"Smithsonian Astrophysical Observation", "SAO 155344"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.32673962),
        dec: Angle.Degrees(-14.85109272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96738",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12748 A"},
        {"Henry Draper", "HD 185514"},
        {"Hipparcos Number", "HIP 96738"},
        {"Smithsonian Astrophysical Observation", "SAO 162864"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.97505463),
        dec: Angle.Degrees(-14.84931688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146254"},
        {"Hipparcos Number", "HIP 79692"},
        {"Fundamental Katalog 5th Edition", "FK5 3286"},
        {"Geneva Identification System", "GEN# +1.00146254"},
        {"Renson", "Renson 41360"},
        {"Smithsonian Astrophysical Observation", "SAO 159821"},
        {"Wilson Evans Batten Catalogue", "WEB 13487"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.96454630),
        dec: Angle.Degrees(-14.84911862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167812"},
        {"Hipparcos Number", "HIP 89626"},
        {"Smithsonian Astrophysical Observation", "SAO 161268"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.35838440),
        dec: Angle.Degrees(-14.84898724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173615"},
        {"Hipparcos Number", "HIP 92139"},
        {"Smithsonian Astrophysical Observation", "SAO 161815"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.69300178),
        dec: Angle.Degrees(-14.84805606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56617"},
        {"Hipparcos Number", "HIP 35258"},
        {"Geneva Identification System", "GEN# +1.00056617"},
        {"Smithsonian Astrophysical Observation", "SAO 152663"},
        {"Wilson Evans Batten Catalogue", "WEB 7040"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.27415185),
        dec: Angle.Degrees(-14.84719433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168444"},
        {"Hipparcos Number", "HIP 89856"},
        {"Geneva Identification System", "GEN# +1.00168444"},
        {"Smithsonian Astrophysical Observation", "SAO 161352"},
        {"Wilson Evans Batten Catalogue", "WEB 15342"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.06371858),
        dec: Angle.Degrees(-14.84687642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48356",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zhang"},
        {"Henry Draper", "HD 85444"},
        {"Hipparcos Number", "HIP 48356"},
        {"Fundamental Katalog 5th Edition", "FK5 2786"},
        {"Geneva Identification System", "GEN# +1.00085444"},
        {"Smithsonian Astrophysical Observation", "SAO 155542"},
        {"Wilson Evans Batten Catalogue", "WEB 9021"},
    },
    visualMagnitude: 4.11,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.86951033),
        dec: Angle.Degrees(-14.84654997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64238"},
        {"Hipparcos Number", "HIP 38427"},
        {"Geneva Identification System", "GEN# +1.00064238"},
        {"Smithsonian Astrophysical Observation", "SAO 153520"},
        {"Wilson Evans Batten Catalogue", "WEB 7556"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.07868058),
        dec: Angle.Degrees(-14.84617833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44007"},
        {"Hipparcos Number", "HIP 29992"},
        {"Geneva Identification System", "GEN# +1.00044007"},
        {"Smithsonian Astrophysical Observation", "SAO 151345"},
        {"Wilson Evans Batten Catalogue", "WEB 5953"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.70199096),
        dec: Angle.Degrees(-14.84529694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224134"},
        {"Hipparcos Number", "HIP 117949"},
        {"Smithsonian Astrophysical Observation", "SAO 165953"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.87635378),
        dec: Angle.Degrees(-14.84515270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7985"},
        {"Hipparcos Number", "HIP 6164"},
        {"Geneva Identification System", "GEN# +1.00007985"},
        {"Smithsonian Astrophysical Observation", "SAO 147734"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.76687842),
        dec: Angle.Degrees(-14.84418717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103173"},
        {"Hipparcos Number", "HIP 57919"},
        {"Smithsonian Astrophysical Observation", "SAO 156956"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19124125),
        dec: Angle.Degrees(-14.84193814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107088",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15216 A"},
        {"Henry Draper", "HD 206288"},
        {"Hipparcos Number", "HIP 107088"},
        {"Smithsonian Astrophysical Observation", "SAO 164579"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.36707505),
        dec: Angle.Degrees(-14.84141085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59156"},
        {"Hipparcos Number", "HIP 36280"},
        {"Smithsonian Astrophysical Observation", "SAO 152917"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.03497226),
        dec: Angle.Degrees(-14.84041485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71055"},
        {"Hipparcos Number", "HIP 41234"},
        {"Smithsonian Astrophysical Observation", "SAO 154229"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.21072963),
        dec: Angle.Degrees(-14.83895816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126679"},
        {"Hipparcos Number", "HIP 70677"},
        {"Geneva Identification System", "GEN# +1.00126679"},
        {"Smithsonian Astrophysical Observation", "SAO 158573"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.83947897),
        dec: Angle.Degrees(-14.83863299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20222"},
        {"Hipparcos Number", "HIP 15085"},
        {"Geneva Identification System", "GEN# +1.00020222"},
        {"Smithsonian Astrophysical Observation", "SAO 148853"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.63929569),
        dec: Angle.Degrees(-14.83803754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180110"},
        {"Hipparcos Number", "HIP 94657"},
        {"Geneva Identification System", "GEN# +1.00180110"},
        {"Smithsonian Astrophysical Observation", "SAO 162376"},
        {"Wilson Evans Batten Catalogue", "WEB 16503"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.92669278),
        dec: Angle.Degrees(-14.83768877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4890"},
        {"Hipparcos Number", "HIP 3953"},
        {"Smithsonian Astrophysical Observation", "SAO 147474"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.68775202),
        dec: Angle.Degrees(-14.83728926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44800"},
        {"Hipparcos Number", "HIP 30381"},
        {"Geneva Identification System", "GEN# +1.00044800"},
        {"Smithsonian Astrophysical Observation", "SAO 151438"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.82658178),
        dec: Angle.Degrees(-14.83532641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15071"},
        {"Geneva Identification System", "GEN# -0.01500560"},
        {"Wilson Evans Batten Catalogue", "WEB 2902"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.57000066),
        dec: Angle.Degrees(-14.83415233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204312"},
        {"Hipparcos Number", "HIP 105997"},
        {"Smithsonian Astrophysical Observation", "SAO 164410"},
    },
    visualMagnitude: 9.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.01569886),
        dec: Angle.Degrees(-14.83314559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35307"},
        {"Hipparcos Number", "HIP 25188"},
        {"Smithsonian Astrophysical Observation", "SAO 150392"},
        {"Wilson Evans Batten Catalogue", "WEB 4880"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.82851314),
        dec: Angle.Degrees(-14.83307377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1523"},
        {"Hipparcos Number", "HIP 1556"},
        {"Fundamental Katalog 5th Edition", "FK5 4035"},
        {"Smithsonian Astrophysical Observation", "SAO 147215"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84362636),
        dec: Angle.Degrees(-14.83279038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200328"},
        {"Hipparcos Number", "HIP 103907"},
        {"Smithsonian Astrophysical Observation", "SAO 164098"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.80516656),
        dec: Angle.Degrees(-14.83190675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153117"},
        {"Hipparcos Number", "HIP 83029"},
        {"Smithsonian Astrophysical Observation", "SAO 160192"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.50595048),
        dec: Angle.Degrees(-14.83171963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142703"},
        {"Hipparcos Number", "HIP 78078"},
        {"Geneva Identification System", "GEN# +1.00142703"},
        {"Smithsonian Astrophysical Observation", "SAO 159587"},
        {"Wilson Evans Batten Catalogue", "WEB 13205"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.13887891),
        dec: Angle.Degrees(-14.82935289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204433"},
        {"Hipparcos Number", "HIP 106050"},
        {"Smithsonian Astrophysical Observation", "SAO 164420"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.20852162),
        dec: Angle.Degrees(-14.82612726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 361"},
        {"Hipparcos Number", "HIP 669"},
        {"Geneva Identification System", "GEN# +1.00000361"},
        {"Smithsonian Astrophysical Observation", "SAO 147100"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.06820906),
        dec: Angle.Degrees(-14.82446576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139864"},
        {"Hipparcos Number", "HIP 76816"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.25808529),
        dec: Angle.Degrees(-14.82323821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202495"},
        {"Hipparcos Number", "HIP 105042"},
        {"Smithsonian Astrophysical Observation", "SAO 164269"},
        {"Wilson Evans Batten Catalogue", "WEB 19083"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.14964103),
        dec: Angle.Degrees(-14.82314840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38678"},
        {"Hipparcos Number", "HIP 27288"},
        {"Fundamental Katalog 5th Edition", "FK5 219"},
        {"Geneva Identification System", "GEN# +1.00038678"},
        {"Smithsonian Astrophysical Observation", "SAO 150801"},
        {"Wilson Evans Batten Catalogue", "WEB 5364"},
    },
    visualMagnitude: 3.55,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.73895728),
        dec: Angle.Degrees(-14.82194717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62000"},
        {"Hipparcos Number", "HIP 37464"},
        {"Geneva Identification System", "GEN# +2.24370002"},
        {"Smithsonian Astrophysical Observation", "SAO 153250"},
        {"New General Catalogue", "NGC 2437 2"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.34544590),
        dec: Angle.Degrees(-14.81974723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51729"},
        {"Hipparcos Number", "HIP 33521"},
        {"Smithsonian Astrophysical Observation", "SAO 152174"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50527826),
        dec: Angle.Degrees(-14.81971736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145594"},
        {"Hipparcos Number", "HIP 79405"},
        {"Smithsonian Astrophysical Observation", "SAO 159771"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.07824845),
        dec: Angle.Degrees(-14.81551590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175432"},
        {"Hipparcos Number", "HIP 92913"},
        {"Geneva Identification System", "GEN# +1.00175432"},
        {"Smithsonian Astrophysical Observation", "SAO 161994"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.96072567),
        dec: Angle.Degrees(-14.81547104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46500"},
        {"Hipparcos Number", "HIP 31253"},
        {"Smithsonian Astrophysical Observation", "SAO 151635"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.32542688),
        dec: Angle.Degrees(-14.81418150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138042"},
        {"Hipparcos Number", "HIP 75879"},
        {"Smithsonian Astrophysical Observation", "SAO 159297"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.48625254),
        dec: Angle.Degrees(-14.81408979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49463"},
        {"Smithsonian Astrophysical Observation", "SAO 155723"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.47055204),
        dec: Angle.Degrees(-14.81041374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221366"},
        {"Hipparcos Number", "HIP 116123"},
        {"Smithsonian Astrophysical Observation", "SAO 165738"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.93764379),
        dec: Angle.Degrees(-14.80670561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31996"},
        {"Hipparcos Number", "HIP 23203"},
        {"Geneva Identification System", "GEN# +1.00031996"},
        {"Smithsonian Astrophysical Observation", "SAO 150058"},
        {"Wilson Evans Batten Catalogue", "WEB 4505"},
    },
    visualMagnitude: 8.08,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.90143509),
        dec: Angle.Degrees(-14.80624885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1037"},
        {"Hipparcos Number", "HIP 1176"},
        {"Geneva Identification System", "GEN# +1.00001037"},
        {"Smithsonian Astrophysical Observation", "SAO 147170"},
        {"Wilson Evans Batten Catalogue", "WEB 209"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.66828731),
        dec: Angle.Degrees(-14.80514201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26095"},
        {"Smithsonian Astrophysical Observation", "SAO 150567"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.47861482),
        dec: Angle.Degrees(-14.80482281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128006"},
        {"Hipparcos Number", "HIP 71299"},
        {"Smithsonian Astrophysical Observation", "SAO 158654"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.72073881),
        dec: Angle.Degrees(-14.80354214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152128"},
        {"Hipparcos Number", "HIP 82525"},
        {"Geneva Identification System", "GEN# +1.00152128"},
        {"Smithsonian Astrophysical Observation", "SAO 160133"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.01914155),
        dec: Angle.Degrees(-14.80294659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83074"},
        {"Hipparcos Number", "HIP 47071"},
        {"Smithsonian Astrophysical Observation", "SAO 155321"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.89224606),
        dec: Angle.Degrees(-14.80278543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207688"},
        {"Hipparcos Number", "HIP 107861"},
        {"Smithsonian Astrophysical Observation", "SAO 164692"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.78444273),
        dec: Angle.Degrees(-14.79889548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156460"},
        {"Hipparcos Number", "HIP 84640"},
        {"Smithsonian Astrophysical Observation", "SAO 160437"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.55544695),
        dec: Angle.Degrees(-14.79884989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20339"},
        {"Hipparcos Number", "HIP 15199"},
        {"Geneva Identification System", "GEN# +1.00020339"},
        {"Smithsonian Astrophysical Observation", "SAO 148868"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.97234119),
        dec: Angle.Degrees(-14.79882531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56045"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.29950172),
        dec: Angle.Degrees(-14.79730633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49048"},
        {"Hipparcos Number", "HIP 32411"},
        {"Celescope Catalog", "CEL 1375"},
        {"Geneva Identification System", "GEN# +1.00049048"},
        {"Smithsonian Astrophysical Observation", "SAO 151895"},
        {"Wilson Evans Batten Catalogue", "WEB 6537"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49750507),
        dec: Angle.Degrees(-14.79608441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78055"},
        {"Hipparcos Number", "HIP 44639"},
        {"Smithsonian Astrophysical Observation", "SAO 154900"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.44351523),
        dec: Angle.Degrees(-14.79567842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121463"},
        {"Hipparcos Number", "HIP 68025"},
        {"Geneva Identification System", "GEN# +1.00121463"},
        {"Smithsonian Astrophysical Observation", "SAO 158242"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95068217),
        dec: Angle.Degrees(-14.79376547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116804"},
        {"Hipparcos Number", "HIP 65548"},
        {"Smithsonian Astrophysical Observation", "SAO 157933"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.55820518),
        dec: Angle.Degrees(-14.79298917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1822",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1822"},
        {"Smithsonian Astrophysical Observation", "SAO 147242"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.76844407),
        dec: Angle.Degrees(-14.79207934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159009"},
        {"Hipparcos Number", "HIP 85866"},
        {"Geneva Identification System", "GEN# +1.00159009"},
        {"Smithsonian Astrophysical Observation", "SAO 160624"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.20294727),
        dec: Angle.Degrees(-14.79187077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126203"},
        {"Hipparcos Number", "HIP 70434"},
        {"Geneva Identification System", "GEN# +1.00126203"},
        {"Smithsonian Astrophysical Observation", "SAO 158543"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.12828187),
        dec: Angle.Degrees(-14.79059905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164103"},
        {"Hipparcos Number", "HIP 88137"},
        {"Geneva Identification System", "GEN# +1.00164103"},
        {"Smithsonian Astrophysical Observation", "SAO 160977"},
        {"Wilson Evans Batten Catalogue", "WEB 14891"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.04034414),
        dec: Angle.Degrees(-14.79030245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46648"},
        {"Hipparcos Number", "HIP 31311"},
        {"Smithsonian Astrophysical Observation", "SAO 151646"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.49435235),
        dec: Angle.Degrees(-14.78984319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76333",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zubenelhakrabi"},
        {"Aitken", "ADS 9704 AP"},
        {"Henry Draper", "HD 138905"},
        {"Hipparcos Number", "HIP 76333"},
        {"Fundamental Katalog 5th Edition", "FK5 577"},
        {"Geneva Identification System", "GEN# +1.00138905J"},
        {"Smithsonian Astrophysical Observation", "SAO 159370"},
        {"Wilson Evans Batten Catalogue", "WEB 12958"},
    },
    visualMagnitude: 3.91,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.88141398),
        dec: Angle.Degrees(-14.78955365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22424"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38697629),
        dec: Angle.Degrees(-14.78888051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192428"},
        {"Hipparcos Number", "HIP 99834"},
        {"Geneva Identification System", "GEN# +1.00192428"},
        {"Smithsonian Astrophysical Observation", "SAO 163387"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84227079),
        dec: Angle.Degrees(-14.78813229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194601"},
        {"Hipparcos Number", "HIP 100862"},
        {"Geneva Identification System", "GEN# +1.00194601"},
        {"Smithsonian Astrophysical Observation", "SAO 163584"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.76855968),
        dec: Angle.Degrees(-14.78558184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100325",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dabih Minor"},
        {"Aitken", "ADS 13717 AB"},
        {"Henry Draper", "HD 193452"},
        {"Hipparcos Number", "HIP 100325"},
        {"Geneva Identification System", "GEN# +1.00193452J"},
        {"Renson", "Renson 54010"},
        {"Smithsonian Astrophysical Observation", "SAO 163471"},
        {"Wilson Evans Batten Catalogue", "WEB 18095"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.19384449),
        dec: Angle.Degrees(-14.78489327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31848"},
        {"Hipparcos Number", "HIP 23129"},
        {"Renson", "Renson 8087"},
        {"Smithsonian Astrophysical Observation", "SAO 150044"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.65111126),
        dec: Angle.Degrees(-14.78411161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100345",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Dabih Major"},
        {"Henry Draper", "HD 193496"},
        {"Henry Draper 2", "HD 193495"},
        {"Hipparcos Number", "HIP 100345"},
        {"Fundamental Katalog 5th Edition", "FK5 762"},
        {"Smithsonian Astrophysical Observation", "SAO 163481"},
        {"Wilson Evans Batten Catalogue", "WEB 18102"},
        {"Wilson Evans Batten Catalogue 2", "WEB 18103"},
    },
    visualMagnitude: 3.05,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.25269347),
        dec: Angle.Degrees(-14.78140119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64895"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52530963),
        dec: Angle.Degrees(-14.77943914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -332.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -233.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98430"},
        {"Hipparcos Number", "HIP 55282"},
        {"Fundamental Katalog 5th Edition", "FK5 426"},
        {"Geneva Identification System", "GEN# +1.00098430"},
        {"Smithsonian Astrophysical Observation", "SAO 156605"},
        {"Wilson Evans Batten Catalogue", "WEB 9958"},
    },
    visualMagnitude: 3.56,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.83551103),
        dec: Angle.Degrees(-14.77904358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 206.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187664"},
        {"Hipparcos Number", "HIP 97736"},
        {"Smithsonian Astrophysical Observation", "SAO 163050"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.92431500),
        dec: Angle.Degrees(-14.77686711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10595 AB"},
        {"Henry Draper", "HD 158561"},
        {"Hipparcos Number", "HIP 85679"},
        {"Smithsonian Astrophysical Observation", "SAO 160594"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.63393765),
        dec: Angle.Degrees(-14.77257304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115957"},
        {"Hipparcos Number", "HIP 65116"},
        {"Geneva Identification System", "GEN# +1.00115957"},
        {"Smithsonian Astrophysical Observation", "SAO 157874"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.16374374),
        dec: Angle.Degrees(-14.77237772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12065"},
        {"Hipparcos Number", "HIP 9173"},
        {"Geneva Identification System", "GEN# +1.00012065"},
        {"Smithsonian Astrophysical Observation", "SAO 148130"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.51889632),
        dec: Angle.Degrees(-14.77215097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176014"},
        {"Hipparcos Number", "HIP 93164"},
        {"Fundamental Katalog 5th Edition", "FK5 5674"},
        {"Geneva Identification System", "GEN# +1.00176014"},
        {"Smithsonian Astrophysical Observation", "SAO 162039"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.65420729),
        dec: Angle.Degrees(-14.76858453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34796"},
        {"Hipparcos Number", "HIP 24834"},
        {"Geneva Identification System", "GEN# +1.00034796"},
        {"Smithsonian Astrophysical Observation", "SAO 150338"},
        {"Wilson Evans Batten Catalogue", "WEB 4808"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.85676735),
        dec: Angle.Degrees(-14.76855138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119720"},
        {"Hipparcos Number", "HIP 67097"},
        {"Smithsonian Astrophysical Observation", "SAO 158141"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.28636935),
        dec: Angle.Degrees(-14.76695970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185045"},
        {"Hipparcos Number", "HIP 96557"},
        {"Smithsonian Astrophysical Observation", "SAO 162830"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.45149034),
        dec: Angle.Degrees(-14.76564894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11080"},
        {"Hipparcos Number", "HIP 8421"},
        {"Smithsonian Astrophysical Observation", "SAO 148020"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.15350288),
        dec: Angle.Degrees(-14.76520709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88166"},
        {"Hipparcos Number", "HIP 49783"},
        {"Smithsonian Astrophysical Observation", "SAO 155774"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.43028090),
        dec: Angle.Degrees(-14.76248843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82492"},
        {"Hipparcos Number", "HIP 46772"},
        {"Smithsonian Astrophysical Observation", "SAO 155263"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98734396),
        dec: Angle.Degrees(-14.76244191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120387"},
        {"Hipparcos Number", "HIP 67445"},
        {"Geneva Identification System", "GEN# +1.00120387"},
        {"Smithsonian Astrophysical Observation", "SAO 158181"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.33408966),
        dec: Angle.Degrees(-14.76183590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20232"},
        {"Geneva Identification System", "GEN# -0.01500767"},
        {"Smithsonian Astrophysical Observation", "SAO 149552"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.04366237),
        dec: Angle.Degrees(-14.76134517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119590"},
        {"Hipparcos Number", "HIP 67043"},
        {"Smithsonian Astrophysical Observation", "SAO 158128"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.09177765),
        dec: Angle.Degrees(-14.76048201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161521"},
        {"Hipparcos Number", "HIP 86988"},
        {"Smithsonian Astrophysical Observation", "SAO 160811"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.64033858),
        dec: Angle.Degrees(-14.75738978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172510"},
        {"Hipparcos Number", "HIP 91623"},
        {"Smithsonian Astrophysical Observation", "SAO 161722"},
        {"Wilson Evans Batten Catalogue", "WEB 15755"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.28605799),
        dec: Angle.Degrees(-14.75684038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37445"},
        {"Hipparcos Number", "HIP 26493"},
        {"Geneva Identification System", "GEN# +1.00037445"},
        {"Smithsonian Astrophysical Observation", "SAO 150635"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.52270487),
        dec: Angle.Degrees(-14.75616681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223006"},
        {"Hipparcos Number", "HIP 117202"},
        {"Geneva Identification System", "GEN# +1.00223006"},
        {"Smithsonian Astrophysical Observation", "SAO 165864"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46827970),
        dec: Angle.Degrees(-14.75481267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91414"},
        {"Hipparcos Number", "HIP 51645"},
        {"Fundamental Katalog 5th Edition", "FK5 4936"},
        {"Smithsonian Astrophysical Observation", "SAO 156055"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.27618393),
        dec: Angle.Degrees(-14.75278412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4671"},
        {"Hipparcos Number", "HIP 3778"},
        {"Smithsonian Astrophysical Observation", "SAO 147456"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.13911418),
        dec: Angle.Degrees(-14.75074522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206677"},
        {"Hipparcos Number", "HIP 107302"},
        {"Geneva Identification System", "GEN# +1.00206677"},
        {"Renson", "Renson 57520"},
        {"Smithsonian Astrophysical Observation", "SAO 164612"},
        {"Wilson Evans Batten Catalogue", "WEB 19376"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00407815),
        dec: Angle.Degrees(-14.74939550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47825"},
        {"Hipparcos Number", "HIP 31888"},
        {"Smithsonian Astrophysical Observation", "SAO 151766"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.99042098),
        dec: Angle.Degrees(-14.74590590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96401"},
        {"Hipparcos Number", "HIP 54304"},
        {"Smithsonian Astrophysical Observation", "SAO 156464"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.64464918),
        dec: Angle.Degrees(-14.74391495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189607"},
        {"Hipparcos Number", "HIP 98570"},
        {"Smithsonian Astrophysical Observation", "SAO 163189"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.33245727),
        dec: Angle.Degrees(-14.74315286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102930"},
        {"Hipparcos Number", "HIP 57789"},
        {"Geneva Identification System", "GEN# +1.00102930"},
        {"Smithsonian Astrophysical Observation", "SAO 156934"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.75255367),
        dec: Angle.Degrees(-14.74192017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136344"},
        {"Hipparcos Number", "HIP 75085"},
        {"Smithsonian Astrophysical Observation", "SAO 159185"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.15570907),
        dec: Angle.Degrees(-14.74104539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3256"},
        {"Hipparcos Number", "HIP 2800"},
        {"Geneva Identification System", "GEN# +1.00003256"},
        {"Smithsonian Astrophysical Observation", "SAO 147352"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.91148854),
        dec: Angle.Degrees(-14.73563616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153326"},
        {"Hipparcos Number", "HIP 83136"},
        {"Geneva Identification System", "GEN# +1.00153326"},
        {"Smithsonian Astrophysical Observation", "SAO 160213"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83903157),
        dec: Angle.Degrees(-14.73476433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33348"},
        {"Hipparcos Number", "HIP 23970"},
        {"Smithsonian Astrophysical Observation", "SAO 150180"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.28544442),
        dec: Angle.Degrees(-14.73221111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216145"},
        {"Hipparcos Number", "HIP 112797"},
        {"Smithsonian Astrophysical Observation", "SAO 165329"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.63954053),
        dec: Angle.Degrees(-14.73160652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132568"},
        {"Hipparcos Number", "HIP 73416"},
        {"Fundamental Katalog 5th Edition", "FK5 5333"},
        {"Smithsonian Astrophysical Observation", "SAO 158960"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.05568441),
        dec: Angle.Degrees(-14.72851189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48812"},
        {"Hipparcos Number", "HIP 32303"},
        {"Smithsonian Astrophysical Observation", "SAO 151866"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.16642736),
        dec: Angle.Degrees(-14.72844416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25943"},
        {"Hipparcos Number", "HIP 19124"},
        {"Smithsonian Astrophysical Observation", "SAO 149371"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.50138751),
        dec: Angle.Degrees(-14.72694085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22982"},
        {"Hipparcos Number", "HIP 17182"},
        {"Smithsonian Astrophysical Observation", "SAO 149103"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.19596593),
        dec: Angle.Degrees(-14.72581054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161701"},
        {"Hipparcos Number", "HIP 87074"},
        {"Fundamental Katalog 5th Edition", "FK5 3413"},
        {"Geneva Identification System", "GEN# +1.00161701"},
        {"Renson", "Renson 45620"},
        {"Smithsonian Astrophysical Observation", "SAO 160822"},
        {"Wilson Evans Batten Catalogue", "WEB 14692"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.90330267),
        dec: Angle.Degrees(-14.72578118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88766"},
        {"Hipparcos Number", "HIP 50133"},
        {"Smithsonian Astrophysical Observation", "SAO 155835"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.51518165),
        dec: Angle.Degrees(-14.72575250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120300"},
        {"Hipparcos Number", "HIP 67407"},
        {"Smithsonian Astrophysical Observation", "SAO 158178"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.22324518),
        dec: Angle.Degrees(-14.72533219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109058"},
        {"Hipparcos Number", "HIP 61152"},
        {"Smithsonian Astrophysical Observation", "SAO 157342"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.96672194),
        dec: Angle.Degrees(-14.72046759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37480"},
        {"Geneva Identification System", "GEN# +2.24370029"},
        {"New General Catalogue", "NGC 2437 29"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.40671125),
        dec: Angle.Degrees(-14.72027571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1268"},
        {"Hipparcos Number", "HIP 1348"},
        {"Geneva Identification System", "GEN# +1.00001268"},
        {"Smithsonian Astrophysical Observation", "SAO 147196"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.22048652),
        dec: Angle.Degrees(-14.71795699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15908"},
        {"Hipparcos Number", "HIP 11863"},
        {"Smithsonian Astrophysical Observation", "SAO 148456"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.26918849),
        dec: Angle.Degrees(-14.71680912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142131"},
        {"Hipparcos Number", "HIP 77809"},
        {"Geneva Identification System", "GEN# +1.00142131"},
        {"Smithsonian Astrophysical Observation", "SAO 159559"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.32371571),
        dec: Angle.Degrees(-14.71660917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147591"},
        {"Hipparcos Number", "HIP 80287"},
        {"Smithsonian Astrophysical Observation", "SAO 159891"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.83983495),
        dec: Angle.Degrees(-14.71586733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14045"},
        {"Hipparcos Number", "HIP 10571"},
        {"Smithsonian Astrophysical Observation", "SAO 148303"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.02069906),
        dec: Angle.Degrees(-14.71405713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126214"},
        {"Hipparcos Number", "HIP 70443"},
        {"Renson", "Renson 35974"},
        {"Smithsonian Astrophysical Observation", "SAO 158548"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.15771700),
        dec: Angle.Degrees(-14.71345815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60856"},
        {"Hipparcos Number", "HIP 36967"},
        {"Celescope Catalog", "CEL 1941"},
        {"Geneva Identification System", "GEN# +2.24220042"},
        {"Smithsonian Astrophysical Observation", "SAO 153115"},
        {"New General Catalogue", "NGC 2422 42"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98734676),
        dec: Angle.Degrees(-14.71083999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22233"},
        {"Hipparcos Number", "HIP 16658"},
        {"Smithsonian Astrophysical Observation", "SAO 149046"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.58381547),
        dec: Angle.Degrees(-14.71044363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40660"},
        {"Hipparcos Number", "HIP 28379"},
        {"Renson", "Renson 10875"},
        {"Smithsonian Astrophysical Observation", "SAO 151003"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.92721363),
        dec: Angle.Degrees(-14.70896673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220740"},
        {"Hipparcos Number", "HIP 115687"},
        {"Smithsonian Astrophysical Observation", "SAO 165690"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.58345502),
        dec: Angle.Degrees(-14.70863966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 288.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126310"},
        {"Hipparcos Number", "HIP 70494"},
        {"Smithsonian Astrophysical Observation", "SAO 158552"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.28155948),
        dec: Angle.Degrees(-14.70847716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173885"},
        {"Hipparcos Number", "HIP 92262"},
        {"Geneva Identification System", "GEN# +1.00173885"},
        {"Smithsonian Astrophysical Observation", "SAO 161843"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.04934910),
        dec: Angle.Degrees(-14.70825716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24245"},
        {"Hipparcos Number", "HIP 18021"},
        {"Smithsonian Astrophysical Observation", "SAO 149209"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76504194),
        dec: Angle.Degrees(-14.70770800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19410"},
        {"Geneva Identification System", "GEN# -0.01500728"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.36004536),
        dec: Angle.Degrees(-14.69834026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73912"},
        {"Hipparcos Number", "HIP 42552"},
        {"Smithsonian Astrophysical Observation", "SAO 154525"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.10058594),
        dec: Angle.Degrees(-14.69698037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32966"},
        {"Hipparcos Number", "HIP 23755"},
        {"Geneva Identification System", "GEN# +1.00032966"},
        {"Renson", "Renson 8420"},
        {"Smithsonian Astrophysical Observation", "SAO 150144"},
    },
    visualMagnitude: 7.12,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.59230142),
        dec: Angle.Degrees(-14.69658834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79481"},
        {"Hipparcos Number", "HIP 45305"},
        {"Smithsonian Astrophysical Observation", "SAO 155021"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.51289243),
        dec: Angle.Degrees(-14.69480209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134885"},
        {"Hipparcos Number", "HIP 74431"},
        {"Smithsonian Astrophysical Observation", "SAO 159098"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.17464482),
        dec: Angle.Degrees(-14.69391932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55066"},
        {"Geneva Identification System", "GEN# -0.01303333"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.09271391),
        dec: Angle.Degrees(-14.69308295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135485"},
        {"Hipparcos Number", "HIP 74680"},
        {"Geneva Identification System", "GEN# +1.00135485"},
        {"Renson", "Renson 38490"},
        {"Smithsonian Astrophysical Observation", "SAO 159132"},
        {"Wilson Evans Batten Catalogue", "WEB 12743"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.93856804),
        dec: Angle.Degrees(-14.69283789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98948"},
        {"Hipparcos Number", "HIP 55579"},
        {"Smithsonian Astrophysical Observation", "SAO 156642"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.78204777),
        dec: Angle.Degrees(-14.69251430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154749"},
        {"Hipparcos Number", "HIP 83821"},
        {"Smithsonian Astrophysical Observation", "SAO 160301"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.95866575),
        dec: Angle.Degrees(-14.69231150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83048"},
        {"Hipparcos Number", "HIP 47066"},
        {"Geneva Identification System", "GEN# +1.00083048"},
        {"Smithsonian Astrophysical Observation", "SAO 155319"},
        {"Wilson Evans Batten Catalogue", "WEB 8865"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.87624267),
        dec: Angle.Degrees(-14.69124997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175297"},
        {"Hipparcos Number", "HIP 92854"},
        {"Geneva Identification System", "GEN# +1.00175297"},
        {"Smithsonian Astrophysical Observation", "SAO 161979"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.81375196),
        dec: Angle.Degrees(-14.69112923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37843",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6348 A"},
        {"Henry Draper", "HD 62864"},
        {"Hipparcos Number", "HIP 37843"},
        {"Geneva Identification System", "GEN# +1.00062864"},
        {"Smithsonian Astrophysical Observation", "SAO 153363"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.37142428),
        dec: Angle.Degrees(-14.69048507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56150",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56150"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.63980219),
        dec: Angle.Degrees(-14.68943909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29841"},
        {"Hipparcos Number", "HIP 21827"},
        {"Geneva Identification System", "GEN# +1.00029841"},
        {"Smithsonian Astrophysical Observation", "SAO 149829"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39149017),
        dec: Angle.Degrees(-14.68778581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6348 B"},
        {"Henry Draper", "HD 62863"},
        {"Hipparcos Number", "HIP 37842"},
        {"Geneva Identification System", "GEN# +1.00062863"},
        {"Smithsonian Astrophysical Observation", "SAO 153362"},
        {"Wilson Evans Batten Catalogue", "WEB 7473"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.36975907),
        dec: Angle.Degrees(-14.68611378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174517"},
        {"Hipparcos Number", "HIP 92529"},
        {"Smithsonian Astrophysical Observation", "SAO 161912"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84864516),
        dec: Angle.Degrees(-14.68386318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207123"},
        {"Hipparcos Number", "HIP 107569"},
        {"Geneva Identification System", "GEN# +1.00207123"},
        {"Smithsonian Astrophysical Observation", "SAO 164648"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.79516016),
        dec: Angle.Degrees(-14.68314040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149912"},
        {"Hipparcos Number", "HIP 81462"},
        {"Geneva Identification System", "GEN# +1.00149912"},
        {"Smithsonian Astrophysical Observation", "SAO 160015"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.57462537),
        dec: Angle.Degrees(-14.68091129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133912"},
        {"Hipparcos Number", "HIP 74005"},
        {"Smithsonian Astrophysical Observation", "SAO 159035"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.85608267),
        dec: Angle.Degrees(-14.67898499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120850"},
        {"Hipparcos Number", "HIP 67708"},
        {"Geneva Identification System", "GEN# +1.00120850"},
        {"Smithsonian Astrophysical Observation", "SAO 158207"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.06436278),
        dec: Angle.Degrees(-14.67654473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33933"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.62036200),
        dec: Angle.Degrees(-14.67631866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -298.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215296"},
        {"Hipparcos Number", "HIP 112267"},
        {"Smithsonian Astrophysical Observation", "SAO 165259"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.08887547),
        dec: Angle.Degrees(-14.67607190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66988"},
        {"Hipparcos Number", "HIP 39586"},
        {"Smithsonian Astrophysical Observation", "SAO 153808"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.33867064),
        dec: Angle.Degrees(-14.67432315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73648"},
        {"Hipparcos Number", "HIP 42411"},
        {"Smithsonian Astrophysical Observation", "SAO 154495"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.73311833),
        dec: Angle.Degrees(-14.67379222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27010",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27010"},
        {"Smithsonian Astrophysical Observation", "SAO 150741"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.94090340),
        dec: Angle.Degrees(-14.67059781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47715"},
        {"Hipparcos Number", "HIP 31846"},
        {"Smithsonian Astrophysical Observation", "SAO 151759"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.87610724),
        dec: Angle.Degrees(-14.66709013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60999"},
        {"Hipparcos Number", "HIP 37018"},
        {"Geneva Identification System", "GEN# +2.24220075"},
        {"Smithsonian Astrophysical Observation", "SAO 153135"},
        {"New General Catalogue", "NGC 2422 75"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.12829346),
        dec: Angle.Degrees(-14.66552299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5486"},
        {"Hipparcos Number", "HIP 4414"},
        {"Geneva Identification System", "GEN# +1.00005486"},
        {"Smithsonian Astrophysical Observation", "SAO 147524"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.13747802),
        dec: Angle.Degrees(-14.66531597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107098"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.40559697),
        dec: Angle.Degrees(-14.66493160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121136"},
        {"Hipparcos Number", "HIP 67850"},
        {"Smithsonian Astrophysical Observation", "SAO 158220"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.46534986),
        dec: Angle.Degrees(-14.66411418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80817"},
        {"Geneva Identification System", "GEN# +9.80153057"},
    },
    visualMagnitude: 12.27,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.55578792),
        dec: Angle.Degrees(-14.66329215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -494.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107746"},
        {"Hipparcos Number", "HIP 60388"},
        {"Geneva Identification System", "GEN# +1.00107746"},
        {"Smithsonian Astrophysical Observation", "SAO 157248"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.72881904),
        dec: Angle.Degrees(-14.66286908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211380"},
        {"Hipparcos Number", "HIP 110014"},
        {"Geneva Identification System", "GEN# +1.00211380"},
        {"Smithsonian Astrophysical Observation", "SAO 164979"},
        {"Wilson Evans Batten Catalogue", "WEB 19752"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.23445023),
        dec: Angle.Degrees(-14.65692783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16295"},
        {"Hipparcos Number", "HIP 12146"},
        {"Smithsonian Astrophysical Observation", "SAO 148499"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.14155619),
        dec: Angle.Degrees(-14.65665995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43527"},
        {"Geneva Identification System", "GEN# -0.01402678"},
        {"Smithsonian Astrophysical Observation", "SAO 154696"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.98150873),
        dec: Angle.Degrees(-14.65259455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42813"},
        {"Hipparcos Number", "HIP 29442"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.05839483),
        dec: Angle.Degrees(-14.65041233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21463"},
        {"Smithsonian Astrophysical Observation", "SAO 149760"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.14113392),
        dec: Angle.Degrees(-14.64949400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90267"},
        {"Geneva Identification System", "GEN# -0.01405037"},
        {"Smithsonian Astrophysical Observation", "SAO 161452"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.27575628),
        dec: Angle.Degrees(-14.64935838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90299"},
        {"Geneva Identification System", "GEN# +6.10005023"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.37505541),
        dec: Angle.Degrees(-14.64469601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170902"},
        {"Hipparcos Number", "HIP 90884"},
        {"Geneva Identification System", "GEN# +1.00170902"},
        {"Smithsonian Astrophysical Observation", "SAO 161580"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.08607249),
        dec: Angle.Degrees(-14.64421705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159527"},
        {"Hipparcos Number", "HIP 86099"},
        {"Smithsonian Astrophysical Observation", "SAO 160669"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.93252266),
        dec: Angle.Degrees(-14.64362550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78567"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.64585427),
        dec: Angle.Degrees(-14.64340775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147008"},
        {"Hipparcos Number", "HIP 80004"},
        {"Smithsonian Astrophysical Observation", "SAO 159855"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96663004),
        dec: Angle.Degrees(-14.64310341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149594"},
        {"Hipparcos Number", "HIP 81306"},
        {"Smithsonian Astrophysical Observation", "SAO 159995"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09474410),
        dec: Angle.Degrees(-14.64140657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146087"},
        {"Hipparcos Number", "HIP 79633"},
        {"Geneva Identification System", "GEN# +1.00146087"},
        {"Smithsonian Astrophysical Observation", "SAO 159809"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.74640138),
        dec: Angle.Degrees(-14.63891601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27325"},
        {"Hipparcos Number", "HIP 20069"},
        {"Smithsonian Astrophysical Observation", "SAO 149524"},
        {"Wilson Evans Batten Catalogue", "WEB 3833"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.55926074),
        dec: Angle.Degrees(-14.63878350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109333"},
        {"Hipparcos Number", "HIP 61329"},
        {"Cincinnati Publication", "Ci 18 1587"},
        {"Cincinnati Publication 2", "Ci 20 717"},
        {"Geneva Identification System", "GEN# +1.00109333"},
        {"Smithsonian Astrophysical Observation", "SAO 157367"},
        {"Wilson Evans Batten Catalogue", "WEB 10917"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.50019977),
        dec: Angle.Degrees(-14.63859695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -502.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141881"},
        {"Hipparcos Number", "HIP 77710"},
        {"Geneva Identification System", "GEN# +1.00141881"},
        {"Smithsonian Astrophysical Observation", "SAO 159547"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.99300219),
        dec: Angle.Degrees(-14.63652928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14669"},
        {"Hipparcos Number", "HIP 10991"},
        {"Smithsonian Astrophysical Observation", "SAO 148348"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.41217682),
        dec: Angle.Degrees(-14.63578559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81465"},
        {"Hipparcos Number", "HIP 46219"},
        {"Smithsonian Astrophysical Observation", "SAO 155169"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.34880287),
        dec: Angle.Degrees(-14.63307289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211609"},
        {"Hipparcos Number", "HIP 110138"},
        {"Smithsonian Astrophysical Observation", "SAO 164992"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.64834167),
        dec: Angle.Degrees(-14.63304469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34995"},
        {"Hipparcos Number", "HIP 24978"},
        {"Geneva Identification System", "GEN# +1.00034995"},
        {"Smithsonian Astrophysical Observation", "SAO 150362"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.23843655),
        dec: Angle.Degrees(-14.63136144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214232"},
        {"Hipparcos Number", "HIP 111646"},
        {"Smithsonian Astrophysical Observation", "SAO 165196"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.25320086),
        dec: Angle.Degrees(-14.63127333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81610"},
        {"Smithsonian Astrophysical Observation", "SAO 160030"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.01909427),
        dec: Angle.Degrees(-14.63027476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81432"},
        {"Smithsonian Astrophysical Observation", "SAO 160013"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.49868192),
        dec: Angle.Degrees(-14.62878866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205277"},
        {"Hipparcos Number", "HIP 106525"},
        {"Smithsonian Astrophysical Observation", "SAO 164490"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.63921203),
        dec: Angle.Degrees(-14.62878522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141076"},
        {"Hipparcos Number", "HIP 77366"},
        {"Smithsonian Astrophysical Observation", "SAO 159497"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.89158699),
        dec: Angle.Degrees(-14.62616788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14524"},
        {"Hipparcos Number", "HIP 10900"},
        {"Smithsonian Astrophysical Observation", "SAO 148339"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.07103306),
        dec: Angle.Degrees(-14.62481697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22234"},
        {"Wilson Evans Batten Catalogue", "WEB 4278"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.74583215),
        dec: Angle.Degrees(-14.62312567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16019"},
        {"Hipparcos Number", "HIP 11948"},
        {"Smithsonian Astrophysical Observation", "SAO 148473"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.53703142),
        dec: Angle.Degrees(-14.62210942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7897"},
        {"Smithsonian Astrophysical Observation", "SAO 147961"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39360490),
        dec: Angle.Degrees(-14.62123728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28241"},
        {"Hipparcos Number", "HIP 20749"},
        {"Smithsonian Astrophysical Observation", "SAO 149636"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.69414669),
        dec: Angle.Degrees(-14.62113337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111946"},
        {"Hipparcos Number", "HIP 62853"},
        {"Smithsonian Astrophysical Observation", "SAO 157566"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.24509292),
        dec: Angle.Degrees(-14.62061789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155413"},
        {"Hipparcos Number", "HIP 84132"},
        {"Geneva Identification System", "GEN# +1.00155413"},
        {"Smithsonian Astrophysical Observation", "SAO 160351"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.99435463),
        dec: Angle.Degrees(-14.62028223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157659"},
        {"Hipparcos Number", "HIP 85239"},
        {"Smithsonian Astrophysical Observation", "SAO 160531"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.26795028),
        dec: Angle.Degrees(-14.61741457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199116"},
        {"Hipparcos Number", "HIP 103283"},
        {"Smithsonian Astrophysical Observation", "SAO 163984"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.87104826),
        dec: Angle.Degrees(-14.61559399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154034"},
        {"Hipparcos Number", "HIP 83463"},
        {"Geneva Identification System", "GEN# +1.00154034"},
        {"Smithsonian Astrophysical Observation", "SAO 160246"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.87600892),
        dec: Angle.Degrees(-14.61464833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63556"},
        {"Hipparcos Number", "HIP 38143"},
        {"Smithsonian Astrophysical Observation", "SAO 153440"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.25175557),
        dec: Angle.Degrees(-14.61394411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75600"},
        {"Hipparcos Number", "HIP 43403"},
        {"Fundamental Katalog 5th Edition", "FK5 4791"},
        {"Smithsonian Astrophysical Observation", "SAO 154678"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.61780290),
        dec: Angle.Degrees(-14.61329418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70170"},
        {"Hipparcos Number", "HIP 40842"},
        {"Geneva Identification System", "GEN# +1.00070170"},
        {"Smithsonian Astrophysical Observation", "SAO 154122"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.01369716),
        dec: Angle.Degrees(-14.61285369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215280"},
        {"Hipparcos Number", "HIP 112260"},
        {"Geneva Identification System", "GEN# +1.00215280"},
        {"Smithsonian Astrophysical Observation", "SAO 165258"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.07208431),
        dec: Angle.Degrees(-14.61174856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195858"},
        {"Hipparcos Number", "HIP 101513"},
        {"Smithsonian Astrophysical Observation", "SAO 163688"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.56812879),
        dec: Angle.Degrees(-14.61122236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20581"},
        {"Smithsonian Astrophysical Observation", "SAO 149612"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.12371121),
        dec: Angle.Degrees(-14.61121668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190264"},
        {"Hipparcos Number", "HIP 98866"},
        {"Smithsonian Astrophysical Observation", "SAO 163233"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.15854565),
        dec: Angle.Degrees(-14.61031999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56110"},
        {"Hipparcos Number", "HIP 35072"},
        {"Smithsonian Astrophysical Observation", "SAO 152616"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.78636672),
        dec: Angle.Degrees(-14.60945054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34045"},
        {"Hipparcos Number", "HIP 24394"},
        {"Geneva Identification System", "GEN# +1.00034045"},
        {"Smithsonian Astrophysical Observation", "SAO 150255"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.49975985),
        dec: Angle.Degrees(-14.60686727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127188"},
        {"Hipparcos Number", "HIP 70934"},
        {"Smithsonian Astrophysical Observation", "SAO 158604"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.61060419),
        dec: Angle.Degrees(-14.60505622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214723"},
        {"Hipparcos Number", "HIP 111931"},
        {"Smithsonian Astrophysical Observation", "SAO 165227"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.08703284),
        dec: Angle.Degrees(-14.60405940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45420"},
        {"Hipparcos Number", "HIP 30669"},
        {"Smithsonian Astrophysical Observation", "SAO 151512"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.67773299),
        dec: Angle.Degrees(-14.60340061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187949"},
        {"Hipparcos Number", "HIP 97849"},
        {"Geneva Identification System", "GEN# +1.00187949"},
        {"Smithsonian Astrophysical Observation", "SAO 163080"},
        {"Wilson Evans Batten Catalogue", "WEB 17215"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.27660773),
        dec: Angle.Degrees(-14.60308038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8705"},
        {"Hipparcos Number", "HIP 6670"},
        {"Geneva Identification System", "GEN# +1.00008705"},
        {"Smithsonian Astrophysical Observation", "SAO 147803"},
        {"Wilson Evans Batten Catalogue", "WEB 1457"},
    },
    visualMagnitude: 4.90,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.40503869),
        dec: Angle.Degrees(-14.59875437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205384"},
        {"Hipparcos Number", "HIP 106584"},
        {"Smithsonian Astrophysical Observation", "SAO 164497"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.80492239),
        dec: Angle.Degrees(-14.59868559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43954"},
        {"Hipparcos Number", "HIP 29966"},
        {"Smithsonian Astrophysical Observation", "SAO 151337"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.62400179),
        dec: Angle.Degrees(-14.59830546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135726"},
        {"Hipparcos Number", "HIP 74783"},
        {"Smithsonian Astrophysical Observation", "SAO 159150"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.24807188),
        dec: Angle.Degrees(-14.59825545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29663"},
        {"Hipparcos Number", "HIP 21705"},
        {"Geneva Identification System", "GEN# +1.00029663"},
        {"Smithsonian Astrophysical Observation", "SAO 149804"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.90494061),
        dec: Angle.Degrees(-14.59571052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103238"},
        {"Hipparcos Number", "HIP 57962"},
        {"Smithsonian Astrophysical Observation", "SAO 156962"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.32916187),
        dec: Angle.Degrees(-14.59556112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60969"},
        {"Hipparcos Number", "HIP 37015"},
        {"Celescope Catalog", "CEL 1947"},
        {"Geneva Identification System", "GEN# +2.24220071"},
        {"Smithsonian Astrophysical Observation", "SAO 153133"},
        {"New General Catalogue", "NGC 2422 71"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.11435496),
        dec: Angle.Degrees(-14.59508725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187196"},
        {"Hipparcos Number", "HIP 97521"},
        {"Smithsonian Astrophysical Observation", "SAO 163015"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.31180260),
        dec: Angle.Degrees(-14.59416625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100764"},
        {"Hipparcos Number", "HIP 56551"},
        {"Geneva Identification System", "GEN# +1.00100764"},
        {"Geneva Identification System 2", "GEN# -0.01303407"},
        {"Smithsonian Astrophysical Observation", "SAO 156773"},
        {"Wilson Evans Batten Catalogue", "WEB 10164"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.92810506),
        dec: Angle.Degrees(-14.59347926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134013"},
        {"Hipparcos Number", "HIP 74050"},
        {"Smithsonian Astrophysical Observation", "SAO 159040"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.99382523),
        dec: Angle.Degrees(-14.59246256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118582"},
        {"Hipparcos Number", "HIP 66512"},
        {"Smithsonian Astrophysical Observation", "SAO 158054"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.50633623),
        dec: Angle.Degrees(-14.59232971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65243"},
        {"Hipparcos Number", "HIP 38862"},
        {"Geneva Identification System", "GEN# +1.00065243"},
        {"Smithsonian Astrophysical Observation", "SAO 153625"},
        {"Wilson Evans Batten Catalogue", "WEB 7610"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.30313449),
        dec: Angle.Degrees(-14.59154003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -252.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 201.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27499"},
        {"Hipparcos Number", "HIP 20211"},
        {"Smithsonian Astrophysical Observation", "SAO 149546"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.97216311),
        dec: Angle.Degrees(-14.59152741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84636"},
        {"Hipparcos Number", "HIP 47949"},
        {"Fundamental Katalog 5th Edition", "FK5 4866"},
        {"Geneva Identification System", "GEN# +1.00084636"},
        {"Smithsonian Astrophysical Observation", "SAO 155467"},
        {"Wilson Evans Batten Catalogue", "WEB 8967"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.56052646),
        dec: Angle.Degrees(-14.58997826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22582",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3485 A"},
        {"Hipparcos Number", "HIP 22582"},
        {"Smithsonian Astrophysical Observation", "SAO 149938"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.89794791),
        dec: Angle.Degrees(-14.58861774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5011"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.04636585),
        dec: Angle.Degrees(-14.58857458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 351.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44608"},
        {"Hipparcos Number", "HIP 30279"},
        {"Smithsonian Astrophysical Observation", "SAO 151420"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.53579261),
        dec: Angle.Degrees(-14.58805526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71685"},
        {"Hipparcos Number", "HIP 41542"},
        {"Smithsonian Astrophysical Observation", "SAO 154286"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.07065422),
        dec: Angle.Degrees(-14.58743631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113308"},
        {"Hipparcos Number", "HIP 63665"},
        {"Smithsonian Astrophysical Observation", "SAO 157675"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.72468682),
        dec: Angle.Degrees(-14.58689571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213236"},
        {"Hipparcos Number", "HIP 111086"},
        {"Fundamental Katalog 5th Edition", "FK5 5985"},
        {"Geneva Identification System", "GEN# +1.00213236"},
        {"Renson", "Renson 59120"},
        {"Smithsonian Astrophysical Observation", "SAO 165127"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.57220833),
        dec: Angle.Degrees(-14.58565069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42341"},
        {"Hipparcos Number", "HIP 29205"},
        {"Geneva Identification System", "GEN# +1.00042341"},
        {"Smithsonian Astrophysical Observation", "SAO 151178"},
        {"Wilson Evans Batten Catalogue", "WEB 5729"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39389063),
        dec: Angle.Degrees(-14.58469045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179130"},
        {"Hipparcos Number", "HIP 94323"},
        {"Smithsonian Astrophysical Observation", "SAO 162299"},
        {"Wilson Evans Batten Catalogue", "WEB 16430"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.97901450),
        dec: Angle.Degrees(-14.58456245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10419 AB"},
        {"Henry Draper", "HD 155970"},
        {"Hipparcos Number", "HIP 84402"},
        {"Geneva Identification System", "GEN# +1.00155970J"},
        {"Smithsonian Astrophysical Observation", "SAO 160402"},
    },
    visualMagnitude: 5.98,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.83456460),
        dec: Angle.Degrees(-14.58412556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152533"},
        {"Hipparcos Number", "HIP 82722"},
        {"Geneva Identification System", "GEN# +1.00152533"},
        {"Smithsonian Astrophysical Observation", "SAO 160157"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.62834747),
        dec: Angle.Degrees(-14.58288482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170397"},
        {"Hipparcos Number", "HIP 90651"},
        {"Geneva Identification System", "GEN# +1.00170397"},
        {"Renson", "Renson 47750"},
        {"Smithsonian Astrophysical Observation", "SAO 161528"},
        {"Wilson Evans Batten Catalogue", "WEB 15522"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.44477862),
        dec: Angle.Degrees(-14.58202326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115589"},
        {"Hipparcos Number", "HIP 64905"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.55696568),
        dec: Angle.Degrees(-14.58169614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223542"},
        {"Hipparcos Number", "HIP 117557"},
        {"Geneva Identification System", "GEN# +1.00223542"},
        {"Smithsonian Astrophysical Observation", "SAO 165912"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.61206682),
        dec: Angle.Degrees(-14.57912155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15260"},
        {"Hipparcos Number", "HIP 11416"},
        {"Smithsonian Astrophysical Observation", "SAO 148395"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.78128453),
        dec: Angle.Degrees(-14.57435236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80050"},
        {"Hipparcos Number", "HIP 45559"},
        {"Geneva Identification System", "GEN# +1.00080050"},
        {"Smithsonian Astrophysical Observation", "SAO 155060"},
        {"Wilson Evans Batten Catalogue", "WEB 8658"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.28221716),
        dec: Angle.Degrees(-14.57405765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138411"},
        {"Hipparcos Number", "HIP 76085"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.08472587),
        dec: Angle.Degrees(-14.57313881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154213"},
        {"Hipparcos Number", "HIP 83560"},
        {"Geneva Identification System", "GEN# +1.00154213"},
        {"Smithsonian Astrophysical Observation", "SAO 160262"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.15014149),
        dec: Angle.Degrees(-14.57107577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171294"},
        {"Hipparcos Number", "HIP 91068"},
        {"Smithsonian Astrophysical Observation", "SAO 161622"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.63860185),
        dec: Angle.Degrees(-14.56859360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186967"},
        {"Hipparcos Number", "HIP 97422"},
        {"Smithsonian Astrophysical Observation", "SAO 162997"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.00739634),
        dec: Angle.Degrees(-14.56737717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213346"},
        {"Hipparcos Number", "HIP 111141"},
        {"Smithsonian Astrophysical Observation", "SAO 165136"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.74180814),
        dec: Angle.Degrees(-14.56692841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69901"},
        {"Hipparcos Number", "HIP 40713"},
        {"Smithsonian Astrophysical Observation", "SAO 154098"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.65560362),
        dec: Angle.Degrees(-14.56639335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170296"},
        {"Hipparcos Number", "HIP 90595"},
        {"Fundamental Katalog 5th Edition", "FK5 696"},
        {"Geneva Identification System", "GEN# +1.00170296"},
        {"Smithsonian Astrophysical Observation", "SAO 161520"},
        {"Wilson Evans Batten Catalogue", "WEB 15512"},
    },
    visualMagnitude: 4.67,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.29938301),
        dec: Angle.Degrees(-14.56580499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172594"},
        {"Hipparcos Number", "HIP 91677"},
        {"Geneva Identification System", "GEN# +1.00172594"},
        {"Smithsonian Astrophysical Observation", "SAO 161730"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.42691728),
        dec: Angle.Degrees(-14.56424178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62952"},
        {"Hipparcos Number", "HIP 37891"},
        {"Fundamental Katalog 5th Edition", "FK5 1202"},
        {"Geneva Identification System", "GEN# +1.00062952"},
        {"Smithsonian Astrophysical Observation", "SAO 153372"},
        {"Wilson Evans Batten Catalogue", "WEB 7478"},
    },
    visualMagnitude: 5.03,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.48698643),
        dec: Angle.Degrees(-14.56382026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183632"},
        {"Hipparcos Number", "HIP 95974"},
        {"Smithsonian Astrophysical Observation", "SAO 162710"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.74249768),
        dec: Angle.Degrees(-14.56322310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10777"},
        {"Hipparcos Number", "HIP 8178"},
        {"Geneva Identification System", "GEN# +1.00010777"},
        {"Smithsonian Astrophysical Observation", "SAO 147996"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.28384271),
        dec: Angle.Degrees(-14.56227793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61045"},
        {"Hipparcos Number", "HIP 37047"},
        {"Celescope Catalog", "CEL 1950"},
        {"Geneva Identification System", "GEN# +2.24220089"},
        {"Renson", "Renson 16680"},
        {"Smithsonian Astrophysical Observation", "SAO 153150"},
        {"New General Catalogue", "NGC 2422 89"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.19654128),
        dec: Angle.Degrees(-14.56160480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210297"},
        {"Hipparcos Number", "HIP 109392"},
        {"Smithsonian Astrophysical Observation", "SAO 164895"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.43022886),
        dec: Angle.Degrees(-14.56102763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201768"},
        {"Hipparcos Number", "HIP 104670"},
        {"Geneva Identification System", "GEN# +1.00201768"},
        {"Smithsonian Astrophysical Observation", "SAO 164211"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.02512509),
        dec: Angle.Degrees(-14.55821291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13849",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13849"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.56734937),
        dec: Angle.Degrees(-14.55745556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 279.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39514"},
        {"Hipparcos Number", "HIP 27765"},
        {"Geneva Identification System", "GEN# +1.00039514"},
        {"Smithsonian Astrophysical Observation", "SAO 150896"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.13519117),
        dec: Angle.Degrees(-14.55705279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32613"},
        {"Hipparcos Number", "HIP 23560"},
        {"Geneva Identification System", "GEN# +1.00032613"},
        {"Smithsonian Astrophysical Observation", "SAO 150113"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.98569291),
        dec: Angle.Degrees(-14.55619649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35042"},
        {"Hipparcos Number", "HIP 25014"},
        {"Smithsonian Astrophysical Observation", "SAO 150372"},
        {"Wilson Evans Batten Catalogue", "WEB 4846"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.34034027),
        dec: Angle.Degrees(-14.55537310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19085"},
        {"Hipparcos Number", "HIP 14250"},
        {"Smithsonian Astrophysical Observation", "SAO 148742"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.94967484),
        dec: Angle.Degrees(-14.55526326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7170"},
        {"Hipparcos Number", "HIP 5607"},
        {"Geneva Identification System", "GEN# +1.00007170"},
        {"Smithsonian Astrophysical Observation", "SAO 147665"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.97635113),
        dec: Angle.Degrees(-14.55456309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4213"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45164773),
        dec: Angle.Degrees(-14.55220922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214654"},
        {"Hipparcos Number", "HIP 111892"},
        {"Geneva Identification System", "GEN# +1.00214654"},
        {"Smithsonian Astrophysical Observation", "SAO 165221"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.98059899),
        dec: Angle.Degrees(-14.55189909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182678"},
        {"Hipparcos Number", "HIP 95574"},
        {"Geneva Identification System", "GEN# +1.00182678"},
        {"Smithsonian Astrophysical Observation", "SAO 162615"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.60227665),
        dec: Angle.Degrees(-14.55119316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148604"},
        {"Hipparcos Number", "HIP 80793"},
        {"Fundamental Katalog 5th Edition", "FK5 1430"},
        {"Geneva Identification System", "GEN# +1.00148604"},
        {"Smithsonian Astrophysical Observation", "SAO 159948"},
        {"Wilson Evans Batten Catalogue", "WEB 13663"},
    },
    visualMagnitude: 5.66,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.44542879),
        dec: Angle.Degrees(-14.55089750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16825"},
        {"Hipparcos Number", "HIP 12562"},
        {"Geneva Identification System", "GEN# +1.00016825"},
        {"Smithsonian Astrophysical Observation", "SAO 148550"},
        {"Wilson Evans Batten Catalogue", "WEB 2565"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.39221887),
        dec: Angle.Degrees(-14.54941172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42440"},
        {"Hipparcos Number", "HIP 29266"},
        {"Smithsonian Astrophysical Observation", "SAO 151185"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.55131874),
        dec: Angle.Degrees(-14.54855346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
