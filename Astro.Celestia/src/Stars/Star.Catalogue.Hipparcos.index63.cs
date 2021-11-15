using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_63() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7014"},
        {"Hipparcos Number", "HIP 5510"},
        {"Geneva Identification System", "GEN# +1.00007014"},
        {"Smithsonian Astrophysical Observation", "SAO 109715"},
        {"Wilson Evans Batten Catalogue", "WEB 1220"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.63982219),
        dec: Angle.Degrees(+02.44570842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9595"},
        {"Hipparcos Number", "HIP 7312"},
        {"Geneva Identification System", "GEN# +1.00009595"},
        {"Smithsonian Astrophysical Observation", "SAO 109983"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.53165110),
        dec: Angle.Degrees(+02.44658838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161303"},
        {"Hipparcos Number", "HIP 86852"},
        {"Geneva Identification System", "GEN# +1.00161303"},
        {"Smithsonian Astrophysical Observation", "SAO 122696"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.18442764),
        dec: Angle.Degrees(+02.44726426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3707 AB"},
        {"Henry Draper", "HD 33007"},
        {"Hipparcos Number", "HIP 23826"},
        {"Smithsonian Astrophysical Observation", "SAO 112434"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.84178596),
        dec: Angle.Degrees(+02.44847861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198864"},
        {"Hipparcos Number", "HIP 103087"},
        {"Geneva Identification System", "GEN# +1.00198864"},
        {"Smithsonian Astrophysical Observation", "SAO 126335"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.30938098),
        dec: Angle.Degrees(+02.45000043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14689"},
        {"Hipparcos Number", "HIP 11052"},
        {"Smithsonian Astrophysical Observation", "SAO 110497"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.56820321),
        dec: Angle.Degrees(+02.45323563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85504"},
        {"Hipparcos Number", "HIP 48414"},
        {"Geneva Identification System", "GEN# +1.00085504"},
        {"Renson", "Renson 24410"},
        {"Smithsonian Astrophysical Observation", "SAO 117959"},
        {"Wilson Evans Batten Catalogue", "WEB 9029"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.05112987),
        dec: Angle.Degrees(+02.45389890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3116"},
        {"Hipparcos Number", "HIP 2703"},
        {"Smithsonian Astrophysical Observation", "SAO 109285"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.59390140),
        dec: Angle.Degrees(+02.45390604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204690"},
        {"Hipparcos Number", "HIP 106162"},
        {"Geneva Identification System", "GEN# +1.00204690"},
        {"Smithsonian Astrophysical Observation", "SAO 126846"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.56143027),
        dec: Angle.Degrees(+02.45539391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96937"},
        {"Hipparcos Number", "HIP 54541"},
        {"Cincinnati Publication", "Ci 18 1358"},
        {"Geneva Identification System", "GEN# +1.00096937"},
        {"Smithsonian Astrophysical Observation", "SAO 118693"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.41825938),
        dec: Angle.Degrees(+02.45615312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -277.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16687 A"},
        {"Henry Draper", "HD 220062"},
        {"Hipparcos Number", "HIP 115273"},
        {"Smithsonian Astrophysical Observation", "SAO 128132"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.21019751),
        dec: Angle.Degrees(+02.45636603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69151"},
        {"Hipparcos Number", "HIP 40479"},
        {"Geneva Identification System", "GEN# +1.00069151"},
        {"Smithsonian Astrophysical Observation", "SAO 116554"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.97214119),
        dec: Angle.Degrees(+02.45710183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95470",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12414 AB"},
        {"Henry Draper", "HD 182575"},
        {"Hipparcos Number", "HIP 95470"},
        {"Smithsonian Astrophysical Observation", "SAO 124601"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.29701045),
        dec: Angle.Degrees(+02.45733029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20151"},
        {"Hipparcos Number", "HIP 15076"},
        {"Geneva Identification System", "GEN# +1.00020151"},
        {"Smithsonian Astrophysical Observation", "SAO 111067"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.59044791),
        dec: Angle.Degrees(+02.45744252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57133"},
        {"Hipparcos Number", "HIP 35533"},
        {"Geneva Identification System", "GEN# +1.00057133"},
        {"Smithsonian Astrophysical Observation", "SAO 115279"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.99823906),
        dec: Angle.Degrees(+02.46046402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40648",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6726 AB"},
        {"Henry Draper", "HD 69609"},
        {"Hipparcos Number", "HIP 40648"},
        {"Smithsonian Astrophysical Observation", "SAO 116595"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.46653511),
        dec: Angle.Degrees(+02.46170309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175805"},
        {"Hipparcos Number", "HIP 93016"},
        {"Geneva Identification System", "GEN# +1.00175805"},
        {"Smithsonian Astrophysical Observation", "SAO 124083"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.24187208),
        dec: Angle.Degrees(+02.46171706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33140"},
        {"Hipparcos Number", "HIP 23920"},
        {"Geneva Identification System", "GEN# +1.00033140"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.10223098),
        dec: Angle.Degrees(+02.46232492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287823"},
        {"Hipparcos Number", "HIP 25258"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.03353248),
        dec: Angle.Degrees(+02.46302433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100417"},
        {"Hipparcos Number", "HIP 56376"},
        {"Smithsonian Astrophysical Observation", "SAO 118918"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.34434650),
        dec: Angle.Degrees(+02.46382058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117866",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17092 AB"},
        {"Henry Draper", "HD 224004"},
        {"Hipparcos Number", "HIP 117866"},
        {"Smithsonian Astrophysical Observation", "SAO 128456"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.60605469),
        dec: Angle.Degrees(+02.46401319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62318",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8662 A"},
        {"Henry Draper", "HD 111005"},
        {"Hipparcos Number", "HIP 62318"},
        {"Geneva Identification System", "GEN# +1.00111005"},
        {"Renson", "Renson 32260"},
        {"Smithsonian Astrophysical Observation", "SAO 119576"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.56186508),
        dec: Angle.Degrees(+02.46431432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58784"},
        {"Hipparcos Number", "HIP 36196"},
        {"Geneva Identification System", "GEN# +1.00058784"},
        {"Smithsonian Astrophysical Observation", "SAO 115464"},
        {"Wilson Evans Batten Catalogue", "WEB 7208"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.81785733),
        dec: Angle.Degrees(+02.46471322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169266"},
        {"Hipparcos Number", "HIP 90148"},
        {"Geneva Identification System", "GEN# +1.00169266"},
        {"Smithsonian Astrophysical Observation", "SAO 123423"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.95555969),
        dec: Angle.Degrees(+02.46489838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63064"},
        {"Hipparcos Number", "HIP 37994"},
        {"Geneva Identification System", "GEN# +1.00063064"},
        {"Smithsonian Astrophysical Observation", "SAO 115929"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.79721530),
        dec: Angle.Degrees(+02.46510066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9763 C"},
        {"Henry Draper", "HD 140527"},
        {"Hipparcos Number", "HIP 77043"},
        {"Smithsonian Astrophysical Observation", "SAO 121151"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.98230633),
        dec: Angle.Degrees(+02.46710987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199455"},
        {"Hipparcos Number", "HIP 103418"},
        {"Geneva Identification System", "GEN# +1.00199455"},
        {"Smithsonian Astrophysical Observation", "SAO 126397"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.29878731),
        dec: Angle.Degrees(+02.46749818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222521"},
        {"Hipparcos Number", "HIP 116865"},
        {"Smithsonian Astrophysical Observation", "SAO 128329"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32566305),
        dec: Angle.Degrees(+02.46767199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20939"},
        {"Hipparcos Number", "HIP 15732"},
        {"Smithsonian Astrophysical Observation", "SAO 111157"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.67568482),
        dec: Angle.Degrees(+02.46870116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33038"},
        {"Hipparcos Number", "HIP 23843"},
        {"Geneva Identification System", "GEN# +1.00033038"},
        {"Smithsonian Astrophysical Observation", "SAO 112439"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89530815),
        dec: Angle.Degrees(+02.46914730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63776"},
        {"Hipparcos Number", "HIP 38296"},
        {"Geneva Identification System", "GEN# +1.00063776"},
        {"Smithsonian Astrophysical Observation", "SAO 116015"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69498185),
        dec: Angle.Degrees(+02.46923520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10407"},
        {"Smithsonian Astrophysical Observation", "SAO 110418"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.52189262),
        dec: Angle.Degrees(+02.47058004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27271"},
        {"Hipparcos Number", "HIP 20102"},
        {"Geneva Identification System", "GEN# +1.00027271"},
        {"Smithsonian Astrophysical Observation", "SAO 111735"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.64094316),
        dec: Angle.Degrees(+02.47069723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287559"},
        {"Hipparcos Number", "HIP 24166"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.84164587),
        dec: Angle.Degrees(+02.47075751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29403",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4796 AB"},
        {"Henry Draper", "HD 42600"},
        {"Hipparcos Number", "HIP 29403"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.94050342),
        dec: Angle.Degrees(+02.47109179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175679"},
        {"Hipparcos Number", "HIP 92968"},
        {"Geneva Identification System", "GEN# +1.00175679"},
        {"Smithsonian Astrophysical Observation", "SAO 124073"},
        {"Wilson Evans Batten Catalogue", "WEB 16101"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.10665456),
        dec: Angle.Degrees(+02.47120367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7218"},
        {"Hipparcos Number", "HIP 5646"},
        {"Smithsonian Astrophysical Observation", "SAO 109727"},
        {"Wilson Evans Batten Catalogue", "WEB 1272"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.12811650),
        dec: Angle.Degrees(+02.47183263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178742"},
        {"Hipparcos Number", "HIP 94133"},
        {"Smithsonian Astrophysical Observation", "SAO 124334"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.42688483),
        dec: Angle.Degrees(+02.47226903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70226"},
        {"Hipparcos Number", "HIP 40912"},
        {"Smithsonian Astrophysical Observation", "SAO 116656"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.24329294),
        dec: Angle.Degrees(+02.47553801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40512"},
        {"Hipparcos Number", "HIP 28356"},
        {"Fundamental Katalog 5th Edition", "FK5 4544"},
        {"Geneva Identification System", "GEN# +1.00040512"},
        {"Smithsonian Astrophysical Observation", "SAO 113329"},
        {"Wilson Evans Batten Catalogue", "WEB 5544"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.87464496),
        dec: Angle.Degrees(+02.47613161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54853"},
        {"Hipparcos Number", "HIP 34662"},
        {"Smithsonian Astrophysical Observation", "SAO 115037"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.67099709),
        dec: Angle.Degrees(+02.47642675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1310"},
        {"Hipparcos Number", "HIP 1384"},
        {"Smithsonian Astrophysical Observation", "SAO 109109"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.32986623),
        dec: Angle.Degrees(+02.47677783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6470"},
        {"Hipparcos Number", "HIP 5134"},
        {"Smithsonian Astrophysical Observation", "SAO 109665"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.42889090),
        dec: Angle.Degrees(+02.47711531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138735"},
        {"Hipparcos Number", "HIP 76194"},
        {"Smithsonian Astrophysical Observation", "SAO 121062"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.45650493),
        dec: Angle.Degrees(+02.47767827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220796"},
        {"Hipparcos Number", "HIP 115724"},
        {"Smithsonian Astrophysical Observation", "SAO 128184"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68187718),
        dec: Angle.Degrees(+02.47833029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128848"},
        {"Hipparcos Number", "HIP 71643"},
        {"Geneva Identification System", "GEN# +1.00128848"},
        {"Smithsonian Astrophysical Observation", "SAO 120587"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.81604340),
        dec: Angle.Degrees(+02.47917263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204776"},
        {"Hipparcos Number", "HIP 106212"},
        {"Smithsonian Astrophysical Observation", "SAO 126851"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.69688313),
        dec: Angle.Degrees(+02.47970638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165742"},
        {"Hipparcos Number", "HIP 88770"},
        {"Smithsonian Astrophysical Observation", "SAO 123138"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83743785),
        dec: Angle.Degrees(+02.48159614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2331"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.45520410),
        dec: Angle.Degrees(+02.48223820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176650"},
        {"Hipparcos Number", "HIP 93383"},
        {"Geneva Identification System", "GEN# +1.00176650"},
        {"Smithsonian Astrophysical Observation", "SAO 124156"},
        {"Wilson Evans Batten Catalogue", "WEB 16193"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.29761035),
        dec: Angle.Degrees(+02.48285449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177258"},
        {"Hipparcos Number", "HIP 93609"},
        {"Smithsonian Astrophysical Observation", "SAO 124210"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.94404846),
        dec: Angle.Degrees(+02.48361358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77371"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.90768401),
        dec: Angle.Degrees(+02.48492140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5623"},
        {"Hipparcos Number", "HIP 4529"},
        {"Smithsonian Astrophysical Observation", "SAO 109561"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.49616961),
        dec: Angle.Degrees(+02.48633209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212653"},
        {"Hipparcos Number", "HIP 110718"},
        {"Smithsonian Astrophysical Observation", "SAO 127524"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.47976537),
        dec: Angle.Degrees(+02.48684395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8082"},
        {"Hipparcos Number", "HIP 6263"},
        {"Smithsonian Astrophysical Observation", "SAO 109815"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.08265135),
        dec: Angle.Degrees(+02.48770818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93102"},
        {"Hipparcos Number", "HIP 52584"},
        {"Geneva Identification System", "GEN# +1.00093102"},
        {"Smithsonian Astrophysical Observation", "SAO 118473"},
        {"Wilson Evans Batten Catalogue", "WEB 9580"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.28952021),
        dec: Angle.Degrees(+02.48802834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71228"},
        {"Hipparcos Number", "HIP 41366"},
        {"Smithsonian Astrophysical Observation", "SAO 116761"},
        {"Wilson Evans Batten Catalogue", "WEB 8001"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.58386200),
        dec: Angle.Degrees(+02.49018648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27911"},
        {"Hipparcos Number", "HIP 20574"},
        {"Geneva Identification System", "GEN# +1.00027911"},
        {"Smithsonian Astrophysical Observation", "SAO 111797"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.11080651),
        dec: Angle.Degrees(+02.49094973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75078"},
        {"Hipparcos Number", "HIP 43192"},
        {"Geneva Identification System", "GEN# +1.00075078"},
        {"Smithsonian Astrophysical Observation", "SAO 117135"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.99665688),
        dec: Angle.Degrees(+02.49257678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152553"},
        {"Hipparcos Number", "HIP 82659"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.45866637),
        dec: Angle.Degrees(+02.49551394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196346"},
        {"Hipparcos Number", "HIP 101690"},
        {"Smithsonian Astrophysical Observation", "SAO 126012"},
        {"Wilson Evans Batten Catalogue", "WEB 18368"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.17803795),
        dec: Angle.Degrees(+02.49583664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29154",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4749 B"},
        {"Henry Draper", "HD 42092"},
        {"Hipparcos Number", "HIP 29154"},
        {"Geneva Identification System", "GEN# +1.00042092"},
        {"Geneva Identification System 2", "GEN# +1.20042111"},
        {"Smithsonian Astrophysical Observation", "SAO 113509"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.24867494),
        dec: Angle.Degrees(+02.49642266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124627"},
        {"Hipparcos Number", "HIP 69587"},
        {"Smithsonian Astrophysical Observation", "SAO 120360"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.65860717),
        dec: Angle.Degrees(+02.49645818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23976"},
        {"Hipparcos Number", "HIP 17867"},
        {"Smithsonian Astrophysical Observation", "SAO 111438"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.34972481),
        dec: Angle.Degrees(+02.49696499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24347"},
        {"Hipparcos Number", "HIP 18127"},
        {"Smithsonian Astrophysical Observation", "SAO 111470"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.14464126),
        dec: Angle.Degrees(+02.49716140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11456"},
        {"Hipparcos Number", "HIP 8757"},
        {"Smithsonian Astrophysical Observation", "SAO 110193"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.15968421),
        dec: Angle.Degrees(+02.49830635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100456"},
        {"Hipparcos Number", "HIP 56388"},
        {"Smithsonian Astrophysical Observation", "SAO 118923"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.40138864),
        dec: Angle.Degrees(+02.49907231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48914"},
        {"Hipparcos Number", "HIP 32397"},
        {"Geneva Identification System", "GEN# +1.00048914"},
        {"Smithsonian Astrophysical Observation", "SAO 114378"},
        {"Wilson Evans Batten Catalogue", "WEB 6534"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.45824196),
        dec: Angle.Degrees(+02.49928246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4749 A"},
        {"Henry Draper", "HD 42111"},
        {"Hipparcos Number", "HIP 29151"},
        {"Geneva Identification System", "GEN# +1.00042111A"},
        {"Smithsonian Astrophysical Observation", "SAO 113507"},
        {"Wilson Evans Batten Catalogue", "WEB 5717"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.24126844),
        dec: Angle.Degrees(+02.49972675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141610"},
        {"Hipparcos Number", "HIP 77532"},
        {"Smithsonian Astrophysical Observation", "SAO 121210"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.46503576),
        dec: Angle.Degrees(+02.50076509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88601",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11046"},
        {"Aitken 2", "ADS 11046 AB"},
        {"Henry Draper", "HD 165341"},
        {"Hipparcos Number", "HIP 88601"},
        {"Cincinnati Publication", "Ci 20 1073"},
        {"Geneva Identification System", "GEN# +1.00165341"},
        {"Smithsonian Astrophysical Observation", "SAO 123107"},
        {"Wilson Evans Batten Catalogue", "WEB 15004"},
    },
    visualMagnitude: 4.03,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.36338682),
        dec: Angle.Degrees(+02.50243928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -962.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59146"},
        {"Smithsonian Astrophysical Observation", "SAO 119231"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.92341770),
        dec: Angle.Degrees(+02.50314771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10743"},
        {"Hipparcos Number", "HIP 8173"},
        {"Smithsonian Astrophysical Observation", "SAO 110109"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.27071711),
        dec: Angle.Degrees(+02.50318862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76040"},
        {"Hipparcos Number", "HIP 43675"},
        {"Smithsonian Astrophysical Observation", "SAO 117241"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46413404),
        dec: Angle.Degrees(+02.50471213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52201",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52201"},
        {"Smithsonian Astrophysical Observation", "SAO 118419"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.98211319),
        dec: Angle.Degrees(+02.50493683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29717"},
        {"Hipparcos Number", "HIP 21797"},
        {"Geneva Identification System", "GEN# +1.00029717"},
        {"Smithsonian Astrophysical Observation", "SAO 111973"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.24023586),
        dec: Angle.Degrees(+02.50566824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81548"},
        {"Hipparcos Number", "HIP 46294"},
        {"Geneva Identification System", "GEN# +1.00081548"},
        {"Smithsonian Astrophysical Observation", "SAO 117693"},
        {"Wilson Evans Batten Catalogue", "WEB 8758"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.61461494),
        dec: Angle.Degrees(+02.50620796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113000"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.27143193),
        dec: Angle.Degrees(+02.50667247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196039"},
        {"Hipparcos Number", "HIP 101542"},
        {"Smithsonian Astrophysical Observation", "SAO 125972"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68281252),
        dec: Angle.Degrees(+02.50680414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148207"},
        {"Hipparcos Number", "HIP 80527"},
        {"Fundamental Katalog 5th Edition", "FK5 5452"},
        {"Smithsonian Astrophysical Observation", "SAO 121596"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.58836810),
        dec: Angle.Degrees(+02.50779917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25036"},
        {"Hipparcos Number", "HIP 18601"},
        {"Geneva Identification System", "GEN# +1.00025036"},
        {"Smithsonian Astrophysical Observation", "SAO 111539"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.69471968),
        dec: Angle.Degrees(+02.50783068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31139"},
        {"Hipparcos Number", "HIP 22730"},
        {"Geneva Identification System", "GEN# +1.00031139"},
        {"Smithsonian Astrophysical Observation", "SAO 112179"},
        {"Wilson Evans Batten Catalogue", "WEB 4398"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.34481369),
        dec: Angle.Degrees(+02.50826491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52184"},
        {"Hipparcos Number", "HIP 33714"},
        {"Smithsonian Astrophysical Observation", "SAO 114756"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.06586719),
        dec: Angle.Degrees(+02.51218797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120603"},
        {"Hipparcos Number", "HIP 67546"},
        {"Smithsonian Astrophysical Observation", "SAO 120133"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.60953396),
        dec: Angle.Degrees(+02.51277863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34745"},
        {"Hipparcos Number", "HIP 24864"},
        {"Geneva Identification System", "GEN# +1.00034745"},
        {"Smithsonian Astrophysical Observation", "SAO 112633"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.95425507),
        dec: Angle.Degrees(+02.51385191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11008 AB"},
        {"Henry Draper", "HD 164929"},
        {"Hipparcos Number", "HIP 88445"},
        {"Smithsonian Astrophysical Observation", "SAO 123067"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.85978839),
        dec: Angle.Degrees(+02.51462268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9763 A"},
        {"Henry Draper", "HD 140538"},
        {"Hipparcos Number", "HIP 77052"},
        {"Fundamental Katalog 5th Edition", "FK5 3248"},
        {"Geneva Identification System", "GEN# +1.00140538"},
        {"Smithsonian Astrophysical Observation", "SAO 121152"},
        {"Wilson Evans Batten Catalogue", "WEB 13065"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.00769128),
        dec: Angle.Degrees(+02.51552506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91048",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91048"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.59234517),
        dec: Angle.Degrees(+02.52225565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214547"},
        {"Hipparcos Number", "HIP 111821"},
        {"Smithsonian Astrophysical Observation", "SAO 127661"},
        {"Wilson Evans Batten Catalogue", "WEB 19975"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.73910468),
        dec: Angle.Degrees(+02.52237383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69847"},
        {"Hipparcos Number", "HIP 40745"},
        {"Geneva Identification System", "GEN# +1.00069847"},
        {"Smithsonian Astrophysical Observation", "SAO 116615"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.76437122),
        dec: Angle.Degrees(+02.52446517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76583"},
        {"Hipparcos Number", "HIP 43966"},
        {"Geneva Identification System", "GEN# +1.00076583"},
        {"Smithsonian Astrophysical Observation", "SAO 117292"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.30692893),
        dec: Angle.Degrees(+02.52490108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6064"},
        {"Hipparcos Number", "HIP 4825"},
        {"Geneva Identification System", "GEN# +1.00006064"},
        {"Smithsonian Astrophysical Observation", "SAO 109613"},
        {"Wilson Evans Batten Catalogue", "WEB 924"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.49842509),
        dec: Angle.Degrees(+02.52590452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177333"},
        {"Hipparcos Number", "HIP 93643"},
        {"Smithsonian Astrophysical Observation", "SAO 124217"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.03489498),
        dec: Angle.Degrees(+02.52639805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60635"},
        {"Hipparcos Number", "HIP 36931"},
        {"Smithsonian Astrophysical Observation", "SAO 115671"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.88346730),
        dec: Angle.Degrees(+02.52736346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27146"},
        {"Hipparcos Number", "HIP 19994"},
        {"Geneva Identification System", "GEN# +1.00027146"},
        {"Smithsonian Astrophysical Observation", "SAO 111722"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.32248544),
        dec: Angle.Degrees(+02.52972303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46573"},
        {"Hipparcos Number", "HIP 31348"},
        {"Geneva Identification System", "GEN# +1.00046573"},
        {"Smithsonian Astrophysical Observation", "SAO 114075"},
        {"Wilson Evans Batten Catalogue", "WEB 6270"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.59822278),
        dec: Angle.Degrees(+02.53414815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108320"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.17103568),
        dec: Angle.Degrees(+02.53452316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175869"},
        {"Hipparcos Number", "HIP 93051"},
        {"Geneva Identification System", "GEN# +1.00175869"},
        {"Renson", "Renson 49100"},
        {"Smithsonian Astrophysical Observation", "SAO 124089"},
        {"Wilson Evans Batten Catalogue", "WEB 16116"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.31913909),
        dec: Angle.Degrees(+02.53537680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126308"},
        {"Hipparcos Number", "HIP 70450"},
        {"Smithsonian Astrophysical Observation", "SAO 120440"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.16690330),
        dec: Angle.Degrees(+02.53681496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97230"},
        {"Hipparcos Number", "HIP 54678"},
        {"Geneva Identification System", "GEN# +1.00097230"},
        {"Smithsonian Astrophysical Observation", "SAO 118712"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.89039990),
        dec: Angle.Degrees(+02.53695852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45997"},
        {"Hipparcos Number", "HIP 31041"},
        {"Smithsonian Astrophysical Observation", "SAO 113980"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.70568703),
        dec: Angle.Degrees(+02.53803838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64959",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64959"},
        {"Smithsonian Astrophysical Observation", "SAO 119869"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.72549376),
        dec: Angle.Degrees(+02.54359744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65122"},
        {"Hipparcos Number", "HIP 38876"},
        {"Geneva Identification System", "GEN# +1.00065122"},
        {"Smithsonian Astrophysical Observation", "SAO 116166"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.32940796),
        dec: Angle.Degrees(+02.54406373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34878"},
        {"Hipparcos Number", "HIP 24960"},
        {"Geneva Identification System", "GEN# +1.00034878"},
        {"Smithsonian Astrophysical Observation", "SAO 112653"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.18226466),
        dec: Angle.Degrees(+02.54473026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177205"},
        {"Hipparcos Number", "HIP 93589"},
        {"Smithsonian Astrophysical Observation", "SAO 124204"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.89773312),
        dec: Angle.Degrees(+02.54573475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7855"},
        {"Hipparcos Number", "HIP 6096"},
        {"Geneva Identification System", "GEN# +1.00007855"},
        {"Smithsonian Astrophysical Observation", "SAO 109795"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.56430548),
        dec: Angle.Degrees(+02.55069562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81036",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10108 AB"},
        {"Henry Draper", "HD 149179"},
        {"Hipparcos Number", "HIP 81036"},
        {"Smithsonian Astrophysical Observation", "SAO 121683"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.25640650),
        dec: Angle.Degrees(+02.55101515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 942 AB"},
        {"Henry Draper", "HD 6864"},
        {"Hipparcos Number", "HIP 5413"},
        {"Smithsonian Astrophysical Observation", "SAO 109703"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30236778),
        dec: Angle.Degrees(+02.55176468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153739"},
        {"Hipparcos Number", "HIP 83264"},
        {"Geneva Identification System", "GEN# +1.00153739"},
        {"Smithsonian Astrophysical Observation", "SAO 122002"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.27380901),
        dec: Angle.Degrees(+02.55247471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79748"},
        {"Hipparcos Number", "HIP 45464"},
        {"Smithsonian Astrophysical Observation", "SAO 117547"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.97447923),
        dec: Angle.Degrees(+02.55458038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139802"},
        {"Hipparcos Number", "HIP 76724"},
        {"Smithsonian Astrophysical Observation", "SAO 121114"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.01797366),
        dec: Angle.Degrees(+02.55507903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107181"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.64804726),
        dec: Angle.Degrees(+02.55542104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47759"},
        {"Hipparcos Number", "HIP 31934"},
        {"Renson", "Renson 12843"},
        {"Smithsonian Astrophysical Observation", "SAO 114243"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.10482544),
        dec: Angle.Degrees(+02.55801223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32484"},
        {"Hipparcos Number", "HIP 23537"},
        {"Geneva Identification System", "GEN# +1.00032484"},
        {"Smithsonian Astrophysical Observation", "SAO 112368"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.90989700),
        dec: Angle.Degrees(+02.55835780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150104"},
        {"Hipparcos Number", "HIP 81501"},
        {"Smithsonian Astrophysical Observation", "SAO 121754"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.70568186),
        dec: Angle.Degrees(+02.55949114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62811"},
        {"Hipparcos Number", "HIP 37874"},
        {"Smithsonian Astrophysical Observation", "SAO 115894"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.44846620),
        dec: Angle.Degrees(+02.55986185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111508",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16089 AB"},
        {"Henry Draper", "HD 214044"},
        {"Hipparcos Number", "HIP 111508"},
        {"Smithsonian Astrophysical Observation", "SAO 127619"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.87419453),
        dec: Angle.Degrees(+02.56182728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56682",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56682"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.33364388),
        dec: Angle.Degrees(+02.56264090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75175"},
        {"Hipparcos Number", "HIP 43241"},
        {"Smithsonian Astrophysical Observation", "SAO 117149"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.13687045),
        dec: Angle.Degrees(+02.56373234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34035"},
        {"Hipparcos Number", "HIP 24442"},
        {"Smithsonian Astrophysical Observation", "SAO 112555"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.65417052),
        dec: Angle.Degrees(+02.56373813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7356"},
        {"Hipparcos Number", "HIP 5738"},
        {"Smithsonian Astrophysical Observation", "SAO 109741"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43304699),
        dec: Angle.Degrees(+02.56434327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9561"},
        {"Hipparcos Number", "HIP 7295"},
        {"Geneva Identification System", "GEN# +1.00009561"},
        {"Smithsonian Astrophysical Observation", "SAO 109977"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.48327430),
        dec: Angle.Degrees(+02.56538999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30185",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4966 AB"},
        {"Henry Draper", "HD 44274"},
        {"Hipparcos Number", "HIP 30185"},
        {"Smithsonian Astrophysical Observation", "SAO 113750"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.26208325),
        dec: Angle.Degrees(+02.56883906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53592"},
        {"Smithsonian Astrophysical Observation", "SAO 118591"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.45652241),
        dec: Angle.Degrees(+02.57335792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43021"},
        {"Hipparcos Number", "HIP 29590"},
        {"Smithsonian Astrophysical Observation", "SAO 113614"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.54338431),
        dec: Angle.Degrees(+02.57462246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127913"},
        {"Hipparcos Number", "HIP 71218"},
        {"Smithsonian Astrophysical Observation", "SAO 120530"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46481368),
        dec: Angle.Degrees(+02.57564066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14084"},
        {"Hipparcos Number", "HIP 10631"},
        {"Geneva Identification System", "GEN# +1.00014084"},
        {"Smithsonian Astrophysical Observation", "SAO 110448"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.20974446),
        dec: Angle.Degrees(+02.57623165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110514"},
        {"Hipparcos Number", "HIP 62016"},
        {"Smithsonian Astrophysical Observation", "SAO 119548"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.66221605),
        dec: Angle.Degrees(+02.57680480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18968"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.96849141),
        dec: Angle.Degrees(+02.57784312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10750 B"},
        {"Henry Draper", "HD 161289"},
        {"Hipparcos Number", "HIP 86835"},
        {"Geneva Identification System", "GEN# +1.00161289"},
        {"Smithsonian Astrophysical Observation", "SAO 122691"},
        {"Wilson Evans Batten Catalogue", "WEB 14648"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.14777330),
        dec: Angle.Degrees(+02.57909650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10750 A"},
        {"Henry Draper", "HD 161270"},
        {"Hipparcos Number", "HIP 86831"},
        {"Geneva Identification System", "GEN# +1.00161270"},
        {"Smithsonian Astrophysical Observation", "SAO 122690"},
        {"Wilson Evans Batten Catalogue", "WEB 14647"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.14203543),
        dec: Angle.Degrees(+02.57940751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43214",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7003 AB"},
        {"Henry Draper", "HD 75121"},
        {"Hipparcos Number", "HIP 43214"},
        {"Smithsonian Astrophysical Observation", "SAO 117140"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.05103147),
        dec: Angle.Degrees(+02.58021020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78255"},
        {"Hipparcos Number", "HIP 44755"},
        {"Geneva Identification System", "GEN# +1.00078255"},
        {"Smithsonian Astrophysical Observation", "SAO 117434"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.81958099),
        dec: Angle.Degrees(+02.58160896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48101"},
        {"Hipparcos Number", "HIP 32062"},
        {"Smithsonian Astrophysical Observation", "SAO 114292"},
        {"Wilson Evans Batten Catalogue", "WEB 6471"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.47786500),
        dec: Angle.Degrees(+02.58176527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5930"},
        {"Hipparcos Number", "HIP 4738"},
        {"Smithsonian Astrophysical Observation", "SAO 109600"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.21187399),
        dec: Angle.Degrees(+02.58404828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4094"},
        {"Hipparcos Number", "HIP 3407"},
        {"Geneva Identification System", "GEN# +1.00004094"},
        {"Smithsonian Astrophysical Observation", "SAO 109408"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.84855088),
        dec: Angle.Degrees(+02.58407242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14839"},
        {"Hipparcos Number", "HIP 11159"},
        {"Smithsonian Astrophysical Observation", "SAO 110509"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.89077309),
        dec: Angle.Degrees(+02.58444068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10057"},
        {"Hipparcos Number", "HIP 7632"},
        {"Smithsonian Astrophysical Observation", "SAO 110024"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.58294363),
        dec: Angle.Degrees(+02.58607253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213574"},
        {"Hipparcos Number", "HIP 111254"},
        {"Smithsonian Astrophysical Observation", "SAO 127583"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.09094869),
        dec: Angle.Degrees(+02.58620834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176737"},
        {"Hipparcos Number", "HIP 93417"},
        {"Geneva Identification System", "GEN# +1.00176737"},
        {"Smithsonian Astrophysical Observation", "SAO 124163"},
        {"Wilson Evans Batten Catalogue", "WEB 16212"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.38956815),
        dec: Angle.Degrees(+02.58846718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112311"},
        {"Smithsonian Astrophysical Observation", "SAO 127728"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.23956973),
        dec: Angle.Degrees(+02.58878526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52774"},
    },
    visualMagnitude: 12.28,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85081610),
        dec: Angle.Degrees(+02.59217168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110989"},
        {"Hipparcos Number", "HIP 62307"},
        {"Geneva Identification System", "GEN# +1.00110989"},
        {"Smithsonian Astrophysical Observation", "SAO 119575"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.50954223),
        dec: Angle.Degrees(+02.59321814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52086"},
        {"Smithsonian Astrophysical Observation", "SAO 118409"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.64730357),
        dec: Angle.Degrees(+02.59330406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10342"},
        {"Smithsonian Astrophysical Observation", "SAO 110412"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.31033938),
        dec: Angle.Degrees(+02.59460274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4286"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.73111928),
        dec: Angle.Degrees(+02.59487583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34658"},
        {"Hipparcos Number", "HIP 24817"},
        {"Geneva Identification System", "GEN# +1.00034658"},
        {"Smithsonian Astrophysical Observation", "SAO 112624"},
        {"Wilson Evans Batten Catalogue", "WEB 4801"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.79678985),
        dec: Angle.Degrees(+02.59593601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105919",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105919"},
        {"Smithsonian Astrophysical Observation", "SAO 126800"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.77906395),
        dec: Angle.Degrees(+02.59689886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75686"},
        {"Geneva Identification System", "GEN# +0.00303032"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.92803486),
        dec: Angle.Degrees(+02.59779906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4564"},
        {"Smithsonian Astrophysical Observation", "SAO 109566"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.59866262),
        dec: Angle.Degrees(+02.59956685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173817"},
        {"Hipparcos Number", "HIP 92180"},
        {"Geneva Identification System", "GEN# +1.00173817"},
        {"Smithsonian Astrophysical Observation", "SAO 123916"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.80990680),
        dec: Angle.Degrees(+02.60188511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3959 AB"},
        {"Henry Draper", "HD 35112"},
        {"Hipparcos Number", "HIP 25119"},
        {"Smithsonian Astrophysical Observation", "SAO 112692"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.65607665),
        dec: Angle.Degrees(+02.60352940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288004"},
        {"Hipparcos Number", "HIP 25934"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.02318011),
        dec: Angle.Degrees(+02.60553783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108940"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07301413),
        dec: Angle.Degrees(+02.60583282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122867"},
        {"Hipparcos Number", "HIP 68747"},
        {"Smithsonian Astrophysical Observation", "SAO 120267"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.08079845),
        dec: Angle.Degrees(+02.60751757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105929"},
        {"Hipparcos Number", "HIP 59441"},
        {"Smithsonian Astrophysical Observation", "SAO 119261"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.88621491),
        dec: Angle.Degrees(+02.60801898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73995"},
        {"Hipparcos Number", "HIP 42648"},
        {"Smithsonian Astrophysical Observation", "SAO 117027"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.37180671),
        dec: Angle.Degrees(+02.60870156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217876"},
        {"Hipparcos Number", "HIP 113879"},
        {"Smithsonian Astrophysical Observation", "SAO 127931"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.93758159),
        dec: Angle.Degrees(+02.60893157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89978"},
        {"Hipparcos Number", "HIP 50869"},
        {"Smithsonian Astrophysical Observation", "SAO 118272"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.80993886),
        dec: Angle.Degrees(+02.60965329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220553"},
        {"Hipparcos Number", "HIP 115568"},
        {"Smithsonian Astrophysical Observation", "SAO 128164"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.14974212),
        dec: Angle.Degrees(+02.60986223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10674"},
        {"Hipparcos Number", "HIP 8116"},
        {"Smithsonian Astrophysical Observation", "SAO 110102"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.08066446),
        dec: Angle.Degrees(+02.61557976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74921"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.65536717),
        dec: Angle.Degrees(+02.61573992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133842"},
        {"Hipparcos Number", "HIP 73938"},
        {"Smithsonian Astrophysical Observation", "SAO 120840"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.64084456),
        dec: Angle.Degrees(+02.61715895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90054"},
        {"Hipparcos Number", "HIP 50907"},
        {"Geneva Identification System", "GEN# +1.00090054"},
        {"Smithsonian Astrophysical Observation", "SAO 118275"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.93128738),
        dec: Angle.Degrees(+02.61995172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145406"},
        {"Hipparcos Number", "HIP 79263"},
        {"Smithsonian Astrophysical Observation", "SAO 121404"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65639416),
        dec: Angle.Degrees(+02.62099995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110630"},
        {"Hipparcos Number", "HIP 62091"},
        {"Fundamental Katalog 5th Edition", "FK5 5122"},
        {"Smithsonian Astrophysical Observation", "SAO 119554"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.88384224),
        dec: Angle.Degrees(+02.62109751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23412"},
        {"Hipparcos Number", "HIP 17519"},
        {"Geneva Identification System", "GEN# +1.00023412"},
        {"Smithsonian Astrophysical Observation", "SAO 111393"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.26131923),
        dec: Angle.Degrees(+02.62140091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11617 AB"},
        {"Henry Draper", "HD 173174"},
        {"Hipparcos Number", "HIP 91889"},
        {"Smithsonian Astrophysical Observation", "SAO 123858"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.98254953),
        dec: Angle.Degrees(+02.62145849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94331",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12147 AB"},
        {"Henry Draper", "HD 179343"},
        {"Hipparcos Number", "HIP 94331"},
        {"Geneva Identification System", "GEN# +1.00179343J"},
        {"Smithsonian Astrophysical Observation", "SAO 124376"},
        {"Wilson Evans Batten Catalogue", "WEB 16431"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.01366099),
        dec: Angle.Degrees(+02.62261658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6459"},
        {"Smithsonian Astrophysical Observation", "SAO 109845"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.76957459),
        dec: Angle.Degrees(+02.62272731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91500"},
        {"Hipparcos Number", "HIP 51711"},
        {"Smithsonian Astrophysical Observation", "SAO 118362"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.48341901),
        dec: Angle.Degrees(+02.62305950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47693",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7500 AB"},
        {"Henry Draper", "HD 84184"},
        {"Hipparcos Number", "HIP 47693"},
        {"Smithsonian Astrophysical Observation", "SAO 117871"},
        {"Wilson Evans Batten Catalogue", "WEB 8936"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.86346269),
        dec: Angle.Degrees(+02.62751526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76262"},
        {"Hipparcos Number", "HIP 43795"},
        {"Smithsonian Astrophysical Observation", "SAO 117263"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.79413360),
        dec: Angle.Degrees(+02.62876119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11507 A"},
        {"Henry Draper", "HD 171953"},
        {"Hipparcos Number", "HIP 91300"},
        {"Geneva Identification System", "GEN# +1.00171953"},
        {"Smithsonian Astrophysical Observation", "SAO 123711"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.35514239),
        dec: Angle.Degrees(+02.62940700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5859"},
        {"Hipparcos Number", "HIP 4677"},
        {"Smithsonian Astrophysical Observation", "SAO 109587"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.02354891),
        dec: Angle.Degrees(+02.63298133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112130"},
        {"Hipparcos Number", "HIP 62966"},
        {"Smithsonian Astrophysical Observation", "SAO 119654"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.54532973),
        dec: Angle.Degrees(+02.63334639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75067"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.09774996),
        dec: Angle.Degrees(+02.63357716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89940"},
        {"Geneva Identification System", "GEN# +0.00203572"},
        {"Smithsonian Astrophysical Observation", "SAO 123380"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.26517088),
        dec: Angle.Degrees(+02.63392518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30172"},
        {"Hipparcos Number", "HIP 22099"},
        {"Smithsonian Astrophysical Observation", "SAO 112045"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.33242358),
        dec: Angle.Degrees(+02.63646753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83024"},
        {"Hipparcos Number", "HIP 47081"},
        {"Smithsonian Astrophysical Observation", "SAO 117794"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.91879212),
        dec: Angle.Degrees(+02.63739946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201941"},
        {"Hipparcos Number", "HIP 104717"},
        {"Smithsonian Astrophysical Observation", "SAO 126618"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.18892067),
        dec: Angle.Degrees(+02.64278504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32663"},
        {"Hipparcos Number", "HIP 23654"},
        {"Smithsonian Astrophysical Observation", "SAO 112397"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.25428680),
        dec: Angle.Degrees(+02.64547610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45724"},
        {"Hipparcos Number", "HIP 30906"},
        {"Geneva Identification System", "GEN# +1.00045724"},
        {"Smithsonian Astrophysical Observation", "SAO 113940"},
        {"Wilson Evans Batten Catalogue", "WEB 6157"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.31172004),
        dec: Angle.Degrees(+02.64629152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90775"},
        {"Hipparcos Number", "HIP 51321"},
        {"Geneva Identification System", "GEN# +1.00090775"},
        {"Smithsonian Astrophysical Observation", "SAO 118326"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.24440779),
        dec: Angle.Degrees(+02.64676188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146102"},
        {"Hipparcos Number", "HIP 79595"},
        {"Geneva Identification System", "GEN# +1.00146102"},
        {"Smithsonian Astrophysical Observation", "SAO 121445"},
        {"Wilson Evans Batten Catalogue", "WEB 13468"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.59219162),
        dec: Angle.Degrees(+02.64733257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50039"},
        {"Hipparcos Number", "HIP 32927"},
        {"Geneva Identification System", "GEN# +1.00050039"},
        {"Smithsonian Astrophysical Observation", "SAO 114523"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.90117489),
        dec: Angle.Degrees(+02.65110655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36654"},
        {"Hipparcos Number", "HIP 26055"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.36429853),
        dec: Angle.Degrees(+02.65158021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50910"},
        {"Smithsonian Astrophysical Observation", "SAO 118276"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.94530571),
        dec: Angle.Degrees(+02.65166277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48956"},
        {"Hipparcos Number", "HIP 32430"},
        {"Smithsonian Astrophysical Observation", "SAO 114383"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.54010338),
        dec: Angle.Degrees(+02.65200142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19927"},
        {"Smithsonian Astrophysical Observation", "SAO 111712"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13241925),
        dec: Angle.Degrees(+02.65223386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16061"},
        {"Hipparcos Number", "HIP 12011"},
        {"Geneva Identification System", "GEN# +1.00016061"},
        {"Smithsonian Astrophysical Observation", "SAO 110623"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.71150406),
        dec: Angle.Degrees(+02.65257480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93543"},
        {"Hipparcos Number", "HIP 52821"},
        {"Geneva Identification System", "GEN# +1.00093543"},
        {"Smithsonian Astrophysical Observation", "SAO 118500"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.99456246),
        dec: Angle.Degrees(+02.65318139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114726"},
        {"Hipparcos Number", "HIP 64433"},
        {"Smithsonian Astrophysical Observation", "SAO 119812"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.09531629),
        dec: Angle.Degrees(+02.65382660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156566"},
        {"Hipparcos Number", "HIP 84641"},
        {"Smithsonian Astrophysical Observation", "SAO 122254"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.56020280),
        dec: Angle.Degrees(+02.65779695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94401"},
        {"Hipparcos Number", "HIP 53284"},
        {"Geneva Identification System", "GEN# +1.00094401"},
        {"Smithsonian Astrophysical Observation", "SAO 118565"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.46618611),
        dec: Angle.Degrees(+02.65791699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160295"},
        {"Hipparcos Number", "HIP 86374"},
        {"Geneva Identification System", "GEN# +1.00160295"},
        {"Smithsonian Astrophysical Observation", "SAO 122600"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.74114544),
        dec: Angle.Degrees(+02.65841241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16710"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.75135077),
        dec: Angle.Degrees(+02.66183627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133828"},
        {"Hipparcos Number", "HIP 73925"},
        {"Smithsonian Astrophysical Observation", "SAO 120838"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.60352937),
        dec: Angle.Degrees(+02.66191496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21848"},
        {"Hipparcos Number", "HIP 16421"},
        {"Geneva Identification System", "GEN# +1.00021848"},
        {"Smithsonian Astrophysical Observation", "SAO 111237"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.85587582),
        dec: Angle.Degrees(+02.66228420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112062"},
        {"Hipparcos Number", "HIP 62924"},
        {"Smithsonian Astrophysical Observation", "SAO 119650"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.42745702),
        dec: Angle.Degrees(+02.66298762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14362"},
        {"Hipparcos Number", "HIP 10822"},
        {"Smithsonian Astrophysical Observation", "SAO 110472"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.83128251),
        dec: Angle.Degrees(+02.66474077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70181"},
        {"Hipparcos Number", "HIP 40893"},
        {"Geneva Identification System", "GEN# +1.00070181"},
        {"Smithsonian Astrophysical Observation", "SAO 116649"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.17265055),
        dec: Angle.Degrees(+02.66482792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30425",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5013 AB"},
        {"Henry Draper", "HD 44771"},
        {"Hipparcos Number", "HIP 30425"},
        {"Smithsonian Astrophysical Observation", "SAO 113812"},
        {"Wilson Evans Batten Catalogue", "WEB 6053"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.94819307),
        dec: Angle.Degrees(+02.66573735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162904"},
        {"Hipparcos Number", "HIP 87566"},
        {"Smithsonian Astrophysical Observation", "SAO 122881"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.32999735),
        dec: Angle.Degrees(+02.66799910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88666"},
        {"Hipparcos Number", "HIP 50091"},
        {"Smithsonian Astrophysical Observation", "SAO 118175"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.41249692),
        dec: Angle.Degrees(+02.66915990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27338"},
        {"Hipparcos Number", "HIP 20141"},
        {"Smithsonian Astrophysical Observation", "SAO 111743"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.76966465),
        dec: Angle.Degrees(+02.67109487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44359",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7152 AB"},
        {"Henry Draper", "HD 77314"},
        {"Hipparcos Number", "HIP 44359"},
        {"Renson", "Renson 21834"},
        {"Smithsonian Astrophysical Observation", "SAO 117363"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.49495728),
        dec: Angle.Degrees(+02.67122861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32867"},
        {"Hipparcos Number", "HIP 23757"},
        {"Geneva Identification System", "GEN# +1.00032867"},
        {"Smithsonian Astrophysical Observation", "SAO 112420"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.59545645),
        dec: Angle.Degrees(+02.67327405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213982"},
        {"Hipparcos Number", "HIP 111481"},
        {"Smithsonian Astrophysical Observation", "SAO 127617"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.80087213),
        dec: Angle.Degrees(+02.67344092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182082"},
        {"Hipparcos Number", "HIP 95263"},
        {"Smithsonian Astrophysical Observation", "SAO 124563"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.72589050),
        dec: Angle.Degrees(+02.67416456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122203"},
        {"Hipparcos Number", "HIP 68415"},
        {"Smithsonian Astrophysical Observation", "SAO 120218"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.08420375),
        dec: Angle.Degrees(+02.67462848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219113"},
        {"Hipparcos Number", "HIP 114639"},
        {"Geneva Identification System", "GEN# +1.00219113"},
        {"Smithsonian Astrophysical Observation", "SAO 128041"},
        {"Wilson Evans Batten Catalogue", "WEB 20334"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.34906284),
        dec: Angle.Degrees(+02.67537604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224760"},
        {"Hipparcos Number", "HIP 31"},
        {"Smithsonian Astrophysical Observation", "SAO 128524"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.09809390),
        dec: Angle.Degrees(+02.67547768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165574"},
        {"Hipparcos Number", "HIP 88701"},
        {"Smithsonian Astrophysical Observation", "SAO 123125"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.61971337),
        dec: Angle.Degrees(+02.67708704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47307"},
        {"Geneva Identification System", "GEN# +9.80048025"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.60049666),
        dec: Angle.Degrees(+02.67863851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -330.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -790.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79971"},
        {"Hipparcos Number", "HIP 45564"},
        {"Geneva Identification System", "GEN# +1.00079971"},
        {"Smithsonian Astrophysical Observation", "SAO 117563"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.29999236),
        dec: Angle.Degrees(+02.67868504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129519"},
        {"Hipparcos Number", "HIP 71948"},
        {"Smithsonian Astrophysical Observation", "SAO 120617"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.783,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.73176036),
        dec: Angle.Degrees(+02.68015389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38014"},
        {"Hipparcos Number", "HIP 26907"},
        {"Cincinnati Publication", "Ci 18 724"},
        {"Cincinnati Publication 2", "Ci 20 346"},
        {"Geneva Identification System", "GEN# +1.00038014"},
        {"Smithsonian Astrophysical Observation", "SAO 113059"},
        {"Wilson Evans Batten Catalogue", "WEB 5305"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.69037392),
        dec: Angle.Degrees(+02.68032382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -526.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118297"},
        {"Hipparcos Number", "HIP 66349"},
        {"Smithsonian Astrophysical Observation", "SAO 120027"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.97865663),
        dec: Angle.Degrees(+02.68178174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172506"},
        {"Hipparcos Number", "HIP 91580"},
        {"Geneva Identification System", "GEN# +1.00172506"},
        {"Smithsonian Astrophysical Observation", "SAO 123794"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.13051314),
        dec: Angle.Degrees(+02.68448346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29311"},
        {"Hipparcos Number", "HIP 21509"},
        {"Smithsonian Astrophysical Observation", "SAO 111925"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.28752895),
        dec: Angle.Degrees(+02.68486823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54191"},
        {"Hipparcos Number", "HIP 34405"},
        {"Smithsonian Astrophysical Observation", "SAO 114954"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.99772674),
        dec: Angle.Degrees(+02.68606540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207203"},
        {"Hipparcos Number", "HIP 107575"},
        {"Fundamental Katalog 5th Edition", "FK5 1574"},
        {"Geneva Identification System", "GEN# +1.00207203"},
        {"Smithsonian Astrophysical Observation", "SAO 127060"},
        {"Wilson Evans Batten Catalogue", "WEB 19415"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.80815996),
        dec: Angle.Degrees(+02.68613092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4210 AB"},
        {"Henry Draper", "HD 288063"},
        {"Hipparcos Number", "HIP 26353"},
        {"Smithsonian Astrophysical Observation", "SAO 112957"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.17435360),
        dec: Angle.Degrees(+02.68649836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114576",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16591 AB"},
        {"Aitken 2", "ADS 16591"},
        {"Henry Draper", "HD 219018"},
        {"Hipparcos Number", "HIP 114576"},
        {"Geneva Identification System", "GEN# +1.00219018J"},
        {"Smithsonian Astrophysical Observation", "SAO 128034"},
        {"Wilson Evans Batten Catalogue", "WEB 20328"},
        {"Wilson Evans Batten Catalogue 2", "WEB 20329"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.16064492),
        dec: Angle.Degrees(+02.68657905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122424"},
        {"Hipparcos Number", "HIP 68525"},
        {"Geneva Identification System", "GEN# +1.00122424"},
        {"Smithsonian Astrophysical Observation", "SAO 120239"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43336176),
        dec: Angle.Degrees(+02.68886713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104005"},
        {"Geneva Identification System", "GEN# +6.20156507"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.07395039),
        dec: Angle.Degrees(+02.69012357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121135"},
        {"Hipparcos Number", "HIP 67822"},
        {"Geneva Identification System", "GEN# +1.00121135"},
        {"Smithsonian Astrophysical Observation", "SAO 120155"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.38984747),
        dec: Angle.Degrees(+02.69482016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19984"},
        {"Hipparcos Number", "HIP 14956"},
        {"Geneva Identification System", "GEN# +1.00019984"},
        {"Smithsonian Astrophysical Observation", "SAO 111050"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.20242671),
        dec: Angle.Degrees(+02.69506253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139693"},
        {"Hipparcos Number", "HIP 76678"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.86340066),
        dec: Angle.Degrees(+02.69862689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113814"},
        {"Hipparcos Number", "HIP 63944"},
        {"Smithsonian Astrophysical Observation", "SAO 119763"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.56811091),
        dec: Angle.Degrees(+02.69918563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1151"},
        {"Hipparcos Number", "HIP 1264"},
        {"Geneva Identification System", "GEN# +1.00001151"},
        {"Smithsonian Astrophysical Observation", "SAO 109092"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.96517040),
        dec: Angle.Degrees(+02.70230268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106565"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.72080465),
        dec: Angle.Degrees(+02.70282686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130307"},
        {"Hipparcos Number", "HIP 72312"},
        {"Cincinnati Publication", "Ci 18 1952"},
        {"Geneva Identification System", "GEN# +1.00130307"},
        {"Smithsonian Astrophysical Observation", "SAO 120663"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.81778800),
        dec: Angle.Degrees(+02.70341682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47220"},
        {"Hipparcos Number", "HIP 31672"},
        {"Fundamental Katalog 5th Edition", "FK5 2512"},
        {"Geneva Identification System", "GEN# +1.00047220"},
        {"Smithsonian Astrophysical Observation", "SAO 114154"},
        {"Wilson Evans Batten Catalogue", "WEB 6350"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41812228),
        dec: Angle.Degrees(+02.70427865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10298"},
        {"Hipparcos Number", "HIP 7833"},
        {"Geneva Identification System", "GEN# +1.00010298"},
        {"Smithsonian Astrophysical Observation", "SAO 110050"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.19571736),
        dec: Angle.Degrees(+02.70496596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109807"},
        {"Geneva Identification System", "GEN# +9.80027020"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.61092518),
        dec: Angle.Degrees(+02.70665190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38528"},
        {"Hipparcos Number", "HIP 27261"},
        {"Smithsonian Astrophysical Observation", "SAO 113123"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.67996511),
        dec: Angle.Degrees(+02.70736249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161868"},
        {"Hipparcos Number", "HIP 87108"},
        {"Fundamental Katalog 5th Edition", "FK5 668"},
        {"Geneva Identification System", "GEN# +1.00161868"},
        {"Geneva Identification System 2", "GEN# +5.13590013"},
        {"Smithsonian Astrophysical Observation", "SAO 122754"},
        {"Wilson Evans Batten Catalogue", "WEB 14695"},
    },
    visualMagnitude: 3.75,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.97322515),
        dec: Angle.Degrees(+02.70745875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94031"},
        {"Hipparcos Number", "HIP 53047"},
        {"Smithsonian Astrophysical Observation", "SAO 118536"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.80072330),
        dec: Angle.Degrees(+02.70803065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73509"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.36725094),
        dec: Angle.Degrees(+02.70829866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74768"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.21050242),
        dec: Angle.Degrees(+02.70935379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11017"},
        {"Hipparcos Number", "HIP 8392"},
        {"Smithsonian Astrophysical Observation", "SAO 110136"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.06150166),
        dec: Angle.Degrees(+02.71142224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19346"},
        {"Hipparcos Number", "HIP 14471"},
        {"Geneva Identification System", "GEN# +1.00019346"},
        {"Smithsonian Astrophysical Observation", "SAO 110978"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.69609715),
        dec: Angle.Degrees(+02.71446808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30508"},
        {"Hipparcos Number", "HIP 22319"},
        {"Geneva Identification System", "GEN# +1.00030508"},
        {"Smithsonian Astrophysical Observation", "SAO 112091"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.11521571),
        dec: Angle.Degrees(+02.71513834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198124"},
        {"Hipparcos Number", "HIP 102653"},
        {"Smithsonian Astrophysical Observation", "SAO 126224"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.04051039),
        dec: Angle.Degrees(+02.71552571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163826"},
        {"Hipparcos Number", "HIP 87954"},
        {"Smithsonian Astrophysical Observation", "SAO 122965"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.51326711),
        dec: Angle.Degrees(+02.71995990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8883 A"},
        {"Henry Draper", "HD 116442"},
        {"Hipparcos Number", "HIP 65352"},
        {"Cincinnati Publication", "Ci 18 1728"},
        {"Geneva Identification System", "GEN# +1.00116442"},
        {"Smithsonian Astrophysical Observation", "SAO 119909"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.91311092),
        dec: Angle.Degrees(+02.72284228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 198.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85749",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10607 AB"},
        {"Henry Draper", "HD 158837"},
        {"Hipparcos Number", "HIP 85749"},
        {"Geneva Identification System", "GEN# +1.00158837J"},
        {"Smithsonian Astrophysical Observation", "SAO 122465"},
        {"Wilson Evans Batten Catalogue", "WEB 14472"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.83893822),
        dec: Angle.Degrees(+02.72446012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65355",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8883 B"},
        {"Henry Draper", "HD 116443"},
        {"Hipparcos Number", "HIP 65355"},
        {"Cincinnati Publication", "Ci 18 1727"},
        {"Geneva Identification System", "GEN# +1.00116443"},
        {"Smithsonian Astrophysical Observation", "SAO 119910"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.92017388),
        dec: Angle.Degrees(+02.72478537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59880"},
        {"Hipparcos Number", "HIP 36636"},
        {"Smithsonian Astrophysical Observation", "SAO 115577"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.01123157),
        dec: Angle.Degrees(+02.72542922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287474"},
        {"Hipparcos Number", "HIP 23548"},
        {"Smithsonian Astrophysical Observation", "SAO 112372"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.96376289),
        dec: Angle.Degrees(+02.72549937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60489"},
        {"Hipparcos Number", "HIP 36869"},
        {"Geneva Identification System", "GEN# +1.00060489"},
        {"Renson", "Renson 16540"},
        {"Smithsonian Astrophysical Observation", "SAO 115653"},
        {"Wilson Evans Batten Catalogue", "WEB 7324"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.69259291),
        dec: Angle.Degrees(+02.72551181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26065"},
        {"Hipparcos Number", "HIP 19267"},
        {"Smithsonian Astrophysical Observation", "SAO 111614"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.94490332),
        dec: Angle.Degrees(+02.72570833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131364"},
        {"Hipparcos Number", "HIP 72827"},
        {"Smithsonian Astrophysical Observation", "SAO 120712"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.28694033),
        dec: Angle.Degrees(+02.72608455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22653"},
        {"Hipparcos Number", "HIP 17003"},
        {"Smithsonian Astrophysical Observation", "SAO 111314"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.67865518),
        dec: Angle.Degrees(+02.72790620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107498"},
        {"Hipparcos Number", "HIP 60264"},
        {"Smithsonian Astrophysical Observation", "SAO 119349"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.35246656),
        dec: Angle.Degrees(+02.72823932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4629"},
        {"Hipparcos Number", "HIP 3758"},
        {"Geneva Identification System", "GEN# +1.00004629"},
        {"Smithsonian Astrophysical Observation", "SAO 109468"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.05645579),
        dec: Angle.Degrees(+02.72952226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8651"},
    },
    visualMagnitude: 12.13,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.87085445),
        dec: Angle.Degrees(+02.73036715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110099"},
        {"Geneva Identification System", "GEN# +0.00204488"},
        {"Wilson Evans Batten Catalogue", "WEB 19764"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.54457518),
        dec: Angle.Degrees(+02.73063070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223927"},
        {"Hipparcos Number", "HIP 117818"},
        {"Smithsonian Astrophysical Observation", "SAO 128447"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.41777317),
        dec: Angle.Degrees(+02.73125600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15467"},
        {"Smithsonian Astrophysical Observation", "SAO 111122"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.86342496),
        dec: Angle.Degrees(+02.73259319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210719"},
        {"Hipparcos Number", "HIP 109614"},
        {"Geneva Identification System", "GEN# +1.00210719"},
        {"Smithsonian Astrophysical Observation", "SAO 127367"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.07337902),
        dec: Angle.Degrees(+02.73379931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210267"},
        {"Hipparcos Number", "HIP 109349"},
        {"Smithsonian Astrophysical Observation", "SAO 127327"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.28831936),
        dec: Angle.Degrees(+02.73406708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99798"},
        {"Hipparcos Number", "HIP 56029"},
        {"Smithsonian Astrophysical Observation", "SAO 118885"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.25300313),
        dec: Angle.Degrees(+02.73424392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7660"},
        {"Hipparcos Number", "HIP 5949"},
        {"Geneva Identification System", "GEN# +1.00007660"},
        {"Smithsonian Astrophysical Observation", "SAO 109775"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.14977784),
        dec: Angle.Degrees(+02.73492707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82251",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10217 AB"},
        {"Henry Draper", "HD 151618"},
        {"Hipparcos Number", "HIP 82251"},
        {"Smithsonian Astrophysical Observation", "SAO 121872"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.08403915),
        dec: Angle.Degrees(+02.73801857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81086"},
        {"Hipparcos Number", "HIP 46073"},
        {"Smithsonian Astrophysical Observation", "SAO 117652"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.92809464),
        dec: Angle.Degrees(+02.73931986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26472"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.46021402),
        dec: Angle.Degrees(+02.73933695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197833"},
        {"Hipparcos Number", "HIP 102479"},
        {"Geneva Identification System", "GEN# +1.00197833"},
        {"Smithsonian Astrophysical Observation", "SAO 126186"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.50242597),
        dec: Angle.Degrees(+02.74037166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56989"},
        {"Hipparcos Number", "HIP 35476"},
        {"Fundamental Katalog 5th Edition", "FK5 2564"},
        {"Geneva Identification System", "GEN# +1.00056989"},
        {"Smithsonian Astrophysical Observation", "SAO 115263"},
        {"Wilson Evans Batten Catalogue", "WEB 7076"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84321714),
        dec: Angle.Degrees(+02.74071985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1935"},
        {"Hipparcos Number", "HIP 1869"},
        {"Geneva Identification System", "GEN# +1.00001935"},
        {"Smithsonian Astrophysical Observation", "SAO 109173"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.91044914),
        dec: Angle.Degrees(+02.74304147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72908"},
        {"Hipparcos Number", "HIP 42142"},
        {"Geneva Identification System", "GEN# +1.00072908"},
        {"Smithsonian Astrophysical Observation", "SAO 116920"},
        {"Wilson Evans Batten Catalogue", "WEB 8098"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.85398701),
        dec: Angle.Degrees(+02.74344025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50372"},
        {"Hipparcos Number", "HIP 33036"},
        {"Geneva Identification System", "GEN# +1.00050372"},
        {"Smithsonian Astrophysical Observation", "SAO 114561"},
        {"Wilson Evans Batten Catalogue", "WEB 6651"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.24710333),
        dec: Angle.Degrees(+02.74348695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4899"},
        {"Hipparcos Number", "HIP 3973"},
        {"Geneva Identification System", "GEN# +1.00004899"},
        {"Smithsonian Astrophysical Observation", "SAO 109506"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.76854142),
        dec: Angle.Degrees(+02.74372611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62022"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.69680728),
        dec: Angle.Degrees(+02.74462925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13546"},
        {"Hipparcos Number", "HIP 10273"},
        {"Geneva Identification System", "GEN# +1.00013546"},
        {"Smithsonian Astrophysical Observation", "SAO 110403"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.06566579),
        dec: Angle.Degrees(+02.74552179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288112"},
        {"Hipparcos Number", "HIP 26467"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.45094052),
        dec: Angle.Degrees(+02.74639068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13572"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.71096212),
        dec: Angle.Degrees(+02.74650037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91802"},
        {"Hipparcos Number", "HIP 51882"},
        {"Smithsonian Astrophysical Observation", "SAO 118388"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.00648751),
        dec: Angle.Degrees(+02.74742048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20173"},
        {"Hipparcos Number", "HIP 15090"},
        {"Geneva Identification System", "GEN# +1.00020173"},
        {"Smithsonian Astrophysical Observation", "SAO 111068"},
        {"Wilson Evans Batten Catalogue", "WEB 2906"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.65204494),
        dec: Angle.Degrees(+02.75453147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212968"},
        {"Hipparcos Number", "HIP 110899"},
        {"Smithsonian Astrophysical Observation", "SAO 127542"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.02993278),
        dec: Angle.Degrees(+02.75535482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116207"},
        {"Hipparcos Number", "HIP 65225"},
        {"Smithsonian Astrophysical Observation", "SAO 119902"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.50734843),
        dec: Angle.Degrees(+02.75733312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65852"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.48304439),
        dec: Angle.Degrees(+02.75745613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208566"},
        {"Hipparcos Number", "HIP 108342"},
        {"Smithsonian Astrophysical Observation", "SAO 127184"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.25127525),
        dec: Angle.Degrees(+02.75957204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71706"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.01768409),
        dec: Angle.Degrees(+02.76083383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12537"},
        {"Hipparcos Number", "HIP 9574"},
        {"Smithsonian Astrophysical Observation", "SAO 110301"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.75283500),
        dec: Angle.Degrees(+02.76243118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22686"},
        {"Hipparcos Number", "HIP 17018"},
        {"Smithsonian Astrophysical Observation", "SAO 111318"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.72949228),
        dec: Angle.Degrees(+02.76354582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3503"},
        {"Hipparcos Number", "HIP 2988"},
        {"Geneva Identification System", "GEN# +1.00003503"},
        {"Smithsonian Astrophysical Observation", "SAO 109323"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.50226191),
        dec: Angle.Degrees(+02.76366339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9487",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alrescha"},
        {"Aitken", "ADS 1615 AB"},
        {"Henry Draper", "HD 12446J"},
        {"Hipparcos Number", "HIP 9487"},
        {"Geneva Identification System", "GEN# +1.00012447"},
    },
    visualMagnitude: 3.82,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.51166929),
        dec: Angle.Degrees(+02.76376048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 489"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.46611168),
        dec: Angle.Degrees(+02.76462706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203633"},
        {"Hipparcos Number", "HIP 105608"},
        {"Geneva Identification System", "GEN# +1.00203633"},
        {"Smithsonian Astrophysical Observation", "SAO 126754"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.84888485),
        dec: Angle.Degrees(+02.76628563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24253"},
        {"Hipparcos Number", "HIP 18072"},
        {"Smithsonian Astrophysical Observation", "SAO 111467"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.93795009),
        dec: Angle.Degrees(+02.76741834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110683",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110683"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.35221544),
        dec: Angle.Degrees(+02.77028128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5409"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30096627),
        dec: Angle.Degrees(+02.77375531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76172"},
        {"Wilson Evans Batten Catalogue", "WEB 12937"},
    },
    visualMagnitude: 12.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.37849443),
        dec: Angle.Degrees(+02.77716024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144132"},
        {"Hipparcos Number", "HIP 78720"},
        {"Smithsonian Astrophysical Observation", "SAO 121343"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.05298753),
        dec: Angle.Degrees(+02.78039290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99739"},
        {"Hipparcos Number", "HIP 55982"},
        {"Geneva Identification System", "GEN# +1.00099739"},
        {"Smithsonian Astrophysical Observation", "SAO 118879"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.10458244),
        dec: Angle.Degrees(+02.78313954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211857"},
        {"Hipparcos Number", "HIP 110265"},
        {"Smithsonian Astrophysical Observation", "SAO 127451"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.02592523),
        dec: Angle.Degrees(+02.78316342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181528"},
        {"Hipparcos Number", "HIP 95080"},
        {"Smithsonian Astrophysical Observation", "SAO 124526"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.16412388),
        dec: Angle.Degrees(+02.78342198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121881"},
        {"Hipparcos Number", "HIP 68236"},
        {"Fundamental Katalog 5th Edition", "FK5 5235"},
        {"Smithsonian Astrophysical Observation", "SAO 120198"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.53063402),
        dec: Angle.Degrees(+02.78351861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73177"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.33943984),
        dec: Angle.Degrees(+02.78578300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126961"},
        {"Hipparcos Number", "HIP 70782"},
        {"Geneva Identification System", "GEN# +1.00126961"},
        {"Smithsonian Astrophysical Observation", "SAO 120481"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.13021469),
        dec: Angle.Degrees(+02.78870615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17743",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17743"},
        {"Cincinnati Publication", "Ci 20 263"},
    },
    visualMagnitude: 11.05,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.99303501),
        dec: Angle.Degrees(+02.78885403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -386.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -431.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82258"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.10733235),
        dec: Angle.Degrees(+02.78946962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209078"},
        {"Hipparcos Number", "HIP 108655"},
        {"Smithsonian Astrophysical Observation", "SAO 127229"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.17068826),
        dec: Angle.Degrees(+02.79233014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204702"},
        {"Hipparcos Number", "HIP 106169"},
        {"Geneva Identification System", "GEN# +1.00204702"},
        {"Smithsonian Astrophysical Observation", "SAO 126847"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.57668710),
        dec: Angle.Degrees(+02.79324891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69608"},
        {"Hipparcos Number", "HIP 40635"},
        {"Smithsonian Astrophysical Observation", "SAO 116592"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.43360152),
        dec: Angle.Degrees(+02.79353043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141609"},
        {"Hipparcos Number", "HIP 77538"},
        {"Smithsonian Astrophysical Observation", "SAO 121211"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.47480654),
        dec: Angle.Degrees(+02.79529361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35134"},
        {"Hipparcos Number", "HIP 25136"},
        {"Celescope Catalog", "CEL 657"},
        {"Geneva Identification System", "GEN# +1.00035134"},
        {"Smithsonian Astrophysical Observation", "SAO 112693"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.69053092),
        dec: Angle.Degrees(+02.79632951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124699"},
        {"Hipparcos Number", "HIP 69631"},
        {"Geneva Identification System", "GEN# +1.00124699"},
        {"Smithsonian Astrophysical Observation", "SAO 120368"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.76353268),
        dec: Angle.Degrees(+02.79666227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92687"},
        {"Hipparcos Number", "HIP 52368"},
        {"Smithsonian Astrophysical Observation", "SAO 118439"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.55197939),
        dec: Angle.Degrees(+02.79680783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137149"},
        {"Hipparcos Number", "HIP 75392"},
        {"Fundamental Katalog 5th Edition", "FK5 5363"},
        {"Smithsonian Astrophysical Observation", "SAO 120980"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08066669),
        dec: Angle.Degrees(+02.79723334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123739"},
        {"Hipparcos Number", "HIP 69165"},
        {"Smithsonian Astrophysical Observation", "SAO 120316"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.36714463),
        dec: Angle.Degrees(+02.79758054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86027"},
        {"Hipparcos Number", "HIP 48704"},
        {"Smithsonian Astrophysical Observation", "SAO 117998"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.99827221),
        dec: Angle.Degrees(+02.79877300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6698 B"},
        {"Hipparcos Number", "HIP 40473"},
        {"Smithsonian Astrophysical Observation", "SAO 116552"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.95624444),
        dec: Angle.Degrees(+02.79967456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17331"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.64571214),
        dec: Angle.Degrees(+02.80075059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40469",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6698 A"},
        {"Henry Draper", "HD 69178"},
        {"Hipparcos Number", "HIP 40469"},
        {"Smithsonian Astrophysical Observation", "SAO 116551"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.95225984),
        dec: Angle.Degrees(+02.80137746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104735",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14750 AB"},
        {"Henry Draper", "HD 201982"},
        {"Hipparcos Number", "HIP 104735"},
        {"Smithsonian Astrophysical Observation", "SAO 126622"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.24931536),
        dec: Angle.Degrees(+02.80255077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19908"},
    },
    visualMagnitude: 11.67,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.06049102),
        dec: Angle.Degrees(+02.80528180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48596"},
        {"Hipparcos Number", "HIP 32276"},
        {"Smithsonian Astrophysical Observation", "SAO 114343"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.07808016),
        dec: Angle.Degrees(+02.80810272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42983"},
        {"Hipparcos Number", "HIP 29573"},
        {"Cincinnati Publication", "Ci 18 777"},
        {"Geneva Identification System", "GEN# +1.00042983"},
        {"Smithsonian Astrophysical Observation", "SAO 113610"},
        {"Wilson Evans Batten Catalogue", "WEB 5815"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.46966294),
        dec: Angle.Degrees(+02.80949722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166917"},
        {"Hipparcos Number", "HIP 89242"},
        {"Geneva Identification System", "GEN# +1.00166917"},
        {"Smithsonian Astrophysical Observation", "SAO 123250"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.16814586),
        dec: Angle.Degrees(+02.81281221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2344"},
        {"Hipparcos Number", "HIP 2166"},
        {"Geneva Identification System", "GEN# +1.00002344"},
        {"Smithsonian Astrophysical Observation", "SAO 109216"},
        {"Wilson Evans Batten Catalogue", "WEB 401"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.83443628),
        dec: Angle.Degrees(+02.81412038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12484"},
        {"Hipparcos Number", "HIP 9519"},
        {"Smithsonian Astrophysical Observation", "SAO 110293"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.61128896),
        dec: Angle.Degrees(+02.81587955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17012"},
        {"Hipparcos Number", "HIP 12743"},
        {"Geneva Identification System", "GEN# +1.00017012"},
        {"Smithsonian Astrophysical Observation", "SAO 110713"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.95769860),
        dec: Angle.Degrees(+02.81724435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100355",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100355"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.29454774),
        dec: Angle.Degrees(+02.81826961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90825"},
        {"Hipparcos Number", "HIP 51346"},
        {"Smithsonian Astrophysical Observation", "SAO 118330"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.32656666),
        dec: Angle.Degrees(+02.81832029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7182 A"},
        {"Henry Draper", "HD 78126"},
        {"Henry Draper 2", "HD 78126A"},
        {"Hipparcos Number", "HIP 44711"},
        {"Smithsonian Astrophysical Observation", "SAO 117428"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.65949421),
        dec: Angle.Degrees(+02.81832375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220337"},
        {"Hipparcos Number", "HIP 115428"},
        {"Fundamental Katalog 5th Edition", "FK5 6065"},
        {"Smithsonian Astrophysical Observation", "SAO 128150"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.72172630),
        dec: Angle.Degrees(+02.81834336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7182 B"},
        {"Henry Draper", "HD 78126B"},
        {"Hipparcos Number", "HIP 44710"},
        {"Smithsonian Astrophysical Observation", "SAO 117427"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.65624497),
        dec: Angle.Degrees(+02.81854638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14385"},
        {"Hipparcos Number", "HIP 10838"},
        {"Geneva Identification System", "GEN# +1.00014385"},
        {"Smithsonian Astrophysical Observation", "SAO 110474"},
        {"Wilson Evans Batten Catalogue", "WEB 2285"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.86948492),
        dec: Angle.Degrees(+02.82034101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57370",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Flegetonte"},
        {"Henry Draper", "HD 102195"},
        {"Hipparcos Number", "HIP 57370"},
        {"Smithsonian Astrophysical Observation", "SAO 119033"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.42667979),
        dec: Angle.Degrees(+02.82175422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15584"},
        {"Hipparcos Number", "HIP 11666"},
        {"Smithsonian Astrophysical Observation", "SAO 110580"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.62408830),
        dec: Angle.Degrees(+02.82312456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85812",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10614 AB"},
        {"Henry Draper", "HD 158976"},
        {"Hipparcos Number", "HIP 85812"},
        {"Smithsonian Astrophysical Observation", "SAO 122481"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.01196939),
        dec: Angle.Degrees(+02.82372436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25621"},
        {"Hipparcos Number", "HIP 18993"},
        {"Fundamental Katalog 5th Edition", "FK5 2292"},
        {"Geneva Identification System", "GEN# +1.00025621"},
        {"Smithsonian Astrophysical Observation", "SAO 111590"},
        {"Wilson Evans Batten Catalogue", "WEB 3652"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.04078184),
        dec: Angle.Degrees(+02.82725258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134754"},
        {"Hipparcos Number", "HIP 74328"},
        {"Geneva Identification System", "GEN# +1.00134754"},
        {"Smithsonian Astrophysical Observation", "SAO 120884"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.87465342),
        dec: Angle.Degrees(+02.82843795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118221"},
    },
    visualMagnitude: 12.46,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70341248),
        dec: Angle.Degrees(+02.83060878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69113"},
        {"Hipparcos Number", "HIP 40450"},
        {"Smithsonian Astrophysical Observation", "SAO 116544"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.88092512),
        dec: Angle.Degrees(+02.83222090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36429"},
        {"Hipparcos Number", "HIP 25897"},
        {"Celescope Catalog", "CEL 757"},
        {"Geneva Identification System", "GEN# +1.00036429"},
        {"Renson", "Renson 9420"},
        {"Smithsonian Astrophysical Observation", "SAO 112873"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.92176365),
        dec: Angle.Degrees(+02.83283006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154479"},
        {"Hipparcos Number", "HIP 83633"},
        {"Geneva Identification System", "GEN# +1.00154479"},
        {"Smithsonian Astrophysical Observation", "SAO 122065"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.38266600),
        dec: Angle.Degrees(+02.83348539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40186"},
    },
    visualMagnitude: 12.37,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.13255184),
        dec: Angle.Degrees(+02.83474158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81795"},
        {"Hipparcos Number", "HIP 46418"},
        {"Geneva Identification System", "GEN# +1.00081795"},
        {"Smithsonian Astrophysical Observation", "SAO 117711"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98533525),
        dec: Angle.Degrees(+02.83530496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128426"},
        {"Hipparcos Number", "HIP 71455"},
        {"Smithsonian Astrophysical Observation", "SAO 120559"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.18721802),
        dec: Angle.Degrees(+02.83913163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72954"},
    },
    visualMagnitude: 12.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.65003707),
        dec: Angle.Degrees(+02.84174629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71955"},
        {"Hipparcos Number", "HIP 41712"},
        {"Smithsonian Astrophysical Observation", "SAO 116832"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.59488449),
        dec: Angle.Degrees(+02.84361543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91165"},
        {"Hipparcos Number", "HIP 51538"},
        {"Smithsonian Astrophysical Observation", "SAO 118347"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.90115051),
        dec: Angle.Degrees(+02.84482369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19575"},
        {"Hipparcos Number", "HIP 14639"},
        {"Smithsonian Astrophysical Observation", "SAO 111008"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.28511022),
        dec: Angle.Degrees(+02.84569638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101305"},
        {"Hipparcos Number", "HIP 56859"},
        {"Smithsonian Astrophysical Observation", "SAO 118977"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.86905191),
        dec: Angle.Degrees(+02.84633502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13586 A"},
        {"Henry Draper", "HD 192586"},
        {"Hipparcos Number", "HIP 99856"},
        {"Geneva Identification System", "GEN# +1.00192586"},
        {"Smithsonian Astrophysical Observation", "SAO 125616"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.88548486),
        dec: Angle.Degrees(+02.84656994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45901"},
        {"Hipparcos Number", "HIP 30992"},
        {"Geneva Identification System", "GEN# +5.10960001"},
        {"Smithsonian Astrophysical Observation", "SAO 113968"},
        {"Wilson Evans Batten Catalogue", "WEB 6171"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.57345492),
        dec: Angle.Degrees(+02.84789614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142722"},
        {"Hipparcos Number", "HIP 78030"},
        {"Geneva Identification System", "GEN# +1.00142722"},
        {"Smithsonian Astrophysical Observation", "SAO 121269"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.98843919),
        dec: Angle.Degrees(+02.84799548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17013"},
        {"Smithsonian Astrophysical Observation", "SAO 111316"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.71092381),
        dec: Angle.Degrees(+02.84845767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20988"},
        {"Hipparcos Number", "HIP 15779"},
        {"Geneva Identification System", "GEN# +1.00020988"},
        {"Smithsonian Astrophysical Observation", "SAO 111160"},
        {"Wilson Evans Batten Catalogue", "WEB 3016"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.83465556),
        dec: Angle.Degrees(+02.84908581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100668"},
        {"Hipparcos Number", "HIP 56513"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.78622816),
        dec: Angle.Degrees(+02.84949118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110292"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.10137177),
        dec: Angle.Degrees(+02.85168473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116139"},
        {"Hipparcos Number", "HIP 65192"},
        {"Smithsonian Astrophysical Observation", "SAO 119898"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.40382516),
        dec: Angle.Degrees(+02.85404864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159121"},
        {"Hipparcos Number", "HIP 85861"},
        {"Smithsonian Astrophysical Observation", "SAO 122488"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.18528466),
        dec: Angle.Degrees(+02.85518302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9654 AB"},
        {"Henry Draper", "HD 137844"},
        {"Hipparcos Number", "HIP 75724"},
        {"Geneva Identification System", "GEN# +1.00137844J"},
        {"Smithsonian Astrophysical Observation", "SAO 121015"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.05391325),
        dec: Angle.Degrees(+02.85599682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199894"},
        {"Hipparcos Number", "HIP 103638"},
        {"Smithsonian Astrophysical Observation", "SAO 126445"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.96740398),
        dec: Angle.Degrees(+02.85600110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99648"},
        {"Hipparcos Number", "HIP 55945"},
        {"Fundamental Katalog 5th Edition", "FK5 1297"},
        {"Geneva Identification System", "GEN# +1.00099648"},
        {"Smithsonian Astrophysical Observation", "SAO 118875"},
        {"Wilson Evans Batten Catalogue", "WEB 10045"},
    },
    visualMagnitude: 4.95,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98429124),
        dec: Angle.Degrees(+02.85629071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35423",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35423"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.70451933),
        dec: Angle.Degrees(+02.85788136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56845"},
        {"Hipparcos Number", "HIP 35425"},
        {"Smithsonian Astrophysical Observation", "SAO 115243"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71168685),
        dec: Angle.Degrees(+02.85836528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186794"},
        {"Hipparcos Number", "HIP 97298"},
        {"Fundamental Katalog 5th Edition", "FK5 5744"},
        {"Smithsonian Astrophysical Observation", "SAO 125043"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.61999046),
        dec: Angle.Degrees(+02.85863540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154894"},
        {"Hipparcos Number", "HIP 83836"},
        {"Smithsonian Astrophysical Observation", "SAO 122107"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.00567548),
        dec: Angle.Degrees(+02.85958762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33856"},
        {"Hipparcos Number", "HIP 24331"},
        {"Geneva Identification System", "GEN# +1.00033856J"},
        {"Smithsonian Astrophysical Observation", "SAO 112528"},
        {"Wilson Evans Batten Catalogue", "WEB 4721"},
    },
    visualMagnitude: 4.46,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.32283171),
        dec: Angle.Degrees(+02.86125346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96399"},
        {"Hipparcos Number", "HIP 54326"},
        {"Smithsonian Astrophysical Observation", "SAO 118665"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.70570793),
        dec: Angle.Degrees(+02.86131462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37467"},
        {"Hipparcos Number", "HIP 26561"},
        {"Geneva Identification System", "GEN# +1.00037467"},
        {"Smithsonian Astrophysical Observation", "SAO 112994"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.71931536),
        dec: Angle.Degrees(+02.86177587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98603"},
        {"Hipparcos Number", "HIP 55408"},
        {"Smithsonian Astrophysical Observation", "SAO 118800"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.20131013),
        dec: Angle.Degrees(+02.86227559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79395"},
        {"Hipparcos Number", "HIP 45299"},
        {"Smithsonian Astrophysical Observation", "SAO 117518"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.47724924),
        dec: Angle.Degrees(+02.86288289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41253"},
        {"Hipparcos Number", "HIP 28718"},
        {"Geneva Identification System", "GEN# +1.00041253"},
        {"Smithsonian Astrophysical Observation", "SAO 113416"},
        {"Wilson Evans Batten Catalogue", "WEB 5618"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.99224985),
        dec: Angle.Degrees(+02.86437422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216230"},
        {"Hipparcos Number", "HIP 112852"},
        {"Smithsonian Astrophysical Observation", "SAO 127798"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.80557415),
        dec: Angle.Degrees(+02.86675823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60825"},
        {"Hipparcos Number", "HIP 37016"},
        {"Smithsonian Astrophysical Observation", "SAO 115691"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.11856061),
        dec: Angle.Degrees(+02.86778454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116786"},
        {"Geneva Identification System", "GEN# +0.00204699"},
        {"Smithsonian Astrophysical Observation", "SAO 128313"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.02162332),
        dec: Angle.Degrees(+02.86846769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3065 AB"},
        {"Henry Draper", "HD 26678"},
        {"Hipparcos Number", "HIP 19712"},
        {"Smithsonian Astrophysical Observation", "SAO 111669"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.34601676),
        dec: Angle.Degrees(+02.86882067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36116"},
        {"Hipparcos Number", "HIP 25719"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.37231791),
        dec: Angle.Degrees(+02.86907509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42256"},
        {"Hipparcos Number", "HIP 29236"},
        {"Smithsonian Astrophysical Observation", "SAO 113530"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.45474257),
        dec: Angle.Degrees(+02.86962287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148390"},
        {"Hipparcos Number", "HIP 80610"},
        {"Smithsonian Astrophysical Observation", "SAO 121614"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.88444640),
        dec: Angle.Degrees(+02.87065873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12415"},
        {"Hipparcos Number", "HIP 9466"},
        {"Cincinnati Publication", "Ci 18 220"},
        {"Smithsonian Astrophysical Observation", "SAO 110287"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.45684669),
        dec: Angle.Degrees(+02.87191989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208279"},
        {"Hipparcos Number", "HIP 108190"},
        {"Smithsonian Astrophysical Observation", "SAO 127155"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.78528173),
        dec: Angle.Degrees(+02.87413825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147510"},
        {"Hipparcos Number", "HIP 80187"},
        {"Smithsonian Astrophysical Observation", "SAO 121543"},
        {"Wilson Evans Batten Catalogue", "WEB 13575"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.56271095),
        dec: Angle.Degrees(+02.87543506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185703"},
        {"Hipparcos Number", "HIP 96774"},
        {"Smithsonian Astrophysical Observation", "SAO 124916"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.05961024),
        dec: Angle.Degrees(+02.87604527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223498"},
        {"Hipparcos Number", "HIP 117526"},
        {"Cincinnati Publication", "Ci 20 1455"},
        {"Cincinnati Publication 2", "Ci 18 3126"},
        {"Geneva Identification System", "GEN# +1.00223498"},
        {"Smithsonian Astrophysical Observation", "SAO 128407"},
        {"Wilson Evans Batten Catalogue", "WEB 20697"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.52282605),
        dec: Angle.Degrees(+02.87672110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 458.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101691"},
        {"Hipparcos Number", "HIP 57084"},
        {"Geneva Identification System", "GEN# +1.00101691"},
        {"Smithsonian Astrophysical Observation", "SAO 119002"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.53804491),
        dec: Angle.Degrees(+02.87836632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163775"},
        {"Hipparcos Number", "HIP 87932"},
        {"Smithsonian Astrophysical Observation", "SAO 122962"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.44020097),
        dec: Angle.Degrees(+02.88005482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139953"},
        {"Hipparcos Number", "HIP 76818"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.25819086),
        dec: Angle.Degrees(+02.88179335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8972"},
        {"Geneva Identification System", "GEN# +9.80071043"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.90616507),
        dec: Angle.Degrees(+02.88357344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -297.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141828"},
        {"Hipparcos Number", "HIP 77636"},
        {"Smithsonian Astrophysical Observation", "SAO 121219"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.74608756),
        dec: Angle.Degrees(+02.88387215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105438",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14894 AB"},
        {"Henry Draper", "HD 203323"},
        {"Hipparcos Number", "HIP 105438"},
        {"Geneva Identification System", "GEN# +1.00203323J"},
        {"Smithsonian Astrophysical Observation", "SAO 126724"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34872513),
        dec: Angle.Degrees(+02.88739061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94349"},
        {"Cincinnati Publication", "Ci 20 1136"},
        {"Geneva Identification System", "GEN# +6.10010748"},
        {"Geneva Identification System 2", "GEN# +9.80022018"},
        {"Wilson Evans Batten Catalogue", "WEB 16435"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.05646821),
        dec: Angle.Degrees(+02.88766813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1789.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -520.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151191"},
        {"Hipparcos Number", "HIP 82063"},
        {"Smithsonian Astrophysical Observation", "SAO 121839"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.44449278),
        dec: Angle.Degrees(+02.88767290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5625 AB"},
        {"Henry Draper", "HD 51449"},
        {"Hipparcos Number", "HIP 33474"},
        {"Smithsonian Astrophysical Observation", "SAO 114683"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.37104229),
        dec: Angle.Degrees(+02.88798945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59918"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.36624721),
        dec: Angle.Degrees(+02.88805548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104100"},
        {"Hipparcos Number", "HIP 58472"},
        {"Smithsonian Astrophysical Observation", "SAO 119151"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.86637037),
        dec: Angle.Degrees(+02.88899425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223176"},
        {"Hipparcos Number", "HIP 117319"},
        {"Geneva Identification System", "GEN# +1.00223176"},
        {"Smithsonian Astrophysical Observation", "SAO 128380"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.83236769),
        dec: Angle.Degrees(+02.88916520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132832"},
        {"Hipparcos Number", "HIP 73480"},
        {"Geneva Identification System", "GEN# +1.00132832"},
        {"Smithsonian Astrophysical Observation", "SAO 120794"},
        {"Wilson Evans Batten Catalogue", "WEB 12575"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.25599580),
        dec: Angle.Degrees(+02.89765004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116830"},
        {"Hipparcos Number", "HIP 65538"},
        {"Smithsonian Astrophysical Observation", "SAO 119922"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53344838),
        dec: Angle.Degrees(+02.89810501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16708"},
        {"Hipparcos Number", "HIP 12496"},
        {"Geneva Identification System", "GEN# +1.00016708"},
        {"Smithsonian Astrophysical Observation", "SAO 110677"},
        {"Wilson Evans Batten Catalogue", "WEB 2558"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.19712418),
        dec: Angle.Degrees(+02.89843191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46558"},
        {"Hipparcos Number", "HIP 31326"},
        {"Geneva Identification System", "GEN# +1.00046558"},
        {"Smithsonian Astrophysical Observation", "SAO 114065"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.53507622),
        dec: Angle.Degrees(+02.89857425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10844 AB"},
        {"Henry Draper", "HD 162628"},
        {"Hipparcos Number", "HIP 87417"},
        {"Smithsonian Astrophysical Observation", "SAO 122841"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96897839),
        dec: Angle.Degrees(+02.89983351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147114"},
        {"Hipparcos Number", "HIP 79991"},
        {"Smithsonian Astrophysical Observation", "SAO 121503"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.93499458),
        dec: Angle.Degrees(+02.90125965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42353"},
        {"Hipparcos Number", "HIP 29282"},
        {"Geneva Identification System", "GEN# +1.00042353"},
        {"Smithsonian Astrophysical Observation", "SAO 113542"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.59912042),
        dec: Angle.Degrees(+02.90187078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55806"},
        {"Hipparcos Number", "HIP 35021"},
        {"Smithsonian Astrophysical Observation", "SAO 115127"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.66022548),
        dec: Angle.Degrees(+02.90193383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109343",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109343"},
        {"Geneva Identification System", "GEN# +9.80018033"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.27337953),
        dec: Angle.Degrees(+02.90213651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 297.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215056"},
        {"Hipparcos Number", "HIP 112110"},
        {"Geneva Identification System", "GEN# +1.00215056"},
        {"Smithsonian Astrophysical Observation", "SAO 127701"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.63287153),
        dec: Angle.Degrees(+02.90228442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115755"},
        {"Hipparcos Number", "HIP 64984"},
        {"Geneva Identification System", "GEN# +1.00115755"},
        {"Smithsonian Astrophysical Observation", "SAO 119873"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.77865149),
        dec: Angle.Degrees(+02.90356362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14014"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.10436164),
        dec: Angle.Degrees(+02.90363173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12520 A"},
        {"Henry Draper", "HD 183589"},
        {"Hipparcos Number", "HIP 95898"},
        {"Geneva Identification System", "GEN# +1.00183589"},
        {"Smithsonian Astrophysical Observation", "SAO 124698"},
        {"Wilson Evans Batten Catalogue", "WEB 16791"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.54389021),
        dec: Angle.Degrees(+02.90407568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4569"},
        {"Hipparcos Number", "HIP 3722"},
        {"Smithsonian Astrophysical Observation", "SAO 109463"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.94654617),
        dec: Angle.Degrees(+02.90412802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38675"},
        {"Hipparcos Number", "HIP 27348"},
        {"Smithsonian Astrophysical Observation", "SAO 113144"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.88976993),
        dec: Angle.Degrees(+02.90675777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32218"},
        {"Hipparcos Number", "HIP 23385"},
        {"Geneva Identification System", "GEN# +1.00032218"},
        {"Smithsonian Astrophysical Observation", "SAO 112327"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.40817741),
        dec: Angle.Degrees(+02.90697657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43945"},
        {"Smithsonian Astrophysical Observation", "SAO 117289"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.26115421),
        dec: Angle.Degrees(+02.90768369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45415"},
        {"Hipparcos Number", "HIP 30728"},
        {"Geneva Identification System", "GEN# +1.00045415"},
        {"Smithsonian Astrophysical Observation", "SAO 113906"},
        {"Wilson Evans Batten Catalogue", "WEB 6127"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.83531772),
        dec: Angle.Degrees(+02.90825624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153403"},
        {"Hipparcos Number", "HIP 83129"},
        {"Smithsonian Astrophysical Observation", "SAO 121978"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.82403569),
        dec: Angle.Degrees(+02.90886362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40837"},
        {"Hipparcos Number", "HIP 28542"},
        {"Smithsonian Astrophysical Observation", "SAO 113377"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.38022421),
        dec: Angle.Degrees(+02.90928595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31083",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5161 A"},
        {"Henry Draper", "HD 46090"},
        {"Hipparcos Number", "HIP 31083"},
        {"Geneva Identification System", "GEN# +1.00046090"},
        {"Smithsonian Astrophysical Observation", "SAO 113993"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.83981164),
        dec: Angle.Degrees(+02.91126900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186589"},
        {"Hipparcos Number", "HIP 97188"},
        {"Geneva Identification System", "GEN# +1.00186589"},
        {"Smithsonian Astrophysical Observation", "SAO 125020"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.30184927),
        dec: Angle.Degrees(+02.91194861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109288"},
        {"Hipparcos Number", "HIP 61303"},
        {"Smithsonian Astrophysical Observation", "SAO 119469"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.40423123),
        dec: Angle.Degrees(+02.91200292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184663"},
        {"Hipparcos Number", "HIP 96351"},
        {"Geneva Identification System", "GEN# +1.00184663"},
        {"Smithsonian Astrophysical Observation", "SAO 124823"},
        {"Wilson Evans Batten Catalogue", "WEB 16893"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.85469016),
        dec: Angle.Degrees(+02.91347598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28035"},
        {"Hipparcos Number", "HIP 20668"},
        {"Smithsonian Astrophysical Observation", "SAO 111809"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41719127),
        dec: Angle.Degrees(+02.91394819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145478"},
        {"Hipparcos Number", "HIP 79304"},
        {"Smithsonian Astrophysical Observation", "SAO 121411"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.77688538),
        dec: Angle.Degrees(+02.91444067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28650"},
        {"Hipparcos Number", "HIP 21085"},
        {"Smithsonian Astrophysical Observation", "SAO 111867"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.78711809),
        dec: Angle.Degrees(+02.91446530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40726"},
        {"Hipparcos Number", "HIP 28485"},
        {"Geneva Identification System", "GEN# +1.00040726"},
        {"Smithsonian Astrophysical Observation", "SAO 113362"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.20553324),
        dec: Angle.Degrees(+02.91600572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55437"},
        {"Hipparcos Number", "HIP 34874"},
        {"Geneva Identification System", "GEN# +1.00055437"},
        {"Smithsonian Astrophysical Observation", "SAO 115085"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.23643724),
        dec: Angle.Degrees(+02.91839451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203522"},
        {"Hipparcos Number", "HIP 105548"},
        {"Geneva Identification System", "GEN# +1.00203522"},
        {"Renson", "Renson 56670"},
        {"Smithsonian Astrophysical Observation", "SAO 126744"},
        {"Wilson Evans Batten Catalogue", "WEB 19162"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.64967481),
        dec: Angle.Degrees(+02.91853247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16640"},
        {"Hipparcos Number", "HIP 12440"},
        {"Smithsonian Astrophysical Observation", "SAO 110672"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.03606279),
        dec: Angle.Degrees(+02.91870970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47419"},
        {"Hipparcos Number", "HIP 31756"},
        {"Smithsonian Astrophysical Observation", "SAO 114188"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.64029105),
        dec: Angle.Degrees(+02.92010929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112727"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.42892198),
        dec: Angle.Degrees(+02.92088584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171050"},
        {"Hipparcos Number", "HIP 90895"},
        {"Geneva Identification System", "GEN# +1.00171050"},
        {"Smithsonian Astrophysical Observation", "SAO 123614"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.11016317),
        dec: Angle.Degrees(+02.92360559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139136"},
        {"Hipparcos Number", "HIP 76409"},
        {"Smithsonian Astrophysical Observation", "SAO 121088"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.09497262),
        dec: Angle.Degrees(+02.92602088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34888"},
        {"Hipparcos Number", "HIP 24967"},
        {"Geneva Identification System", "GEN# +1.00034888"},
        {"Smithsonian Astrophysical Observation", "SAO 112655"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.21769688),
        dec: Angle.Degrees(+02.92881386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51061",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7769 AB"},
        {"Henry Draper", "HD 90361"},
        {"Hipparcos Number", "HIP 51061"},
        {"Smithsonian Astrophysical Observation", "SAO 118296"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.49449858),
        dec: Angle.Degrees(+02.92921546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183227"},
        {"Hipparcos Number", "HIP 95732"},
        {"Geneva Identification System", "GEN# +1.00183227"},
        {"Smithsonian Astrophysical Observation", "SAO 124661"},
        {"Wilson Evans Batten Catalogue", "WEB 16751"},
    },
    visualMagnitude: 5.84,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.08665305),
        dec: Angle.Degrees(+02.93006720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223719"},
        {"Hipparcos Number", "HIP 117683"},
        {"Fundamental Katalog 5th Edition", "FK5 3918"},
        {"Geneva Identification System", "GEN# +1.00223719"},
        {"Smithsonian Astrophysical Observation", "SAO 128427"},
        {"Wilson Evans Batten Catalogue", "WEB 20710"},
    },
    visualMagnitude: 5.59,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.99095935),
        dec: Angle.Degrees(+02.93041943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88192",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10966 A"},
        {"Henry Draper", "HD 164353"},
        {"Hipparcos Number", "HIP 88192"},
        {"Fundamental Katalog 5th Edition", "FK5 677"},
        {"Geneva Identification System", "GEN# +1.00164353J"},
        {"Smithsonian Astrophysical Observation", "SAO 123013"},
        {"Wilson Evans Batten Catalogue", "WEB 14902"},
    },
    visualMagnitude: 3.93,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.16131466),
        dec: Angle.Degrees(+02.93158759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179970"},
        {"Hipparcos Number", "HIP 94541"},
        {"Smithsonian Astrophysical Observation", "SAO 124427"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.63029719),
        dec: Angle.Degrees(+02.93237769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31452"},
        {"Hipparcos Number", "HIP 22940"},
        {"Cincinnati Publication", "Ci 18 633"},
        {"Geneva Identification System", "GEN# +1.00031452"},
        {"Smithsonian Astrophysical Observation", "SAO 112229"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.04419263),
        dec: Angle.Degrees(+02.93488748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65372"},
        {"Hipparcos Number", "HIP 38972"},
        {"Geneva Identification System", "GEN# +1.00065372"},
        {"Smithsonian Astrophysical Observation", "SAO 116186"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.62637992),
        dec: Angle.Degrees(+02.93587585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25443",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4033 AB"},
        {"Henry Draper", "HD 35673"},
        {"Hipparcos Number", "HIP 25443"},
        {"Celescope Catalog", "CEL 697"},
        {"Geneva Identification System", "GEN# +1.00035673J"},
        {"Smithsonian Astrophysical Observation", "SAO 112765"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.63007717),
        dec: Angle.Degrees(+02.93592103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33403"},
        {"Hipparcos Number", "HIP 24048"},
        {"Smithsonian Astrophysical Observation", "SAO 112489"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.52048761),
        dec: Angle.Degrees(+02.93593378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194953"},
        {"Hipparcos Number", "HIP 100969"},
        {"Geneva Identification System", "GEN# +1.00194953"},
        {"Smithsonian Astrophysical Observation", "SAO 125843"},
        {"Wilson Evans Batten Catalogue", "WEB 18238"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.06986982),
        dec: Angle.Degrees(+02.93715202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225221"},
        {"Hipparcos Number", "HIP 368"},
        {"Smithsonian Astrophysical Observation", "SAO 108995"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.15607578),
        dec: Angle.Degrees(+02.93722463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95079",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12329 AB"},
        {"Henry Draper", "HD 181527"},
        {"Hipparcos Number", "HIP 95079"},
        {"Renson", "Renson 50270"},
        {"Smithsonian Astrophysical Observation", "SAO 124525"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.16206346),
        dec: Angle.Degrees(+02.93765984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99629"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.29566345),
        dec: Angle.Degrees(+02.93888174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109984"},
        {"Hipparcos Number", "HIP 61714"},
        {"Smithsonian Astrophysical Observation", "SAO 119514"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.74430293),
        dec: Angle.Degrees(+02.93921360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80678"},
        {"Hipparcos Number", "HIP 45866"},
        {"Geneva Identification System", "GEN# +1.00080678"},
        {"Smithsonian Astrophysical Observation", "SAO 117611"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.28760237),
        dec: Angle.Degrees(+02.94101672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19155"},
        {"Hipparcos Number", "HIP 14348"},
        {"Geneva Identification System", "GEN# +1.00019155"},
        {"Smithsonian Astrophysical Observation", "SAO 110948"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.26159579),
        dec: Angle.Degrees(+02.94118960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44958",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7215 AB"},
        {"Henry Draper", "HD 78637"},
        {"Hipparcos Number", "HIP 44958"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37947516),
        dec: Angle.Degrees(+02.94138052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200661"},
        {"Hipparcos Number", "HIP 104041"},
        {"Geneva Identification System", "GEN# +1.00200661"},
        {"Smithsonian Astrophysical Observation", "SAO 126519"},
        {"Wilson Evans Batten Catalogue", "WEB 18953"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.17346969),
        dec: Angle.Degrees(+02.94226021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8864 AB"},
        {"Henry Draper", "HD 115995"},
        {"Hipparcos Number", "HIP 65119"},
        {"Geneva Identification System", "GEN# +1.00115995"},
        {"Smithsonian Astrophysical Observation", "SAO 119889"},
        {"Wilson Evans Batten Catalogue", "WEB 11500"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.17335581),
        dec: Angle.Degrees(+02.94231688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44595"},
        {"Smithsonian Astrophysical Observation", "SAO 117409"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.27616298),
        dec: Angle.Degrees(+02.94257652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174438"},
        {"Hipparcos Number", "HIP 92446"},
        {"Smithsonian Astrophysical Observation", "SAO 123957"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.59216637),
        dec: Angle.Degrees(+02.94316992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201507"},
        {"Hipparcos Number", "HIP 104481"},
        {"Geneva Identification System", "GEN# +1.00201507"},
        {"Smithsonian Astrophysical Observation", "SAO 126587"},
        {"Wilson Evans Batten Catalogue", "WEB 19019"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.49273258),
        dec: Angle.Degrees(+02.94359966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67567"},
        {"Hipparcos Number", "HIP 39872"},
        {"Smithsonian Astrophysical Observation", "SAO 116391"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.17171269),
        dec: Angle.Degrees(+02.94519712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68018"},
        {"Hipparcos Number", "HIP 40036"},
        {"Geneva Identification System", "GEN# +1.00068018"},
        {"Smithsonian Astrophysical Observation", "SAO 116436"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.66832291),
        dec: Angle.Degrees(+02.94954604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1040",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 155 AB"},
        {"Henry Draper", "HD 866"},
        {"Hipparcos Number", "HIP 1040"},
        {"Smithsonian Astrophysical Observation", "SAO 109065"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.25187208),
        dec: Angle.Degrees(+02.94967547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176468"},
        {"Hipparcos Number", "HIP 93300"},
        {"Smithsonian Astrophysical Observation", "SAO 124142"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.05772854),
        dec: Angle.Degrees(+02.95030853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65079"},
        {"Hipparcos Number", "HIP 38855"},
        {"Geneva Identification System", "GEN# +1.00065079"},
        {"Smithsonian Astrophysical Observation", "SAO 116160"},
        {"Wilson Evans Batten Catalogue", "WEB 7609"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.26664629),
        dec: Angle.Degrees(+02.95084742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167923"},
        {"Hipparcos Number", "HIP 89611"},
        {"Fundamental Katalog 5th Edition", "FK5 5609"},
        {"Smithsonian Astrophysical Observation", "SAO 123324"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.30938590),
        dec: Angle.Degrees(+02.95356077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173651"},
        {"Hipparcos Number", "HIP 92101"},
        {"Geneva Identification System", "GEN# +1.00173651"},
        {"Smithsonian Astrophysical Observation", "SAO 123902"},
        {"Wilson Evans Batten Catalogue", "WEB 15873"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.55896125),
        dec: Angle.Degrees(+02.95366627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187406"},
        {"Hipparcos Number", "HIP 97555"},
        {"Geneva Identification System", "GEN# +1.00187406"},
        {"Smithsonian Astrophysical Observation", "SAO 125103"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.42867235),
        dec: Angle.Degrees(+02.95390374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3688 AB"},
        {"Henry Draper", "HD 32866"},
        {"Hipparcos Number", "HIP 23752"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.57873547),
        dec: Angle.Degrees(+02.95392497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109870"},
        {"Hipparcos Number", "HIP 61641"},
        {"Smithsonian Astrophysical Observation", "SAO 119504"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.53971730),
        dec: Angle.Degrees(+02.95525265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3652 AB"},
        {"Henry Draper", "HD 32541"},
        {"Hipparcos Number", "HIP 23571"},
        {"Smithsonian Astrophysical Observation", "SAO 112378"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.01720178),
        dec: Angle.Degrees(+02.95598056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8958",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1530 AB"},
        {"Hipparcos Number", "HIP 8958"},
        {"Smithsonian Astrophysical Observation", "SAO 110231"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.84174994),
        dec: Angle.Degrees(+02.95681803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194579"},
        {"Hipparcos Number", "HIP 100797"},
        {"Geneva Identification System", "GEN# +1.00194579"},
        {"Smithsonian Astrophysical Observation", "SAO 125805"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.56380411),
        dec: Angle.Degrees(+02.95717881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84940"},
        {"Smithsonian Astrophysical Observation", "SAO 122310"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.39033536),
        dec: Angle.Degrees(+02.95759309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35624"},
        {"Hipparcos Number", "HIP 25424"},
        {"Smithsonian Astrophysical Observation", "SAO 112758"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56185384),
        dec: Angle.Degrees(+02.95762617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66090"},
        {"Hipparcos Number", "HIP 39302"},
        {"Smithsonian Astrophysical Observation", "SAO 116258"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.53126157),
        dec: Angle.Degrees(+02.96062129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168203"},
        {"Hipparcos Number", "HIP 89702"},
        {"Smithsonian Astrophysical Observation", "SAO 123341"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.61059861),
        dec: Angle.Degrees(+02.96116217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85570"},
        {"Hipparcos Number", "HIP 48461"},
        {"Smithsonian Astrophysical Observation", "SAO 117966"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.21400047),
        dec: Angle.Degrees(+02.96161181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140848"},
        {"Hipparcos Number", "HIP 77201"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.45317375),
        dec: Angle.Degrees(+02.96267098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45159"},
        {"Smithsonian Astrophysical Observation", "SAO 117489"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.99532619),
        dec: Angle.Degrees(+02.96309665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31355"},
        {"Hipparcos Number", "HIP 22880"},
        {"Geneva Identification System", "GEN# +1.00031355"},
        {"Smithsonian Astrophysical Observation", "SAO 112207"},
        {"Wilson Evans Batten Catalogue", "WEB 4436"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.82720971),
        dec: Angle.Degrees(+02.96328901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162212"},
        {"Hipparcos Number", "HIP 87262"},
        {"Smithsonian Astrophysical Observation", "SAO 122799"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.46457098),
        dec: Angle.Degrees(+02.96333125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86563"},
        {"Hipparcos Number", "HIP 48971"},
        {"Smithsonian Astrophysical Observation", "SAO 118035"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.84505039),
        dec: Angle.Degrees(+02.96400865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49544"},
        {"Geneva Identification System", "GEN# +0.00302316"},
        {"Wilson Evans Batten Catalogue", "WEB 9141"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.73708450),
        dec: Angle.Degrees(+02.96465366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100530"},
    },
    visualMagnitude: 11.14,
    bvColour: 1.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.76433060),
        dec: Angle.Degrees(+02.96571631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91482"},
        {"Hipparcos Number", "HIP 51712"},
        {"Smithsonian Astrophysical Observation", "SAO 118363"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.48435213),
        dec: Angle.Degrees(+02.96654512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86820",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10748 A"},
        {"Henry Draper", "HD 161262"},
        {"Hipparcos Number", "HIP 86820"},
        {"Geneva Identification System", "GEN# +1.00161262"},
        {"Smithsonian Astrophysical Observation", "SAO 122688"},
        {"Wilson Evans Batten Catalogue", "WEB 14646"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.10038959),
        dec: Angle.Degrees(+02.96732613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53804",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8017 AB"},
        {"Hipparcos Number", "HIP 53804"},
    },
    visualMagnitude: 9.33,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.13505375),
        dec: Angle.Degrees(+02.96921827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82542"},
        {"Hipparcos Number", "HIP 46844"},
        {"Smithsonian Astrophysical Observation", "SAO 117760"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.18481922),
        dec: Angle.Degrees(+02.97028840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7022",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1190 AB"},
        {"Henry Draper", "HD 9181"},
        {"Hipparcos Number", "HIP 7022"},
        {"Smithsonian Astrophysical Observation", "SAO 109928"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.62141140),
        dec: Angle.Degrees(+02.97118114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1138 A"},
        {"Henry Draper", "HD 8686"},
        {"Hipparcos Number", "HIP 6679"},
        {"Geneva Identification System", "GEN# +1.00008686"},
        {"Smithsonian Astrophysical Observation", "SAO 109883"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.41935034),
        dec: Angle.Degrees(+02.97208511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203306"},
        {"Hipparcos Number", "HIP 105433"},
        {"Smithsonian Astrophysical Observation", "SAO 126723"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.34237120),
        dec: Angle.Degrees(+02.97419138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175228"},
        {"Hipparcos Number", "HIP 92772"},
        {"Smithsonian Astrophysical Observation", "SAO 124022"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.56184999),
        dec: Angle.Degrees(+02.97533848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171914"},
        {"Hipparcos Number", "HIP 91285"},
        {"Geneva Identification System", "GEN# +1.00171914"},
        {"Renson", "Renson 48170"},
        {"Smithsonian Astrophysical Observation", "SAO 123701"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.30080044),
        dec: Angle.Degrees(+02.97627471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24818"},
        {"Hipparcos Number", "HIP 18480"},
        {"Smithsonian Astrophysical Observation", "SAO 111517"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.24570981),
        dec: Angle.Degrees(+02.97675276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166991"},
        {"Hipparcos Number", "HIP 89277"},
        {"Smithsonian Astrophysical Observation", "SAO 123257"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.26598666),
        dec: Angle.Degrees(+02.98061833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35111"},
        {"Hipparcos Number", "HIP 25106"},
        {"Smithsonian Astrophysical Observation", "SAO 112690"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.63164317),
        dec: Angle.Degrees(+02.98332883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84527",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10432 AB"},
        {"Henry Draper", "HD 156298"},
        {"Hipparcos Number", "HIP 84527"},
        {"Smithsonian Astrophysical Observation", "SAO 122230"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.18869511),
        dec: Angle.Degrees(+02.98580305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10899 AB"},
        {"Henry Draper", "HD 163471"},
        {"Hipparcos Number", "HIP 87811"},
        {"Smithsonian Astrophysical Observation", "SAO 122936"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.06956901),
        dec: Angle.Degrees(+02.98585198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121665"},
        {"Hipparcos Number", "HIP 68110"},
        {"Geneva Identification System", "GEN# +1.00121665"},
        {"Smithsonian Astrophysical Observation", "SAO 120189"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.16932261),
        dec: Angle.Degrees(+02.98658066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98227",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13162 AB"},
        {"Henry Draper", "HD 188974"},
        {"Hipparcos Number", "HIP 98227"},
        {"Smithsonian Astrophysical Observation", "SAO 125280"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.42289980),
        dec: Angle.Degrees(+02.98876526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21880",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3395 AB"},
        {"Henry Draper", "HD 29839"},
        {"Hipparcos Number", "HIP 21880"},
        {"Smithsonian Astrophysical Observation", "SAO 111990"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.55712393),
        dec: Angle.Degrees(+02.99005124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219447"},
        {"Hipparcos Number", "HIP 114849"},
        {"Smithsonian Astrophysical Observation", "SAO 128070"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.95322738),
        dec: Angle.Degrees(+02.99076327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43728"},
        {"Hipparcos Number", "HIP 29921"},
        {"Smithsonian Astrophysical Observation", "SAO 113698"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.48102548),
        dec: Angle.Degrees(+02.99189386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15278 AB"},
        {"Henry Draper", "HD 206863"},
        {"Hipparcos Number", "HIP 107367"},
        {"Smithsonian Astrophysical Observation", "SAO 127036"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.20081763),
        dec: Angle.Degrees(+02.99212936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27408"},
        {"Hipparcos Number", "HIP 20190"},
        {"Smithsonian Astrophysical Observation", "SAO 111748"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.91030027),
        dec: Angle.Degrees(+02.99220674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162736"},
        {"Hipparcos Number", "HIP 87480"},
        {"Smithsonian Astrophysical Observation", "SAO 122857"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.11124597),
        dec: Angle.Degrees(+02.99421961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197315"},
        {"Hipparcos Number", "HIP 102221"},
        {"Smithsonian Astrophysical Observation", "SAO 126127"},
        {"Wilson Evans Batten Catalogue", "WEB 18496"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.68790204),
        dec: Angle.Degrees(+02.99532319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200580"},
        {"Hipparcos Number", "HIP 103987"},
        {"Cincinnati Publication", "Ci 20 1254"},
        {"Geneva Identification System", "GEN# +1.00200580"},
        {"Smithsonian Astrophysical Observation", "SAO 126509"},
        {"Wilson Evans Batten Catalogue", "WEB 18940"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.03145139),
        dec: Angle.Degrees(+02.99537712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -272.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -368.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195198"},
        {"Hipparcos Number", "HIP 101114"},
        {"Smithsonian Astrophysical Observation", "SAO 125863"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.43688846),
        dec: Angle.Degrees(+02.99623756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11809",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11809"},
        {"Geneva Identification System", "GEN# +6.10164144"},
    },
    visualMagnitude: 11.76,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.07161011),
        dec: Angle.Degrees(+02.99798291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65401"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.06695191),
        dec: Angle.Degrees(+02.99883796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16076"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.76277367),
        dec: Angle.Degrees(+02.99941554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198920"},
        {"Hipparcos Number", "HIP 103111"},
        {"Geneva Identification System", "GEN# +1.00198920"},
        {"Renson", "Renson 55380"},
        {"Smithsonian Astrophysical Observation", "SAO 126341"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.37465285),
        dec: Angle.Degrees(+03.00202260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213620"},
        {"Hipparcos Number", "HIP 111295"},
        {"Smithsonian Astrophysical Observation", "SAO 127589"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.19259013),
        dec: Angle.Degrees(+03.00525439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55848",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8162 B"},
        {"Henry Draper", "HD 99492"},
        {"Hipparcos Number", "HIP 55848"},
        {"Geneva Identification System", "GEN# +1.00099492"},
        {"Smithsonian Astrophysical Observation", "SAO 118865"},
        {"Wilson Evans Batten Catalogue", "WEB 10038"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.69459817),
        dec: Angle.Degrees(+03.00586353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -730.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 191.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158493"},
        {"Hipparcos Number", "HIP 85601"},
        {"Smithsonian Astrophysical Observation", "SAO 122431"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.37902311),
        dec: Angle.Degrees(+03.00736478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18"},
        {"Hipparcos Number", "HIP 433"},
        {"Smithsonian Astrophysical Observation", "SAO 109002"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.31190920),
        dec: Angle.Degrees(+03.00739806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64167"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.26539132),
        dec: Angle.Degrees(+03.00772973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133841"},
        {"Hipparcos Number", "HIP 73930"},
        {"Geneva Identification System", "GEN# +1.00133841"},
        {"Smithsonian Astrophysical Observation", "SAO 120839"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.61616423),
        dec: Angle.Degrees(+03.00902726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224382"},
        {"Hipparcos Number", "HIP 118104"},
        {"Geneva Identification System", "GEN# +1.00224382"},
        {"Smithsonian Astrophysical Observation", "SAO 128494"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.35151968),
        dec: Angle.Degrees(+03.00998914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217459"},
        {"Hipparcos Number", "HIP 113622"},
        {"Geneva Identification System", "GEN# +1.00217459"},
        {"Smithsonian Astrophysical Observation", "SAO 127894"},
        {"Wilson Evans Batten Catalogue", "WEB 20192"},
    },
    visualMagnitude: 5.85,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.17873968),
        dec: Angle.Degrees(+03.01200821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8162 A"},
        {"Henry Draper", "HD 99491"},
        {"Hipparcos Number", "HIP 55846"},
        {"Cincinnati Publication", "Ci 20 637"},
        {"Fundamental Katalog 5th Edition", "FK5 1296"},
        {"Geneva Identification System", "GEN# +1.00099491A"},
        {"Smithsonian Astrophysical Observation", "SAO 118864"},
        {"Wilson Evans Batten Catalogue", "WEB 10037"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.69060734),
        dec: Angle.Degrees(+03.01265989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -726.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 181.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100957",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100957"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.03673744),
        dec: Angle.Degrees(+03.01842344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66444"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.31508702),
        dec: Angle.Degrees(+03.02053334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152448"},
        {"Hipparcos Number", "HIP 82605"},
        {"Geneva Identification System", "GEN# +1.00152448"},
        {"Smithsonian Astrophysical Observation", "SAO 121922"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.31184534),
        dec: Angle.Degrees(+03.02076379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14667"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.37014831),
        dec: Angle.Degrees(+03.02122507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26794"},
        {"Hipparcos Number", "HIP 19788"},
        {"Cincinnati Publication", "Ci 18 563"},
        {"Geneva Identification System", "GEN# +1.00026794"},
        {"Smithsonian Astrophysical Observation", "SAO 111681"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.62598058),
        dec: Angle.Degrees(+03.02139704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 272.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65654"},
        {"Smithsonian Astrophysical Observation", "SAO 119935"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.91472901),
        dec: Angle.Degrees(+03.02418342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30222"},
        {"Hipparcos Number", "HIP 22139"},
        {"Smithsonian Astrophysical Observation", "SAO 112050"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.45913086),
        dec: Angle.Degrees(+03.02432754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75769"},
        {"Hipparcos Number", "HIP 43529"},
        {"Smithsonian Astrophysical Observation", "SAO 117207"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.98436544),
        dec: Angle.Degrees(+03.02435343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45554"},
        {"Geneva Identification System", "GEN# +9.80046031"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.26655574),
        dec: Angle.Degrees(+03.02560375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77712"},
        {"Hipparcos Number", "HIP 44520"},
        {"Geneva Identification System", "GEN# +1.00077712"},
        {"Smithsonian Astrophysical Observation", "SAO 117389"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.06265374),
        dec: Angle.Degrees(+03.02658524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81490"},
        {"Hipparcos Number", "HIP 46267"},
        {"Geneva Identification System", "GEN# +1.00081490"},
        {"Smithsonian Astrophysical Observation", "SAO 117686"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.50114111),
        dec: Angle.Degrees(+03.03028911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174719"},
        {"Hipparcos Number", "HIP 92569"},
        {"Geneva Identification System", "GEN# +1.00174719"},
        {"Smithsonian Astrophysical Observation", "SAO 123984"},
        {"Wilson Evans Batten Catalogue", "WEB 16013"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.95177431),
        dec: Angle.Degrees(+03.03136205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9432"},
        {"Hipparcos Number", "HIP 7196"},
        {"Geneva Identification System", "GEN# +1.00009432"},
        {"Smithsonian Astrophysical Observation", "SAO 109956"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.18532661),
        dec: Angle.Degrees(+03.03241518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1586"},
        {"Hipparcos Number", "HIP 1609"},
        {"Smithsonian Astrophysical Observation", "SAO 109146"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.03971809),
        dec: Angle.Degrees(+03.03357475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48348"},
        {"Hipparcos Number", "HIP 32177"},
        {"Geneva Identification System", "GEN# +1.00048348"},
        {"Smithsonian Astrophysical Observation", "SAO 114312"},
        {"Wilson Evans Batten Catalogue", "WEB 6490"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.77753650),
        dec: Angle.Degrees(+03.03382319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77711"},
        {"Hipparcos Number", "HIP 44518"},
        {"Smithsonian Astrophysical Observation", "SAO 117388"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.05777405),
        dec: Angle.Degrees(+03.03408872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155347"},
        {"Hipparcos Number", "HIP 84052"},
        {"Smithsonian Astrophysical Observation", "SAO 122151"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.74859574),
        dec: Angle.Degrees(+03.03885977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221481"},
        {"Hipparcos Number", "HIP 116185"},
        {"Smithsonian Astrophysical Observation", "SAO 128234"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.11828869),
        dec: Angle.Degrees(+03.04020492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50062"},
        {"Hipparcos Number", "HIP 32931"},
        {"Geneva Identification System", "GEN# +1.00050062"},
        {"Renson", "Renson 13610"},
        {"Smithsonian Astrophysical Observation", "SAO 114525"},
        {"Wilson Evans Batten Catalogue", "WEB 6631"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.91405812),
        dec: Angle.Degrees(+03.04206333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21052"},
        {"Hipparcos Number", "HIP 15830"},
        {"Smithsonian Astrophysical Observation", "SAO 111164"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97848822),
        dec: Angle.Degrees(+03.04356868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58275"},
        {"Hipparcos Number", "HIP 35991"},
        {"Smithsonian Astrophysical Observation", "SAO 115410"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.25213842),
        dec: Angle.Degrees(+03.04569811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39480"},
        {"Hipparcos Number", "HIP 27799"},
        {"Geneva Identification System", "GEN# +1.00039480"},
        {"Smithsonian Astrophysical Observation", "SAO 113229"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.24206003),
        dec: Angle.Degrees(+03.04823649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184947"},
        {"Hipparcos Number", "HIP 96464"},
        {"Smithsonian Astrophysical Observation", "SAO 124843"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.17490985),
        dec: Angle.Degrees(+03.04845243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60612"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.34387364),
        dec: Angle.Degrees(+03.04852519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115199"},
        {"Hipparcos Number", "HIP 64693"},
        {"Geneva Identification System", "GEN# +1.00115199"},
        {"Smithsonian Astrophysical Observation", "SAO 119834"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.88424517),
        dec: Angle.Degrees(+03.04908759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112235"},
        {"Hipparcos Number", "HIP 63056"},
        {"Geneva Identification System", "GEN# +1.00112235"},
        {"Smithsonian Astrophysical Observation", "SAO 119665"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.79623250),
        dec: Angle.Degrees(+03.04922284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218330"},
        {"Hipparcos Number", "HIP 114148"},
        {"Smithsonian Astrophysical Observation", "SAO 127977"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.76106633),
        dec: Angle.Degrees(+03.05220759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111765"},
        {"Hipparcos Number", "HIP 62757"},
        {"Geneva Identification System", "GEN# +1.00111765"},
        {"Smithsonian Astrophysical Observation", "SAO 119633"},
        {"Wilson Evans Batten Catalogue", "WEB 11127"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.90379424),
        dec: Angle.Degrees(+03.05673901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13314",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2178 AB"},
        {"Henry Draper", "HD 17779"},
        {"Hipparcos Number", "HIP 13314"},
        {"Smithsonian Astrophysical Observation", "SAO 110790"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.83671438),
        dec: Angle.Degrees(+03.05682280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22796"},
        {"Hipparcos Number", "HIP 17103"},
        {"Fundamental Katalog 5th Edition", "FK5 2258"},
        {"Geneva Identification System", "GEN# +1.00022796"},
        {"Smithsonian Astrophysical Observation", "SAO 111334"},
        {"Wilson Evans Batten Catalogue", "WEB 3247"},
    },
    visualMagnitude: 5.55,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.96309860),
        dec: Angle.Degrees(+03.05684307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36759"},
        {"Hipparcos Number", "HIP 26107"},
        {"Smithsonian Astrophysical Observation", "SAO 112902"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.51632828),
        dec: Angle.Degrees(+03.05750006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144331"},
        {"Hipparcos Number", "HIP 78793"},
        {"Geneva Identification System", "GEN# +1.00144331"},
        {"Smithsonian Astrophysical Observation", "SAO 121358"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.28721728),
        dec: Angle.Degrees(+03.05759632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24792"},
        {"Hipparcos Number", "HIP 18454"},
        {"Fundamental Katalog 5th Edition", "FK5 4358"},
        {"Smithsonian Astrophysical Observation", "SAO 111514"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.15721210),
        dec: Angle.Degrees(+03.05788610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100563"},
        {"Hipparcos Number", "HIP 56445"},
        {"Fundamental Katalog 5th Edition", "FK5 2924"},
        {"Geneva Identification System", "GEN# +1.00100563"},
        {"Smithsonian Astrophysical Observation", "SAO 118929"},
        {"Wilson Evans Batten Catalogue", "WEB 10143"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.59189996),
        dec: Angle.Degrees(+03.06041500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9967"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.08307119),
        dec: Angle.Degrees(+03.06084785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19648"},
        {"Hipparcos Number", "HIP 14704"},
        {"Geneva Identification System", "GEN# +1.00019648"},
        {"Smithsonian Astrophysical Observation", "SAO 111018"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.48679260),
        dec: Angle.Degrees(+03.06110728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8193 A"},
        {"Henry Draper", "HD 100129"},
        {"Hipparcos Number", "HIP 56209"},
        {"Smithsonian Astrophysical Observation", "SAO 118902"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.84727963),
        dec: Angle.Degrees(+03.06268566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74444"},
        {"Hipparcos Number", "HIP 42869"},
        {"Smithsonian Astrophysical Observation", "SAO 117075"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.04114943),
        dec: Angle.Degrees(+03.06326318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31624"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.27018736),
        dec: Angle.Degrees(+03.06396746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63437"},
        {"Smithsonian Astrophysical Observation", "SAO 119704"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.98566326),
        dec: Angle.Degrees(+03.06510809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75943"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.66632647),
        dec: Angle.Degrees(+03.06675189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90933"},
        {"Hipparcos Number", "HIP 51405"},
        {"Geneva Identification System", "GEN# +1.00090933"},
        {"Smithsonian Astrophysical Observation", "SAO 118336"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.49056878),
        dec: Angle.Degrees(+03.06725889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157583"},
        {"Hipparcos Number", "HIP 85153"},
        {"Smithsonian Astrophysical Observation", "SAO 122345"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.01401549),
        dec: Angle.Degrees(+03.06761080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146364"},
        {"Hipparcos Number", "HIP 79693"},
        {"Smithsonian Astrophysical Observation", "SAO 121457"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.96590112),
        dec: Angle.Degrees(+03.06828698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76011"},
        {"Hipparcos Number", "HIP 43653"},
        {"Geneva Identification System", "GEN# +1.00076011"},
        {"Smithsonian Astrophysical Observation", "SAO 117236"},
        {"Wilson Evans Batten Catalogue", "WEB 8405"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.39145830),
        dec: Angle.Degrees(+03.06845168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8614"},
        {"Hipparcos Number", "HIP 6630"},
        {"Geneva Identification System", "GEN# +1.00008614"},
        {"Smithsonian Astrophysical Observation", "SAO 109875"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.26705935),
        dec: Angle.Degrees(+03.07076481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102083"},
        {"Hipparcos Number", "HIP 57302"},
        {"Geneva Identification System", "GEN# +1.00102083"},
        {"Smithsonian Astrophysical Observation", "SAO 119023"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.24661052),
        dec: Angle.Degrees(+03.07139235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88611"},
        {"Hipparcos Number", "HIP 50057"},
        {"Geneva Identification System", "GEN# +1.00088611"},
        {"Smithsonian Astrophysical Observation", "SAO 118169"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.30561533),
        dec: Angle.Degrees(+03.07279255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46661"},
        {"Hipparcos Number", "HIP 31372"},
        {"Smithsonian Astrophysical Observation", "SAO 114084"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.67042106),
        dec: Angle.Degrees(+03.07342347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196974"},
        {"Hipparcos Number", "HIP 102028"},
        {"Smithsonian Astrophysical Observation", "SAO 126095"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.14450138),
        dec: Angle.Degrees(+03.07411725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124001"},
        {"Hipparcos Number", "HIP 69267"},
        {"Geneva Identification System", "GEN# +1.00124001"},
        {"Smithsonian Astrophysical Observation", "SAO 120328"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.70681131),
        dec: Angle.Degrees(+03.07752914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25521"},
        {"Hipparcos Number", "HIP 18921"},
        {"Geneva Identification System", "GEN# +1.00025521"},
        {"Smithsonian Astrophysical Observation", "SAO 111580"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.82929717),
        dec: Angle.Degrees(+03.07765212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203382"},
        {"Hipparcos Number", "HIP 105466"},
        {"Geneva Identification System", "GEN# +1.00203382"},
        {"Smithsonian Astrophysical Observation", "SAO 126729"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.43634090),
        dec: Angle.Degrees(+03.07796043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126600"},
        {"Hipparcos Number", "HIP 70600"},
        {"Smithsonian Astrophysical Observation", "SAO 120461"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.61037974),
        dec: Angle.Degrees(+03.07940167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96361"},
        {"Hipparcos Number", "HIP 54307"},
        {"Smithsonian Astrophysical Observation", "SAO 118663"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.65164045),
        dec: Angle.Degrees(+03.07943665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82267"},
        {"Hipparcos Number", "HIP 46690"},
        {"Geneva Identification System", "GEN# +1.00082267"},
        {"Smithsonian Astrophysical Observation", "SAO 117742"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.77602608),
        dec: Angle.Degrees(+03.07977745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210240"},
        {"Hipparcos Number", "HIP 109327"},
        {"Smithsonian Astrophysical Observation", "SAO 127325"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23420293),
        dec: Angle.Degrees(+03.08249883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27790"},
        {"Hipparcos Number", "HIP 20486"},
        {"Smithsonian Astrophysical Observation", "SAO 111787"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.85545539),
        dec: Angle.Degrees(+03.08386932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147531"},
        {"Hipparcos Number", "HIP 80195"},
        {"Geneva Identification System", "GEN# +1.00147531"},
        {"Smithsonian Astrophysical Observation", "SAO 121547"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.58045114),
        dec: Angle.Degrees(+03.08503642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69788"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.25978904),
        dec: Angle.Degrees(+03.08608780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125056"},
        {"Hipparcos Number", "HIP 69783"},
        {"Geneva Identification System", "GEN# +1.00125056"},
        {"Smithsonian Astrophysical Observation", "SAO 120379"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.25198418),
        dec: Angle.Degrees(+03.08842718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92417"},
        {"Cincinnati Publication", "Ci 20 1111"},
        {"Geneva Identification System", "GEN# +9.80022003"},
        {"Wilson Evans Batten Catalogue", "WEB 15965"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.50390954),
        dec: Angle.Degrees(+03.08910317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -407.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95834",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12508 AB"},
        {"Henry Draper", "HD 183442"},
        {"Hipparcos Number", "HIP 95834"},
        {"Smithsonian Astrophysical Observation", "SAO 124685"},
        {"Wilson Evans Batten Catalogue", "WEB 16779"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37530958),
        dec: Angle.Degrees(+03.08989317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41808"},
        {"Hipparcos Number", "HIP 29017"},
        {"Smithsonian Astrophysical Observation", "SAO 113475"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.84731797),
        dec: Angle.Degrees(+03.09168990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159757"},
        {"Hipparcos Number", "HIP 86155"},
        {"Smithsonian Astrophysical Observation", "SAO 122555"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.09052246),
        dec: Angle.Degrees(+03.09320355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137690"},
        {"Hipparcos Number", "HIP 75643"},
        {"Smithsonian Astrophysical Observation", "SAO 121006"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.81925740),
        dec: Angle.Degrees(+03.09323100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4039 A"},
        {"Henry Draper", "HD 35715"},
        {"Hipparcos Number", "HIP 25473"},
        {"Celescope Catalog", "CEL 702"},
        {"Geneva Identification System", "GEN# +1.00035715"},
        {"Smithsonian Astrophysical Observation", "SAO 112775"},
        {"Wilson Evans Batten Catalogue", "WEB 4933"},
    },
    visualMagnitude: 4.59,
    bvColour: -0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.70928405),
        dec: Angle.Degrees(+03.09567718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22775",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22775"},
        {"Smithsonian Astrophysical Observation", "SAO 112190"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48376060),
        dec: Angle.Degrees(+03.09657976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43407"},
        {"Hipparcos Number", "HIP 29766"},
        {"Smithsonian Astrophysical Observation", "SAO 113660"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.02167676),
        dec: Angle.Degrees(+03.09745964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95837",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12508 C"},
        {"Hipparcos Number", "HIP 95837"},
        {"Smithsonian Astrophysical Observation", "SAO 124686"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.37947655),
        dec: Angle.Degrees(+03.09755559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12235"},
        {"Hipparcos Number", "HIP 9353"},
        {"Geneva Identification System", "GEN# +1.00012235"},
        {"Smithsonian Astrophysical Observation", "SAO 110266"},
        {"Wilson Evans Batten Catalogue", "WEB 1963"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.03760293),
        dec: Angle.Degrees(+03.09763527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 231.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -255.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107000"},
        {"Hipparcos Number", "HIP 59998"},
        {"Renson", "Renson 30960"},
        {"Smithsonian Astrophysical Observation", "SAO 119317"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.57968311),
        dec: Angle.Degrees(+03.10112675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9843"},
        {"Smithsonian Astrophysical Observation", "SAO 110341"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.66501281),
        dec: Angle.Degrees(+03.10169060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10591"},
        {"Smithsonian Astrophysical Observation", "SAO 110438"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.09563062),
        dec: Angle.Degrees(+03.10297238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207742"},
        {"Hipparcos Number", "HIP 107863"},
        {"Smithsonian Astrophysical Observation", "SAO 127109"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.79449488),
        dec: Angle.Degrees(+03.10663205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105587"},
        {"Hipparcos Number", "HIP 59263"},
        {"Smithsonian Astrophysical Observation", "SAO 119242"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.34069022),
        dec: Angle.Degrees(+03.10668413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33303"},
        {"Hipparcos Number", "HIP 23989"},
        {"Geneva Identification System", "GEN# +1.00033303"},
        {"Smithsonian Astrophysical Observation", "SAO 112470"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.35385137),
        dec: Angle.Degrees(+03.10741740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173113"},
        {"Hipparcos Number", "HIP 91850"},
        {"Smithsonian Astrophysical Observation", "SAO 123847"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.88791129),
        dec: Angle.Degrees(+03.10840315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105490"},
        {"Hipparcos Number", "HIP 59215"},
        {"Smithsonian Astrophysical Observation", "SAO 119239"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.17419681),
        dec: Angle.Degrees(+03.10893678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88548"},
        {"Hipparcos Number", "HIP 50028"},
        {"Smithsonian Astrophysical Observation", "SAO 118165"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.20207323),
        dec: Angle.Degrees(+03.11027495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55751"},
        {"Hipparcos Number", "HIP 34987"},
        {"Geneva Identification System", "GEN# +1.00055751"},
        {"Smithsonian Astrophysical Observation", "SAO 115119"},
        {"Wilson Evans Batten Catalogue", "WEB 6993"},
    },
    visualMagnitude: 5.36,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.58360689),
        dec: Angle.Degrees(+03.11142128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182640"},
        {"Hipparcos Number", "HIP 95501"},
        {"Fundamental Katalog 5th Edition", "FK5 730"},
        {"Geneva Identification System", "GEN# +1.00182640"},
        {"Renson", "Renson 50510"},
        {"Smithsonian Astrophysical Observation", "SAO 124603"},
        {"Wilson Evans Batten Catalogue", "WEB 16698"},
    },
    visualMagnitude: 3.36,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.37396941),
        dec: Angle.Degrees(+03.11457923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 253.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105399",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14880 AB"},
        {"Henry Draper", "HD 203235"},
        {"Hipparcos Number", "HIP 105399"},
    },
    visualMagnitude: 7.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.23207761),
        dec: Angle.Degrees(+03.11824466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104535"},
        {"Geneva Identification System", "GEN# +0.00204314"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.62782538),
        dec: Angle.Degrees(+03.12012777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11113 A"},
        {"Henry Draper", "HD 166285"},
        {"Henry Draper 2", "HD 166285A"},
        {"Hipparcos Number", "HIP 89000"},
        {"Geneva Identification System", "GEN# +1.00166285"},
        {"Smithsonian Astrophysical Observation", "SAO 123198"},
        {"Wilson Evans Batten Catalogue", "WEB 15101"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.47502296),
        dec: Angle.Degrees(+03.12029682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34684"},
        {"Hipparcos Number", "HIP 24830"},
        {"Smithsonian Astrophysical Observation", "SAO 112627"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.84389009),
        dec: Angle.Degrees(+03.12274562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138834"},
        {"Hipparcos Number", "HIP 76250"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.63156719),
        dec: Angle.Degrees(+03.12478924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268593"},
        {"Hipparcos Number", "HIP 34129"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.15251669),
        dec: Angle.Degrees(+03.12852736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51147"},
        {"Hipparcos Number", "HIP 33363"},
        {"Smithsonian Astrophysical Observation", "SAO 114647"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.08150594),
        dec: Angle.Degrees(+03.12925844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48447"},
    },
    visualMagnitude: 10.57,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.16331632),
        dec: Angle.Degrees(+03.13024501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36627"},
        {"Hipparcos Number", "HIP 26024"},
        {"Celescope Catalog", "CEL 779"},
        {"Geneva Identification System", "GEN# +1.00036627"},
        {"Smithsonian Astrophysical Observation", "SAO 112894"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28711082),
        dec: Angle.Degrees(+03.13109216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9182 AB"},
        {"Henry Draper", "HD 124757"},
        {"Hipparcos Number", "HIP 69653"},
        {"Smithsonian Astrophysical Observation", "SAO 120370"},
        {"Wilson Evans Batten Catalogue", "WEB 12127"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.83128126),
        dec: Angle.Degrees(+03.13123545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68583"},
        {"Hipparcos Number", "HIP 40256"},
        {"Smithsonian Astrophysical Observation", "SAO 116486"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.32833864),
        dec: Angle.Degrees(+03.13149555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117966"},
        {"Hipparcos Number", "HIP 66174"},
        {"Smithsonian Astrophysical Observation", "SAO 119998"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.45730910),
        dec: Angle.Degrees(+03.13195492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214787"},
        {"Hipparcos Number", "HIP 111941"},
        {"Geneva Identification System", "GEN# +1.00214787"},
        {"Smithsonian Astrophysical Observation", "SAO 127679"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.11819176),
        dec: Angle.Degrees(+03.13282897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3628"},
        {"Hipparcos Number", "HIP 3086"},
        {"Cincinnati Publication", "Ci 20 41"},
        {"Geneva Identification System", "GEN# +1.00003628"},
        {"Smithsonian Astrophysical Observation", "SAO 109348"},
        {"Wilson Evans Batten Catalogue", "WEB 550"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.80336453),
        dec: Angle.Degrees(+03.13320203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 781.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 296.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3457"},
        {"Hipparcos Number", "HIP 2954"},
        {"Fundamental Katalog 5th Edition", "FK5 2040"},
        {"Geneva Identification System", "GEN# +1.00003457"},
        {"Smithsonian Astrophysical Observation", "SAO 109315"},
        {"Wilson Evans Batten Catalogue", "WEB 535"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.37682692),
        dec: Angle.Degrees(+03.13549746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171388"},
        {"Hipparcos Number", "HIP 91072"},
        {"Fundamental Katalog 5th Edition", "FK5 5632"},
        {"Geneva Identification System", "GEN# +1.00171388"},
        {"Renson", "Renson 48020"},
        {"Smithsonian Astrophysical Observation", "SAO 123653"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.64723269),
        dec: Angle.Degrees(+03.13577883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243721"},
        {"Hipparcos Number", "HIP 25417"},
        {"Smithsonian Astrophysical Observation", "SAO 112757"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.54924733),
        dec: Angle.Degrees(+03.13598815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18826"},
        {"Hipparcos Number", "HIP 14099"},
        {"Geneva Identification System", "GEN# +1.00018826"},
        {"Smithsonian Astrophysical Observation", "SAO 110916"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46358754),
        dec: Angle.Degrees(+03.13802706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15292"},
        {"Smithsonian Astrophysical Observation", "SAO 111101"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.32791124),
        dec: Angle.Degrees(+03.13877962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98334"},
        {"Hipparcos Number", "HIP 55231"},
        {"Smithsonian Astrophysical Observation", "SAO 118774"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.65671193),
        dec: Angle.Degrees(+03.13879453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38696"},
        {"Hipparcos Number", "HIP 27358"},
        {"Smithsonian Astrophysical Observation", "SAO 113148"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.91480763),
        dec: Angle.Degrees(+03.13961910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48616"},
        {"Hipparcos Number", "HIP 32288"},
        {"Geneva Identification System", "GEN# +1.00048616"},
        {"Smithsonian Astrophysical Observation", "SAO 114347"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.10584895),
        dec: Angle.Degrees(+03.14157742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115618"},
        {"Geneva Identification System", "GEN# +9.80029031"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.32409258),
        dec: Angle.Degrees(+03.14158183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22535"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.73869950),
        dec: Angle.Degrees(+03.14233669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103447"},
        {"Hipparcos Number", "HIP 58083"},
        {"Geneva Identification System", "GEN# +1.00103447"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.67849597),
        dec: Angle.Degrees(+03.14343611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114222"},
        {"Hipparcos Number", "HIP 64174"},
        {"Geneva Identification System", "GEN# +1.00114222"},
        {"Smithsonian Astrophysical Observation", "SAO 119792"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.28109476),
        dec: Angle.Degrees(+03.14449027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156539"},
        {"Hipparcos Number", "HIP 84632"},
        {"Geneva Identification System", "GEN# +1.00156539"},
        {"Smithsonian Astrophysical Observation", "SAO 122251"},
        {"Wilson Evans Batten Catalogue", "WEB 14292"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.52063420),
        dec: Angle.Degrees(+03.14698060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27297"},
        {"Hipparcos Number", "HIP 20113"},
        {"Geneva Identification System", "GEN# +1.00027297"},
        {"Smithsonian Astrophysical Observation", "SAO 111738"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.68387460),
        dec: Angle.Degrees(+03.14912559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79079"},
        {"Hipparcos Number", "HIP 45163"},
        {"Smithsonian Astrophysical Observation", "SAO 117490"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.00711929),
        dec: Angle.Degrees(+03.14960739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21976"},
        {"Hipparcos Number", "HIP 16515"},
        {"Smithsonian Astrophysical Observation", "SAO 111248"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.16128493),
        dec: Angle.Degrees(+03.14994297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180432"},
        {"Hipparcos Number", "HIP 94717"},
        {"Geneva Identification System", "GEN# +1.00180432"},
        {"Smithsonian Astrophysical Observation", "SAO 124451"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.10078668),
        dec: Angle.Degrees(+03.15091502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221916"},
        {"Hipparcos Number", "HIP 116479"},
        {"Geneva Identification System", "GEN# +1.00221916"},
        {"Smithsonian Astrophysical Observation", "SAO 128277"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.02422496),
        dec: Angle.Degrees(+03.15121281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103129"},
        {"Hipparcos Number", "HIP 57902"},
        {"Smithsonian Astrophysical Observation", "SAO 119092"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.14705146),
        dec: Angle.Degrees(+03.15200928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88725"},
        {"Hipparcos Number", "HIP 50139"},
        {"Cincinnati Publication", "Ci 20 568"},
        {"Geneva Identification System", "GEN# +1.00088725"},
        {"Smithsonian Astrophysical Observation", "SAO 118176"},
        {"Wilson Evans Batten Catalogue", "WEB 9216"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.53416616),
        dec: Angle.Degrees(+03.15227289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -400.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218845"},
        {"Hipparcos Number", "HIP 114488"},
        {"Smithsonian Astrophysical Observation", "SAO 128018"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.80572466),
        dec: Angle.Degrees(+03.15302451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121234"},
        {"Hipparcos Number", "HIP 67879"},
        {"Geneva Identification System", "GEN# +1.00121234"},
        {"Smithsonian Astrophysical Observation", "SAO 120161"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.54125661),
        dec: Angle.Degrees(+03.15410825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170712"},
        {"Hipparcos Number", "HIP 90738"},
        {"Geneva Identification System", "GEN# +1.00170712"},
        {"Smithsonian Astrophysical Observation", "SAO 123587"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.70621917),
        dec: Angle.Degrees(+03.15456841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15502"},
        {"Hipparcos Number", "HIP 11616"},
        {"Smithsonian Astrophysical Observation", "SAO 110573"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.45872380),
        dec: Angle.Degrees(+03.15604812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15219"},
        {"Hipparcos Number", "HIP 11417"},
        {"Geneva Identification System", "GEN# +1.00015219"},
        {"Smithsonian Astrophysical Observation", "SAO 110536"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.79564221),
        dec: Angle.Degrees(+03.15659169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88581"},
        {"Hipparcos Number", "HIP 50046"},
        {"Geneva Identification System", "GEN# +1.00088581"},
        {"Smithsonian Astrophysical Observation", "SAO 118168"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.26159850),
        dec: Angle.Degrees(+03.15687598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207433"},
        {"Hipparcos Number", "HIP 107687"},
        {"Smithsonian Astrophysical Observation", "SAO 127080"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.21774337),
        dec: Angle.Degrees(+03.15852706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104863"},
        {"Hipparcos Number", "HIP 58881"},
        {"Smithsonian Astrophysical Observation", "SAO 119204"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.15444233),
        dec: Angle.Degrees(+03.16177823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88105"},
        {"Hipparcos Number", "HIP 49782"},
        {"Smithsonian Astrophysical Observation", "SAO 118140"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.42690459),
        dec: Angle.Degrees(+03.16211933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54117"},
        {"Smithsonian Astrophysical Observation", "SAO 118646"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.10021739),
        dec: Angle.Degrees(+03.16356512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50622"},
        {"Smithsonian Astrophysical Observation", "SAO 118238"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.10532674),
        dec: Angle.Degrees(+03.16435273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49778"},
    },
    visualMagnitude: 11.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.41905604),
        dec: Angle.Degrees(+03.16549978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74190"},
        {"Geneva Identification System", "GEN# +9.80015009"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.39976594),
        dec: Angle.Degrees(+03.16564990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -601.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 482.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114575"},
        {"Hipparcos Number", "HIP 64350"},
        {"Smithsonian Astrophysical Observation", "SAO 119804"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.85313219),
        dec: Angle.Degrees(+03.16851146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197738"},
        {"Hipparcos Number", "HIP 102438"},
        {"Smithsonian Astrophysical Observation", "SAO 126177"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.36646842),
        dec: Angle.Degrees(+03.16872922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66924"},
        {"Hipparcos Number", "HIP 39622"},
        {"Geneva Identification System", "GEN# +1.00066924"},
        {"Smithsonian Astrophysical Observation", "SAO 116334"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.44972727),
        dec: Angle.Degrees(+03.17231196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22946",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3542 AB"},
        {"Henry Draper", "HD 31466"},
        {"Hipparcos Number", "HIP 22946"},
        {"Smithsonian Astrophysical Observation", "SAO 112232"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.05896697),
        dec: Angle.Degrees(+03.17584671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134211"},
        {"Hipparcos Number", "HIP 74088"},
        {"Smithsonian Astrophysical Observation", "SAO 120860"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.12184346),
        dec: Angle.Degrees(+03.17780150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88119"},
        {"Hipparcos Number", "HIP 49787"},
        {"Smithsonian Astrophysical Observation", "SAO 118141"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.44687390),
        dec: Angle.Degrees(+03.17783950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58122"},
        {"Hipparcos Number", "HIP 35923"},
        {"Smithsonian Astrophysical Observation", "SAO 115394"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.07580414),
        dec: Angle.Degrees(+03.17797574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28544"},
        {"Smithsonian Astrophysical Observation", "SAO 113378"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.38470964),
        dec: Angle.Degrees(+03.17811807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204378"},
        {"Hipparcos Number", "HIP 105995"},
        {"Geneva Identification System", "GEN# +1.00204378"},
        {"Smithsonian Astrophysical Observation", "SAO 126812"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.01096292),
        dec: Angle.Degrees(+03.18041619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223374"},
        {"Hipparcos Number", "HIP 117463"},
        {"Geneva Identification System", "GEN# +1.00223374"},
        {"Smithsonian Astrophysical Observation", "SAO 128395"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.25466927),
        dec: Angle.Degrees(+03.18117161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209408"},
        {"Hipparcos Number", "HIP 108855"},
        {"Smithsonian Astrophysical Observation", "SAO 127253"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.78238225),
        dec: Angle.Degrees(+03.18247063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152126"},
        {"Hipparcos Number", "HIP 82483"},
        {"Geneva Identification System", "GEN# +1.00152126"},
        {"Smithsonian Astrophysical Observation", "SAO 121912"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.86364688),
        dec: Angle.Degrees(+03.18339187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39059"},
        {"Smithsonian Astrophysical Observation", "SAO 116207"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.86140853),
        dec: Angle.Degrees(+03.18621716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40836"},
        {"Hipparcos Number", "HIP 28543"},
        {"Smithsonian Astrophysical Observation", "SAO 113376"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.38056731),
        dec: Angle.Degrees(+03.18653350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11559"},
        {"Hipparcos Number", "HIP 8833"},
        {"Fundamental Katalog 5th Edition", "FK5 65"},
        {"Geneva Identification System", "GEN# +1.00011559"},
        {"Smithsonian Astrophysical Observation", "SAO 110206"},
        {"Wilson Evans Batten Catalogue", "WEB 1862"},
    },
    visualMagnitude: 4.61,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.38890233),
        dec: Angle.Degrees(+03.18747844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25520"},
        {"Hipparcos Number", "HIP 18922"},
        {"Smithsonian Astrophysical Observation", "SAO 111581"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.83842323),
        dec: Angle.Degrees(+03.18780428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56332"},
        {"Hipparcos Number", "HIP 35218"},
        {"Smithsonian Astrophysical Observation", "SAO 115190"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.18049837),
        dec: Angle.Degrees(+03.18863523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18524"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.40961828),
        dec: Angle.Degrees(+03.19008996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54989"},
        {"Hipparcos Number", "HIP 34696"},
        {"Geneva Identification System", "GEN# +1.00054989"},
        {"Smithsonian Astrophysical Observation", "SAO 115050"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.79821122),
        dec: Angle.Degrees(+03.19163121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38271"},
        {"Hipparcos Number", "HIP 27094"},
        {"Geneva Identification System", "GEN# +1.00038271"},
        {"Renson", "Renson 10307"},
        {"Smithsonian Astrophysical Observation", "SAO 113094"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.18119606),
        dec: Angle.Degrees(+03.19393527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83581"},
        {"Hipparcos Number", "HIP 47411"},
        {"Fundamental Katalog 5th Edition", "FK5 4857"},
        {"Geneva Identification System", "GEN# +1.00083581"},
        {"Smithsonian Astrophysical Observation", "SAO 117831"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.91500066),
        dec: Angle.Degrees(+03.19533334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208880"},
        {"Hipparcos Number", "HIP 108525"},
        {"Geneva Identification System", "GEN# +1.00208880"},
        {"Smithsonian Astrophysical Observation", "SAO 127207"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.78664186),
        dec: Angle.Degrees(+03.19760020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4246"},
        {"Hipparcos Number", "HIP 3518"},
        {"Smithsonian Astrophysical Observation", "SAO 109427"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.23027741),
        dec: Angle.Degrees(+03.20099550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166284"},
        {"Hipparcos Number", "HIP 88986"},
        {"Geneva Identification System", "GEN# +1.00166284"},
        {"Smithsonian Astrophysical Observation", "SAO 123197"},
        {"Wilson Evans Batten Catalogue", "WEB 15098"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.44811490),
        dec: Angle.Degrees(+03.20101490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87301"},
        {"Hipparcos Number", "HIP 49329"},
        {"Geneva Identification System", "GEN# +1.00087301"},
        {"Smithsonian Astrophysical Observation", "SAO 118086"},
        {"Wilson Evans Batten Catalogue", "WEB 9121"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.03531426),
        dec: Angle.Degrees(+03.20128263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241890"},
        {"Hipparcos Number", "HIP 24399"},
        {"Smithsonian Astrophysical Observation", "SAO 112548"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.51291097),
        dec: Angle.Degrees(+03.20206910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99949"},
        {"Hipparcos Number", "HIP 56102"},
        {"Smithsonian Astrophysical Observation", "SAO 118894"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.49514681),
        dec: Angle.Degrees(+03.20520606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34292"},
        {"Hipparcos Number", "HIP 24588"},
        {"Geneva Identification System", "GEN# +1.00034292"},
        {"Smithsonian Astrophysical Observation", "SAO 112587"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.12115612),
        dec: Angle.Degrees(+03.20545849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3194"},
        {"Hipparcos Number", "HIP 2759"},
        {"Smithsonian Astrophysical Observation", "SAO 109295"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.80509903),
        dec: Angle.Degrees(+03.20901471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20871"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.09288121),
        dec: Angle.Degrees(+03.21061751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17927"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51270709),
        dec: Angle.Degrees(+03.21215579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193224"},
        {"Hipparcos Number", "HIP 100161"},
        {"Smithsonian Astrophysical Observation", "SAO 125675"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75598482),
        dec: Angle.Degrees(+03.21279171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70047",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70047"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.02111259),
        dec: Angle.Degrees(+03.21334535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135340"},
        {"Hipparcos Number", "HIP 74590"},
        {"Geneva Identification System", "GEN# +1.00135340"},
        {"Smithsonian Astrophysical Observation", "SAO 120912"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.61205202),
        dec: Angle.Degrees(+03.21798895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71515"},
        {"Hipparcos Number", "HIP 41508"},
        {"Smithsonian Astrophysical Observation", "SAO 116787"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.98177339),
        dec: Angle.Degrees(+03.21857862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103501"},
        {"Hipparcos Number", "HIP 58113"},
        {"Smithsonian Astrophysical Observation", "SAO 119113"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.77987994),
        dec: Angle.Degrees(+03.21863679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3728"},
        {"Henry Draper", "HD 33236"},
        {"Hipparcos Number", "HIP 23957"},
        {"Renson", "Renson 8480"},
        {"Smithsonian Astrophysical Observation", "SAO 112465"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.23398804),
        dec: Angle.Degrees(+03.21878769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17780"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.09405414),
        dec: Angle.Degrees(+03.21921063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115167"},
        {"Hipparcos Number", "HIP 64680"},
        {"Smithsonian Astrophysical Observation", "SAO 119833"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.85293053),
        dec: Angle.Degrees(+03.21962826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171952"},
        {"Hipparcos Number", "HIP 91302"},
        {"Smithsonian Astrophysical Observation", "SAO 123712"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.36253218),
        dec: Angle.Degrees(+03.22010125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6391 A"},
        {"Henry Draper", "HD 63536"},
        {"Hipparcos Number", "HIP 38189"},
        {"Smithsonian Astrophysical Observation", "SAO 115981"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37410479),
        dec: Angle.Degrees(+03.22102575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35077"},
        {"Hipparcos Number", "HIP 25083"},
        {"Smithsonian Astrophysical Observation", "SAO 112682"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.54725581),
        dec: Angle.Degrees(+03.22127415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85488"},
        {"Hipparcos Number", "HIP 48411"},
        {"Cincinnati Publication", "Ci 20 552"},
        {"Geneva Identification System", "GEN# +1.00085488"},
        {"Smithsonian Astrophysical Observation", "SAO 117958"},
        {"Wilson Evans Batten Catalogue", "WEB 9028"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.04838021),
        dec: Angle.Degrees(+03.22179861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -425.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96710"},
        {"Hipparcos Number", "HIP 54451"},
        {"Smithsonian Astrophysical Observation", "SAO 118683"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.11141197),
        dec: Angle.Degrees(+03.22263247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160510"},
        {"Hipparcos Number", "HIP 86478"},
        {"Smithsonian Astrophysical Observation", "SAO 122629"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.05326847),
        dec: Angle.Degrees(+03.22311591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88556"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.23721828),
        dec: Angle.Degrees(+03.22360631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10698"},
        {"Hipparcos Number", "HIP 8134"},
        {"Smithsonian Astrophysical Observation", "SAO 110104"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.14985337),
        dec: Angle.Degrees(+03.22373927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52915"},
        {"Hipparcos Number", "HIP 33988"},
        {"Smithsonian Astrophysical Observation", "SAO 114833"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.78256003),
        dec: Angle.Degrees(+03.22547819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6391 B"},
        {"Hipparcos Number", "HIP 38193"},
        {"Smithsonian Astrophysical Observation", "SAO 115982"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.37807496),
        dec: Angle.Degrees(+03.22554730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92955"},
        {"Hipparcos Number", "HIP 52501"},
        {"Smithsonian Astrophysical Observation", "SAO 118459"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.02517679),
        dec: Angle.Degrees(+03.22557192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39685"},
        {"Hipparcos Number", "HIP 27902"},
        {"Geneva Identification System", "GEN# +1.00039685"},
        {"Smithsonian Astrophysical Observation", "SAO 113253"},
        {"Wilson Evans Batten Catalogue", "WEB 5464"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.56551372),
        dec: Angle.Degrees(+03.22576839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140235"},
        {"Hipparcos Number", "HIP 76915"},
        {"Smithsonian Astrophysical Observation", "SAO 121132"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.57679010),
        dec: Angle.Degrees(+03.22712756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206891"},
        {"Hipparcos Number", "HIP 107388"},
        {"Smithsonian Astrophysical Observation", "SAO 127039"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.25609273),
        dec: Angle.Degrees(+03.23060829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106645"},
    },
    visualMagnitude: 12.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.03529825),
        dec: Angle.Degrees(+03.23067245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12503"},
        {"Smithsonian Astrophysical Observation", "SAO 110679"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.21622149),
        dec: Angle.Degrees(+03.23258343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68889",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9109 AB"},
        {"Hipparcos Number", "HIP 68889"},
        {"Geneva Identification System", "GEN# +0.00302855"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.57438740),
        dec: Angle.Degrees(+03.23569859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -328.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12706",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kaffaljidhma"},
        {"Henry Draper", "HD 16970"},
        {"Hipparcos Number", "HIP 12706"},
        {"Geneva Identification System", "GEN# +1.00016970"},
        {"Smithsonian Astrophysical Observation", "SAO 110707"},
        {"Wilson Evans Batten Catalogue", "WEB 2583"},
    },
    visualMagnitude: 3.47,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.82551897),
        dec: Angle.Degrees(+03.23617162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50794"},
        {"Hipparcos Number", "HIP 33227"},
        {"Geneva Identification System", "GEN# +1.00050794"},
        {"Smithsonian Astrophysical Observation", "SAO 114604"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.71075747),
        dec: Angle.Degrees(+03.23750915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224118"},
        {"Hipparcos Number", "HIP 117933"},
        {"Smithsonian Astrophysical Observation", "SAO 128467"},
        {"Wilson Evans Batten Catalogue", "WEB 20740"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.83817961),
        dec: Angle.Degrees(+03.23973048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23467"},
        {"Hipparcos Number", "HIP 17556"},
        {"Smithsonian Astrophysical Observation", "SAO 111398"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.39405687),
        dec: Angle.Degrees(+03.23974474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105241"},
        {"Geneva Identification System", "GEN# +0.00204338"},
        {"Wilson Evans Batten Catalogue", "WEB 19114"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76062828),
        dec: Angle.Degrees(+03.24196570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214669"},
        {"Hipparcos Number", "HIP 111886"},
        {"Smithsonian Astrophysical Observation", "SAO 127671"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.95681741),
        dec: Angle.Degrees(+03.24245020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19585"},
        {"Hipparcos Number", "HIP 14644"},
        {"Geneva Identification System", "GEN# +1.00019585"},
        {"Smithsonian Astrophysical Observation", "SAO 111009"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.31053909),
        dec: Angle.Degrees(+03.24275237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113198"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.85974860),
        dec: Angle.Degrees(+03.24290511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211305"},
        {"Hipparcos Number", "HIP 109947"},
        {"Geneva Identification System", "GEN# +1.00211305"},
        {"Smithsonian Astrophysical Observation", "SAO 127421"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.02253670),
        dec: Angle.Degrees(+03.24573828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149162"},
        {"Hipparcos Number", "HIP 81023"},
        {"Cincinnati Publication", "Ci 20 999"},
        {"Geneva Identification System", "GEN# +1.00149162"},
        {"Smithsonian Astrophysical Observation", "SAO 121679"},
        {"Wilson Evans Batten Catalogue", "WEB 13704"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.21600642),
        dec: Angle.Degrees(+03.24648222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -371.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26875"},
        {"Hipparcos Number", "HIP 19830"},
        {"Smithsonian Astrophysical Observation", "SAO 111691"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.77839714),
        dec: Angle.Degrees(+03.24652559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219817"},
        {"Hipparcos Number", "HIP 115101"},
        {"Smithsonian Astrophysical Observation", "SAO 128107"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.70081915),
        dec: Angle.Degrees(+03.24681087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48157"},
        {"Hipparcos Number", "HIP 32072"},
        {"Smithsonian Astrophysical Observation", "SAO 114297"},
        {"Wilson Evans Batten Catalogue", "WEB 6475"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.51956738),
        dec: Angle.Degrees(+03.24835620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21585"},
        {"Hipparcos Number", "HIP 16226"},
        {"Fundamental Katalog 5th Edition", "FK5 4316"},
        {"Geneva Identification System", "GEN# +1.00021585"},
        {"Smithsonian Astrophysical Observation", "SAO 111215"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.26585232),
        dec: Angle.Degrees(+03.24868660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65778"},
        {"Hipparcos Number", "HIP 39141"},
        {"Geneva Identification System", "GEN# +1.00065778"},
        {"Smithsonian Astrophysical Observation", "SAO 116223"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.09393602),
        dec: Angle.Degrees(+03.24896207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189798"},
        {"Hipparcos Number", "HIP 98604"},
        {"Smithsonian Astrophysical Observation", "SAO 125369"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.41927665),
        dec: Angle.Degrees(+03.25192506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148530"},
        {"Hipparcos Number", "HIP 80700"},
        {"Cincinnati Publication", "Ci 20 989"},
        {"Cincinnati Publication 2", "Ci 18 2196"},
        {"Geneva Identification System", "GEN# +1.00148530"},
        {"Smithsonian Astrophysical Observation", "SAO 121625"},
        {"Wilson Evans Batten Catalogue", "WEB 13649"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14981831),
        dec: Angle.Degrees(+03.25423361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -525.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6242"},
        {"Hipparcos Number", "HIP 4945"},
        {"Smithsonian Astrophysical Observation", "SAO 109637"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.85824367),
        dec: Angle.Degrees(+03.25560486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114061"},
        {"Hipparcos Number", "HIP 64086"},
        {"Smithsonian Astrophysical Observation", "SAO 119782"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.00240569),
        dec: Angle.Degrees(+03.25613020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19304"},
        {"Hipparcos Number", "HIP 14443"},
        {"Geneva Identification System", "GEN# +1.00019304"},
        {"Smithsonian Astrophysical Observation", "SAO 110969"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.60662240),
        dec: Angle.Degrees(+03.26462454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32056"},
        {"Hipparcos Number", "HIP 23295"},
        {"Smithsonian Astrophysical Observation", "SAO 112306"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.16578400),
        dec: Angle.Degrees(+03.26534609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177812"},
        {"Hipparcos Number", "HIP 93796"},
        {"Geneva Identification System", "GEN# +1.00177812"},
        {"Smithsonian Astrophysical Observation", "SAO 124260"},
        {"Wilson Evans Batten Catalogue", "WEB 16304"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.52248112),
        dec: Angle.Degrees(+03.26640613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2690"},
        {"Hipparcos Number", "HIP 2398"},
        {"Geneva Identification System", "GEN# +1.00002690"},
        {"Smithsonian Astrophysical Observation", "SAO 109242"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.63013181),
        dec: Angle.Degrees(+03.26688983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30286"},
        {"Hipparcos Number", "HIP 22175"},
        {"Geneva Identification System", "GEN# +1.00030286"},
        {"Smithsonian Astrophysical Observation", "SAO 112058"},
        {"Wilson Evans Batten Catalogue", "WEB 4266"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.56860663),
        dec: Angle.Degrees(+03.26870425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23299"},
    },
    visualMagnitude: 9.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)00, 40.8300),
        dec: Angle.DegreesMinutesSeconds((int)+03, (int)16, 10.100)
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
    primaryId: "HIP 22401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30618"},
        {"Hipparcos Number", "HIP 22401"},
        {"Smithsonian Astrophysical Observation", "SAO 112103"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.31616599),
        dec: Angle.Degrees(+03.26954029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108563"},
        {"Hipparcos Number", "HIP 60847"},
        {"Geneva Identification System", "GEN# +1.00108563"},
        {"Smithsonian Astrophysical Observation", "SAO 119419"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.07142323),
        dec: Angle.Degrees(+03.27083016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64769"},
        {"Hipparcos Number", "HIP 38717"},
        {"Smithsonian Astrophysical Observation", "SAO 116123"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.89858256),
        dec: Angle.Degrees(+03.27200266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16895",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16895"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.34402372),
        dec: Angle.Degrees(+03.27344327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6499"},
        {"Hipparcos Number", "HIP 5166"},
        {"Smithsonian Astrophysical Observation", "SAO 109671"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52397905),
        dec: Angle.Degrees(+03.27473062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121440"},
        {"Hipparcos Number", "HIP 67978"},
        {"Smithsonian Astrophysical Observation", "SAO 120170"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.81716479),
        dec: Angle.Degrees(+03.27533175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60526"},
        {"Hipparcos Number", "HIP 36882"},
        {"Geneva Identification System", "GEN# +1.00060526"},
        {"Smithsonian Astrophysical Observation", "SAO 115658"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.73932893),
        dec: Angle.Degrees(+03.27651680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38300",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6405 AB"},
        {"Henry Draper", "HD 63799"},
        {"Hipparcos Number", "HIP 38300"},
        {"Geneva Identification System", "GEN# +1.00063799"},
        {"Smithsonian Astrophysical Observation", "SAO 116014"},
        {"Wilson Evans Batten Catalogue", "WEB 7535"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69733913),
        dec: Angle.Degrees(+03.27732483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64052"},
        {"Hipparcos Number", "HIP 38406"},
        {"Geneva Identification System", "GEN# +1.00064052"},
        {"Smithsonian Astrophysical Observation", "SAO 116054"},
        {"Wilson Evans Batten Catalogue", "WEB 7554"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.02983762),
        dec: Angle.Degrees(+03.27753363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221715"},
        {"Hipparcos Number", "HIP 116344"},
        {"Smithsonian Astrophysical Observation", "SAO 128263"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.61840327),
        dec: Angle.Degrees(+03.27801733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205161"},
        {"Hipparcos Number", "HIP 106427"},
        {"Smithsonian Astrophysical Observation", "SAO 126888"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.34604586),
        dec: Angle.Degrees(+03.27944254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77352"},
        {"Hipparcos Number", "HIP 44363"},
        {"Geneva Identification System", "GEN# +1.00077352"},
        {"Smithsonian Astrophysical Observation", "SAO 117364"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.51972021),
        dec: Angle.Degrees(+03.27999705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13412"},
    },
    visualMagnitude: 12.08,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.17222328),
        dec: Angle.Degrees(+03.28057994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21195"},
        {"Hipparcos Number", "HIP 15948"},
        {"Geneva Identification System", "GEN# +1.00021195"},
        {"Smithsonian Astrophysical Observation", "SAO 111179"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.33642026),
        dec: Angle.Degrees(+03.28179974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212060"},
        {"Hipparcos Number", "HIP 110385"},
        {"Smithsonian Astrophysical Observation", "SAO 127473"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.37596164),
        dec: Angle.Degrees(+03.28191033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219615"},
        {"Hipparcos Number", "HIP 114971"},
        {"Cincinnati Publication", "Ci 20 1414"},
        {"Fundamental Katalog 5th Edition", "FK5 878"},
        {"Geneva Identification System", "GEN# +1.00219615"},
        {"Smithsonian Astrophysical Observation", "SAO 128085"},
        {"Wilson Evans Batten Catalogue", "WEB 20367"},
    },
    visualMagnitude: 3.70,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.28955677),
        dec: Angle.Degrees(+03.28224524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 760.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109860"},
        {"Hipparcos Number", "HIP 61637"},
        {"Geneva Identification System", "GEN# +1.00109860"},
        {"Renson", "Renson 31890"},
        {"Smithsonian Astrophysical Observation", "SAO 119503"},
        {"Wilson Evans Batten Catalogue", "WEB 10966"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.51847183),
        dec: Angle.Degrees(+03.28247137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31567"},
        {"Hipparcos Number", "HIP 23014"},
        {"Geneva Identification System", "GEN# +1.00031567"},
        {"Smithsonian Astrophysical Observation", "SAO 112249"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.24707510),
        dec: Angle.Degrees(+03.28604008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31993"},
        {"Hipparcos Number", "HIP 23245"},
        {"Smithsonian Astrophysical Observation", "SAO 112298"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.03425460),
        dec: Angle.Degrees(+03.28670889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115930"},
        {"Hipparcos Number", "HIP 65067"},
        {"Smithsonian Astrophysical Observation", "SAO 119885"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.06122620),
        dec: Angle.Degrees(+03.28755291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7991"},
        {"Hipparcos Number", "HIP 6188"},
        {"Smithsonian Astrophysical Observation", "SAO 109805"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.85090038),
        dec: Angle.Degrees(+03.28973359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60111"},
        {"Hipparcos Number", "HIP 36723"},
        {"Geneva Identification System", "GEN# +1.00060111"},
        {"Smithsonian Astrophysical Observation", "SAO 115610"},
        {"Wilson Evans Batten Catalogue", "WEB 7298"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.29864650),
        dec: Angle.Degrees(+03.29027472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142399"},
        {"Hipparcos Number", "HIP 77887"},
        {"Smithsonian Astrophysical Observation", "SAO 121246"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60195381),
        dec: Angle.Degrees(+03.29052828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25861",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4123 AB"},
        {"Henry Draper", "HD 36351"},
        {"Hipparcos Number", "HIP 25861"},
        {"Celescope Catalog", "CEL 749"},
        {"Geneva Identification System", "GEN# +1.00036351J"},
        {"Smithsonian Astrophysical Observation", "SAO 112861"},
        {"Wilson Evans Batten Catalogue", "WEB 5020"},
    },
    visualMagnitude: 5.46,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.81054942),
        dec: Angle.Degrees(+03.29213510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72887"},
        {"Hipparcos Number", "HIP 42140"},
        {"Smithsonian Astrophysical Observation", "SAO 116919"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.84934615),
        dec: Angle.Degrees(+03.29262271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217927"},
        {"Hipparcos Number", "HIP 113913"},
        {"Geneva Identification System", "GEN# +1.00217927"},
        {"Smithsonian Astrophysical Observation", "SAO 127938"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.02160961),
        dec: Angle.Degrees(+03.29340535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157215"},
        {"Hipparcos Number", "HIP 84961"},
        {"Smithsonian Astrophysical Observation", "SAO 122311"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.47480127),
        dec: Angle.Degrees(+03.29408937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130503"},
        {"Hipparcos Number", "HIP 72421"},
        {"Fundamental Katalog 5th Edition", "FK5 5312"},
        {"Geneva Identification System", "GEN# +1.00130503"},
        {"Smithsonian Astrophysical Observation", "SAO 120672"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.12229303),
        dec: Angle.Degrees(+03.29577119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82445"},
        {"Hipparcos Number", "HIP 46802"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.05294644),
        dec: Angle.Degrees(+03.29609175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242484"},
        {"Hipparcos Number", "HIP 24729"},
        {"Smithsonian Astrophysical Observation", "SAO 112607"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54493784),
        dec: Angle.Degrees(+03.29750335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60337",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8529 A"},
        {"Henry Draper", "HD 107658"},
        {"Hipparcos Number", "HIP 60337"},
        {"Geneva Identification System", "GEN# +1.00107658"},
        {"Smithsonian Astrophysical Observation", "SAO 119358"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.57180866),
        dec: Angle.Degrees(+03.29766536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81165"},
        {"Geneva Identification System", "GEN# +9.80017026"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.66932669),
        dec: Angle.Degrees(+03.29925099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8233 AB"},
        {"Henry Draper", "HD 100822"},
        {"Hipparcos Number", "HIP 56598"},
        {"Smithsonian Astrophysical Observation", "SAO 118942"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.06096046),
        dec: Angle.Degrees(+03.30121475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99305"},
        {"Hipparcos Number", "HIP 55769"},
        {"Smithsonian Astrophysical Observation", "SAO 118847"},
        {"Wilson Evans Batten Catalogue", "WEB 10022"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.41446085),
        dec: Angle.Degrees(+03.30124291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5821"},
        {"Hipparcos Number", "HIP 4660"},
        {"Smithsonian Astrophysical Observation", "SAO 109582"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.97125375),
        dec: Angle.Degrees(+03.30274864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4186",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 736 AB"},
        {"Henry Draper", "HD 5155"},
        {"Hipparcos Number", "HIP 4186"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.36891500),
        dec: Angle.Degrees(+03.30280194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196218"},
        {"Hipparcos Number", "HIP 101620"},
        {"Geneva Identification System", "GEN# +1.00196218"},
        {"Smithsonian Astrophysical Observation", "SAO 126000"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.92889449),
        dec: Angle.Degrees(+03.30298845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198070"},
        {"Hipparcos Number", "HIP 102631"},
        {"Geneva Identification System", "GEN# +1.00198070"},
        {"Smithsonian Astrophysical Observation", "SAO 126221"},
        {"Wilson Evans Batten Catalogue", "WEB 18598"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.94939860),
        dec: Angle.Degrees(+03.30644316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31346",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5202 AB"},
        {"Henry Draper", "HD 46597"},
        {"Hipparcos Number", "HIP 31346"},
        {"Smithsonian Astrophysical Observation", "SAO 114073"},
        {"Wilson Evans Batten Catalogue", "WEB 6271"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.59024564),
        dec: Angle.Degrees(+03.30648368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93081"},
        {"Hipparcos Number", "HIP 52574"},
        {"Geneva Identification System", "GEN# +1.00093081"},
        {"Smithsonian Astrophysical Observation", "SAO 118471"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.25924352),
        dec: Angle.Degrees(+03.30674280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245519"},
        {"Hipparcos Number", "HIP 26331"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.12231937),
        dec: Angle.Degrees(+03.30824271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240991"},
        {"Hipparcos Number", "HIP 23892"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.01547412),
        dec: Angle.Degrees(+03.30866865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219198"},
        {"Hipparcos Number", "HIP 114696"},
        {"Geneva Identification System", "GEN# +1.00219198"},
        {"Smithsonian Astrophysical Observation", "SAO 128052"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.51718053),
        dec: Angle.Degrees(+03.31003342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12946"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.62573769),
        dec: Angle.Degrees(+03.31065120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157824"},
        {"Hipparcos Number", "HIP 85279"},
        {"Smithsonian Astrophysical Observation", "SAO 122368"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.37418134),
        dec: Angle.Degrees(+03.31111575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107328"},
        {"Hipparcos Number", "HIP 60172"},
        {"Fundamental Katalog 5th Edition", "FK5 1317"},
        {"Geneva Identification System", "GEN# +1.00107328"},
        {"Smithsonian Astrophysical Observation", "SAO 119341"},
        {"Wilson Evans Batten Catalogue", "WEB 10698"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.08813566),
        dec: Angle.Degrees(+03.31272688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42317"},
        {"Hipparcos Number", "HIP 29259"},
        {"Geneva Identification System", "GEN# +1.00042317"},
        {"Smithsonian Astrophysical Observation", "SAO 113538"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.53877700),
        dec: Angle.Degrees(+03.31307055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6516"},
        {"Smithsonian Astrophysical Observation", "SAO 109855"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.92254737),
        dec: Angle.Degrees(+03.31476386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90651"},
        {"Hipparcos Number", "HIP 51250"},
        {"Smithsonian Astrophysical Observation", "SAO 118319"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.02314855),
        dec: Angle.Degrees(+03.31571028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28716"},
        {"Hipparcos Number", "HIP 21128"},
        {"Geneva Identification System", "GEN# +1.00028716"},
        {"Smithsonian Astrophysical Observation", "SAO 111875"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.92946072),
        dec: Angle.Degrees(+03.31776797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93292"},
        {"Smithsonian Astrophysical Observation", "SAO 124137"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.02481946),
        dec: Angle.Degrees(+03.31830994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129901"},
        {"Hipparcos Number", "HIP 72114"},
        {"Smithsonian Astrophysical Observation", "SAO 120637"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.27108129),
        dec: Angle.Degrees(+03.31882690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261557"},
        {"Hipparcos Number", "HIP 31849"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.88074350),
        dec: Angle.Degrees(+03.31978257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3070"},
        {"Hipparcos Number", "HIP 2677"},
        {"Fundamental Katalog 5th Edition", "FK5 4049"},
        {"Geneva Identification System", "GEN# +1.00003070"},
        {"Smithsonian Astrophysical Observation", "SAO 109278"},
        {"Wilson Evans Batten Catalogue", "WEB 488"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.47598058),
        dec: Angle.Degrees(+03.31990802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21744",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3374 A"},
        {"Henry Draper", "HD 29633"},
        {"Hipparcos Number", "HIP 21744"},
        {"Smithsonian Astrophysical Observation", "SAO 111967"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.03117183),
        dec: Angle.Degrees(+03.31992249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17384"},
        {"Hipparcos Number", "HIP 13031"},
        {"Smithsonian Astrophysical Observation", "SAO 110747"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.86962666),
        dec: Angle.Degrees(+03.32098682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21745",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3374 B"},
        {"Hipparcos Number", "HIP 21745"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.03257215),
        dec: Angle.Degrees(+03.32272198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26292"},
        {"Hipparcos Number", "HIP 19434"},
        {"Geneva Identification System", "GEN# +1.00026292"},
        {"Smithsonian Astrophysical Observation", "SAO 111634"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.42931953),
        dec: Angle.Degrees(+03.32284490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138644"},
        {"Hipparcos Number", "HIP 76159"},
        {"Smithsonian Astrophysical Observation", "SAO 121058"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.32510447),
        dec: Angle.Degrees(+03.32289489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166460"},
        {"Hipparcos Number", "HIP 89065"},
        {"Fundamental Katalog 5th Edition", "FK5 3445"},
        {"Geneva Identification System", "GEN# +1.00166460"},
        {"Smithsonian Astrophysical Observation", "SAO 123212"},
        {"Wilson Evans Batten Catalogue", "WEB 15122"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.66786991),
        dec: Angle.Degrees(+03.32426855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245762"},
        {"Hipparcos Number", "HIP 26469"},
        {"Smithsonian Astrophysical Observation", "SAO 112974"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.45873241),
        dec: Angle.Degrees(+03.32521617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190007"},
        {"Hipparcos Number", "HIP 98698"},
        {"Geneva Identification System", "GEN# +1.00190007"},
        {"Smithsonian Astrophysical Observation", "SAO 125379"},
        {"Wilson Evans Batten Catalogue", "WEB 17476"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.69624414),
        dec: Angle.Degrees(+03.32589486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 120.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114233"},
        {"Geneva Identification System", "GEN# +9.80028039"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.02781318),
        dec: Angle.Degrees(+03.32836789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 492.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 254.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177332"},
        {"Hipparcos Number", "HIP 93647"},
        {"Geneva Identification System", "GEN# +1.00177332"},
        {"Renson", "Renson 49450"},
        {"Smithsonian Astrophysical Observation", "SAO 124219"},
        {"Wilson Evans Batten Catalogue", "WEB 16268"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.04457658),
        dec: Angle.Degrees(+03.33051705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86203"},
        {"Hipparcos Number", "HIP 48797"},
        {"Smithsonian Astrophysical Observation", "SAO 118009"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.28332347),
        dec: Angle.Degrees(+03.33090149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136293"},
        {"Hipparcos Number", "HIP 75014"},
        {"Geneva Identification System", "GEN# +1.00136293"},
        {"Smithsonian Astrophysical Observation", "SAO 120950"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.92920256),
        dec: Angle.Degrees(+03.33174298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189533"},
        {"Hipparcos Number", "HIP 98474"},
        {"Geneva Identification System", "GEN# +1.00189533"},
        {"Smithsonian Astrophysical Observation", "SAO 125339"},
        {"Wilson Evans Batten Catalogue", "WEB 17390"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08856467),
        dec: Angle.Degrees(+03.33197413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128611"},
        {"Hipparcos Number", "HIP 71527"},
        {"Smithsonian Astrophysical Observation", "SAO 120572"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.43759664),
        dec: Angle.Degrees(+03.33279000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -289.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41594"},
        {"Hipparcos Number", "HIP 28917"},
        {"Geneva Identification System", "GEN# +1.00041594"},
        {"Smithsonian Astrophysical Observation", "SAO 113449"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.56092944),
        dec: Angle.Degrees(+03.33550327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38193"},
        {"Hipparcos Number", "HIP 27041"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.02505000),
        dec: Angle.Degrees(+03.33561272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124681"},
        {"Hipparcos Number", "HIP 69614"},
        {"Fundamental Katalog 5th Edition", "FK5 5258"},
        {"Geneva Identification System", "GEN# +1.00124681"},
        {"Smithsonian Astrophysical Observation", "SAO 120364"},
        {"Wilson Evans Batten Catalogue", "WEB 12122"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.72103315),
        dec: Angle.Degrees(+03.33593802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127912"},
        {"Hipparcos Number", "HIP 71227"},
        {"Smithsonian Astrophysical Observation", "SAO 120532"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.48324246),
        dec: Angle.Degrees(+03.33634888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181990"},
        {"Hipparcos Number", "HIP 95224"},
        {"Smithsonian Astrophysical Observation", "SAO 124556"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.60219740),
        dec: Angle.Degrees(+03.33860082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85242"},
        {"Hipparcos Number", "HIP 48282"},
        {"Smithsonian Astrophysical Observation", "SAO 117939"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.66035631),
        dec: Angle.Degrees(+03.34145663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42402",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Minchir"},
        {"Henry Draper", "HD 73471"},
        {"Hipparcos Number", "HIP 42402"},
        {"Fundamental Katalog 5th Edition", "FK5 1224"},
        {"Geneva Identification System", "GEN# +1.00073471"},
        {"Smithsonian Astrophysical Observation", "SAO 116988"},
        {"Wilson Evans Batten Catalogue", "WEB 8151"},
    },
    visualMagnitude: 4.45,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.68936993),
        dec: Angle.Degrees(+03.34147477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104800"},
        {"Hipparcos Number", "HIP 58843"},
        {"Cincinnati Publication", "Ci 20 679"},
        {"Geneva Identification System", "GEN# +1.00104800"},
        {"Smithsonian Astrophysical Observation", "SAO 119191"},
        {"Wilson Evans Batten Catalogue", "WEB 10480"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02302917),
        dec: Angle.Degrees(+03.34215150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -575.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214493"},
        {"Hipparcos Number", "HIP 111779"},
        {"Smithsonian Astrophysical Observation", "SAO 127653"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62382485),
        dec: Angle.Degrees(+03.34243286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60504"},
        {"Hipparcos Number", "HIP 36879"},
        {"Geneva Identification System", "GEN# +1.00060504"},
        {"Smithsonian Astrophysical Observation", "SAO 115655"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.72156013),
        dec: Angle.Degrees(+03.34294386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217458"},
        {"Hipparcos Number", "HIP 113627"},
        {"Smithsonian Astrophysical Observation", "SAO 127897"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.19170116),
        dec: Angle.Degrees(+03.34381736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91893",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11619 AB"},
        {"Henry Draper", "HD 173196"},
        {"Hipparcos Number", "HIP 91893"},
        {"Smithsonian Astrophysical Observation", "SAO 123862"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.99706899),
        dec: Angle.Degrees(+03.34395755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20414"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.58458238),
        dec: Angle.Degrees(+03.34682558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101540"},
        {"Geneva Identification System", "GEN# +9.80024020"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.67858975),
        dec: Angle.Degrees(+03.34874845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 313.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -431.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210824"},
        {"Hipparcos Number", "HIP 109678"},
        {"Smithsonian Astrophysical Observation", "SAO 127376"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.26382790),
        dec: Angle.Degrees(+03.34933070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8587"},
        {"Hipparcos Number", "HIP 6614"},
        {"Smithsonian Astrophysical Observation", "SAO 109873"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.22736639),
        dec: Angle.Degrees(+03.34944619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200326"},
        {"Hipparcos Number", "HIP 103863"},
        {"Smithsonian Astrophysical Observation", "SAO 126488"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.67885251),
        dec: Angle.Degrees(+03.35029653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110763"},
        {"Hipparcos Number", "HIP 62147"},
        {"Smithsonian Astrophysical Observation", "SAO 119563"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.06656595),
        dec: Angle.Degrees(+03.35108774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84321"},
        {"Hipparcos Number", "HIP 47795"},
        {"Smithsonian Astrophysical Observation", "SAO 117885"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15875250),
        dec: Angle.Degrees(+03.35326160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36340"},
        {"Hipparcos Number", "HIP 25850"},
        {"Geneva Identification System", "GEN# +1.00036340"},
        {"Smithsonian Astrophysical Observation", "SAO 112859"},
        {"Wilson Evans Batten Catalogue", "WEB 5017"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.77090135),
        dec: Angle.Degrees(+03.35327866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196593"},
        {"Hipparcos Number", "HIP 101842"},
        {"Smithsonian Astrophysical Observation", "SAO 126042"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.57219808),
        dec: Angle.Degrees(+03.35649236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172425"},
        {"Hipparcos Number", "HIP 91538"},
        {"Smithsonian Astrophysical Observation", "SAO 123786"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.02095340),
        dec: Angle.Degrees(+03.35668531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68386"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.98961623),
        dec: Angle.Degrees(+03.35791264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79306"},
        {"Hipparcos Number", "HIP 45248"},
        {"Smithsonian Astrophysical Observation", "SAO 117507"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.33839504),
        dec: Angle.Degrees(+03.35824333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12536"},
        {"Hipparcos Number", "HIP 9576"},
        {"Geneva Identification System", "GEN# +1.00012536"},
        {"Smithsonian Astrophysical Observation", "SAO 110302"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.75664962),
        dec: Angle.Degrees(+03.35828084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132973"},
        {"Hipparcos Number", "HIP 73544"},
        {"Geneva Identification System", "GEN# +1.00132973"},
        {"Smithsonian Astrophysical Observation", "SAO 120800"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.46820194),
        dec: Angle.Degrees(+03.36048342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22227"},
        {"Hipparcos Number", "HIP 16698"},
        {"Smithsonian Astrophysical Observation", "SAO 111274"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.72221838),
        dec: Angle.Degrees(+03.36054372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149029"},
        {"Hipparcos Number", "HIP 80971"},
        {"Smithsonian Astrophysical Observation", "SAO 121672"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.01629543),
        dec: Angle.Degrees(+03.36204577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100416"},
        {"Hipparcos Number", "HIP 56371"},
        {"Smithsonian Astrophysical Observation", "SAO 118917"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.33228718),
        dec: Angle.Degrees(+03.36250969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91537"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.01966697),
        dec: Angle.Degrees(+03.36268329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1030"},
        {"Hipparcos Number", "HIP 1179"},
        {"Smithsonian Astrophysical Observation", "SAO 109085"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.67302810),
        dec: Angle.Degrees(+03.36392861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98060"},
    },
    visualMagnitude: 12.17,
    bvColour: 1.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.92886421),
        dec: Angle.Degrees(+03.36455182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16260"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.39024326),
        dec: Angle.Degrees(+03.36498632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57515"},
        {"Hipparcos Number", "HIP 35674"},
        {"Smithsonian Astrophysical Observation", "SAO 115320"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.41489418),
        dec: Angle.Degrees(+03.36760290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20630"},
        {"Hipparcos Number", "HIP 15457"},
        {"Fundamental Katalog 5th Edition", "FK5 1093"},
        {"Geneva Identification System", "GEN# +1.00020630"},
        {"Smithsonian Astrophysical Observation", "SAO 111120"},
        {"Wilson Evans Batten Catalogue", "WEB 2972"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.83974536),
        dec: Angle.Degrees(+03.36997055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 268.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140614"},
        {"Hipparcos Number", "HIP 77094"},
        {"Geneva Identification System", "GEN# +1.00140614"},
        {"Smithsonian Astrophysical Observation", "SAO 121159"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.12613538),
        dec: Angle.Degrees(+03.37016524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222111"},
        {"Hipparcos Number", "HIP 116600"},
        {"Geneva Identification System", "GEN# +1.00222111"},
        {"Smithsonian Astrophysical Observation", "SAO 128293"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.45455811),
        dec: Angle.Degrees(+03.37030064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60357"},
        {"Hipparcos Number", "HIP 36812"},
        {"Geneva Identification System", "GEN# +1.00060357"},
        {"Smithsonian Astrophysical Observation", "SAO 115644"},
        {"Wilson Evans Batten Catalogue", "WEB 7314"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.56622524),
        dec: Angle.Degrees(+03.37173632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47817"},
        {"Hipparcos Number", "HIP 31952"},
        {"Smithsonian Astrophysical Observation", "SAO 114253"},
        {"Wilson Evans Batten Catalogue", "WEB 6425"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.15602105),
        dec: Angle.Degrees(+03.37361673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1943"},
        {"Smithsonian Astrophysical Observation", "SAO 109184"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.13995879),
        dec: Angle.Degrees(+03.37423252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89918",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11271 A"},
        {"Henry Draper", "HD 168656"},
        {"Hipparcos Number", "HIP 89918"},
        {"Fundamental Katalog 5th Edition", "FK5 1476"},
        {"Geneva Identification System", "GEN# +1.00168656A"},
        {"Smithsonian Astrophysical Observation", "SAO 123377"},
        {"Wilson Evans Batten Catalogue", "WEB 15354"},
    },
    visualMagnitude: 4.85,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.21692548),
        dec: Angle.Degrees(+03.37714467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78175"},
        {"Smithsonian Astrophysical Observation", "SAO 121282"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.43157275),
        dec: Angle.Degrees(+03.37721995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5572"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.86600522),
        dec: Angle.Degrees(+03.37750415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36384",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6121 AB"},
        {"Henry Draper", "HD 59271"},
        {"Hipparcos Number", "HIP 36384"},
        {"Smithsonian Astrophysical Observation", "SAO 115514"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.32463189),
        dec: Angle.Degrees(+03.38033902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4821"},
        {"Hipparcos Number", "HIP 3925"},
        {"Smithsonian Astrophysical Observation", "SAO 109494"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.60207386),
        dec: Angle.Degrees(+03.38141553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185423"},
        {"Hipparcos Number", "HIP 96630"},
        {"Fundamental Katalog 5th Edition", "FK5 3569"},
        {"Geneva Identification System", "GEN# +1.00185423"},
        {"Smithsonian Astrophysical Observation", "SAO 124892"},
        {"Wilson Evans Batten Catalogue", "WEB 16954"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.70412852),
        dec: Angle.Degrees(+03.38152187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221527"},
        {"Hipparcos Number", "HIP 116223"},
        {"Smithsonian Astrophysical Observation", "SAO 128240"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.22697445),
        dec: Angle.Degrees(+03.38167077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225058"},
        {"Hipparcos Number", "HIP 239"},
        {"Smithsonian Astrophysical Observation", "SAO 108985"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.74317400),
        dec: Angle.Degrees(+03.38193739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11815"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.09624982),
        dec: Angle.Degrees(+03.38259131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6425 AB"},
        {"Henry Draper", "HD 64165"},
        {"Hipparcos Number", "HIP 38460"},
        {"Geneva Identification System", "GEN# +1.00064165J"},
        {"Smithsonian Astrophysical Observation", "SAO 116064"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.17545115),
        dec: Angle.Degrees(+03.38390209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45356"},
        {"Hipparcos Number", "HIP 30702"},
        {"Geneva Identification System", "GEN# +1.00045356"},
        {"Smithsonian Astrophysical Observation", "SAO 113897"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.76483616),
        dec: Angle.Degrees(+03.38414139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86611"},
        {"Hipparcos Number", "HIP 48990"},
        {"Fundamental Katalog 5th Edition", "FK5 376"},
        {"Geneva Identification System", "GEN# +1.00086611"},
        {"Smithsonian Astrophysical Observation", "SAO 118041"},
        {"Wilson Evans Batten Catalogue", "WEB 9091"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.92965948),
        dec: Angle.Degrees(+03.38474767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4928"},
        {"Hipparcos Number", "HIP 3992"},
        {"Geneva Identification System", "GEN# +1.00004928"},
        {"Smithsonian Astrophysical Observation", "SAO 109507"},
        {"Wilson Evans Batten Catalogue", "WEB 712"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.82629635),
        dec: Angle.Degrees(+03.38517465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193970"},
        {"Hipparcos Number", "HIP 100516"},
        {"Fundamental Katalog 5th Edition", "FK5 5796"},
        {"Smithsonian Astrophysical Observation", "SAO 125742"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.73483386),
        dec: Angle.Degrees(+03.38782364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41986"},
        {"Hipparcos Number", "HIP 29101"},
        {"Smithsonian Astrophysical Observation", "SAO 113493"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07250576),
        dec: Angle.Degrees(+03.38839194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87551"},
        {"Hipparcos Number", "HIP 49458"},
        {"Smithsonian Astrophysical Observation", "SAO 118098"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.46639356),
        dec: Angle.Degrees(+03.38911647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176764"},
        {"Hipparcos Number", "HIP 93434"},
        {"Smithsonian Astrophysical Observation", "SAO 124166"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.42897037),
        dec: Angle.Degrees(+03.38917843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18140"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.16677184),
        dec: Angle.Degrees(+03.38965477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150206"},
        {"Hipparcos Number", "HIP 81556"},
        {"Smithsonian Astrophysical Observation", "SAO 121762"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.84749838),
        dec: Angle.Degrees(+03.39222075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10688 A"},
        {"Henry Draper", "HD 160385"},
        {"Hipparcos Number", "HIP 86424"},
        {"Smithsonian Astrophysical Observation", "SAO 122615"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.87986716),
        dec: Angle.Degrees(+03.39273735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199238"},
        {"Hipparcos Number", "HIP 103313"},
        {"Geneva Identification System", "GEN# +1.00199238"},
        {"Smithsonian Astrophysical Observation", "SAO 126375"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.95922052),
        dec: Angle.Degrees(+03.39278158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59063"},
        {"Hipparcos Number", "HIP 36309"},
        {"Geneva Identification System", "GEN# +1.00059063"},
        {"Smithsonian Astrophysical Observation", "SAO 115495"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.10741879),
        dec: Angle.Degrees(+03.39300849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17277"},
    },
    visualMagnitude: 11.31,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.49785678),
        dec: Angle.Degrees(+03.39350871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50484"},
        {"Hipparcos Number", "HIP 33101"},
        {"Renson", "Renson 13840"},
        {"Smithsonian Astrophysical Observation", "SAO 114570"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.41070770),
        dec: Angle.Degrees(+03.39582736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15207"},
        {"Smithsonian Astrophysical Observation", "SAO 111083"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.01435413),
        dec: Angle.Degrees(+03.39702691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63090",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Minelauva"},
        {"Henry Draper", "HD 112300"},
        {"Hipparcos Number", "HIP 63090"},
        {"Cincinnati Publication", "Ci 20 749"},
        {"Fundamental Katalog 5th Edition", "FK5 484"},
        {"Geneva Identification System", "GEN# +1.00112300"},
        {"Smithsonian Astrophysical Observation", "SAO 119674"},
        {"Wilson Evans Batten Catalogue", "WEB 11187"},
    },
    visualMagnitude: 3.39,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.90201366),
        dec: Angle.Degrees(+03.39759862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -471.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74280"},
        {"Hipparcos Number", "HIP 42799"},
        {"Fundamental Katalog 5th Edition", "FK5 2687"},
        {"Geneva Identification System", "GEN# +1.00074280"},
        {"Smithsonian Astrophysical Observation", "SAO 117050"},
        {"Wilson Evans Batten Catalogue", "WEB 8265"},
    },
    visualMagnitude: 4.30,
    bvColour: -0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80619315),
        dec: Angle.Degrees(+03.39866539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66513"},
        {"Hipparcos Number", "HIP 39458"},
        {"Smithsonian Astrophysical Observation", "SAO 116290"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.98111860),
        dec: Angle.Degrees(+03.39878423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32400",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5428 AB"},
        {"Henry Draper", "HD 263502"},
        {"Hipparcos Number", "HIP 32400"},
        {"Smithsonian Astrophysical Observation", "SAO 114379"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.46602574),
        dec: Angle.Degrees(+03.40069607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106105"},
        {"Hipparcos Number", "HIP 59536"},
        {"Geneva Identification System", "GEN# +1.00106105"},
        {"Smithsonian Astrophysical Observation", "SAO 119272"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.12484296),
        dec: Angle.Degrees(+03.40404643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78134",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9855 A"},
        {"Henry Draper", "HD 142930"},
        {"Hipparcos Number", "HIP 78134"},
        {"Geneva Identification System", "GEN# +1.00142930"},
        {"Smithsonian Astrophysical Observation", "SAO 121277"},
        {"Wilson Evans Batten Catalogue", "WEB 13213"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.31223026),
        dec: Angle.Degrees(+03.40532113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192460"},
        {"Hipparcos Number", "HIP 99798"},
        {"Smithsonian Astrophysical Observation", "SAO 125609"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.72261774),
        dec: Angle.Degrees(+03.40684291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78131",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9855 B"},
        {"Hipparcos Number", "HIP 78131"},
        {"Smithsonian Astrophysical Observation", "SAO 121276"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.31039263),
        dec: Angle.Degrees(+03.40765597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156287"},
        {"Hipparcos Number", "HIP 84515"},
        {"Geneva Identification System", "GEN# +1.00156287"},
        {"Smithsonian Astrophysical Observation", "SAO 122229"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.15409208),
        dec: Angle.Degrees(+03.40840679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71508"},
        {"Smithsonian Astrophysical Observation", "SAO 120568"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.35717621),
        dec: Angle.Degrees(+03.40913887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144762"},
        {"Hipparcos Number", "HIP 78995"},
        {"Smithsonian Astrophysical Observation", "SAO 121375"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.87407607),
        dec: Angle.Degrees(+03.40921447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27707"},
        {"Hipparcos Number", "HIP 20424"},
        {"Fundamental Katalog 5th Edition", "FK5 4400"},
        {"Smithsonian Astrophysical Observation", "SAO 111776"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.62549734),
        dec: Angle.Degrees(+03.40972953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131428"},
        {"Hipparcos Number", "HIP 72855"},
        {"Smithsonian Astrophysical Observation", "SAO 120713"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.37320695),
        dec: Angle.Degrees(+03.40985787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52055"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.55910788),
        dec: Angle.Degrees(+03.41356269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109554"},
        {"Hipparcos Number", "HIP 61458"},
        {"Smithsonian Astrophysical Observation", "SAO 119488"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.91213370),
        dec: Angle.Degrees(+03.41511284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84702"},
        {"Hipparcos Number", "HIP 48004"},
        {"Smithsonian Astrophysical Observation", "SAO 117905"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.77837848),
        dec: Angle.Degrees(+03.41603354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131917"},
        {"Hipparcos Number", "HIP 73093"},
        {"Geneva Identification System", "GEN# +1.00131917"},
        {"Smithsonian Astrophysical Observation", "SAO 120743"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.07023452),
        dec: Angle.Degrees(+03.41622034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37544"},
        {"Hipparcos Number", "HIP 26615"},
        {"Smithsonian Astrophysical Observation", "SAO 113006"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.86231983),
        dec: Angle.Degrees(+03.41651188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10809"},
        {"Hipparcos Number", "HIP 8225"},
        {"Geneva Identification System", "GEN# +1.00010809"},
        {"Renson", "Renson 2680"},
        {"Smithsonian Astrophysical Observation", "SAO 110114"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.47918313),
        dec: Angle.Degrees(+03.41757837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104931"},
    },
    visualMagnitude: 10.57,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.82695557),
        dec: Angle.Degrees(+03.41931489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164734"},
        {"Hipparcos Number", "HIP 88355"},
        {"Geneva Identification System", "GEN# +1.00164734"},
        {"Smithsonian Astrophysical Observation", "SAO 123054"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.64093216),
        dec: Angle.Degrees(+03.42041096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80701"},
        {"Hipparcos Number", "HIP 45872"},
        {"Geneva Identification System", "GEN# +1.00080701"},
        {"Smithsonian Astrophysical Observation", "SAO 117613"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.30391534),
        dec: Angle.Degrees(+03.42060174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156021"},
        {"Hipparcos Number", "HIP 84384"},
        {"Geneva Identification System", "GEN# +1.00156021"},
        {"Smithsonian Astrophysical Observation", "SAO 122207"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.77411744),
        dec: Angle.Degrees(+03.42391849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44544"},
        {"Hipparcos Number", "HIP 30301"},
        {"Geneva Identification System", "GEN# +1.00044544"},
    },
    visualMagnitude: 9.76,
    bvColour: 3.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.59937916),
        dec: Angle.Degrees(+03.42443672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54853"},
        {"Smithsonian Astrophysical Observation", "SAO 118733"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.45904632),
        dec: Angle.Degrees(+03.42449515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45282"},
        {"Hipparcos Number", "HIP 30668"},
        {"Geneva Identification System", "GEN# +1.00045282"},
        {"Smithsonian Astrophysical Observation", "SAO 113885"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.66986987),
        dec: Angle.Degrees(+03.42516264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5973"},
        {"Hipparcos Number", "HIP 4759"},
        {"Smithsonian Astrophysical Observation", "SAO 109602"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.29145793),
        dec: Angle.Degrees(+03.42974101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221408"},
        {"Hipparcos Number", "HIP 116138"},
        {"Smithsonian Astrophysical Observation", "SAO 128229"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.97421179),
        dec: Angle.Degrees(+03.43053574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22149"},
        {"Hipparcos Number", "HIP 16651"},
        {"Geneva Identification System", "GEN# +1.00022149"},
        {"Smithsonian Astrophysical Observation", "SAO 111264"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.55682998),
        dec: Angle.Degrees(+03.43236450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44016"},
        {"Smithsonian Astrophysical Observation", "SAO 117306"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.45292114),
        dec: Angle.Degrees(+03.43573893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154443"},
        {"Hipparcos Number", "HIP 83619"},
        {"Geneva Identification System", "GEN# +1.00154443"},
        {"Smithsonian Astrophysical Observation", "SAO 122061"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34765958),
        dec: Angle.Degrees(+03.43860791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93728"},
        {"Hipparcos Number", "HIP 52919"},
        {"Smithsonian Astrophysical Observation", "SAO 118518"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.34757420),
        dec: Angle.Degrees(+03.44023181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16569"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.33328009),
        dec: Angle.Degrees(+03.44025329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191840"},
        {"Hipparcos Number", "HIP 99516"},
        {"Smithsonian Astrophysical Observation", "SAO 125549"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.94811989),
        dec: Angle.Degrees(+03.44068026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 359"},
        {"Hipparcos Number", "HIP 675"},
        {"Geneva Identification System", "GEN# +1.00000359"},
        {"Smithsonian Astrophysical Observation", "SAO 109026"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.09220806),
        dec: Angle.Degrees(+03.44072762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102010",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14133 A"},
        {"Henry Draper", "HD 196929"},
        {"Hipparcos Number", "HIP 102010"},
        {"Smithsonian Astrophysical Observation", "SAO 126088"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.07349694),
        dec: Angle.Degrees(+03.44125739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84543"},
        {"Hipparcos Number", "HIP 47935"},
        {"Smithsonian Astrophysical Observation", "SAO 117897"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.52277297),
        dec: Angle.Degrees(+03.44145036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178129"},
        {"Hipparcos Number", "HIP 93904"},
        {"Geneva Identification System", "GEN# +1.00178129"},
        {"Smithsonian Astrophysical Observation", "SAO 124288"},
        {"Wilson Evans Batten Catalogue", "WEB 16338"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.82563513),
        dec: Angle.Degrees(+03.44302175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141271"},
        {"Hipparcos Number", "HIP 77404"},
        {"Geneva Identification System", "GEN# +1.00141271"},
        {"Smithsonian Astrophysical Observation", "SAO 121195"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.03276586),
        dec: Angle.Degrees(+03.44317953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16467"},
        {"Hipparcos Number", "HIP 12318"},
        {"Geneva Identification System", "GEN# +1.00016467"},
        {"Smithsonian Astrophysical Observation", "SAO 110655"},
        {"Wilson Evans Batten Catalogue", "WEB 2526"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.65326455),
        dec: Angle.Degrees(+03.44318549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183656"},
        {"Hipparcos Number", "HIP 95929"},
        {"Geneva Identification System", "GEN# +1.00183656"},
        {"Smithsonian Astrophysical Observation", "SAO 124704"},
        {"Wilson Evans Batten Catalogue", "WEB 16798"},
    },
    visualMagnitude: 6.09,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.63797828),
        dec: Angle.Degrees(+03.44440006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15711"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.59701531),
        dec: Angle.Degrees(+03.44725936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217144"},
        {"Hipparcos Number", "HIP 113441"},
        {"Smithsonian Astrophysical Observation", "SAO 127868"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.62781406),
        dec: Angle.Degrees(+03.44777497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34341"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.78875508),
        dec: Angle.Degrees(+03.44808184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137929"},
        {"Hipparcos Number", "HIP 75773"},
        {"Smithsonian Astrophysical Observation", "SAO 121022"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.19255679),
        dec: Angle.Degrees(+03.44818272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129229"},
        {"Hipparcos Number", "HIP 71806"},
        {"Geneva Identification System", "GEN# +1.00129229"},
        {"Smithsonian Astrophysical Observation", "SAO 120599"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.32839677),
        dec: Angle.Degrees(+03.44882595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1644"},
        {"Hipparcos Number", "HIP 1653"},
        {"Smithsonian Astrophysical Observation", "SAO 109153"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18178259),
        dec: Angle.Degrees(+03.44948223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11842 AB"},
        {"Henry Draper", "HD 175543"},
        {"Hipparcos Number", "HIP 92909"},
        {"Geneva Identification System", "GEN# +1.00175543J"},
        {"Renson", "Renson 49050"},
        {"Smithsonian Astrophysical Observation", "SAO 124058"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.95260604),
        dec: Angle.Degrees(+03.44979606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94819"},
        {"Hipparcos Number", "HIP 53512"},
        {"Smithsonian Astrophysical Observation", "SAO 118583"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.20726401),
        dec: Angle.Degrees(+03.45024884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13467"},
        {"Hipparcos Number", "HIP 10242"},
        {"Geneva Identification System", "GEN# +1.00013467"},
        {"Smithsonian Astrophysical Observation", "SAO 110395"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.93085546),
        dec: Angle.Degrees(+03.45271653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178952"},
        {"Hipparcos Number", "HIP 94189"},
        {"Geneva Identification System", "GEN# +1.00178952"},
        {"Smithsonian Astrophysical Observation", "SAO 124346"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.63743188),
        dec: Angle.Degrees(+03.45298605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150764"},
        {"Hipparcos Number", "HIP 81846"},
        {"Geneva Identification System", "GEN# +1.00150764"},
        {"Smithsonian Astrophysical Observation", "SAO 121807"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.76203938),
        dec: Angle.Degrees(+03.45436278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145085"},
        {"Hipparcos Number", "HIP 79120"},
        {"Geneva Identification System", "GEN# +1.00145085"},
        {"Smithsonian Astrophysical Observation", "SAO 121390"},
        {"Wilson Evans Batten Catalogue", "WEB 13374"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.24541959),
        dec: Angle.Degrees(+03.45444515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125922"},
        {"Hipparcos Number", "HIP 70249"},
        {"Smithsonian Astrophysical Observation", "SAO 120416"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.60616447),
        dec: Angle.Degrees(+03.45493412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62466",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8668 A"},
        {"Henry Draper", "HD 111274"},
        {"Hipparcos Number", "HIP 62466"},
        {"Smithsonian Astrophysical Observation", "SAO 119598"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.01693147),
        dec: Angle.Degrees(+03.45534062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10183"},
        {"Hipparcos Number", "HIP 7747"},
        {"Geneva Identification System", "GEN# +1.00010183"},
        {"Smithsonian Astrophysical Observation", "SAO 110037"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.93313686),
        dec: Angle.Degrees(+03.45548852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32359"},
        {"Hipparcos Number", "HIP 23473"},
        {"Smithsonian Astrophysical Observation", "SAO 112356"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68563313),
        dec: Angle.Degrees(+03.45771424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209904"},
        {"Hipparcos Number", "HIP 109150"},
        {"Smithsonian Astrophysical Observation", "SAO 127302"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64557758),
        dec: Angle.Degrees(+03.45882610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21365"},
        {"Hipparcos Number", "HIP 16066"},
        {"Geneva Identification System", "GEN# +1.00021365"},
        {"Smithsonian Astrophysical Observation", "SAO 111194"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.73449882),
        dec: Angle.Degrees(+03.46464024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14950"},
        {"Smithsonian Astrophysical Observation", "SAO 111049"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.17947097),
        dec: Angle.Degrees(+03.46493485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128221"},
        {"Hipparcos Number", "HIP 71360"},
        {"Geneva Identification System", "GEN# +1.00128221"},
        {"Smithsonian Astrophysical Observation", "SAO 120548"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.90024052),
        dec: Angle.Degrees(+03.46763941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139622"},
        {"Hipparcos Number", "HIP 76634"},
        {"Smithsonian Astrophysical Observation", "SAO 121107"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.75442797),
        dec: Angle.Degrees(+03.46780541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175312"},
        {"Hipparcos Number", "HIP 92819"},
        {"Smithsonian Astrophysical Observation", "SAO 124034"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.68740300),
        dec: Angle.Degrees(+03.46849035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87803"},
        {"Geneva Identification System", "GEN# +9.80020020"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.05011236),
        dec: Angle.Degrees(+03.47247537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -237.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123192"},
        {"Hipparcos Number", "HIP 68870"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54219905),
        dec: Angle.Degrees(+03.47324525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102329"},
        {"Hipparcos Number", "HIP 57467"},
        {"Smithsonian Astrophysical Observation", "SAO 119043"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.69446587),
        dec: Angle.Degrees(+03.47433829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87656"},
        {"Hipparcos Number", "HIP 49508"},
        {"Geneva Identification System", "GEN# +1.00087656"},
        {"Smithsonian Astrophysical Observation", "SAO 118109"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.62798260),
        dec: Angle.Degrees(+03.47482190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29999"},
        {"Hipparcos Number", "HIP 22005"},
        {"Smithsonian Astrophysical Observation", "SAO 112017"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.95490105),
        dec: Angle.Degrees(+03.47789904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103945"},
        {"Hipparcos Number", "HIP 58377"},
        {"Smithsonian Astrophysical Observation", "SAO 119139"},
        {"Wilson Evans Batten Catalogue", "WEB 10434"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.55802245),
        dec: Angle.Degrees(+03.48202404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12244"},
        {"Smithsonian Astrophysical Observation", "SAO 110649"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.41727246),
        dec: Angle.Degrees(+03.48267403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25701"},
        {"Geneva Identification System", "GEN# +0.00300924"},
        {"Wilson Evans Batten Catalogue", "WEB 4986"},
    },
    visualMagnitude: 9.99,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.32264504),
        dec: Angle.Degrees(+03.48366782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129887"},
        {"Hipparcos Number", "HIP 72096"},
        {"Geneva Identification System", "GEN# +1.00129887"},
        {"Smithsonian Astrophysical Observation", "SAO 120636"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23157632),
        dec: Angle.Degrees(+03.48424875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75302"},
        {"Hipparcos Number", "HIP 43297"},
        {"Geneva Identification System", "GEN# +1.00075302"},
        {"Smithsonian Astrophysical Observation", "SAO 117163"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.30256721),
        dec: Angle.Degrees(+03.48461117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6317 A"},
        {"Henry Draper", "HD 62323"},
        {"Henry Draper 2", "HD 62323A"},
        {"Hipparcos Number", "HIP 37645"},
        {"Geneva Identification System", "GEN# +1.00062323"},
        {"Smithsonian Astrophysical Observation", "SAO 115851"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.87956075),
        dec: Angle.Degrees(+03.48606514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223075"},
        {"Hipparcos Number", "HIP 117245"},
        {"Fundamental Katalog 5th Edition", "FK5 3908"},
        {"Geneva Identification System", "GEN# +1.00223075"},
        {"Smithsonian Astrophysical Observation", "SAO 128374"},
        {"Wilson Evans Batten Catalogue", "WEB 20657"},
    },
    visualMagnitude: 4.95,
    bvColour: 2.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.59807048),
        dec: Angle.Degrees(+03.48687164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18162"},
        {"Hipparcos Number", "HIP 13593"},
        {"Geneva Identification System", "GEN# +1.00018162"},
        {"Smithsonian Astrophysical Observation", "SAO 110833"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.78396033),
        dec: Angle.Degrees(+03.48690209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242244"},
        {"Hipparcos Number", "HIP 24570"},
        {"Smithsonian Astrophysical Observation", "SAO 112586"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.06320581),
        dec: Angle.Degrees(+03.48968019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198585"},
        {"Hipparcos Number", "HIP 102929"},
        {"Geneva Identification System", "GEN# +1.00198585"},
        {"Smithsonian Astrophysical Observation", "SAO 126291"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.80189947),
        dec: Angle.Degrees(+03.49043297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71094"},
        {"Hipparcos Number", "HIP 41300"},
        {"Smithsonian Astrophysical Observation", "SAO 116745"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.39931346),
        dec: Angle.Degrees(+03.49084889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218744"},
        {"Hipparcos Number", "HIP 114429"},
        {"Smithsonian Astrophysical Observation", "SAO 128012"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.61355071),
        dec: Angle.Degrees(+03.49086829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43101"},
        {"Hipparcos Number", "HIP 29624"},
        {"Smithsonian Astrophysical Observation", "SAO 113622"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.64043385),
        dec: Angle.Degrees(+03.49099013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140267"},
        {"Hipparcos Number", "HIP 76932"},
        {"Smithsonian Astrophysical Observation", "SAO 121137"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.64018291),
        dec: Angle.Degrees(+03.49382825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33934",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5721 AB"},
        {"Henry Draper", "HD 52742"},
        {"Hipparcos Number", "HIP 33934"},
        {"Smithsonian Astrophysical Observation", "SAO 114820"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.62051831),
        dec: Angle.Degrees(+03.49875761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169554"},
        {"Hipparcos Number", "HIP 90269"},
        {"Smithsonian Astrophysical Observation", "SAO 123449"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.27754228),
        dec: Angle.Degrees(+03.50134567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46029",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7342 A"},
        {"Henry Draper", "HD 81029"},
        {"Henry Draper 2", "HD 81029A"},
        {"Hipparcos Number", "HIP 46029"},
        {"Geneva Identification System", "GEN# +1.00081029A"},
        {"Renson", "Renson 23000"},
        {"Smithsonian Astrophysical Observation", "SAO 117641"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.81585177),
        dec: Angle.Degrees(+03.50135148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127414"},
        {"Hipparcos Number", "HIP 70996"},
        {"Smithsonian Astrophysical Observation", "SAO 120508"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.80753079),
        dec: Angle.Degrees(+03.50195412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224156"},
        {"Hipparcos Number", "HIP 117953"},
        {"Cincinnati Publication", "Ci 18 3134"},
        {"Geneva Identification System", "GEN# +1.00224156"},
        {"Smithsonian Astrophysical Observation", "SAO 128469"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.88558803),
        dec: Angle.Degrees(+03.50216062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190594"},
        {"Hipparcos Number", "HIP 98964"},
        {"Fundamental Katalog 5th Edition", "FK5 5769"},
        {"Geneva Identification System", "GEN# +1.00190594"},
        {"Smithsonian Astrophysical Observation", "SAO 125430"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.38980494),
        dec: Angle.Degrees(+03.50310035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130125"},
        {"Hipparcos Number", "HIP 72223"},
        {"Geneva Identification System", "GEN# +1.00130125"},
        {"Smithsonian Astrophysical Observation", "SAO 120649"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.56806632),
        dec: Angle.Degrees(+03.50420449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7342 B"},
        {"Henry Draper", "HD 81029B"},
        {"Hipparcos Number", "HIP 46028"},
        {"Geneva Identification System", "GEN# +1.00081029B"},
        {"Smithsonian Astrophysical Observation", "SAO 117640"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.81141839),
        dec: Angle.Degrees(+03.50525693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88278",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10987 E"},
        {"Henry Draper", "HD 164557"},
        {"Hipparcos Number", "HIP 88278"},
        {"Geneva Identification System", "GEN# +1.00164557"},
        {"Smithsonian Astrophysical Observation", "SAO 123034"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.40167821),
        dec: Angle.Degrees(+03.50576027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267315"},
        {"Hipparcos Number", "HIP 33547"},
        {"Geneva Identification System", "GEN# +1.00267315"},
        {"Smithsonian Astrophysical Observation", "SAO 114702"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.57513441),
        dec: Angle.Degrees(+03.50717088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186413"},
        {"Hipparcos Number", "HIP 97105"},
        {"Geneva Identification System", "GEN# +1.00186413"},
        {"Smithsonian Astrophysical Observation", "SAO 124998"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.01817167),
        dec: Angle.Degrees(+03.50802392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9014 AB"},
        {"Henry Draper", "HD 119843"},
        {"Hipparcos Number", "HIP 67136"},
        {"Smithsonian Astrophysical Observation", "SAO 120098"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.38404987),
        dec: Angle.Degrees(+03.50809196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108877"},
        {"Hipparcos Number", "HIP 61037"},
        {"Smithsonian Astrophysical Observation", "SAO 119437"},
        {"Wilson Evans Batten Catalogue", "WEB 10867"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.64350935),
        dec: Angle.Degrees(+03.50824819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42845"},
        {"Hipparcos Number", "HIP 29516"},
        {"Celescope Catalog", "CEL 1124"},
        {"Geneva Identification System", "GEN# +1.00042845"},
        {"Smithsonian Astrophysical Observation", "SAO 113596"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.26570221),
        dec: Angle.Degrees(+03.50905953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97196"},
        {"Hipparcos Number", "HIP 54661"},
        {"Smithsonian Astrophysical Observation", "SAO 118708"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.83741404),
        dec: Angle.Degrees(+03.51252170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111661"},
        {"Hipparcos Number", "HIP 62698"},
        {"Smithsonian Astrophysical Observation", "SAO 119622"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.71229689),
        dec: Angle.Degrees(+03.51309540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8291"},
        {"Hipparcos Number", "HIP 6407"},
        {"Smithsonian Astrophysical Observation", "SAO 109831"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.57790181),
        dec: Angle.Degrees(+03.51348726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29734"},
        {"Hipparcos Number", "HIP 21809"},
        {"Smithsonian Astrophysical Observation", "SAO 111977"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.27407130),
        dec: Angle.Degrees(+03.51397801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41437"},
        {"Wilson Evans Batten Catalogue", "WEB 8014"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.76641260),
        dec: Angle.Degrees(+03.51469160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29273"},
        {"Hipparcos Number", "HIP 21477"},
        {"Cincinnati Publication", "Ci 18 599"},
        {"Geneva Identification System", "GEN# +1.00029273"},
        {"Smithsonian Astrophysical Observation", "SAO 111915"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.17884429),
        dec: Angle.Degrees(+03.51475769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8340 AB"},
        {"Henry Draper", "HD 103262"},
        {"Hipparcos Number", "HIP 57975"},
        {"Geneva Identification System", "GEN# +1.00103262"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.38692876),
        dec: Angle.Degrees(+03.51716097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18597"},
        {"Hipparcos Number", "HIP 13937"},
        {"Geneva Identification System", "GEN# +1.00018597"},
        {"Renson", "Renson 4660"},
        {"Smithsonian Astrophysical Observation", "SAO 110887"},
        {"Wilson Evans Batten Catalogue", "WEB 2749"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.88971236),
        dec: Angle.Degrees(+03.51758351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9275"},
        {"Geneva Identification System", "GEN# +9.80159018"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.80095354),
        dec: Angle.Degrees(+03.51918598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 258.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182740"},
        {"Hipparcos Number", "HIP 95547"},
        {"Smithsonian Astrophysical Observation", "SAO 124619"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.52133197),
        dec: Angle.Degrees(+03.51938421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88271",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10987 AB"},
        {"Henry Draper", "HD 164529"},
        {"Hipparcos Number", "HIP 88271"},
        {"Geneva Identification System", "GEN# +1.00164529J"},
        {"Smithsonian Astrophysical Observation", "SAO 123031"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.38482098),
        dec: Angle.Degrees(+03.52428749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8658 AB"},
        {"Henry Draper", "HD 110899"},
        {"Hipparcos Number", "HIP 62237"},
        {"Smithsonian Astrophysical Observation", "SAO 119569"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.33800798),
        dec: Angle.Degrees(+03.52445458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25035"},
        {"Hipparcos Number", "HIP 18600"},
        {"Smithsonian Astrophysical Observation", "SAO 111538"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.69476402),
        dec: Angle.Degrees(+03.52731514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18501"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.34428430),
        dec: Angle.Degrees(+03.52790747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117474",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17024 AB"},
        {"Henry Draper", "HD 223403"},
        {"Hipparcos Number", "HIP 117474"},
        {"Smithsonian Astrophysical Observation", "SAO 128399"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.30403579),
        dec: Angle.Degrees(+03.52864998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179018"},
        {"Hipparcos Number", "HIP 94215"},
        {"Geneva Identification System", "GEN# +1.00179018"},
        {"Smithsonian Astrophysical Observation", "SAO 124347"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.70078842),
        dec: Angle.Degrees(+03.53086894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217590"},
        {"Hipparcos Number", "HIP 113705"},
        {"Geneva Identification System", "GEN# +1.00217590"},
        {"Smithsonian Astrophysical Observation", "SAO 127908"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.43150931),
        dec: Angle.Degrees(+03.53103820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110802"},
        {"Hipparcos Number", "HIP 62178"},
        {"Geneva Identification System", "GEN# +1.00110802"},
        {"Smithsonian Astrophysical Observation", "SAO 119567"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.14537678),
        dec: Angle.Degrees(+03.53166480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96681"},
        {"Hipparcos Number", "HIP 54425"},
        {"Fundamental Katalog 5th Edition", "FK5 4986"},
        {"Smithsonian Astrophysical Observation", "SAO 118679"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.05714898),
        dec: Angle.Degrees(+03.53337461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14602 APBC"},
        {"Henry Draper", "HD 200660"},
        {"Hipparcos Number", "HIP 104047"},
        {"Smithsonian Astrophysical Observation", "SAO 126523"},
    },
    visualMagnitude: 7.63,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.18796654),
        dec: Angle.Degrees(+03.53389408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6751",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1148 A"},
        {"Henry Draper", "HD 8803"},
        {"Hipparcos Number", "HIP 6751"},
        {"Geneva Identification System", "GEN# +1.00008803A"},
        {"Smithsonian Astrophysical Observation", "SAO 109895"},
        {"Wilson Evans Batten Catalogue", "WEB 1472"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.72311866),
        dec: Angle.Degrees(+03.53568617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14350"},
        {"Hipparcos Number", "HIP 10813"},
        {"Geneva Identification System", "GEN# +1.00014350"},
        {"Smithsonian Astrophysical Observation", "SAO 110470"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.79310855),
        dec: Angle.Degrees(+03.53686039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249714"},
        {"Hipparcos Number", "HIP 28192"},
        {"Smithsonian Astrophysical Observation", "SAO 113295"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.36913711),
        dec: Angle.Degrees(+03.53787688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9000 AB"},
        {"Henry Draper", "HD 119425"},
        {"Hipparcos Number", "HIP 66936"},
        {"Geneva Identification System", "GEN# +1.00119425J"},
        {"Smithsonian Astrophysical Observation", "SAO 120082"},
        {"Wilson Evans Batten Catalogue", "WEB 11798"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.76618427),
        dec: Angle.Degrees(+03.53807968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245680"},
        {"Hipparcos Number", "HIP 26421"},
        {"Smithsonian Astrophysical Observation", "SAO 112968"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.34483878),
        dec: Angle.Degrees(+03.53954566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77777"},
        {"Hipparcos Number", "HIP 44552"},
        {"Smithsonian Astrophysical Observation", "SAO 117398"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.16547762),
        dec: Angle.Degrees(+03.54109061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141208"},
        {"Hipparcos Number", "HIP 77387"},
        {"Smithsonian Astrophysical Observation", "SAO 121194"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.95941770),
        dec: Angle.Degrees(+03.54303919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135004"},
        {"Hipparcos Number", "HIP 74435"},
        {"Geneva Identification System", "GEN# +1.00135004"},
        {"Smithsonian Astrophysical Observation", "SAO 120893"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.18803315),
        dec: Angle.Degrees(+03.54409024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25142",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3962 A"},
        {"Henry Draper", "HD 35149"},
        {"Hipparcos Number", "HIP 25142"},
        {"Celescope Catalog", "CEL 659"},
        {"Geneva Identification System", "GEN# +1.00035149A"},
        {"Smithsonian Astrophysical Observation", "SAO 112697"},
        {"Wilson Evans Batten Catalogue", "WEB 4876"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.70833880),
        dec: Angle.Degrees(+03.54444809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84486"},
        {"Hipparcos Number", "HIP 47897"},
        {"Geneva Identification System", "GEN# +1.00084486"},
        {"Smithsonian Astrophysical Observation", "SAO 117894"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.43040210),
        dec: Angle.Degrees(+03.54468845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73713"},
        {"Hipparcos Number", "HIP 42493"},
        {"Smithsonian Astrophysical Observation", "SAO 117003"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.94217319),
        dec: Angle.Degrees(+03.54497553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122603"},
        {"Hipparcos Number", "HIP 68619"},
        {"Geneva Identification System", "GEN# +1.00122603"},
        {"Smithsonian Astrophysical Observation", "SAO 120252"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.69887450),
        dec: Angle.Degrees(+03.54575930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87601"},
        {"Hipparcos Number", "HIP 49483"},
        {"Geneva Identification System", "GEN# +1.00087601"},
        {"Smithsonian Astrophysical Observation", "SAO 118101"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.54326930),
        dec: Angle.Degrees(+03.54692821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115216"},
        {"Hipparcos Number", "HIP 64697"},
        {"Smithsonian Astrophysical Observation", "SAO 119835"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.90292800),
        dec: Angle.Degrees(+03.54725024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89011"},
        {"Hipparcos Number", "HIP 50299"},
        {"Smithsonian Astrophysical Observation", "SAO 118193"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.04989778),
        dec: Angle.Degrees(+03.54917282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10172"},
        {"Hipparcos Number", "HIP 7732"},
        {"Smithsonian Astrophysical Observation", "SAO 110035"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.89199133),
        dec: Angle.Degrees(+03.55086647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25145",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3962 B"},
        {"Henry Draper", "HD 35148"},
        {"Hipparcos Number", "HIP 25145"},
        {"Geneva Identification System", "GEN# +1.00035148"},
        {"Smithsonian Astrophysical Observation", "SAO 112699"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.71264315),
        dec: Angle.Degrees(+03.55222037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216400"},
        {"Hipparcos Number", "HIP 112950"},
        {"Smithsonian Astrophysical Observation", "SAO 127811"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.13694746),
        dec: Angle.Degrees(+03.55223823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90983"},
        {"Hipparcos Number", "HIP 51436"},
        {"Smithsonian Astrophysical Observation", "SAO 118338"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.56983397),
        dec: Angle.Degrees(+03.55248228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43075"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.60507413),
        dec: Angle.Degrees(+03.55283978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37766"},
        {"Geneva Identification System", "GEN# +9.80050004"},
        {"Geneva Identification System 2", "GEN# +6.10010285"},
        {"Wilson Evans Batten Catalogue", "WEB 7464"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.16823269),
        dec: Angle.Degrees(+03.55354943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -344.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -450.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103577"},
        {"Cincinnati Publication", "Ci 20 1249"},
        {"Geneva Identification System", "GEN# +9.80025011"},
    },
    visualMagnitude: 12.03,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.78484448),
        dec: Angle.Degrees(+03.55438416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 328.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -723.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160346"},
        {"Hipparcos Number", "HIP 86400"},
        {"Cincinnati Publication", "Ci 18 2350"},
        {"Fundamental Katalog 5th Edition", "FK5 5549"},
        {"Geneva Identification System", "GEN# +1.00160346"},
        {"Smithsonian Astrophysical Observation", "SAO 122610"},
        {"Wilson Evans Batten Catalogue", "WEB 14579"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.82092067),
        dec: Angle.Degrees(+03.55547760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120685"},
        {"Hipparcos Number", "HIP 67585"},
        {"Geneva Identification System", "GEN# +1.00120685"},
        {"Smithsonian Astrophysical Observation", "SAO 120135"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.72500101),
        dec: Angle.Degrees(+03.55554628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179494"},
        {"Hipparcos Number", "HIP 94402"},
        {"Geneva Identification System", "GEN# +1.00179494"},
        {"Smithsonian Astrophysical Observation", "SAO 124392"},
        {"Wilson Evans Batten Catalogue", "WEB 16451"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.19714938),
        dec: Angle.Degrees(+03.55742867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
