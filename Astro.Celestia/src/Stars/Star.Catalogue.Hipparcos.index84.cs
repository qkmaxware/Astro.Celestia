using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_84() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194650"},
        {"Hipparcos Number", "HIP 100774"},
        {"Geneva Identification System", "GEN# +1.00194650"},
        {"Smithsonian Astrophysical Observation", "SAO 88673"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.48882449),
        dec: Angle.Degrees(+26.03606777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13433"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.24200270),
        dec: Angle.Degrees(+26.03682354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151369"},
        {"Hipparcos Number", "HIP 82087"},
        {"Geneva Identification System", "GEN# +1.00151369"},
        {"Smithsonian Astrophysical Observation", "SAO 84589"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.51537885),
        dec: Angle.Degrees(+26.03759237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133460"},
        {"Hipparcos Number", "HIP 73700"},
        {"Geneva Identification System", "GEN# +1.00133460"},
        {"Smithsonian Astrophysical Observation", "SAO 83637"},
        {"Wilson Evans Batten Catalogue", "WEB 12596"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95536569),
        dec: Angle.Degrees(+26.03880074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68656",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68656"},
        {"Geneva Identification System", "GEN# +0.02602518"},
        {"Smithsonian Astrophysical Observation", "SAO 83141"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.80476194),
        dec: Angle.Degrees(+26.04068178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15141"},
        {"Hipparcos Number", "HIP 11405"},
        {"Geneva Identification System", "GEN# +1.00015141"},
        {"Smithsonian Astrophysical Observation", "SAO 75367"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.74176281),
        dec: Angle.Degrees(+26.04096097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104206"},
        {"Hipparcos Number", "HIP 58524"},
        {"Smithsonian Astrophysical Observation", "SAO 82093"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.03192037),
        dec: Angle.Degrees(+26.04200924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11464"},
        {"Hipparcos Number", "HIP 8812"},
        {"Geneva Identification System", "GEN# +1.00011464"},
        {"Smithsonian Astrophysical Observation", "SAO 75000"},
        {"Wilson Evans Batten Catalogue", "WEB 1854"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.31068470),
        dec: Angle.Degrees(+26.04484307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26500"},
        {"Hipparcos Number", "HIP 19637"},
        {"Smithsonian Astrophysical Observation", "SAO 76500"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.12113844),
        dec: Angle.Degrees(+26.04570568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204923"},
        {"Hipparcos Number", "HIP 106239"},
        {"Geneva Identification System", "GEN# +1.00204923"},
        {"Smithsonian Astrophysical Observation", "SAO 89769"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.78158977),
        dec: Angle.Degrees(+26.04668980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174180"},
        {"Hipparcos Number", "HIP 92271"},
        {"Smithsonian Astrophysical Observation", "SAO 86453"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.07839694),
        dec: Angle.Degrees(+26.04730576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80879",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10090 A"},
        {"Henry Draper", "HD 148996"},
        {"Hipparcos Number", "HIP 80879"},
        {"Smithsonian Astrophysical Observation", "SAO 84419"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.72475081),
        dec: Angle.Degrees(+26.04783071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73226"},
        {"Hipparcos Number", "HIP 42356"},
        {"Geneva Identification System", "GEN# +1.00073226"},
        {"Smithsonian Astrophysical Observation", "SAO 80303"},
        {"Wilson Evans Batten Catalogue", "WEB 8139"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.53579126),
        dec: Angle.Degrees(+26.04942128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163506"},
        {"Hipparcos Number", "HIP 87747"},
        {"Fundamental Katalog 5th Edition", "FK5 1468"},
        {"Geneva Identification System", "GEN# +1.00163506"},
        {"Smithsonian Astrophysical Observation", "SAO 85545"},
        {"Wilson Evans Batten Catalogue", "WEB 14807"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.85494207),
        dec: Angle.Degrees(+26.04997848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156093"},
        {"Hipparcos Number", "HIP 84340"},
        {"Smithsonian Astrophysical Observation", "SAO 84948"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.63941435),
        dec: Angle.Degrees(+26.05198525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177371"},
        {"Hipparcos Number", "HIP 93564"},
        {"Smithsonian Astrophysical Observation", "SAO 86748"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.85637123),
        dec: Angle.Degrees(+26.05289636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80880",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10090 C"},
        {"Hipparcos Number", "HIP 80880"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)30, 54.5500),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)03, 13.900)
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
    primaryId: "HIP 27612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39005"},
        {"Hipparcos Number", "HIP 27612"},
        {"Smithsonian Astrophysical Observation", "SAO 77622"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.69903063),
        dec: Angle.Degrees(+26.05435527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190605"},
        {"Hipparcos Number", "HIP 98894"},
        {"Cincinnati Publication", "Ci 19 3895"},
        {"Geneva Identification System", "GEN# +1.00190605"},
        {"Smithsonian Astrophysical Observation", "SAO 88162"},
        {"Wilson Evans Batten Catalogue", "WEB 17553"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22963036),
        dec: Angle.Degrees(+26.05515008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -381.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188594"},
        {"Hipparcos Number", "HIP 97996"},
        {"Geneva Identification System", "GEN# +1.00188594"},
        {"Smithsonian Astrophysical Observation", "SAO 87918"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.73371894),
        dec: Angle.Degrees(+26.05522256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170648"},
        {"Hipparcos Number", "HIP 90635"},
        {"Smithsonian Astrophysical Observation", "SAO 86119"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39777849),
        dec: Angle.Degrees(+26.05567465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42746",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6942 AB"},
        {"Hipparcos Number", "HIP 42746"},
        {"Smithsonian Astrophysical Observation", "SAO 80374"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.67779118),
        dec: Angle.Degrees(+26.05575290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93563",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)03, 24.2100),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)03, 24.400)
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
    primaryId: "HIP 81855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150918"},
        {"Hipparcos Number", "HIP 81855"},
        {"Smithsonian Astrophysical Observation", "SAO 84559"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.77706402),
        dec: Angle.Degrees(+26.05692885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181164"},
        {"Hipparcos Number", "HIP 94876"},
        {"Geneva Identification System", "GEN# +1.00181164"},
        {"Smithsonian Astrophysical Observation", "SAO 87053"},
        {"Wilson Evans Batten Catalogue", "WEB 16563"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.61747590),
        dec: Angle.Degrees(+26.05711170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218943"},
        {"Hipparcos Number", "HIP 114527"},
        {"Smithsonian Astrophysical Observation", "SAO 91081"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.96318134),
        dec: Angle.Degrees(+26.05907899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107257"},
        {"Smithsonian Astrophysical Observation", "SAO 89927"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.86266265),
        dec: Angle.Degrees(+26.05942558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28695"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.87503721),
        dec: Angle.Degrees(+26.06010664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55104",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55104"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.23803538),
        dec: Angle.Degrees(+26.06091863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176283"},
        {"Hipparcos Number", "HIP 93160"},
        {"Smithsonian Astrophysical Observation", "SAO 86650"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.63687340),
        dec: Angle.Degrees(+26.06175216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184537"},
        {"Hipparcos Number", "HIP 96220"},
        {"Geneva Identification System", "GEN# +1.00184537"},
        {"Renson", "Renson 50900"},
        {"Smithsonian Astrophysical Observation", "SAO 87364"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.50305346),
        dec: Angle.Degrees(+26.06257840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2725"},
        {"Cincinnati Publication", "Ci 18 66"},
        {"Geneva Identification System", "GEN# +0.02500077"},
        {"Smithsonian Astrophysical Observation", "SAO 74113"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.69614733),
        dec: Angle.Degrees(+26.06594227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 378.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3571"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.40727587),
        dec: Angle.Degrees(+26.06675118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196866"},
        {"Hipparcos Number", "HIP 101930"},
        {"Geneva Identification System", "GEN# +1.00196866"},
        {"Smithsonian Astrophysical Observation", "SAO 88962"},
        {"Wilson Evans Batten Catalogue", "WEB 18421"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.83477905),
        dec: Angle.Degrees(+26.06787704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82920",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82920"},
        {"Smithsonian Astrophysical Observation", "SAO 84707"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.17535864),
        dec: Angle.Degrees(+26.06799100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141714"},
        {"Hipparcos Number", "HIP 77512"},
        {"Fundamental Katalog 5th Edition", "FK5 3252"},
        {"Geneva Identification System", "GEN# +1.00141714"},
        {"Smithsonian Astrophysical Observation", "SAO 84019"},
        {"Wilson Evans Batten Catalogue", "WEB 13125"},
    },
    visualMagnitude: 4.59,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39874182),
        dec: Angle.Degrees(+26.06854936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198514"},
        {"Hipparcos Number", "HIP 102840"},
        {"Smithsonian Astrophysical Observation", "SAO 89183"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.51542128),
        dec: Angle.Degrees(+26.07083848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257713"},
        {"Hipparcos Number", "HIP 30839"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.15998374),
        dec: Angle.Degrees(+26.07147824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65482",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65482"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.31726801),
        dec: Angle.Degrees(+26.07267246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125728"},
        {"Hipparcos Number", "HIP 70108"},
        {"Geneva Identification System", "GEN# +1.00125728"},
        {"Smithsonian Astrophysical Observation", "SAO 83298"},
        {"Wilson Evans Batten Catalogue", "WEB 12187"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.18783935),
        dec: Angle.Degrees(+26.07553732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197102"},
        {"Hipparcos Number", "HIP 102037"},
        {"Smithsonian Astrophysical Observation", "SAO 89000"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.17608727),
        dec: Angle.Degrees(+26.07921536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150665"},
        {"Hipparcos Number", "HIP 81722"},
        {"Smithsonian Astrophysical Observation", "SAO 84542"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.39103771),
        dec: Angle.Degrees(+26.08023269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24655"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.35673230),
        dec: Angle.Degrees(+26.08031939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51530"},
        {"Hipparcos Number", "HIP 33595"},
        {"Geneva Identification System", "GEN# +1.00051530"},
        {"Smithsonian Astrophysical Observation", "SAO 78929"},
        {"Wilson Evans Batten Catalogue", "WEB 6756"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.69798197),
        dec: Angle.Degrees(+26.08085056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242261"},
        {"Hipparcos Number", "HIP 24654"},
        {"Smithsonian Astrophysical Observation", "SAO 77081"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.35227313),
        dec: Angle.Degrees(+26.08317043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90288",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11337 A"},
        {"Henry Draper", "HD 169797"},
        {"Hipparcos Number", "HIP 90288"},
        {"Geneva Identification System", "GEN# +1.00169797A"},
        {"Smithsonian Astrophysical Observation", "SAO 86025"},
        {"Wilson Evans Batten Catalogue", "WEB 15448"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.33597272),
        dec: Angle.Degrees(+26.08411671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203031"},
        {"Hipparcos Number", "HIP 105238"},
        {"Geneva Identification System", "GEN# +1.00203031"},
        {"Smithsonian Astrophysical Observation", "SAO 89610"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.75081478),
        dec: Angle.Degrees(+26.09009568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18189"},
        {"Hipparcos Number", "HIP 13672"},
        {"Geneva Identification System", "GEN# +1.00018189"},
        {"Smithsonian Astrophysical Observation", "SAO 75650"},
        {"Wilson Evans Batten Catalogue", "WEB 2712"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.01992438),
        dec: Angle.Degrees(+26.09074942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335839"},
        {"Hipparcos Number", "HIP 89633"},
        {"Smithsonian Astrophysical Observation", "SAO 85898"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.37808281),
        dec: Angle.Degrees(+26.09462150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7825"},
        {"Hipparcos Number", "HIP 6101"},
        {"Smithsonian Astrophysical Observation", "SAO 74622"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.58541709),
        dec: Angle.Degrees(+26.09513460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11869 AB"},
        {"Henry Draper", "HD 176005"},
        {"Hipparcos Number", "HIP 93038"},
        {"Smithsonian Astrophysical Observation", "SAO 86619"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.28261485),
        dec: Angle.Degrees(+26.09587401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75489"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.31125070),
        dec: Angle.Degrees(+26.09612015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88817",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11089 B"},
        {"Henry Draper", "HD 166046"},
        {"Hipparcos Number", "HIP 88817"},
        {"Geneva Identification System", "GEN# +1.00166046"},
        {"Smithsonian Astrophysical Observation", "SAO 85752"},
        {"Wilson Evans Batten Catalogue", "WEB 15051"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.95628810),
        dec: Angle.Degrees(+26.09726716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112191"},
        {"Smithsonian Astrophysical Observation", "SAO 90738"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.84168392),
        dec: Angle.Degrees(+26.09744367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107966"},
        {"Hipparcos Number", "HIP 60514"},
        {"Geneva Identification System", "GEN# +5.21110107"},
        {"Renson", "Renson 31320"},
        {"Smithsonian Astrophysical Observation", "SAO 82291"},
        {"Wilson Evans Batten Catalogue", "WEB 10761"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.07724865),
        dec: Angle.Degrees(+26.09861325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11089 A"},
        {"Henry Draper", "HD 166045"},
        {"Hipparcos Number", "HIP 88818"},
        {"Celescope Catalog", "CEL 4628"},
        {"Geneva Identification System", "GEN# +1.00166045"},
        {"Smithsonian Astrophysical Observation", "SAO 85753"},
        {"Wilson Evans Batten Catalogue", "WEB 15050"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.95651031),
        dec: Angle.Degrees(+26.10122114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182865"},
        {"Hipparcos Number", "HIP 95512"},
        {"Renson", "Renson 50555"},
        {"Smithsonian Astrophysical Observation", "SAO 87195"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.41260078),
        dec: Angle.Degrees(+26.10400897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13380"},
        {"Hipparcos Number", "HIP 10221"},
        {"Smithsonian Astrophysical Observation", "SAO 75192"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.85665287),
        dec: Angle.Degrees(+26.10462491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147367"},
        {"Hipparcos Number", "HIP 80078"},
        {"Geneva Identification System", "GEN# +1.00147367"},
        {"Smithsonian Astrophysical Observation", "SAO 84311"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.15323501),
        dec: Angle.Degrees(+26.10486844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64833"},
        {"Hipparcos Number", "HIP 38832"},
        {"Smithsonian Astrophysical Observation", "SAO 79816"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.19957228),
        dec: Angle.Degrees(+26.10526525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197851"},
        {"Hipparcos Number", "HIP 102442"},
        {"Smithsonian Astrophysical Observation", "SAO 89097"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.37170406),
        dec: Angle.Degrees(+26.10586227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193388"},
        {"Hipparcos Number", "HIP 100171"},
        {"Geneva Identification System", "GEN# +1.00193388"},
        {"Smithsonian Astrophysical Observation", "SAO 88509"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.77817955),
        dec: Angle.Degrees(+26.10780777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85693",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Maasym"},
        {"Henry Draper", "HD 158899"},
        {"Hipparcos Number", "HIP 85693"},
        {"Fundamental Katalog 5th Edition", "FK5 1460"},
        {"Geneva Identification System", "GEN# +1.00158899"},
        {"Smithsonian Astrophysical Observation", "SAO 85163"},
        {"Wilson Evans Batten Catalogue", "WEB 14459"},
    },
    visualMagnitude: 4.41,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.68457505),
        dec: Angle.Degrees(+26.11060450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59925"},
        {"Hipparcos Number", "HIP 36725"},
        {"Smithsonian Astrophysical Observation", "SAO 79495"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.30294856),
        dec: Angle.Degrees(+26.11381496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11721"},
        {"Hipparcos Number", "HIP 8970"},
        {"Geneva Identification System", "GEN# +1.00011721"},
        {"Smithsonian Astrophysical Observation", "SAO 75025"},
        {"Wilson Evans Batten Catalogue", "WEB 1882"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.89385172),
        dec: Angle.Degrees(+26.11386854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224561"},
        {"Hipparcos Number", "HIP 118232"},
        {"Smithsonian Astrophysical Observation", "SAO 91628"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.72826855),
        dec: Angle.Degrees(+26.11424400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8879 A"},
        {"Henry Draper", "HD 116316"},
        {"Hipparcos Number", "HIP 65268"},
        {"Geneva Identification System", "GEN# +1.00116316"},
        {"Smithsonian Astrophysical Observation", "SAO 82809"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.64273402),
        dec: Angle.Degrees(+26.11565720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66662"},
        {"Hipparcos Number", "HIP 39603"},
        {"Smithsonian Astrophysical Observation", "SAO 79927"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.39172886),
        dec: Angle.Degrees(+26.11590341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66127"},
        {"Cincinnati Publication", "Ci 18 1752"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.33854326),
        dec: Angle.Degrees(+26.11962283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5041"},
        {"Geneva Identification System", "GEN# +9.80069045"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.13435587),
        dec: Angle.Degrees(+26.12014117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 317.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108805"},
        {"Hipparcos Number", "HIP 60980"},
        {"Geneva Identification System", "GEN# +5.21110153"},
        {"Smithsonian Astrophysical Observation", "SAO 82338"},
        {"Wilson Evans Batten Catalogue", "WEB 10853"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.49142232),
        dec: Angle.Degrees(+26.12080859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3467"},
        {"Hipparcos Number", "HIP 2969"},
        {"Smithsonian Astrophysical Observation", "SAO 74155"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.44094984),
        dec: Angle.Degrees(+26.12158938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72680"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.90344759),
        dec: Angle.Degrees(+26.12656080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110628"},
        {"Hipparcos Number", "HIP 62073"},
        {"Geneva Identification System", "GEN# +1.00110628"},
        {"Smithsonian Astrophysical Observation", "SAO 82456"},
        {"Wilson Evans Batten Catalogue", "WEB 11036"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.82695030),
        dec: Angle.Degrees(+26.12659918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194450"},
        {"Hipparcos Number", "HIP 100689"},
        {"Smithsonian Astrophysical Observation", "SAO 88644"},
        {"Wilson Evans Batten Catalogue", "WEB 18193"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.20051591),
        dec: Angle.Degrees(+26.12715559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246197"},
        {"Hipparcos Number", "HIP 26759"},
        {"Smithsonian Astrophysical Observation", "SAO 77388"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.26773891),
        dec: Angle.Degrees(+26.12817287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49012"},
        {"Hipparcos Number", "HIP 32543"},
        {"Smithsonian Astrophysical Observation", "SAO 78744"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.86442376),
        dec: Angle.Degrees(+26.12946042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262819"},
        {"Hipparcos Number", "HIP 32306"},
        {"Smithsonian Astrophysical Observation", "SAO 78693"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.17889728),
        dec: Angle.Degrees(+26.13019774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172650"},
        {"Hipparcos Number", "HIP 91568"},
        {"Geneva Identification System", "GEN# +1.00172650"},
        {"Smithsonian Astrophysical Observation", "SAO 86307"},
        {"Wilson Evans Batten Catalogue", "WEB 15745"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.09066164),
        dec: Angle.Degrees(+26.13086180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77948"},
        {"Hipparcos Number", "HIP 44670"},
        {"Smithsonian Astrophysical Observation", "SAO 80630"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.55127441),
        dec: Angle.Degrees(+26.13091176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257046"},
        {"Hipparcos Number", "HIP 30644"},
        {"Smithsonian Astrophysical Observation", "SAO 78368"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.59667976),
        dec: Angle.Degrees(+26.13814798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243809"},
        {"Hipparcos Number", "HIP 25556"},
        {"Smithsonian Astrophysical Observation", "SAO 77185"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.94058030),
        dec: Angle.Degrees(+26.13847633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191898"},
        {"Hipparcos Number", "HIP 99467"},
        {"Geneva Identification System", "GEN# +2.68820007"},
        {"Smithsonian Astrophysical Observation", "SAO 88316"},
        {"Wilson Evans Batten Catalogue", "WEB 17781"},
        {"New General Catalogue", "NGC 6882 7"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.81789676),
        dec: Angle.Degrees(+26.13891754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1429"},
        {"Hipparcos Number", "HIP 1488"},
        {"Smithsonian Astrophysical Observation", "SAO 73883"},
        {"Wilson Evans Batten Catalogue", "WEB 274"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.62751675),
        dec: Angle.Degrees(+26.14035586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5770 AB"},
        {"Hipparcos Number", "HIP 34226"},
        {"Smithsonian Astrophysical Observation", "SAO 79046"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)05, 44.9400),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)08, 25.500)
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
    primaryId: "HIP 80500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148265"},
        {"Hipparcos Number", "HIP 80500"},
        {"Geneva Identification System", "GEN# +1.00148265"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.47952029),
        dec: Angle.Degrees(+26.14085405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100434"},
        {"Hipparcos Number", "HIP 56385"},
        {"Geneva Identification System", "GEN# +1.00100434"},
        {"Smithsonian Astrophysical Observation", "SAO 81877"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.37691738),
        dec: Angle.Degrees(+26.14667056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194989"},
        {"Hipparcos Number", "HIP 100927"},
        {"Geneva Identification System", "GEN# +1.00194989"},
        {"Renson", "Renson 54360"},
        {"Smithsonian Astrophysical Observation", "SAO 88704"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.94801033),
        dec: Angle.Degrees(+26.14670754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99195"},
        {"Hipparcos Number", "HIP 55724"},
        {"Smithsonian Astrophysical Observation", "SAO 81810"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27115518),
        dec: Angle.Degrees(+26.14836432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9255"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.74315080),
        dec: Angle.Degrees(+26.14838120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81567"},
        {"Smithsonian Astrophysical Observation", "SAO 84520"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.88275789),
        dec: Angle.Degrees(+26.14863245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283869"},
        {"Hipparcos Number", "HIP 22271"},
        {"Geneva Identification System", "GEN# +1.00283869"},
        {"Wilson Evans Batten Catalogue", "WEB 4289"},
    },
    visualMagnitude: 10.61,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.92386071),
        dec: Angle.Degrees(+26.15043249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88460"},
        {"Hipparcos Number", "HIP 50093"},
        {"Smithsonian Astrophysical Observation", "SAO 81242"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.42586218),
        dec: Angle.Degrees(+26.15058455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101396"},
        {"Hipparcos Number", "HIP 56921"},
        {"Geneva Identification System", "GEN# +1.00101396"},
        {"Smithsonian Astrophysical Observation", "SAO 81933"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.05253454),
        dec: Angle.Degrees(+26.15354257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223487"},
        {"Hipparcos Number", "HIP 117512"},
        {"Smithsonian Astrophysical Observation", "SAO 91525"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.46538041),
        dec: Angle.Degrees(+26.15420599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185270"},
        {"Hipparcos Number", "HIP 96514"},
        {"Geneva Identification System", "GEN# +1.00185270"},
        {"Smithsonian Astrophysical Observation", "SAO 87466"},
        {"Wilson Evans Batten Catalogue", "WEB 16939"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.31653909),
        dec: Angle.Degrees(+26.15441911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11050"},
        {"Smithsonian Astrophysical Observation", "SAO 75314"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.56733170),
        dec: Angle.Degrees(+26.15732658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200425"},
        {"Hipparcos Number", "HIP 103849"},
        {"Geneva Identification System", "GEN# +1.00200425"},
        {"Smithsonian Astrophysical Observation", "SAO 89398"},
        {"Wilson Evans Batten Catalogue", "WEB 18905"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.64492838),
        dec: Angle.Degrees(+26.15741909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91546"},
        {"Hipparcos Number", "HIP 51770"},
        {"Geneva Identification System", "GEN# +1.00091546"},
        {"Smithsonian Astrophysical Observation", "SAO 81421"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.68228093),
        dec: Angle.Degrees(+26.15907313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57267"},
        {"Hipparcos Number", "HIP 35664"},
        {"Geneva Identification System", "GEN# +1.00057267"},
        {"Smithsonian Astrophysical Observation", "SAO 79316"},
        {"Wilson Evans Batten Catalogue", "WEB 7103"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.38674129),
        dec: Angle.Degrees(+26.15925845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2867"},
        {"Smithsonian Astrophysical Observation", "SAO 74138"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.09218245),
        dec: Angle.Degrees(+26.15930855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94948"},
        {"Hipparcos Number", "HIP 53599"},
        {"Geneva Identification System", "GEN# +1.00094948"},
        {"Smithsonian Astrophysical Observation", "SAO 81600"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.48635558),
        dec: Angle.Degrees(+26.15995997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338812"},
        {"Hipparcos Number", "HIP 96954"},
        {"Smithsonian Astrophysical Observation", "SAO 87602"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.63593535),
        dec: Angle.Degrees(+26.16468458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77729"},
        {"Hipparcos Number", "HIP 44592"},
        {"Geneva Identification System", "GEN# +1.00077729"},
        {"Smithsonian Astrophysical Observation", "SAO 80616"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.26973016),
        dec: Angle.Degrees(+26.16484519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38620",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6444 A"},
        {"Henry Draper", "HD 64350"},
        {"Hipparcos Number", "HIP 38620"},
        {"Smithsonian Astrophysical Observation", "SAO 79784"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.61824881),
        dec: Angle.Degrees(+26.16718402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10866"},
        {"Hipparcos Number", "HIP 8300"},
        {"Smithsonian Astrophysical Observation", "SAO 74926"},
        {"Wilson Evans Batten Catalogue", "WEB 1768"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.76376246),
        dec: Angle.Degrees(+26.16831104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86534"},
        {"Hipparcos Number", "HIP 48984"},
        {"Smithsonian Astrophysical Observation", "SAO 81132"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.91337531),
        dec: Angle.Degrees(+26.16992547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143707"},
        {"Hipparcos Number", "HIP 78464"},
        {"Geneva Identification System", "GEN# +1.00143707"},
        {"Smithsonian Astrophysical Observation", "SAO 84144"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.26646359),
        dec: Angle.Degrees(+26.17231592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4312"},
        {"Hipparcos Number", "HIP 3585"},
        {"Geneva Identification System", "GEN# +1.00004312"},
        {"Smithsonian Astrophysical Observation", "SAO 74251"},
        {"Wilson Evans Batten Catalogue", "WEB 636"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.44379465),
        dec: Angle.Degrees(+26.17304461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203925"},
        {"Hipparcos Number", "HIP 105703"},
        {"Geneva Identification System", "GEN# +1.00203925"},
        {"Smithsonian Astrophysical Observation", "SAO 89685"},
        {"Wilson Evans Batten Catalogue", "WEB 19186"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.14155670),
        dec: Angle.Degrees(+26.17454472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91855"},
        {"Hipparcos Number", "HIP 51954"},
        {"Smithsonian Astrophysical Observation", "SAO 81435"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.19901856),
        dec: Angle.Degrees(+26.17460486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79303"},
        {"Hipparcos Number", "HIP 45304"},
        {"Smithsonian Astrophysical Observation", "SAO 80705"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.50205353),
        dec: Angle.Degrees(+26.17641941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198184"},
        {"Hipparcos Number", "HIP 102630"},
        {"Smithsonian Astrophysical Observation", "SAO 89132"},
        {"Wilson Evans Batten Catalogue", "WEB 18600"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.94894082),
        dec: Angle.Degrees(+26.17798961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141794"},
        {"Hipparcos Number", "HIP 77548"},
        {"Smithsonian Astrophysical Observation", "SAO 84025"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50303898),
        dec: Angle.Degrees(+26.17882408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13397 AB"},
        {"Henry Draper", "HD 191101"},
        {"Hipparcos Number", "HIP 99106"},
        {"Smithsonian Astrophysical Observation", "SAO 88216"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.81071135),
        dec: Angle.Degrees(+26.17983379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155989"},
        {"Hipparcos Number", "HIP 84291"},
        {"Smithsonian Astrophysical Observation", "SAO 84940"},
        {"Wilson Evans Batten Catalogue", "WEB 14232"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.48547027),
        dec: Angle.Degrees(+26.18073398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57903"},
    },
    visualMagnitude: 10.49,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.15136188),
        dec: Angle.Degrees(+26.18178097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46146",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7351 AB"},
        {"Henry Draper", "HD 81146"},
        {"Hipparcos Number", "HIP 46146"},
        {"Fundamental Katalog 5th Edition", "FK5 1244"},
        {"Geneva Identification System", "GEN# +1.00081146J"},
        {"Smithsonian Astrophysical Observation", "SAO 80807"},
        {"Wilson Evans Batten Catalogue", "WEB 8737"},
    },
    visualMagnitude: 4.47,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.16366395),
        dec: Angle.Degrees(+26.18244091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242930"},
        {"Hipparcos Number", "HIP 25089"},
    },
    visualMagnitude: 10.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.57010937),
        dec: Angle.Degrees(+26.18512952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87269"},
        {"Smithsonian Astrophysical Observation", "SAO 85455"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.48213198),
        dec: Angle.Degrees(+26.18637161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220684"},
        {"Hipparcos Number", "HIP 115638"},
        {"Smithsonian Astrophysical Observation", "SAO 91255"},
        {"Wilson Evans Batten Catalogue", "WEB 20465"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.39152190),
        dec: Angle.Degrees(+26.18659283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98458",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13237 AB"},
        {"Henry Draper", "HD 189671"},
        {"Hipparcos Number", "HIP 98458"},
        {"Geneva Identification System", "GEN# +1.00189671J"},
        {"Smithsonian Astrophysical Observation", "SAO 88046"},
        {"Wilson Evans Batten Catalogue", "WEB 17384"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.06399327),
        dec: Angle.Degrees(+26.18790438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336601"},
        {"Hipparcos Number", "HIP 91501"},
        {"Geneva Identification System", "GEN# +1.00336601"},
        {"Smithsonian Astrophysical Observation", "SAO 86295"},
        {"Wilson Evans Batten Catalogue", "WEB 15726"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.90743480),
        dec: Angle.Degrees(+26.18896882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107086"},
        {"Hipparcos Number", "HIP 60031"},
        {"Geneva Identification System", "GEN# +5.21110055"},
        {"Smithsonian Astrophysical Observation", "SAO 82229"},
        {"Wilson Evans Batten Catalogue", "WEB 10670"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.67058430),
        dec: Angle.Degrees(+26.19023164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116555"},
        {"Smithsonian Astrophysical Observation", "SAO 91382"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31513358),
        dec: Angle.Degrees(+26.19213468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82817"},
        {"Hipparcos Number", "HIP 47034"},
        {"Geneva Identification System", "GEN# +1.00082817"},
        {"Smithsonian Astrophysical Observation", "SAO 80912"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.78675295),
        dec: Angle.Degrees(+26.19266663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71729"},
        {"Hipparcos Number", "HIP 41679"},
        {"Smithsonian Astrophysical Observation", "SAO 80210"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.45644502),
        dec: Angle.Degrees(+26.19288335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339102"},
        {"Hipparcos Number", "HIP 97852"},
        {"Renson", "Renson 51990"},
        {"Smithsonian Astrophysical Observation", "SAO 87867"},
    },
    visualMagnitude: 9.60,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.28481192),
        dec: Angle.Degrees(+26.19405936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69345"},
        {"Geneva Identification System", "GEN# +0.02602536"},
        {"Wilson Evans Batten Catalogue", "WEB 12092"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.89297735),
        dec: Angle.Degrees(+26.19540003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72363"},
        {"Smithsonian Astrophysical Observation", "SAO 83526"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.94762388),
        dec: Angle.Degrees(+26.19868314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173549"},
        {"Hipparcos Number", "HIP 91977"},
        {"Smithsonian Astrophysical Observation", "SAO 86395"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.20872076),
        dec: Angle.Degrees(+26.19883826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43766",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7082 AB"},
        {"Henry Draper", "HD 76095"},
        {"Hipparcos Number", "HIP 43766"},
        {"Cincinnati Publication", "Ci 20 496"},
        {"Geneva Identification System", "GEN# +1.00076095J"},
        {"Smithsonian Astrophysical Observation", "SAO 80503"},
        {"Wilson Evans Batten Catalogue", "WEB 8419"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.73311556),
        dec: Angle.Degrees(+26.19938553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -450.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339686"},
        {"Hipparcos Number", "HIP 99293"},
        {"Geneva Identification System", "GEN# +1.00339686"},
        {"Smithsonian Astrophysical Observation", "SAO 88261"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.34292941),
        dec: Angle.Degrees(+26.20120685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126694"},
        {"Hipparcos Number", "HIP 70605"},
        {"Geneva Identification System", "GEN# +1.00126694"},
        {"Smithsonian Astrophysical Observation", "SAO 83354"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.63032525),
        dec: Angle.Degrees(+26.20239376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158555"},
        {"Hipparcos Number", "HIP 85542"},
        {"Smithsonian Astrophysical Observation", "SAO 85131"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.22860311),
        dec: Angle.Degrees(+26.20381455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7147 A"},
        {"Henry Draper", "HD 77229"},
        {"Hipparcos Number", "HIP 44352"},
        {"Smithsonian Astrophysical Observation", "SAO 80586"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48417111),
        dec: Angle.Degrees(+26.20436192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81359"},
        {"Hipparcos Number", "HIP 46255"},
        {"Smithsonian Astrophysical Observation", "SAO 80826"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.45016054),
        dec: Angle.Degrees(+26.20459090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12270"},
        {"Smithsonian Astrophysical Observation", "SAO 75483"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.49681837),
        dec: Angle.Degrees(+26.20632682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44351",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7147 B"},
        {"Hipparcos Number", "HIP 44351"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48415385),
        dec: Angle.Degrees(+26.20717454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94336"},
        {"Hipparcos Number", "HIP 53262"},
        {"Fundamental Katalog 5th Edition", "FK5 4959"},
        {"Geneva Identification System", "GEN# +1.00094336"},
        {"Smithsonian Astrophysical Observation", "SAO 81568"},
        {"Wilson Evans Batten Catalogue", "WEB 9672"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.39522164),
        dec: Angle.Degrees(+26.20781322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20284"},
        {"Hipparcos Number", "HIP 15238"},
        {"Smithsonian Astrophysical Observation", "SAO 75827"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.13523575),
        dec: Angle.Degrees(+26.20866271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152032"},
        {"Hipparcos Number", "HIP 82385"},
        {"Geneva Identification System", "GEN# +1.00152032"},
        {"Smithsonian Astrophysical Observation", "SAO 84631"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51696402),
        dec: Angle.Degrees(+26.20913396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56850"},
        {"Smithsonian Astrophysical Observation", "SAO 81923"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.83906960),
        dec: Angle.Degrees(+26.21026049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204687"},
        {"Hipparcos Number", "HIP 106112"},
        {"Smithsonian Astrophysical Observation", "SAO 89748"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.41218553),
        dec: Angle.Degrees(+26.21055153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25768"},
        {"Hipparcos Number", "HIP 19136"},
        {"Geneva Identification System", "GEN# +1.00025768"},
        {"Smithsonian Astrophysical Observation", "SAO 76449"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51904459),
        dec: Angle.Degrees(+26.21185919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81855"},
        {"Hipparcos Number", "HIP 46490"},
        {"Smithsonian Astrophysical Observation", "SAO 80852"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.23010609),
        dec: Angle.Degrees(+26.21358935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23453"},
        {"Hipparcos Number", "HIP 17609"},
        {"Cincinnati Publication", "Ci 20 259"},
        {"Geneva Identification System", "GEN# +1.00023453"},
        {"Wilson Evans Batten Catalogue", "WEB 3352"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.58286876),
        dec: Angle.Degrees(+26.21598281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 386.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201762"},
        {"Hipparcos Number", "HIP 104569"},
        {"Smithsonian Astrophysical Observation", "SAO 89510"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.74622609),
        dec: Angle.Degrees(+26.21765762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283933"},
        {"Hipparcos Number", "HIP 22864"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.78053753),
        dec: Angle.Degrees(+26.21773859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283646"},
        {"Hipparcos Number", "HIP 20895"},
        {"Geneva Identification System", "GEN# +1.00283646"},
        {"Wilson Evans Batten Catalogue", "WEB 4013"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.16575346),
        dec: Angle.Degrees(+26.22016660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111514"},
        {"Hipparcos Number", "HIP 62592"},
        {"Geneva Identification System", "GEN# +1.00111514"},
        {"Smithsonian Astrophysical Observation", "SAO 82516"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38642561),
        dec: Angle.Degrees(+26.22199505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169245"},
        {"Hipparcos Number", "HIP 90058"},
        {"Geneva Identification System", "GEN# +1.00169245"},
        {"Smithsonian Astrophysical Observation", "SAO 85985"},
        {"Wilson Evans Batten Catalogue", "WEB 15392"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.67498798),
        dec: Angle.Degrees(+26.22411875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40200",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6654 AB"},
        {"Henry Draper", "HD 68282"},
        {"Hipparcos Number", "HIP 40200"},
        {"Smithsonian Astrophysical Observation", "SAO 80013"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.16460441),
        dec: Angle.Degrees(+26.22421422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113312"},
        {"Smithsonian Astrophysical Observation", "SAO 90886"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.21888659),
        dec: Angle.Degrees(+26.22559470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187943"},
        {"Hipparcos Number", "HIP 97730"},
        {"Smithsonian Astrophysical Observation", "SAO 87830"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.90501658),
        dec: Angle.Degrees(+26.22564032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262517"},
        {"Hipparcos Number", "HIP 32232"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.92935121),
        dec: Angle.Degrees(+26.22596364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108642"},
        {"Hipparcos Number", "HIP 60880"},
        {"Geneva Identification System", "GEN# +5.21110144"},
        {"Renson", "Renson 31530"},
        {"Smithsonian Astrophysical Observation", "SAO 82326"},
        {"Wilson Evans Batten Catalogue", "WEB 10835"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.15902221),
        dec: Angle.Degrees(+26.22697321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58747"},
        {"Hipparcos Number", "HIP 36262"},
        {"Smithsonian Astrophysical Observation", "SAO 79405"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.00384313),
        dec: Angle.Degrees(+26.22751902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170028"},
        {"Hipparcos Number", "HIP 90361"},
        {"Geneva Identification System", "GEN# +1.00170028"},
        {"Smithsonian Astrophysical Observation", "SAO 86048"},
        {"Wilson Evans Batten Catalogue", "WEB 15468"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.58182891),
        dec: Angle.Degrees(+26.22773104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66361"},
        {"Smithsonian Astrophysical Observation", "SAO 82895"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.04523963),
        dec: Angle.Degrees(+26.22866354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176527"},
        {"Hipparcos Number", "HIP 93256"},
        {"Geneva Identification System", "GEN# +1.00176527"},
        {"Smithsonian Astrophysical Observation", "SAO 86673"},
        {"Wilson Evans Batten Catalogue", "WEB 16171"},
    },
    visualMagnitude: 5.26,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.93928575),
        dec: Angle.Degrees(+26.23043204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203030"},
        {"Henry Draper 2", "HD 203030A"},
        {"Hipparcos Number", "HIP 105232"},
        {"Geneva Identification System", "GEN# +1.00203030"},
        {"Smithsonian Astrophysical Observation", "SAO 89609"},
        {"Wilson Evans Batten Catalogue", "WEB 19113"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.74221892),
        dec: Angle.Degrees(+26.23052250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173435"},
        {"Hipparcos Number", "HIP 91914"},
        {"Geneva Identification System", "GEN# +1.00173435"},
        {"Smithsonian Astrophysical Observation", "SAO 86384"},
        {"Wilson Evans Batten Catalogue", "WEB 15823"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.06003929),
        dec: Angle.Degrees(+26.23097814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151024"},
        {"Hipparcos Number", "HIP 81912"},
        {"Smithsonian Astrophysical Observation", "SAO 84569"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.96618956),
        dec: Angle.Degrees(+26.23103924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47178",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47178"},
        {"Geneva Identification System", "GEN# +0.02601981"},
        {"Smithsonian Astrophysical Observation", "SAO 80927"},
        {"Wilson Evans Batten Catalogue", "WEB 8874"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.21584846),
        dec: Angle.Degrees(+26.23269222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267750"},
        {"Hipparcos Number", "HIP 33793"},
        {"Smithsonian Astrophysical Observation", "SAO 78970"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.25666973),
        dec: Angle.Degrees(+26.23343476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187957"},
        {"Hipparcos Number", "HIP 97741"},
        {"Smithsonian Astrophysical Observation", "SAO 87832"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.93850121),
        dec: Angle.Degrees(+26.23722435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73160"},
        {"Hipparcos Number", "HIP 42326"},
        {"Smithsonian Astrophysical Observation", "SAO 80298"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.44422691),
        dec: Angle.Degrees(+26.23763260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27267"},
        {"Hipparcos Number", "HIP 20170"},
        {"Smithsonian Astrophysical Observation", "SAO 76547"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.85120499),
        dec: Angle.Degrees(+26.23897835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283240"},
        {"Hipparcos Number", "HIP 18630"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.80940661),
        dec: Angle.Degrees(+26.23914289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143211"},
        {"Hipparcos Number", "HIP 78206"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.54392307),
        dec: Angle.Degrees(+26.24169865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7308"},
        {"Hipparcos Number", "HIP 5744"},
        {"Smithsonian Astrophysical Observation", "SAO 74570"},
        {"Wilson Evans Batten Catalogue", "WEB 1310"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43873267),
        dec: Angle.Degrees(+26.24171772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29835"},
        {"Hipparcos Number", "HIP 21951"},
        {"Smithsonian Astrophysical Observation", "SAO 76725"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.77101584),
        dec: Angle.Degrees(+26.24311606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167275"},
        {"Hipparcos Number", "HIP 89313"},
        {"Geneva Identification System", "GEN# +1.00167275"},
        {"Smithsonian Astrophysical Observation", "SAO 85841"},
        {"Wilson Evans Batten Catalogue", "WEB 15183"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.36211592),
        dec: Angle.Degrees(+26.24412699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153753"},
        {"Hipparcos Number", "HIP 83208"},
        {"Smithsonian Astrophysical Observation", "SAO 84748"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.07650959),
        dec: Angle.Degrees(+26.24421671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12153 A"},
        {"Henry Draper", "HD 179461"},
        {"Hipparcos Number", "HIP 94308"},
        {"Geneva Identification System", "GEN# +1.00179461"},
        {"Renson", "Renson 49850"},
        {"Smithsonian Astrophysical Observation", "SAO 86917"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.93760707),
        dec: Angle.Degrees(+26.24932614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31781"},
        {"Hipparcos Number", "HIP 23209"},
        {"Geneva Identification System", "GEN# +1.00031781"},
        {"Smithsonian Astrophysical Observation", "SAO 76877"},
        {"Wilson Evans Batten Catalogue", "WEB 4504"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.91150221),
        dec: Angle.Degrees(+26.25004252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203288"},
        {"Hipparcos Number", "HIP 105376"},
        {"Smithsonian Astrophysical Observation", "SAO 89636"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.15899044),
        dec: Angle.Degrees(+26.25021346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9688"},
        {"Smithsonian Astrophysical Observation", "SAO 75127"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.15622133),
        dec: Angle.Degrees(+26.25116185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80217"},
        {"Hipparcos Number", "HIP 45723"},
        {"Smithsonian Astrophysical Observation", "SAO 80757"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.81406132),
        dec: Angle.Degrees(+26.25190409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246369"},
        {"Hipparcos Number", "HIP 26832"},
        {"Geneva Identification System", "GEN# +1.00246369"},
        {"Smithsonian Astrophysical Observation", "SAO 77407"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.46825993),
        dec: Angle.Degrees(+26.25871287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 976"},
        {"Hipparcos Number", "HIP 1133"},
        {"Geneva Identification System", "GEN# +1.00000976"},
        {"Smithsonian Astrophysical Observation", "SAO 73830"},
        {"Wilson Evans Batten Catalogue", "WEB 200"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.53745161),
        dec: Angle.Degrees(+26.25887171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67174"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.49071472),
        dec: Angle.Degrees(+26.25979706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202302"},
        {"Hipparcos Number", "HIP 104825"},
        {"Geneva Identification System", "GEN# +1.00202302"},
        {"Smithsonian Astrophysical Observation", "SAO 89548"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.54807555),
        dec: Angle.Degrees(+26.26038851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97748"},
        {"Hipparcos Number", "HIP 54945"},
        {"Smithsonian Astrophysical Observation", "SAO 81735"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.77235348),
        dec: Angle.Degrees(+26.26212557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182255"},
        {"Hipparcos Number", "HIP 95260"},
        {"Geneva Identification System", "GEN# +1.00182255"},
        {"Renson", "Renson 50370"},
        {"Smithsonian Astrophysical Observation", "SAO 87136"},
        {"Wilson Evans Batten Catalogue", "WEB 16644"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.71202082),
        dec: Angle.Degrees(+26.26242970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63410"},
        {"Hipparcos Number", "HIP 38221"},
        {"Fundamental Katalog 5th Edition", "FK5 4705"},
        {"Geneva Identification System", "GEN# +1.00063410"},
        {"Smithsonian Astrophysical Observation", "SAO 79726"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.44887148),
        dec: Angle.Degrees(+26.26384791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126598"},
        {"Hipparcos Number", "HIP 70548"},
        {"Geneva Identification System", "GEN# +1.00126598"},
        {"Smithsonian Astrophysical Observation", "SAO 83349"},
        {"Wilson Evans Batten Catalogue", "WEB 12235"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.47758259),
        dec: Angle.Degrees(+26.26535228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16431"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.89005475),
        dec: Angle.Degrees(+26.26556793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77078"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.08032522),
        dec: Angle.Degrees(+26.26590073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66472"},
        {"Smithsonian Astrophysical Observation", "SAO 82912"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.41412803),
        dec: Angle.Degrees(+26.26620799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205523"},
        {"Hipparcos Number", "HIP 106587"},
        {"Smithsonian Astrophysical Observation", "SAO 89814"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.80945691),
        dec: Angle.Degrees(+26.26631590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221958"},
        {"Hipparcos Number", "HIP 116499"},
        {"Geneva Identification System", "GEN# +1.00221958"},
        {"Smithsonian Astrophysical Observation", "SAO 91373"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.11355055),
        dec: Angle.Degrees(+26.26756145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6538"},
        {"Aitken 2", "ADS 6538 AB"},
        {"Henry Draper", "HD 66176"},
        {"Hipparcos Number", "HIP 39401"},
        {"Smithsonian Astrophysical Observation", "SAO 79893"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.82707439),
        dec: Angle.Degrees(+26.26762080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97102"},
        {"Hipparcos Number", "HIP 54634"},
        {"Smithsonian Astrophysical Observation", "SAO 81708"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.73399407),
        dec: Angle.Degrees(+26.26830019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36893"},
        {"Hipparcos Number", "HIP 26299"},
        {"Geneva Identification System", "GEN# +1.00036893"},
        {"Smithsonian Astrophysical Observation", "SAO 77300"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.01123385),
        dec: Angle.Degrees(+26.26832059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14624"},
        {"Hipparcos Number", "HIP 11053"},
        {"Geneva Identification System", "GEN# +1.00014624"},
        {"Smithsonian Astrophysical Observation", "SAO 75315"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.56987521),
        dec: Angle.Degrees(+26.26935536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21451"},
        {"Hipparcos Number", "HIP 16171"},
        {"Smithsonian Astrophysical Observation", "SAO 75943"},
        {"Wilson Evans Batten Catalogue", "WEB 3083"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.08867046),
        dec: Angle.Degrees(+26.27075930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109965",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15799 AB"},
        {"Henry Draper", "HD 211407"},
        {"Hipparcos Number", "HIP 109965"},
        {"Smithsonian Astrophysical Observation", "SAO 90375"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.08219112),
        dec: Angle.Degrees(+26.27111164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339483"},
        {"Hipparcos Number", "HIP 98807"},
        {"Geneva Identification System", "GEN# +1.00339483"},
        {"Smithsonian Astrophysical Observation", "SAO 88145"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.00311117),
        dec: Angle.Degrees(+26.27133153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110775"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.63528977),
        dec: Angle.Degrees(+26.27364831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213497"},
        {"Hipparcos Number", "HIP 111176"},
        {"Smithsonian Astrophysical Observation", "SAO 90565"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.83885695),
        dec: Angle.Degrees(+26.27406489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191381"},
        {"Hipparcos Number", "HIP 99244"},
        {"Smithsonian Astrophysical Observation", "SAO 88246"},
        {"Wilson Evans Batten Catalogue", "WEB 17682"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.17992486),
        dec: Angle.Degrees(+26.27486368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118114"},
        {"Hipparcos Number", "HIP 66225"},
        {"Smithsonian Astrophysical Observation", "SAO 82883"},
        {"Wilson Evans Batten Catalogue", "WEB 11699"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.59917346),
        dec: Angle.Degrees(+26.27613302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75708"},
        {"Smithsonian Astrophysical Observation", "SAO 83834"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00497473),
        dec: Angle.Degrees(+26.27820886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179460"},
        {"Hipparcos Number", "HIP 94298"},
        {"Smithsonian Astrophysical Observation", "SAO 86916"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.90712249),
        dec: Angle.Degrees(+26.27857446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219946"},
        {"Hipparcos Number", "HIP 115188"},
        {"Wilson Evans Batten Catalogue", "WEB 20403"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.96041112),
        dec: Angle.Degrees(+26.27880182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2330"},
        {"Hipparcos Number", "HIP 2174"},
        {"Geneva Identification System", "GEN# +1.00002330"},
        {"Smithsonian Astrophysical Observation", "SAO 74006"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.86103160),
        dec: Angle.Degrees(+26.27896981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64280"},
        {"Geneva Identification System", "GEN# +0.02702223"},
        {"Smithsonian Astrophysical Observation", "SAO 82689"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.60947645),
        dec: Angle.Degrees(+26.28469155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10668"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.31831724),
        dec: Angle.Degrees(+26.28475991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41950"},
        {"Smithsonian Astrophysical Observation", "SAO 80246"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.27010588),
        dec: Angle.Degrees(+26.28498589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191652"},
        {"Hipparcos Number", "HIP 99362"},
        {"Wilson Evans Batten Catalogue", "WEB 17735"},
        {"New General Catalogue", "NGC 6882 13"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.51777082),
        dec: Angle.Degrees(+26.28542158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335506"},
        {"Hipparcos Number", "HIP 88225"},
        {"Smithsonian Astrophysical Observation", "SAO 85639"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.25062772),
        dec: Angle.Degrees(+26.28773541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120664"},
        {"Hipparcos Number", "HIP 67544"},
        {"Fundamental Katalog 5th Edition", "FK5 5223"},
        {"Smithsonian Astrophysical Observation", "SAO 83023"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.59938286),
        dec: Angle.Degrees(+26.28839923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91277"},
        {"Hipparcos Number", "HIP 51617"},
        {"Smithsonian Astrophysical Observation", "SAO 81406"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.18164810),
        dec: Angle.Degrees(+26.28843275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109415"},
        {"Hipparcos Number", "HIP 61355"},
        {"Geneva Identification System", "GEN# +5.21110187"},
        {"Smithsonian Astrophysical Observation", "SAO 82383"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.58842813),
        dec: Angle.Degrees(+26.28918054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259184"},
        {"Hipparcos Number", "HIP 31232"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.26860003),
        dec: Angle.Degrees(+26.28998392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162864"},
        {"Hipparcos Number", "HIP 87449"},
        {"Smithsonian Astrophysical Observation", "SAO 85486"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.02416647),
        dec: Angle.Degrees(+26.29064780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176871"},
        {"Hipparcos Number", "HIP 93393"},
        {"Fundamental Katalog 5th Edition", "FK5 3518"},
        {"Geneva Identification System", "GEN# +1.00176871"},
        {"Smithsonian Astrophysical Observation", "SAO 86707"},
        {"Wilson Evans Batten Catalogue", "WEB 16197"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.32232152),
        dec: Angle.Degrees(+26.29143333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4550"},
        {"Hipparcos Number", "HIP 3719"},
        {"Geneva Identification System", "GEN# +1.00004550"},
        {"Smithsonian Astrophysical Observation", "SAO 74278"},
        {"Wilson Evans Batten Catalogue", "WEB 660"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.93731453),
        dec: Angle.Degrees(+26.29162679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115639"},
        {"Hipparcos Number", "HIP 64907"},
        {"Geneva Identification System", "GEN# +1.00115639"},
        {"Smithsonian Astrophysical Observation", "SAO 82765"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.56066785),
        dec: Angle.Degrees(+26.29233970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283648"},
        {"Hipparcos Number", "HIP 20652"},
        {"Geneva Identification System", "GEN# +1.00283648"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37860299),
        dec: Angle.Degrees(+26.29244709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17525"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.28414429),
        dec: Angle.Degrees(+26.29262540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189180"},
        {"Hipparcos Number", "HIP 98238"},
        {"Smithsonian Astrophysical Observation", "SAO 87984"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.44955585),
        dec: Angle.Degrees(+26.29405858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267826"},
        {"Hipparcos Number", "HIP 33831"},
        {"Smithsonian Astrophysical Observation", "SAO 78977"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.34961109),
        dec: Angle.Degrees(+26.29474153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9757 AB"},
        {"Henry Draper", "HD 140436"},
        {"Hipparcos Number", "HIP 76952"},
        {"Celescope Catalog", "CEL 4391"},
        {"Geneva Identification System", "GEN# +1.00140436J"},
        {"Smithsonian Astrophysical Observation", "SAO 83958"},
        {"Wilson Evans Batten Catalogue", "WEB 13050"},
    },
    visualMagnitude: 3.81,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.68599269),
        dec: Angle.Degrees(+26.29551419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59800",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59800"},
        {"Geneva Identification System", "GEN# +5.21110033"},
        {"Smithsonian Astrophysical Observation", "SAO 82206"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.94175690),
        dec: Angle.Degrees(+26.29569520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264088"},
        {"Hipparcos Number", "HIP 32663"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.20184639),
        dec: Angle.Degrees(+26.29664407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194033"},
        {"Hipparcos Number", "HIP 100476"},
        {"Smithsonian Astrophysical Observation", "SAO 88597"},
        {"Wilson Evans Batten Catalogue", "WEB 18144"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.63578722),
        dec: Angle.Degrees(+26.29808147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6133"},
        {"Hipparcos Number", "HIP 4893"},
        {"Geneva Identification System", "GEN# +1.00006133"},
        {"Smithsonian Astrophysical Observation", "SAO 74445"},
        {"Wilson Evans Batten Catalogue", "WEB 954"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.70953600),
        dec: Angle.Degrees(+26.29933494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206082"},
        {"Hipparcos Number", "HIP 106901"},
        {"Smithsonian Astrophysical Observation", "SAO 89873"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.76456953),
        dec: Angle.Degrees(+26.29957765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134320"},
        {"Hipparcos Number", "HIP 74087"},
        {"Geneva Identification System", "GEN# +1.00134320"},
        {"Smithsonian Astrophysical Observation", "SAO 83682"},
        {"Wilson Evans Batten Catalogue", "WEB 12657"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.09908475),
        dec: Angle.Degrees(+26.30118271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48024"},
        {"Geneva Identification System", "GEN# +9.80049024"},
    },
    visualMagnitude: 10.91,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.84391132),
        dec: Angle.Degrees(+26.30434448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -352.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142375"},
        {"Hipparcos Number", "HIP 77819"},
        {"Smithsonian Astrophysical Observation", "SAO 84059"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.34919096),
        dec: Angle.Degrees(+26.30596634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261960"},
        {"Hipparcos Number", "HIP 32057"},
        {"Smithsonian Astrophysical Observation", "SAO 78645"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.47124486),
        dec: Angle.Degrees(+26.30799477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196940"},
        {"Hipparcos Number", "HIP 101959"},
        {"Smithsonian Astrophysical Observation", "SAO 88973"},
        {"Wilson Evans Batten Catalogue", "WEB 18431"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.91564777),
        dec: Angle.Degrees(+26.30843598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103524"},
        {"Smithsonian Astrophysical Observation", "SAO 89340"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.60420661),
        dec: Angle.Degrees(+26.30846812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21510"},
        {"Hipparcos Number", "HIP 16217"},
        {"Geneva Identification System", "GEN# +1.00021510"},
        {"Smithsonian Astrophysical Observation", "SAO 75947"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.23620167),
        dec: Angle.Degrees(+26.30874641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6212"},
        {"Hipparcos Number", "HIP 4957"},
        {"Geneva Identification System", "GEN# +1.00006212"},
        {"Smithsonian Astrophysical Observation", "SAO 74457"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.89264480),
        dec: Angle.Degrees(+26.31190650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183033"},
        {"Hipparcos Number", "HIP 95594"},
        {"Geneva Identification System", "GEN# +1.00183033"},
        {"Smithsonian Astrophysical Observation", "SAO 87214"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.65480736),
        dec: Angle.Degrees(+26.31231144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85332"},
        {"Hipparcos Number", "HIP 48378"},
        {"Smithsonian Astrophysical Observation", "SAO 81052"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.93088638),
        dec: Angle.Degrees(+26.31320784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11003 A"},
        {"Henry Draper", "HD 164922"},
        {"Hipparcos Number", "HIP 88348"},
        {"Cincinnati Publication", "Ci 20 1072"},
        {"Geneva Identification System", "GEN# +1.00164922"},
        {"Smithsonian Astrophysical Observation", "SAO 85678"},
        {"Wilson Evans Batten Catalogue", "WEB 14933"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.62753648),
        dec: Angle.Degrees(+26.31446576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 389.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -602.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15300"},
        {"Geneva Identification System", "GEN# +5.20253202J"},
        {"Geneva Identification System 2", "GEN# +6.20030417"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.34476049),
        dec: Angle.Degrees(+26.31514825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218601"},
        {"Hipparcos Number", "HIP 114312"},
        {"Geneva Identification System", "GEN# +1.00218601"},
        {"Smithsonian Astrophysical Observation", "SAO 91042"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.25915952),
        dec: Angle.Degrees(+26.31568203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245770"},
        {"Hipparcos Number", "HIP 26566"},
        {"Smithsonian Astrophysical Observation", "SAO 77348"},
        {"Wilson Evans Batten Catalogue", "WEB 5236"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.72739698),
        dec: Angle.Degrees(+26.31579457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185914"},
        {"Hipparcos Number", "HIP 96788"},
        {"Smithsonian Astrophysical Observation", "SAO 87545"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.10665096),
        dec: Angle.Degrees(+26.31592876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64946"},
        {"Geneva Identification System", "GEN# +0.02702235"},
        {"Smithsonian Astrophysical Observation", "SAO 82773"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.69408908),
        dec: Angle.Degrees(+26.31730657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65649"},
        {"Smithsonian Astrophysical Observation", "SAO 82852"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.89157738),
        dec: Angle.Degrees(+26.31807550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82634"},
        {"Smithsonian Astrophysical Observation", "SAO 84671"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.38168012),
        dec: Angle.Degrees(+26.32008506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12897"},
        {"Hipparcos Number", "HIP 9864"},
        {"Geneva Identification System", "GEN# +1.00012897"},
        {"Smithsonian Astrophysical Observation", "SAO 75150"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.73293309),
        dec: Angle.Degrees(+26.32333888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3590"},
        {"Hipparcos Number", "HIP 3070"},
        {"Smithsonian Astrophysical Observation", "SAO 74168"},
        {"Wilson Evans Batten Catalogue", "WEB 548"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.73961842),
        dec: Angle.Degrees(+26.32380637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46916"},
        {"Smithsonian Astrophysical Observation", "SAO 80903"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.43863141),
        dec: Angle.Degrees(+26.32554230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7899 A"},
        {"Henry Draper", "HD 92769"},
        {"Hipparcos Number", "HIP 52422"},
        {"Geneva Identification System", "GEN# +1.00092769"},
        {"Renson", "Renson 26790"},
        {"Smithsonian Astrophysical Observation", "SAO 81485"},
        {"Wilson Evans Batten Catalogue", "WEB 9544"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.75811147),
        dec: Angle.Degrees(+26.32569732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67623",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67623"},
        {"Geneva Identification System", "GEN# +6.20030701"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.84356291),
        dec: Angle.Degrees(+26.32622110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32963"},
        {"Hipparcos Number", "HIP 23884"},
        {"Geneva Identification System", "GEN# +1.00032963"},
        {"Smithsonian Astrophysical Observation", "SAO 76970"},
        {"Wilson Evans Batten Catalogue", "WEB 4657"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.98253929),
        dec: Angle.Degrees(+26.32812489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251549"},
        {"Hipparcos Number", "HIP 28945"},
        {"Smithsonian Astrophysical Observation", "SAO 77963"},
        {"Wilson Evans Batten Catalogue", "WEB 5666"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.64560992),
        dec: Angle.Degrees(+26.32922303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283585"},
        {"Hipparcos Number", "HIP 20427"},
    },
    visualMagnitude: 10.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.64479789),
        dec: Angle.Degrees(+26.33128334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19445"},
        {"Hipparcos Number", "HIP 14594"},
        {"Celescope Catalog", "CEL 302"},
        {"Cincinnati Publication", "Ci 18 407"},
        {"Cincinnati Publication 2", "Ci 20 209"},
        {"Geneva Identification System", "GEN# +1.00019445"},
        {"Smithsonian Astrophysical Observation", "SAO 75749"},
        {"Wilson Evans Batten Catalogue", "WEB 2836"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.10718746),
        dec: Angle.Degrees(+26.33296054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -830.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56418"},
        {"Hipparcos Number", "HIP 35333"},
        {"Smithsonian Astrophysical Observation", "SAO 79253"},
        {"Wilson Evans Batten Catalogue", "WEB 7050"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.47723355),
        dec: Angle.Degrees(+26.33315529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201860"},
        {"Hipparcos Number", "HIP 104617"},
        {"Geneva Identification System", "GEN# +1.00201860"},
        {"Smithsonian Astrophysical Observation", "SAO 89516"},
        {"Wilson Evans Batten Catalogue", "WEB 19036"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.88838299),
        dec: Angle.Degrees(+26.33364925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69684"},
        {"Hipparcos Number", "HIP 40739"},
        {"Geneva Identification System", "GEN# +1.00069684"},
        {"Smithsonian Astrophysical Observation", "SAO 80086"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.72807765),
        dec: Angle.Degrees(+26.33543035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223019"},
        {"Hipparcos Number", "HIP 117194"},
        {"Smithsonian Astrophysical Observation", "SAO 91470"},
        {"Wilson Evans Batten Catalogue", "WEB 20651"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.44262045),
        dec: Angle.Degrees(+26.33556495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 901"},
        {"Smithsonian Astrophysical Observation", "SAO 73793"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.77875300),
        dec: Angle.Degrees(+26.33796403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193948"},
        {"Hipparcos Number", "HIP 100441"},
        {"Renson", "Renson 54130"},
        {"Smithsonian Astrophysical Observation", "SAO 88585"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.53767393),
        dec: Angle.Degrees(+26.33827419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5462"},
        {"Hipparcos Number", "HIP 4433"},
        {"Smithsonian Astrophysical Observation", "SAO 74382"},
        {"Wilson Evans Batten Catalogue", "WEB 795"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18528917),
        dec: Angle.Degrees(+26.33999429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27110",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4324 AB"},
        {"Henry Draper", "HD 38161"},
        {"Hipparcos Number", "HIP 27110"},
        {"Smithsonian Astrophysical Observation", "SAO 77494"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.23149705),
        dec: Angle.Degrees(+26.34242003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111065"},
        {"Hipparcos Number", "HIP 62340"},
        {"Geneva Identification System", "GEN# +1.00111065"},
        {"Smithsonian Astrophysical Observation", "SAO 82487"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61993785),
        dec: Angle.Degrees(+26.34470560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49186"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.58459568),
        dec: Angle.Degrees(+26.34631375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341159"},
        {"Hipparcos Number", "HIP 102881"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66352585),
        dec: Angle.Degrees(+26.34652874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9171"},
        {"Hipparcos Number", "HIP 7035"},
        {"Geneva Identification System", "GEN# +1.00009171"},
        {"Smithsonian Astrophysical Observation", "SAO 74764"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.66723811),
        dec: Angle.Degrees(+26.34931824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202618"},
        {"Hipparcos Number", "HIP 105016"},
        {"Geneva Identification System", "GEN# +1.00202618"},
        {"Smithsonian Astrophysical Observation", "SAO 89573"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.07082290),
        dec: Angle.Degrees(+26.35028042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81505"},
        {"Hipparcos Number", "HIP 46325"},
        {"Geneva Identification System", "GEN# +1.00081505"},
        {"Smithsonian Astrophysical Observation", "SAO 80835"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.67985043),
        dec: Angle.Degrees(+26.35105285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182569"},
        {"Hipparcos Number", "HIP 95399"},
        {"Smithsonian Astrophysical Observation", "SAO 87163"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.09368972),
        dec: Angle.Degrees(+26.35136561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75317"},
        {"Hipparcos Number", "HIP 43378"},
        {"Smithsonian Astrophysical Observation", "SAO 80450"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.54116438),
        dec: Angle.Degrees(+26.35440040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337707"},
        {"Hipparcos Number", "HIP 94105"},
        {"Smithsonian Astrophysical Observation", "SAO 86874"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.34716324),
        dec: Angle.Degrees(+26.35468015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63688"},
        {"Hipparcos Number", "HIP 38342"},
        {"Smithsonian Astrophysical Observation", "SAO 79746"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80621193),
        dec: Angle.Degrees(+26.35761362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26946"},
        {"Hipparcos Number", "HIP 19947"},
        {"Smithsonian Astrophysical Observation", "SAO 76530"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.17330337),
        dec: Angle.Degrees(+26.35797871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185289"},
        {"Hipparcos Number", "HIP 96523"},
        {"Geneva Identification System", "GEN# +1.00185289"},
        {"Smithsonian Astrophysical Observation", "SAO 87471"},
        {"Wilson Evans Batten Catalogue", "WEB 16941"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.34071552),
        dec: Angle.Degrees(+26.35908214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8635 AB"},
        {"Henry Draper", "HD 110465"},
        {"Hipparcos Number", "HIP 61986"},
        {"Geneva Identification System", "GEN# +1.00110465J"},
        {"Smithsonian Astrophysical Observation", "SAO 82443"},
        {"Wilson Evans Batten Catalogue", "WEB 11025"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.54476199),
        dec: Angle.Degrees(+26.36081169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76318"},
        {"Hipparcos Number", "HIP 43865"},
        {"Geneva Identification System", "GEN# +1.00076318"},
        {"Smithsonian Astrophysical Observation", "SAO 80517"},
        {"Wilson Evans Batten Catalogue", "WEB 8436"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.04330329),
        dec: Angle.Degrees(+26.36097531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105035"},
        {"Hipparcos Number", "HIP 58978"},
        {"Smithsonian Astrophysical Observation", "SAO 82128"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38935692),
        dec: Angle.Degrees(+26.36131415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341037"},
        {"Hipparcos Number", "HIP 102534"},
        {"Renson", "Renson 55130"},
        {"Smithsonian Astrophysical Observation", "SAO 89115"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.67382430),
        dec: Angle.Degrees(+26.36203835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56224"},
        {"Hipparcos Number", "HIP 35273"},
        {"Geneva Identification System", "GEN# +1.00056224"},
        {"Smithsonian Astrophysical Observation", "SAO 79243"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.31510673),
        dec: Angle.Degrees(+26.36371563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218815"},
        {"Hipparcos Number", "HIP 114457"},
        {"Geneva Identification System", "GEN# +1.00218815"},
        {"Smithsonian Astrophysical Observation", "SAO 91062"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.70890999),
        dec: Angle.Degrees(+26.36379338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284007"},
        {"Hipparcos Number", "HIP 23018"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.25333146),
        dec: Angle.Degrees(+26.36527891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115708"},
        {"Hipparcos Number", "HIP 64936"},
        {"Geneva Identification System", "GEN# +1.00115708"},
        {"Renson", "Renson 33450"},
        {"Smithsonian Astrophysical Observation", "SAO 82769"},
        {"Wilson Evans Batten Catalogue", "WEB 11478"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.65520196),
        dec: Angle.Degrees(+26.36575790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69776"},
        {"Smithsonian Astrophysical Observation", "SAO 83268"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.21955774),
        dec: Angle.Degrees(+26.36592048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283036"},
        {"Hipparcos Number", "HIP 18149"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.20104750),
        dec: Angle.Degrees(+26.36626957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15121 A"},
        {"Henry Draper", "HD 205626"},
        {"Hipparcos Number", "HIP 106635"},
        {"Geneva Identification System", "GEN# +1.00205626A"},
        {"Smithsonian Astrophysical Observation", "SAO 89830"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.98515492),
        dec: Angle.Degrees(+26.36959839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15121 B"},
        {"Henry Draper", "HD 205627"},
        {"Hipparcos Number", "HIP 106637"},
        {"Geneva Identification System", "GEN# +1.00205627"},
        {"Smithsonian Astrophysical Observation", "SAO 89831"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.98882511),
        dec: Angle.Degrees(+26.36990516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189179"},
        {"Hipparcos Number", "HIP 98236"},
        {"Smithsonian Astrophysical Observation", "SAO 87983"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.44744952),
        dec: Angle.Degrees(+26.37308327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337975"},
        {"Hipparcos Number", "HIP 94628"},
        {"Smithsonian Astrophysical Observation", "SAO 86989"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.84312500),
        dec: Angle.Degrees(+26.37344494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209298"},
        {"Hipparcos Number", "HIP 108746"},
        {"Geneva Identification System", "GEN# +1.00209298"},
        {"Smithsonian Astrophysical Observation", "SAO 90179"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.43079721),
        dec: Angle.Degrees(+26.37787113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336803"},
        {"Hipparcos Number", "HIP 91900"},
        {"Smithsonian Astrophysical Observation", "SAO 86380"},
    },
    visualMagnitude: 9.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.03003403),
        dec: Angle.Degrees(+26.38016287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23141"},
        {"Hipparcos Number", "HIP 17407"},
        {"Geneva Identification System", "GEN# +1.00023141"},
        {"Smithsonian Astrophysical Observation", "SAO 76105"},
        {"Wilson Evans Batten Catalogue", "WEB 3292"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.94178078),
        dec: Angle.Degrees(+26.38115414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339916"},
        {"Hipparcos Number", "HIP 99964"},
        {"Smithsonian Astrophysical Observation", "SAO 88453"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.22746041),
        dec: Angle.Degrees(+26.38427477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94991"},
        {"Hipparcos Number", "HIP 53627"},
        {"Smithsonian Astrophysical Observation", "SAO 81602"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.56912870),
        dec: Angle.Degrees(+26.38665125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211555"},
        {"Hipparcos Number", "HIP 110049"},
        {"Smithsonian Astrophysical Observation", "SAO 90395"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.35385845),
        dec: Angle.Degrees(+26.38681333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114636"},
        {"Hipparcos Number", "HIP 64353"},
        {"Geneva Identification System", "GEN# +1.00114636"},
        {"Smithsonian Astrophysical Observation", "SAO 82697"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.86770600),
        dec: Angle.Degrees(+26.38695693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113317"},
        {"Fundamental Katalog 5th Edition", "FK5 6031"},
        {"Smithsonian Astrophysical Observation", "SAO 90888"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.23423838),
        dec: Angle.Degrees(+26.38790587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86007"},
        {"Smithsonian Astrophysical Observation", "SAO 85221"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.66807610),
        dec: Angle.Degrees(+26.38826795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117589"},
        {"Hipparcos Number", "HIP 65933"},
        {"Geneva Identification System", "GEN# +1.00117589"},
        {"Smithsonian Astrophysical Observation", "SAO 82869"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.75368165),
        dec: Angle.Degrees(+26.39020659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77173"},
        {"Hipparcos Number", "HIP 44333"},
        {"Geneva Identification System", "GEN# +1.00077173"},
        {"Smithsonian Astrophysical Observation", "SAO 80583"},
        {"Wilson Evans Batten Catalogue", "WEB 8499"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.42570818),
        dec: Angle.Degrees(+26.39049882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112871",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16314 AB"},
        {"Henry Draper", "HD 216285"},
        {"Hipparcos Number", "HIP 112871"},
        {"Geneva Identification System", "GEN# +1.00216285"},
        {"Smithsonian Astrophysical Observation", "SAO 90833"},
        {"Wilson Evans Batten Catalogue", "WEB 20101"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.86108097),
        dec: Angle.Degrees(+26.39100769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338529"},
        {"Hipparcos Number", "HIP 96115"},
        {"Geneva Identification System", "GEN# +1.00338529"},
        {"Smithsonian Astrophysical Observation", "SAO 87333"},
        {"Wilson Evans Batten Catalogue", "WEB 16836"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.13295608),
        dec: Angle.Degrees(+26.39101224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19970"},
        {"Hipparcos Number", "HIP 15000"},
        {"Smithsonian Astrophysical Observation", "SAO 75800"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.34158833),
        dec: Angle.Degrees(+26.39160673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99443"},
        {"Hipparcos Number", "HIP 55844"},
        {"Geneva Identification System", "GEN# +1.00099443"},
        {"Smithsonian Astrophysical Observation", "SAO 81828"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.67727735),
        dec: Angle.Degrees(+26.39490034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1996"},
        {"Hipparcos Number", "HIP 1934"},
        {"Geneva Identification System", "GEN# +1.00001996"},
        {"Smithsonian Astrophysical Observation", "SAO 73958"},
        {"Wilson Evans Batten Catalogue", "WEB 360"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.09369856),
        dec: Angle.Degrees(+26.39556049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337457"},
        {"Hipparcos Number", "HIP 93407"},
        {"Smithsonian Astrophysical Observation", "SAO 86710"},
        {"Wilson Evans Batten Catalogue", "WEB 16205"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.35274023),
        dec: Angle.Degrees(+26.39556326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73162"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.28386192),
        dec: Angle.Degrees(+26.39649881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145627"},
        {"Hipparcos Number", "HIP 79291"},
        {"Geneva Identification System", "GEN# +1.00145627"},
        {"Smithsonian Astrophysical Observation", "SAO 84232"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.73826523),
        dec: Angle.Degrees(+26.39851725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10766"},
        {"Hipparcos Number", "HIP 8216"},
        {"Geneva Identification System", "GEN# +1.00010766"},
        {"Smithsonian Astrophysical Observation", "SAO 74913"},
        {"Wilson Evans Batten Catalogue", "WEB 1748"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.45778871),
        dec: Angle.Degrees(+26.39968173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49930"},
        {"Hipparcos Number", "HIP 32959"},
        {"Smithsonian Astrophysical Observation", "SAO 78810"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.97241018),
        dec: Angle.Degrees(+26.40035937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338534"},
        {"Hipparcos Number", "HIP 96271"},
        {"Smithsonian Astrophysical Observation", "SAO 87375"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.63047176),
        dec: Angle.Degrees(+26.40086612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5345"},
        {"Hipparcos Number", "HIP 4334"},
        {"Smithsonian Astrophysical Observation", "SAO 74368"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.88392831),
        dec: Angle.Degrees(+26.40322363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208457"},
        {"Hipparcos Number", "HIP 108252"},
        {"Geneva Identification System", "GEN# +1.00208457"},
        {"Smithsonian Astrophysical Observation", "SAO 90105"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.96645390),
        dec: Angle.Degrees(+26.40337513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143808"},
        {"Hipparcos Number", "HIP 78497"},
        {"Smithsonian Astrophysical Observation", "SAO 84151"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.36921915),
        dec: Angle.Degrees(+26.40458136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199598"},
        {"Hipparcos Number", "HIP 103455"},
        {"Geneva Identification System", "GEN# +1.00199598"},
        {"Smithsonian Astrophysical Observation", "SAO 89320"},
        {"Wilson Evans Batten Catalogue", "WEB 18818"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41458150),
        dec: Angle.Degrees(+26.40484620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 273.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337839"},
        {"Hipparcos Number", "HIP 94448"},
        {"Smithsonian Astrophysical Observation", "SAO 86947"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.33153677),
        dec: Angle.Degrees(+26.40524220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63667"},
        {"Geneva Identification System", "GEN# +0.02702208"},
        {"Smithsonian Astrophysical Observation", "SAO 82621"},
    },
    visualMagnitude: 11.89,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73244373),
        dec: Angle.Degrees(+26.40576918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54825"},
        {"Hipparcos Number", "HIP 34735"},
        {"Smithsonian Astrophysical Observation", "SAO 79142"},
        {"Wilson Evans Batten Catalogue", "WEB 6943"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.87499739),
        dec: Angle.Degrees(+26.40594388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128424"},
        {"Hipparcos Number", "HIP 71402"},
        {"Smithsonian Astrophysical Observation", "SAO 83428"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.01820548),
        dec: Angle.Degrees(+26.40914854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76192"},
        {"Hipparcos Number", "HIP 43817"},
        {"Smithsonian Astrophysical Observation", "SAO 80508"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.86425501),
        dec: Angle.Degrees(+26.40988005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19560"},
    },
    visualMagnitude: 11.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.84637061),
        dec: Angle.Degrees(+26.41099291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204539"},
        {"Hipparcos Number", "HIP 106033"},
        {"Geneva Identification System", "GEN# +1.00204539"},
        {"Smithsonian Astrophysical Observation", "SAO 89734"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.17118863),
        dec: Angle.Degrees(+26.41168353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71004"},
        {"Smithsonian Astrophysical Observation", "SAO 83388"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.82657752),
        dec: Angle.Degrees(+26.41186569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339671"},
        {"Hipparcos Number", "HIP 99523"},
        {"Geneva Identification System", "GEN# +2.68820009"},
        {"Smithsonian Astrophysical Observation", "SAO 88332"},
        {"New General Catalogue", "NGC 6882 9"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.96911945),
        dec: Angle.Degrees(+26.41364523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165989"},
        {"Hipparcos Number", "HIP 88793"},
        {"Smithsonian Astrophysical Observation", "SAO 85748"},
        {"Wilson Evans Batten Catalogue", "WEB 15042"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.87537569),
        dec: Angle.Degrees(+26.41483856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336348"},
        {"Hipparcos Number", "HIP 90916"},
        {"Smithsonian Astrophysical Observation", "SAO 86179"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.19384410),
        dec: Angle.Degrees(+26.41738215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87039"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.76683990),
        dec: Angle.Degrees(+26.41947653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110627"},
        {"Hipparcos Number", "HIP 62074"},
        {"Geneva Identification System", "GEN# +1.00110627"},
        {"Smithsonian Astrophysical Observation", "SAO 82457"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.82872439),
        dec: Angle.Degrees(+26.41976563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121827"},
        {"Hipparcos Number", "HIP 68169"},
        {"Geneva Identification System", "GEN# +1.00121827"},
        {"Smithsonian Astrophysical Observation", "SAO 83092"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.33682211),
        dec: Angle.Degrees(+26.42119783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214434"},
        {"Hipparcos Number", "HIP 111713"},
        {"Geneva Identification System", "GEN# +1.00214434J"},
        {"Smithsonian Astrophysical Observation", "SAO 90659"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44330816),
        dec: Angle.Degrees(+26.42182077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39478"},
        {"Hipparcos Number", "HIP 27881"},
        {"Geneva Identification System", "GEN# +1.00039478"},
        {"Smithsonian Astrophysical Observation", "SAO 77697"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.49936525),
        dec: Angle.Degrees(+26.42253383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69477"},
        {"Hipparcos Number", "HIP 40667"},
        {"Smithsonian Astrophysical Observation", "SAO 80076"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.52759735),
        dec: Angle.Degrees(+26.42464614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174549"},
        {"Hipparcos Number", "HIP 92410"},
        {"Smithsonian Astrophysical Observation", "SAO 86481"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.48239406),
        dec: Angle.Degrees(+26.42510135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246766"},
        {"Hipparcos Number", "HIP 27017"},
        {"Geneva Identification System", "GEN# +1.00246766"},
        {"Smithsonian Astrophysical Observation", "SAO 77468"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.95723549),
        dec: Angle.Degrees(+26.42634593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57989"},
        {"Smithsonian Astrophysical Observation", "SAO 82036"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.41338618),
        dec: Angle.Degrees(+26.42773603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32656"},
        {"Hipparcos Number", "HIP 23712"},
        {"Geneva Identification System", "GEN# +1.00032656"},
        {"Renson", "Renson 8360"},
        {"Smithsonian Astrophysical Observation", "SAO 76955"},
        {"Wilson Evans Batten Catalogue", "WEB 4626"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.47255738),
        dec: Angle.Degrees(+26.42995756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111541"},
        {"Hipparcos Number", "HIP 62614"},
        {"Geneva Identification System", "GEN# +1.00111541"},
        {"Smithsonian Astrophysical Observation", "SAO 82519"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.45254321),
        dec: Angle.Degrees(+26.43135394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40813"},
        {"Hipparcos Number", "HIP 28617"},
        {"Smithsonian Astrophysical Observation", "SAO 77872"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.61437940),
        dec: Angle.Degrees(+26.43136420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9964 A"},
        {"Henry Draper", "HD 145890"},
        {"Hipparcos Number", "HIP 79413"},
        {"Smithsonian Astrophysical Observation", "SAO 84244"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.10479465),
        dec: Angle.Degrees(+26.43142293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108578"},
        {"Geneva Identification System", "GEN# +0.02504655"},
        {"Renson", "Renson 58120"},
        {"Smithsonian Astrophysical Observation", "SAO 90153"},
    },
    visualMagnitude: 9.72,
    bvColour: -0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.92499774),
        dec: Angle.Degrees(+26.43271421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149086"},
        {"Hipparcos Number", "HIP 80930"},
        {"Cincinnati Publication", "Ci 18 2203"},
        {"Smithsonian Astrophysical Observation", "SAO 84427"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.88558811),
        dec: Angle.Degrees(+26.43400742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7123 AB"},
        {"Henry Draper", "HD 76924"},
        {"Hipparcos Number", "HIP 44180"},
        {"Renson", "Renson 21700"},
        {"Smithsonian Astrophysical Observation", "SAO 80562"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.99150012),
        dec: Angle.Degrees(+26.43446538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133922"},
        {"Hipparcos Number", "HIP 73917"},
        {"Smithsonian Astrophysical Observation", "SAO 83662"},
        {"Wilson Evans Batten Catalogue", "WEB 12626"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.58759676),
        dec: Angle.Degrees(+26.43719303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86521"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.21564645),
        dec: Angle.Degrees(+26.43752800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 194.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159223"},
        {"Hipparcos Number", "HIP 85840"},
        {"Geneva Identification System", "GEN# +1.00159223"},
        {"Smithsonian Astrophysical Observation", "SAO 85188"},
        {"Wilson Evans Batten Catalogue", "WEB 14489"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.10481525),
        dec: Angle.Degrees(+26.43937405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12061"},
        {"Smithsonian Astrophysical Observation", "SAO 75457"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.88397955),
        dec: Angle.Degrees(+26.43947462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86587"},
        {"Smithsonian Astrophysical Observation", "SAO 85327"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.43389793),
        dec: Angle.Degrees(+26.43963419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80370",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80370"},
        {"Smithsonian Astrophysical Observation", "SAO 84356"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.08748111),
        dec: Angle.Degrees(+26.44407695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3150"},
        {"Hipparcos Number", "HIP 2732"},
        {"Smithsonian Astrophysical Observation", "SAO 74115"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.72706436),
        dec: Angle.Degrees(+26.44445715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39340"},
        {"Hipparcos Number", "HIP 27808"},
        {"Geneva Identification System", "GEN# +1.00039340"},
        {"Smithsonian Astrophysical Observation", "SAO 77668"},
        {"Wilson Evans Batten Catalogue", "WEB 5449"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.27539020),
        dec: Angle.Degrees(+26.44541235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7625"},
        {"Hipparcos Number", "HIP 5963"},
        {"Smithsonian Astrophysical Observation", "SAO 74598"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17573837),
        dec: Angle.Degrees(+26.44844936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80420"},
        {"Smithsonian Astrophysical Observation", "SAO 84362"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.22286571),
        dec: Angle.Degrees(+26.44900189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11356 A"},
        {"Henry Draper", "HD 170111"},
        {"Hipparcos Number", "HIP 90398"},
        {"Geneva Identification System", "GEN# +1.00170111J"},
        {"Smithsonian Astrophysical Observation", "SAO 86060"},
        {"Wilson Evans Batten Catalogue", "WEB 15478"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.67053001),
        dec: Angle.Degrees(+26.44923123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97777"},
        {"Hipparcos Number", "HIP 54965"},
        {"Smithsonian Astrophysical Observation", "SAO 81739"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.83580753),
        dec: Angle.Degrees(+26.45007413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249"},
        {"Hipparcos Number", "HIP 607"},
        {"Geneva Identification System", "GEN# +1.00000249"},
        {"Smithsonian Astrophysical Observation", "SAO 73755"},
        {"Wilson Evans Batten Catalogue", "WEB 105"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.84365756),
        dec: Angle.Degrees(+26.45088655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7802"},
        {"Hipparcos Number", "HIP 6085"},
        {"Smithsonian Astrophysical Observation", "SAO 74617"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.53696875),
        dec: Angle.Degrees(+26.45101146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7300"},
        {"Hipparcos Number", "HIP 5722"},
        {"Smithsonian Astrophysical Observation", "SAO 74567"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.39082919),
        dec: Angle.Degrees(+26.45226969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99594"},
        {"Hipparcos Number", "HIP 55916"},
        {"Geneva Identification System", "GEN# +1.00099594"},
        {"Smithsonian Astrophysical Observation", "SAO 81839"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91283169),
        dec: Angle.Degrees(+26.45262134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1501"},
        {"Hipparcos Number", "HIP 1553"},
        {"Geneva Identification System", "GEN# +1.00001501"},
        {"Smithsonian Astrophysical Observation", "SAO 73889"},
        {"Wilson Evans Batten Catalogue", "WEB 283"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84173094),
        dec: Angle.Degrees(+26.45409110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33585"},
        {"Hipparcos Number", "HIP 24252"},
        {"Geneva Identification System", "GEN# +1.00033585"},
        {"Smithsonian Astrophysical Observation", "SAO 77028"},
        {"Wilson Evans Batten Catalogue", "WEB 4708"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.08981788),
        dec: Angle.Degrees(+26.45497128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155344"},
        {"Hipparcos Number", "HIP 83975"},
        {"Smithsonian Astrophysical Observation", "SAO 84885"},
        {"Wilson Evans Batten Catalogue", "WEB 14186"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.48697315),
        dec: Angle.Degrees(+26.45534800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178276"},
        {"Hipparcos Number", "HIP 93868"},
        {"Smithsonian Astrophysical Observation", "SAO 86826"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.74641290),
        dec: Angle.Degrees(+26.45624543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252940"},
        {"Hipparcos Number", "HIP 29390"},
        {"Geneva Identification System", "GEN# +1.00252940"},
        {"Smithsonian Astrophysical Observation", "SAO 78082"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.90506161),
        dec: Angle.Degrees(+26.45850268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154617"},
        {"Hipparcos Number", "HIP 83639"},
        {"Geneva Identification System", "GEN# +1.00154617"},
        {"Smithsonian Astrophysical Observation", "SAO 84825"},
        {"Wilson Evans Batten Catalogue", "WEB 14145"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.39919428),
        dec: Angle.Degrees(+26.46083602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170051"},
        {"Hipparcos Number", "HIP 90377"},
        {"Geneva Identification System", "GEN# +1.00170051"},
        {"Smithsonian Astrophysical Observation", "SAO 86055"},
        {"Wilson Evans Batten Catalogue", "WEB 15472"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.62175394),
        dec: Angle.Degrees(+26.46102331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176802"},
        {"Hipparcos Number", "HIP 93357"},
        {"Smithsonian Astrophysical Observation", "SAO 86698"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.23671675),
        dec: Angle.Degrees(+26.46107618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55077"},
        {"Geneva Identification System", "GEN# +6.20030606"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.13762106),
        dec: Angle.Degrees(+26.46151296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196504"},
        {"Hipparcos Number", "HIP 101716"},
        {"Fundamental Katalog 5th Edition", "FK5 3649"},
        {"Geneva Identification System", "GEN# +1.00196504"},
        {"Smithsonian Astrophysical Observation", "SAO 88903"},
        {"Wilson Evans Batten Catalogue", "WEB 18373"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.26942755),
        dec: Angle.Degrees(+26.46197499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36601",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36601"},
        {"Smithsonian Astrophysical Observation", "SAO 79467"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.91172585),
        dec: Angle.Degrees(+26.46203411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18769"},
        {"Hipparcos Number", "HIP 14109"},
        {"Fundamental Katalog 5th Edition", "FK5 2214"},
        {"Geneva Identification System", "GEN# +1.00018769"},
        {"Renson", "Renson 4690"},
        {"Smithsonian Astrophysical Observation", "SAO 75693"},
        {"Wilson Evans Batten Catalogue", "WEB 2775"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.47562665),
        dec: Angle.Degrees(+26.46234187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85111"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.91736199),
        dec: Angle.Degrees(+26.46377621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131453"},
        {"Hipparcos Number", "HIP 72805"},
        {"Smithsonian Astrophysical Observation", "SAO 83566"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.22095275),
        dec: Angle.Degrees(+26.46502736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87339"},
        {"Smithsonian Astrophysical Observation", "SAO 85469"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.69001536),
        dec: Angle.Degrees(+26.46506040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70707"},
        {"Hipparcos Number", "HIP 41194"},
        {"Smithsonian Astrophysical Observation", "SAO 80155"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.09113973),
        dec: Angle.Degrees(+26.46575888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113946"},
        {"Smithsonian Astrophysical Observation", "SAO 90989"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.13565463),
        dec: Angle.Degrees(+26.46605191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105073"},
        {"Hipparcos Number", "HIP 59004"},
        {"Smithsonian Astrophysical Observation", "SAO 82132"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.47630164),
        dec: Angle.Degrees(+26.46731921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79678"},
        {"Hipparcos Number", "HIP 45490"},
        {"Geneva Identification System", "GEN# +1.00079678"},
        {"Smithsonian Astrophysical Observation", "SAO 80728"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.03748614),
        dec: Angle.Degrees(+26.46775431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283477"},
        {"Hipparcos Number", "HIP 19803"},
        {"Smithsonian Astrophysical Observation", "SAO 76519"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.69581832),
        dec: Angle.Degrees(+26.47090490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11079"},
        {"Hipparcos Number", "HIP 8490"},
        {"Smithsonian Astrophysical Observation", "SAO 74953"},
        {"Wilson Evans Batten Catalogue", "WEB 1803"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.36323139),
        dec: Angle.Degrees(+26.47267045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5928"},
        {"Hipparcos Number", "HIP 4761"},
        {"Smithsonian Astrophysical Observation", "SAO 74434"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.29479385),
        dec: Angle.Degrees(+26.47299584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81243"},
        {"Smithsonian Astrophysical Observation", "SAO 84469"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.89041678),
        dec: Angle.Degrees(+26.47435296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116072"},
        {"Smithsonian Astrophysical Observation", "SAO 91314"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.80111895),
        dec: Angle.Degrees(+26.47482001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341306"},
        {"Hipparcos Number", "HIP 103211"},
        {"Smithsonian Astrophysical Observation", "SAO 89273"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.65792210),
        dec: Angle.Degrees(+26.47492943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4884"},
        {"Hipparcos Number", "HIP 3977"},
        {"Smithsonian Astrophysical Observation", "SAO 74316"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.78857033),
        dec: Angle.Degrees(+26.47821031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11402"},
        {"Hipparcos Number", "HIP 8760"},
        {"Smithsonian Astrophysical Observation", "SAO 74994"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.17803702),
        dec: Angle.Degrees(+26.47848246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192044"},
        {"Hipparcos Number", "HIP 99531"},
        {"Geneva Identification System", "GEN# +2.68820003"},
        {"Smithsonian Astrophysical Observation", "SAO 88339"},
        {"Wilson Evans Batten Catalogue", "WEB 17804"},
        {"New General Catalogue", "NGC 6882 3"},
    },
    visualMagnitude: 5.91,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.00291076),
        dec: Angle.Degrees(+26.47883104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249141"},
        {"Hipparcos Number", "HIP 28032"},
        {"Smithsonian Astrophysical Observation", "SAO 77725"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.91375231),
        dec: Angle.Degrees(+26.47889314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9178"},
        {"Hipparcos Number", "HIP 7049"},
        {"Smithsonian Astrophysical Observation", "SAO 74765"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.71275148),
        dec: Angle.Degrees(+26.47971895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26322"},
        {"Hipparcos Number", "HIP 19513"},
        {"Fundamental Katalog 5th Edition", "FK5 1116"},
        {"Geneva Identification System", "GEN# +1.00026322"},
        {"Smithsonian Astrophysical Observation", "SAO 76485"},
        {"Wilson Evans Batten Catalogue", "WEB 3736"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.70783742),
        dec: Angle.Degrees(+26.48103948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219919"},
        {"Hipparcos Number", "HIP 115140"},
        {"Geneva Identification System", "GEN# +1.00219919"},
        {"Smithsonian Astrophysical Observation", "SAO 91169"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.84844563),
        dec: Angle.Degrees(+26.48123393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10171"},
        {"Hipparcos Number", "HIP 7771"},
        {"Smithsonian Astrophysical Observation", "SAO 74860"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.00414797),
        dec: Angle.Degrees(+26.48305430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195532"},
        {"Hipparcos Number", "HIP 101216"},
        {"Smithsonian Astrophysical Observation", "SAO 88789"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.75712001),
        dec: Angle.Degrees(+26.48327504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339479"},
        {"Hipparcos Number", "HIP 98881"},
        {"Geneva Identification System", "GEN# +1.00339479"},
        {"Smithsonian Astrophysical Observation", "SAO 88160"},
        {"Wilson Evans Batten Catalogue", "WEB 17552"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.20121146),
        dec: Angle.Degrees(+26.48345161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13225"},
        {"Hipparcos Number", "HIP 10098"},
        {"Smithsonian Astrophysical Observation", "SAO 75176"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.46204968),
        dec: Angle.Degrees(+26.48454322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340577"},
        {"Hipparcos Number", "HIP 101536"},
        {"Renson", "Renson 54670"},
        {"Smithsonian Astrophysical Observation", "SAO 88860"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.67013365),
        dec: Angle.Degrees(+26.48548376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142743"},
        {"Hipparcos Number", "HIP 77956"},
        {"Smithsonian Astrophysical Observation", "SAO 84076"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.80171175),
        dec: Angle.Degrees(+26.48612595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340470"},
        {"Hipparcos Number", "HIP 101215"},
        {"Smithsonian Astrophysical Observation", "SAO 88788"},
    },
    visualMagnitude: 9.64,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.75023872),
        dec: Angle.Degrees(+26.48694782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335505"},
        {"Hipparcos Number", "HIP 88083"},
        {"Smithsonian Astrophysical Observation", "SAO 85610"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.84467136),
        dec: Angle.Degrees(+26.48712543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87445"},
        {"Hipparcos Number", "HIP 49429"},
        {"Smithsonian Astrophysical Observation", "SAO 81174"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.36101100),
        dec: Angle.Degrees(+26.48801387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76657"},
        {"Hipparcos Number", "HIP 44061"},
        {"Geneva Identification System", "GEN# +1.00076657"},
        {"Smithsonian Astrophysical Observation", "SAO 80542"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.59512411),
        dec: Angle.Degrees(+26.48897615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13261"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.65510530),
        dec: Angle.Degrees(+26.48977041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192892"},
        {"Hipparcos Number", "HIP 99917"},
        {"Geneva Identification System", "GEN# +1.00192892"},
        {"Smithsonian Astrophysical Observation", "SAO 88438"},
        {"Wilson Evans Batten Catalogue", "WEB 17973"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.09329488),
        dec: Angle.Degrees(+26.49032686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111891"},
        {"Hipparcos Number", "HIP 62817"},
        {"Geneva Identification System", "GEN# +1.00111891"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.08178155),
        dec: Angle.Degrees(+26.49062746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43334"},
        {"Hipparcos Number", "HIP 29826"},
        {"Smithsonian Astrophysical Observation", "SAO 78172"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.21325761),
        dec: Angle.Degrees(+26.49340844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105475"},
        {"Hipparcos Number", "HIP 59210"},
        {"Geneva Identification System", "GEN# +5.21110003"},
        {"Smithsonian Astrophysical Observation", "SAO 82152"},
        {"Wilson Evans Batten Catalogue", "WEB 10534"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.15506614),
        dec: Angle.Degrees(+26.49364200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57206"},
        {"Hipparcos Number", "HIP 35639"},
        {"Smithsonian Astrophysical Observation", "SAO 79311"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.31493644),
        dec: Angle.Degrees(+26.49442663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2563"},
        {"Hipparcos Number", "HIP 2306"},
        {"Geneva Identification System", "GEN# +1.00002563"},
        {"Smithsonian Astrophysical Observation", "SAO 74037"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.35250860),
        dec: Angle.Degrees(+26.49536212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240622"},
        {"Hipparcos Number", "HIP 23772"},
        {"Smithsonian Astrophysical Observation", "SAO 76959"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.64068972),
        dec: Angle.Degrees(+26.49557115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25249"},
    },
    visualMagnitude: 11.35,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.98769850),
        dec: Angle.Degrees(+26.49610116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252400"},
        {"Hipparcos Number", "HIP 29209"},
        {"Smithsonian Astrophysical Observation", "SAO 78044"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.39992497),
        dec: Angle.Degrees(+26.49711351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47217"},
        {"Hipparcos Number", "HIP 31774"},
        {"Smithsonian Astrophysical Observation", "SAO 78578"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.66619635),
        dec: Angle.Degrees(+26.49992224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84794"},
        {"Geneva Identification System", "GEN# +9.80170035"},
        {"Wilson Evans Batten Catalogue", "WEB 14314"},
    },
    visualMagnitude: 11.26,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.97645029),
        dec: Angle.Degrees(+26.49999989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 348.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217492"},
        {"Hipparcos Number", "HIP 113630"},
        {"Smithsonian Astrophysical Observation", "SAO 90940"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.19946413),
        dec: Angle.Degrees(+26.50222692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131765"},
        {"Hipparcos Number", "HIP 72970"},
        {"Geneva Identification System", "GEN# +1.00131765"},
        {"Smithsonian Astrophysical Observation", "SAO 83574"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.68368620),
        dec: Angle.Degrees(+26.50313472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106398"},
        {"Hipparcos Number", "HIP 59680"},
        {"Geneva Identification System", "GEN# +5.21110027"},
        {"Smithsonian Astrophysical Observation", "SAO 82199"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.57541025),
        dec: Angle.Degrees(+26.50484728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135773"},
        {"Hipparcos Number", "HIP 74709"},
        {"Smithsonian Astrophysical Observation", "SAO 83736"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.01741187),
        dec: Angle.Degrees(+26.50532619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207531"},
        {"Hipparcos Number", "HIP 107703"},
        {"Smithsonian Astrophysical Observation", "SAO 90025"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.26327977),
        dec: Angle.Degrees(+26.50678006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335916"},
        {"Hipparcos Number", "HIP 89849"},
        {"Geneva Identification System", "GEN# +1.00335916"},
        {"Smithsonian Astrophysical Observation", "SAO 85936"},
        {"Wilson Evans Batten Catalogue", "WEB 15337"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.03109516),
        dec: Angle.Degrees(+26.50755804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200451"},
        {"Hipparcos Number", "HIP 103861"},
        {"Smithsonian Astrophysical Observation", "SAO 89400"},
        {"Wilson Evans Batten Catalogue", "WEB 18908"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.67182665),
        dec: Angle.Degrees(+26.50808694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137983"},
        {"Hipparcos Number", "HIP 75734"},
        {"Geneva Identification System", "GEN# +1.00137983"},
        {"Smithsonian Astrophysical Observation", "SAO 83838"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.08435925),
        dec: Angle.Degrees(+26.50938301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93861"},
        {"Hipparcos Number", "HIP 52994"},
        {"Smithsonian Astrophysical Observation", "SAO 81545"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.61138022),
        dec: Angle.Degrees(+26.51023245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140366"},
        {"Hipparcos Number", "HIP 76914"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.57653072),
        dec: Angle.Degrees(+26.51280919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216039"},
        {"Hipparcos Number", "HIP 112687"},
        {"Geneva Identification System", "GEN# +1.00216039"},
        {"Renson", "Renson 59690"},
        {"Smithsonian Astrophysical Observation", "SAO 90807"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.29928755),
        dec: Angle.Degrees(+26.51311413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1633"},
        {"Hipparcos Number", "HIP 1656"},
        {"Geneva Identification System", "GEN# +1.00001633"},
        {"Smithsonian Astrophysical Observation", "SAO 73904"},
        {"Wilson Evans Batten Catalogue", "WEB 304"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18959551),
        dec: Angle.Degrees(+26.51363527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120295"},
        {"Hipparcos Number", "HIP 67335"},
        {"Geneva Identification System", "GEN# +1.00120295"},
        {"Smithsonian Astrophysical Observation", "SAO 82997"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.01176872),
        dec: Angle.Degrees(+26.51538860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83690",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10346 AB"},
        {"Henry Draper", "HD 154760"},
        {"Hipparcos Number", "HIP 83690"},
        {"Geneva Identification System", "GEN# +1.00154760J"},
        {"Smithsonian Astrophysical Observation", "SAO 84840"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.57435212),
        dec: Angle.Degrees(+26.51789173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206828"},
        {"Hipparcos Number", "HIP 107313"},
        {"Cincinnati Publication", "Ci 18 2822"},
        {"Geneva Identification System", "GEN# +1.00206828"},
        {"Smithsonian Astrophysical Observation", "SAO 89938"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.03824516),
        dec: Angle.Degrees(+26.51916265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65249",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8876 AB"},
        {"Hipparcos Number", "HIP 65249"},
        {"Geneva Identification System", "GEN# +0.02702245J"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.57504788),
        dec: Angle.Degrees(+26.51939026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54370"},
        {"Hipparcos Number", "HIP 34576"},
        {"Smithsonian Astrophysical Observation", "SAO 79122"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.41564701),
        dec: Angle.Degrees(+26.52294260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16567 A"},
        {"Henry Draper", "HD 218806"},
        {"Hipparcos Number", "HIP 114448"},
        {"Smithsonian Astrophysical Observation", "SAO 91061"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.67664936),
        dec: Angle.Degrees(+26.52306736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81672"},
        {"Smithsonian Astrophysical Observation", "SAO 84537"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.26591911),
        dec: Angle.Degrees(+26.52330517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85037"},
        {"Smithsonian Astrophysical Observation", "SAO 85048"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.69906249),
        dec: Angle.Degrees(+26.52376247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114037"},
        {"Hipparcos Number", "HIP 64034"},
        {"Geneva Identification System", "GEN# +1.00114037"},
        {"Smithsonian Astrophysical Observation", "SAO 82661"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.85315635),
        dec: Angle.Degrees(+26.52390867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124732"},
        {"Hipparcos Number", "HIP 69607"},
        {"Smithsonian Astrophysical Observation", "SAO 83245"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.69193532),
        dec: Angle.Degrees(+26.52393684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41456"},
        {"Hipparcos Number", "HIP 28932"},
        {"Geneva Identification System", "GEN# +1.00041456"},
        {"Smithsonian Astrophysical Observation", "SAO 77960"},
        {"Wilson Evans Batten Catalogue", "WEB 5662"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.60024640),
        dec: Angle.Degrees(+26.52557805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90403"},
        {"Hipparcos Number", "HIP 51119"},
        {"Smithsonian Astrophysical Observation", "SAO 81342"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.66380009),
        dec: Angle.Degrees(+26.52562211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160424"},
        {"Hipparcos Number", "HIP 86351"},
        {"Smithsonian Astrophysical Observation", "SAO 85279"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.68078180),
        dec: Angle.Degrees(+26.52682067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129712"},
        {"Hipparcos Number", "HIP 71995"},
        {"Fundamental Katalog 5th Edition", "FK5 1383"},
        {"Geneva Identification System", "GEN# +1.00129712"},
        {"Smithsonian Astrophysical Observation", "SAO 83488"},
        {"Wilson Evans Batten Catalogue", "WEB 12392"},
    },
    visualMagnitude: 4.80,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.85571623),
        dec: Angle.Degrees(+26.52789077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40996"},
        {"Hipparcos Number", "HIP 28697"},
        {"Geneva Identification System", "GEN# +1.00040996"},
        {"Smithsonian Astrophysical Observation", "SAO 77900"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.89135950),
        dec: Angle.Degrees(+26.52914511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50456"},
        {"Hipparcos Number", "HIP 33194"},
        {"Smithsonian Astrophysical Observation", "SAO 78853"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.62149248),
        dec: Angle.Degrees(+26.53074032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149931"},
        {"Hipparcos Number", "HIP 81349"},
        {"Smithsonian Astrophysical Observation", "SAO 84485"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.20397331),
        dec: Angle.Degrees(+26.53235649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3602 AB"},
        {"Henry Draper", "HD 32018"},
        {"Hipparcos Number", "HIP 23349"},
        {"Smithsonian Astrophysical Observation", "SAO 76895"},
        {"Wilson Evans Batten Catalogue", "WEB 4533"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.32881024),
        dec: Angle.Degrees(+26.53430776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175036"},
        {"Hipparcos Number", "HIP 92631"},
        {"Geneva Identification System", "GEN# +1.00175036"},
        {"Smithsonian Astrophysical Observation", "SAO 86532"},
        {"Wilson Evans Batten Catalogue", "WEB 16026"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.11402450),
        dec: Angle.Degrees(+26.53454667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 156.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157428"},
        {"Hipparcos Number", "HIP 84985"},
        {"Smithsonian Astrophysical Observation", "SAO 85041"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.53936013),
        dec: Angle.Degrees(+26.53705343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12519"},
        {"Hipparcos Number", "HIP 9601"},
        {"Geneva Identification System", "GEN# +1.00012519"},
        {"Smithsonian Astrophysical Observation", "SAO 75111"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.87034636),
        dec: Angle.Degrees(+26.53724081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208775"},
        {"Hipparcos Number", "HIP 108444"},
        {"Smithsonian Astrophysical Observation", "SAO 90140"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.51446845),
        dec: Angle.Degrees(+26.53907240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47322"},
        {"Smithsonian Astrophysical Observation", "SAO 80942"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.63841542),
        dec: Angle.Degrees(+26.54430321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107583"},
        {"Hipparcos Number", "HIP 60293"},
        {"Geneva Identification System", "GEN# +5.21110085"},
        {"Smithsonian Astrophysical Observation", "SAO 82268"},
        {"Wilson Evans Batten Catalogue", "WEB 10722"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.45431132),
        dec: Angle.Degrees(+26.54911730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86681",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10731 A"},
        {"Henry Draper", "HD 161112"},
        {"Hipparcos Number", "HIP 86681"},
        {"Geneva Identification System", "GEN# +1.00161112J"},
        {"Smithsonian Astrophysical Observation", "SAO 85346"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.65982667),
        dec: Angle.Degrees(+26.55170769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221469"},
        {"Hipparcos Number", "HIP 116168"},
        {"Smithsonian Astrophysical Observation", "SAO 91329"},
        {"Wilson Evans Batten Catalogue", "WEB 20534"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.06776420),
        dec: Angle.Degrees(+26.55179295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251383"},
        {"Hipparcos Number", "HIP 28884"},
        {"Cincinnati Publication", "Ci 20 366"},
        {"Cincinnati Publication 2", "Ci 18 761"},
        {"Geneva Identification System", "GEN# +1.00251383"},
        {"Smithsonian Astrophysical Observation", "SAO 77946"},
        {"Wilson Evans Batten Catalogue", "WEB 5651"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.48013722),
        dec: Angle.Degrees(+26.55574982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -375.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339279"},
        {"Hipparcos Number", "HIP 98212"},
        {"Geneva Identification System", "GEN# +1.00339279"},
        {"Smithsonian Astrophysical Observation", "SAO 87980"},
        {"Wilson Evans Batten Catalogue", "WEB 17324"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.36919230),
        dec: Angle.Degrees(+26.55647940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201094"},
        {"Hipparcos Number", "HIP 104205"},
        {"Geneva Identification System", "GEN# +1.00201094"},
        {"Smithsonian Astrophysical Observation", "SAO 89464"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.67922229),
        dec: Angle.Degrees(+26.55760951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55767"},
        {"Geneva Identification System", "GEN# +0.02702018"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.41042949),
        dec: Angle.Degrees(+26.55812946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19296"},
        {"Wilson Evans Batten Catalogue", "WEB 3709"},
    },
    visualMagnitude: 10.96,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.04926664),
        dec: Angle.Degrees(+26.59826193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13604"},
        {"Smithsonian Astrophysical Observation", "SAO 75637"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.83035411),
        dec: Angle.Degrees(+26.55944839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48952"},
        {"Hipparcos Number", "HIP 32518"},
        {"Geneva Identification System", "GEN# +1.00048952"},
        {"Smithsonian Astrophysical Observation", "SAO 78738"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.79483332),
        dec: Angle.Degrees(+26.56125512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8300"},
        {"Hipparcos Number", "HIP 6434"},
        {"Smithsonian Astrophysical Observation", "SAO 74670"},
        {"Wilson Evans Batten Catalogue", "WEB 1421"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.65657636),
        dec: Angle.Degrees(+26.56266580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55080"},
        {"Hipparcos Number", "HIP 34830"},
        {"Smithsonian Astrophysical Observation", "SAO 79164"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.12996453),
        dec: Angle.Degrees(+26.56454837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64207"},
        {"Hipparcos Number", "HIP 38564"},
        {"Geneva Identification System", "GEN# +1.00064207"},
        {"Smithsonian Astrophysical Observation", "SAO 79777"},
        {"Wilson Evans Batten Catalogue", "WEB 7575"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.43819858),
        dec: Angle.Degrees(+26.56463925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50582"},
        {"Smithsonian Astrophysical Observation", "SAO 81295"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.98714416),
        dec: Angle.Degrees(+26.56732217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51294"},
        {"Hipparcos Number", "HIP 33506"},
        {"Smithsonian Astrophysical Observation", "SAO 78914"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.47177582),
        dec: Angle.Degrees(+26.56883492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1339"},
        {"Hipparcos Number", "HIP 1416"},
        {"Smithsonian Astrophysical Observation", "SAO 73877"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.43656260),
        dec: Angle.Degrees(+26.56949519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204559"},
        {"Hipparcos Number", "HIP 106040"},
        {"Geneva Identification System", "GEN# +1.00204559"},
        {"Smithsonian Astrophysical Observation", "SAO 89736"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.18086174),
        dec: Angle.Degrees(+26.56960514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339667"},
        {"Hipparcos Number", "HIP 99382"},
        {"Geneva Identification System", "GEN# +2.68820010"},
        {"Smithsonian Astrophysical Observation", "SAO 88288"},
        {"New General Catalogue", "NGC 6882 10"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.57164361),
        dec: Angle.Degrees(+26.56969243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23007"},
        {"Hipparcos Number", "HIP 17324"},
        {"Smithsonian Astrophysical Observation", "SAO 76089"},
        {"Wilson Evans Batten Catalogue", "WEB 3274"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.62381632),
        dec: Angle.Degrees(+26.57229581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125709"},
        {"Hipparcos Number", "HIP 70089"},
        {"Geneva Identification System", "GEN# +1.00125709J"},
        {"Smithsonian Astrophysical Observation", "SAO 83297"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13740021),
        dec: Angle.Degrees(+26.57285618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10435 C"},
        {"Hipparcos Number", "HIP 84512"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.15184084),
        dec: Angle.Degrees(+26.57491461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100405"},
        {"Hipparcos Number", "HIP 56373"},
        {"Geneva Identification System", "GEN# +1.00100405"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.33783428),
        dec: Angle.Degrees(+26.57494395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84513",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10435 AB"},
        {"Henry Draper", "HD 156454"},
        {"Hipparcos Number", "HIP 84513"},
        {"Geneva Identification System", "GEN# +1.00156454"},
        {"Smithsonian Astrophysical Observation", "SAO 84967"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.15216225),
        dec: Angle.Degrees(+26.57979497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243695"},
        {"Hipparcos Number", "HIP 25491"},
        {"Geneva Identification System", "GEN# +1.00243695"},
        {"Smithsonian Astrophysical Observation", "SAO 77180"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.78115586),
        dec: Angle.Degrees(+26.58407212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36174"},
        {"Hipparcos Number", "HIP 25845"},
        {"Smithsonian Astrophysical Observation", "SAO 77221"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.76236296),
        dec: Angle.Degrees(+26.58426437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113771"},
        {"Hipparcos Number", "HIP 63891"},
        {"Geneva Identification System", "GEN# +1.00113771"},
        {"Smithsonian Astrophysical Observation", "SAO 82642"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.42035689),
        dec: Angle.Degrees(+26.58569005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6286"},
        {"Hipparcos Number", "HIP 5007"},
        {"Geneva Identification System", "GEN# +1.00006286"},
        {"Smithsonian Astrophysical Observation", "SAO 74467"},
        {"Wilson Evans Batten Catalogue", "WEB 1015"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.02983656),
        dec: Angle.Degrees(+26.58706157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172499"},
        {"Hipparcos Number", "HIP 91492"},
        {"Geneva Identification System", "GEN# +1.00172499"},
        {"Smithsonian Astrophysical Observation", "SAO 86293"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.89237406),
        dec: Angle.Degrees(+26.58741893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87905"},
        {"Smithsonian Astrophysical Observation", "SAO 85579"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.34421111),
        dec: Angle.Degrees(+26.58881594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23731"},
        {"Hipparcos Number", "HIP 17774"},
        {"Smithsonian Astrophysical Observation", "SAO 76213"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.07898533),
        dec: Angle.Degrees(+26.58917912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126956"},
        {"Hipparcos Number", "HIP 70742"},
        {"Geneva Identification System", "GEN# +1.00126956"},
        {"Smithsonian Astrophysical Observation", "SAO 83368"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.00026299),
        dec: Angle.Degrees(+26.59080463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206124"},
        {"Hipparcos Number", "HIP 106935"},
        {"Smithsonian Astrophysical Observation", "SAO 89880"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.85797392),
        dec: Angle.Degrees(+26.59141105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13213 AB"},
        {"Henry Draper", "HD 339272"},
        {"Hipparcos Number", "HIP 98390"},
        {"Smithsonian Astrophysical Observation", "SAO 88026"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.85502533),
        dec: Angle.Degrees(+26.59228394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188383"},
        {"Hipparcos Number", "HIP 97915"},
        {"Geneva Identification System", "GEN# +1.00188383"},
        {"Renson", "Renson 52035"},
        {"Smithsonian Astrophysical Observation", "SAO 87897"},
        {"Wilson Evans Batten Catalogue", "WEB 17228"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.46950633),
        dec: Angle.Degrees(+26.59347022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37642"},
        {"Smithsonian Astrophysical Observation", "SAO 79642"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.87121619),
        dec: Angle.Degrees(+26.59530765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112034"},
        {"Smithsonian Astrophysical Observation", "SAO 90712"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.38088231),
        dec: Angle.Degrees(+26.59641202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83397"},
        {"Smithsonian Astrophysical Observation", "SAO 84784"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.67314484),
        dec: Angle.Degrees(+26.59666503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70862"},
        {"Smithsonian Astrophysical Observation", "SAO 83379"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.36605499),
        dec: Angle.Degrees(+26.59704629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111367"},
        {"Hipparcos Number", "HIP 62507"},
        {"Geneva Identification System", "GEN# +1.00111367"},
        {"Smithsonian Astrophysical Observation", "SAO 82509"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.14267935),
        dec: Angle.Degrees(+26.59715831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213947"},
        {"Hipparcos Number", "HIP 111443"},
        {"Smithsonian Astrophysical Observation", "SAO 90607"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.65227844),
        dec: Angle.Degrees(+26.59820931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69206",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9136 AB"},
        {"Henry Draper", "HD 123963"},
        {"Hipparcos Number", "HIP 69206"},
        {"Smithsonian Astrophysical Observation", "SAO 83201"},
        {"Wilson Evans Batten Catalogue", "WEB 12078"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.53231274),
        dec: Angle.Degrees(+26.59947002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151780"},
        {"Hipparcos Number", "HIP 82263"},
        {"Smithsonian Astrophysical Observation", "SAO 84619"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.13362127),
        dec: Angle.Degrees(+26.59951588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117730"},
        {"Hipparcos Number", "HIP 65994"},
        {"Geneva Identification System", "GEN# +1.00117730"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.95639033),
        dec: Angle.Degrees(+26.60100611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68764"},
        {"Smithsonian Astrophysical Observation", "SAO 83150"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.11395255),
        dec: Angle.Degrees(+26.60169446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141023"},
        {"Hipparcos Number", "HIP 77205"},
        {"Smithsonian Astrophysical Observation", "SAO 83992"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46356903),
        dec: Angle.Degrees(+26.60195503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60407"},
        {"Hipparcos Number", "HIP 36912"},
        {"Smithsonian Astrophysical Observation", "SAO 79530"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.83813512),
        dec: Angle.Degrees(+26.60230277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52051",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7860 AB"},
        {"Henry Draper", "HD 92049"},
        {"Hipparcos Number", "HIP 52051"},
        {"Cincinnati Publication", "Ci 18 1284"},
        {"Smithsonian Astrophysical Observation", "SAO 81448"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.54563717),
        dec: Angle.Degrees(+26.60701714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22145"},
        {"Hipparcos Number", "HIP 16704"},
        {"Smithsonian Astrophysical Observation", "SAO 76004"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.73978142),
        dec: Angle.Degrees(+26.60826823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220242"},
        {"Hipparcos Number", "HIP 115360"},
        {"Geneva Identification System", "GEN# +1.00220242"},
        {"Smithsonian Astrophysical Observation", "SAO 91208"},
        {"Wilson Evans Batten Catalogue", "WEB 20431"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.49297672),
        dec: Angle.Degrees(+26.60910495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18803"},
        {"Hipparcos Number", "HIP 14150"},
        {"Geneva Identification System", "GEN# +1.00018803"},
        {"Smithsonian Astrophysical Observation", "SAO 75696"},
        {"Wilson Evans Batten Catalogue", "WEB 2781"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.60780944),
        dec: Angle.Degrees(+26.60964871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212595"},
        {"Hipparcos Number", "HIP 110658"},
        {"Geneva Identification System", "GEN# +1.00212595"},
        {"Renson", "Renson 58970"},
        {"Smithsonian Astrophysical Observation", "SAO 90486"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26146995),
        dec: Angle.Degrees(+26.61111666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335758"},
        {"Hipparcos Number", "HIP 89346"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.45557815),
        dec: Angle.Degrees(+26.61211199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144004"},
        {"Hipparcos Number", "HIP 78572"},
        {"Geneva Identification System", "GEN# +1.00144004"},
        {"Smithsonian Astrophysical Observation", "SAO 84160"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.66014237),
        dec: Angle.Degrees(+26.61223819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201626"},
        {"Hipparcos Number", "HIP 104486"},
        {"Geneva Identification System", "GEN# +1.00201626"},
        {"Smithsonian Astrophysical Observation", "SAO 89499"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49708112),
        dec: Angle.Degrees(+26.61518484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184010"},
        {"Hipparcos Number", "HIP 96016"},
        {"Geneva Identification System", "GEN# +1.00184010"},
        {"Smithsonian Astrophysical Observation", "SAO 87314"},
        {"Wilson Evans Batten Catalogue", "WEB 16821"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.84005924),
        dec: Angle.Degrees(+26.61710997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338362"},
        {"Hipparcos Number", "HIP 95739"},
        {"Geneva Identification System", "GEN# +1.00338362"},
        {"Smithsonian Astrophysical Observation", "SAO 87255"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.09966030),
        dec: Angle.Degrees(+26.61735086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37329"},
        {"Hipparcos Number", "HIP 26571"},
        {"Geneva Identification System", "GEN# +1.00037329"},
        {"Smithsonian Astrophysical Observation", "SAO 77350"},
        {"Wilson Evans Batten Catalogue", "WEB 5239"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73901439),
        dec: Angle.Degrees(+26.61809415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260198"},
        {"Hipparcos Number", "HIP 31545"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.05015732),
        dec: Angle.Degrees(+26.61950819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107325"},
        {"Hipparcos Number", "HIP 60170"},
        {"Geneva Identification System", "GEN# +5.21110071"},
        {"Smithsonian Astrophysical Observation", "SAO 82250"},
        {"Wilson Evans Batten Catalogue", "WEB 10696"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.08216696),
        dec: Angle.Degrees(+26.61975090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155641"},
        {"Hipparcos Number", "HIP 84115"},
        {"Smithsonian Astrophysical Observation", "SAO 84905"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.95005407),
        dec: Angle.Degrees(+26.62103114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35964",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)24, 48.1400),
        dec: Angle.DegreesMinutesSeconds((int)+26, (int)37, 16.200)
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
    primaryId: "HIP 60358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107725"},
        {"Hipparcos Number", "HIP 60358"},
        {"Geneva Identification System", "GEN# +5.21110093"},
        {"Smithsonian Astrophysical Observation", "SAO 82275"},
        {"Wilson Evans Batten Catalogue", "WEB 10737"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.64339889),
        dec: Angle.Degrees(+26.62159078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12491",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2034 AB"},
        {"Henry Draper", "HD 16638"},
        {"Hipparcos Number", "HIP 12491"},
        {"Geneva Identification System", "GEN# +1.00016638"},
        {"Wilson Evans Batten Catalogue", "WEB 2554"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.17597716),
        dec: Angle.Degrees(+26.62231281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210026"},
        {"Hipparcos Number", "HIP 109175"},
        {"Smithsonian Astrophysical Observation", "SAO 90239"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.74469598),
        dec: Angle.Degrees(+26.62278025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13691"},
        {"Hipparcos Number", "HIP 10402"},
        {"Geneva Identification System", "GEN# +1.00013691"},
        {"Smithsonian Astrophysical Observation", "SAO 75215"},
        {"Wilson Evans Batten Catalogue", "WEB 2177"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.50970807),
        dec: Angle.Degrees(+26.62689822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35967"},
        {"Fundamental Katalog 5th Edition", "FK5 4667"},
        {"Smithsonian Astrophysical Observation", "SAO 79369"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20247758),
        dec: Angle.Degrees(+26.62749551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224560"},
        {"Hipparcos Number", "HIP 118231"},
        {"Smithsonian Astrophysical Observation", "SAO 91627"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.72743488),
        dec: Angle.Degrees(+26.62805825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9630 AB"},
        {"Henry Draper", "HD 137529"},
        {"Hipparcos Number", "HIP 75519"},
        {"Smithsonian Astrophysical Observation", "SAO 83814"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.42841230),
        dec: Angle.Degrees(+26.62807082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68562"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.53718355),
        dec: Angle.Degrees(+26.62838678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125039"},
        {"Hipparcos Number", "HIP 69743"},
        {"Smithsonian Astrophysical Observation", "SAO 83261"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.12101658),
        dec: Angle.Degrees(+26.62877571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54126"},
        {"Hipparcos Number", "HIP 34487"},
        {"Smithsonian Astrophysical Observation", "SAO 79105"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.20440032),
        dec: Angle.Degrees(+26.62953755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78418"},
        {"Hipparcos Number", "HIP 44892"},
        {"Cincinnati Publication", "Ci 20 511"},
        {"Fundamental Katalog 5th Edition", "FK5 2724"},
        {"Geneva Identification System", "GEN# +1.00078418"},
        {"Smithsonian Astrophysical Observation", "SAO 80659"},
        {"Wilson Evans Batten Catalogue", "WEB 8575"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.19758758),
        dec: Angle.Degrees(+26.63001213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -370.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108082",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108082"},
        {"Smithsonian Astrophysical Observation", "SAO 90084"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.47413542),
        dec: Angle.Degrees(+26.63048056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203976"},
        {"Hipparcos Number", "HIP 105726"},
        {"Smithsonian Astrophysical Observation", "SAO 89688"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.20490063),
        dec: Angle.Degrees(+26.63062798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182008"},
        {"Hipparcos Number", "HIP 95169"},
        {"Geneva Identification System", "GEN# +1.00182008"},
        {"Smithsonian Astrophysical Observation", "SAO 87114"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.41900693),
        dec: Angle.Degrees(+26.63551867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92279"},
        {"Hipparcos Number", "HIP 52185"},
        {"Smithsonian Astrophysical Observation", "SAO 81456"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.92004742),
        dec: Angle.Degrees(+26.63622981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67692"},
        {"Geneva Identification System", "GEN# +0.02702303"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.99829443),
        dec: Angle.Degrees(+26.63640934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65934"},
        {"Hipparcos Number", "HIP 39306"},
        {"Smithsonian Astrophysical Observation", "SAO 79879"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.54621373),
        dec: Angle.Degrees(+26.63793802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248906"},
        {"Hipparcos Number", "HIP 27907"},
        {"Smithsonian Astrophysical Observation", "SAO 77703"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.57837266),
        dec: Angle.Degrees(+26.63965550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69786"},
        {"Hipparcos Number", "HIP 40792"},
        {"Smithsonian Astrophysical Observation", "SAO 80095"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.88255294),
        dec: Angle.Degrees(+26.64082248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104124"},
    },
    visualMagnitude: 10.75,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.42046758),
        dec: Angle.Degrees(+26.64140138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90442"},
        {"Hipparcos Number", "HIP 51157"},
        {"Geneva Identification System", "GEN# +1.00090442"},
        {"Smithsonian Astrophysical Observation", "SAO 81348"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.74746522),
        dec: Angle.Degrees(+26.64166347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10065"},
        {"Hipparcos Number", "HIP 7677"},
        {"Smithsonian Astrophysical Observation", "SAO 74847"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.70809826),
        dec: Angle.Degrees(+26.64423760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181602"},
        {"Hipparcos Number", "HIP 95028"},
        {"Geneva Identification System", "GEN# +1.00181602"},
        {"Smithsonian Astrophysical Observation", "SAO 87082"},
        {"Wilson Evans Batten Catalogue", "WEB 16595"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.03111605),
        dec: Angle.Degrees(+26.64504014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 42 A"},
        {"Henry Draper", "HD 225276"},
        {"Hipparcos Number", "HIP 399"},
        {"Geneva Identification System", "GEN# +1.00225276A"},
        {"Smithsonian Astrophysical Observation", "SAO 73731"},
        {"Wilson Evans Batten Catalogue", "WEB 59"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.23302998),
        dec: Angle.Degrees(+26.64879958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3608 C"},
        {"Henry Draper", "HD 32093"},
        {"Hipparcos Number", "HIP 23402"},
        {"Geneva Identification System", "GEN# +1.00032093"},
        {"Smithsonian Astrophysical Observation", "SAO 76904"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.44302929),
        dec: Angle.Degrees(+26.65066656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11031 A"},
        {"Henry Draper", "HD 165241"},
        {"Hipparcos Number", "HIP 88474"},
        {"Geneva Identification System", "GEN# +1.00165241"},
        {"Smithsonian Astrophysical Observation", "SAO 85696"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.97547558),
        dec: Angle.Degrees(+26.65139062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71991"},
        {"Smithsonian Astrophysical Observation", "SAO 83487"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.84903071),
        dec: Angle.Degrees(+26.65658324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106189"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.62859571),
        dec: Angle.Degrees(+26.65696613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170737"},
        {"Hipparcos Number", "HIP 90659"},
        {"Geneva Identification System", "GEN# +1.00170737"},
        {"Smithsonian Astrophysical Observation", "SAO 86130"},
        {"Wilson Evans Batten Catalogue", "WEB 15525"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.47521868),
        dec: Angle.Degrees(+26.65740577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56843"},
        {"Smithsonian Astrophysical Observation", "SAO 81921"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.80786551),
        dec: Angle.Degrees(+26.66066392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44905"},
        {"Smithsonian Astrophysical Observation", "SAO 80660"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22331991),
        dec: Angle.Degrees(+26.66115286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173780"},
        {"Hipparcos Number", "HIP 92088"},
        {"Fundamental Katalog 5th Edition", "FK5 1488"},
        {"Geneva Identification System", "GEN# +1.00173780"},
        {"Smithsonian Astrophysical Observation", "SAO 86418"},
        {"Wilson Evans Batten Catalogue", "WEB 15872"},
    },
    visualMagnitude: 4.83,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51861708),
        dec: Angle.Degrees(+26.66207055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181601"},
        {"Hipparcos Number", "HIP 95029"},
        {"Geneva Identification System", "GEN# +1.00181601"},
        {"Smithsonian Astrophysical Observation", "SAO 87083"},
        {"Wilson Evans Batten Catalogue", "WEB 16594"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.03121624),
        dec: Angle.Degrees(+26.66217768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264933"},
        {"Hipparcos Number", "HIP 32922"},
        {"Smithsonian Astrophysical Observation", "SAO 78804"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88804619),
        dec: Angle.Degrees(+26.66307824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108959"},
        {"Smithsonian Astrophysical Observation", "SAO 90205"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.12380729),
        dec: Angle.Degrees(+26.66523027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3726"},
        {"Hipparcos Number", "HIP 3164"},
        {"Geneva Identification System", "GEN# +1.00003726"},
        {"Smithsonian Astrophysical Observation", "SAO 74183"},
        {"Wilson Evans Batten Catalogue", "WEB 565"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.08026530),
        dec: Angle.Degrees(+26.66624490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53367"},
        {"Smithsonian Astrophysical Observation", "SAO 81577"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.69286518),
        dec: Angle.Degrees(+26.66644889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30306",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4983 A"},
        {"Henry Draper", "HD 44328"},
        {"Hipparcos Number", "HIP 30306"},
        {"Smithsonian Astrophysical Observation", "SAO 78286"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.60812923),
        dec: Angle.Degrees(+26.66899132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257288"},
        {"Hipparcos Number", "HIP 30724"},
        {"Smithsonian Astrophysical Observation", "SAO 78385"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.82615669),
        dec: Angle.Degrees(+26.66916851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338618"},
        {"Hipparcos Number", "HIP 96436"},
        {"Smithsonian Astrophysical Observation", "SAO 87440"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.09625896),
        dec: Angle.Degrees(+26.66925109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79441",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9966 AB"},
        {"Henry Draper", "HD 145976"},
        {"Hipparcos Number", "HIP 79441"},
        {"Geneva Identification System", "GEN# +1.00145976"},
        {"Smithsonian Astrophysical Observation", "SAO 84247"},
        {"Wilson Evans Batten Catalogue", "WEB 13434"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.18927382),
        dec: Angle.Degrees(+26.67065993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166781"},
        {"Hipparcos Number", "HIP 89095"},
        {"Geneva Identification System", "GEN# +1.00166781"},
        {"Smithsonian Astrophysical Observation", "SAO 85804"},
        {"Wilson Evans Batten Catalogue", "WEB 15127"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.76462641),
        dec: Angle.Degrees(+26.67076965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335828"},
        {"Hipparcos Number", "HIP 89656"},
        {"Cincinnati Publication", "Ci 22 1700"},
        {"Geneva Identification System", "GEN# +1.00335828"},
        {"Smithsonian Astrophysical Observation", "SAO 85902"},
        {"Wilson Evans Batten Catalogue", "WEB 15273"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.45662590),
        dec: Angle.Degrees(+26.67105367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 327.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23395",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3608 AB"},
        {"Henry Draper", "HD 32092"},
        {"Hipparcos Number", "HIP 23395"},
        {"Geneva Identification System", "GEN# +1.00032092J"},
        {"Smithsonian Astrophysical Observation", "SAO 76903"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.43448908),
        dec: Angle.Degrees(+26.67106213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283704"},
        {"Hipparcos Number", "HIP 20949"},
        {"Geneva Identification System", "GEN# +5.20250076"},
        {"Smithsonian Astrophysical Observation", "SAO 76628"},
        {"Wilson Evans Batten Catalogue", "WEB 4027"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.37796582),
        dec: Angle.Degrees(+26.67166648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159479"},
        {"Hipparcos Number", "HIP 85945"},
        {"Geneva Identification System", "GEN# +1.00159479"},
        {"Smithsonian Astrophysical Observation", "SAO 85211"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.48500254),
        dec: Angle.Degrees(+26.67167195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209761"},
        {"Hipparcos Number", "HIP 109023"},
        {"Geneva Identification System", "GEN# +1.00209761"},
        {"Smithsonian Astrophysical Observation", "SAO 90214"},
        {"Wilson Evans Batten Catalogue", "WEB 19605"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.29714774),
        dec: Angle.Degrees(+26.67361826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30304",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4983 B"},
        {"Hipparcos Number", "HIP 30304"},
        {"Smithsonian Astrophysical Observation", "SAO 78284"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.60703362),
        dec: Angle.Degrees(+26.67389325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71094",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9301 AB"},
        {"Aitken 2", "ADS 9301"},
        {"Henry Draper", "HD 127726"},
        {"Hipparcos Number", "HIP 71094"},
        {"Geneva Identification System", "GEN# +1.00127726J"},
        {"Smithsonian Astrophysical Observation", "SAO 83394"},
        {"Wilson Evans Batten Catalogue", "WEB 12294"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.08446559),
        dec: Angle.Degrees(+26.67734238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111750"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.55856540),
        dec: Angle.Degrees(+26.67874392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24301"},
        {"Hipparcos Number", "HIP 18163"},
        {"Geneva Identification System", "GEN# +1.00024301"},
        {"Smithsonian Astrophysical Observation", "SAO 76294"},
        {"Wilson Evans Batten Catalogue", "WEB 3503"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.24701277),
        dec: Angle.Degrees(+26.67883936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103676"},
        {"Hipparcos Number", "HIP 58213"},
        {"Geneva Identification System", "GEN# +1.00103676"},
        {"Smithsonian Astrophysical Observation", "SAO 82062"},
        {"Wilson Evans Batten Catalogue", "WEB 10420"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.08635796),
        dec: Angle.Degrees(+26.67959996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 115 AB"},
        {"Hipparcos Number", "HIP 780"},
        {"Fundamental Katalog 5th Edition", "FK5 4020"},
        {"Smithsonian Astrophysical Observation", "SAO 73781"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.40182077),
        dec: Angle.Degrees(+26.68206689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41600"},
        {"Hipparcos Number", "HIP 29014"},
        {"Smithsonian Astrophysical Observation", "SAO 77980"},
    },
    visualMagnitude: 7.08,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.83342783),
        dec: Angle.Degrees(+26.68216142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14738"},
        {"Hipparcos Number", "HIP 11126"},
        {"Geneva Identification System", "GEN# +1.00014738"},
        {"Smithsonian Astrophysical Observation", "SAO 75326"},
        {"Wilson Evans Batten Catalogue", "WEB 2341"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.80021873),
        dec: Angle.Degrees(+26.68231132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81162"},
        {"Hipparcos Number", "HIP 46153"},
        {"Smithsonian Astrophysical Observation", "SAO 80808"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.18348946),
        dec: Angle.Degrees(+26.68318542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1250 AB"},
        {"Henry Draper", "HD 9701"},
        {"Hipparcos Number", "HIP 7406"},
        {"Geneva Identification System", "GEN# +1.00009701"},
        {"Smithsonian Astrophysical Observation", "SAO 74810"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.86081156),
        dec: Angle.Degrees(+26.68440112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74684"},
        {"Hipparcos Number", "HIP 43052"},
        {"Smithsonian Astrophysical Observation", "SAO 80410"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.56673520),
        dec: Angle.Degrees(+26.68444231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60695"},
    },
    visualMagnitude: 11.76,
    bvColour: 2.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.59185820),
        dec: Angle.Degrees(+35.93301035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -494.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118905"},
        {"Hipparcos Number", "HIP 66627"},
        {"Geneva Identification System", "GEN# +1.00118905"},
        {"Smithsonian Astrophysical Observation", "SAO 82928"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85569239),
        dec: Angle.Degrees(+26.68487835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36307"},
        {"Hipparcos Number", "HIP 25925"},
        {"Smithsonian Astrophysical Observation", "SAO 77229"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.98498152),
        dec: Angle.Degrees(+26.68500152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195509"},
        {"Hipparcos Number", "HIP 101210"},
        {"Geneva Identification System", "GEN# +1.00195509"},
        {"Smithsonian Astrophysical Observation", "SAO 88786"},
        {"Wilson Evans Batten Catalogue", "WEB 18281"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.73601011),
        dec: Angle.Degrees(+26.68558760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110336"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.21313553),
        dec: Angle.Degrees(+26.68847470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175084"},
        {"Hipparcos Number", "HIP 92641"},
        {"Smithsonian Astrophysical Observation", "SAO 86535"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.15243512),
        dec: Angle.Degrees(+26.68894328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65246"},
        {"Smithsonian Astrophysical Observation", "SAO 82803"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.56342981),
        dec: Angle.Degrees(+26.68954012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44349"},
        {"Geneva Identification System", "GEN# +0.02701706"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.48108607),
        dec: Angle.Degrees(+26.68976705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56176"},
        {"Hipparcos Number", "HIP 35253"},
        {"Geneva Identification System", "GEN# +1.00056176"},
        {"Smithsonian Astrophysical Observation", "SAO 79241"},
        {"Wilson Evans Batten Catalogue", "WEB 7039"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.26401639),
        dec: Angle.Degrees(+26.68980471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93615",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11998 AB"},
        {"Aitken 2", "ADS 11998"},
        {"Henry Draper", "HD 337446"},
        {"Hipparcos Number", "HIP 93615"},
        {"Geneva Identification System", "GEN# +1.00337446J"},
        {"Smithsonian Astrophysical Observation", "SAO 86758"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.96320786),
        dec: Angle.Degrees(+26.69392284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69551",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9177 AB"},
        {"Henry Draper", "HD 124643"},
        {"Hipparcos Number", "HIP 69551"},
        {"Smithsonian Astrophysical Observation", "SAO 83239"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.55344823),
        dec: Angle.Degrees(+26.69553761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89631"},
        {"Hipparcos Number", "HIP 50699"},
        {"Geneva Identification System", "GEN# +1.00089631"},
        {"Smithsonian Astrophysical Observation", "SAO 81306"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.29181227),
        dec: Angle.Degrees(+26.69668257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112294"},
        {"Smithsonian Astrophysical Observation", "SAO 90755"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.18141218),
        dec: Angle.Degrees(+26.69751531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196908"},
        {"Hipparcos Number", "HIP 101944"},
        {"Geneva Identification System", "GEN# +1.00196908"},
        {"Smithsonian Astrophysical Observation", "SAO 88969"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.88033977),
        dec: Angle.Degrees(+26.69761220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340676"},
        {"Hipparcos Number", "HIP 101893"},
        {"Geneva Identification System", "GEN# +1.00340676"},
        {"Smithsonian Astrophysical Observation", "SAO 88955"},
        {"Wilson Evans Batten Catalogue", "WEB 18411"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.73072371),
        dec: Angle.Degrees(+26.70033216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13843 A"},
        {"Henry Draper", "HD 194595"},
        {"Hipparcos Number", "HIP 100750"},
        {"Geneva Identification System", "GEN# +1.00194595"},
        {"Smithsonian Astrophysical Observation", "SAO 88665"},
        {"Wilson Evans Batten Catalogue", "WEB 18207"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.40873332),
        dec: Angle.Degrees(+26.70469341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18060"},
    },
    visualMagnitude: 11.75,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.90273637),
        dec: Angle.Degrees(+36.25947229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168956"},
        {"Hipparcos Number", "HIP 89959"},
        {"Geneva Identification System", "GEN# +1.00168956"},
        {"Smithsonian Astrophysical Observation", "SAO 85960"},
        {"Wilson Evans Batten Catalogue", "WEB 15366"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.31605768),
        dec: Angle.Degrees(+26.70675489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57087"},
        {"Geneva Identification System", "GEN# +9.80120068"},
        {"Wilson Evans Batten Catalogue", "WEB 10275"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.54378678),
        dec: Angle.Degrees(+26.70854768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 896.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -813.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100760",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13843 BC"},
        {"Henry Draper", "HD 340224"},
        {"Hipparcos Number", "HIP 100760"},
        {"Smithsonian Astrophysical Observation", "SAO 88669"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.43088359),
        dec: Angle.Degrees(+26.71082529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134282"},
        {"Hipparcos Number", "HIP 74070"},
        {"Geneva Identification System", "GEN# +1.00134282"},
        {"Smithsonian Astrophysical Observation", "SAO 83680"},
        {"Wilson Evans Batten Catalogue", "WEB 12652"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05801699),
        dec: Angle.Degrees(+26.71134983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337556"},
        {"Hipparcos Number", "HIP 93891"},
        {"Smithsonian Astrophysical Observation", "SAO 86829"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78720349),
        dec: Angle.Degrees(+26.71319034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188686"},
        {"Hipparcos Number", "HIP 98047"},
        {"Geneva Identification System", "GEN# +1.00188686"},
        {"Smithsonian Astrophysical Observation", "SAO 87934"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.85483753),
        dec: Angle.Degrees(+26.71319837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46734"},
        {"Hipparcos Number", "HIP 31535"},
        {"Smithsonian Astrophysical Observation", "SAO 78537"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.02522790),
        dec: Angle.Degrees(+26.71475712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76267",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alphecca"},
        {"Henry Draper", "HD 139006"},
        {"Hipparcos Number", "HIP 76267"},
        {"Fundamental Katalog 5th Edition", "FK5 578"},
        {"Geneva Identification System", "GEN# +1.00139006"},
        {"Smithsonian Astrophysical Observation", "SAO 83893"},
        {"Wilson Evans Batten Catalogue", "WEB 12948"},
    },
    visualMagnitude: 2.22,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.67162293),
        dec: Angle.Degrees(+26.71491041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16841 AB"},
        {"Henry Draper", "HD 221714"},
        {"Hipparcos Number", "HIP 116340"},
        {"Smithsonian Astrophysical Observation", "SAO 91352"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.61035844),
        dec: Angle.Degrees(+26.71512481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156536"},
        {"Hipparcos Number", "HIP 84548"},
        {"Geneva Identification System", "GEN# +1.00156536"},
        {"Smithsonian Astrophysical Observation", "SAO 84972"},
        {"Wilson Evans Batten Catalogue", "WEB 14272"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.25741934),
        dec: Angle.Degrees(+26.71522089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212547"},
        {"Hipparcos Number", "HIP 110621"},
        {"Smithsonian Astrophysical Observation", "SAO 90481"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.15269726),
        dec: Angle.Degrees(+26.71539968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61243"},
        {"Wilson Evans Batten Catalogue", "WEB 10899"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.25152766),
        dec: Angle.Degrees(+26.71630435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66321"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88162522),
        dec: Angle.Degrees(+26.71674578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183561"},
        {"Hipparcos Number", "HIP 95806"},
        {"Geneva Identification System", "GEN# +1.00183561"},
        {"Smithsonian Astrophysical Observation", "SAO 87270"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.31104631),
        dec: Angle.Degrees(+26.71682014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75564"},
        {"Smithsonian Astrophysical Observation", "SAO 83820"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.55716721),
        dec: Angle.Degrees(+26.71993266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32509"},
        {"Hipparcos Number", "HIP 23633"},
        {"Smithsonian Astrophysical Observation", "SAO 76945"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20884856),
        dec: Angle.Degrees(+26.72085053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61364"},
        {"Hipparcos Number", "HIP 37337"},
        {"Geneva Identification System", "GEN# +1.00061364"},
        {"Smithsonian Astrophysical Observation", "SAO 79590"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97266434),
        dec: Angle.Degrees(+26.72189530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 406"},
        {"Smithsonian Astrophysical Observation", "SAO 73732"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.24392487),
        dec: Angle.Degrees(+26.72525618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158521"},
        {"Hipparcos Number", "HIP 85532"},
        {"Geneva Identification System", "GEN# +1.00158521"},
        {"Smithsonian Astrophysical Observation", "SAO 85129"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.19215061),
        dec: Angle.Degrees(+26.72537086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62615"},
        {"Hipparcos Number", "HIP 37886"},
        {"Smithsonian Astrophysical Observation", "SAO 79677"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.47098795),
        dec: Angle.Degrees(+26.72557937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213101"},
        {"Hipparcos Number", "HIP 110946"},
        {"Smithsonian Astrophysical Observation", "SAO 90537"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.18094452),
        dec: Angle.Degrees(+26.72566987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180241"},
        {"Hipparcos Number", "HIP 94569"},
        {"Smithsonian Astrophysical Observation", "SAO 86977"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.69567868),
        dec: Angle.Degrees(+26.73002049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68724"},
        {"Hipparcos Number", "HIP 40378"},
        {"Geneva Identification System", "GEN# +1.00068724"},
        {"Smithsonian Astrophysical Observation", "SAO 80032"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66358982),
        dec: Angle.Degrees(+26.73010792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200223"},
        {"Hipparcos Number", "HIP 103757"},
        {"Renson", "Renson 55770"},
        {"Smithsonian Astrophysical Observation", "SAO 89375"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.37358136),
        dec: Angle.Degrees(+26.73156189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207858"},
        {"Hipparcos Number", "HIP 107890"},
        {"Geneva Identification System", "GEN# +1.00207858"},
        {"Smithsonian Astrophysical Observation", "SAO 90053"},
        {"Wilson Evans Batten Catalogue", "WEB 19453"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.89455359),
        dec: Angle.Degrees(+26.73556165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179422"},
        {"Hipparcos Number", "HIP 94290"},
        {"Geneva Identification System", "GEN# +1.00179422"},
        {"Smithsonian Astrophysical Observation", "SAO 86912"},
        {"Wilson Evans Batten Catalogue", "WEB 16424"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.87900681),
        dec: Angle.Degrees(+26.73594891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128609"},
        {"Hipparcos Number", "HIP 71490"},
        {"Geneva Identification System", "GEN# +1.00128609"},
        {"Smithsonian Astrophysical Observation", "SAO 83440"},
        {"Wilson Evans Batten Catalogue", "WEB 12333"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.29830593),
        dec: Angle.Degrees(+26.73654275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3650"},
        {"Hipparcos Number", "HIP 3101"},
        {"Smithsonian Astrophysical Observation", "SAO 74176"},
        {"Wilson Evans Batten Catalogue", "WEB 554"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.86776727),
        dec: Angle.Degrees(+26.73691109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16170 A"},
        {"Henry Draper", "HD 214849"},
        {"Hipparcos Number", "HIP 111957"},
        {"Smithsonian Astrophysical Observation", "SAO 90696"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.16815384),
        dec: Angle.Degrees(+26.73790131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17283"},
        {"Hipparcos Number", "HIP 13010"},
        {"Smithsonian Astrophysical Observation", "SAO 75570"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.80256698),
        dec: Angle.Degrees(+26.73844542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79219",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kamuy"},
        {"Henry Draper", "HD 145457"},
        {"Hipparcos Number", "HIP 79219"},
        {"Geneva Identification System", "GEN# +1.00145457"},
        {"Smithsonian Astrophysical Observation", "SAO 84223"},
        {"Wilson Evans Batten Catalogue", "WEB 13394"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.51635964),
        dec: Angle.Degrees(+26.74265822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24690"},
        {"Hipparcos Number", "HIP 18439"},
        {"Geneva Identification System", "GEN# +1.00024690"},
        {"Smithsonian Astrophysical Observation", "SAO 76332"},
        {"Wilson Evans Batten Catalogue", "WEB 3554"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.12988396),
        dec: Angle.Degrees(+26.74294466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74812"},
        {"Hipparcos Number", "HIP 43127"},
        {"Smithsonian Astrophysical Observation", "SAO 80422"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.77006295),
        dec: Angle.Degrees(+26.74369917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192043"},
        {"Hipparcos Number", "HIP 99528"},
        {"Geneva Identification System", "GEN# +2.68820005"},
        {"Smithsonian Astrophysical Observation", "SAO 88335"},
        {"New General Catalogue", "NGC 6882 5"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.98803496),
        dec: Angle.Degrees(+26.74372999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6487"},
        {"Hipparcos Number", "HIP 5177"},
        {"Smithsonian Astrophysical Observation", "SAO 74488"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.55261372),
        dec: Angle.Degrees(+26.74394804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175035"},
        {"Hipparcos Number", "HIP 92626"},
        {"Smithsonian Astrophysical Observation", "SAO 86530"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.10324067),
        dec: Angle.Degrees(+26.74556201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16508"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.13737318),
        dec: Angle.Degrees(+26.74674291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99302"},
        {"Hipparcos Number", "HIP 55781"},
        {"Fundamental Katalog 5th Edition", "FK5 1295"},
        {"Geneva Identification System", "GEN# +1.00099302"},
        {"Renson", "Renson 28610"},
        {"Smithsonian Astrophysical Observation", "SAO 81819"},
        {"Wilson Evans Batten Catalogue", "WEB 10025"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.44066121),
        dec: Angle.Degrees(+26.74722187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36441"},
        {"Hipparcos Number", "HIP 25988"},
        {"Geneva Identification System", "GEN# +1.00036441"},
        {"Smithsonian Astrophysical Observation", "SAO 77242"},
        {"Wilson Evans Batten Catalogue", "WEB 5056"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.19428923),
        dec: Angle.Degrees(+26.74742503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255817"},
        {"Hipparcos Number", "HIP 30305"},
        {"Smithsonian Astrophysical Observation", "SAO 78285"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.60777182),
        dec: Angle.Degrees(+26.74758063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242299"},
        {"Hipparcos Number", "HIP 24684"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.42417050),
        dec: Angle.Degrees(+26.74783519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340555"},
        {"Hipparcos Number", "HIP 101630"},
        {"Smithsonian Astrophysical Observation", "SAO 88881"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.97754814),
        dec: Angle.Degrees(+26.74968878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71981"},
        {"Cincinnati Publication", "Ci 18 1943"},
        {"Geneva Identification System", "GEN# +0.02702411"},
        {"Smithsonian Astrophysical Observation", "SAO 83486"},
        {"Wilson Evans Batten Catalogue", "WEB 12391"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.83023500),
        dec: Angle.Degrees(+26.74973066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -332.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206374"},
        {"Hipparcos Number", "HIP 107070"},
        {"Cincinnati Publication", "Ci 18 2816"},
        {"Geneva Identification System", "GEN# +1.00206374"},
        {"Smithsonian Astrophysical Observation", "SAO 89905"},
        {"Wilson Evans Batten Catalogue", "WEB 19339"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.27488546),
        dec: Angle.Degrees(+26.75088747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 342.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338708"},
        {"Hipparcos Number", "HIP 96704"},
        {"Geneva Identification System", "GEN# +1.00338708"},
        {"Smithsonian Astrophysical Observation", "SAO 87519"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89002778),
        dec: Angle.Degrees(+26.75134609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109968"},
        {"Hipparcos Number", "HIP 61694"},
        {"Smithsonian Astrophysical Observation", "SAO 82418"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.69611224),
        dec: Angle.Degrees(+26.75193656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241138"},
        {"Hipparcos Number", "HIP 24047"},
        {"Smithsonian Astrophysical Observation", "SAO 77000"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51871814),
        dec: Angle.Degrees(+26.75365400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207163"},
        {"Hipparcos Number", "HIP 107518"},
        {"Geneva Identification System", "GEN# +1.00207163"},
        {"Smithsonian Astrophysical Observation", "SAO 89980"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.63411740),
        dec: Angle.Degrees(+26.75374908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149973"},
        {"Hipparcos Number", "HIP 81370"},
        {"Smithsonian Astrophysical Observation", "SAO 84487"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.27209601),
        dec: Angle.Degrees(+26.75409129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200843"},
        {"Hipparcos Number", "HIP 104080"},
        {"Smithsonian Astrophysical Observation", "SAO 89436"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.29636184),
        dec: Angle.Degrees(+26.75576639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259084"},
        {"Hipparcos Number", "HIP 31213"},
        {"Smithsonian Astrophysical Observation", "SAO 78476"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.21162205),
        dec: Angle.Degrees(+26.75577266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167391"},
        {"Hipparcos Number", "HIP 89349"},
        {"Geneva Identification System", "GEN# +1.00167391"},
        {"Smithsonian Astrophysical Observation", "SAO 85846"},
        {"Wilson Evans Batten Catalogue", "WEB 15193"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.47830650),
        dec: Angle.Degrees(+26.75633722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160508"},
        {"Hipparcos Number", "HIP 86394"},
        {"Geneva Identification System", "GEN# +1.00160508"},
        {"Smithsonian Astrophysical Observation", "SAO 85287"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.80280667),
        dec: Angle.Degrees(+26.75770164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86204"},
        {"Smithsonian Astrophysical Observation", "SAO 85250"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.24282666),
        dec: Angle.Degrees(+26.75948641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139405"},
        {"Hipparcos Number", "HIP 76474"},
        {"Smithsonian Astrophysical Observation", "SAO 83910"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.27934939),
        dec: Angle.Degrees(+26.76015533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57103"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.58448836),
        dec: Angle.Degrees(+26.76027863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103813"},
        {"Hipparcos Number", "HIP 58306"},
        {"Geneva Identification System", "GEN# +1.00103813"},
        {"Smithsonian Astrophysical Observation", "SAO 82071"},
        {"Wilson Evans Batten Catalogue", "WEB 10428"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.35698540),
        dec: Angle.Degrees(+26.76260203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213179"},
        {"Hipparcos Number", "HIP 110992"},
        {"Fundamental Katalog 5th Edition", "FK5 1589"},
        {"Geneva Identification System", "GEN# +1.00213179"},
        {"Smithsonian Astrophysical Observation", "SAO 90544"},
        {"Wilson Evans Batten Catalogue", "WEB 19872"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.29254382),
        dec: Angle.Degrees(+26.76320924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64145"},
        {"Hipparcos Number", "HIP 38538"},
        {"Fundamental Katalog 5th Edition", "FK5 1207"},
        {"Geneva Identification System", "GEN# +1.00064145"},
        {"Smithsonian Astrophysical Observation", "SAO 79774"},
        {"Wilson Evans Batten Catalogue", "WEB 7573"},
    },
    visualMagnitude: 4.97,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.37431874),
        dec: Angle.Degrees(+26.76585858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54161"},
        {"Hipparcos Number", "HIP 34500"},
        {"Smithsonian Astrophysical Observation", "SAO 79106"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.22598127),
        dec: Angle.Degrees(+26.76809480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109376"},
        {"Smithsonian Astrophysical Observation", "SAO 90276"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.37088484),
        dec: Angle.Degrees(+26.76842588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4195"},
        {"Hipparcos Number", "HIP 3495"},
        {"Smithsonian Astrophysical Observation", "SAO 74233"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.15606356),
        dec: Angle.Degrees(+26.77010071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55021"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97427120),
        dec: Angle.Degrees(+26.77022725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18450"},
        {"Hipparcos Number", "HIP 13891"},
        {"Smithsonian Astrophysical Observation", "SAO 75668"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.871,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.71850136),
        dec: Angle.Degrees(+26.77377289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108226"},
        {"Hipparcos Number", "HIP 60649"},
        {"Geneva Identification System", "GEN# +5.21110118"},
        {"Smithsonian Astrophysical Observation", "SAO 82304"},
        {"Wilson Evans Batten Catalogue", "WEB 10788"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.46650316),
        dec: Angle.Degrees(+26.77669123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123611"},
        {"Hipparcos Number", "HIP 69061"},
        {"Geneva Identification System", "GEN# +1.00123611"},
        {"Smithsonian Astrophysical Observation", "SAO 83188"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.04098724),
        dec: Angle.Degrees(+26.77705099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67995"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.86921918),
        dec: Angle.Degrees(+26.77732064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79999",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10007 AB"},
        {"Henry Draper", "HD 147251"},
        {"Hipparcos Number", "HIP 79999"},
        {"Smithsonian Astrophysical Observation", "SAO 84305"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.95680507),
        dec: Angle.Degrees(+26.77740976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30945"},
        {"Hipparcos Number", "HIP 22706"},
        {"Smithsonian Astrophysical Observation", "SAO 76804"},
        {"Wilson Evans Batten Catalogue", "WEB 4391"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.24261098),
        dec: Angle.Degrees(+26.77757913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112127"},
        {"Hipparcos Number", "HIP 62944"},
        {"Geneva Identification System", "GEN# +1.00112127"},
        {"Smithsonian Astrophysical Observation", "SAO 82554"},
        {"Wilson Evans Batten Catalogue", "WEB 11161"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.48226856),
        dec: Angle.Degrees(+26.78000371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113654",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16449 AB"},
        {"Henry Draper", "HD 217544"},
        {"Hipparcos Number", "HIP 113654"},
        {"Smithsonian Astrophysical Observation", "SAO 90947"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.27464196),
        dec: Angle.Degrees(+26.78134071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87717"},
        {"Hipparcos Number", "HIP 49597"},
        {"Geneva Identification System", "GEN# +1.00087717"},
        {"Smithsonian Astrophysical Observation", "SAO 81192"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.86553029),
        dec: Angle.Degrees(+26.78374894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209059"},
        {"Hipparcos Number", "HIP 108608"},
        {"Renson", "Renson 58140"},
        {"Smithsonian Astrophysical Observation", "SAO 90159"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.02777564),
        dec: Angle.Degrees(+26.78381354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62779"},
        {"Geneva Identification System", "GEN# +0.02702181"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.97510418),
        dec: Angle.Degrees(+26.78563389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341301"},
        {"Hipparcos Number", "HIP 103289"},
        {"Geneva Identification System", "GEN# +1.00341301"},
        {"Smithsonian Astrophysical Observation", "SAO 89286"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.88912432),
        dec: Angle.Degrees(+26.78563691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5650"},
        {"Hipparcos Number", "HIP 4571"},
        {"Smithsonian Astrophysical Observation", "SAO 74405"},
        {"Wilson Evans Batten Catalogue", "WEB 838"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.61860964),
        dec: Angle.Degrees(+26.78584740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61060"},
        {"Hipparcos Number", "HIP 37195"},
        {"Smithsonian Astrophysical Observation", "SAO 79567"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.61739013),
        dec: Angle.Degrees(+26.78728131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339766"},
        {"Hipparcos Number", "HIP 99789"},
        {"Smithsonian Astrophysical Observation", "SAO 88401"},
        {"Wilson Evans Batten Catalogue", "WEB 17923"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.69576381),
        dec: Angle.Degrees(+26.79242426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97520"},
        {"Geneva Identification System", "GEN# +8.02260006"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.31048874),
        dec: Angle.Degrees(+26.79415609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158332"},
        {"Hipparcos Number", "HIP 85436"},
        {"Cincinnati Publication", "Ci 18 2329"},
        {"Geneva Identification System", "GEN# +1.00158332"},
        {"Smithsonian Astrophysical Observation", "SAO 85110"},
        {"Wilson Evans Batten Catalogue", "WEB 14432"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.89436517),
        dec: Angle.Degrees(+26.79429130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 275.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112001"},
        {"Hipparcos Number", "HIP 62857"},
        {"Geneva Identification System", "GEN# +1.00112001"},
        {"Smithsonian Astrophysical Observation", "SAO 82547"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.25707451),
        dec: Angle.Degrees(+26.79448024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125320"},
        {"Hipparcos Number", "HIP 69886"},
        {"Geneva Identification System", "GEN# +1.00125320"},
        {"Smithsonian Astrophysical Observation", "SAO 83280"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.53394896),
        dec: Angle.Degrees(+26.79554435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54169"},
        {"Smithsonian Astrophysical Observation", "SAO 81654"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.21279809),
        dec: Angle.Degrees(+26.79646428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78787"},
        {"Smithsonian Astrophysical Observation", "SAO 84185"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.26512673),
        dec: Angle.Degrees(+26.79686949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65179"},
        {"Smithsonian Astrophysical Observation", "SAO 82796"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.36817321),
        dec: Angle.Degrees(+26.79851719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49652",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7648 A"},
        {"Henry Draper", "HD 87804"},
        {"Hipparcos Number", "HIP 49652"},
        {"Smithsonian Astrophysical Observation", "SAO 81201"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.03970403),
        dec: Angle.Degrees(+26.79872749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222391"},
        {"Hipparcos Number", "HIP 116783"},
        {"Geneva Identification System", "GEN# +1.00222391"},
        {"Smithsonian Astrophysical Observation", "SAO 91412"},
        {"Wilson Evans Batten Catalogue", "WEB 20607"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.01382996),
        dec: Angle.Degrees(+26.80191222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93651"},
        {"Hipparcos Number", "HIP 52889"},
        {"Smithsonian Astrophysical Observation", "SAO 81534"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.25445711),
        dec: Angle.Degrees(+26.80365725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339086"},
        {"Hipparcos Number", "HIP 97865"},
        {"Smithsonian Astrophysical Observation", "SAO 87872"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.30324537),
        dec: Angle.Degrees(+26.80401135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9111"},
        {"Smithsonian Astrophysical Observation", "SAO 75045"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.34441418),
        dec: Angle.Degrees(+26.80462586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118658"},
        {"Hipparcos Number", "HIP 66498"},
        {"Geneva Identification System", "GEN# +1.00118658"},
        {"Smithsonian Astrophysical Observation", "SAO 82914"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.47178953),
        dec: Angle.Degrees(+26.80570416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71651",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9331 AB"},
        {"Henry Draper", "HD 128967"},
        {"Hipparcos Number", "HIP 71651"},
        {"Fundamental Katalog 5th Edition", "FK5 5299"},
        {"Smithsonian Astrophysical Observation", "SAO 83454"},
        {"Wilson Evans Batten Catalogue", "WEB 12348"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.83091269),
        dec: Angle.Degrees(+26.80660335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283923"},
        {"Hipparcos Number", "HIP 22802"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.57488284),
        dec: Angle.Degrees(+26.80775364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192004"},
        {"Hipparcos Number", "HIP 99518"},
        {"Geneva Identification System", "GEN# +2.68820001"},
        {"Smithsonian Astrophysical Observation", "SAO 88330"},
        {"Wilson Evans Batten Catalogue", "WEB 17798"},
        {"New General Catalogue", "NGC 6882 1"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94989008),
        dec: Angle.Degrees(+26.80901561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340923"},
        {"Hipparcos Number", "HIP 102238"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.75108386),
        dec: Angle.Degrees(+26.80998377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -251.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113589"},
        {"Smithsonian Astrophysical Observation", "SAO 90935"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.09561798),
        dec: Angle.Degrees(+26.81001036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249698"},
        {"Hipparcos Number", "HIP 28276"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.62047071),
        dec: Angle.Degrees(+26.81025416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165041"},
        {"Hipparcos Number", "HIP 88388"},
        {"Smithsonian Astrophysical Observation", "SAO 85682"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.73652747),
        dec: Angle.Degrees(+26.81293485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338084"},
        {"Hipparcos Number", "HIP 94772"},
        {"Smithsonian Astrophysical Observation", "SAO 87025"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.25696775),
        dec: Angle.Degrees(+26.81430731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132408"},
        {"Hipparcos Number", "HIP 73248"},
        {"Geneva Identification System", "GEN# +1.00132408"},
        {"Smithsonian Astrophysical Observation", "SAO 83601"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.55304299),
        dec: Angle.Degrees(+26.81691868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246746"},
        {"Hipparcos Number", "HIP 27012"},
        {"Geneva Identification System", "GEN# +1.00246746"},
        {"Smithsonian Astrophysical Observation", "SAO 77464"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.94461150),
        dec: Angle.Degrees(+26.81923841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198266"},
        {"Hipparcos Number", "HIP 102683"},
        {"Smithsonian Astrophysical Observation", "SAO 89148"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10488413),
        dec: Angle.Degrees(+26.82032777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56761"},
        {"Hipparcos Number", "HIP 35494"},
        {"Geneva Identification System", "GEN# +1.00056761"},
        {"Smithsonian Astrophysical Observation", "SAO 79286"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.87825394),
        dec: Angle.Degrees(+26.82291456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108382"},
        {"Hipparcos Number", "HIP 60746"},
        {"Geneva Identification System", "GEN# +5.21110130"},
        {"Renson", "Renson 31480"},
        {"Smithsonian Astrophysical Observation", "SAO 82314"},
        {"Wilson Evans Batten Catalogue", "WEB 10806"},
    },
    visualMagnitude: 4.98,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.74710034),
        dec: Angle.Degrees(+26.82572160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75419"},
        {"Hipparcos Number", "HIP 43430"},
        {"Geneva Identification System", "GEN# +1.00075419"},
        {"Smithsonian Astrophysical Observation", "SAO 80454"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.69232457),
        dec: Angle.Degrees(+26.82688561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82331"},
        {"Hipparcos Number", "HIP 46787"},
        {"Geneva Identification System", "GEN# +1.00082331"},
        {"Smithsonian Astrophysical Observation", "SAO 80889"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.01671436),
        dec: Angle.Degrees(+26.82793835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156002"},
        {"Hipparcos Number", "HIP 84298"},
        {"Smithsonian Astrophysical Observation", "SAO 84943"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.51672221),
        dec: Angle.Degrees(+26.82878088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61957"},
        {"Geneva Identification System", "GEN# +0.02702161"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.46259816),
        dec: Angle.Degrees(+26.82988637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15548 A"},
        {"Henry Draper", "HD 209223"},
        {"Hipparcos Number", "HIP 108700"},
        {"Smithsonian Astrophysical Observation", "SAO 90171"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.29763767),
        dec: Angle.Degrees(+26.83020886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97211"},
        {"Hipparcos Number", "HIP 54685"},
        {"Geneva Identification System", "GEN# +1.00097211"},
        {"Smithsonian Astrophysical Observation", "SAO 81713"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.92505031),
        dec: Angle.Degrees(+26.83197097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337206"},
        {"Hipparcos Number", "HIP 93043"},
        {"Smithsonian Astrophysical Observation", "SAO 86621"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.29650855),
        dec: Angle.Degrees(+26.83205865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103966"},
        {"Hipparcos Number", "HIP 58396"},
        {"Geneva Identification System", "GEN# +1.00103966"},
        {"Renson", "Renson 30050"},
        {"Smithsonian Astrophysical Observation", "SAO 82082"},
        {"Wilson Evans Batten Catalogue", "WEB 10438"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.61248878),
        dec: Angle.Degrees(+26.83735699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337815"},
        {"Hipparcos Number", "HIP 94282"},
        {"Smithsonian Astrophysical Observation", "SAO 86910"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.85074708),
        dec: Angle.Degrees(+26.83755439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12845"},
        {"Hipparcos Number", "HIP 9833"},
        {"Smithsonian Astrophysical Observation", "SAO 75143"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.63214628),
        dec: Angle.Degrees(+26.83763203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9578 AB"},
        {"Henry Draper", "HD 136176"},
        {"Hipparcos Number", "HIP 74893"},
        {"Geneva Identification System", "GEN# +1.00136176"},
        {"Smithsonian Astrophysical Observation", "SAO 83756"},
        {"Wilson Evans Batten Catalogue", "WEB 12771"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.58414001),
        dec: Angle.Degrees(+26.84019551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117124"},
        {"Hipparcos Number", "HIP 65670"},
        {"Geneva Identification System", "GEN# +1.00117124"},
        {"Smithsonian Astrophysical Observation", "SAO 82854"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.98015805),
        dec: Angle.Degrees(+26.84156714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19332"},
        {"Wilson Evans Batten Catalogue", "WEB 3712"},
    },
    visualMagnitude: 11.00,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.14111242),
        dec: Angle.Degrees(+26.84306216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340345"},
        {"Hipparcos Number", "HIP 101150"},
        {"Geneva Identification System", "GEN# +1.00340345J"},
        {"Wilson Evans Batten Catalogue", "WEB 18271"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.54486771),
        dec: Angle.Degrees(+26.84310641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57400"},
        {"Geneva Identification System", "GEN# +0.02702053"},
        {"Smithsonian Astrophysical Observation", "SAO 81977"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.51826565),
        dec: Angle.Degrees(+26.84400567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140455"},
        {"Hipparcos Number", "HIP 76950"},
        {"Smithsonian Astrophysical Observation", "SAO 83957"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.67972424),
        dec: Angle.Degrees(+26.84450716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170004"},
        {"Hipparcos Number", "HIP 90352"},
        {"Smithsonian Astrophysical Observation", "SAO 86044"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.53789279),
        dec: Angle.Degrees(+26.84474682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19750"},
        {"Hipparcos Number", "HIP 14831"},
        {"Smithsonian Astrophysical Observation", "SAO 75779"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.87760321),
        dec: Angle.Degrees(+26.84593411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41469"},
        {"Smithsonian Astrophysical Observation", "SAO 80197"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88071567),
        dec: Angle.Degrees(+26.84622647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215620"},
        {"Hipparcos Number", "HIP 112416"},
        {"Geneva Identification System", "GEN# +1.00215620"},
        {"Smithsonian Astrophysical Observation", "SAO 90773"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.54061603),
        dec: Angle.Degrees(+26.84658126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80650"},
        {"Hipparcos Number", "HIP 45914"},
        {"Smithsonian Astrophysical Observation", "SAO 80783"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.43009983),
        dec: Angle.Degrees(+26.84664944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218935"},
        {"Hipparcos Number", "HIP 114526"},
        {"Geneva Identification System", "GEN# +1.00218935"},
        {"Smithsonian Astrophysical Observation", "SAO 91080"},
        {"Wilson Evans Batten Catalogue", "WEB 20325"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.95547912),
        dec: Angle.Degrees(+26.84757838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16740",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2627 A"},
        {"Henry Draper", "HD 22181"},
        {"Hipparcos Number", "HIP 16740"},
        {"Smithsonian Astrophysical Observation", "SAO 76011"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.83501350),
        dec: Angle.Degrees(+26.85018583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338183"},
        {"Hipparcos Number", "HIP 95018"},
        {"Smithsonian Astrophysical Observation", "SAO 87079"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.00693328),
        dec: Angle.Degrees(+26.85094876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85946"},
        {"Hipparcos Number", "HIP 48696"},
        {"Smithsonian Astrophysical Observation", "SAO 81088"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.96592154),
        dec: Angle.Degrees(+26.85116667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16742",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2627 B"},
        {"Hipparcos Number", "HIP 16742"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.83879684),
        dec: Angle.Degrees(+26.85276524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143271"},
        {"Hipparcos Number", "HIP 78234"},
        {"Smithsonian Astrophysical Observation", "SAO 84109"},
        {"Wilson Evans Batten Catalogue", "WEB 13230"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.62688683),
        dec: Angle.Degrees(+26.85315155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40002"},
        {"Hipparcos Number", "HIP 28185"},
        {"Smithsonian Astrophysical Observation", "SAO 77759"},
        {"Wilson Evans Batten Catalogue", "WEB 5515"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.33039672),
        dec: Angle.Degrees(+26.85350623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54801"},
        {"Hipparcos Number", "HIP 34722"},
        {"Fundamental Katalog 5th Edition", "FK5 2553"},
        {"Geneva Identification System", "GEN# +1.00054801"},
        {"Smithsonian Astrophysical Observation", "SAO 79141"},
        {"Wilson Evans Batten Catalogue", "WEB 6940"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.84616679),
        dec: Angle.Degrees(+26.85666896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283921"},
        {"Hipparcos Number", "HIP 22600"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.93801050),
        dec: Angle.Degrees(+26.86234652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180615"},
        {"Hipparcos Number", "HIP 94696"},
        {"Geneva Identification System", "GEN# +1.00180615"},
        {"Smithsonian Astrophysical Observation", "SAO 87012"},
        {"Wilson Evans Batten Catalogue", "WEB 16513"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.03612727),
        dec: Angle.Degrees(+26.86860808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2562"},
        {"Hipparcos Number", "HIP 2301"},
        {"Geneva Identification System", "GEN# +1.00002562"},
        {"Smithsonian Astrophysical Observation", "SAO 74036"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.33872711),
        dec: Angle.Degrees(+26.87171075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18143"},
        {"Hipparcos Number", "HIP 13642"},
        {"Cincinnati Publication", "Ci 18 377"},
        {"Geneva Identification System", "GEN# +1.00018143J"},
        {"Smithsonian Astrophysical Observation", "SAO 75644"},
        {"Wilson Evans Batten Catalogue", "WEB 2707"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.91202372),
        dec: Angle.Degrees(+26.87368205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 262.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51275"},
        {"Hipparcos Number", "HIP 33501"},
        {"Smithsonian Astrophysical Observation", "SAO 78909"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.45223459),
        dec: Angle.Degrees(+26.87386652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75225"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.58935075),
        dec: Angle.Degrees(+26.87713141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9859 A"},
        {"Henry Draper", "HD 143107"},
        {"Hipparcos Number", "HIP 78159"},
        {"Fundamental Katalog 5th Edition", "FK5 593"},
        {"Geneva Identification System", "GEN# +1.00143107"},
        {"Smithsonian Astrophysical Observation", "SAO 84098"},
        {"Wilson Evans Batten Catalogue", "WEB 13217"},
    },
    visualMagnitude: 4.14,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.39709121),
        dec: Angle.Degrees(+26.87802632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8646"},
        {"Hipparcos Number", "HIP 6678"},
        {"Smithsonian Astrophysical Observation", "SAO 74708"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.41696728),
        dec: Angle.Degrees(+26.87832215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51886"},
        {"Hipparcos Number", "HIP 33712"},
        {"Smithsonian Astrophysical Observation", "SAO 78957"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.06164125),
        dec: Angle.Degrees(+26.87838762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158067"},
        {"Hipparcos Number", "HIP 85313"},
        {"Fundamental Katalog 5th Edition", "FK5 3387"},
        {"Geneva Identification System", "GEN# +1.00158067"},
        {"Smithsonian Astrophysical Observation", "SAO 85080"},
        {"Wilson Evans Batten Catalogue", "WEB 14404"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.50359570),
        dec: Angle.Degrees(+26.87868518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45178",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7231 AB"},
        {"Hipparcos Number", "HIP 45178"},
        {"Smithsonian Astrophysical Observation", "SAO 80691"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.09823069),
        dec: Angle.Degrees(+26.87906508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114839"},
        {"Hipparcos Number", "HIP 64463"},
        {"Geneva Identification System", "GEN# +1.00114839"},
        {"Renson", "Renson 33220"},
        {"Smithsonian Astrophysical Observation", "SAO 82715"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.19775550),
        dec: Angle.Degrees(+26.88119199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81019"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.19156852),
        dec: Angle.Degrees(+26.88291212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284074"},
        {"Hipparcos Number", "HIP 23634"},
        {"Smithsonian Astrophysical Observation", "SAO 76946"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20980383),
        dec: Angle.Degrees(+26.88330232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55320"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.92602541),
        dec: Angle.Degrees(+26.88358048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80594",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10066 AB"},
        {"Henry Draper", "HD 148466"},
        {"Hipparcos Number", "HIP 80594"},
        {"Smithsonian Astrophysical Observation", "SAO 84384"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.82750648),
        dec: Angle.Degrees(+26.88587162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89630"},
        {"Hipparcos Number", "HIP 50700"},
        {"Geneva Identification System", "GEN# +1.00089630"},
        {"Smithsonian Astrophysical Observation", "SAO 81307"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.29270253),
        dec: Angle.Degrees(+26.88607263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17140"},
        {"Smithsonian Astrophysical Observation", "SAO 76063"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.05799168),
        dec: Angle.Degrees(+26.88745105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18561"},
        {"Hipparcos Number", "HIP 13973"},
        {"Fundamental Katalog 5th Edition", "FK5 4273"},
        {"Smithsonian Astrophysical Observation", "SAO 75677"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.99192010),
        dec: Angle.Degrees(+26.88868233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39303"},
        {"Smithsonian Astrophysical Observation", "SAO 79878"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.53798956),
        dec: Angle.Degrees(+26.88959179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190257"},
        {"Hipparcos Number", "HIP 98726"},
        {"Smithsonian Astrophysical Observation", "SAO 88121"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.77398848),
        dec: Angle.Degrees(+26.89201545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145676"},
        {"Hipparcos Number", "HIP 79305"},
        {"Geneva Identification System", "GEN# +1.00145676"},
        {"Smithsonian Astrophysical Observation", "SAO 84233"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.78287124),
        dec: Angle.Degrees(+26.89236093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114616"},
        {"Smithsonian Astrophysical Observation", "SAO 91097"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.29550686),
        dec: Angle.Degrees(+26.89276508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123859"},
        {"Hipparcos Number", "HIP 69169"},
        {"Geneva Identification System", "GEN# +1.00123859"},
        {"Smithsonian Astrophysical Observation", "SAO 83197"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.37713418),
        dec: Angle.Degrees(+26.89400992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24399"},
        {"Hipparcos Number", "HIP 18230"},
        {"Geneva Identification System", "GEN# +1.00024399"},
        {"Smithsonian Astrophysical Observation", "SAO 76307"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.45962253),
        dec: Angle.Degrees(+26.89588252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192022"},
        {"Hipparcos Number", "HIP 99520"},
        {"Geneva Identification System", "GEN# +2.68820004"},
        {"Smithsonian Astrophysical Observation", "SAO 88331"},
        {"Wilson Evans Batten Catalogue", "WEB 17799"},
        {"New General Catalogue", "NGC 6882 4"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.96108780),
        dec: Angle.Degrees(+26.89595896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60522"},
        {"Hipparcos Number", "HIP 36962"},
        {"Fundamental Katalog 5th Edition", "FK5 1196"},
        {"Geneva Identification System", "GEN# +1.00060522"},
        {"Smithsonian Astrophysical Observation", "SAO 79533"},
        {"Wilson Evans Batten Catalogue", "WEB 7335"},
    },
    visualMagnitude: 4.06,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.98071783),
        dec: Angle.Degrees(+26.89600343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19637"},
        {"Hipparcos Number", "HIP 14748"},
        {"Geneva Identification System", "GEN# +1.00019637"},
        {"Smithsonian Astrophysical Observation", "SAO 75771"},
        {"Wilson Evans Batten Catalogue", "WEB 2855"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.61268192),
        dec: Angle.Degrees(+26.89607076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20900"},
        {"Hipparcos Number", "HIP 15760"},
        {"Smithsonian Astrophysical Observation", "SAO 75903"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.77053606),
        dec: Angle.Degrees(+26.90098306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20194"},
        {"Hipparcos Number", "HIP 15177"},
        {"Geneva Identification System", "GEN# +1.00020194"},
        {"Smithsonian Astrophysical Observation", "SAO 75814"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.89400882),
        dec: Angle.Degrees(+26.90343458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341349"},
        {"Hipparcos Number", "HIP 103513"},
        {"Smithsonian Astrophysical Observation", "SAO 89336"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.57335271),
        dec: Angle.Degrees(+26.90354962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198438"},
        {"Hipparcos Number", "HIP 102806"},
        {"Smithsonian Astrophysical Observation", "SAO 89173"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.41071631),
        dec: Angle.Degrees(+26.90409665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191747"},
        {"Hipparcos Number", "HIP 99404"},
        {"Geneva Identification System", "GEN# +2.68820002"},
        {"Smithsonian Astrophysical Observation", "SAO 88295"},
        {"Wilson Evans Batten Catalogue", "WEB 17747"},
        {"New General Catalogue", "NGC 6882 2"},
    },
    visualMagnitude: 5.51,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.63968695),
        dec: Angle.Degrees(+26.90413736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82995"},
        {"Geneva Identification System", "GEN# +0.02702725"},
        {"Smithsonian Astrophysical Observation", "SAO 84725"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.40152526),
        dec: Angle.Degrees(+26.90505675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 241.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47196"},
        {"Hipparcos Number", "HIP 31759"},
        {"Smithsonian Astrophysical Observation", "SAO 78576"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.64799519),
        dec: Angle.Degrees(+26.90547981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48405"},
        {"Smithsonian Astrophysical Observation", "SAO 81057"},
        {"Wilson Evans Batten Catalogue", "WEB 9027"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.03488517),
        dec: Angle.Degrees(+26.90629275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93391"},
        {"Hipparcos Number", "HIP 52770"},
        {"Geneva Identification System", "GEN# +1.00093391"},
        {"Smithsonian Astrophysical Observation", "SAO 81523"},
        {"Wilson Evans Batten Catalogue", "WEB 9605"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.84534393),
        dec: Angle.Degrees(+26.91062073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218610"},
        {"Hipparcos Number", "HIP 114321"},
        {"Smithsonian Astrophysical Observation", "SAO 91043"},
        {"Wilson Evans Batten Catalogue", "WEB 20297"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.29027284),
        dec: Angle.Degrees(+26.91298015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75935"},
        {"Hipparcos Number", "HIP 43670"},
        {"Geneva Identification System", "GEN# +1.00075935"},
        {"Smithsonian Astrophysical Observation", "SAO 80487"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.45804720),
        dec: Angle.Degrees(+26.91325629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336003"},
        {"Hipparcos Number", "HIP 89993"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.43356814),
        dec: Angle.Degrees(+26.91408232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105022"},
    },
    visualMagnitude: 9.85,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.09097662),
        dec: Angle.Degrees(+26.91528895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11740"},
        {"Smithsonian Astrophysical Observation", "SAO 75418"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.87918028),
        dec: Angle.Degrees(+26.91577933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150682"},
        {"Hipparcos Number", "HIP 81729"},
        {"Geneva Identification System", "GEN# +1.00150682"},
        {"Smithsonian Astrophysical Observation", "SAO 84543"},
        {"Wilson Evans Batten Catalogue", "WEB 13806"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.40291009),
        dec: Angle.Degrees(+26.91698945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224758"},
        {"Hipparcos Number", "HIP 34"},
        {"Geneva Identification System", "GEN# +1.00224758"},
        {"Smithsonian Astrophysical Observation", "SAO 91648"},
        {"Wilson Evans Batten Catalogue", "WEB 4"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.09946973),
        dec: Angle.Degrees(+26.91823821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99996"},
        {"Hipparcos Number", "HIP 56142"},
        {"Geneva Identification System", "GEN# +1.00099996"},
        {"Smithsonian Astrophysical Observation", "SAO 81859"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.61203981),
        dec: Angle.Degrees(+26.92291339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4759"},
        {"Hipparcos Number", "HIP 3890"},
        {"Smithsonian Astrophysical Observation", "SAO 74297"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.48023049),
        dec: Angle.Degrees(+26.92295460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90682"},
        {"Hipparcos Number", "HIP 51303"},
        {"Smithsonian Astrophysical Observation", "SAO 81370"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.18658984),
        dec: Angle.Degrees(+26.92327859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76010"},
        {"Hipparcos Number", "HIP 43729"},
        {"Smithsonian Astrophysical Observation", "SAO 80495"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.58864567),
        dec: Angle.Degrees(+26.92379619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140067"},
        {"Hipparcos Number", "HIP 76794"},
        {"Smithsonian Astrophysical Observation", "SAO 83939"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.19007550),
        dec: Angle.Degrees(+26.92420881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201051"},
        {"Hipparcos Number", "HIP 104172"},
        {"Fundamental Katalog 5th Edition", "FK5 3686"},
        {"Geneva Identification System", "GEN# +1.00201051"},
        {"Smithsonian Astrophysical Observation", "SAO 89459"},
        {"Wilson Evans Batten Catalogue", "WEB 18975"},
    },
    visualMagnitude: 6.13,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.59771242),
        dec: Angle.Degrees(+26.92440789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84560"},
        {"Hipparcos Number", "HIP 47976"},
        {"Smithsonian Astrophysical Observation", "SAO 81012"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.68632420),
        dec: Angle.Degrees(+26.92443851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4208 AB"},
        {"Henry Draper", "HD 37098"},
        {"Hipparcos Number", "HIP 26396"},
        {"Geneva Identification System", "GEN# +1.00037098"},
        {"Smithsonian Astrophysical Observation", "SAO 77322"},
        {"Wilson Evans Batten Catalogue", "WEB 5203"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.28682553),
        dec: Angle.Degrees(+26.92452823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12721"},
        {"Smithsonian Astrophysical Observation", "SAO 75533"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.87190808),
        dec: Angle.Degrees(+26.92684365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20680"},
        {"Hipparcos Number", "HIP 15575"},
        {"Geneva Identification System", "GEN# +1.00020680"},
        {"Smithsonian Astrophysical Observation", "SAO 75879"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.15957311),
        dec: Angle.Degrees(+26.92737292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59107"},
        {"Hipparcos Number", "HIP 36416"},
        {"Smithsonian Astrophysical Observation", "SAO 79431"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.38342290),
        dec: Angle.Degrees(+26.92850737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114543"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.02717416),
        dec: Angle.Degrees(+26.92969136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50878"},
        {"Smithsonian Astrophysical Observation", "SAO 81325"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.83192926),
        dec: Angle.Degrees(+26.92988647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58175"},
        {"Smithsonian Astrophysical Observation", "SAO 82056"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.97636565),
        dec: Angle.Degrees(+26.93001633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87852"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.20671638),
        dec: Angle.Degrees(+26.93164752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186395"},
        {"Hipparcos Number", "HIP 97025"},
        {"Geneva Identification System", "GEN# +1.00186395"},
        {"Smithsonian Astrophysical Observation", "SAO 87623"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.77969090),
        dec: Angle.Degrees(+26.93180530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181359"},
        {"Hipparcos Number", "HIP 94942"},
        {"Smithsonian Astrophysical Observation", "SAO 87062"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.79467189),
        dec: Angle.Degrees(+26.93205571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212047"},
        {"Hipparcos Number", "HIP 110346"},
        {"Geneva Identification System", "GEN# +1.00212047"},
        {"Smithsonian Astrophysical Observation", "SAO 90437"},
        {"Wilson Evans Batten Catalogue", "WEB 19790"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25019994),
        dec: Angle.Degrees(+26.93518051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6815 AB"},
        {"Henry Draper", "HD 71150J"},
        {"Hipparcos Number", "HIP 41404"},
        {"Geneva Identification System", "GEN# +1.00071150"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.69614859),
        dec: Angle.Degrees(+26.93548570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83604"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.33118426),
        dec: Angle.Degrees(+26.93608368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -245.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211606"},
        {"Hipparcos Number", "HIP 110073"},
        {"Fundamental Katalog 5th Edition", "FK5 3783"},
        {"Geneva Identification System", "GEN# +1.00211606"},
        {"Smithsonian Astrophysical Observation", "SAO 90396"},
        {"Wilson Evans Batten Catalogue", "WEB 19759"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.44711848),
        dec: Angle.Degrees(+26.93653781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156774"},
        {"Hipparcos Number", "HIP 84659"},
        {"Geneva Identification System", "GEN# +1.00156774"},
        {"Smithsonian Astrophysical Observation", "SAO 84995"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.60222988),
        dec: Angle.Degrees(+26.93696234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35998"},
        {"Hipparcos Number", "HIP 25736"},
        {"Renson", "Renson 9268"},
        {"Smithsonian Astrophysical Observation", "SAO 77206"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.43248822),
        dec: Angle.Degrees(+26.93723002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102809"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.42027332),
        dec: Angle.Degrees(+26.93910843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 213.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3353 A"},
        {"Henry Draper", "HD 29364A"},
        {"Henry Draper 2", "HD 29364"},
        {"Hipparcos Number", "HIP 21619"},
        {"Smithsonian Astrophysical Observation", "SAO 76682"},
        {"Wilson Evans Batten Catalogue", "WEB 4153"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.62286382),
        dec: Angle.Degrees(+26.93942408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48175"},
        {"Hipparcos Number", "HIP 32194"},
        {"Smithsonian Astrophysical Observation", "SAO 78670"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.81159556),
        dec: Angle.Degrees(+26.94017892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18105"},
        {"Hipparcos Number", "HIP 13605"},
        {"Geneva Identification System", "GEN# +1.00018105"},
        {"Smithsonian Astrophysical Observation", "SAO 75636"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.83261058),
        dec: Angle.Degrees(+26.94089642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16729"},
        {"Hipparcos Number", "HIP 12571"},
        {"Smithsonian Astrophysical Observation", "SAO 75522"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.41995235),
        dec: Angle.Degrees(+26.94143819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8791 AB"},
        {"Henry Draper", "HD 114109"},
        {"Hipparcos Number", "HIP 64092"},
        {"Smithsonian Astrophysical Observation", "SAO 82667"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.01309399),
        dec: Angle.Degrees(+26.94686058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133582"},
        {"Hipparcos Number", "HIP 73745"},
        {"Fundamental Katalog 5th Edition", "FK5 557"},
        {"Geneva Identification System", "GEN# +1.00133582"},
        {"Smithsonian Astrophysical Observation", "SAO 83645"},
        {"Wilson Evans Batten Catalogue", "WEB 12607"},
    },
    visualMagnitude: 4.52,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.11190457),
        dec: Angle.Degrees(+26.94765981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339462"},
        {"Hipparcos Number", "HIP 98873"},
        {"Geneva Identification System", "GEN# +1.00339462"},
        {"Smithsonian Astrophysical Observation", "SAO 88157"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.19009604),
        dec: Angle.Degrees(+26.94814784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45705"},
        {"Hipparcos Number", "HIP 30984"},
        {"Geneva Identification System", "GEN# +1.00045705"},
        {"Smithsonian Astrophysical Observation", "SAO 78439"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.53982992),
        dec: Angle.Degrees(+26.94964846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209543"},
        {"Hipparcos Number", "HIP 108904"},
        {"Smithsonian Astrophysical Observation", "SAO 90198"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.90427423),
        dec: Angle.Degrees(+26.95044035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338272"},
        {"Hipparcos Number", "HIP 95427"},
        {"Smithsonian Astrophysical Observation", "SAO 87175"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17310483),
        dec: Angle.Degrees(+26.95051951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5522"},
        {"Smithsonian Astrophysical Observation", "SAO 74534"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.67733434),
        dec: Angle.Degrees(+26.95145118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113069"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.49904423),
        dec: Angle.Degrees(+26.95256727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -320.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101320"},
        {"Hipparcos Number", "HIP 56878"},
        {"Geneva Identification System", "GEN# +1.00101320J"},
        {"Smithsonian Astrophysical Observation", "SAO 81926"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90768809),
        dec: Angle.Degrees(+26.95659325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166436"},
        {"Hipparcos Number", "HIP 88957"},
        {"Smithsonian Astrophysical Observation", "SAO 85785"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.37598510),
        dec: Angle.Degrees(+26.95674581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115603"},
    },
    visualMagnitude: 10.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.26924048),
        dec: Angle.Degrees(+26.95741224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17134"},
        {"Geneva Identification System", "GEN# +0.02600595"},
        {"Smithsonian Astrophysical Observation", "SAO 76062"},
        {"Wilson Evans Batten Catalogue", "WEB 3249"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.04153172),
        dec: Angle.Degrees(+26.96055175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1709",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 298 A"},
        {"Henry Draper", "HD 1716"},
        {"Hipparcos Number", "HIP 1709"},
        {"Smithsonian Astrophysical Observation", "SAO 73921"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.38331785),
        dec: Angle.Degrees(+26.96214466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248087"},
        {"Hipparcos Number", "HIP 27562"},
        {"Smithsonian Astrophysical Observation", "SAO 77615"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.55490831),
        dec: Angle.Degrees(+26.96225434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46671"},
    },
    visualMagnitude: 11.06,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.73116741),
        dec: Angle.Degrees(+26.96447365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176583"},
        {"Hipparcos Number", "HIP 93275"},
        {"Smithsonian Astrophysical Observation", "SAO 86678"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99585762),
        dec: Angle.Degrees(+26.96567320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30402"},
        {"Hipparcos Number", "HIP 22313"},
        {"Smithsonian Astrophysical Observation", "SAO 76764"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.08519958),
        dec: Angle.Degrees(+26.96638294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45504"},
        {"Hipparcos Number", "HIP 30880"},
        {"Fundamental Katalog 5th Edition", "FK5 4588"},
        {"Geneva Identification System", "GEN# +1.00045504"},
        {"Smithsonian Astrophysical Observation", "SAO 78417"},
        {"Wilson Evans Batten Catalogue", "WEB 6153"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.23470629),
        dec: Angle.Degrees(+26.96764519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47741"},
        {"Cincinnati Publication", "Ci 20 546"},
    },
    visualMagnitude: 12.08,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.98330214),
        dec: Angle.Degrees(+26.96924933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -581.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36724"},
        {"Hipparcos Number", "HIP 26192"},
        {"Geneva Identification System", "GEN# +1.00036724"},
        {"Smithsonian Astrophysical Observation", "SAO 77272"},
        {"Wilson Evans Batten Catalogue", "WEB 5106"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.74370550),
        dec: Angle.Degrees(+26.97245209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145374"},
        {"Hipparcos Number", "HIP 79177"},
        {"Smithsonian Astrophysical Observation", "SAO 84220"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.40069789),
        dec: Angle.Degrees(+26.97283653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100821"},
        {"Hipparcos Number", "HIP 56602"},
        {"Smithsonian Astrophysical Observation", "SAO 81894"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.07872776),
        dec: Angle.Degrees(+26.97288902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166279"},
        {"Hipparcos Number", "HIP 88889"},
        {"Smithsonian Astrophysical Observation", "SAO 85771"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.19177653),
        dec: Angle.Degrees(+26.97347906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13398"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.10425820),
        dec: Angle.Degrees(+26.97554256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216502"},
        {"Hipparcos Number", "HIP 113005"},
        {"Smithsonian Astrophysical Observation", "SAO 90852"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.28818793),
        dec: Angle.Degrees(+26.97748666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107877"},
        {"Hipparcos Number", "HIP 60458"},
        {"Geneva Identification System", "GEN# +5.21110101"},
        {"Smithsonian Astrophysical Observation", "SAO 82285"},
        {"Wilson Evans Batten Catalogue", "WEB 10751"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.92090725),
        dec: Angle.Degrees(+26.97995158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67422",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9031 AB"},
        {"Aitken 2", "ADS 9031"},
        {"Henry Draper", "HD 120476"},
        {"Hipparcos Number", "HIP 67422"},
        {"Cincinnati Publication", "Ci 18 1800"},
        {"Cincinnati Publication 2", "Ci 20 812"},
        {"Geneva Identification System", "GEN# +1.00120476"},
        {"Smithsonian Astrophysical Observation", "SAO 83011"},
        {"Wilson Evans Batten Catalogue", "WEB 11858"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.26781460),
        dec: Angle.Degrees(+26.98012928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -427.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283798"},
        {"Hipparcos Number", "HIP 21852"},
        {"Smithsonian Astrophysical Observation", "SAO 76714"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.47981431),
        dec: Angle.Degrees(+26.98044731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36374"},
        {"Hipparcos Number", "HIP 25969"},
        {"Geneva Identification System", "GEN# +1.00036374"},
        {"Smithsonian Astrophysical Observation", "SAO 77237"},
        {"Wilson Evans Batten Catalogue", "WEB 5051"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.11486722),
        dec: Angle.Degrees(+26.98162978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48429",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7551 AB"},
        {"Henry Draper", "HD 85441"},
        {"Hipparcos Number", "HIP 48429"},
        {"Smithsonian Astrophysical Observation", "SAO 81060"},
        {"Wilson Evans Batten Catalogue", "WEB 9032"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.10897773),
        dec: Angle.Degrees(+26.98194018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106514",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106514"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.60400122),
        dec: Angle.Degrees(+26.98212253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184059"},
        {"Hipparcos Number", "HIP 96034"},
        {"Smithsonian Astrophysical Observation", "SAO 87317"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.90156919),
        dec: Angle.Degrees(+26.98657023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1076",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 161 AB"},
        {"Henry Draper", "HD 895"},
        {"Hipparcos Number", "HIP 1076"},
        {"Geneva Identification System", "GEN# +1.00000895J"},
        {"Smithsonian Astrophysical Observation", "SAO 73823"},
        {"Wilson Evans Batten Catalogue", "WEB 187"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.34972158),
        dec: Angle.Degrees(+26.98762497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70071"},
        {"Geneva Identification System", "GEN# +0.02702366"},
        {"Smithsonian Astrophysical Observation", "SAO 83295"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.08610313),
        dec: Angle.Degrees(+26.98835650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100198"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.85303934),
        dec: Angle.Degrees(+36.34008037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82443"},
        {"Hipparcos Number", "HIP 46843"},
        {"Geneva Identification System", "GEN# +1.00082443"},
        {"Smithsonian Astrophysical Observation", "SAO 80897"},
        {"Wilson Evans Batten Catalogue", "WEB 8832"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.18273247),
        dec: Angle.Degrees(+26.98912885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201470"},
        {"Hipparcos Number", "HIP 104406"},
        {"Geneva Identification System", "GEN# +1.00201470"},
        {"Smithsonian Astrophysical Observation", "SAO 89487"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.26338774),
        dec: Angle.Degrees(+26.98949378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193347"},
        {"Hipparcos Number", "HIP 100145"},
        {"Smithsonian Astrophysical Observation", "SAO 88502"},
        {"Wilson Evans Batten Catalogue", "WEB 18034"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.71111875),
        dec: Angle.Degrees(+26.99127487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106992",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106992"},
        {"Smithsonian Astrophysical Observation", "SAO 89892"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.03321403),
        dec: Angle.Degrees(+26.99132125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185856"},
        {"Hipparcos Number", "HIP 96772"},
        {"Smithsonian Astrophysical Observation", "SAO 87538"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05619696),
        dec: Angle.Degrees(+26.99533999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32835"},
        {"Henry Draper 2", "HD 32836"},
        {"Hipparcos Number", "HIP 23814"},
        {"Geneva Identification System", "GEN# +1.00032835"},
        {"Smithsonian Astrophysical Observation", "SAO 76965"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.77144702),
        dec: Angle.Degrees(+26.99593292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65763",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65763"},
        {"Smithsonian Astrophysical Observation", "SAO 82861"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.23381586),
        dec: Angle.Degrees(+26.99677855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246128"},
        {"Hipparcos Number", "HIP 26730"},
        {"Smithsonian Astrophysical Observation", "SAO 77384"},
        {"Wilson Evans Batten Catalogue", "WEB 5273"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.19350067),
        dec: Angle.Degrees(+26.99835517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243610"},
        {"Hipparcos Number", "HIP 25450"},
        {"Smithsonian Astrophysical Observation", "SAO 77171"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.65606313),
        dec: Angle.Degrees(+26.99875330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206991"},
        {"Hipparcos Number", "HIP 107411"},
        {"Smithsonian Astrophysical Observation", "SAO 89963"},
        {"Wilson Evans Batten Catalogue", "WEB 19396"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.33825552),
        dec: Angle.Degrees(+26.99951750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5514"},
        {"Hipparcos Number", "HIP 4467"},
        {"Geneva Identification System", "GEN# +1.00005514"},
        {"Smithsonian Astrophysical Observation", "SAO 74389"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.31330835),
        dec: Angle.Degrees(+26.99954131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188366"},
        {"Hipparcos Number", "HIP 97903"},
        {"Geneva Identification System", "GEN# +1.00188366"},
        {"Smithsonian Astrophysical Observation", "SAO 87894"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.43882516),
        dec: Angle.Degrees(+26.99990400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11841 A"},
        {"Henry Draper", "HD 337202"},
        {"Hipparcos Number", "HIP 92863"},
        {"Smithsonian Astrophysical Observation", "SAO 86586"},
        {"Wilson Evans Batten Catalogue", "WEB 16076"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.83482638),
        dec: Angle.Degrees(+27.00270509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49537"},
        {"Hipparcos Number", "HIP 32777"},
        {"Smithsonian Astrophysical Observation", "SAO 78784"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.51028924),
        dec: Angle.Degrees(+27.00353626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16869"},
        {"Hipparcos Number", "HIP 12696"},
        {"Smithsonian Astrophysical Observation", "SAO 75530"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.77016436),
        dec: Angle.Degrees(+27.00409453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52764"},
        {"Hipparcos Number", "HIP 34030"},
        {"Geneva Identification System", "GEN# +1.00052764"},
        {"Smithsonian Astrophysical Observation", "SAO 79015"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.90347839),
        dec: Angle.Degrees(+27.00548495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105454",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105454"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.39070577),
        dec: Angle.Degrees(+27.00576160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104621"},
        {"Hipparcos Number", "HIP 58746"},
        {"Geneva Identification System", "GEN# +1.00104621"},
        {"Smithsonian Astrophysical Observation", "SAO 82117"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.73208549),
        dec: Angle.Degrees(+27.00593660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257886"},
        {"Hipparcos Number", "HIP 30893"},
        {"Cincinnati Publication", "Ci 18 803"},
        {"Cincinnati Publication 2", "Ci 20 389"},
        {"Geneva Identification System", "GEN# +1.00257886"},
        {"Smithsonian Astrophysical Observation", "SAO 78422"},
        {"Wilson Evans Batten Catalogue", "WEB 6156"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.27370602),
        dec: Angle.Degrees(+27.00989342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -247.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -418.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30467"},
        {"Hipparcos Number", "HIP 22382"},
        {"Geneva Identification System", "GEN# +1.00030467"},
        {"Smithsonian Astrophysical Observation", "SAO 76770"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.27295356),
        dec: Angle.Degrees(+27.01163966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15152"},
        {"Hipparcos Number", "HIP 11415"},
        {"Geneva Identification System", "GEN# +1.00015152"},
        {"Smithsonian Astrophysical Observation", "SAO 75370"},
        {"Wilson Evans Batten Catalogue", "WEB 2383"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.78023268),
        dec: Angle.Degrees(+27.01257767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67175"},
        {"Hipparcos Number", "HIP 39777"},
        {"Smithsonian Astrophysical Observation", "SAO 79956"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.93332408),
        dec: Angle.Degrees(+27.01328309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136009"},
        {"Hipparcos Number", "HIP 74822"},
        {"Smithsonian Astrophysical Observation", "SAO 83750"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.36909547),
        dec: Angle.Degrees(+27.01619225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78437"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.19976156),
        dec: Angle.Degrees(+27.01833935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213025"},
        {"Hipparcos Number", "HIP 110907"},
        {"Smithsonian Astrophysical Observation", "SAO 90527"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.04645171),
        dec: Angle.Degrees(+27.01888696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116778"},
        {"Smithsonian Astrophysical Observation", "SAO 91411"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.00436027),
        dec: Angle.Degrees(+27.02109125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161268"},
        {"Hipparcos Number", "HIP 86740"},
        {"Smithsonian Astrophysical Observation", "SAO 85362"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.86359276),
        dec: Angle.Degrees(+27.02285562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57480",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57480"},
        {"Geneva Identification System", "GEN# +0.02702055"},
        {"Smithsonian Astrophysical Observation", "SAO 81987"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.73832140),
        dec: Angle.Degrees(+27.02301073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158331"},
        {"Hipparcos Number", "HIP 85437"},
        {"Cincinnati Publication", "Ci 18 2330"},
        {"Geneva Identification System", "GEN# +1.00158331"},
        {"Smithsonian Astrophysical Observation", "SAO 85111"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.89598469),
        dec: Angle.Degrees(+27.02473274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 370.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8553 AB"},
        {"Henry Draper", "HD 108421"},
        {"Hipparcos Number", "HIP 60759"},
        {"Cincinnati Publication", "Ci 18 1571"},
        {"Geneva Identification System", "GEN# +1.00108421"},
        {"Geneva Identification System 2", "GEN# +5.21110133J"},
        {"Smithsonian Astrophysical Observation", "SAO 82315"},
        {"Wilson Evans Batten Catalogue", "WEB 10809"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.80689476),
        dec: Angle.Degrees(+27.02528454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -248.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13934"},
        {"Hipparcos Number", "HIP 10582"},
        {"Smithsonian Astrophysical Observation", "SAO 75247"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.05342110),
        dec: Angle.Degrees(+27.02695380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39909"},
        {"Smithsonian Astrophysical Observation", "SAO 79976"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.26603273),
        dec: Angle.Degrees(+27.02930199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61225"},
        {"Wilson Evans Batten Catalogue", "WEB 10897"},
    },
    visualMagnitude: 11.73,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.19015343),
        dec: Angle.Degrees(+27.02932223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8545",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1456 AB"},
        {"Henry Draper", "HD 11142"},
        {"Hipparcos Number", "HIP 8545"},
        {"Smithsonian Astrophysical Observation", "SAO 74965"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.54862203),
        dec: Angle.Degrees(+27.03306205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9133"},
        {"Smithsonian Astrophysical Observation", "SAO 75049"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.43642130),
        dec: Angle.Degrees(+27.03365439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223424"},
        {"Hipparcos Number", "HIP 117482"},
        {"Smithsonian Astrophysical Observation", "SAO 91516"},
        {"Wilson Evans Batten Catalogue", "WEB 20692"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.33392119),
        dec: Angle.Degrees(+27.03391999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59613"},
        {"Geneva Identification System", "GEN# +5.21110024"},
        {"Smithsonian Astrophysical Observation", "SAO 82194"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.37761033),
        dec: Angle.Degrees(+27.04346176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150102"},
        {"Hipparcos Number", "HIP 81426"},
        {"Fundamental Katalog 5th Edition", "FK5 3318"},
        {"Geneva Identification System", "GEN# +1.00150102"},
        {"Smithsonian Astrophysical Observation", "SAO 84493"},
        {"Wilson Evans Batten Catalogue", "WEB 13761"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.45421779),
        dec: Angle.Degrees(+27.04391689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1079"},
        {"Smithsonian Astrophysical Observation", "SAO 73824"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.36100672),
        dec: Angle.Degrees(+27.04406266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248666"},
        {"Hipparcos Number", "HIP 27817"},
        {"Geneva Identification System", "GEN# +1.00248666"},
        {"Smithsonian Astrophysical Observation", "SAO 77670"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.28938418),
        dec: Angle.Degrees(+27.04451397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83300",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83300"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.36418849),
        dec: Angle.Degrees(+27.04456202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46336"},
        {"Hipparcos Number", "HIP 31310"},
        {"Geneva Identification System", "GEN# +1.00046336"},
        {"Smithsonian Astrophysical Observation", "SAO 78501"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.49151148),
        dec: Angle.Degrees(+27.04479253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109817"},
        {"Smithsonian Astrophysical Observation", "SAO 90347"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.64618677),
        dec: Angle.Degrees(+27.04558640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71143"},
        {"Geneva Identification System", "GEN# +0.02702391"},
        {"Smithsonian Astrophysical Observation", "SAO 83397"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.24628641),
        dec: Angle.Degrees(+27.04857805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25159"},
    },
    visualMagnitude: 11.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75325688),
        dec: Angle.Degrees(+27.04903393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69312"},
        {"Hipparcos Number", "HIP 40603"},
        {"Smithsonian Astrophysical Observation", "SAO 80068"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.34537719),
        dec: Angle.Degrees(+27.04929834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160487"},
        {"Hipparcos Number", "HIP 86382"},
        {"Geneva Identification System", "GEN# +1.00160487"},
        {"Smithsonian Astrophysical Observation", "SAO 85286"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77161201),
        dec: Angle.Degrees(+27.05066848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142898"},
        {"Hipparcos Number", "HIP 78038"},
        {"Smithsonian Astrophysical Observation", "SAO 84084"},
        {"Wilson Evans Batten Catalogue", "WEB 13198"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.01471290),
        dec: Angle.Degrees(+27.05148074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97440"},
        {"Hipparcos Number", "HIP 54798"},
        {"Geneva Identification System", "GEN# +1.00097440"},
        {"Smithsonian Astrophysical Observation", "SAO 81720"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27696449),
        dec: Angle.Degrees(+27.05166374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3370"},
        {"Hipparcos Number", "HIP 2896"},
        {"Geneva Identification System", "GEN# +1.00003370"},
        {"Smithsonian Astrophysical Observation", "SAO 74143"},
        {"Wilson Evans Batten Catalogue", "WEB 521"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.18244268),
        dec: Angle.Degrees(+27.05253658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88020"},
        {"Hipparcos Number", "HIP 49763"},
        {"Geneva Identification System", "GEN# +1.00088020"},
        {"Smithsonian Astrophysical Observation", "SAO 81210"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.37621841),
        dec: Angle.Degrees(+27.05443211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192969"},
        {"Hipparcos Number", "HIP 99961"},
        {"Geneva Identification System", "GEN# +1.00192969"},
        {"Renson", "Renson 53870"},
        {"Smithsonian Astrophysical Observation", "SAO 88452"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.21624215),
        dec: Angle.Degrees(+27.05466869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8519 AB"},
        {"Henry Draper", "HD 107398"},
        {"Hipparcos Number", "HIP 60197"},
        {"Geneva Identification System", "GEN# +5.21110073"},
        {"Wilson Evans Batten Catalogue", "WEB 10704"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.17237629),
        dec: Angle.Degrees(+27.05483793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41455"},
        {"Hipparcos Number", "HIP 28939"},
        {"Geneva Identification System", "GEN# +1.00041455"},
        {"Smithsonian Astrophysical Observation", "SAO 77961"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.62044041),
        dec: Angle.Degrees(+27.05557383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55583"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.78888024),
        dec: Angle.Degrees(+27.05687552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154461"},
        {"Hipparcos Number", "HIP 83549"},
        {"Geneva Identification System", "GEN# +1.00154461"},
        {"Smithsonian Astrophysical Observation", "SAO 84808"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.12855142),
        dec: Angle.Degrees(+27.05884353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2033 A"},
        {"Henry Draper", "HD 16628"},
        {"Hipparcos Number", "HIP 12489"},
        {"Geneva Identification System", "GEN# +1.00016628A"},
        {"Smithsonian Astrophysical Observation", "SAO 75510"},
        {"Wilson Evans Batten Catalogue", "WEB 2553"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.17097186),
        dec: Angle.Degrees(+27.06100903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68280"},
        {"Smithsonian Astrophysical Observation", "SAO 83104"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66797427),
        dec: Angle.Degrees(+27.06216125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24525"},
        {"Hipparcos Number", "HIP 18330"},
        {"Smithsonian Astrophysical Observation", "SAO 76318"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.77883632),
        dec: Angle.Degrees(+27.06457764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109012"},
        {"Hipparcos Number", "HIP 61118"},
        {"Geneva Identification System", "GEN# +5.21110165"},
        {"Smithsonian Astrophysical Observation", "SAO 82353"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.88838399),
        dec: Angle.Degrees(+27.06460029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162688"},
        {"Hipparcos Number", "HIP 87375"},
        {"Geneva Identification System", "GEN# +1.00162688"},
        {"Smithsonian Astrophysical Observation", "SAO 85474"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78741125),
        dec: Angle.Degrees(+27.06841143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57248"},
        {"Hipparcos Number", "HIP 35659"},
        {"Geneva Identification System", "GEN# +1.00057248"},
        {"Smithsonian Astrophysical Observation", "SAO 79315"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.36852682),
        dec: Angle.Degrees(+27.06879804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17382"},
        {"Hipparcos Number", "HIP 13081"},
        {"Cincinnati Publication", "Ci 18 357"},
        {"Geneva Identification System", "GEN# +1.00017382"},
        {"Smithsonian Astrophysical Observation", "SAO 75580"},
        {"Wilson Evans Batten Catalogue", "WEB 2639"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.03737461),
        dec: Angle.Degrees(+27.06894254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20618"},
        {"Hipparcos Number", "HIP 15514"},
        {"Geneva Identification System", "GEN# +1.00020618"},
        {"Smithsonian Astrophysical Observation", "SAO 75863"},
        {"Wilson Evans Batten Catalogue", "WEB 2980"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.98255370),
        dec: Angle.Degrees(+27.07130717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146046"},
        {"Hipparcos Number", "HIP 79483"},
        {"Smithsonian Astrophysical Observation", "SAO 84252"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.30681860),
        dec: Angle.Degrees(+27.07217145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72105",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Izar"},
        {"Aitken", "ADS 9372 AB"},
        {"Hipparcos Number", "HIP 72105"},
        {"Geneva Identification System", "GEN# +1.00129989J"},
    },
    visualMagnitude: 2.35,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.24687869),
        dec: Angle.Degrees(+27.07417383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196674"},
        {"Hipparcos Number", "HIP 101821"},
        {"Geneva Identification System", "GEN# +1.00196674"},
        {"Smithsonian Astrophysical Observation", "SAO 88929"},
        {"Wilson Evans Batten Catalogue", "WEB 18397"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.51689582),
        dec: Angle.Degrees(+27.07883744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64492"},
        {"Hipparcos Number", "HIP 38679"},
        {"Smithsonian Astrophysical Observation", "SAO 79793"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.78590620),
        dec: Angle.Degrees(+27.07976897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133459"},
        {"Hipparcos Number", "HIP 73699"},
        {"Smithsonian Astrophysical Observation", "SAO 83638"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95536524),
        dec: Angle.Degrees(+27.08117836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47836"},
        {"Hipparcos Number", "HIP 32044"},
        {"Geneva Identification System", "GEN# +1.00047836"},
        {"Smithsonian Astrophysical Observation", "SAO 78643"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.42809859),
        dec: Angle.Degrees(+27.08157738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242581"},
        {"Hipparcos Number", "HIP 24869"},
        {"Smithsonian Astrophysical Observation", "SAO 77108"},
        {"Wilson Evans Batten Catalogue", "WEB 4817"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.97175316),
        dec: Angle.Degrees(+27.08255109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224930"},
        {"Hipparcos Number", "HIP 171"},
        {"Cincinnati Publication", "Ci 20 1473"},
        {"Geneva Identification System", "GEN# +1.00224930"},
        {"Smithsonian Astrophysical Observation", "SAO 91669"},
        {"Wilson Evans Batten Catalogue", "WEB 27"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.54018776),
        dec: Angle.Degrees(+27.08448905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 778.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -918.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12547"},
        {"Hipparcos Number", "HIP 9623"},
        {"Smithsonian Astrophysical Observation", "SAO 75117"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.92075630),
        dec: Angle.Degrees(+27.08477929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187614"},
        {"Hipparcos Number", "HIP 97573"},
        {"Geneva Identification System", "GEN# +1.00187614"},
        {"Smithsonian Astrophysical Observation", "SAO 87785"},
        {"Wilson Evans Batten Catalogue", "WEB 17158"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.48252498),
        dec: Angle.Degrees(+27.08517105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121183"},
        {"Hipparcos Number", "HIP 67797"},
        {"Geneva Identification System", "GEN# +1.00121183"},
        {"Smithsonian Astrophysical Observation", "SAO 83058"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.32885096),
        dec: Angle.Degrees(+27.08710516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67709"},
        {"Hipparcos Number", "HIP 40009"},
        {"Smithsonian Astrophysical Observation", "SAO 79990"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.55801980),
        dec: Angle.Degrees(+27.08918270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 536"},
        {"Wilson Evans Batten Catalogue", "WEB 95"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.62196859),
        dec: Angle.Degrees(+27.09013496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339362"},
        {"Hipparcos Number", "HIP 98627"},
        {"Smithsonian Astrophysical Observation", "SAO 88095"},
        {"Wilson Evans Batten Catalogue", "WEB 17445"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.47939574),
        dec: Angle.Degrees(+27.09240993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176800"},
        {"Hipparcos Number", "HIP 93348"},
        {"Smithsonian Astrophysical Observation", "SAO 86694"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.20242028),
        dec: Angle.Degrees(+27.09260883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70455"},
        {"Hipparcos Number", "HIP 41096"},
        {"Fundamental Katalog 5th Edition", "FK5 4753"},
        {"Smithsonian Astrophysical Observation", "SAO 80140"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.76264334),
        dec: Angle.Degrees(+27.09389610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93994",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12079 AB"},
        {"Henry Draper", "HD 178617"},
        {"Hipparcos Number", "HIP 93994"},
        {"Smithsonian Astrophysical Observation", "SAO 86855"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.06747398),
        dec: Angle.Degrees(+27.09424599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168038"},
        {"Hipparcos Number", "HIP 89577"},
        {"Geneva Identification System", "GEN# +1.00168038"},
        {"Smithsonian Astrophysical Observation", "SAO 85887"},
        {"Wilson Evans Batten Catalogue", "WEB 15253"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.18644088),
        dec: Angle.Degrees(+27.09584217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4549"},
        {"Hipparcos Number", "HIP 3720"},
        {"Geneva Identification System", "GEN# +1.00004549"},
        {"Smithsonian Astrophysical Observation", "SAO 74279"},
        {"Wilson Evans Batten Catalogue", "WEB 663"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.93830967),
        dec: Angle.Degrees(+27.09696932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198809"},
        {"Hipparcos Number", "HIP 103004"},
        {"Geneva Identification System", "GEN# +1.00198809"},
        {"Smithsonian Astrophysical Observation", "SAO 89228"},
        {"Wilson Evans Batten Catalogue", "WEB 18697"},
    },
    visualMagnitude: 4.56,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.03218980),
        dec: Angle.Degrees(+27.09712771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2216"},
        {"Smithsonian Astrophysical Observation", "SAO 74017"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.00565637),
        dec: Angle.Degrees(+27.09741256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53827"},
        {"Smithsonian Astrophysical Observation", "SAO 81620"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.19539700),
        dec: Angle.Degrees(+27.09822647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 974"},
        {"Smithsonian Astrophysical Observation", "SAO 73804"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.01599223),
        dec: Angle.Degrees(+27.09915401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 283.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138156"},
        {"Hipparcos Number", "HIP 75823"},
        {"Smithsonian Astrophysical Observation", "SAO 83848"},
        {"Wilson Evans Batten Catalogue", "WEB 12906"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.34197778),
        dec: Angle.Degrees(+27.09939367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155025"},
        {"Hipparcos Number", "HIP 83830"},
        {"Geneva Identification System", "GEN# +1.00155025"},
        {"Smithsonian Astrophysical Observation", "SAO 84864"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.99646010),
        dec: Angle.Degrees(+27.10138782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68774"},
        {"Hipparcos Number", "HIP 40401"},
        {"Geneva Identification System", "GEN# +1.00068774"},
        {"Smithsonian Astrophysical Observation", "SAO 80037"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.71933613),
        dec: Angle.Degrees(+27.10186889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336676"},
        {"Hipparcos Number", "HIP 91543"},
        {"Smithsonian Astrophysical Observation", "SAO 86303"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.02656977),
        dec: Angle.Degrees(+27.10260065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7478 AB"},
        {"Henry Draper", "HD 83729"},
        {"Hipparcos Number", "HIP 47510"},
        {"Smithsonian Astrophysical Observation", "SAO 80967"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29111284),
        dec: Angle.Degrees(+27.10327717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88416"},
        {"Hipparcos Number", "HIP 49993"},
        {"Geneva Identification System", "GEN# +1.00088416"},
        {"Smithsonian Astrophysical Observation", "SAO 81227"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.08455500),
        dec: Angle.Degrees(+27.10379952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73784"},
        {"Hipparcos Number", "HIP 42608"},
        {"Smithsonian Astrophysical Observation", "SAO 80350"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.26078765),
        dec: Angle.Degrees(+27.10468276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111284"},
        {"Hipparcos Number", "HIP 62463"},
        {"Geneva Identification System", "GEN# +1.00111284"},
        {"Smithsonian Astrophysical Observation", "SAO 82502"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.01241178),
        dec: Angle.Degrees(+27.10594691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82446"},
        {"Smithsonian Astrophysical Observation", "SAO 84642"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73715080),
        dec: Angle.Degrees(+27.10676661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89023"},
        {"Hipparcos Number", "HIP 50334"},
        {"Smithsonian Astrophysical Observation", "SAO 81263"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.17036198),
        dec: Angle.Degrees(+27.10710114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242106"},
        {"Hipparcos Number", "HIP 24581"},
        {"Smithsonian Astrophysical Observation", "SAO 77070"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.10559814),
        dec: Angle.Degrees(+27.10806580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184879"},
        {"Hipparcos Number", "HIP 96366"},
        {"Smithsonian Astrophysical Observation", "SAO 87410"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88994916),
        dec: Angle.Degrees(+27.10837429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 830"},
        {"Hipparcos Number", "HIP 1025"},
        {"Smithsonian Astrophysical Observation", "SAO 73816"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.19355537),
        dec: Angle.Degrees(+27.10919668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16259"},
        {"Hipparcos Number", "HIP 12214"},
        {"Smithsonian Astrophysical Observation", "SAO 75472"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.31757565),
        dec: Angle.Degrees(+27.11166100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21701"},
        {"Hipparcos Number", "HIP 16382"},
        {"Smithsonian Astrophysical Observation", "SAO 75963"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.75726211),
        dec: Angle.Degrees(+27.11342959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183259"},
        {"Hipparcos Number", "HIP 95685"},
        {"Smithsonian Astrophysical Observation", "SAO 87239"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.93409653),
        dec: Angle.Degrees(+27.11435928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213633"},
        {"Hipparcos Number", "HIP 111260"},
        {"Smithsonian Astrophysical Observation", "SAO 90579"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.11049232),
        dec: Angle.Degrees(+27.11507869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88525",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11040 A"},
        {"Henry Draper", "HD 165398"},
        {"Hipparcos Number", "HIP 88525"},
        {"Smithsonian Astrophysical Observation", "SAO 85707"},
        {"Wilson Evans Batten Catalogue", "WEB 14982"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.16281645),
        dec: Angle.Degrees(+27.11524886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104088"},
        {"Hipparcos Number", "HIP 58462"},
        {"Geneva Identification System", "GEN# +1.00104088"},
        {"Smithsonian Astrophysical Observation", "SAO 82088"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.83510323),
        dec: Angle.Degrees(+27.11544116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26127"},
        {"Hipparcos Number", "HIP 19382"},
        {"Smithsonian Astrophysical Observation", "SAO 76479"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.28099397),
        dec: Angle.Degrees(+27.11561208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194449"},
        {"Hipparcos Number", "HIP 100678"},
        {"Smithsonian Astrophysical Observation", "SAO 88640"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18163393),
        dec: Angle.Degrees(+27.11614557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68923"},
        {"Geneva Identification System", "GEN# +0.02702332"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.65767850),
        dec: Angle.Degrees(+27.11655941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44541"},
        {"Hipparcos Number", "HIP 30396"},
        {"Smithsonian Astrophysical Observation", "SAO 78309"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.87571117),
        dec: Angle.Degrees(+27.11802250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17175 C"},
        {"Hipparcos Number", "HIP 162"},
        {"Geneva Identification System", "GEN# +1.30224930"},
        {"Smithsonian Astrophysical Observation", "SAO 91668"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51336753),
        dec: Angle.Degrees(+27.11861943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10742"},
        {"Hipparcos Number", "HIP 8207"},
        {"Fundamental Katalog 5th Edition", "FK5 4159"},
        {"Smithsonian Astrophysical Observation", "SAO 74908"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.38903853),
        dec: Angle.Degrees(+27.11910759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212353"},
        {"Hipparcos Number", "HIP 110505"},
        {"Smithsonian Astrophysical Observation", "SAO 90456"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.78059093),
        dec: Angle.Degrees(+27.11920784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112754"},
        {"Hipparcos Number", "HIP 63334"},
        {"Geneva Identification System", "GEN# +1.00112754J"},
        {"Smithsonian Astrophysical Observation", "SAO 82593"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.67948621),
        dec: Angle.Degrees(+27.11948658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214226"},
        {"Hipparcos Number", "HIP 111586"},
        {"Geneva Identification System", "GEN# +1.00214226"},
        {"Smithsonian Astrophysical Observation", "SAO 90634"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.09014063),
        dec: Angle.Degrees(+27.12179071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247989"},
        {"Hipparcos Number", "HIP 27527"},
        {"Cincinnati Publication", "Ci 18 731"},
        {"Smithsonian Astrophysical Observation", "SAO 77608"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.44035109),
        dec: Angle.Degrees(+27.12203652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85983"},
        {"Smithsonian Astrophysical Observation", "SAO 85216"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.59630873),
        dec: Angle.Degrees(+27.12457986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59684"},
        {"Hipparcos Number", "HIP 36647"},
        {"Smithsonian Astrophysical Observation", "SAO 79479"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.05378607),
        dec: Angle.Degrees(+27.12533613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151304"},
        {"Hipparcos Number", "HIP 82043"},
        {"Geneva Identification System", "GEN# +1.00151304"},
        {"Smithsonian Astrophysical Observation", "SAO 84582"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.38605557),
        dec: Angle.Degrees(+27.12607297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97237"},
        {"Cincinnati Publication", "Ci 20 1163"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)45, 45.2400),
        dec: Angle.DegreesMinutesSeconds((int)+27, (int)07, 38.500)
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
    primaryId: "HIP 1848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1848"},
    },
    visualMagnitude: 11.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.83677139),
        dec: Angle.Degrees(+27.12786531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242015"},
        {"Hipparcos Number", "HIP 24546"},
        {"Smithsonian Astrophysical Observation", "SAO 77061"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.98787912),
        dec: Angle.Degrees(+27.12799497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120802"},
        {"Hipparcos Number", "HIP 67608"},
        {"Geneva Identification System", "GEN# +1.00120802"},
        {"Smithsonian Astrophysical Observation", "SAO 83033"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.80020754),
        dec: Angle.Degrees(+27.12878079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341399"},
        {"Hipparcos Number", "HIP 103795"},
        {"Smithsonian Astrophysical Observation", "SAO 89385"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.48466559),
        dec: Angle.Degrees(+27.12993724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13773 AB"},
        {"Henry Draper", "HD 194111"},
        {"Hipparcos Number", "HIP 100510"},
        {"Smithsonian Astrophysical Observation", "SAO 88608"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.71406860),
        dec: Angle.Degrees(+27.13167130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95363"},
        {"Hipparcos Number", "HIP 53850"},
        {"Geneva Identification System", "GEN# +1.00095363"},
        {"Smithsonian Astrophysical Observation", "SAO 81623"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.24000849),
        dec: Angle.Degrees(+27.13220397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283750"},
        {"Hipparcos Number", "HIP 21482"},
        {"Geneva Identification System", "GEN# +5.20253301"},
        {"Smithsonian Astrophysical Observation", "SAO 76672"},
        {"Wilson Evans Batten Catalogue", "WEB 4125"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.20037606),
        dec: Angle.Degrees(+27.13255130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 232.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74603"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.65033415),
        dec: Angle.Degrees(+27.13268283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185983"},
        {"Hipparcos Number", "HIP 96830"},
        {"Geneva Identification System", "GEN# +1.00185983"},
        {"Renson", "Renson 51290"},
        {"Smithsonian Astrophysical Observation", "SAO 87561"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.21653875),
        dec: Angle.Degrees(+27.13296635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7307"},
        {"Hipparcos Number", "HIP 5746"},
        {"Geneva Identification System", "GEN# +1.00007307"},
        {"Smithsonian Astrophysical Observation", "SAO 74573"},
        {"Wilson Evans Batten Catalogue", "WEB 1309"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.44984167),
        dec: Angle.Degrees(+27.13311720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73046"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.92785516),
        dec: Angle.Degrees(+27.13316885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107742"},
        {"Hipparcos Number", "HIP 60364"},
        {"Geneva Identification System", "GEN# +5.21110094"},
        {"Smithsonian Astrophysical Observation", "SAO 82276"},
        {"Wilson Evans Batten Catalogue", "WEB 10739"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.66357712),
        dec: Angle.Degrees(+27.13340568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46354"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.76839067),
        dec: Angle.Degrees(+27.13370389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87065",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87065"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.87786278),
        dec: Angle.Degrees(+27.13384688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156362"},
        {"Hipparcos Number", "HIP 84455"},
        {"Geneva Identification System", "GEN# +1.00156362"},
        {"Smithsonian Astrophysical Observation", "SAO 84958"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99548708),
        dec: Angle.Degrees(+27.13434206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335909"},
        {"Hipparcos Number", "HIP 89704"},
        {"Smithsonian Astrophysical Observation", "SAO 85911"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.61589804),
        dec: Angle.Degrees(+27.13537013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97091",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12850 AB"},
        {"Henry Draper", "HD 186519"},
        {"Henry Draper 2", "HD 186518"},
        {"Hipparcos Number", "HIP 97091"},
        {"Geneva Identification System", "GEN# +1.00186518J"},
        {"Smithsonian Astrophysical Observation", "SAO 87640"},
        {"Wilson Evans Batten Catalogue", "WEB 17043"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.98322359),
        dec: Angle.Degrees(+27.13540609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96827"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.21169817),
        dec: Angle.Degrees(+27.13551496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88639"},
        {"Hipparcos Number", "HIP 50109"},
        {"Geneva Identification System", "GEN# +1.00088639"},
        {"Smithsonian Astrophysical Observation", "SAO 81243"},
        {"Wilson Evans Batten Catalogue", "WEB 9212"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.45718363),
        dec: Angle.Degrees(+27.13582714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154987"},
        {"Hipparcos Number", "HIP 83815"},
        {"Geneva Identification System", "GEN# +1.00154987"},
        {"Smithsonian Astrophysical Observation", "SAO 84861"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.94448562),
        dec: Angle.Degrees(+27.13783573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10682"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.36004175),
        dec: Angle.Degrees(+27.13790124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 200.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138057"},
        {"Hipparcos Number", "HIP 75767"},
        {"Geneva Identification System", "GEN# +1.00138057"},
        {"Smithsonian Astrophysical Observation", "SAO 83844"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.17971599),
        dec: Angle.Degrees(+27.13839256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110297"},
        {"Hipparcos Number", "HIP 61890"},
        {"Geneva Identification System", "GEN# +1.00110297J"},
        {"Smithsonian Astrophysical Observation", "SAO 82439"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.23099758),
        dec: Angle.Degrees(+27.13913979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122237"},
        {"Hipparcos Number", "HIP 68394"},
        {"Smithsonian Astrophysical Observation", "SAO 83124"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.01507634),
        dec: Angle.Degrees(+27.14082284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7061"},
        {"Hipparcos Number", "HIP 5570"},
        {"Smithsonian Astrophysical Observation", "SAO 74543"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.86247959),
        dec: Angle.Degrees(+27.14175881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35191"},
        {"Geneva Identification System", "GEN# +0.02701348"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.08250709),
        dec: Angle.Degrees(+27.14297445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143743"},
        {"Hipparcos Number", "HIP 78470"},
        {"Smithsonian Astrophysical Observation", "SAO 84146"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.28048400),
        dec: Angle.Degrees(+27.14385931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283466"},
        {"Hipparcos Number", "HIP 19592"},
        {"Geneva Identification System", "GEN# +1.00283466"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.98413649),
        dec: Angle.Degrees(+27.14589204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82713"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.60801813),
        dec: Angle.Degrees(+27.15141999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15720"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.61664578),
        dec: Angle.Degrees(+27.15620962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55786"},
        {"Geneva Identification System", "GEN# +0.02702019"},
        {"Smithsonian Astrophysical Observation", "SAO 81820"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.45176715),
        dec: Angle.Degrees(+27.15731695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338872"},
        {"Hipparcos Number", "HIP 97313"},
        {"Geneva Identification System", "GEN# +1.00338872"},
        {"Smithsonian Astrophysical Observation", "SAO 87705"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.65078725),
        dec: Angle.Degrees(+27.15820826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84577"},
        {"Hipparcos Number", "HIP 47991"},
        {"Smithsonian Astrophysical Observation", "SAO 81013"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.72552663),
        dec: Angle.Degrees(+27.15882901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103781"},
        {"Hipparcos Number", "HIP 58284"},
        {"Geneva Identification System", "GEN# +1.00103781"},
        {"Smithsonian Astrophysical Observation", "SAO 82066"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.30200590),
        dec: Angle.Degrees(+27.15969507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182218"},
        {"Hipparcos Number", "HIP 95231"},
        {"Smithsonian Astrophysical Observation", "SAO 87132"},
        {"Wilson Evans Batten Catalogue", "WEB 16639"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.63331482),
        dec: Angle.Degrees(+27.15971962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132737"},
        {"Hipparcos Number", "HIP 73388"},
        {"Smithsonian Astrophysical Observation", "SAO 83609"},
        {"Wilson Evans Batten Catalogue", "WEB 12568"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.96840786),
        dec: Angle.Degrees(+27.16017025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40387"},
        {"Smithsonian Astrophysical Observation", "SAO 80034"},
        {"Wilson Evans Batten Catalogue", "WEB 7873"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.68078544),
        dec: Angle.Degrees(+27.16318318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36575"},
        {"Hipparcos Number", "HIP 26094"},
        {"Smithsonian Astrophysical Observation", "SAO 77258"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.47652084),
        dec: Angle.Degrees(+27.16403714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80356"},
        {"Hipparcos Number", "HIP 45779"},
        {"Geneva Identification System", "GEN# +1.00080356"},
        {"Smithsonian Astrophysical Observation", "SAO 80767"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.01648721),
        dec: Angle.Degrees(+27.16546364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16128"},
        {"Hipparcos Number", "HIP 12124"},
        {"Geneva Identification System", "GEN# +1.00016128"},
        {"Smithsonian Astrophysical Observation", "SAO 75461"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.04080218),
        dec: Angle.Degrees(+27.16687315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117982"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.96838157),
        dec: Angle.Degrees(+27.17415260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139325"},
        {"Hipparcos Number", "HIP 76426"},
        {"Smithsonian Astrophysical Observation", "SAO 83906"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.13910812),
        dec: Angle.Degrees(+27.17482582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97476"},
        {"Hipparcos Number", "HIP 54818"},
        {"Smithsonian Astrophysical Observation", "SAO 81722"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.32648571),
        dec: Angle.Degrees(+27.17502604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151328"},
        {"Hipparcos Number", "HIP 82053"},
        {"Smithsonian Astrophysical Observation", "SAO 84585"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.41298886),
        dec: Angle.Degrees(+27.17703649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223231"},
        {"Hipparcos Number", "HIP 117348"},
        {"Smithsonian Astrophysical Observation", "SAO 91491"},
        {"Wilson Evans Batten Catalogue", "WEB 20674"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.90849651),
        dec: Angle.Degrees(+27.17971439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1756"},
        {"Hipparcos Number", "HIP 1740"},
        {"Renson", "Renson 400"},
        {"Smithsonian Astrophysical Observation", "SAO 73927"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.50023045),
        dec: Angle.Degrees(+27.18595731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3893"},
        {"Hipparcos Number", "HIP 3275"},
        {"Geneva Identification System", "GEN# +1.00003893"},
        {"Smithsonian Astrophysical Observation", "SAO 74201"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.43739585),
        dec: Angle.Degrees(+27.18610789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223154"},
        {"Hipparcos Number", "HIP 117294"},
        {"Geneva Identification System", "GEN# +1.00223154"},
        {"Smithsonian Astrophysical Observation", "SAO 91483"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.74522011),
        dec: Angle.Degrees(+27.18715520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167781"},
        {"Hipparcos Number", "HIP 89481"},
        {"Geneva Identification System", "GEN# +1.00167781"},
        {"Smithsonian Astrophysical Observation", "SAO 85868"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.90827378),
        dec: Angle.Degrees(+27.18853052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2272"},
        {"Hipparcos Number", "HIP 2113"},
        {"Geneva Identification System", "GEN# +1.00002272"},
        {"Smithsonian Astrophysical Observation", "SAO 73992"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.70610629),
        dec: Angle.Degrees(+27.18917289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189884"},
        {"Hipparcos Number", "HIP 98562"},
        {"Smithsonian Astrophysical Observation", "SAO 88078"},
        {"Wilson Evans Batten Catalogue", "WEB 17416"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31255840),
        dec: Angle.Degrees(+27.18961398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49345"},
        {"Hipparcos Number", "HIP 32689"},
        {"Smithsonian Astrophysical Observation", "SAO 78770"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.29248605),
        dec: Angle.Degrees(+27.19048634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120007"},
        {"Hipparcos Number", "HIP 67212"},
        {"Geneva Identification System", "GEN# +1.00120007"},
        {"Smithsonian Astrophysical Observation", "SAO 82990"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.58429230),
        dec: Angle.Degrees(+27.19284794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162950"},
        {"Hipparcos Number", "HIP 87486"},
        {"Geneva Identification System", "GEN# +1.00162950"},
        {"Renson", "Renson 46110"},
        {"Smithsonian Astrophysical Observation", "SAO 85497"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.13393096),
        dec: Angle.Degrees(+27.19373850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
